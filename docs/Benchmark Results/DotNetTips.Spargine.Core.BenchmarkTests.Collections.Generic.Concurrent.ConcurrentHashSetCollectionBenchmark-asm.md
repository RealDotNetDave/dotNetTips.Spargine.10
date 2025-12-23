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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA085D10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA085D10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFEAA085D10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEAA085D10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9D6E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FC42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FC42D0]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0850E0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA0850E0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845E8]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CA6E0B0008
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
       call      qword ptr [7FFEAA086FB8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FEEAF0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FEEAF0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFEA9FEEAF0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFEA9FEEAF0]
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFEA9D769E8]
       mov       ecx,54D0
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9EAC738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9EAC750]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FEEB08]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEA9FEEB08]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FEEAD8]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CF3CAF0008
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
       call      qword ptr [7FFEA9FEF168]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA085CE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA085CE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFEAA085CE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFEAA085CE0]
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFEA9D6E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FC4270]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FC4288]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0850B0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA0850B0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0845B8]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19DE6530008
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
       call      qword ptr [7FFEAA086F88]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5D88]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5D88]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L19
M00_L16:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L20
M00_L17:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5D88]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L13
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
       int       3
M00_L24:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5D88]
       jmp       short M00_L22
M00_L25:
       call      qword ptr [7FFEA9D8E700]
       mov       ecx,54D0
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97178A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97178A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FE43A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FE43C0]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0A5158]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA0A5158]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4660]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA9715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA9715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18E1F360008
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
       call      qword ptr [7FFEAA0A7030]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1A0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1A0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1A0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1A0]
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
       call      qword ptr [7FFEA9D7E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FD4288]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FD42A0]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDD1B8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEA9FDD1B8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27854DB0008
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
       call      qword ptr [7FFEAA097048]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDECD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDECD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDECD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDECD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9D7E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97078A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FD42A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FD42B8]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FD54A0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEA9FD54A0]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD5488]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA9705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E3A9340008
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
       call      qword ptr [7FFEAA097048]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FCED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FCED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFEA9FCED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEA9FCED00]
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
       call      qword ptr [7FFEA9D8E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97178A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA97178A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FC53B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9FC53C8]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FC6FE8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEA9FC6FE8]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6FD0]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA9715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA9715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20E7A610008
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
       call      qword ptr [7FFEAA0A7600]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9ECC348]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9ECC348]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L17
M00_L14:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L18
M00_L15:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
       int       3
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L17:
       mov       rcx,r14
       call      qword ptr [7FFEA9ECC348]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEA9ECC348]
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
       call      qword ptr [7FFEA9D6E5C8]
       mov       ecx,54D0
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA96F78A0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9EC65C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9EC65E0]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9EC7678]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEA9EC7678]
M00_L44:
       add       esi,1
       jo        short M00_L47
       cmp       esi,[rbp-2C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B38]
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
       call      00007FFF09348D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEA96F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20514320008
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
       call      qword ptr [7FFEAA0B7C18]
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
       mov       rcx,2D840800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0FE508A58
       mov       r8d,70285536
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
       call      qword ptr [7FFEA9FCCF90]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B37858]
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
       mov       r11,7FFEA96410B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96410C0
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
       mov       rcx,173C9400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,77E88E24
       mov       r8d,33CC91D
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
       call      qword ptr [7FFEA9FDCF78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96510C0
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
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1FE3A800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DF97EA97
       mov       r8d,919B04B7
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
       call      qword ptr [7FFEA9FDCF78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96510C0
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
       mov       rcx,29C69C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,72D4CEB
       mov       r8d,0BE0795C4
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
       call      qword ptr [7FFEA9FFCF60]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA96710B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96710C0
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
       mov       rcx,1ED30000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,37FE4E9A
       mov       r8d,0CF3368FE
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
       call      qword ptr [7FFEA9FDCAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA96710B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96710C0
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
       mov       rcx,22905000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6715FF04
       mov       r8d,0AE0E05A6
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
       call      qword ptr [7FFEA9FCD0F8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B37858]
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
       mov       r11,7FFEA96410B8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96410C0
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
       je        near ptr M00_L06
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L11
       mov       rcx,1D34E800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,681DF241
       mov       r8d,4C298FDC
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
       cmp       edx,4
       jb        short M00_L12
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
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEA9FDE088]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B67858]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       xor       ebp,ebp
       jmp       near ptr M00_L03
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
       mov       r11,7FFEA96712C0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA96712C8
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
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,29013C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,64C68CDE
       mov       r8d,35AA87E6
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
       call      qword ptr [7FFEAA0F56B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA9671678
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FFEA9671680
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5F80]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEAA0B5F80]
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
       mov       rcx,2AD04002AC0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5F80]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFEAA0B5F80]
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
       mov       rdx,2AD04002AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AD04002AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA99A7E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99A79D8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0BF318]
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
       mov       r11,7FFEA9670F98
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9670FA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9670FA8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9670FB0
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
       call      00007FFF092F6030
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEAA0B5F80]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEAA0B5F80]
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
       jmp       near ptr M00_L76
M00_L61:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L63
       mov       rcx,r12
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L64
M00_L62:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L65
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L64:
       mov       rcx,r12
       call      qword ptr [7FFEAA0B5F80]
       jmp       short M00_L62
M00_L65:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L71
M00_L68:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L72
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
       int       3
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L71:
       mov       rcx,r13
       call      qword ptr [7FFEAA0B5F80]
       jmp       short M00_L68
M00_L72:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L67
       jmp       near ptr M00_L51
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
       mov       rax,[rbp-88]
M00_L76:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFEA9FFD0B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFEAA0BF330]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AC5D88
       call      qword ptr [7FFEA99A7768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B67900]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0B53C8]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FFD128]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2ED99006FB8
       mov       r8,2ED99006FB8
       call      qword ptr [7FFEA9FF42E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0B53C8]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
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
       mov       r11,7FFEA9670FB0
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0B53C8]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0B53C8]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B48D0]
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
       call      qword ptr [7FFEAA0B54E8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEAA086028]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEAA086028]
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
       mov       rcx,1D7CF802AC0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA086028]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFEAA086028]
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
       mov       rdx,1D7CF802AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA96F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D7CF802AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA9977E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99779D8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA08E820]
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
       mov       r11,7FFEA9640F90
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L39:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9640F98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9640FA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9640FA8
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
       call      00007FFF092F6030
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEAA086028]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEAA086028]
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
       jmp       near ptr M00_L76
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFEAA086028]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFEAA086028]
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
       mov       rax,[rbp-88]
M00_L76:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFEA9FCD0E0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFEAA08E838]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9A95D88
       call      qword ptr [7FFEA9977768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B37900]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0853F8]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FCD158]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,218649E6FB8
       mov       r8,218649E6FB8
       call      qword ptr [7FFEA9FC42D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0853F8]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
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
       mov       r11,7FFEA9640FA8
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0853F8]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0853F8]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084900]
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
       call      qword ptr [7FFEAA085500]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEAA095FE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEAA095FE0]
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
       mov       rcx,1D2FE400AC8
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA095FE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFEAA095FE0]
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
       mov       rdx,1D2FE400AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D2FE400AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA9987E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99879D8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA09E7F0]
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
       mov       r11,7FFEA9651110
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9651118
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9651120
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9651128
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
       call      00007FFF092F6030
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEAA095FE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEAA095FE0]
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
       jmp       near ptr M00_L76
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L65
M00_L62:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L66
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFEAA095FE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L70
M00_L68:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L71
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
       int       3
M00_L70:
       mov       rcx,r12
       call      qword ptr [7FFEAA095FE0]
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
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L74
M00_L75:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L76:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFEA9FDD098]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFEAA09E808]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B47900]
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
       call      00007FFF092F6030
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
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0953B0]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FDD110]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2137D336FB8
       mov       r8,2137D336FB8
       call      qword ptr [7FFEA9FD4288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0953B0]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
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
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L95
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9651128
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
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0953B0]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
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
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0953B0]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0948B8]
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
; Total bytes of code 2776
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
       call      qword ptr [7FFEAA0954D0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,256DB002AC0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L28:
       mov       rcx,r13
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rdx,256DB002AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,256DB002AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA9997E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rdi],rdx
       jne       short M00_L35
       mov       edx,[rdi+10]
       mov       rcx,[rdi+8]
       cmp       [rcx+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99979D8]
       int       3
M00_L34:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0AE820]
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
       mov       r11,7FFEA9660F90
       call      qword ptr [r11]
       mov       [rbp-0B0],rax
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9660F98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9660FA0
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9660FA8
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
       call      00007FFF092F6030
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jmp       near ptr M00_L76
M00_L61:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L63
       mov       rcx,r12
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L64
M00_L62:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L65
M00_L63:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L64:
       mov       rcx,r12
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L62
M00_L65:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L71
M00_L68:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L72
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
       int       3
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L71:
       mov       rcx,r13
       call      qword ptr [7FFEAA0A5FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L72:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L67
       jmp       near ptr M00_L51
M00_L73:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L74:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-0B8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-90]
       jne       short M00_L74
M00_L75:
       mov       r8,[rbp-0A0]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L76:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L81
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-0A0],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L75
       jmp       near ptr M00_L73
M00_L77:
       call      qword ptr [7FFEA9FED008]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L78
       call      qword ptr [7FFEAA0AE838]
       mov       rbx,rax
M00_L78:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B57900]
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
       call      00007FFF092F6030
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
M00_L85:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0A53F8]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FED080]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29770006FB8
       mov       r8,29770006FB8
       call      qword ptr [7FFEA9FE42E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0A53F8]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
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
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L95
       mov       rcx,[rbp-0B0]
       mov       r11,7FFEA9660FA8
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
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L103
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L102
       mov       rcx,r15
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0A53F8]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
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
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L117
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L116
       mov       rcx,r15
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEAA0A53F8]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4900]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA0A5518]
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
       je        near ptr M00_L23
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L23
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jge       near ptr M00_L34
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,20A7F800AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L35
M00_L13:
       test      rdi,rdi
       je        short M00_L17
       xor       r15d,r15d
       mov       r13d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rdi],rdx
       jne       near ptr M00_L36
       lea       r12,[rdi+10]
       mov       eax,[rdi+8]
M00_L14:
       test      r13d,r13d
       je        short M00_L20
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
       mov       ecx,11
       call      qword ptr [7FFEA9997E28]
       int       3
M00_L18:
       mov       r8d,[r12+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [r14+18],rdx
       jne       near ptr M00_L40
       add       r15d,r8d
       jo        near ptr M00_L41
M00_L19:
       add       rdi,4
       dec       r13d
       jne       short M00_L18
       jmp       short M00_L16
M00_L20:
       mov       rcx,rdi
       mov       r11,7FFEA9661150
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L21:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9661158
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9661160
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L21
M00_L22:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9661168
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L26
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L25
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L27
M00_L24:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L28
M00_L25:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
       nop       dword ptr [rax]
M00_L28:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       test      r14d,r14d
       jle       short M00_L23
       jmp       near ptr M00_L05
M00_L29:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L31
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L32
M00_L30:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L33
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L32:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L30
M00_L33:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L41
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L34:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L29
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,20A7F800AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20A7F800AC8
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
       call      qword ptr [7FFEA99979D8]
       int       3
M00_L37:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0AE808]
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
       jmp       near ptr M00_L18
M00_L40:
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       near ptr M00_L19
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
       call      00007FFF092F6030
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
       je        near ptr M00_L65
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L65
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jge       near ptr M00_L64
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jl        short M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-88],rax
       xor       r8d,r8d
       jmp       near ptr M00_L74
M00_L61:
       call      qword ptr [7FFEA9FED098]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FFEA9FED518]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B57900]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L80
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L64:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       near ptr M00_L75
M00_L65:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L68
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L67
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L69
M00_L66:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L70
M00_L67:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L66
M00_L70:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       test      r15d,r15d
       jle       short M00_L65
       jmp       near ptr M00_L51
M00_L71:
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L72:
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
       jne       short M00_L72
M00_L73:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        short M00_L80
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L74:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       short M00_L81
       cmp       r8d,r12d
       jae       short M00_L79
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L73
       jmp       near ptr M00_L71
M00_L75:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L77
       mov       rcx,r12
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L78
M00_L76:
       mov       dword ptr [rbp-64],1
       jmp       near ptr M00_L63
M00_L77:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
       int       3
M00_L78:
       mov       rcx,r12
       call      qword ptr [7FFEA9FED440]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L76
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FED458]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FED110]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24AFE726FB8
       mov       r8,24AFE726FB8
       call      qword ptr [7FFEA9FE42A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FED458]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
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
       mov       r11,7FFEA9661168
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FED458]
M00_L101:
       add       r14d,1
       jo        short M00_L104
       cmp       r14d,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FED458]
M00_L115:
       add       edi,1
       jo        short M00_L118
       cmp       edi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FED428]
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
; Total bytes of code 2754
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA0A5590]
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
       je        near ptr M00_L23
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L23
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       xchg      ax,ax
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
       jge       near ptr M00_L34
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,21022000AC8
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        short M00_L17
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L20
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
       mov       ecx,11
       call      qword ptr [7FFEA9997E28]
       int       3
M00_L18:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L19:
       add       rsi,4
       dec       r15d
       jne       short M00_L18
       jmp       short M00_L16
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFEA9661150
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA9661158
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA9661160
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L21
M00_L22:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA9661168
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L26
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L25
       mov       rcx,r14
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L27
M00_L24:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L28
M00_L25:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
       xchg      ax,ax
M00_L28:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L23
       jmp       near ptr M00_L05
M00_L29:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L31
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L32
M00_L30:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L33
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L32:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L30
M00_L33:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L34:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L29
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21022000AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21022000AC8
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
       call      qword ptr [7FFEA99979D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0AE838]
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
       jmp       near ptr M00_L18
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L19
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
       jae       near ptr M00_L89
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       edi,1
       jo        near ptr M00_L90
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
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L80
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
       jge       near ptr M00_L74
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
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
       jae       near ptr M00_L79
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
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
       jo        near ptr M00_L80
       or        edx,ecx
       jl        short M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L78
M00_L61:
       call      qword ptr [7FFEA9FED128]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FFEA9FED578]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AB5D88
       call      qword ptr [7FFEA9997768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9B57900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L67
M00_L64:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L68
M00_L65:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,r15
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L64
M00_L68:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L80
       test      r14d,r14d
       jle       short M00_L63
       jmp       near ptr M00_L51
M00_L69:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L71
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L72
M00_L70:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L73
M00_L71:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
       int       3
M00_L72:
       mov       rcx,r13
       call      qword ptr [7FFEA9FED4B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L70
M00_L73:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L74:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L69
M00_L75:
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L76:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       short M00_L79
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L80
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L76
M00_L77:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        short M00_L80
       mov       rcx,r8
M00_L78:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       short M00_L81
       cmp       r8d,r13d
       jae       short M00_L79
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L77
       jmp       short M00_L75
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L89
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       esi,1
       jo        near ptr M00_L90
       cmp       esi,[rbp-5C]
       jl        short M00_L82
M00_L84:
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
M00_L85:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FE54E8]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEA9FED1A0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,250A11B6FB8
       mov       r8,250A11B6FB8
       call      qword ptr [7FFEA9FE42E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FE54E8]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
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
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L95
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA9661168
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
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L103
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L102
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FE54E8]
M00_L101:
       add       edi,1
       jo        short M00_L104
       cmp       edi,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
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
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L117
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L116
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FE54E8]
M00_L115:
       add       esi,1
       jo        short M00_L118
       cmp       esi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE54D0]
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
; Total bytes of code 2742
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA0A55F0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,1EFAD802AC0
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
       mov       r11,7FFEA9651408
       call      qword ptr [r11]
       mov       [rbp-0A8],rax
M00_L20:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9651410
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9651418
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r15d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-0A8]
       mov       r11,7FFEA9651420
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r15
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L31:
       mov       rcx,r13
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9987E28]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1EFAD802AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EFAD802AC0
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
       call      qword ptr [7FFEA99879D8]
       int       3
M00_L37:
       add       rcx,10
       mov       [rbp-80],rcx
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA09FE28]
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
       call      00007FFF092F6030
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
       je        near ptr M00_L66
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L66
M00_L46:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L49:
       mov       rcx,r13
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jge       near ptr M00_L65
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jmp       short M00_L62
M00_L61:
       mov       r8,[rbp-98]
       add       r8d,1
       jo        near ptr M00_L79
       mov       rcx,r8
       mov       rax,[rbp-88]
M00_L62:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L80
       cmp       r8d,r12d
       jae       near ptr M00_L78
       mov       [rbp-98],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L61
       mov       r9d,edi
       mov       [rbp-90],r9
M00_L63:
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
       jne       short M00_L63
       jmp       near ptr M00_L61
M00_L64:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r13d,1
       jo        near ptr M00_L79
       cmp       r13d,edi
       jge       near ptr M00_L58
M00_L65:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       jmp       near ptr M00_L74
M00_L66:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       r15d,[rdi+8]
       jae       short M00_L69
       mov       ecx,r15d
       mov       r13,[rdi+rcx*8+10]
       test      r13,r13
       je        short M00_L68
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L70
M00_L67:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L71
M00_L68:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L69:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L70:
       mov       rcx,r13
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L67
M00_L71:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L79
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L79
       test      r15d,r15d
       jle       short M00_L66
       jmp       near ptr M00_L51
M00_L72:
       call      qword ptr [7FFEA9FCEA60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L73
       call      qword ptr [7FFEA9FCFD08]
       mov       rbx,rax
M00_L73:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AA5D88
       call      qword ptr [7FFEA9987768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFEA9B47900]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L74:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L76
       mov       rcx,r12
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L77
M00_L75:
       mov       dword ptr [rbp-64],1
       jmp       near ptr M00_L64
M00_L76:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
       int       3
M00_L77:
       mov       rcx,r12
       call      qword ptr [7FFEA9FCFBB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FC6EF8]
       jmp       near ptr M00_L44
M00_L85:
       call      qword ptr [7FFEA9FCEAD8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23042936FB8
       mov       r8,23042936FB8
       call      qword ptr [7FFEA9FC5D10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FC6EF8]
       jmp       near ptr M00_L82
M00_L87:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
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
       mov       r11,7FFEA9651420
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FC6EF8]
M00_L100:
       add       r14d,1
       jo        short M00_L103
       cmp       r14d,[rbp-3C]
       jl        short M00_L99
       jmp       short M00_L104
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L114
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFEA9FC6EF8]
M00_L114:
       add       edi,1
       jo        short M00_L117
       cmp       edi,[rbp-5C]
       jl        short M00_L113
       jmp       short M00_L118
M00_L115:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC6EE0]
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
; Total bytes of code 2767
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA095668]
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
       je        near ptr M00_L23
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L23
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       xchg      ax,ax
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
       jge       near ptr M00_L34
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,1E85FC00B70
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L35
M00_L13:
       test      rsi,rsi
       je        short M00_L17
       xor       r14d,r14d
       mov       r15d,1
       mov       rdx,offset MT_System.Int32[]
       cmp       [rsi],rdx
       jne       near ptr M00_L36
       lea       r13,[rsi+10]
       mov       eax,[rsi+8]
M00_L14:
       test      r15d,r15d
       je        short M00_L20
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
       mov       ecx,11
       call      qword ptr [7FFEA99A7E28]
       int       3
M00_L18:
       mov       r8d,[rsi+r13]
       mov       rdx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L40
       add       r14d,r8d
       jo        near ptr M00_L41
M00_L19:
       add       rsi,4
       dec       r15d
       jne       short M00_L18
       jmp       short M00_L16
M00_L20:
       mov       rcx,rsi
       mov       r11,7FFEA96717A8
       call      qword ptr [r11]
       mov       [rbp-0A0],rax
M00_L21:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA96717B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA96717B8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L21
M00_L22:
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA96717C0
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L23:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L26
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L25
       mov       rcx,r14
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L27
M00_L24:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L28
M00_L25:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
       xchg      ax,ax
M00_L28:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L41
       test      edi,edi
       jle       short M00_L23
       jmp       near ptr M00_L05
M00_L29:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L31
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L32
M00_L30:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L33
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L32:
       mov       rcx,r15
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L30
M00_L33:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L41
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L41
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L34:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L29
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E85FC00B68
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E85FC00B70
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
       call      qword ptr [7FFEA99A79D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-80],rax
       mov       [rbp-78],edx
       lea       rdx,[rbp-80]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA294A68]
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
       jmp       near ptr M00_L18
M00_L40:
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       near ptr M00_L19
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
       jae       near ptr M00_L89
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       jne       near ptr M00_L85
M00_L44:
       add       edi,1
       jo        near ptr M00_L90
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
       jl        near ptr M00_L90
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L86
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       r14d,r14d
       test      rsi,rsi
       je        near ptr M00_L67
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L67
M00_L46:
       xor       eax,eax
       mov       [rbp-60],eax
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L48
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        near ptr M00_L80
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
       jge       near ptr M00_L78
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r13
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        near ptr M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        near ptr M00_L80
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
       jae       near ptr M00_L79
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L80
       add       edx,1
       jo        near ptr M00_L80
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
       jo        near ptr M00_L80
       or        edx,ecx
       jl        near ptr M00_L65
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L64
M00_L61:
       mov       r9d,esi
       mov       [rbp-88],r9
M00_L62:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L79
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-0A8],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L80
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-88]
       jne       short M00_L62
M00_L63:
       mov       r8,[rbp-90]
       add       r8d,1
       jo        near ptr M00_L80
       mov       rcx,r8
M00_L64:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L81
       cmp       r8d,r13d
       jae       near ptr M00_L79
       mov       [rbp-90],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L63
       jmp       near ptr M00_L61
M00_L65:
       call      qword ptr [7FFEAA0D69E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFEAA0D6E20]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E27
       mov       rdx,7FFEA9AC5D88
       call      qword ptr [7FFEA99A7768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEA9B67900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       xor       eax,eax
       mov       [rbp-60],eax
       cmp       r14d,[rsi+8]
       jae       short M00_L70
       mov       eax,r14d
       mov       r15,[rsi+rax*8+10]
       test      r15,r15
       je        short M00_L69
       mov       rcx,r15
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L71
M00_L68:
       mov       dword ptr [rbp-60],1
       jmp       short M00_L72
M00_L69:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L71:
       mov       rcx,r15
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L68
M00_L72:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-5C],ecx
       add       r14d,1
       jo        short M00_L80
       test      r14d,r14d
       jle       short M00_L67
       jmp       near ptr M00_L51
M00_L73:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L75
       mov       rcx,r13
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L76
M00_L74:
       mov       dword ptr [rbp-64],1
       jmp       short M00_L77
M00_L75:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
       int       3
M00_L76:
       mov       rcx,r13
       call      qword ptr [7FFEA9EFC6D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L74
M00_L77:
       mov       ecx,[rbp-5C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-5C],ecx
       add       r15d,1
       jo        short M00_L80
       cmp       r15d,esi
       jge       near ptr M00_L58
M00_L78:
       xor       eax,eax
       mov       [rbp-64],eax
       jmp       short M00_L73
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L81:
       xor       esi,esi
       cmp       dword ptr [rbp-5C],0
       jle       short M00_L84
M00_L82:
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L89
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L88
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       jne       near ptr M00_L87
M00_L83:
       add       esi,1
       jo        near ptr M00_L90
       cmp       esi,[rbp-5C]
       jl        short M00_L82
M00_L84:
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
M00_L85:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9EF7678]
       jmp       near ptr M00_L44
M00_L86:
       call      qword ptr [7FFEAA0D6A60]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,228DEE06FB8
       mov       r8,228DEE06FB8
       call      qword ptr [7FFEA9EF65C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L87:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9EF7678]
       jmp       near ptr M00_L83
M00_L88:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
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
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L95
       mov       rcx,[rbp-0A0]
       mov       r11,7FFEA96717C0
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
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L105
M00_L100:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L103
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L102
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9EF7678]
M00_L101:
       add       edi,1
       jo        short M00_L104
       cmp       edi,[rbp-3C]
       jl        short M00_L100
       jmp       short M00_L105
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
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
       xor       esi,esi
       cmp       esi,[rbp-5C]
       jge       short M00_L119
M00_L114:
       mov       rcx,[rbp-98]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L117
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L116
       mov       rcx,r14
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L115
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9EF7678]
M00_L115:
       add       esi,1
       jo        short M00_L118
       cmp       esi,[rbp-5C]
       jl        short M00_L114
       jmp       short M00_L119
M00_L116:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B38]
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
; Total bytes of code 2750
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEA9EF7798]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5CE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5CE0]
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
       mov       rax,110C8402AC0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5CE0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5CE0]
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
       mov       rdx,110C8402AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,110C8402AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA9997E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99979D8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-60],rax
       mov       [rbp-58],edx
       lea       rdx,[rbp-60]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFEAA0AF030]
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
       mov       r11,7FFEA96610F8
       call      qword ptr [r11]
       mov       [rbp-70],rax
M00_L39:
       mov       rcx,[rbp-70]
       mov       r11,7FFEA9661100
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-70]
       mov       r11,7FFEA9661108
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-70]
       mov       r11,7FFEA9661110
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0A5128]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
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
       mov       r11,7FFEA9661110
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEAA0A5128]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-34]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4630]
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
       call      qword ptr [7FFEAA0A5248]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5CF8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5CF8]
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
       mov       rax,261AF400AC8
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5CF8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5CF8]
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
       mov       rdx,261AF400AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,261AF400AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA99A7E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99A79D8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0BF018]
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
       mov       r11,7FFEA9670F78
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F80
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F88
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F90
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0B5140]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
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
       mov       r11,7FFEA9670F90
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEAA0B5140]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4648]
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
       call      qword ptr [7FFEAA0B5260]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5D28]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5D28]
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
       mov       rax,1E9C7400AC8
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5D28]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5D28]
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
       mov       rdx,1E9C7400AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E9C7400AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA99A7E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99A79D8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0BE520]
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
       mov       r11,7FFEA96710F0
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA96710F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9671100
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9671108
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0B5170]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
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
       mov       r11,7FFEA9671108
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEAA0B5170]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4678]
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
       call      qword ptr [7FFEAA0B5290]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5D58]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5D58]
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
       mov       rax,1A546802AC0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEAA0B5D58]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFEAA0B5D58]
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
       mov       rdx,1A546802AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A546802AC0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,11
       call      qword ptr [7FFEA99A7E28]
       int       3
M00_L33:
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rdx
       jne       short M00_L35
       mov       edx,[rsi+10]
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jae       short M00_L34
       call      qword ptr [7FFEA99A79D8]
       int       3
M00_L34:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA0BE4F0]
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
       mov       r11,7FFEA9670F70
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L39:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L40
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F80
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L39
M00_L40:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9670F88
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0B5128]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
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
       mov       r11,7FFEA9670F88
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEAA0B5128]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4630]
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
       call      qword ptr [7FFEAA0B5248]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,194D3802AC0
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
       mov       r11,7FFEA9651130
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651138
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651140
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651148
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9987E28]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,194D3802AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,194D3802AC0
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
       call      qword ptr [7FFEA99879D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA09E4F0]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDD260]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
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
       mov       r11,7FFEA9651148
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FDD260]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD1D0]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA0952C0]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,20E7A002AC0
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
       mov       r11,7FFEA9651130
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651138
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651140
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651148
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDD1A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFEA9FDD1A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9987E28]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20E7A002AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20E7A002AC0
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
       call      qword ptr [7FFEA99879D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA09E4D8]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDD218]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
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
       mov       r11,7FFEA9651148
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FDD218]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDD188]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEAA0952A8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9FBF9D8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9FBF9D8]
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
       mov       rax,229B1C00AC8
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
       mov       r11,7FFEA96413C8
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA96413D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFEA96413D8
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA96413E0
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFEA9FBF9D8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFEA9FBF9D8]
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
       call      qword ptr [7FFEA9977E28]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,229B1C00AC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA96F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,229B1C00AC8
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
       call      qword ptr [7FFEA99779D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA08FAF8]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FB71B0]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
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
       mov       r11,7FFEA96413E0
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9FB71B0]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FB7198]
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
       call      qword ptr [7FFEAA085308]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEA9EDC4E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEA9EDC4E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,27676C02B80
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
       mov       r11,7FFEA9651770
       call      qword ptr [r11]
       mov       [rbp-78],rax
M00_L20:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651778
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L21
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651780
       call      qword ptr [r11]
       mov       r8d,eax
       mov       edx,r14d
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r14d,eax
       jmp       short M00_L20
M00_L21:
       mov       rcx,[rbp-78]
       mov       r11,7FFEA9651788
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L26
M00_L23:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L27
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       mov       rcx,r14
       call      qword ptr [7FFEA9EDC4E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L31
M00_L29:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L32
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
       int       3
M00_L31:
       mov       rcx,r15
       call      qword ptr [7FFEA9EDC4E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFEA9987E28]
       int       3
M00_L35:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27676C02B78
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFEA9706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27676C02B80
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
       call      qword ptr [7FFEA99879D8]
       int       3
M00_L37:
       add       rax,10
       mov       [rbp-68],rax
       mov       [rbp-60],edx
       lea       rdx,[rbp-68]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFEAA274720]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9ED7870]
       jmp       short M00_L44
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
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
       mov       r11,7FFEA9651788
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFEA9ED7870]
M00_L60:
       add       edi,1
       jo        short M00_L63
       cmp       edi,[rbp-3C]
       jl        short M00_L59
       jmp       short M00_L64
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FFEA9ED6C58]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEA9ED78B8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA085C20]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA085C20]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFEAA085C20]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FFEAA085C20]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA085140]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA085140]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA095BD8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA095BD8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFEAA095BD8]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA095BD8]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA095020]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA095020]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5C50]
       jmp       short M00_L01
       nop       dword ptr [rax]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0A5020]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA0A5020]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
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
; Total bytes of code 919
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FFEAA0A5C50]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0A50F8]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFEAA0A50F8]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A4528]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFEAA095C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFEAA095C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFEAA095C50]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEAA095C50]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA095020]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFEAA095020]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFEA9FDEC40]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDEC40]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFEA9FDEC40]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEA9FDEC40]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDEC58]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFEA9FDEC58]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FDEC28]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFEA9FEED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFEA9FEED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFEA9FEED00]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEA9FEED00]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FE6568]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFEA9FE6568]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FE6550]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFEAA004048]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFEAA004048]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FFEAA004048]
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
       call      00007FFF09239E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FFEAA004048]
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9EF7660]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFEA9EF7660]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B20]
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
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,2C057400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C9A2D7A0
       mov       r11d,0E69F2259
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA094558]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEAA095C80]
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96510C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDCE58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095050]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095050]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094558]
       int       3
; Total bytes of code 1060
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
       mov       rcx,7FFEAA0DB290
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFEAA0DB288
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FDF468]
       int       3
M01_L01:
       mov       rcx,7FFEAA0DB28C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA096538]
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
       mov       r10,234E2C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0EF94D88B
       mov       r11d,0D6F29326
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA0945E8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FDD830]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96510C0
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
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDCEB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0950E0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0950E0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0945E8]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0DB360
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0DB358
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FDF4B0]
       int       3
M02_L01:
       mov       rcx,7FFEAA0DB35C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0965B0]
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
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,18FDC400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0D8D052C3
       mov       r11d,0F8CFA2C4
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
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA0B45E8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FFF330]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96710C0
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
       call      qword ptr [7FFEA97257D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FFCEB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA96710B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0B50E0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0B50E0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B45E8]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0FB2B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0FB2B0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FFF4B0]
       int       3
M02_L01:
       mov       rcx,7FFEAA0FB2B4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0B65B0]
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
       mov       r10,1B083C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C936C470
       mov       r11d,0A651D44A
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA0B4588]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FFD7D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96710C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFEA97257D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FFCF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA96710B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0B5080]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0B5080]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0B4588]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0FB280
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0FB278
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FFF498]
       int       3
M02_L01:
       mov       rcx,7FFEAA0FB27C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0B6550]
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
       mov       r10,16DD5400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,60BF0816
       mov       r11d,5E4D4284
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA0A45A0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FED7E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96610C0
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
       call      qword ptr [7FFEA97157D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FECF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B57858]
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
       mov       r11,7FFEA96610B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0A5098]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0A5098]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A45A0]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0EBDF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0EBDE8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FEF468]
       int       3
M02_L01:
       mov       rcx,7FFEAA0EBDEC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0A65F8]
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
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,212A4800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,26CC9AFC
       mov       r11d,0B11A75FA
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
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA0A45E8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEAA0A5D10]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96610C0
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
       call      qword ptr [7FFEA97157D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FED080]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B57858]
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
       mov       r11,7FFEA96610B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0A50E0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA0A50E0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEAA0A45E8]
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
       mov       rcx,7FFEAA0EBEF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FFEAA0EBEE8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FEF438]
       int       3
M01_L01:
       mov       rcx,7FFEAA0EBEEC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0A6658]
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
       mov       r10,187AF400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E152E656
       mov       r11d,6151ACA2
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9FC71C8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEAA094030]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA9651358
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
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FCECD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA9651350
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FC71E0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FC71E0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC71C8]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0F9078
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0F9070
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9EDDA58]
       int       3
M02_L01:
       mov       rcx,7FFEAA0F9074
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA096CE8]
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
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,1E662C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,990927FA
       mov       r11d,8C9A4F4E
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9EC6B20]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9ECC3A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA9641700
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA126DC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B37858]
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
       mov       r11,7FFEA96416F8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9EC7660]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9EC7660]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EC6B20]
       int       3
; Total bytes of code 1059
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEA9EC5590]
       int       3
M02_L01:
       call      qword ptr [7FFEA9FEE718]
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
       mov       r10,1DD5BC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,2A0147C4
       mov       r11d,0F4A594CE
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA094630]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FDD950]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96510C0
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
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDCFD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095128]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095128]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094630]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0DB260
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0DB258
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FDF480]
       int       3
M02_L01:
       mov       rcx,7FFEAA0DB25C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0965F8]
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
       mov       r10,23F4D800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,71AE78B1
       mov       r11d,0F2B60055
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA094528]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FDD890]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96510C0
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
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDCF30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095020]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095020]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094528]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0DB288
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0DB280
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FDF3F0]
       int       3
M02_L01:
       mov       rcx,7FFEAA0DB284
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0964F0]
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
       mov       r10,18178800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A93914BA
       mov       r11d,33D46B93
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
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9FFEA48]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FF5C80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA9650CF8
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FF53E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA9650CF0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FFEA60]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FFEA60]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FFEA48]
       int       3
; Total bytes of code 1053
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEF7343D78]
       int       3
M02_L01:
       call      qword ptr [7FFEF7343D80]
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
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,2C549800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,299FCC67
       mov       r11d,44E3724D
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA094558]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FDD7B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96510C0
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
       call      qword ptr [7FFEA97057D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDCE58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B47858]
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
       mov       r11,7FFEA96510B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095050]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA095050]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEAA094558]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0DB280
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0DB278
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FDF420]
       int       3
M02_L01:
       mov       rcx,7FFEAA0DB27C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA096520]
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
       mov       r10,155C3800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,535C35D8
       mov       r11d,0E2117067
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEAA084570]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FCD7D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96410C0
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
       call      qword ptr [7FFEA96F57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FCCE58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B37858]
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
       mov       r11,7FFEA96410B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA085068]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEAA085068]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEAA084570]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0CB028
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0CB020
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FCF438]
       int       3
M02_L01:
       mov       rcx,7FFEAA0CB024
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0865C8]
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
       mov       r10,26CF5C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,535C68B5
       mov       r11d,0BC765B94
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9FC5488]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FCD800]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA96410C0
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
       call      qword ptr [7FFEA96F57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FCCEA0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B37858]
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
       mov       r11,7FFEA96410B8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FC54A0]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FC54A0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FC5488]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA0CB150
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA0CB148
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9FCF468]
       int       3
M02_L01:
       mov       rcx,7FFEAA0CB14C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0865B0]
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
       mov       r10,19AB7000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,2D3AC545
       mov       r11d,3EDA306C
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9FD6820]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9FDF828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA9661328
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
       call      qword ptr [7FFEA97157D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEA9FDE310]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B57858]
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
       mov       r11,7FFEA9661320
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FD6838]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9FD6838]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEA9FD6820]
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rcx,7FFEAA108B50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FFEAA108B48
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEA9EEE838]
       int       3
M02_L01:
       mov       rcx,7FFEAA108B4C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFEAA0A6C10]
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
       mov       r10,228E1C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,44963859
       mov       r11d,9BCE95FA
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
       call      00007FFF09239E20
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
       call      qword ptr [7FFEA9EF6B68]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFEA9EFC378]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FFEA9671700
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
       call      00007FFF092F6030
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
       call      qword ptr [7FFEAA0D68B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEA9B67858]
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
       mov       r11,7FFEA96716F8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9EF76A8]
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
       call      00007FFF092F6030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFEA9EF76A8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFEA9EF6B68]
       int       3
; Total bytes of code 1050
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
       call      qword ptr [7FFEF7328018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFEF7328020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFEA9EF55D8]
       int       3
M02_L01:
       call      qword ptr [7FFEAA00E5F8]
       int       3
; Total bytes of code 45
```

