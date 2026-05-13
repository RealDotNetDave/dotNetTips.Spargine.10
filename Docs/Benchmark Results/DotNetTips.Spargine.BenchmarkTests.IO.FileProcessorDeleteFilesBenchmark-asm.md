## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorDeleteFilesBenchmark.DeleteFiles()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       mov       rdi,[rbx+140]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L83
       mov       r14,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32<System.IO.FileInfo>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+2C],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2DC370001C8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [r15+28],0FFFFFFFE
       jne       near ptr M00_L84
       mov       r13d,[r15+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r13d,eax
       jne       near ptr M00_L84
       xor       ecx,ecx
       mov       [r15+28],ecx
       mov       r13,r15
M00_L00:
       mov       rdx,[r15+18]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r13
M00_L01:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       edx,[rcx+28]
       test      edx,edx
       je        near ptr M00_L06
       cmp       edx,1
       jne       near ptr M00_L11
M00_L02:
       mov       dword ptr [rcx+28],0FFFFFFFD
M00_L03:
       mov       rdx,[rbp-0A8]
       mov       rax,[rdx+20]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rax],rdx
       jne       near ptr M00_L16
       lea       r14,[rax+8]
       mov       rdx,[r14]
       mov       rax,rdx
       mov       r8d,[r14+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L17
       mov       edx,[r14+14]
       cmp       edx,[rax+10]
       jae       near ptr M00_L08
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M00_L18
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
M00_L04:
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+20]
       mov       r11,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L15
       mov       rdx,[rcx+10]
M00_L05:
       test      rdx,rdx
       je        near ptr M00_L03
       mov       rax,[rbp-0A8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0A8]
       mov       dword ptr [rcx+28],1
       mov       r14d,1
       jmp       near ptr M00_L20
M00_L06:
       mov       dword ptr [rcx+28],0FFFFFFFF
       mov       r14,[rcx+10]
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       cmp       [r14],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L07:
       mov       rcx,[rbp-0A0]
       lea       rcx,[rcx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0A0]
       jmp       near ptr M00_L02
M00_L08:
       xor       edx,edx
       mov       [r14+8],rdx
       mov       dword ptr [r14+14],0FFFFFFFF
M00_L09:
       mov       r11,[rbp-0A8]
       mov       dword ptr [r11+28],0FFFFFFFF
       mov       r11,[rbp-0A8]
       mov       r11,[r11+20]
       test      r11,r11
       je        short M00_L10
       mov       rax,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [r11],rax
       jne       near ptr M00_L19
M00_L10:
       mov       rax,[rbp-0A8]
       xor       edx,edx
       mov       [rax+20],rdx
       mov       rcx,[rbp-0A0]
M00_L11:
       xor       r14d,r14d
       jmp       near ptr M00_L20
M00_L12:
       call      qword ptr [7FFBEC5CF618]
       mov       ecx,65
       mov       rdx,7FFBEC40F0A0
       call      qword ptr [7FFBEC2477B0]
       mov       rsi,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2F5548
       call      qword ptr [7FFBEC2477B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC027858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBEC40F0A0
       call      qword ptr [7FFBEC2477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC027858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC835F98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC5CF438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2DC37000460
       mov       r15,[rcx]
       jmp       near ptr M00_L07
       nop
M00_L14:
       mov       rcx,r14
       mov       r11,7FFBEBF71260
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L15:
       mov       r11,7FFBEBF71270
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rax
       mov       r11,7FFBEBF71268
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
       jmp       near ptr M00_L09
M00_L17:
       call      qword ptr [7FFBEC24C150]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r11
       mov       r11,7FFBEBF71278
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L20:
       test      r14d,r14d
       je        near ptr M00_L74
       mov       rcx,[rbp-0A0]
       mov       r14,[rcx+8]
       cmp       qword ptr [rdi+8],0
       je        near ptr M00_L32
M00_L21:
       mov       r15,[rdi+10]
       mov       r13,[rdi+18]
       xor       r12d,r12d
       test      r14,r14
       je        near ptr M00_L56
       mov       rax,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.IO.FileInfo>
       cmp       [r13],rax
       jne       near ptr M00_L58
       mov       [rbp-68],r14
       xor       eax,eax
       mov       [rbp-70],rax
       lea       rax,[rbp-68]
       cmp       qword ptr [rbp-70],0
       jne       short M00_L22
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       lea       rax,[rbp-70]
       cmp       qword ptr [rbp-70],0
       je        near ptr M00_L57
M00_L22:
       mov       rax,[rax]
       mov       [rbp-0C8],rax
       mov       rdx,offset MT_System.IO.FileInfo
       cmp       [rax],rdx
       jne       near ptr M00_L36
       mov       rcx,rax
       call      00007FFC4BC39590
       test      eax,eax
       je        near ptr M00_L35
M00_L23:
       mov       edx,eax
M00_L24:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M00_L25:
       mov       eax,edx
M00_L26:
       mov       [rbp-5C],eax
       mov       rdx,[rdi+8]
       mov       r8d,eax
       imul      r8,[rdi+20]
       shr       r8,20
       inc       r8
       mov       r11d,[rdx+8]
       mov       r10d,r11d
       imul      r8,r10
       shr       r8,20
       cmp       r8d,r11d
       jae       near ptr M00_L73
       mov       r8d,r8d
       lea       r10,[rdx+r8*4+10]
       mov       [rbp-0B8],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L29
M00_L27:
       cmp       r9d,[r15+8]
       jae       near ptr M00_L73
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r15+rdx+10]
       mov       [rbp-0C0],r9
       cmp       [r9+8],eax
       je        near ptr M00_L59
M00_L28:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M00_L72
       test      r9d,r9d
       mov       eax,[rbp-5C]
       jge       short M00_L27
M00_L29:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M00_L60
       mov       edx,[rdi+28]
       mov       [rbp-60],edx
       cmp       [r15+8],edx
       je        near ptr M00_L37
M00_L30:
       mov       edx,[rbp-60]
       mov       r15d,edx
       lea       edx,[r15+1]
       mov       [rdi+28],edx
       mov       rdx,[rdi+10]
       mov       r8,rdx
M00_L31:
       cmp       r15d,[r8+8]
       jae       near ptr M00_L73
       mov       edx,r15d
       shl       rdx,4
       mov       [rbp-0B0],r8
       lea       r9,[r8+rdx+10]
       mov       [r9+8],eax
       mov       r10,[rbp-0B8]
       mov       edx,[r10]
       dec       edx
       mov       [r9+0C],edx
       mov       rcx,r9
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-0B8]
       mov       [rdx],r15d
       inc       dword ptr [rdi+34]
       cmp       r12d,64
       jbe       near ptr M00_L01
       jmp       near ptr M00_L71
M00_L32:
       mov       rax,7FFC49680B08
       xor       edx,edx
       mov       r8d,48
M00_L33:
       mov       r15d,[rax+rdx]
       test      r15d,r15d
       jge       short M00_L34
       add       rdx,4
       dec       r8d
       jne       short M00_L33
       jmp       near ptr M00_L50
M00_L34:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
       jmp       near ptr M00_L21
M00_L35:
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFBEC02EEC8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L23
M00_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edx,eax
       jmp       near ptr M00_L24
M00_L37:
       mov       r8d,[rdi+28]
       lea       r10d,[r8+r8]
       cmp       r10d,7FFFFFC3
       ja        near ptr M00_L61
M00_L38:
       mov       ecx,r10d
       call      qword ptr [7FFBEC025A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
M00_L39:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0D0],rax
       mov       r10d,[rdi+28]
       mov       [rbp-74],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-0D8],rdx
       test      rdx,rdx
       je        near ptr M00_L68
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L67
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L66
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L65
       cmp       r10d,[rax+8]
       ja        near ptr M00_L64
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L45
       mov       rax,[rbp-0D0]
       cmp       r8,4000
       jbe       near ptr M00_L44
       mov       rcx,r9
       call      qword ptr [7FFBEC6D5260]
M00_L40:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
       xor       ecx,ecx
       mov       r15d,[rbp-74]
       test      r15d,r15d
       jle       near ptr M00_L49
       mov       r8,[rbp-0D0]
       cmp       [r8+8],r15d
       jl        near ptr M00_L46
M00_L41:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[r8+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M00_L42
       mov       eax,[rdx+8]
       mov       r10,[rdi+8]
       mov       r9d,eax
       imul      r9,[rdi+20]
       shr       r9,20
       inc       r9
       mov       eax,[r10+8]
       mov       r11d,eax
       imul      r9,r11
       shr       r9,20
       cmp       r9d,eax
       jae       near ptr M00_L73
       mov       r9d,r9d
       lea       rax,[r10+r9*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [rdx+0C],r10d
       lea       edx,[rcx+1]
       mov       [rax],edx
M00_L42:
       inc       ecx
       cmp       ecx,r15d
       jl        short M00_L41
M00_L43:
       lea       rcx,[rdi+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r15d,[rbp-5C]
       mov       edx,r15d
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-0B8],rax
       mov       eax,r15d
       jmp       near ptr M00_L30
M00_L44:
       mov       rcx,r9
       call      00007FFC4BC39170
       cmp       dword ptr [7FFC4BF639A0],0
       je        near ptr M00_L40
       jmp       near ptr M00_L63
M00_L45:
       mov       rcx,r9
       call      qword ptr [7FFBEC025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L40
M00_L46:
       mov       eax,[r8+8]
M00_L47:
       cmp       ecx,[r8+8]
       jae       near ptr M00_L73
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[r8+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M00_L48
       mov       eax,[rdx+8]
       mov       r10,[rdi+8]
       mov       r9d,eax
       imul      r9,[rdi+20]
       shr       r9,20
       inc       r9
       mov       eax,[r10+8]
       imul      r9,rax
       shr       r9,20
       cmp       r9d,[r10+8]
       jae       near ptr M00_L73
       mov       eax,r9d
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [rdx+0C],r10d
       lea       edx,[rcx+1]
       mov       [rax],edx
M00_L48:
       inc       ecx
       cmp       ecx,r15d
       jl        short M00_L47
       jmp       near ptr M00_L43
M00_L49:
       mov       r8,[rbp-0D0]
       jmp       near ptr M00_L43
M00_L50:
       mov       r15d,1
       jmp       short M00_L53
M00_L51:
       mov       ecx,r15d
       call      qword ptr [7FFBEC6D52A8]
       test      eax,eax
       je        short M00_L52
       lea       ecx,[r15-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       edx,eax
       imul      edx,65
       sub       ecx,edx
       jne       short M00_L54
M00_L52:
       add       r15d,2
M00_L53:
       cmp       r15d,7FFFFFFF
       jl        short M00_L51
       jmp       short M00_L55
M00_L54:
       jmp       near ptr M00_L34
M00_L55:
       xor       r15d,r15d
       jmp       near ptr M00_L34
M00_L56:
       xor       eax,eax
       jmp       near ptr M00_L26
M00_L57:
       xor       edx,edx
       jmp       near ptr M00_L24
M00_L58:
       mov       rcx,r13
       mov       rdx,r14
       mov       r11,7FFBEBF71250
       call      qword ptr [r11]
       mov       edx,eax
       jmp       near ptr M00_L25
M00_L59:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,r14
       mov       r11,7FFBEBF71258
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-0C0]
       jne       near ptr M00_L01
       jmp       near ptr M00_L28
M00_L60:
       mov       edx,[rdi+2C]
       mov       r8d,edx
       dec       dword ptr [rdi+30]
       mov       edx,[rdi+2C]
       cmp       edx,[r15+8]
       jae       near ptr M00_L73
       shl       rdx,4
       mov       edx,[r15+rdx+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rdi+2C],edx
       mov       ecx,r8d
       mov       r8,r15
       mov       r15d,ecx
       jmp       near ptr M00_L31
M00_L61:
       cmp       r8d,7FFFFFC3
       jge       short M00_L62
       mov       r15d,7FFFFFC3
       jmp       near ptr M00_L39
M00_L62:
       jmp       near ptr M00_L38
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L40
M00_L64:
       jmp       short M00_L69
M00_L65:
       jmp       short M00_L69
M00_L66:
       jmp       short M00_L69
M00_L67:
       jmp       short M00_L69
M00_L68:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       jmp       short M00_L70
M00_L69:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFBEC6D59C8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-78],eax
       mov       rax,[rbp-0D0]
M00_L70:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFBEC6D59C8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-74]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-78]
       mov       r8,[rbp-0D0]
       call      qword ptr [7FFBEC6D59E0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L40
M00_L71:
       mov       r15,[rbp-0B0]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L01
       mov       edx,[r15+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFBEC3ACE10]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFBEC02EEE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L01
M00_L72:
       call      qword ptr [7FFBEC247A20]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       mov       rcx,[rbp-0A0]
       mov       r14d,[rcx+28]
       cmp       r14d,0FFFFFFFD
       je        near ptr M00_L85
       cmp       r14d,1
       je        near ptr M00_L85
M00_L75:
       xor       eax,eax
       mov       [rcx+20],rax
       mov       dword ptr [rcx+28],0FFFFFFFE
       mov       ecx,[rdi+28]
       test      ecx,ecx
       jle       short M00_L76
       mov       rax,[rdi+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L86
M00_L76:
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rdi
       mov       r11,7FFBEBF712A0
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M00_L87
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.IO.FileInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
       mov       rcx,rdi
       mov       r11,7FFBEBF712A8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [r14+10],r15d
M00_L77:
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L83
       xor       edi,edi
       cmp       qword ptr [rsi+8],0
       jne       near ptr M00_L88
       xor       r15d,r15d
M00_L78:
       lea       rcx,[rbp-90]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC836A78]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.List`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-40],rcx
       lea       rcx,[rbp-50]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC2444E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M00_L82
M00_L79:
       mov       esi,edi
M00_L80:
       mov       [rbp-98],esi
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC65EE20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L81:
       mov       rcx,rsi
       mov       r8,r15
       call      qword ptr [7FFBEC65E9B8]; DotNetTips.Spargine.IO.FileProcessor.DeleteFileItem(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       edi,eax
       jo        near ptr M00_L90
       lea       rcx,[rbp-50]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC2444E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L79
M00_L82:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rbp-58],0
       je        short M00_L81
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       je        short M00_L81
       jmp       near ptr M00_L89
M00_L83:
       xor       esi,esi
       jmp       short M00_L80
M00_L84:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFBEC65E9D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L85:
       call      qword ptr [7FFBEC65EA60]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0A0]
       jmp       near ptr M00_L75
M00_L86:
       mov       edx,ecx
       sub       edx,[rdi+30]
       mov       rcx,rdi
       call      qword ptr [7FFBEC8360B8]
       jmp       near ptr M00_L76
M00_L87:
       mov       rcx,2DC370001C0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L77
       int       3
M00_L88:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,31CB6020CD0
       call      qword ptr [7FFBEC65E988]
       jmp       near ptr M00_L78
M00_L89:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFBEC834EA0]
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFBEC6B4080]; Precode of DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-0A0]
       mov       r14d,[rcx+28]
       cmp       r14d,0FFFFFFFD
       je        short M00_L91
       cmp       r14d,1
       jne       short M00_L92
M00_L91:
       call      qword ptr [7FFBEC65EA60]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0A0]
M00_L92:
       xor       edx,edx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+28],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       int       3
; Total bytes of code 3270
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
       call      00007FFC4BCA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEC025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBEC025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,31CB6010008
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
       call      qword ptr [7FFBEC6D69D0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFBEC025C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       cmp       qword ptr [rbp+10],0
       je        short M03_L03
       lea       rcx,[rbp+10]
       mov       rax,7FFBEC17ACC0
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFC4BC442E0
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFC4BF639A0],0
       je        short M03_L01
       call      qword ptr [7FFC4BF51648]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rcx,[rbp-68]
       mov       [rbx+8],rcx
M03_L02:
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
M03_L03:
       xor       eax,eax
       jmp       short M03_L02
; Total bytes of code 165
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M04_L02
       mov       rcx,7FFC49680B08
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M04_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M04_L01
       add       rax,4
       dec       edx
       jne       short M04_L00
       jmp       short M04_L03
M04_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6D5290]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC3A5320]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M04_L06
M04_L04:
       mov       ecx,esi
       call      qword ptr [7FFBEC6D52A8]
       test      eax,eax
       je        short M04_L05
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M04_L07
M04_L05:
       add       esi,2
M04_L06:
       cmp       esi,7FFFFFFF
       jl        short M04_L04
       jmp       short M04_L08
M04_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L03
       test      r8b,18
       je        short M05_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M05_L00:
       vzeroupper
       ret
M05_L01:
       test      r8b,4
       jne       short M05_L02
       test      r8,r8
       je        short M05_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M05_L00
M05_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M05_L00
M05_L03:
       cmp       r8,40
       ja        short M05_L06
M05_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M05_L00
M05_L06:
       cmp       r8,800
       ja        short M05_L11
       cmp       r8,100
       jae       short M05_L09
M05_L07:
       mov       r9,r8
       shr       r9,6
M05_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L08
       and       r8,3F
       cmp       r8,10
       ja        short M05_L04
       jmp       short M05_L05
M05_L09:
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
       jmp       short M05_L07
M05_L10:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L00
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBEC0266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 312
```
```assembly
; System.Array.GetLowerBound(Int32)
       push      rbx
       sub       rsp,20
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       r8d,eax
       or        r8d,edx
       je        short M06_L00
       cmp       edx,eax
       jae       short M06_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFC4A2EE650]
       mov       rbx,rax
       call      qword ptr [7FFC4A2F98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4A2F8058]
       mov       rcx,rbx
       call      qword ptr [7FFC4A2E3FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
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
       je        near ptr M07_L07
       test      rsi,rsi
       je        near ptr M07_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M07_L00
       mov       rax,[rbx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,1
       test      eax,eax
       cmove     eax,ecx
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       cmp       eax,ecx
       jne       near ptr M07_L08
M07_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M07_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC4A2F5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFC4A30C8F8]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC4A2F5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFC4A30C8F8]
       int       3
M07_L02:
       sub       ebp,eax
       js        near ptr M07_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M07_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M07_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC4A2F5298]
       test      eax,eax
       jne       near ptr M07_L16
M07_L03:
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
       je        near ptr M07_L15
       cmp       r8,4000
       ja        near ptr M07_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC4A2F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M07_L12
M07_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M07_L13
M07_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC4A2F71F0]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFC4A2F71F0]
       int       3
M07_L08:
       call      qword ptr [7FFC4A2EE770]
       mov       rbx,rax
       call      qword ptr [7FFC4A2F9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4A2F8778]
       mov       rcx,rbx
       call      qword ptr [7FFC4A2E3FC0]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFC4A30C8E0]
       int       3
M07_L10:
       call      qword ptr [7FFC4A2EE538]
       mov       rbx,rax
       call      qword ptr [7FFC4A2F8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFC4A2F71A0]
       mov       rcx,rbx
       call      qword ptr [7FFC4A2E3FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FFC4A2EE538]
       mov       r14,rax
       call      qword ptr [7FFC4A2F8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFC4A2F71A0]
       mov       rcx,r14
       call      qword ptr [7FFC4A2E3FC0]; CORINFO_HELP_THROW
       int       3
M07_L12:
       call      qword ptr [7FFC4A2E4040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L04
M07_L13:
       call      qword ptr [7FFC4A2E4040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L05
M07_L14:
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
M07_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFC4A2F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L04
M07_L16:
       cmp       byte ptr [rsp+78],0
       je        short M07_L17
       call      qword ptr [7FFC4A2EE560]
       mov       rbx,rax
       call      qword ptr [7FFC4A2F9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC4A2F7218]
       mov       rcx,rbx
       call      qword ptr [7FFC4A2E3FC0]; CORINFO_HELP_THROW
       int       3
M07_L17:
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
; Total bytes of code 738
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
M08_L00:
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       jne       short M08_L03
M08_L01:
       xor       edx,edx
M08_L02:
       mov       rax,rdx
       ret
M08_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       jmp       short M08_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M09_L01
       mov       rcx,rax
M09_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M09_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M09_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L13
       cmp       r14d,[r15+8]
       ja        near ptr M09_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M09_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M09_L11
       cmp       r8,4000
       ja        short M09_L02
       mov       rcx,rax
       call      00007FFC4BC39170
       cmp       dword ptr [7FFC4BF639A0],0
       je        short M09_L03
       jmp       near ptr M09_L10
M09_L01:
       mov       rdx,7FFBEC82F458
       call      qword ptr [7FFBEC02C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L00
       nop
M09_L02:
       mov       rcx,rax
       call      qword ptr [7FFBEC6D5260]
M09_L03:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M09_L15
M09_L04:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M09_L07
       cmp       [rbp+8],r14d
       jl        short M09_L08
M09_L05:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L06
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M09_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L06:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L05
M09_L07:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L08:
       cmp       ecx,[rbp+8]
       jae       near ptr M09_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L09
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M09_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L09:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L08
       jmp       near ptr M09_L07
M09_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M09_L03
M09_L11:
       mov       rcx,rax
       call      qword ptr [7FFBEC025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L03
M09_L12:
       xor       r13d,r13d
       jmp       short M09_L14
M09_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFBEC6D59C8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M09_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFBEC6D59C8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFBEC6D59E0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M09_L03
M09_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+88]
       test      rdi,rdi
       je        short M09_L16
       jmp       short M09_L17
M09_L16:
       mov       rdx,7FFBEC82F3B8
       call      qword ptr [7FFBEC02C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M09_L17:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M09_L04
M09_L18:
       cmp       r15d,[rbp+8]
       jae       short M09_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M09_L23
       cmp       qword ptr [r13],0
       jne       short M09_L19
       xor       r12d,r12d
       jmp       short M09_L22
M09_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M09_L20
       jmp       short M09_L21
M09_L20:
       mov       rdx,7FFBEC6E35B0
       call      qword ptr [7FFBEC02C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M09_L22:
       mov       [r13+8],r12d
M09_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M09_L18
       jmp       near ptr M09_L04
M09_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 846
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M10_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M10_L08
M10_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M10_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M10_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M10_L12
M10_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.IO.FileInfo
       cmp       [r15],rcx
       jne       near ptr M10_L10
       mov       rcx,r15
       call      00007FFC4BC39590
       test      eax,eax
       je        near ptr M10_L09
M10_L02:
       mov       r15d,eax
M10_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M10_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M10_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M10_L07
M10_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M10_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M10_L14
M10_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M10_L17
       test      r13d,r13d
       jge       short M10_L05
M10_L07:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L08:
       mov       rdx,7FFBEC6E35B0
       call      qword ptr [7FFBEC02C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L09:
       mov       rcx,r15
       call      qword ptr [7FFBEC02EEC8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M10_L02
M10_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M10_L03
M10_L11:
       xor       r15d,r15d
       jmp       near ptr M10_L04
M10_L12:
       xor       r15d,r15d
       jmp       near ptr M10_L03
M10_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L04
M10_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M10_L15
       jmp       short M10_L16
M10_L15:
       mov       rdx,7FFBEC6E35C8
       call      qword ptr [7FFBEC02C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M10_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M10_L06
       mov       eax,r13d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L17:
       call      qword ptr [7FFBEC247A20]
       int       3
M10_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.List`1<System.__Canon>)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       xor       ecx,ecx
       mov       [rbx+14],ecx
       mov       [rbx+8],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC4A2E3FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsi+14]
       mov       [rbx+10],eax
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M12_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M12_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M12_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       call      qword ptr [7FFBEC24C150]
       int       3
M12_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.DeleteFileItem(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
; 		if (!file.Exists)
; 		^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = file.FullName, ProgressState = FileProgressState.Error });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		long fileLength = 0;
; 		^^^^^^^^^^^^^^^^^^^^
; 			fileLength = file.Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FileHelper.RemoveReadOnlyAttribute(file);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			psw?.Start();
; 			^^^^^^^^^^^^^
; 			file.Delete();
; 			^^^^^^^^^^^^^^
; 			var perf = psw?.StopReset() ?? TimeSpan.Zero;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenDeleted, Name = file.FullName, ProgressState = FileProgressState.FileDeleted, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return 1;
; 			^^^^^^^^^
; 	}
; 	^
; 		catch (Exception ex) // Report all errors
; 		^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = file.FullName, ProgressState = FileProgressState.Error, Size = fileLength });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC69AB88]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M14_L49
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M14_L21
M14_L00:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M14_L23
       test      byte ptr [rbx+30],10
       jne       near ptr M14_L22
       cmp       dword ptr [rbx+28],0
       jne       near ptr M14_L23
       mov       ecx,[rbx+4C]
       shl       rcx,20
       mov       eax,[rbx+50]
       or        rcx,rax
       mov       [rbp-40],rcx
       mov       rcx,rbx
       call      qword ptr [7FFBEC69AB88]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M14_L05
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M14_L24
M14_L01:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M14_L25
       mov       edi,[rbx+30]
       and       edi,0FFFFFFFE
       mov       r14,[rbx+8]
       test      r14,r14
       je        short M14_L02
       mov       ecx,[r14+8]
       cmp       ecx,104
       jge       near ptr M14_L26
       test      ecx,ecx
       je        short M14_L02
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M14_L26
       cmp       ecx,2E
       je        near ptr M14_L26
M14_L02:
       mov       rax,r14
M14_L03:
       test      rax,rax
       je        near ptr M14_L19
       add       rax,0C
       mov       r15,rax
M14_L04:
       mov       [rbp-50],r15
       xor       ecx,ecx
       call      00007FFBEC018D68
       mov       rcx,r15
       mov       edx,edi
       call      00007FFBEC018ED0
       mov       edi,eax
       call      00007FFBEC018D98
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-50],rax
       call      00007FFC4BCA6B40
       test      edi,edi
       je        near ptr M14_L27
       mov       dword ptr [rbx+28],0FFFFFFFF
M14_L05:
       test      rsi,rsi
       jne       near ptr M14_L29
M14_L06:
       mov       rdi,[rbx+8]
       test      rdi,rdi
       je        short M14_L07
       mov       ecx,[rdi+8]
       cmp       ecx,104
       jge       near ptr M14_L30
       test      ecx,ecx
       je        short M14_L07
       dec       ecx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M14_L30
       cmp       ecx,2E
       je        near ptr M14_L30
M14_L07:
       mov       rax,rdi
M14_L08:
       test      rax,rax
       je        near ptr M14_L20
       add       rax,0C
       mov       r14,rax
M14_L09:
       mov       [rbp-58],r14
       xor       ecx,ecx
       call      00007FFBEC018D68
       mov       rcx,r14
       call      00007FFBEC018EE8
       mov       r14d,eax
       call      00007FFBEC018D98
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-58],rax
       call      00007FFC4BCA6B40
       test      r14d,r14d
       jne       short M14_L10
       call      00007FFC4BCA6B20
       cmp       eax,2
       jne       near ptr M14_L31
M14_L10:
       mov       byte ptr [rbx+2C],0
       mov       dword ptr [rbx+28],0FFFFFFFF
       test      rsi,rsi
       jne       near ptr M14_L32
       xor       edi,edi
M14_L11:
       mov       [rbp-68],rdi
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,31CB6010008
       mov       rsi,[rbp-70]
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       mov       rcx,2DC370001E8
       cmp       qword ptr [rcx],0
       je        near ptr M14_L33
M14_L12:
       mov       rcx,2DC370001E8
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rdi],rcx
       jne       near ptr M14_L43
       mov       rcx,2DC370001F0
       mov       r14,[rcx]
       test      r14,r14
       jne       short M14_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M14_L34
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M14_L34
M14_L13:
       mov       r14,[rax+18]
       test      r14,r14
       jne       short M14_L14
       mov       rax,2DC21000108
       mov       r14,[rax]
       test      r14,r14
       jne       short M14_L14
       mov       rax,2DC210000F8
       mov       r14,[rax]
       test      r14,r14
       jne       short M14_L14
       call      qword ptr [7FFBEC244150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       r14,rax
M14_L14:
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFBEC4563D0]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       r15,rax
       test      r15,r15
       je        near ptr M14_L37
       movzx     r8d,byte ptr [rdi+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [r15],rcx
       jne       near ptr M14_L36
       mov       rcx,r15
       mov       rdx,31CB6020DA0
       mov       r9d,1
       call      qword ptr [7FFBEC456EC8]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       rdx,rax
       test      rdx,rdx
       je        short M14_L15
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M14_L35
M14_L15:
       test      rdx,rdx
       je        near ptr M14_L37
M14_L16:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       mov       rdx,[rbp-40]
       mov       [rsi+18],rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,qword ptr [rbp-68]
       vdivsd    xmm0,xmm0,[7FFBEC789328]
       vucomisd  xmm0,qword ptr [7FFBEC789330]
       ja        near ptr M14_L44
       vmovsd    xmm1,qword ptr [7FFBEC789338]
       vucomisd  xmm1,xmm0
       ja        near ptr M14_L45
M14_L17:
       vmovsd    qword ptr [rsi+20],xmm0
       mov       rdx,offset MT_DotNetTips.Spargine.IO.FileProcessor
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M14_L47
       mov       rax,[rcx+8]
       test      rax,rax
       jne       near ptr M14_L46
M14_L18:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M14_L48
M14_L19:
       xor       r15d,r15d
       jmp       near ptr M14_L04
M14_L20:
       xor       r14d,r14d
       jmp       near ptr M14_L09
M14_L21:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FFBEC8341E0]
       jmp       near ptr M14_L00
M14_L22:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC834EB8]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FFBEC5CED30]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFBEC834ED0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M14_L23:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FFBEC6DE3A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L24:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FFBEC8341E0]
       jmp       near ptr M14_L01
M14_L25:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FFBEC6DE3A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L26:
       mov       rcx,r14
       call      qword ptr [7FFBEC65DE60]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M14_L03
M14_L27:
       call      00007FFC4BCA6B20
       cmp       eax,57
       jne       short M14_L28
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFBEC834E88]
       mov       rsi,rax
       mov       ecx,1C44A
       mov       rdx,7FFBEBF64000
       call      qword ptr [7FFBEC2477B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r14
       call      qword ptr [7FFBEC3A71E0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M14_L28:
       mov       ecx,eax
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFBEC6DE3A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L29:
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EBF8]
       jmp       near ptr M14_L06
M14_L30:
       mov       rcx,rdi
       call      qword ptr [7FFBEC65DE60]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M14_L08
M14_L31:
       mov       ecx,eax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFBEC6DE3A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L32:
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EC28]
       mov       rdi,rax
       jmp       near ptr M14_L11
M14_L33:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,31CB6020E48
       call      qword ptr [7FFBEC836388]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,31CB6020DE0
       call      qword ptr [7FFBEC456220]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,2DC370001E8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M14_L12
M14_L34:
       mov       ecx,2
       call      qword ptr [7FFBEC6DDEC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M14_L13
M14_L35:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M14_L36:
       mov       rcx,r15
       mov       rdx,31CB6020DA0
       mov       rax,[r15]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M14_L15
M14_L37:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r8,[rdi+30]
       mov       rcx,r13
       mov       rdx,r14
       mov       r9d,1
       call      qword ptr [7FFBEC834048]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-78],r14
M14_L38:
       mov       rcx,[rbp-78]
       call      qword ptr [7FFBEC49BA70]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M14_L41
       mov       rcx,[rbp-78]
       mov       r14,[rcx+8]
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFBEC168720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M14_L41
       cmp       r13,r15
       je        short M14_L38
       movzx     r8d,byte ptr [rdi+54]
       mov       rcx,r13
       mov       rdx,31CB6020DA0
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r12,rax
       test      r12,r12
       jne       short M14_L39
       mov       r15,r13
       jmp       short M14_L38
M14_L39:
       cmp       qword ptr [rdi+38],0
       je        short M14_L40
       mov       rdx,[rdi+38]
       mov       [rbp-88],rdx
       mov       byte ptr [rbp-60],0
       lea       rdx,[rbp-60]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFBEC025998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rdi+38]
       lea       rcx,[rcx+8]
       mov       [rbp-90],rcx
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+38]
       lea       rcx,[rcx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-60],0
       je        short M14_L40
       mov       rcx,[rbp-88]
       call      qword ptr [7FFBEC026820]; System.Threading.Monitor.Exit(System.Object)
M14_L40:
       mov       [rbp-80],r12
       jmp       short M14_L42
M14_L41:
       xor       edx,edx
       mov       rcx,[rbp-78]
       mov       [rcx+18],rdx
       mov       dword ptr [rcx+20],0FFFFFFFE
       jmp       near ptr M14_L16
M14_L42:
       call      M14_L51
       nop
       mov       rdx,[rbp-80]
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-70]
       jmp       near ptr M14_L16
M14_L43:
       mov       r8,2DC370001F0
       mov       r8,[r8]
       mov       rcx,rdi
       mov       rdx,31CB6020DA0
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       jmp       near ptr M14_L16
M14_L44:
       vmovsd    xmm0,qword ptr [7FFBEC789330]
       jmp       near ptr M14_L17
M14_L45:
       vmovsd    xmm0,qword ptr [7FFBEC789338]
       jmp       near ptr M14_L17
M14_L46:
       mov       rdx,rcx
       mov       r8,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M14_L18
M14_L47:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp+10]
       jmp       near ptr M14_L18
M14_L48:
       mov       eax,[rbp-44]
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L49:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EB38]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       call      qword ptr [7FFBEC65EB50]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       xor       eax,eax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-60],0
       je        short M14_L50
       mov       rcx,[rbp-88]
       call      qword ptr [7FFBEC026820]; System.Threading.Monitor.Exit(System.Object)
M14_L50:
       nop
       add       rsp,28
       ret
M14_L51:
       sub       rsp,28
       vzeroupper
       xor       r8d,r8d
       mov       rcx,[rbp-78]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EB38]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       mov       rcx,rbx
       mov       edx,2C
       call      qword ptr [7FFBEC65ECA0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EB68]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Message(System.String)
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBEC351BF0]; System.IO.FileSystemInfo.get_FullName()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC65EB80]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC65EB98]; DotNetTips.Spargine.IO.ProgressEventArgs.set_ProgressState(DotNetTips.Spargine.IO.FileProgressState)
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC65EC58]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Size(Int64)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       xor       eax,eax
       mov       [rbp-44],eax
       lea       rax,[M14_L48]
       add       rsp,28
       ret
; Total bytes of code 2247
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       [rbx+28],edx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       dword ptr [rax+28],0FFFFFFFF
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+20],0
       je        short M16_L00
       mov       rcx,7FFBEC87D2D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+20]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FFBEC87D2E0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r11,7FFBEBF70EB8
       call      qword ptr [r11]
M16_L00:
       mov       rcx,7FFBEC87D3E8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 139
```

