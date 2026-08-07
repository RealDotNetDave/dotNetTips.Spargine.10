## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-98],xmm4
       xor       eax,eax
       mov       [rbp-88],rax
       mov       [rbp+10],rcx
       mov       r11,[rcx+2E0]
       mov       [rbp-90],r11
       mov       rbx,[rcx+2D8]
       cmp       [r11],r11b
       test      rbx,rbx
       je        near ptr M00_L93
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L98
       mov       rax,[rbx+8]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L94
       mov       esi,[rax+10]
M00_L00:
       test      esi,esi
       je        near ptr M00_L97
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L96
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L95
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-88],rsi
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-88]
       cmp       [rsi],rcx
       jne       near ptr M00_L88
       lea       rbx,[rsi+8]
       mov       rcx,[rbx]
       mov       edx,[rbx+10]
       mov       rax,[rbx]
       cmp       edx,[rax+14]
       jne       near ptr M00_L87
       mov       edx,[rbx+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L74
       mov       rcx,[rcx+8]
       mov       edx,[rbx+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L90
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rsi+10]
M00_L03:
       test      rbx,rbx
       je        short M00_L02
       mov       r11,[rbp-90]
       mov       rcx,[r11+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L83
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M00_L76
       mov       rcx,1E892C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L82
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,149FB0D3
       mov       r8d,69DDED0C
       cmp       edx,8
       jb        near ptr M00_L77
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L78
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M00_L07:
       mov       [rbp-98],rbx
       mov       [rbp-40],eax
M00_L08:
       mov       r11,[rbp-90]
       mov       rbx,[r11+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r8,[rbx+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-40]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       cmp       edi,[r8+8]
       jae       near ptr M00_L90
       mov       ecx,edi
       mov       rcx,[r8+rcx*8+10]
       mov       [rbp-0A0],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M00_L14
       mov       rcx,[rbp-0A0]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M00_L15
M00_L09:
       mov       dword ptr [rbp-44],1
       mov       r11,[rbp-90]
       cmp       rbx,[r11+10]
       jne       near ptr M00_L85
       mov       r14d,[rbp-40]
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        short M00_L12
M00_L10:
       cmp       r14d,[r15+18]
       je        near ptr M00_L16
M00_L11:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L10
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r13,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],r14d
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L17
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M00_L18
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L17
       nop       dword ptr [rax]
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       r11,[rbp-90]
       cmp       ecx,[r11+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M00_L13:
       movzx     esi,r13b
       jmp       short M00_L19
M00_L14:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L15:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE2D3EEC10]
       jmp       near ptr M00_L09
       nop       dword ptr [rax]
M00_L16:
       mov       rcx,[r11+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-98]
       mov       r11,7FFE2CB51588
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-90]
       je        near ptr M00_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M00_L13
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-0A0]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L84
M00_L20:
       test      esi,esi
       je        near ptr M00_L73
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       r11,[rbp-90]
       mov       rcx,[r11+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L51
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L51
M00_L21:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L23
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L25
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FFE2D3EEC10]
       jmp       short M00_L22
M00_L25:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-48],ecx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L21
M00_L26:
       mov       r11,[rbp-90]
       cmp       rbx,[r11+10]
       jne       near ptr M00_L70
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+8],0
       je        short M00_L28
M00_L27:
       mov       rcx,[rbx+18]
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L66
       movsxd    rcx,dword ptr [rcx+r9*4+10]
       add       rdx,rcx
       jo        near ptr M00_L67
       add       r9d,1
       jo        near ptr M00_L67
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       movsxd    r8,r9d
       cmp       rcx,r8
       jg        short M00_L27
M00_L28:
       mov       r9,[rbx+8]
       mov       ecx,[r9+8]
       shr       rcx,2
       cmp       rcx,rdx
       jg        near ptr M00_L58
       xor       edx,edx
       mov       [rbp-58],edx
       mov       edx,[r9+8]
       lea       r9,[rbp-58]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D3E64F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L61
       mov       esi,[rbp-58]
       xor       edi,edi
M00_L29:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r11,[rbp-90]
       mov       rcx,[r11+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M00_L35
       test      r13,r13
       je        near ptr M00_L45
       cmp       [r13+8],r14d
       jl        near ptr M00_L45
M00_L30:
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L32
       mov       [rbp-0A8],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L33
M00_L31:
       mov       dword ptr [rbp-5C],1
       jmp       short M00_L34
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L33:
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFE2D3EEC10]
       jmp       short M00_L31
M00_L34:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L30
M00_L35:
       mov       r11,[rbp-90]
       cmp       byte ptr [r11+1C],0
       je        near ptr M00_L62
       mov       r14,[rbx+10]
       cmp       dword ptr [r14+8],400
       jge       near ptr M00_L62
       mov       edx,[r14+8]
       imul      rdx,2
       jo        near ptr M00_L67
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r14
       mov       r14d,[r14+8]
       test      rcx,rcx
       je        near ptr M00_L68
       mov       rdx,[rcx]
       cmp       rdx,[r13]
       jne       near ptr M00_L68
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L68
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L68
       cmp       r14d,[r13+8]
       ja        near ptr M00_L68
       mov       r8d,r14d
       movzx     eax,word ptr [rdx]
       imul      r8,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[r13+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L65
       cmp       r8,4000
       ja        near ptr M00_L64
       mov       rdx,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L63
M00_L36:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r12d,[r13+8]
       cmp       r12,r14
       jle       short M00_L38
M00_L37:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r14,r12
       jae       near ptr M00_L66
       lea       rcx,[r13+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,1
       jo        near ptr M00_L67
       cmp       r12,r14
       jg        short M00_L37
M00_L38:
       mov       r14,r13
M00_L39:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       r8d,r8d
       jmp       short M00_L41
M00_L40:
       mov       rax,[rbp-80]
       add       eax,1
       jo        near ptr M00_L67
       mov       r8,rax
M00_L41:
       mov       rax,[rbx+8]
       mov       edx,[rax+8]
       movsxd    rcx,r8d
       cmp       rdx,rcx
       jle       near ptr M00_L43
       cmp       r8d,[rax+8]
       jae       near ptr M00_L66
       mov       [rbp-80],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M00_L40
M00_L42:
       mov       r9,[r10+10]
       mov       [rbp-0B8],r9
       mov       [rbp-0B0],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       [rbp-70],r11d
       mov       ecx,r11d
       mov       [rbp-68],r13d
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-60],ecx
       mov       eax,ecx
       cdq
       idiv      dword ptr [rbp-68]
       mov       [rbp-64],edx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       mov       r8,[rbp-0B0]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-6C],r8d
       mov       r10d,[rbp-60]
       cmp       r10d,[rbp-70]
       jae       near ptr M00_L66
       mov       r11d,r10d
       mov       [rbp-78],r11
       mov       rcx,[rsi+r11*8+10]
       mov       [rbp-0C8],rcx
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0C0]
       mov       ecx,[rbp-6C]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-60]
       cmp       ecx,[rbp-70]
       jae       near ptr M00_L66
       mov       rcx,[rbp-78]
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-64]
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rax],edx
       mov       r8,[rbp-0B8]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M00_L42
       jmp       near ptr M00_L40
M00_L43:
       mov       r9d,[rsi+8]
       mov       ebx,r9d
       mov       eax,ebx
       test      edi,edi
       jne       near ptr M00_L69
       cdq
       idiv      r13d
       cmp       eax,1
       jle       near ptr M00_L57
M00_L44:
       mov       r11,[rbp-90]
       mov       [r11+18],eax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-90]
       lea       rcx,[r11+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L70
M00_L45:
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L48
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L47
       mov       [rbp-0A8],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L49
M00_L46:
       mov       dword ptr [rbp-5C],1
       jmp       short M00_L50
M00_L47:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFE2D3EEC10]
       jmp       short M00_L46
M00_L50:
       mov       edx,[rbp-48]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-48],edx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L45
       jmp       near ptr M00_L35
M00_L51:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L54
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L55
M00_L52:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       mov       rcx,r14
       call      qword ptr [7FFE2D3EEC10]
       jmp       short M00_L52
M00_L56:
       mov       edx,[rbp-48]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-48],edx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L51
       jmp       near ptr M00_L26
M00_L57:
       mov       eax,1
       jmp       near ptr M00_L44
M00_L58:
       mov       r11,[rbp-90]
       movsxd    rcx,dword ptr [r11+18]
       imul      rcx,2
       jo        short M00_L67
       cmp       rcx,7FFFFFFF
       jle       short M00_L59
       mov       eax,7FFFFFFF
       jmp       short M00_L60
M00_L59:
       mov       rax,rcx
M00_L60:
       movsxd    rcx,eax
       cmp       rax,rcx
       jne       short M00_L67
       mov       [r11+18],eax
       jmp       short M00_L70
M00_L61:
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       near ptr M00_L29
M00_L62:
       mov       r14,[rbx+10]
       jmp       near ptr M00_L39
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L64:
       mov       rdx,rax
       call      qword ptr [7FFE2D2FC810]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L65:
       mov       rdx,rax
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L68:
       mov       [rsp+20],r14d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D246AD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L36
M00_L69:
       mov       eax,7FFFFFFF
       jmp       near ptr M00_L44
M00_L70:
       xor       ebx,ebx
       cmp       dword ptr [rbp-48],0
       jle       short M00_L73
M00_L71:
       mov       r11,[rbp-90]
       mov       rcx,[r11+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M00_L90
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        near ptr M00_L89
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L86
M00_L72:
       add       ebx,1
       jo        near ptr M00_L91
       cmp       ebx,[rbp-48]
       jl        short M00_L71
M00_L73:
       test      r15d,r15d
       je        near ptr M00_L02
       mov       eax,[rbp-3C]
       add       eax,1
       jo        near ptr M00_L91
       mov       [rbp-3C],eax
       jmp       near ptr M00_L02
M00_L74:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L92
M00_L75:
       mov       rcx,rsi
       mov       r11,7FFE2CB51560
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L76:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L77:
       cmp       edx,4
       jb        short M00_L79
M00_L78:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L79:
       mov       r10d,80
       test      dl,1
       je        short M00_L80
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L80:
       test      dl,2
       je        short M00_L81
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L81:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L82:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L83:
       mov       rdx,rbx
       mov       r11,7FFE2CB51580
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L84:
       mov       ecx,eax
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFE2D3EDB30]
       jmp       near ptr M00_L20
M00_L85:
       call      M00_L100
       jmp       near ptr M00_L08
M00_L86:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3EDB30]
       jmp       near ptr M00_L72
M00_L87:
       call      qword ptr [7FFE2CE2C168]
       int       3
M00_L88:
       mov       rcx,rsi
       mov       r11,7FFE2CB51558
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L75
       jmp       near ptr M00_L99
M00_L89:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L90:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L92:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       ecx,[rbp-3C]
       mov       [rax+38],ecx
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L93:
       call      qword ptr [7FFE2D1BF378]
       mov       ecx,2A41
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE277C8]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE277C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CC07888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE277C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D4A5AD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3EF150]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L94:
       mov       rcx,rax
       mov       r11,7FFE2CB51570
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L95:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E8A8C00C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L96:
       mov       rcx,rbx
       mov       r11,7FFE2CB51578
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L97:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E8A8C00C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L98:
       mov       rcx,rbx
       mov       r11,7FFE2CB51550
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L99:
       mov       rcx,rsi
       mov       r11,7FFE2CB51568
       call      qword ptr [r11]
       jmp       near ptr M00_L92
M00_L100:
       sub       rsp,38
       cmp       dword ptr [rbp-44],0
       je        short M00_L101
       cmp       qword ptr [rbp-0A0],0
       je        short M00_L102
       mov       rcx,[rbp-0A0]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFE2D3EDB30]
M00_L101:
       nop
       add       rsp,38
       ret
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-4C],0
       je        short M00_L103
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L104
       mov       [rbp-48],ecx
M00_L103:
       add       rsp,38
       ret
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-5C],0
       je        short M00_L105
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-48],ecx
M00_L105:
       add       rsp,38
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-4C],0
       je        short M00_L107
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-48],ecx
M00_L107:
       add       rsp,38
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-5C],0
       je        short M00_L109
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-48],ecx
M00_L109:
       add       rsp,38
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       xor       ebx,ebx
       cmp       ebx,[rbp-48]
       jge       short M00_L116
M00_L111:
       mov       r11,[rbp-90]
       mov       rcx,[r11+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M00_L114
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L113
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L112
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3EDB30]
M00_L112:
       add       ebx,1
       jo        short M00_L115
       cmp       ebx,[rbp-48]
       jl        short M00_L111
       jmp       short M00_L116
M00_L113:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDA10]
       int       3
M00_L114:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L115:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L116:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-88],0
       je        short M00_L117
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-88]
       cmp       [rsi],rcx
       je        short M00_L117
       mov       rcx,rsi
       mov       r11,7FFE2CB51568
       call      qword ptr [r11]
M00_L117:
       nop
       add       rsp,38
       ret
; Total bytes of code 3809
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
       call      qword ptr [7FFE2D3ECE70]
       int       3
M01_L01:
       call      qword ptr [7FFE2D3EFA80]
       int       3
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
; 				newLength = FindNextValidLength((currentLength * 2) + 1);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return newLength <= maxLength;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (OverflowException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			newLength = maxLength;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       imul      ecx,edx,2
       jo        near ptr M02_L02
       add       ecx,1
       jo        short M02_L02
       nop       dword ptr [rax]
       jmp       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       add       ecx,2
       jo        short M02_L02
M02_L01:
       mov       edx,55555556
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,92492493
       mov       eax,edx
       imul      ecx
       add       edx,ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       edx,[rax*8]
       sub       edx,eax
       mov       eax,ecx
       sub       eax,edx
       je        short M02_L00
       mov       [r9],ecx
       cmp       [r9],r8d
       setle     al
       movzx     eax,al
       mov       [rbp-4],eax
       jmp       short M02_L03
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L03:
       mov       eax,[rbp-4]
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       r9,[rbp+28]
       mov       r8d,[rbp+20]
       mov       [r9],r8d
       xor       eax,eax
       mov       [rbp-4],eax
       lea       rax,[M02_L03]
       add       rsp,28
       ret
; Total bytes of code 205
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L01
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M04_L01:
       vzeroupper
       ret
M04_L02:
       test      r8,r8
       je        short M04_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L01
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L01
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L01
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CC066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M05_L09
       test      rsi,rsi
       je        near ptr M05_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M05_L10
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M05_L07
       sub       edi,eax
       js        near ptr M05_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M05_L06
       sub       ebp,eax
       js        near ptr M05_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C67A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M05_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M05_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M05_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L15
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       r8,4000
       jbe       short M05_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L02
       jmp       near ptr M05_L14
M05_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L10:
       call      qword ptr [7FFE8C673788]
       mov       rbx,rax
       call      qword ptr [7FFE8C67ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFE8C691908]
       int       3
M05_L12:
       call      qword ptr [7FFE8C673550]
       mov       rdi,rax
       call      qword ptr [7FFE8C67DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L13:
       call      qword ptr [7FFE8C673550]
       mov       rbp,rax
       call      qword ptr [7FFE8C67DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L14:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L15:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFE8C673578]
       mov       rbx,rax
       call      qword ptr [7FFE8C67E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67C240]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22927D30008
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
       call      qword ptr [7FFE2D3EF738]
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
       jmp       qword ptr [7FFE2CC05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.AddRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       xor       eax,eax
       mov       [rbp-80],rax
       mov       [rbp+10],rcx
       mov       r11,[rcx+2E0]
       mov       [rbp-88],r11
       mov       rbx,[rcx+2D8]
       cmp       [r11],r11b
       test      rbx,rbx
       je        near ptr M00_L93
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L98
       mov       rax,[rbx+8]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L94
       mov       esi,[rax+10]
M00_L00:
       test      esi,esi
       je        near ptr M00_L97
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L96
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L95
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-80],rsi
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-80]
       cmp       [rsi],rcx
       jne       near ptr M00_L88
       lea       rbx,[rsi+8]
       mov       rcx,[rbx]
       mov       edx,[rbx+10]
       mov       rax,[rbx]
       cmp       edx,[rax+14]
       jne       near ptr M00_L87
       mov       edx,[rbx+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L74
       mov       rcx,[rcx+8]
       mov       edx,[rbx+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L90
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rsi+10]
M00_L03:
       test      rbx,rbx
       je        short M00_L02
       mov       r11,[rbp-88]
       mov       rcx,[r11+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L83
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M00_L76
       mov       rcx,1AD49400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L82
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,5D583D30
       mov       r8d,37DACFA1
       cmp       edx,8
       jb        near ptr M00_L77
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L78
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M00_L07:
       mov       [rbp-90],rbx
       mov       [rbp-40],eax
M00_L08:
       mov       r11,[rbp-88]
       mov       rbx,[r11+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r8,[rbx+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-40]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       cmp       edi,[r8+8]
       jae       near ptr M00_L90
       mov       ecx,edi
       mov       rcx,[r8+rcx*8+10]
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-98],0
       je        near ptr M00_L14
       mov       rcx,[rbp-98]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M00_L15
M00_L09:
       mov       dword ptr [rbp-44],1
       mov       r11,[rbp-88]
       cmp       rbx,[r11+10]
       jne       near ptr M00_L85
       mov       r14d,[rbp-40]
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        short M00_L12
M00_L10:
       cmp       r14d,[r15+18]
       je        near ptr M00_L16
M00_L11:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L10
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r13,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],r14d
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L17
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M00_L18
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L17
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       r11,[rbp-88]
       cmp       ecx,[r11+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M00_L13:
       movzx     esi,r13b
       jmp       short M00_L19
M00_L14:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L15:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3CF060]
       jmp       near ptr M00_L09
M00_L16:
       mov       rcx,[r11+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-90]
       mov       r11,7FFE2CB413B0
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-88]
       je        near ptr M00_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M00_L13
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L84
M00_L20:
       test      esi,esi
       je        near ptr M00_L73
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       r11,[rbp-88]
       mov       rcx,[r11+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L46
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L46
M00_L21:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L23
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L25
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FFE2D3CF060]
       jmp       short M00_L22
M00_L25:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-48],ecx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L21
M00_L26:
       mov       r11,[rbp-88]
       cmp       rbx,[r11+10]
       jne       near ptr M00_L70
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+8],0
       je        short M00_L28
M00_L27:
       mov       rcx,[rbx+18]
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L66
       movsxd    rcx,dword ptr [rcx+r9*4+10]
       add       rdx,rcx
       jo        near ptr M00_L67
       add       r9d,1
       jo        near ptr M00_L67
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       movsxd    r8,r9d
       cmp       rcx,r8
       jg        short M00_L27
M00_L28:
       mov       r9,[rbx+8]
       mov       ecx,[r9+8]
       shr       rcx,2
       cmp       rcx,rdx
       jg        near ptr M00_L59
       xor       edx,edx
       mov       [rbp-58],edx
       mov       edx,[r9+8]
       lea       r9,[rbp-58]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D3C6190]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L62
       mov       esi,[rbp-58]
       xor       edi,edi
M00_L29:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r11,[rbp-88]
       mov       rcx,[r11+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M00_L35
       test      r13,r13
       je        near ptr M00_L52
       cmp       [r13+8],r14d
       jl        near ptr M00_L52
M00_L30:
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L32
       mov       [rbp-0A0],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L33
M00_L31:
       mov       dword ptr [rbp-5C],1
       jmp       short M00_L34
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L33:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE2D3CF060]
       jmp       short M00_L31
M00_L34:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L30
M00_L35:
       mov       r11,[rbp-88]
       cmp       byte ptr [r11+1C],0
       je        near ptr M00_L43
       mov       r14,[rbx+10]
       cmp       dword ptr [r14+8],400
       jge       near ptr M00_L43
       mov       edx,[r14+8]
       imul      rdx,2
       jo        near ptr M00_L67
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r14
       mov       r14d,[r14+8]
       test      rcx,rcx
       je        near ptr M00_L68
       mov       rdx,[rcx]
       cmp       rdx,[r13]
       jne       near ptr M00_L68
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L68
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L68
       cmp       r14d,[r13+8]
       ja        near ptr M00_L68
       mov       r8d,r14d
       movzx     eax,word ptr [rdx]
       imul      r8,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[r13+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L65
       cmp       r8,4000
       ja        near ptr M00_L64
       mov       rdx,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L63
M00_L36:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r12d,[r13+8]
       cmp       r12,r14
       jle       short M00_L38
M00_L37:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r14,r12
       jae       near ptr M00_L66
       lea       rcx,[r13+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,1
       jo        near ptr M00_L67
       cmp       r12,r14
       jg        short M00_L37
M00_L38:
       mov       r14,r13
M00_L39:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       r8d,r8d
       jmp       short M00_L41
M00_L40:
       mov       rax,[rbp-78]
       add       eax,1
       jo        near ptr M00_L67
       mov       r8,rax
M00_L41:
       mov       rax,[rbx+8]
       mov       edx,[rax+8]
       movsxd    rcx,r8d
       cmp       rdx,rcx
       jle       near ptr M00_L44
       cmp       r8d,[rax+8]
       jae       near ptr M00_L66
       mov       [rbp-78],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M00_L40
M00_L42:
       mov       r9,[r10+10]
       mov       [rbp-0B0],r9
       mov       [rbp-0A8],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       [rbp-70],r11d
       mov       ecx,r11d
       mov       [rbp-68],r13d
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-60],ecx
       mov       eax,ecx
       cdq
       idiv      dword ptr [rbp-68]
       mov       [rbp-64],edx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-6C],r8d
       mov       r10d,[rbp-60]
       cmp       r10d,[rbp-70]
       jae       near ptr M00_L66
       mov       ecx,r10d
       mov       r11,[rsi+rcx*8+10]
       mov       [rbp-0C0],r11
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B8]
       mov       ecx,[rbp-6C]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-60]
       cmp       ecx,[rbp-70]
       jae       near ptr M00_L66
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-64]
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rax],edx
       mov       r8,[rbp-0B0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M00_L42
       jmp       near ptr M00_L40
M00_L43:
       mov       r14,[rbx+10]
       jmp       near ptr M00_L39
M00_L44:
       mov       r9d,[rsi+8]
       mov       ebx,r9d
       mov       eax,ebx
       test      edi,edi
       jne       near ptr M00_L69
       cdq
       idiv      r13d
       cmp       eax,1
       jle       near ptr M00_L58
M00_L45:
       mov       r11,[rbp-88]
       mov       [r11+18],eax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-88]
       lea       rcx,[r11+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L70
M00_L46:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L49
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L48
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r14
       call      qword ptr [7FFE2D3CF060]
       jmp       short M00_L47
M00_L51:
       mov       edx,[rbp-48]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-48],edx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L46
       jmp       near ptr M00_L26
M00_L52:
       xor       ecx,ecx
       mov       [rbp-5C],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L55
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L54
       mov       [rbp-0A0],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-5C],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE2D3CF060]
       jmp       short M00_L53
M00_L57:
       mov       edx,[rbp-48]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-48],edx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L52
       jmp       near ptr M00_L35
M00_L58:
       mov       eax,1
       jmp       near ptr M00_L45
M00_L59:
       mov       r11,[rbp-88]
       movsxd    rcx,dword ptr [r11+18]
       imul      rcx,2
       jo        short M00_L67
       cmp       rcx,7FFFFFFF
       jle       short M00_L60
       mov       eax,7FFFFFFF
       jmp       short M00_L61
M00_L60:
       mov       rax,rcx
M00_L61:
       movsxd    rcx,eax
       cmp       rax,rcx
       jne       short M00_L67
       mov       [r11+18],eax
       jmp       short M00_L70
M00_L62:
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       near ptr M00_L29
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L64:
       mov       rdx,rax
       call      qword ptr [7FFE2D2EC498]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L65:
       mov       rdx,rax
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L68:
       mov       [rsp+20],r14d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D236778]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L36
M00_L69:
       mov       eax,7FFFFFFF
       jmp       near ptr M00_L45
M00_L70:
       xor       ebx,ebx
       cmp       dword ptr [rbp-48],0
       jle       short M00_L73
M00_L71:
       mov       r11,[rbp-88]
       mov       rcx,[r11+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M00_L90
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        near ptr M00_L89
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L86
M00_L72:
       add       ebx,1
       jo        near ptr M00_L91
       cmp       ebx,[rbp-48]
       jl        short M00_L71
M00_L73:
       test      r15d,r15d
       je        near ptr M00_L02
       mov       eax,[rbp-3C]
       add       eax,1
       jo        near ptr M00_L91
       mov       [rbp-3C],eax
       jmp       near ptr M00_L02
M00_L74:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L92
M00_L75:
       mov       rcx,rsi
       mov       r11,7FFE2CB41388
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L76:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L77:
       cmp       edx,4
       jb        short M00_L79
M00_L78:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L79:
       mov       r10d,80
       test      dl,1
       je        short M00_L80
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L80:
       test      dl,2
       je        short M00_L81
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L81:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L82:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L83:
       mov       rdx,rbx
       mov       r11,7FFE2CB413A8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L84:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3CE1F0]
       jmp       near ptr M00_L20
M00_L85:
       call      M00_L100
       jmp       near ptr M00_L08
M00_L86:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3CE1F0]
       jmp       near ptr M00_L72
M00_L87:
       call      qword ptr [7FFE2CE1C138]
       int       3
M00_L88:
       mov       rcx,rsi
       mov       r11,7FFE2CB41380
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L75
       jmp       near ptr M00_L99
M00_L89:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L90:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L92:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       ecx,[rbp-3C]
       mov       [rax+38],ecx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L93:
       call      qword ptr [7FFE2D1AF120]
       mov       ecx,2A41
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3CD9C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3CD9E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L94:
       mov       rcx,rax
       mov       r11,7FFE2CB41398
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L95:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AD5F400C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L96:
       mov       rcx,rbx
       mov       r11,7FFE2CB413A0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L97:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AD5F400C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L98:
       mov       rcx,rbx
       mov       r11,7FFE2CB41378
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L99:
       mov       rcx,rsi
       mov       r11,7FFE2CB41390
       call      qword ptr [r11]
       jmp       near ptr M00_L92
M00_L100:
       sub       rsp,38
       cmp       dword ptr [rbp-44],0
       je        short M00_L101
       cmp       qword ptr [rbp-98],0
       je        short M00_L102
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3CE1F0]
M00_L101:
       nop
       add       rsp,38
       ret
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-4C],0
       je        short M00_L103
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L104
       mov       [rbp-48],ecx
M00_L103:
       add       rsp,38
       ret
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-5C],0
       je        short M00_L105
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-48],ecx
M00_L105:
       add       rsp,38
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-4C],0
       je        short M00_L107
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-48],ecx
M00_L107:
       add       rsp,38
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-5C],0
       je        short M00_L109
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-48],ecx
M00_L109:
       add       rsp,38
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       xor       ebx,ebx
       cmp       ebx,[rbp-48]
       jge       short M00_L116
M00_L111:
       mov       r11,[rbp-88]
       mov       rcx,[r11+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M00_L114
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L113
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L112
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3CE1F0]
M00_L112:
       add       ebx,1
       jo        short M00_L115
       cmp       ebx,[rbp-48]
       jl        short M00_L111
       jmp       short M00_L116
M00_L113:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CE100]
       int       3
M00_L114:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L115:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L116:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-80],0
       je        short M00_L117
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-80]
       cmp       [rsi],rcx
       je        short M00_L117
       mov       rcx,rsi
       mov       r11,7FFE2CB41390
       call      qword ptr [r11]
M00_L117:
       nop
       add       rsp,38
       ret
; Total bytes of code 3779
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
       call      qword ptr [7FFE2D3CCE70]
       int       3
M01_L01:
       call      qword ptr [7FFE2D3CFED0]
       int       3
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
; 				newLength = FindNextValidLength((currentLength * 2) + 1);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return newLength <= maxLength;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (OverflowException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			newLength = maxLength;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       imul      ecx,edx,2
       jo        near ptr M02_L02
       add       ecx,1
       jo        short M02_L02
       nop       dword ptr [rax]
       jmp       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       add       ecx,2
       jo        short M02_L02
M02_L01:
       mov       edx,55555556
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,92492493
       mov       eax,edx
       imul      ecx
       add       edx,ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       edx,[rax*8]
       sub       edx,eax
       mov       eax,ecx
       sub       eax,edx
       je        short M02_L00
       mov       [r9],ecx
       cmp       [r9],r8d
       setle     al
       movzx     eax,al
       mov       [rbp-4],eax
       jmp       short M02_L03
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L03:
       mov       eax,[rbp-4]
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       r9,[rbp+28]
       mov       r8d,[rbp+20]
       mov       [r9],r8d
       xor       eax,eax
       mov       [rbp-4],eax
       lea       rax,[M02_L03]
       add       rsp,28
       ret
; Total bytes of code 205
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L01
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M04_L01:
       vzeroupper
       ret
M04_L02:
       test      r8,r8
       je        short M04_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L01
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L01
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L01
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CBF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M05_L09
       test      rsi,rsi
       je        near ptr M05_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M05_L10
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M05_L07
       sub       edi,eax
       js        near ptr M05_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M05_L06
       sub       ebp,eax
       js        near ptr M05_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C67A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M05_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M05_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M05_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L15
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       r8,4000
       jbe       short M05_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L02
       jmp       near ptr M05_L14
M05_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L10:
       call      qword ptr [7FFE8C673788]
       mov       rbx,rax
       call      qword ptr [7FFE8C67ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFE8C691908]
       int       3
M05_L12:
       call      qword ptr [7FFE8C673550]
       mov       rdi,rax
       call      qword ptr [7FFE8C67DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L13:
       call      qword ptr [7FFE8C673550]
       mov       rbp,rax
       call      qword ptr [7FFE8C67DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L14:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L15:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFE8C673578]
       mov       rbx,rax
       call      qword ptr [7FFE8C67E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67C240]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EDDE510008
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
       call      qword ptr [7FFE2D3CFB88]
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
       jmp       qword ptr [7FFE2CBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2E0]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE2D423680
       call      qword ptr [7FFE2D3F6298]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-8],eax
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FFE2D3F62F8]; System.Array.Clear(System.Array, Int32, Int32)
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFE2D3F62F8]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FFE2CE3DA10]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6310]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 210
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE2D40AC10
       call      qword ptr [7FFE2CE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6340]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2E0]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE2D423680
       call      qword ptr [7FFE2D3F6370]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-8],eax
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F63B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FFE2D3F63D0]; System.Array.Clear(System.Array, Int32, Int32)
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFE2D3F63D0]; System.Array.Clear(System.Array, Int32, Int32)
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FFE2CE3DA10]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F63E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 210
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE2D40ACF8
       call      qword ptr [7FFE2CE37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6460]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01ACF8]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2E0]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE2D423690
       call      qword ptr [7FFE2D3F63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M01_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE2D40ACF8
       call      qword ptr [7FFE2CE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01ACF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       rax,[rbp+10]
       mov       r8,[rax+2E0]
       mov       rcx,[rbp+10]
       mov       rdx,7FFE2D423690
       call      qword ptr [7FFE2D3F63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var tables = this._tables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var locks = tables._locks;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var buckets = tables._buckets;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Array.Clear(buckets, 0, buckets.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, buckets.Length / lockCount);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       xor       eax,eax
       mov       [rbp-8],eax
       lea       rdx,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
       mov       rax,[rbp+10]
       mov       rax,[rax+10]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       mov       [rbp-14],eax
       mov       rax,[rbp-10]
       mov       rax,[rax+18]
       mov       r8d,[rax+8]
       mov       rax,[rbp-10]
       mov       rcx,[rax+18]
       xor       edx,edx
       call      qword ptr [7FFE2D3F6418]; System.Array.Clear(System.Array, Int32, Int32)
       mov       rax,[rbp-10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       r8d,[rax+8]
       mov       rcx,[rbp-20]
       xor       edx,edx
       call      qword ptr [7FFE2D3F6418]; System.Array.Clear(System.Array, Int32, Int32)
       mov       rax,[rbp-20]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [rbp-14]
       mov       edx,eax
       mov       ecx,1
       call      qword ptr [7FFE2CE3DA10]; System.Math.Max(Int32, Int32)
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       call      M01_L00
       nop
       mov       rcx,7FFE2D51D76C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,50
       pop       rbp
       ret
M01_L00:
       sub       rsp,28
       mov       rcx,7FFE2D51D768
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       [rbp-28],eax
       lea       rdx,[rbp-28]
       lea       r8,[rbp-8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6430]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32 ByRef, Int32 ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 241
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE2D40ACF8
       call      qword ptr [7FFE2CE37B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F64A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E0]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFE2D3DDD58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE2D3DDD58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rdi,[rsi+10]
       mov       rcx,[rdi+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rdi+18]
       mov       rdx,[rdi+18]
       mov       edx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L32
       lea       rax,[rcx+10]
       xor       r8d,r8d
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L34
       test      r9d,r9d
       jl        near ptr M00_L34
       lea       r8d,[r9+rdx]
       cmp       r8d,[rcx+8]
       ja        near ptr M00_L34
       movzx     ecx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rcx
       add       r8,rax
       mov       edx,edx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L30
       mov       rcx,r8
       call      qword ptr [7FFE2CBF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rdi,[rdi+8]
       mov       ecx,[rdi+8]
       lea       rdx,[rdi+10]
       xor       eax,eax
       mov       r8,[rdi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rdi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FFE2CBF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FFE2D23FBA0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFE2D3DDD58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FFE2D3DDD58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFE2D23FBA0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFE2CE1C258]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FFE2D496BE0]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+2E0]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D3DE190]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
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
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L57
M00_L52:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L55
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L54
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D3DE190]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE0A0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1262
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M02_L00
M02_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFE2D2F4540]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E0]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFE2D3DEF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE2D3DEF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rdi,[rsi+10]
       mov       rcx,[rdi+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rdi+18]
       mov       rdx,[rdi+18]
       mov       edx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L32
       lea       rax,[rcx+10]
       xor       r8d,r8d
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L34
       test      r9d,r9d
       jl        near ptr M00_L34
       lea       r8d,[r9+rdx]
       cmp       r8d,[rcx+8]
       ja        near ptr M00_L34
       movzx     ecx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rcx
       add       r8,rax
       mov       edx,edx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L30
       mov       rcx,r8
       call      qword ptr [7FFE2CBF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rdi,[rdi+8]
       mov       ecx,[rdi+8]
       lea       rdx,[rdi+10]
       xor       eax,eax
       mov       r8,[rdi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rdi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FFE2CBF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FFE2D23FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFE2D3DEF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FFE2D3DEF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFE2D23FB70]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFE2CE1C228]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FFE2D496D30]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+2E0]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D3DE118]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
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
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L57
M00_L52:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L55
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L54
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D3DE118]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE028]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1262
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M02_L00
M02_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFE2D2F4510]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E0]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFE2D2FEC10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE2D2FEC10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rdi,[rsi+10]
       mov       rcx,[rdi+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rdi+18]
       mov       rdx,[rdi+18]
       mov       edx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L32
       lea       rax,[rcx+10]
       xor       r8d,r8d
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L34
       test      r9d,r9d
       jl        near ptr M00_L34
       lea       r8d,[r9+rdx]
       cmp       r8d,[rcx+8]
       ja        near ptr M00_L34
       movzx     ecx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rcx
       add       r8,rax
       mov       edx,edx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L30
       mov       rcx,r8
       call      qword ptr [7FFE2CC157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rdi,[rdi+8]
       mov       ecx,[rdi+8]
       lea       rdx,[rdi+10]
       xor       eax,eax
       mov       r8,[rdi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rdi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FFE2CC157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FFE2D247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFE2D2FEC10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FFE2D2FEC10]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFE2D247E58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFE2CE3C258]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FFE2D4C7048]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+2E0]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2FEC28]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
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
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L57
M00_L52:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L55
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L54
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2FEC28]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D41E340]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1262
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L00
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       ja        short M02_L01
       test      dl,18
       jne       short M02_L05
       test      dl,4
       je        short M02_L06
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
M02_L00:
       pop       rbx
       ret
M02_L01:
       cmp       rdx,40
       jbe       short M02_L02
       cmp       rdx,400
       jbe       short M02_L07
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFE2D2F4540]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L03
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L04
M02_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       short M02_L00
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L03
M02_L05:
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rbx-8],rdx
       jmp       short M02_L00
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L00
       mov       word ptr [rbx-2],0
       jmp       short M02_L00
M02_L07:
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L02
       jmp       near ptr M02_L03
; Total bytes of code 227
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E0]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,[rsi+10]
       mov       rdi,[rcx+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L18
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FFE2D3075D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       edi,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L29
M00_L06:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE2D3075D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L35
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rdi,[rsi+10]
       mov       rcx,[rdi+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rdi+18]
       mov       rdx,[rdi+18]
       mov       edx,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L32
       lea       rax,[rcx+10]
       xor       r8d,r8d
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L34
       test      r9d,r9d
       jl        near ptr M00_L34
       lea       r8d,[r9+rdx]
       cmp       r8d,[rcx+8]
       ja        near ptr M00_L34
       movzx     ecx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rcx
       add       r8,rax
       mov       edx,edx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L30
       mov       rcx,r8
       call      qword ptr [7FFE2CC057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rdi,[rdi+8]
       mov       ecx,[rdi+8]
       lea       rdx,[rdi+10]
       xor       eax,eax
       mov       r8,[rdi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rdi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FFE2CC057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FFE2D24FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rdi+8]
       xor       edx,edx
       div       r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       [rsi+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L21
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L20
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFE2D3075D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L35
       test      r14d,r14d
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L26
       mov       rcx,r13
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L27:
       mov       rcx,r13
       call      qword ptr [7FFE2D3075D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L35
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L29:
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFE2D24FB58]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L31:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FFE2CE2C258]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FFE2D4C79D8]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L39
M00_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L42
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L41
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       edi,1
       jo        short M00_L43
       cmp       edi,[rbp-34]
       jl        short M00_L37
M00_L39:
       mov       rcx,[rbx+2E0]
       mov       [rbp-48],rcx
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D306388]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L44
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-34],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L46
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-34],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L48
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-34],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
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
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L57
M00_L52:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L55
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M00_L54
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D306388]
M00_L53:
       add       edi,1
       jo        short M00_L56
       cmp       edi,[rbp-34]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D306298]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1262
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M02_L00
M02_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFE2D306F28]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E59C8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E59B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D3E59F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E5A40]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3E5A10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D00AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E63B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D3E6400]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3E6448]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3E6418]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3D5EC0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D00AD10]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3D5EA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3D5F38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3D5F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+2E0]
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F63E8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01AD10]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F63D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
; 		return item is null ? false : this.TryRemove(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       qword ptr [rbp+18],0
       je        short M02_L00
       mov       rcx,7FFE2D51D2B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D3F6418]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
M02_L00:
       mov       rcx,7FFE2D51D2B4
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6460]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6430]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,20B83000068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,0F7DA92F0
       mov       ebx,66DA63FD
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L28
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FDFF8]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3FCCC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB614F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],bl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB614F0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FE0E8]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L29
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L29
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L30
       cmp       qword ptr [rbp-50],0
       je        short M00_L31
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L30
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FE0E8]
M00_L30:
       nop
       add       rsp,28
       ret
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FDFF8]
       int       3
; Total bytes of code 987
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FFE2CC58210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFE8C89E370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L01
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,25A5EC00068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,0BD7A4B7E
       mov       ebx,0C6392708
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L28
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FDF68]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3FEC28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB61510
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],bl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB61508
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FE058]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L29
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L29
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L30
       cmp       qword ptr [rbp-50],0
       je        short M00_L31
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L30
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FE058]
M00_L30:
       nop
       add       rsp,28
       ret
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FDF68]
       int       3
; Total bytes of code 987
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FFE2CC58210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFE8C89E370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L01
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,21565C00068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,3D24C413
       mov       ebx,0AEA95BF
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L28
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D31E718]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D40ECA0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB61470
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],bl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB61468
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D40D098]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L29
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L29
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L30
       cmp       qword ptr [rbp-50],0
       je        short M00_L31
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L30
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D40D098]
M00_L30:
       nop
       add       rsp,28
       ret
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFE2D31E718]
       int       3
; Total bytes of code 987
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,1C9CDC00068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,0A0329688
       mov       ebx,1A195C7A
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L28
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D317660]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB61650
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       ebx,ebx
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],bl
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB61648
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3163B8]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L29
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L29
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L30
       cmp       qword ptr [rbp-50],0
       je        short M00_L31
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L30
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3163B8]
M00_L30:
       nop
       add       rsp,28
       ret
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
; Total bytes of code 987
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01D358]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FFE2D423680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D423688
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFE2CB60A50
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F63A0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE2D423790
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FFE2CB60A48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FFE2D4239AC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FFE2D423898
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFE2D4238A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB60A58
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FFE2D4239A8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FFE8C66DB38]
       mov       rcx,[rbx+8]
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C66DB60]
       mov       rcx,[rbx+8]
       mov       r11,rax
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C66BC88]
       mov       rcx,rax
       call      qword ptr [7FFE8C6690A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M02_L00
       mov       rax,[rbp-38]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-30]
       mov       rdx,7FFE2D33BA00
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2426AEABB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,2426AEA0008
       call      qword ptr [7FFE2D1CF4E0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M02_L02
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-40]
       mov       rdx,7FFE2D33BA20
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       r8d,[rbp-24]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FFE2D31E958]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 279
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3F6610]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F65E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CFFD358]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FFE2D3F6278
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D3F6280
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFE2CB40A50
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C5F38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3C5F20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE2D3F6388
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FFE2CB40A48
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FFE2D3F65A4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FFE2D3F6490
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFE2D3F6498
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB40A58
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FFE2D3F65A0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FFE8C66DB38]
       mov       rcx,[rbx+8]
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C66DB60]
       mov       rcx,[rbx+8]
       mov       r11,rax
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C66BC88]
       mov       rcx,rax
       call      qword ptr [7FFE8C6690A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-30],rax
       mov       rax,[rbp-30]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       je        short M02_L00
       mov       rax,[rbp-38]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp-30]
       mov       rdx,7FFE2D30BA00
       call      qword ptr [7FFE2CBFC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2155CA2BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,2155CA20008
       call      qword ptr [7FFE2D1AF078]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M02_L02
       mov       rax,[rbp-48]
       mov       [rbp-20],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-40]
       mov       rdx,7FFE2D30BA20
       call      qword ptr [7FFE2CBFC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-24],eax
       mov       r8d,[rbp-24]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FFE2D2EE4F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 279
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3C61A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C6178]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CFED358]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FFE2D3F3670
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D3F3678
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFE2CB30F88
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C62E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3C62C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE2D3F3780
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FFE2CB30F80
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FFE2D3F399C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FFE2D3F3888
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFE2D3F3890
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB30F90
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FFE2D3F3998
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L00
       mov       rax,[rbp-48]
       mov       [rbp-18],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp-40]
       mov       rdx,7FFE2D30BA00
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L01:
       mov       rax,2A83C55BB70
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,2A83C550008
       call      qword ptr [7FFE2D19F4E0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-50],rax
       mov       rax,[rbp-50]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        short M01_L02
       mov       rax,[rbp-58]
       mov       [rbp-20],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D30BA20
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M01_L03:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,7FFE2D4C9088
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       r11,[rbp-20]
       mov       rdx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       mov       [rbp-34],eax
       mov       r8d,[rbp-34]
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       mov       r9d,1
       call      qword ptr [7FFE2D2EE988]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 332
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3C6550]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C6520]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CFED358]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FFE2D38F460
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D38F468
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFE2CB31438
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2CE610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D2CE5F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE2D38F570
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FFE2CB31430
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FFE2D38F78C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FFE2D38F678
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFE2D38F680
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB31440
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FFE2D38F788
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-88],rax
       mov       [rbp-60],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L72
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+38]
       test      r11,r11
       je        near ptr M01_L69
M01_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L75
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        near ptr M01_L73
       mov       ecx,4
       call      qword ptr [7FFE2D2C6D00]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rdx,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],rdx
       jne       near ptr M01_L74
       mov       edx,[rsi+8]
       add       edx,edx
       lea       rcx,[rsi+0C]
       mov       r8d,0AD1ECA41
       mov       r9d,4BFA3F9
       call      qword ptr [7FFE2D00DE90]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
M01_L01:
       mov       [rbp-88],rbx
       mov       [rbp-44],eax
M01_L02:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L79
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       mov       [rbp-90],rax
       xor       eax,eax
       mov       [rbp-48],eax
       cmp       qword ptr [rbp-90],0
       je        near ptr M01_L10
       mov       rcx,[rbp-90]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M01_L11
M01_L03:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L77
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M01_L15
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M01_L06
M01_L04:
       cmp       r14d,[r15+18]
       je        near ptr M01_L12
M01_L05:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M01_L04
M01_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+40]
       test      r12,r12
       je        near ptr M01_L09
M01_L07:
       mov       r15,r12
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L15
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L15
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M01_L16
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L15
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M01_L08:
       movzx     esi,r13b
       jmp       near ptr M01_L17
M01_L09:
       mov       rcx,rdx
       mov       rdx,7FFE2D2B9C10
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M01_L07
M01_L10:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L11:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3C7600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M01_L03
       nop       dword ptr [rax]
M01_L12:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdx
       mov       rdx,7FFE2D2B9EC8
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-88]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M01_L05
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M01_L08
M01_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M01_L76
M01_L18:
       test      esi,esi
       je        near ptr M01_L67
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M01_L54
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L54
       jmp       short M01_L20
M01_L19:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L64
       mov       [rbp-4C],ecx
       add       edi,1
       jo        near ptr M01_L64
       test      edi,edi
       jg        short M01_L24
M01_L20:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M01_L21
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L22
       jmp       short M01_L23
M01_L21:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L22:
       mov       dword ptr [rbp-54],1
       jmp       short M01_L19
M01_L23:
       mov       rcx,r14
       call      qword ptr [7FFE2D3C7600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M01_L22
M01_L24:
       mov       rax,[rbp+10]
       cmp       rbx,[rax+10]
       jne       near ptr M01_L66
       xor       edx,edx
       xor       ecx,ecx
       mov       r9,[rbx+18]
       cmp       dword ptr [r9+8],0
       je        short M01_L26
M01_L25:
       mov       r9,[rbx+18]
       cmp       ecx,[r9+8]
       jae       near ptr M01_L63
       movsxd    r9,dword ptr [r9+rcx*4+10]
       add       rdx,r9
       jo        near ptr M01_L64
       add       ecx,1
       jo        near ptr M01_L64
       mov       r9,[rbx+18]
       mov       r9d,[r9+8]
       movsxd    r8,ecx
       cmp       r9,r8
       jg        short M01_L25
M01_L26:
       mov       rcx,[rbx+8]
       mov       r9d,[rcx+8]
       shr       r9,2
       cmp       r9,rdx
       jg        near ptr M01_L60
       mov       edx,[rcx+8]
       mov       rcx,[rax]
       lea       r9,[rbp-60]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D2CE7D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L61
       mov       esi,[rbp-60]
       xor       edi,edi
M01_L27:
       mov       [rbp-50],edi
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M01_L33
       test      r13,r13
       je        near ptr M01_L48
       cmp       [r13+8],r14d
       jl        near ptr M01_L48
       jmp       short M01_L29
M01_L28:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L64
       mov       [rbp-4C],ecx
       add       r12d,1
       jo        near ptr M01_L64
       cmp       r12d,r14d
       jge       short M01_L33
M01_L29:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       ecx,r12d
       mov       rdx,[r13+rcx*8+10]
       test      rdx,rdx
       je        short M01_L30
       mov       [rbp-0A0],rdx
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L31
       jmp       short M01_L32
M01_L30:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L31:
       mov       dword ptr [rbp-64],1
       jmp       short M01_L28
M01_L32:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE2D3C7600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M01_L31
M01_L33:
       mov       rax,[rbp+10]
       cmp       byte ptr [rax+1C],0
       je        near ptr M01_L62
       mov       r14,[rbx+10]
       cmp       dword ptr [r14+8],400
       jge       near ptr M01_L62
       mov       edx,[r14+8]
       imul      rdx,2
       jo        near ptr M01_L64
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       ecx,[r14+8]
       mov       [rsp+20],ecx
       mov       rcx,r14
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D11DA40]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r12d,[r13+8]
       cmp       r12,r14
       jle       short M01_L35
M01_L34:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r14,r12
       jae       near ptr M01_L63
       lea       rcx,[r13+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,1
       jo        near ptr M01_L64
       cmp       r12,r14
       jg        short M01_L34
M01_L35:
       mov       [rbp-98],r13
       mov       rax,[rbp+10]
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M01_L43
       mov       rcx,r8
M01_L36:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r14d,[r13+8]
       mov       edx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       rax,[rbp+10]
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+40]
       test      r8,r8
       je        short M01_L38
       mov       r13,[rbp-98]
M01_L37:
       xor       r10d,r10d
       jmp       short M01_L41
M01_L38:
       mov       r13,[rbp-98]
       mov       rdx,7FFE2D2B9C10
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r8,rax
       jmp       short M01_L37
M01_L39:
       mov       [rbp-70],r8
M01_L40:
       mov       rdi,[rbp-80]
       add       edi,1
       jo        near ptr M01_L64
       mov       r10,rdi
       mov       r8,[rbp-70]
       mov       r13,[rbp-98]
M01_L41:
       mov       rdx,[rbx+8]
       mov       ecx,[rdx+8]
       movsxd    r9,r10d
       cmp       rcx,r9
       jle       near ptr M01_L44
       cmp       r10d,[rdx+8]
       jae       near ptr M01_L63
       mov       [rbp-80],r10
       mov       r9,[rdx+r10*8+10]
       test      r9,r9
       je        short M01_L39
M01_L42:
       mov       r11,[r9+10]
       mov       [rbp-0B0],r11
       mov       [rbp-0A8],r9
       lea       rdx,[r9+18]
       mov       ecx,[rsi+8]
       mov       [rbp-74],ecx
       mov       edi,ecx
       mov       r13d,r14d
       mov       edx,[rdx]
       mov       eax,edx
       and       eax,7FFFFFFF
       cdq
       idiv      edi
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r13d
       mov       r13d,edx
       mov       [rbp-70],r8
       mov       rcx,r8
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B8],rax
       mov       r8,[rbp-0A8]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-68],r8d
       cmp       edi,[rbp-74]
       jae       near ptr M01_L63
       mov       ecx,edi
       mov       r10,[rsi+rcx*8+10]
       mov       [rbp-0C0],r10
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B8]
       mov       ecx,[rbp-68]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,edi
       mov       rcx,rsi
       mov       r8,[rbp-0B8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       cmp       r13d,[r12+8]
       jae       near ptr M01_L63
       mov       eax,r13d
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M01_L64
       mov       [rax],edx
       mov       rdi,[rbp-0B0]
       test      rdi,rdi
       mov       r9,rdi
       je        near ptr M01_L40
       mov       r8,[rbp-70]
       jmp       near ptr M01_L42
M01_L43:
       mov       rdx,7FFE2D2B7028
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L36
M01_L44:
       mov       ecx,[rsi+8]
       mov       ebx,ecx
       cmp       dword ptr [rbp-50],0
       jne       near ptr M01_L65
       mov       eax,ebx
       cdq
       idiv      r14d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
M01_L45:
       mov       rax,[rbp+10]
       mov       [rax+18],ecx
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M01_L59
M01_L46:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L66
M01_L47:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L64
       mov       [rbp-4C],ecx
       add       r12d,1
       jo        near ptr M01_L64
       cmp       r12d,r14d
       jge       near ptr M01_L33
M01_L48:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r12d,[r13+8]
       jae       short M01_L51
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L49
       mov       [rbp-0A0],rdx
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L50
       jmp       short M01_L52
M01_L49:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L50:
       mov       dword ptr [rbp-64],1
       jmp       short M01_L47
M01_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L52:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFE2D3C7600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M01_L50
M01_L53:
       mov       edx,[rbp-4C]
       add       edx,1
       jo        near ptr M01_L64
       mov       [rbp-4C],edx
       add       edi,1
       jo        near ptr M01_L64
       test      edi,edi
       jg        near ptr M01_L24
M01_L54:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       edi,[rsi+8]
       jae       short M01_L57
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M01_L55
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L56
       jmp       short M01_L58
M01_L55:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L56:
       mov       dword ptr [rbp-54],1
       jmp       short M01_L53
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L58:
       mov       rcx,r14
       call      qword ptr [7FFE2D3C7600]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M01_L56
M01_L59:
       mov       rdx,7FFE2D2B7270
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M01_L46
M01_L60:
       movsxd    rcx,dword ptr [rax+18]
       imul      rcx,2
       jo        short M01_L64
       mov       edx,7FFFFFFF
       cmp       rcx,7FFFFFFF
       cmovg     rcx,rdx
       movsxd    rdx,ecx
       cmp       rcx,rdx
       jne       short M01_L64
       mov       [rax+18],ecx
       jmp       short M01_L66
M01_L61:
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       near ptr M01_L27
M01_L62:
       mov       r14,[rbx+10]
       mov       r13,r14
       jmp       near ptr M01_L35
M01_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L65:
       mov       ecx,7FFFFFFF
       jmp       near ptr M01_L45
M01_L66:
       xor       ebx,ebx
       cmp       dword ptr [rbp-4C],0
       jg        short M01_L71
M01_L67:
       mov       eax,r15d
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L68:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L69:
       mov       rcx,rdx
       mov       rdx,7FFE2D2B9A98
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L70:
       add       ebx,1
       jo        near ptr M01_L80
       cmp       ebx,[rbp-4C]
       jge       short M01_L67
M01_L71:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M01_L79
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M01_L68
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L70
       jmp       near ptr M01_L78
M01_L72:
       call      qword ptr [7FFE2D1977E0]
       mov       ecx,24AB
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D485AB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3CD680]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L73:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L74:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L01
M01_L75:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [r11]
       jmp       near ptr M01_L01
M01_L76:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3CC270]
       jmp       near ptr M01_L18
M01_L77:
       call      M01_L81
       jmp       near ptr M01_L02
M01_L78:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3CC270]
       jmp       near ptr M01_L70
M01_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L81:
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M01_L82
       cmp       qword ptr [rbp-90],0
       je        short M01_L83
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L82
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3CC270]
M01_L82:
       nop
       add       rsp,28
       ret
M01_L83:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-54],0
       je        short M01_L84
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L85
       mov       [rbp-4C],ecx
M01_L84:
       add       rsp,28
       ret
M01_L85:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M01_L86
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L87
       mov       [rbp-4C],ecx
M01_L86:
       add       rsp,28
       ret
M01_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-54],0
       je        short M01_L88
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L89
       mov       [rbp-4C],ecx
M01_L88:
       add       rsp,28
       ret
M01_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M01_L90
       mov       edx,[rbp-4C]
       add       edx,1
       jo        short M01_L91
       mov       [rbp-4C],edx
M01_L90:
       add       rsp,28
       ret
M01_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       ebx,ebx
       cmp       ebx,[rbp-4C]
       jge       short M01_L95
M01_L92:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M01_L96
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M01_L94
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L93
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3CC270]
M01_L93:
       add       ebx,1
       jo        short M01_L97
       cmp       ebx,[rbp-4C]
       jl        short M01_L92
       jmp       short M01_L95
M01_L94:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3CC258]
       int       3
M01_L95:
       add       rsp,28
       ret
M01_L96:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2946
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rcx+88]
       mov       [rax+4C],dl
       ret
; Total bytes of code 11
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       r11,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r11],rax
       jne       near ptr M00_L94
       mov       esi,[r11+10]
M00_L00:
       test      esi,esi
       je        near ptr M00_L97
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L96
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L95
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-78],rsi
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-78]
       cmp       [rsi],rcx
       jne       near ptr M00_L88
       lea       rbx,[rsi+8]
       mov       rcx,[rbx]
       mov       edx,[rbx+10]
       mov       rax,[rbx]
       cmp       edx,[rax+14]
       jne       near ptr M00_L87
       mov       edx,[rbx+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L74
       mov       rcx,[rcx+8]
       mov       edx,[rbx+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L91
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rsi+10]
M00_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+2E0]
       mov       [rbp-80],rdx
       mov       rdx,[rbp-80]
       cmp       [rdx],dl
       test      rbx,rbx
       je        near ptr M00_L89
       mov       rdx,[rbp-80]
       mov       rax,[rdx+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L83
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M00_L78
       mov       rax,1881B400068
       mov       rax,[rax]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],r8
       jne       near ptr M00_L82
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0E211AB16
       mov       r10d,6AFE1885
       cmp       edx,8
       jb        near ptr M00_L75
       mov       r9d,edx
       shr       r9d,3
       nop
M00_L04:
       add       r8d,[rax]
       mov       r11d,[rax+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rax,8
       dec       r9d
       mov       ecx,r8d
       mov       r8d,r10d
       mov       r10d,ecx
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L76
M00_L05:
       mov       r9d,edx
       and       r9,7
       mov       eax,[rax+r9-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M00_L06:
       add       edx,r8d
       mov       eax,r10d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M00_L07:
       mov       [rbp-88],rbx
       mov       [rbp-3C],eax
M00_L08:
       mov       rax,[rbp-80]
       mov       rbx,[rax+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r8,[rbx+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-3C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       cmp       edi,[r8+8]
       jae       near ptr M00_L91
       mov       ecx,edi
       mov       rcx,[r8+rcx*8+10]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-90],0
       je        near ptr M00_L14
       mov       rcx,[rbp-90]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M00_L15
M00_L09:
       mov       dword ptr [rbp-40],1
       mov       rcx,[rbp-80]
       cmp       rbx,[rcx+10]
       jne       near ptr M00_L85
       mov       r14d,[rbp-3C]
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        short M00_L12
M00_L10:
       cmp       r14d,[r15+18]
       je        near ptr M00_L16
M00_L11:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L10
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r13,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],r14d
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L17
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M00_L18
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L17
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp-80]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M00_L13:
       movzx     esi,r13b
       jmp       short M00_L19
M00_L14:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L15:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3DF048]
       jmp       near ptr M00_L09
M00_L16:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-88]
       mov       r11,7FFE2CB41588
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M00_L13
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L84
M00_L20:
       test      esi,esi
       je        near ptr M00_L73
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L49
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L49
M00_L21:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L23
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L25
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FFE2D3DF048]
       jmp       short M00_L22
M00_L25:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-44],ecx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L21
M00_L26:
       mov       rdx,[rbp-80]
       cmp       rbx,[rdx+10]
       jne       near ptr M00_L70
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+8],0
       je        short M00_L28
M00_L27:
       mov       rcx,[rbx+18]
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L66
       movsxd    rcx,dword ptr [rcx+r9*4+10]
       add       rdx,rcx
       jo        near ptr M00_L67
       add       r9d,1
       jo        near ptr M00_L67
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       movsxd    r8,r9d
       cmp       rcx,r8
       jg        short M00_L27
M00_L28:
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jg        near ptr M00_L46
       xor       edx,edx
       mov       [rbp-50],edx
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       lea       r9,[rbp-50]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D3D6598]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L61
       mov       esi,[rbp-50]
       xor       edi,edi
M00_L29:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M00_L35
       test      r13,r13
       je        near ptr M00_L55
       cmp       [r13+8],r14d
       jl        near ptr M00_L55
M00_L30:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L32
       mov       [rbp-98],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L33
M00_L31:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L34
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L33:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3DF048]
       jmp       short M00_L31
M00_L34:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-44],ecx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L30
M00_L35:
       mov       rdx,[rbp-80]
       cmp       byte ptr [rdx+1C],0
       je        near ptr M00_L62
       mov       r14,[rbx+10]
       cmp       dword ptr [r14+8],400
       jge       near ptr M00_L62
       mov       edx,[r14+8]
       imul      rdx,2
       jo        near ptr M00_L67
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r14
       mov       r14d,[r14+8]
       test      rcx,rcx
       je        near ptr M00_L68
       mov       rdx,[rcx]
       cmp       rdx,[r13]
       jne       near ptr M00_L68
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L68
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L68
       cmp       r14d,[r13+8]
       ja        near ptr M00_L68
       mov       r8d,r14d
       movzx     eax,word ptr [rdx]
       imul      r8,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[r13+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L65
       cmp       r8,4000
       ja        near ptr M00_L64
       mov       rdx,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L63
M00_L36:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r12d,[r13+8]
       cmp       r12,r14
       jle       short M00_L38
M00_L37:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r14,r12
       jae       near ptr M00_L66
       lea       rcx,[r13+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,1
       jo        near ptr M00_L67
       cmp       r12,r14
       jg        short M00_L37
M00_L38:
       mov       r14,r13
M00_L39:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       r8d,r8d
       jmp       short M00_L41
M00_L40:
       mov       rax,[rbp-70]
       add       eax,1
       jo        near ptr M00_L67
       mov       r8,rax
M00_L41:
       mov       rax,[rbx+8]
       mov       edx,[rax+8]
       movsxd    rcx,r8d
       cmp       rdx,rcx
       jle       near ptr M00_L43
       cmp       r8d,[rax+8]
       jae       near ptr M00_L66
       mov       [rbp-70],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M00_L40
M00_L42:
       mov       r9,[r10+10]
       mov       [rbp-0A8],r9
       mov       [rbp-0A0],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       [rbp-68],r11d
       mov       ecx,r11d
       mov       [rbp-60],r13d
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-58],ecx
       mov       eax,ecx
       cdq
       idiv      dword ptr [rbp-60]
       mov       [rbp-5C],edx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       r8,[rbp-0A0]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-64],r8d
       mov       r10d,[rbp-58]
       cmp       r10d,[rbp-68]
       jae       near ptr M00_L66
       mov       ecx,r10d
       mov       r11,[rsi+rcx*8+10]
       mov       [rbp-0B8],r11
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       ecx,[rbp-64]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-68]
       jae       near ptr M00_L66
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-5C]
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rax],edx
       mov       r8,[rbp-0A8]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M00_L42
       jmp       near ptr M00_L40
M00_L43:
       mov       r9d,[rsi+8]
       mov       ebx,r9d
       mov       eax,ebx
       test      edi,edi
       jne       near ptr M00_L69
       cdq
       idiv      r13d
       cmp       eax,1
       jle       short M00_L45
M00_L44:
       mov       rcx,[rbp-80]
       mov       [rcx+18],eax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-80]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L70
M00_L45:
       mov       eax,1
       jmp       short M00_L44
M00_L46:
       mov       rcx,[rbp-80]
       movsxd    rcx,dword ptr [rcx+18]
       imul      rcx,2
       jo        near ptr M00_L67
       cmp       rcx,7FFFFFFF
       jg        short M00_L47
       jmp       short M00_L48
M00_L47:
       mov       ecx,7FFFFFFF
M00_L48:
       movsxd    rax,ecx
       cmp       rcx,rax
       jne       near ptr M00_L67
       mov       rax,[rbp-80]
       mov       [rax+18],ecx
       jmp       near ptr M00_L70
M00_L49:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L52
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L51
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r14
       call      qword ptr [7FFE2D3DF048]
       jmp       short M00_L50
M00_L54:
       mov       edx,[rbp-44]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-44],edx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L49
       jmp       near ptr M00_L26
M00_L55:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L58
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L57
       mov       [rbp-98],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L59
M00_L56:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L60
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L59:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3DF048]
       jmp       short M00_L56
M00_L60:
       mov       edx,[rbp-44]
       add       edx,1
       jo        short M00_L67
       mov       [rbp-44],edx
       add       r12d,1
       jo        short M00_L67
       cmp       r12d,r14d
       jl        short M00_L55
       jmp       near ptr M00_L35
M00_L61:
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       near ptr M00_L29
M00_L62:
       mov       r14,[rbx+10]
       jmp       near ptr M00_L39
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L64:
       mov       rdx,rax
       call      qword ptr [7FFE2D1AF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L65:
       mov       rdx,rax
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L68:
       mov       [rsp+20],r14d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D236C10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L36
M00_L69:
       mov       eax,7FFFFFFF
       jmp       near ptr M00_L44
M00_L70:
       xor       ebx,ebx
       cmp       dword ptr [rbp-44],0
       jle       short M00_L73
M00_L71:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M00_L91
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        near ptr M00_L90
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L86
M00_L72:
       add       ebx,1
       jo        near ptr M00_L92
       cmp       ebx,[rbp-44]
       jl        short M00_L71
M00_L73:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],r15b
       jmp       near ptr M00_L02
M00_L74:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L93
M00_L75:
       cmp       edx,4
       jb        short M00_L79
M00_L76:
       add       r8d,[rax]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L05
M00_L77:
       mov       rcx,rsi
       mov       r11,7FFE2CB41560
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L78:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L79:
       mov       r9d,80
       test      dl,1
       je        short M00_L80
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rax+r9]
       or        r9d,8000
M00_L80:
       test      dl,2
       je        short M00_L81
       shl       r9d,10
       movzx     edx,word ptr [rax]
       or        r9d,edx
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L81:
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L82:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L83:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r11,7FFE2CB41580
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L84:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3DE238]
       jmp       near ptr M00_L20
M00_L85:
       call      M00_L99
       jmp       near ptr M00_L08
M00_L86:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3DE238]
       jmp       near ptr M00_L72
M00_L87:
       call      qword ptr [7FFE2CE1C168]
       int       3
M00_L88:
       mov       rcx,rsi
       mov       r11,7FFE2CB41558
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L77
       jmp       near ptr M00_L98
M00_L89:
       call      qword ptr [7FFE2D1AF588]
       mov       ecx,24AB
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE177C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE177C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE177C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3DD7E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3DD800]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L90:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L91:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L93:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L94:
       mov       rcx,r11
       mov       r11,7FFE2CB41570
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L95:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18831400C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L96:
       mov       rcx,rbx
       mov       r11,7FFE2CB41578
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L97:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18831400C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L98:
       mov       rcx,rsi
       mov       r11,7FFE2CB41568
       call      qword ptr [r11]
       jmp       near ptr M00_L93
M00_L99:
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M00_L100
       cmp       qword ptr [rbp-90],0
       je        short M00_L101
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3DE238]
M00_L100:
       nop
       add       rsp,38
       ret
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L102
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L103
       mov       [rbp-44],ecx
M00_L102:
       add       rsp,38
       ret
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L104
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L105
       mov       [rbp-44],ecx
M00_L104:
       add       rsp,38
       ret
M00_L105:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L106
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-44],ecx
M00_L106:
       add       rsp,38
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L108
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-44],ecx
M00_L108:
       add       rsp,38
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       xor       ebx,ebx
       cmp       ebx,[rbp-44]
       jge       short M00_L115
M00_L110:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M00_L113
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L112
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3DE238]
M00_L111:
       add       ebx,1
       jo        short M00_L114
       cmp       ebx,[rbp-44]
       jl        short M00_L110
       jmp       short M00_L115
M00_L112:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DE148]
       int       3
M00_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L114:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L115:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-78],0
       je        short M00_L116
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-78]
       cmp       [rsi],rcx
       je        short M00_L116
       mov       rcx,rsi
       mov       r11,7FFE2CB41568
       call      qword ptr [r11]
M00_L116:
       nop
       add       rsp,38
       ret
; Total bytes of code 3686
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
       call      qword ptr [7FFE2D3DCCD8]
       int       3
M01_L01:
       call      qword ptr [7FFE2D3DFEA0]
       int       3
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
; 				newLength = FindNextValidLength((currentLength * 2) + 1);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return newLength <= maxLength;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (OverflowException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			newLength = maxLength;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       imul      ecx,edx,2
       jo        near ptr M02_L02
       add       ecx,1
       jo        short M02_L02
       nop       dword ptr [rax]
       jmp       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       add       ecx,2
       jo        short M02_L02
M02_L01:
       mov       edx,55555556
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,92492493
       mov       eax,edx
       imul      ecx
       add       edx,ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       edx,[rax*8]
       sub       edx,eax
       mov       eax,ecx
       sub       eax,edx
       je        short M02_L00
       mov       [r9],ecx
       cmp       [r9],r8d
       setle     al
       movzx     eax,al
       mov       [rbp-4],eax
       jmp       short M02_L03
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L03:
       mov       eax,[rbp-4]
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       r9,[rbp+28]
       mov       r8d,[rbp+20]
       mov       [r9],r8d
       xor       eax,eax
       mov       [rbp-4],eax
       lea       rax,[M02_L03]
       add       rsp,28
       ret
; Total bytes of code 205
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L01
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M04_L01:
       vzeroupper
       ret
M04_L02:
       test      r8,r8
       je        short M04_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L01
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L01
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L01
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CBF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M05_L09
       test      rsi,rsi
       je        near ptr M05_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M05_L10
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M05_L07
       sub       edi,eax
       js        near ptr M05_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M05_L06
       sub       ebp,eax
       js        near ptr M05_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C67A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M05_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M05_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M05_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L15
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       r8,4000
       jbe       short M05_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L02
       jmp       near ptr M05_L14
M05_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L10:
       call      qword ptr [7FFE8C673788]
       mov       rbx,rax
       call      qword ptr [7FFE8C67ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFE8C691908]
       int       3
M05_L12:
       call      qword ptr [7FFE8C673550]
       mov       rdi,rax
       call      qword ptr [7FFE8C67DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L13:
       call      qword ptr [7FFE8C673550]
       mov       rbp,rax
       call      qword ptr [7FFE8C67DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L14:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L15:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFE8C673578]
       mov       rbx,rax
       call      qword ptr [7FFE8C67E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67C240]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C8B0560008
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
       call      qword ptr [7FFE2D3DFB58]
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
       jmp       qword ptr [7FFE2CBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       r11,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r11],rax
       jne       near ptr M00_L94
       mov       esi,[r11+10]
M00_L00:
       test      esi,esi
       je        near ptr M00_L97
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L96
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L95
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-78],rsi
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-78]
       cmp       [rsi],rcx
       jne       near ptr M00_L88
       lea       rbx,[rsi+8]
       mov       rcx,[rbx]
       mov       edx,[rbx+10]
       mov       rax,[rbx]
       cmp       edx,[rax+14]
       jne       near ptr M00_L87
       mov       edx,[rbx+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L74
       mov       rcx,[rcx+8]
       mov       edx,[rbx+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L91
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rsi+10]
M00_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+2E0]
       mov       [rbp-80],rdx
       mov       rdx,[rbp-80]
       cmp       [rdx],dl
       test      rbx,rbx
       je        near ptr M00_L89
       mov       rdx,[rbp-80]
       mov       rax,[rdx+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L83
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M00_L76
       mov       rax,21166800068
       mov       rax,[rax]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],r8
       jne       near ptr M00_L82
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,14EBC769
       mov       r10d,0EFE8FA4C
       cmp       edx,8
       jb        near ptr M00_L77
       mov       r9d,edx
       shr       r9d,3
       nop
M00_L04:
       add       r8d,[rax]
       mov       r11d,[rax+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rax,8
       dec       r9d
       mov       ecx,r8d
       mov       r8d,r10d
       mov       r10d,ecx
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L78
M00_L05:
       mov       r9d,edx
       and       r9,7
       mov       eax,[rax+r9-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M00_L06:
       add       edx,r8d
       mov       eax,r10d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M00_L07:
       mov       [rbp-88],rbx
       mov       [rbp-3C],eax
M00_L08:
       mov       rax,[rbp-80]
       mov       rbx,[rax+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r8,[rbx+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-3C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       cmp       edi,[r8+8]
       jae       near ptr M00_L91
       mov       ecx,edi
       mov       rcx,[r8+rcx*8+10]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-90],0
       je        near ptr M00_L14
       mov       rcx,[rbp-90]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M00_L15
M00_L09:
       mov       dword ptr [rbp-40],1
       mov       rcx,[rbp-80]
       cmp       rbx,[rcx+10]
       jne       near ptr M00_L85
       mov       r14d,[rbp-3C]
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        short M00_L12
M00_L10:
       cmp       r14d,[r15+18]
       je        near ptr M00_L16
M00_L11:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L10
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r13,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],r14d
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L17
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M00_L18
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L17
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp-80]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M00_L13:
       movzx     esi,r13b
       jmp       short M00_L19
M00_L14:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L15:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3EEBF8]
       jmp       near ptr M00_L09
M00_L16:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-88]
       mov       r11,7FFE2CB513D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M00_L13
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L84
M00_L20:
       test      esi,esi
       je        near ptr M00_L73
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L46
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L46
M00_L21:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L23
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L25
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FFE2D3EEBF8]
       jmp       short M00_L22
M00_L25:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-44],ecx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L21
M00_L26:
       mov       rdx,[rbp-80]
       cmp       rbx,[rdx+10]
       jne       near ptr M00_L70
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+8],0
       je        short M00_L28
M00_L27:
       mov       rcx,[rbx+18]
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L66
       movsxd    rcx,dword ptr [rcx+r9*4+10]
       add       rdx,rcx
       jo        near ptr M00_L67
       add       r9d,1
       jo        near ptr M00_L67
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       movsxd    r8,r9d
       cmp       rcx,r8
       jg        short M00_L27
M00_L28:
       mov       r9,[rbx+8]
       mov       ecx,[r9+8]
       shr       rcx,2
       cmp       rcx,rdx
       jg        near ptr M00_L59
       xor       edx,edx
       mov       [rbp-50],edx
       mov       edx,[r9+8]
       lea       r9,[rbp-50]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D3E6448]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L62
       mov       esi,[rbp-50]
       xor       edi,edi
M00_L29:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M00_L35
       test      r13,r13
       je        near ptr M00_L52
       cmp       [r13+8],r14d
       jl        near ptr M00_L52
M00_L30:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L32
       mov       [rbp-98],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L33
M00_L31:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L34
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L33:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3EEBF8]
       jmp       short M00_L31
M00_L34:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L67
       mov       [rbp-44],ecx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L30
M00_L35:
       mov       rdx,[rbp-80]
       cmp       byte ptr [rdx+1C],0
       je        near ptr M00_L43
       mov       r14,[rbx+10]
       cmp       dword ptr [r14+8],400
       jge       near ptr M00_L43
       mov       edx,[r14+8]
       imul      rdx,2
       jo        near ptr M00_L67
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r14
       mov       r14d,[r14+8]
       test      rcx,rcx
       je        near ptr M00_L68
       mov       rdx,[rcx]
       cmp       rdx,[r13]
       jne       near ptr M00_L68
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L68
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L68
       cmp       r14d,[r13+8]
       ja        near ptr M00_L68
       mov       r8d,r14d
       movzx     eax,word ptr [rdx]
       imul      r8,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[r13+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L65
       cmp       r8,4000
       ja        near ptr M00_L64
       mov       rdx,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L63
M00_L36:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       r12d,[r13+8]
       cmp       r12,r14
       jle       short M00_L38
M00_L37:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r14,r12
       jae       near ptr M00_L66
       lea       rcx,[r13+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,1
       jo        near ptr M00_L67
       cmp       r12,r14
       jg        short M00_L37
M00_L38:
       mov       r14,r13
M00_L39:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       r8d,r8d
       jmp       short M00_L41
M00_L40:
       mov       rax,[rbp-70]
       add       eax,1
       jo        near ptr M00_L67
       mov       r8,rax
M00_L41:
       mov       rax,[rbx+8]
       mov       edx,[rax+8]
       movsxd    rcx,r8d
       cmp       rdx,rcx
       jle       near ptr M00_L44
       cmp       r8d,[rax+8]
       jae       near ptr M00_L66
       mov       [rbp-70],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M00_L40
M00_L42:
       mov       r9,[r10+10]
       mov       [rbp-0A8],r9
       mov       [rbp-0A0],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       [rbp-68],r11d
       mov       ecx,r11d
       mov       [rbp-60],r13d
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-58],ecx
       mov       eax,ecx
       cdq
       idiv      dword ptr [rbp-60]
       mov       [rbp-5C],edx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       r8,[rbp-0A0]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-64],r8d
       mov       r10d,[rbp-58]
       cmp       r10d,[rbp-68]
       jae       near ptr M00_L66
       mov       ecx,r10d
       mov       r11,[rsi+rcx*8+10]
       mov       [rbp-0B8],r11
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       ecx,[rbp-64]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-68]
       jae       near ptr M00_L66
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-5C]
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rax],edx
       mov       r8,[rbp-0A8]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M00_L42
       jmp       near ptr M00_L40
M00_L43:
       mov       r14,[rbx+10]
       jmp       near ptr M00_L39
M00_L44:
       mov       r9d,[rsi+8]
       mov       ebx,r9d
       mov       eax,ebx
       test      edi,edi
       jne       near ptr M00_L69
       cdq
       idiv      r13d
       cmp       eax,1
       jle       near ptr M00_L58
M00_L45:
       mov       rcx,[rbp-80]
       mov       [rcx+18],eax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-80]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L70
M00_L46:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L49
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L48
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r14
       call      qword ptr [7FFE2D3EEBF8]
       jmp       short M00_L47
M00_L51:
       mov       edx,[rbp-44]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-44],edx
       add       edi,1
       jo        near ptr M00_L67
       test      edi,edi
       jle       short M00_L46
       jmp       near ptr M00_L26
M00_L52:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L55
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L54
       mov       [rbp-98],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3EEBF8]
       jmp       short M00_L53
M00_L57:
       mov       edx,[rbp-44]
       add       edx,1
       jo        near ptr M00_L67
       mov       [rbp-44],edx
       add       r12d,1
       jo        near ptr M00_L67
       cmp       r12d,r14d
       jl        short M00_L52
       jmp       near ptr M00_L35
M00_L58:
       mov       eax,1
       jmp       near ptr M00_L45
M00_L59:
       mov       rcx,[rbp-80]
       movsxd    rcx,dword ptr [rcx+18]
       imul      rcx,2
       jo        short M00_L67
       cmp       rcx,7FFFFFFF
       jle       short M00_L60
       mov       eax,7FFFFFFF
       jmp       short M00_L61
M00_L60:
       mov       rax,rcx
M00_L61:
       movsxd    rcx,eax
       cmp       rax,rcx
       jne       short M00_L67
       mov       rcx,[rbp-80]
       mov       [rcx+18],eax
       jmp       short M00_L70
M00_L62:
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       near ptr M00_L29
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L64:
       mov       rdx,rax
       call      qword ptr [7FFE2D1BEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L65:
       mov       rdx,rax
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L36
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L68:
       mov       [rsp+20],r14d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r13
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D246BC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L36
M00_L69:
       mov       eax,7FFFFFFF
       jmp       near ptr M00_L45
M00_L70:
       xor       ebx,ebx
       cmp       dword ptr [rbp-44],0
       jle       short M00_L73
M00_L71:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M00_L91
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        near ptr M00_L90
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L86
M00_L72:
       add       ebx,1
       jo        near ptr M00_L92
       cmp       ebx,[rbp-44]
       jl        short M00_L71
M00_L73:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],r15b
       jmp       near ptr M00_L02
M00_L74:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L93
M00_L75:
       mov       rcx,rsi
       mov       r11,7FFE2CB513A8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L76:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L77:
       cmp       edx,4
       jb        short M00_L79
M00_L78:
       add       r8d,[rax]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L05
M00_L79:
       mov       r9d,80
       test      dl,1
       je        short M00_L80
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rax+r9]
       or        r9d,8000
M00_L80:
       test      dl,2
       je        short M00_L81
       shl       r9d,10
       movzx     edx,word ptr [rax]
       or        r9d,edx
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L81:
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L82:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L83:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r11,7FFE2CB513C8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L84:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3EDCE0]
       jmp       near ptr M00_L20
M00_L85:
       call      M00_L99
       jmp       near ptr M00_L08
M00_L86:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3EDCE0]
       jmp       near ptr M00_L72
M00_L87:
       call      qword ptr [7FFE2CE2C138]
       int       3
M00_L88:
       mov       rcx,rsi
       mov       r11,7FFE2CB513A0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L75
       jmp       near ptr M00_L98
M00_L89:
       call      qword ptr [7FFE2D1BF528]
       mov       ecx,24AB
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3EDAE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3EDB00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L90:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L91:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L93:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L94:
       mov       rcx,r11
       mov       r11,7FFE2CB513B8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L95:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21166802C18
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L96:
       mov       rcx,rbx
       mov       r11,7FFE2CB513C0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L97:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21166802C18
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L98:
       mov       rcx,rsi
       mov       r11,7FFE2CB513B0
       call      qword ptr [r11]
       jmp       near ptr M00_L93
M00_L99:
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M00_L100
       cmp       qword ptr [rbp-90],0
       je        short M00_L101
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3EDCE0]
M00_L100:
       nop
       add       rsp,38
       ret
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L102
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L103
       mov       [rbp-44],ecx
M00_L102:
       add       rsp,38
       ret
M00_L103:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L104
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L105
       mov       [rbp-44],ecx
M00_L104:
       add       rsp,38
       ret
M00_L105:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L106
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L107
       mov       [rbp-44],ecx
M00_L106:
       add       rsp,38
       ret
M00_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L108
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L109
       mov       [rbp-44],ecx
M00_L108:
       add       rsp,38
       ret
M00_L109:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       xor       ebx,ebx
       cmp       ebx,[rbp-44]
       jge       short M00_L115
M00_L110:
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M00_L113
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L112
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3EDCE0]
M00_L111:
       add       ebx,1
       jo        short M00_L114
       cmp       ebx,[rbp-44]
       jl        short M00_L110
       jmp       short M00_L115
M00_L112:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDBC0]
       int       3
M00_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L114:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L115:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-78],0
       je        short M00_L116
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-78]
       cmp       [rsi],rcx
       je        short M00_L116
       mov       rcx,rsi
       mov       r11,7FFE2CB513B0
       call      qword ptr [r11]
M00_L116:
       nop
       add       rsp,38
       ret
; Total bytes of code 3690
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
       call      qword ptr [7FFE2D3ECC90]
       int       3
M01_L01:
       call      qword ptr [7FFE2D3EF9F0]
       int       3
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
; 				newLength = FindNextValidLength((currentLength * 2) + 1);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return newLength <= maxLength;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (OverflowException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			newLength = maxLength;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       imul      ecx,edx,2
       jo        near ptr M02_L02
       add       ecx,1
       jo        short M02_L02
       nop       dword ptr [rax]
       jmp       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       add       ecx,2
       jo        short M02_L02
M02_L01:
       mov       edx,55555556
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,92492493
       mov       eax,edx
       imul      ecx
       add       edx,ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       edx,[rax*8]
       sub       edx,eax
       mov       eax,ecx
       sub       eax,edx
       je        short M02_L00
       mov       [r9],ecx
       cmp       [r9],r8d
       setle     al
       movzx     eax,al
       mov       [rbp-4],eax
       jmp       short M02_L03
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L03:
       mov       eax,[rbp-4]
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       r9,[rbp+28]
       mov       r8d,[rbp+20]
       mov       [r9],r8d
       xor       eax,eax
       mov       [rbp-4],eax
       lea       rax,[M02_L03]
       add       rsp,28
       ret
; Total bytes of code 205
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L01
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M04_L01:
       vzeroupper
       ret
M04_L02:
       test      r8,r8
       je        short M04_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L01
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L01
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L01
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CC066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M05_L09
       test      rsi,rsi
       je        near ptr M05_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M05_L10
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M05_L07
       sub       edi,eax
       js        near ptr M05_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M05_L06
       sub       ebp,eax
       js        near ptr M05_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C67A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M05_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M05_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M05_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L15
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       r8,4000
       jbe       short M05_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L02
       jmp       near ptr M05_L14
M05_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L10:
       call      qword ptr [7FFE8C673788]
       mov       rbx,rax
       call      qword ptr [7FFE8C67ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFE8C691908]
       int       3
M05_L12:
       call      qword ptr [7FFE8C673550]
       mov       rdi,rax
       call      qword ptr [7FFE8C67DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L13:
       call      qword ptr [7FFE8C673550]
       mov       rbp,rax
       call      qword ptr [7FFE8C67DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L14:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L15:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFE8C673578]
       mov       rbx,rax
       call      qword ptr [7FFE8C67E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67C240]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,251FB7E0008
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
       call      qword ptr [7FFE2D3EF6A8]
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
       jmp       qword ptr [7FFE2CC05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
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
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       r11,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r11],rax
       jne       near ptr M00_L95
       mov       esi,[r11+10]
M00_L00:
       test      esi,esi
       je        near ptr M00_L98
       mov       rbx,[rbx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rax
       jne       near ptr M00_L97
       cmp       dword ptr [rbx+10],0
       je        near ptr M00_L96
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+14]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       [rsi+18],edi
       mov       [rsi+1C],ecx
M00_L01:
       mov       [rbp-70],rsi
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-70]
       cmp       [rsi],rcx
       jne       near ptr M00_L89
       lea       rbx,[rsi+8]
       mov       rcx,[rbx]
       mov       edx,[rbx+10]
       mov       rax,[rbx]
       cmp       edx,[rax+14]
       jne       near ptr M00_L88
       mov       edx,[rbx+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L75
       mov       rcx,[rcx+8]
       mov       edx,[rbx+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L92
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rsi+10]
M00_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+2E0]
       mov       [rbp-78],rdx
       mov       rdx,[rbp-78]
       cmp       [rdx],dl
       test      rbx,rbx
       je        near ptr M00_L90
       mov       rdx,[rbp-78]
       mov       rax,[rdx+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L84
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M00_L77
       mov       rax,2098E000068
       mov       rax,[rax]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],r8
       jne       near ptr M00_L83
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,27C43658
       mov       r10d,784D659F
       cmp       edx,8
       jb        near ptr M00_L78
       mov       r9d,edx
       shr       r9d,3
M00_L04:
       add       r8d,[rax]
       mov       r11d,[rax+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rax,8
       dec       r9d
       mov       ecx,r8d
       mov       r8d,r10d
       mov       r10d,ecx
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L79
M00_L05:
       mov       r9d,edx
       and       r9,7
       mov       eax,[rax+r9-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M00_L06:
       add       edx,r8d
       mov       eax,r10d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r8d,edx
       rol       r8d,14
       add       r8d,eax
       rol       eax,9
       xor       eax,r8d
       rol       r8d,1B
       add       r8d,eax
       rol       eax,13
       xor       eax,r8d
M00_L07:
       mov       [rbp-80],rbx
       mov       [rbp-3C],eax
M00_L08:
       mov       rax,[rbp-78]
       mov       rbx,[rax+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r8,[rbx+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-3C]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       cmp       edi,[r8+8]
       jae       near ptr M00_L92
       mov       ecx,edi
       mov       rcx,[r8+rcx*8+10]
       mov       [rbp-88],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L14
       mov       rcx,[rbp-88]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M00_L15
M00_L09:
       mov       dword ptr [rbp-40],1
       mov       rcx,[rbp-78]
       cmp       rbx,[rcx+10]
       jne       near ptr M00_L86
       mov       r14d,[rbp-3C]
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        short M00_L12
M00_L10:
       cmp       r14d,[r15+18]
       je        near ptr M00_L16
M00_L11:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L10
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r13,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L17
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],r14d
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L17
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        short M00_L18
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L17
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp-78]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M00_L13:
       movzx     esi,r13b
       jmp       short M00_L19
M00_L14:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L15:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFE2D3FEF28]
       jmp       near ptr M00_L09
M00_L16:
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-80]
       mov       r11,7FFE2CB415F0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M00_L13
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-88]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L85
M00_L20:
       test      esi,esi
       je        near ptr M00_L74
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L58
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L58
M00_L21:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L23
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L24
M00_L22:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L25
M00_L23:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FFE2D3FEF28]
       jmp       short M00_L22
M00_L25:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L69
       mov       [rbp-44],ecx
       add       edi,1
       jo        near ptr M00_L69
       test      edi,edi
       jle       short M00_L21
M00_L26:
       mov       rdx,[rbp-78]
       cmp       rbx,[rdx+10]
       jne       near ptr M00_L71
       xor       edx,edx
       xor       r9d,r9d
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+8],0
       je        short M00_L28
M00_L27:
       mov       rcx,[rbx+18]
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L68
       movsxd    rcx,dword ptr [rcx+r9*4+10]
       add       rdx,rcx
       jo        near ptr M00_L69
       add       r9d,1
       jo        near ptr M00_L69
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       movsxd    r8,r9d
       cmp       rcx,r8
       jg        short M00_L27
M00_L28:
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jg        near ptr M00_L56
       xor       edx,edx
       mov       [rbp-50],edx
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       lea       r9,[rbp-50]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D3FD170]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        short M00_L29
       mov       esi,[rbp-50]
       xor       edi,edi
       jmp       short M00_L30
M00_L29:
       mov       esi,7FEFFFFF
       mov       edi,1
M00_L30:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M00_L36
       test      r13,r13
       je        near ptr M00_L42
       cmp       [r13+8],r14d
       jl        near ptr M00_L42
M00_L31:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L33
       mov       [rbp-90],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L34:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3FEF28]
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        near ptr M00_L69
       mov       [rbp-44],ecx
       add       r12d,1
       jo        near ptr M00_L69
       cmp       r12d,r14d
       jl        short M00_L31
M00_L36:
       mov       rdx,[rbp-78]
       cmp       byte ptr [rdx+1C],0
       je        short M00_L37
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        near ptr M00_L48
M00_L37:
       mov       r14,[rbx+10]
M00_L38:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       r8d,r8d
       jmp       short M00_L40
M00_L39:
       mov       rax,[rbp-68]
       add       eax,1
       jo        near ptr M00_L69
       mov       r8,rax
M00_L40:
       mov       rax,[rbx+8]
       mov       edx,[rax+8]
       movsxd    rcx,r8d
       cmp       rdx,rcx
       jle       near ptr M00_L52
       cmp       r8d,[rax+8]
       jae       near ptr M00_L68
       mov       [rbp-68],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M00_L39
M00_L41:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       ecx,[rsi+8]
       mov       r11d,r13d
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-58],ecx
       mov       eax,ecx
       cdq
       idiv      r11d
       mov       [rbp-5C],edx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-60],r8d
       mov       r10d,[rbp-58]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L68
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-60]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-58]
       cmp       ecx,[rsi+8]
       jae       near ptr M00_L68
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,[rbp-0A8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-5C]
       cmp       eax,[r12+8]
       jae       near ptr M00_L68
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M00_L69
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M00_L41
       jmp       near ptr M00_L39
M00_L42:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L45
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L44
       mov       [rbp-90],rax
       mov       rcx,rax
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L46
M00_L43:
       mov       dword ptr [rbp-54],1
       jmp       short M00_L47
M00_L44:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L46:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3FEF28]
       jmp       short M00_L43
M00_L47:
       mov       edx,[rbp-44]
       add       edx,1
       jo        near ptr M00_L69
       mov       [rbp-44],edx
       add       r12d,1
       jo        near ptr M00_L69
       cmp       r12d,r14d
       jl        short M00_L42
       jmp       near ptr M00_L36
M00_L48:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M00_L69
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbx+10]
       mov       r13d,[rdx+8]
       test      rcx,rcx
       je        near ptr M00_L70
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L70
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L70
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L70
       cmp       r13d,[r14+8]
       ja        near ptr M00_L70
       mov       r8d,r13d
       movzx     eax,word ptr [rdx]
       imul      r8,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[r14+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L67
       cmp       r8,4000
       ja        near ptr M00_L66
       mov       rdx,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L65
M00_L49:
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12,r13
       jle       short M00_L51
M00_L50:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r13,r12
       jae       near ptr M00_L68
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M00_L69
       cmp       r12,r13
       jg        short M00_L50
M00_L51:
       jmp       near ptr M00_L38
M00_L52:
       mov       eax,[rsi+8]
       test      edi,edi
       je        short M00_L53
       mov       ecx,7FFFFFFF
       jmp       short M00_L54
M00_L53:
       cdq
       idiv      r13d
       cmp       eax,1
       jle       short M00_L55
       mov       ecx,eax
M00_L54:
       mov       rax,[rbp-78]
       mov       [rax+18],ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-78]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L71
M00_L55:
       mov       ecx,1
       jmp       short M00_L54
M00_L56:
       mov       rcx,[rbp-78]
       movsxd    rcx,dword ptr [rcx+18]
       imul      rcx,2
       jo        near ptr M00_L69
       cmp       rcx,7FFFFFFF
       jle       short M00_L64
       mov       eax,7FFFFFFF
M00_L57:
       movsxd    rcx,eax
       cmp       rax,rcx
       jne       near ptr M00_L69
       mov       rcx,[rbp-78]
       mov       [rcx+18],eax
       jmp       near ptr M00_L71
M00_L58:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L61
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L60
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L62
M00_L59:
       mov       dword ptr [rbp-48],1
       jmp       short M00_L63
M00_L60:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L62:
       mov       rcx,r14
       call      qword ptr [7FFE2D3FEF28]
       jmp       short M00_L59
M00_L63:
       mov       edx,[rbp-44]
       add       edx,1
       jo        short M00_L69
       mov       [rbp-44],edx
       add       edi,1
       jo        short M00_L69
       test      edi,edi
       jle       short M00_L58
       jmp       near ptr M00_L26
M00_L64:
       mov       rax,rcx
       jmp       short M00_L57
M00_L65:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L49
M00_L66:
       mov       rdx,rax
       call      qword ptr [7FFE2D236F70]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L49
M00_L67:
       mov       rdx,rax
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L49
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L70:
       mov       [rsp+20],r13d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D2367A8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L49
M00_L71:
       xor       ebx,ebx
       cmp       dword ptr [rbp-44],0
       jle       short M00_L74
M00_L72:
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M00_L92
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        near ptr M00_L91
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L87
M00_L73:
       add       ebx,1
       jo        near ptr M00_L93
       cmp       ebx,[rbp-44]
       jl        short M00_L72
M00_L74:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],r15b
       jmp       near ptr M00_L02
M00_L75:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L94
M00_L76:
       mov       rcx,rsi
       mov       r11,7FFE2CB415C8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L77:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L78:
       cmp       edx,4
       jb        short M00_L80
M00_L79:
       add       r8d,[rax]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L05
M00_L80:
       mov       r9d,80
       test      dl,1
       je        short M00_L81
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rax+r9]
       or        r9d,8000
M00_L81:
       test      dl,2
       je        short M00_L82
       shl       r9d,10
       movzx     edx,word ptr [rax]
       or        r9d,edx
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L82:
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L83:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L84:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r11,7FFE2CB415E8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L85:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFE2D2EE820]
       jmp       near ptr M00_L20
M00_L86:
       call      M00_L100
       jmp       near ptr M00_L08
M00_L87:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D2EE820]
       jmp       near ptr M00_L73
M00_L88:
       call      qword ptr [7FFE2CE1C138]
       int       3
M00_L89:
       mov       rcx,rsi
       mov       r11,7FFE2CB415C0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L76
       jmp       near ptr M00_L99
M00_L90:
       call      qword ptr [7FFE2D1AF120]
       mov       ecx,24AB
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D2EDF50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D2EDF68]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L91:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L92:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L94:
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
M00_L95:
       mov       rcx,r11
       mov       r11,7FFE2CB415D8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L96:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,209A4000C60
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L97:
       mov       rcx,rbx
       mov       r11,7FFE2CB415E0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L98:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,209A4000C60
       mov       rsi,[rcx]
       jmp       near ptr M00_L01
M00_L99:
       mov       rcx,rsi
       mov       r11,7FFE2CB415D0
       call      qword ptr [r11]
       jmp       near ptr M00_L94
M00_L100:
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M00_L101
       cmp       qword ptr [rbp-88],0
       je        short M00_L102
       mov       rcx,[rbp-88]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFE2D2EE820]
M00_L101:
       nop
       add       rsp,38
       ret
M00_L102:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L103
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L104
       mov       [rbp-44],ecx
M00_L103:
       add       rsp,38
       ret
M00_L104:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L105
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L106
       mov       [rbp-44],ecx
M00_L105:
       add       rsp,38
       ret
M00_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-48],0
       je        short M00_L107
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L108
       mov       [rbp-44],ecx
M00_L107:
       add       rsp,38
       ret
M00_L108:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-54],0
       je        short M00_L109
       mov       ecx,[rbp-44]
       add       ecx,1
       jo        short M00_L110
       mov       [rbp-44],ecx
M00_L109:
       add       rsp,38
       ret
M00_L110:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       xor       ebx,ebx
       cmp       ebx,[rbp-44]
       jge       short M00_L116
M00_L111:
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M00_L114
       mov       eax,ebx
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L113
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L112
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D2EE820]
M00_L112:
       add       ebx,1
       jo        short M00_L115
       cmp       ebx,[rbp-44]
       jl        short M00_L111
       jmp       short M00_L116
M00_L113:
       xor       ecx,ecx
       call      qword ptr [7FFE2D2EE730]
       int       3
M00_L114:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L115:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L116:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-70],0
       je        short M00_L117
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rsi,[rbp-70]
       cmp       [rsi],rcx
       je        short M00_L117
       mov       rcx,rsi
       mov       r11,7FFE2CB415D0
       call      qword ptr [r11]
M00_L117:
       nop
       add       rsp,38
       ret
; Total bytes of code 3640
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
       call      qword ptr [7FFE2D2E4D20]
       int       3
M01_L01:
       call      qword ptr [7FFE2D3FFF30]
       int       3
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
; 				newLength = FindNextValidLength((currentLength * 2) + 1);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return newLength <= maxLength;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (OverflowException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 			newLength = maxLength;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       imul      ecx,edx,2
       jo        near ptr M02_L02
       add       ecx,1
       jo        short M02_L02
       nop       dword ptr [rax]
       jmp       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       add       ecx,2
       jo        short M02_L02
M02_L01:
       mov       edx,55555556
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       mov       edx,ecx
       sub       edx,eax
       je        short M02_L00
       mov       edx,92492493
       mov       eax,edx
       imul      ecx
       add       edx,ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       edx,[rax*8]
       sub       edx,eax
       mov       eax,ecx
       sub       eax,edx
       je        short M02_L00
       mov       [r9],ecx
       cmp       [r9],r8d
       setle     al
       movzx     eax,al
       mov       [rbp-4],eax
       jmp       short M02_L03
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L03:
       mov       eax,[rbp-4]
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       r9,[rbp+28]
       mov       r8d,[rbp+20]
       mov       [r9],r8d
       xor       eax,eax
       mov       [rbp-4],eax
       lea       rax,[M02_L03]
       add       rsp,28
       ret
; Total bytes of code 205
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFE8C81A2B0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFE8CB54A90],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        short M04_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L01
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M04_L01:
       vzeroupper
       ret
M04_L02:
       test      r8,r8
       je        short M04_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L01
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L01
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L01
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE2CBF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M05_L09
       test      rsi,rsi
       je        near ptr M05_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M05_L10
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M05_L07
       sub       edi,eax
       js        near ptr M05_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE8C67A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M05_L06
       sub       ebp,eax
       js        near ptr M05_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C67A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M05_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M05_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M05_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L15
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L04:
       cmp       r8,4000
       jbe       short M05_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M05_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE8C67A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L02
       jmp       near ptr M05_L14
M05_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFE8C691920]
       int       3
M05_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE8C67C210]
       int       3
M05_L10:
       call      qword ptr [7FFE8C673788]
       mov       rbx,rax
       call      qword ptr [7FFE8C67ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFE8C691908]
       int       3
M05_L12:
       call      qword ptr [7FFE8C673550]
       mov       rdi,rax
       call      qword ptr [7FFE8C67DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L13:
       call      qword ptr [7FFE8C673550]
       mov       rbp,rax
       call      qword ptr [7FFE8C67DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFE8C67C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
M05_L14:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L15:
       call      qword ptr [7FFE8C669040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L16:
       call      qword ptr [7FFE8C673578]
       mov       rbx,rax
       call      qword ptr [7FFE8C67E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C67C240]
       mov       rcx,rbx
       call      qword ptr [7FFE8C668FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       call      00007FFE8C8950F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE2CBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24A23060008
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
       call      qword ptr [7FFE2D4A4330]
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
       jmp       qword ptr [7FFE2CBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryAdd()
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       dword ptr [rbp-68],3E8
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01D358]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-40],rax
       jmp       short M00_L01
M00_L00:
       mov       rcx,7FFE2D4AB818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,7FFE2D4AB820
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFE2CB60E88
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E0]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D43E8E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
       mov       [rbp-74],eax
       mov       edx,[rbp-74]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D43E8C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M00_L02
       lea       rcx,[rbp-68]
       mov       edx,27
       call      CORINFO_HELP_PATCHPOINT
M00_L02:
       mov       rax,[rbp-40]
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rdx,7FFE2D4AB928
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-58]
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       r11,7FFE2CB60E80
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L00
       call      M00_L03
       nop
       mov       rcx,7FFE2D4ABB44
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,0B0
       pop       rbp
       ret
M00_L03:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L04
       mov       rcx,7FFE2D4ABA30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,7FFE2D4ABA38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-60]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB60E90
       call      qword ptr [r11]
M00_L04:
       mov       rcx,7FFE2D4ABB40
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryAdd(System.__Canon)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       xor       eax,eax
       mov       [rbp-88],rax
       mov       [rbp-60],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       cmp       [rcx],ecx
       test      rbx,rbx
       je        near ptr M01_L74
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+38]
       test      r11,r11
       je        near ptr M01_L71
M01_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L77
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        near ptr M01_L75
       mov       ecx,4
       call      qword ptr [7FFE2D436F40]; System.StringComparer.FromComparison(System.StringComparison)
       mov       rdx,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],rdx
       jne       near ptr M01_L76
       mov       edx,[rsi+8]
       add       edx,edx
       lea       rcx,[rsi+0C]
       mov       r8d,0A69E987B
       mov       r9d,0FE0A97F3
       call      qword ptr [7FFE2D03DE90]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
M01_L01:
       mov       [rbp-88],rbx
       mov       [rbp-44],eax
M01_L02:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L81
       mov       eax,edi
       mov       rax,[r10+rax*8+10]
       mov       [rbp-90],rax
       xor       eax,eax
       mov       [rbp-48],eax
       cmp       qword ptr [rbp-90],0
       je        near ptr M01_L10
       mov       rcx,[rbp-90]
       call      00007FFE8C89DF30
       test      eax,eax
       je        near ptr M01_L11
M01_L03:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L79
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M01_L15
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M01_L06
M01_L04:
       cmp       r14d,[r15+18]
       je        near ptr M01_L12
M01_L05:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M01_L04
M01_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+40]
       test      r12,r12
       je        near ptr M01_L09
M01_L07:
       mov       r15,r12
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L15
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L15
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M01_L16
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L15
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
M01_L08:
       movzx     esi,r13b
       jmp       near ptr M01_L17
M01_L09:
       mov       rcx,rdx
       mov       rdx,7FFE2D469800
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
       jmp       near ptr M01_L07
M01_L10:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L11:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D317600]
       jmp       near ptr M01_L03
       nop       dword ptr [rax]
M01_L12:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdx
       mov       rdx,7FFE2D469AB8
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-88]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M01_L05
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M01_L08
M01_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M01_L78
M01_L18:
       test      esi,esi
       je        near ptr M01_L69
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M01_L61
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L61
       jmp       short M01_L20
M01_L19:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L67
       mov       [rbp-4C],ecx
       add       edi,1
       jo        near ptr M01_L67
       test      edi,edi
       jg        short M01_L24
M01_L20:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M01_L21
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L22
       jmp       short M01_L23
M01_L21:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L22:
       mov       dword ptr [rbp-54],1
       jmp       short M01_L19
M01_L23:
       mov       rcx,r14
       call      qword ptr [7FFE2D317600]
       jmp       short M01_L22
M01_L24:
       mov       rax,[rbp+10]
       cmp       rbx,[rax+10]
       jne       near ptr M01_L68
       xor       edx,edx
       xor       ecx,ecx
       mov       r9,[rbx+18]
       cmp       dword ptr [r9+8],0
       je        short M01_L26
M01_L25:
       mov       r9,[rbx+18]
       cmp       ecx,[r9+8]
       jae       near ptr M01_L66
       movsxd    r9,dword ptr [r9+rcx*4+10]
       add       rdx,r9
       jo        near ptr M01_L67
       add       ecx,1
       jo        near ptr M01_L67
       mov       r9,[rbx+18]
       mov       r9d,[r9+8]
       movsxd    r8,ecx
       cmp       r9,r8
       jg        short M01_L25
M01_L26:
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       shr       rcx,2
       cmp       rcx,rdx
       jg        near ptr M01_L59
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rax]
       lea       r9,[rbp-60]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFE2D43EAA8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryComputeDoublePlusOne(Int32, Int32, Int32 ByRef)
       test      eax,eax
       je        short M01_L27
       mov       esi,[rbp-60]
       xor       edi,edi
       jmp       short M01_L28
M01_L27:
       mov       esi,7FEFFFFF
       mov       edi,1
M01_L28:
       mov       [rbp-50],edi
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r14d,1
       jle       short M01_L34
       test      r13,r13
       je        near ptr M01_L40
       cmp       [r13+8],r14d
       jl        near ptr M01_L40
       jmp       short M01_L30
M01_L29:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L67
       mov       [rbp-4C],ecx
       add       r12d,1
       jo        near ptr M01_L67
       cmp       r12d,r14d
       jge       short M01_L34
M01_L30:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       mov       ecx,r12d
       mov       rdx,[r13+rcx*8+10]
       test      rdx,rdx
       je        short M01_L31
       mov       [rbp-98],rdx
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L32
       jmp       short M01_L33
M01_L31:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L32:
       mov       dword ptr [rbp-64],1
       jmp       short M01_L29
M01_L33:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D317600]
       jmp       short M01_L32
M01_L34:
       mov       rax,[rbp+10]
       cmp       byte ptr [rax+1C],0
       je        short M01_L35
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        near ptr M01_L45
M01_L35:
       mov       r14,[rbx+10]
M01_L36:
       mov       rax,[rbp+10]
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M01_L48
       mov       rcx,r8
M01_L37:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r13d,[r14+8]
       mov       edx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       rax,[rbp+10]
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r8,[rdx+40]
       test      r8,r8
       je        near ptr M01_L49
M01_L38:
       xor       r10d,r10d
       jmp       near ptr M01_L52
M01_L39:
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        near ptr M01_L67
       mov       [rbp-4C],ecx
       add       r12d,1
       jo        near ptr M01_L67
       cmp       r12d,r14d
       jge       near ptr M01_L34
M01_L40:
       xor       ecx,ecx
       mov       [rbp-64],ecx
       cmp       r12d,[r13+8]
       jae       short M01_L43
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L41
       mov       [rbp-98],rdx
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L42
       jmp       short M01_L44
M01_L41:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L42:
       mov       dword ptr [rbp-64],1
       jmp       short M01_L39
M01_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L44:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D317600]
       jmp       short M01_L42
M01_L45:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M01_L67
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D14DA40]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12,r13
       jle       short M01_L47
M01_L46:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       cmp       r13,r12
       jae       near ptr M01_L66
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M01_L67
       cmp       r12,r13
       jg        short M01_L46
M01_L47:
       jmp       near ptr M01_L36
M01_L48:
       mov       rdx,7FFE2D466D58
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L37
M01_L49:
       mov       rdx,7FFE2D469800
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r8,rax
       jmp       near ptr M01_L38
M01_L50:
       mov       [rbp-78],r8
M01_L51:
       mov       rdi,[rbp-80]
       add       edi,1
       jo        near ptr M01_L67
       mov       r10,rdi
       mov       r8,[rbp-78]
M01_L52:
       mov       rdx,[rbx+8]
       mov       ecx,[rdx+8]
       movsxd    r9,r10d
       cmp       rcx,r9
       jle       near ptr M01_L54
       cmp       r10d,[rdx+8]
       jae       near ptr M01_L66
       mov       [rbp-80],r10
       mov       r9,[rdx+r10*8+10]
       test      r9,r9
       je        short M01_L50
M01_L53:
       mov       r11,[r9+10]
       mov       [rbp-0A8],r11
       mov       [rbp-0A0],r9
       lea       rdx,[r9+18]
       mov       ecx,[rsi+8]
       mov       edi,r13d
       mov       edx,[rdx]
       mov       eax,edx
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ecx,edx
       mov       [rbp-68],ecx
       mov       eax,ecx
       cdq
       idiv      edi
       mov       edi,edx
       mov       [rbp-78],r8
       mov       rcx,r8
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       r8,[rbp-0A0]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-6C],r8d
       mov       r10d,[rbp-68]
       cmp       r10d,[rsi+8]
       jae       near ptr M01_L66
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B8],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       ecx,[rbp-6C]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    rdx,dword ptr [rbp-68]
       mov       rcx,rsi
       mov       r8,[rbp-0B0]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       cmp       edi,[r12+8]
       jae       near ptr M01_L66
       mov       eax,edi
       lea       rax,[r12+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M01_L67
       mov       [rax],edx
       mov       rdi,[rbp-0A8]
       test      rdi,rdi
       mov       r9,rdi
       je        near ptr M01_L51
       mov       r8,[rbp-78]
       jmp       near ptr M01_L53
M01_L54:
       mov       edx,[rsi+8]
       cmp       dword ptr [rbp-50],0
       je        short M01_L55
       mov       ecx,7FFFFFFF
       jmp       short M01_L56
M01_L55:
       mov       eax,edx
       cdq
       idiv      r13d
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
M01_L56:
       mov       rax,[rbp+10]
       mov       [rax+18],ecx
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M01_L58
M01_L57:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       jmp       near ptr M01_L68
M01_L58:
       mov       rdx,7FFE2D466FA0
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L57
M01_L59:
       movsxd    rcx,dword ptr [rax+18]
       imul      rcx,2
       jo        near ptr M01_L67
       mov       edx,7FFFFFFF
       cmp       rcx,7FFFFFFF
       cmovg     rcx,rdx
       movsxd    rdx,ecx
       cmp       rcx,rdx
       jne       short M01_L67
       mov       [rax+18],ecx
       jmp       short M01_L68
M01_L60:
       mov       edx,[rbp-4C]
       add       edx,1
       jo        short M01_L67
       mov       [rbp-4C],edx
       add       edi,1
       jo        short M01_L67
       test      edi,edi
       jg        near ptr M01_L24
M01_L61:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       edi,[rsi+8]
       jae       short M01_L64
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M01_L62
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M01_L63
       jmp       short M01_L65
M01_L62:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L63:
       mov       dword ptr [rbp-54],1
       jmp       short M01_L60
M01_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L65:
       mov       rcx,r14
       call      qword ptr [7FFE2D317600]
       jmp       short M01_L63
M01_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L68:
       xor       ebx,ebx
       cmp       dword ptr [rbp-4C],0
       jg        short M01_L73
M01_L69:
       mov       eax,r15d
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
M01_L70:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L71:
       mov       rcx,rdx
       mov       rdx,7FFE2D469688
       call      qword ptr [7FFE2CC1C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L72:
       add       ebx,1
       jo        near ptr M01_L82
       cmp       ebx,[rbp-4C]
       jge       short M01_L69
M01_L73:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       near ptr M01_L81
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M01_L70
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L72
       jmp       near ptr M01_L80
M01_L74:
       call      qword ptr [7FFE2D1CF588]
       mov       ecx,24AB
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE377C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE377C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE377C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D315C38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D315C50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L75:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L76:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L01
M01_L77:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [r11]
       jmp       near ptr M01_L01
M01_L78:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3163B8]
       jmp       near ptr M01_L18
M01_L79:
       call      M01_L83
       jmp       near ptr M01_L02
M01_L80:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3163B8]
       jmp       near ptr M01_L72
M01_L81:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L83:
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M01_L84
       cmp       qword ptr [rbp-90],0
       je        short M01_L85
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L84
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3163B8]
M01_L84:
       nop
       add       rsp,28
       ret
M01_L85:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-54],0
       je        short M01_L86
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L87
       mov       [rbp-4C],ecx
M01_L86:
       add       rsp,28
       ret
M01_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M01_L88
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L89
       mov       [rbp-4C],ecx
M01_L88:
       add       rsp,28
       ret
M01_L89:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-54],0
       je        short M01_L90
       mov       ecx,[rbp-4C]
       add       ecx,1
       jo        short M01_L91
       mov       [rbp-4C],ecx
M01_L90:
       add       rsp,28
       ret
M01_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-64],0
       je        short M01_L92
       mov       edx,[rbp-4C]
       add       edx,1
       jo        short M01_L93
       mov       [rbp-4C],edx
M01_L92:
       add       rsp,28
       ret
M01_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       ebx,ebx
       cmp       ebx,[rbp-4C]
       jge       short M01_L97
M01_L94:
       mov       rax,[rbp+10]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       ebx,[rcx+8]
       jae       short M01_L98
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M01_L96
       mov       rcx,rsi
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M01_L95
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE2D3163B8]
M01_L95:
       add       ebx,1
       jo        short M01_L99
       cmp       ebx,[rbp-4C]
       jl        short M01_L94
       jmp       short M01_L97
M01_L96:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3162C8]
       int       3
M01_L97:
       add       rsp,28
       ret
M01_L98:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L99:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2909
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       rax,[rcx+88]
       mov       [rax+4C],dl
       ret
; Total bytes of code 11
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-2C],eax
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,24D97800068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,0A84FC21A
       mov       ebx,48BB1035
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L27
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DDF50]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3DEBB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB41408
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       eax,eax
M00_L15:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB41400
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3DE040]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L28
       nop
       mov       eax,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-50],0
       je        short M00_L30
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3DE040]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3DDF50]
       int       3
; Total bytes of code 980
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-2C],eax
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,201AB800068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,3B623A25
       mov       ebx,0CB9BFF28
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L27
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDFC8]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3ED728]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB51510
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       eax,eax
M00_L15:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB51508
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3EE0B8]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L28
       nop
       mov       eax,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-50],0
       je        short M00_L30
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3EE0B8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3EDFC8]
       int       3
; Total bytes of code 980
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-2C],eax
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,1977AC00068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,90CA6426
       mov       ebx,0E7A905A5
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L27
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FE388]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3FD998]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB71428
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       eax,eax
M00_L15:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB71420
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FD9B0]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L28
       nop
       mov       eax,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-50],0
       je        short M00_L30
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D3FD9B0]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFE2D3FE388]
       int       3
; Total bytes of code 980
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetMutatingCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+2E0]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       xor       eax,eax
       mov       [rbp-2C],eax
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rax,[r8+8]
       mov       [rbp-48],rax
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rbp-48]
       mov       r10,[rdx+28]
       test      r10,r10
       je        near ptr M00_L16
       mov       r9,27DB2800068
       mov       r9,[r9]
       mov       r11,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r9],r11
       jne       near ptr M00_L22
       lea       r9,[r10+0C]
       mov       r10d,[r10+8]
       add       r10d,r10d
       mov       r11d,727DB9FD
       mov       ebx,3846DF9C
       cmp       r10d,8
       jb        near ptr M00_L17
       mov       esi,r10d
       shr       esi,3
M00_L00:
       add       r11d,[r9]
       mov       edi,[r9+4]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       add       edi,r11d
       mov       r11d,ebx
       xor       r11d,edi
       rol       edi,14
       add       edi,r11d
       rol       r11d,9
       xor       r11d,edi
       rol       edi,1B
       add       edi,r11d
       rol       r11d,13
       mov       ebx,edi
       add       r9,8
       dec       esi
       mov       ecx,ebx
       mov       ebx,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      r10b,4
       jne       near ptr M00_L18
M00_L01:
       mov       esi,r10d
       and       rsi,7
       mov       r9d,[r9+rsi-4]
       shr       r9d,8
       or        r9d,80000000
       not       r10d
       shl       r10d,3
       shrx      r10d,r9d,r10d
M00_L02:
       add       r10d,r11d
       mov       r9d,ebx
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rsi,[rbx+8]
       mov       rcx,[rbx+10]
       mov       r10d,[rsi+8]
       mov       r9d,[rcx+8]
       mov       r11d,r9d
       mov       eax,[rbp-24]
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r11d
       mov       r14d,edx
       cmp       r14d,r9d
       jae       near ptr M00_L27
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FFE8C89DF30
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       cmp       edi,[rsi+8]
       jae       near ptr M00_L11
       mov       edx,edi
       lea       rsi,[rsi+rdx*8+10]
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L06:
       mov       edx,[rbp-24]
       cmp       edx,[rdi+18]
       je        short M00_L10
M00_L07:
       lea       rsi,[rdi+10]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M00_L06
       jmp       short M00_L13
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE2D316298]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFE2D3175D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rdx,[rdi+8]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-40]
       mov       r11,7FFE2CB71658
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rdi+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L11
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L12
       mov       [rcx],eax
       mov       dword ptr [rbp-2C],1
       jmp       near ptr M00_L26
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L24
M00_L14:
       xor       eax,eax
M00_L15:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       r10d,4
       jb        short M00_L19
M00_L18:
       add       r11d,[r9]
       xor       ebx,r11d
       rol       r11d,14
       add       r11d,ebx
       rol       ebx,9
       xor       ebx,r11d
       rol       r11d,1B
       add       r11d,ebx
       rol       ebx,13
       jmp       near ptr M00_L01
M00_L19:
       mov       esi,80
       test      r10b,1
       je        short M00_L20
       mov       esi,r10d
       and       rsi,2
       movzx     esi,byte ptr [r9+rsi]
       or        esi,8000
M00_L20:
       test      r10b,2
       je        short M00_L21
       shl       esi,10
       movzx     r10d,word ptr [r9]
       or        esi,r10d
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L21:
       mov       r10d,esi
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r9
       mov       rdx,r10
       mov       r10,[r9]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L23:
       mov       rax,[rbp-48]
       mov       rcx,rax
       mov       r11,7FFE2CB71650
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-48]
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D316388]
       jmp       near ptr M00_L14
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       call      M00_L28
       nop
       mov       eax,[rbp-2C]
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-50],0
       je        short M00_L30
       mov       rcx,[rbp-50]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFE2D316388]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FFE2D316298]
       int       3
; Total bytes of code 980
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
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
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

