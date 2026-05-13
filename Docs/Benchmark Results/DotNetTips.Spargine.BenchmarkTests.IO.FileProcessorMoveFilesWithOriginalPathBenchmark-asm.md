## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileProcessorMoveFilesWithOriginalPathBenchmark.MoveFilesWithOriginalPath()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+140]
       mov       rdi,[rbx+148]
       mov       r14,[rbx+138]
       cmp       [rsi],sil
       test      r14,r14
       je        near ptr M00_L87
       test      rdi,rdi
       je        near ptr M00_L88
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32<System.IO.FileInfo>
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+2C],eax
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,20D34400190
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [r13+28],0FFFFFFFE
       jne       near ptr M00_L89
       mov       r12d,[r13+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r12d,eax
       jne       near ptr M00_L89
       xor       ecx,ecx
       mov       [r13+28],ecx
       mov       r12,r13
M00_L00:
       mov       rdx,[r13+18]
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0D0],r12
M00_L01:
       mov       rcx,[rbp-0D0]
       mov       [rbp-0D8],rcx
       mov       edx,[rcx+28]
       test      edx,edx
       je        near ptr M00_L06
       cmp       edx,1
       jne       near ptr M00_L11
M00_L02:
       mov       dword ptr [rcx+28],0FFFFFFFD
M00_L03:
       mov       rdx,[rbp-0D8]
       mov       rax,[rdx+20]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rax],rdx
       jne       near ptr M00_L16
       lea       r15,[rax+8]
       mov       rdx,[r15]
       mov       rax,rdx
       mov       r8d,[r15+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M00_L17
       mov       edx,[r15+14]
       cmp       edx,[rax+10]
       jae       near ptr M00_L08
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M00_L18
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r15+14]
M00_L04:
       mov       rcx,[rbp-0D8]
       mov       rcx,[rcx+20]
       mov       r11,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L15
       mov       rdx,[rcx+10]
M00_L05:
       test      rdx,rdx
       je        near ptr M00_L03
       mov       rax,[rbp-0D8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       dword ptr [rcx+28],1
       mov       r15d,1
       jmp       near ptr M00_L20
M00_L06:
       mov       dword ptr [rcx+28],0FFFFFFFF
       mov       r15,[rcx+10]
       mov       rdx,r15
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       cmp       [r15],rcx
       jne       near ptr M00_L14
       cmp       dword ptr [r15+10],0
       je        near ptr M00_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r15+14]
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       mov       [r13+18],r12d
       mov       [r13+1C],ecx
M00_L07:
       mov       rcx,[rbp-0D0]
       lea       rcx,[rcx+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       jmp       near ptr M00_L02
M00_L08:
       xor       edx,edx
       mov       [r15+8],rdx
       mov       dword ptr [r15+14],0FFFFFFFF
M00_L09:
       mov       r11,[rbp-0D8]
       mov       dword ptr [r11+28],0FFFFFFFF
       mov       r11,[rbp-0D8]
       mov       r11,[r11+20]
       test      r11,r11
       je        short M00_L10
       mov       rax,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [r11],rax
       jne       near ptr M00_L19
M00_L10:
       mov       rax,[rbp-0D8]
       xor       edx,edx
       mov       [rax+20],rdx
       mov       rcx,[rbp-0D0]
M00_L11:
       xor       r15d,r15d
       jmp       near ptr M00_L20
M00_L12:
       call      qword ptr [7FFBEC5AC4E0]
       mov       ecx,65
       mov       rdx,7FFBEC4006D8
       call      qword ptr [7FFBEC2277B0]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2D5548
       call      qword ptr [7FFBEC2277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC007858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBEC4006D8
       call      qword ptr [7FFBEC2277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC007858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC6BFBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC62F3F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20D344003C0
       mov       r13,[rcx]
       jmp       near ptr M00_L07
M00_L14:
       mov       rcx,r15
       mov       r11,7FFBEBF51108
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L15:
       mov       r11,7FFBEBF51118
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rax
       mov       r11,7FFBEBF51110
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
       jmp       near ptr M00_L09
M00_L17:
       call      qword ptr [7FFBEC22C150]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r11
       mov       r11,7FFBEBF51120
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L20:
       test      r15d,r15d
       je        near ptr M00_L73
       mov       rcx,[rbp-0D0]
       mov       r15,[rcx+8]
       cmp       qword ptr [rdi+8],0
       je        near ptr M00_L32
M00_L21:
       mov       r13,[rdi+10]
       mov       r12,[rdi+18]
       xor       eax,eax
       mov       [rbp-5C],eax
       test      r15,r15
       je        near ptr M00_L56
       mov       rdx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.IO.FileInfo>
       cmp       [r12],rdx
       jne       near ptr M00_L36
       mov       [rbp-70],r15
       xor       edx,edx
       mov       [rbp-78],rdx
       lea       rdx,[rbp-70]
       cmp       qword ptr [rbp-78],0
       jne       short M00_L22
       mov       rdx,[rbp-70]
       mov       [rbp-78],rdx
       lea       rdx,[rbp-78]
       cmp       qword ptr [rbp-78],0
       je        near ptr M00_L57
M00_L22:
       mov       rdx,[rdx]
       mov       [rbp-100],rdx
       mov       r8,offset MT_System.IO.FileInfo
       cmp       [rdx],r8
       jne       near ptr M00_L58
       mov       rcx,rdx
       call      00007FFC4BC39590
       test      eax,eax
       je        near ptr M00_L35
M00_L23:
       mov       r8d,eax
M00_L24:
       xor       ecx,ecx
       mov       [rbp-78],rcx
M00_L25:
       mov       eax,r8d
M00_L26:
       mov       [rbp-60],eax
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
       jae       near ptr M00_L72
       mov       r8d,r8d
       lea       r10,[rdx+r8*4+10]
       mov       [rbp-0E8],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L29
M00_L27:
       cmp       r9d,[r13+8]
       jae       near ptr M00_L72
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r13+rdx+10]
       mov       [rbp-0F0],r9
       cmp       [r9+8],eax
       je        near ptr M00_L37
M00_L28:
       mov       r9d,[r9+0C]
       mov       edx,[rbp-5C]
       inc       edx
       mov       [rbp-5C],edx
       cmp       [r13+8],edx
       jb        near ptr M00_L71
       test      r9d,r9d
       mov       eax,[rbp-60]
       jge       short M00_L27
M00_L29:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M00_L59
       mov       r8d,[rdi+28]
       mov       [rbp-64],r8d
       cmp       [r13+8],r8d
       je        near ptr M00_L38
M00_L30:
       mov       r8d,[rbp-64]
       mov       r13d,r8d
       lea       r8d,[r13+1]
       mov       [rdi+28],r8d
       mov       r8,[rdi+10]
M00_L31:
       cmp       r13d,[r8+8]
       jae       near ptr M00_L72
       mov       r9d,r13d
       shl       r9,4
       mov       [rbp-0E0],r8
       lea       r9,[r8+r9+10]
       mov       [r9+8],eax
       mov       r10,[rbp-0E8]
       mov       eax,[r10]
       dec       eax
       mov       [r9+0C],eax
       mov       rcx,r9
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       rdx,[rbp-0E8]
       mov       [rdx],r13d
       inc       dword ptr [rdi+34]
       cmp       dword ptr [rbp-5C],64
       jbe       near ptr M00_L01
       jmp       near ptr M00_L70
M00_L32:
       mov       rax,7FFC49680B08
       xor       edx,edx
       mov       r8d,48
M00_L33:
       mov       r13d,[rax+rdx]
       test      r13d,r13d
       jge       short M00_L34
       add       rdx,4
       dec       r8d
       jne       short M00_L33
       jmp       near ptr M00_L50
M00_L34:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
       jmp       near ptr M00_L21
       nop       dword ptr [rax]
M00_L35:
       mov       rcx,[rbp-100]
       call      qword ptr [7FFBEC00EEC8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L23
M00_L36:
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FFBEBF510F8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L25
M00_L37:
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FFBEBF51100
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-0F0]
       jne       near ptr M00_L01
       jmp       near ptr M00_L28
M00_L38:
       mov       r10d,[rdi+28]
       lea       r9d,[r10+r10]
       cmp       r9d,7FFFFFC3
       ja        near ptr M00_L60
M00_L39:
       mov       ecx,r9d
       call      qword ptr [7FFBEC005A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
M00_L40:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-108],rax
       mov       r10d,[rdi+28]
       mov       [rbp-7C],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-110],rdx
       test      rdx,rdx
       je        near ptr M00_L67
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L66
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L65
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L64
       cmp       r10d,[rax+8]
       ja        near ptr M00_L63
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L46
       mov       rax,[rbp-108]
       cmp       r8,4000
       jbe       near ptr M00_L45
       mov       rcx,r9
       call      qword ptr [7FFBEC62F708]
M00_L41:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+20],rax
       xor       ecx,ecx
       mov       r13d,[rbp-7C]
       test      r13d,r13d
       jle       near ptr M00_L49
       mov       r8,[rbp-108]
       cmp       [r8+8],r13d
       jl        near ptr M00_L47
M00_L42:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[r8+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M00_L43
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
       jae       near ptr M00_L72
       mov       r9d,r9d
       lea       rax,[r10+r9*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [rdx+0C],r10d
       lea       edx,[rcx+1]
       mov       [rax],edx
M00_L43:
       inc       ecx
       cmp       ecx,r13d
       jl        short M00_L42
M00_L44:
       lea       rcx,[rdi+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r13d,[rbp-60]
       mov       edx,r13d
       imul      rdx,[rdi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L72
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-0E8],rax
       mov       eax,r13d
       jmp       near ptr M00_L30
M00_L45:
       mov       rcx,r9
       call      00007FFC4BC39170
       cmp       dword ptr [7FFC4BF639A0],0
       je        near ptr M00_L41
       jmp       near ptr M00_L62
M00_L46:
       mov       rcx,r9
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L41
M00_L47:
       cmp       ecx,[r8+8]
       jae       near ptr M00_L72
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[r8+rax+10]
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
       jae       near ptr M00_L72
       mov       eax,r9d
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [rdx+0C],r10d
       lea       edx,[rcx+1]
       mov       [rax],edx
M00_L48:
       inc       ecx
       cmp       ecx,r13d
       jl        short M00_L47
       jmp       near ptr M00_L44
M00_L49:
       mov       r8,[rbp-108]
       jmp       near ptr M00_L44
M00_L50:
       mov       r13d,1
       jmp       short M00_L53
M00_L51:
       mov       ecx,r13d
       call      qword ptr [7FFBEC62F750]
       test      eax,eax
       je        short M00_L52
       lea       ecx,[r13-1]
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
       add       r13d,2
M00_L53:
       cmp       r13d,7FFFFFFF
       jl        short M00_L51
       jmp       short M00_L55
M00_L54:
       jmp       near ptr M00_L34
M00_L55:
       xor       r13d,r13d
       jmp       near ptr M00_L34
M00_L56:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L26
M00_L57:
       xor       r8d,r8d
       jmp       near ptr M00_L24
M00_L58:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r8d,eax
       jmp       near ptr M00_L24
M00_L59:
       mov       r8d,[rdi+2C]
       dec       dword ptr [rdi+30]
       mov       r9d,[rdi+2C]
       cmp       r9d,[r13+8]
       jae       near ptr M00_L72
       shl       r9,4
       mov       r9d,[r13+r9+1C]
       neg       r9d
       add       r9d,0FFFFFFFD
       mov       [rdi+2C],r9d
       mov       ecx,r8d
       mov       r8,r13
       mov       r13d,ecx
       jmp       near ptr M00_L31
M00_L60:
       cmp       r10d,7FFFFFC3
       jge       short M00_L61
       mov       r13d,7FFFFFC3
       jmp       near ptr M00_L40
M00_L61:
       jmp       near ptr M00_L39
M00_L62:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L41
M00_L63:
       jmp       short M00_L68
M00_L64:
       jmp       short M00_L68
M00_L65:
       jmp       short M00_L68
M00_L66:
       jmp       short M00_L68
M00_L67:
       xor       ecx,ecx
       mov       [rbp-80],ecx
       jmp       short M00_L69
M00_L68:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFBEC62FC78]; System.Array.GetLowerBound(Int32)
       mov       [rbp-80],eax
       mov       rax,[rbp-108]
M00_L69:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFBEC62FC78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-7C]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-110]
       mov       edx,[rbp-80]
       mov       r8,[rbp-108]
       call      qword ptr [7FFBEC62FC90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L41
M00_L70:
       mov       r13,[rbp-0E0]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L01
       mov       edx,[r13+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFBEC38CBA0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFBEC00EEE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L01
M00_L71:
       call      qword ptr [7FFBEC227A20]
       int       3
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L73:
       mov       rcx,[rbp-0D0]
       mov       r15d,[rcx+28]
       cmp       r15d,0FFFFFFFD
       je        near ptr M00_L90
       cmp       r15d,1
       je        near ptr M00_L90
M00_L74:
       xor       eax,eax
       mov       [rcx+20],rax
       mov       dword ptr [rcx+28],0FFFFFFFE
       mov       ecx,[rdi+28]
       test      ecx,ecx
       jle       short M00_L75
       mov       rax,[rdi+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L91
M00_L75:
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rdi
       mov       r11,7FFBEBF51148
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M00_L92
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.IO.FileInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+8]
       mov       rcx,rdi
       mov       r11,7FFBEBF51150
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [r15+10],r13d
M00_L76:
       cmp       dword ptr [r15+10],0
       je        near ptr M00_L88
       mov       rcx,[r14+8]
       call      qword ptr [7FFBEC627738]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L93
M00_L77:
       mov       rdi,[r14+8]
       test      rdi,rdi
       je        near ptr M00_L94
       mov       ecx,[rdi+8]
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L94
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jge       near ptr M00_L96
       cmp       ecx,100
       jae       near ptr M00_L101
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L98
M00_L78:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M00_L101
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L97
       cmp       ecx,100
       jae       near ptr M00_L101
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L98
M00_L79:
       mov       rdx,rdi
M00_L80:
       mov       rdi,rdx
       mov       ecx,[rdi+8]
       cmp       word ptr [rdi+rcx*2+0A],5C
       je        short M00_L81
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBEC38E838]; System.String.op_Implicit(System.String)
       mov       dword ptr [rbp-84],5C
       lea       rdx,[rbp-84]
       mov       [rbp-0C8],rdx
       mov       dword ptr [rbp-0C0],1
       lea       rdx,[rbp-0C8]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBEC38E880]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
M00_L81:
       xor       r14d,r14d
       cmp       qword ptr [rsi+8],0
       jne       near ptr M00_L99
       xor       r13d,r13d
M00_L82:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,20D1E400070
       mov       rdx,[rdx]
       mov       rcx,r12
       call      qword ptr [7FFBEC00E118]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       lea       rcx,[rbp-0B0]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC825398]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.List`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-0B0]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-0A0]
       mov       [rbp-40],rcx
       lea       rcx,[rbp-50]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC2244E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M00_L86
M00_L83:
       mov       esi,r14d
M00_L84:
       mov       [rbp-0B8],esi
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6B4240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,108
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
       mov       [rsp+20],r12
       mov       [rsp+28],r13
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      qword ptr [7FFBEC6275D0]; DotNetTips.Spargine.IO.FileProcessor.MoveFileItemWithOriginalPath(System.IO.FileInfo, System.String, Boolean, System.Collections.Generic.HashSet`1<System.String>, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       r14d,eax
       jo        near ptr M00_L102
       lea       rcx,[rbp-50]
       mov       rdx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       call      qword ptr [7FFBEC2244E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L83
M00_L86:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rbp-58],0
       je        short M00_L85
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       je        short M00_L85
       jmp       near ptr M00_L100
M00_L87:
       call      qword ptr [7FFBEC5AC4E0]
       mov       ecx,549
       mov       rdx,7FFBEC400000
       call      qword ptr [7FFBEC2277B0]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2D5548
       call      qword ptr [7FFBEC2277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC007858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBEC400000
       call      qword ptr [7FFBEC2277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC007858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC6BFBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC62F3F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L88:
       xor       esi,esi
       jmp       near ptr M00_L84
M00_L89:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFBEC6275E8]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L90:
       call      qword ptr [7FFBEC627678]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0D0]
       jmp       near ptr M00_L74
M00_L91:
       mov       edx,ecx
       sub       edx,[rdi+30]
       mov       rcx,rdi
       call      qword ptr [7FFBEC824AC8]
       jmp       near ptr M00_L75
M00_L92:
       mov       rcx,20D34400188
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L76
       int       3
M00_L93:
       mov       rcx,r14
       call      qword ptr [7FFBEC627768]
       mov       rcx,[r14+8]
       call      qword ptr [7FFBEC627738]; System.IO.Directory.Exists(System.String)
       jmp       near ptr M00_L77
M00_L94:
       call      qword ptr [7FFBEC4354B8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L95
       call      qword ptr [7FFBEC6BFBA0]
       mov       rsi,rax
M00_L95:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,24DB35C7DF8
       call      qword ptr [7FFBEC62F3F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L96:
       call      qword ptr [7FFBEC6B61D8]
       test      eax,eax
       jne       short M00_L98
       jmp       near ptr M00_L78
M00_L97:
       call      qword ptr [7FFBEC6B61D8]
       test      eax,eax
       je        near ptr M00_L79
M00_L98:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFBEC824AE0]
       mov       rdx,rax
       jmp       near ptr M00_L80
M00_L99:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,24DB35D0E38
       call      qword ptr [7FFBEC627588]
       jmp       near ptr M00_L82
M00_L100:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFBEC6BD578]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0D8]
       call      qword ptr [7FFBEC659900]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-0D0]
       mov       r15d,[rcx+28]
       cmp       r15d,0FFFFFFFD
       je        short M00_L103
       cmp       r15d,1
       jne       short M00_L104
M00_L103:
       call      qword ptr [7FFBEC627678]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0D0]
M00_L104:
       xor       edx,edx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+28],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       int       3
; Total bytes of code 3940
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
       call      00007FFC4BCA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,24DB35C0008
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
       call      qword ptr [7FFBEC6B4E10]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFBEC005C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rax,7FFBEC15ACC0
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
       call      qword ptr [7FFBEC62F738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC385080]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M04_L06
M04_L04:
       mov       ecx,esi
       call      qword ptr [7FFBEC62F750]
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
       jb        near ptr M05_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M05_L05
       cmp       r8,40
       jbe       short M05_L02
       cmp       r8,800
       ja        near ptr M05_L09
       cmp       r8,100
       jb        short M05_L00
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
M05_L00:
       mov       r9,r8
       shr       r9,6
M05_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M05_L03
M05_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L04:
       vzeroupper
       ret
M05_L05:
       test      r8b,18
       jne       short M05_L07
       test      r8b,4
       jne       short M05_L06
       test      r8,r8
       je        short M05_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M05_L04
M05_L06:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M05_L04
M05_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M05_L04
M05_L08:
       cmp       rcx,rdx
       jne       short M05_L09
       cmp       [rdx],dl
       jmp       short M05_L04
M05_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBEC0066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 311
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        near ptr M09_L05
       mov       rcx,rax
M09_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFBEC007048]; System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M09_L08
M09_L01:
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
       xor       esi,esi
       test      r14d,r14d
       jle       near ptr M09_L04
       cmp       [rbp+8],r14d
       jl        near ptr M09_L06
M09_L02:
       mov       ecx,esi
       shl       rcx,4
       lea       rdi,[rbp+rcx+10]
       cmp       dword ptr [rdi+0C],0FFFFFFFF
       jl        short M09_L03
       mov       rcx,7FFBEC809894
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+8]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+20]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M09_L18
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+0C],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M09_L03:
       mov       rcx,7FFBEC809898
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M09_L02
M09_L04:
       mov       rcx,7FFBEC80989C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L05:
       mov       rdx,7FFBEC816EA0
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L00
M09_L06:
       cmp       esi,[rbp+8]
       jae       near ptr M09_L18
       mov       ecx,esi
       shl       rcx,4
       lea       rdi,[rbp+rcx+10]
       cmp       dword ptr [rdi+0C],0FFFFFFFF
       jl        short M09_L07
       mov       rcx,7FFBEC809894
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,[rdi+8]
       mov       r13,[rbx+8]
       mov       eax,r15d
       imul      rax,[rbx+20]
       shr       rax,20
       inc       rax
       mov       ecx,[r13+8]
       imul      rax,rcx
       shr       rax,20
       cmp       eax,[r13+8]
       jae       near ptr M09_L18
       mov       ecx,eax
       lea       r12,[r13+rcx*4+10]
       mov       ecx,[r12]
       dec       ecx
       mov       [rdi+0C],ecx
       lea       ecx,[rsi+1]
       mov       [r12],ecx
M09_L07:
       mov       rcx,7FFBEC809898
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        near ptr M09_L06
       jmp       near ptr M09_L04
M09_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M09_L09
       jmp       short M09_L10
M09_L09:
       mov       rdx,7FFBEC816E00
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M09_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFBEC809670
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBEC0058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M09_L17
M09_L11:
       cmp       r15d,[rbp+8]
       jae       near ptr M09_L18
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        near ptr M09_L16
       cmp       qword ptr [r13],0
       jne       short M09_L12
       xor       r12d,r12d
       jmp       short M09_L15
M09_L12:
       mov       rcx,7FFBEC809778
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r12,[rdx+80]
       test      r12,r12
       je        short M09_L13
       jmp       short M09_L14
M09_L13:
       mov       rdx,7FFBEC686FC0
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M09_L14:
       mov       rcx,rdi
       mov       rdx,7FFBEC809780
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       rdx,[r13]
       mov       r11,r12
       call      qword ptr [r12]
       mov       r12d,eax
M09_L15:
       mov       rcx,7FFBEC809888
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [r13+8],r12d
M09_L16:
       mov       rcx,7FFBEC80988C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M09_L11
M09_L17:
       mov       rcx,7FFBEC809890
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L01
M09_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 853
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
       je        near ptr M10_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
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
       je        near ptr M10_L11
M10_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.IO.FileInfo
       cmp       [r15],rcx
       jne       near ptr M10_L12
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
       mov       rdx,7FFBEC686FC0
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L09:
       mov       rcx,r15
       call      qword ptr [7FFBEC00EEC8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M10_L02
M10_L10:
       xor       r15d,r15d
       jmp       near ptr M10_L04
M10_L11:
       xor       r15d,r15d
       jmp       near ptr M10_L03
M10_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
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
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M10_L15
       jmp       short M10_L16
M10_L15:
       mov       rdx,7FFBEC686FD8
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFBEC227A20]
       int       3
M10_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 550
```
```assembly
; System.IO.Directory.Exists(System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2E8
       vzeroupper
       lea       rbp,[rsp+310]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2E0],ymm4
       xor       eax,eax
       mov       [rbp-2C0],rax
       mov       rax,0F0051F828BB5
       mov       [rbp-30],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M11_L39
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M11_L39
       lea       rdi,[rbx+0C]
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
M11_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M11_L40
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFBEC22FDC8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M11_L41
       cmp       esi,4
       jl        short M11_L01
       cmp       word ptr [rdi],5C
       je        near ptr M11_L42
M11_L01:
       mov       rcx,rbx
       call      qword ptr [7FFBEC22FE10]; System.IO.PathHelper.Normalize(System.String)
       mov       rbx,rax
M11_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-2A8],ymm0
       vmovdqu   xmmword ptr [rbp-294],xmm0
       xor       esi,esi
       test      rbx,rbx
       je        short M11_L04
       cmp       dword ptr [rbx+8],0
       je        short M11_L04
       mov       edi,[rbx+8]
       dec       edi
       cmp       edi,[rbx+8]
       jae       near ptr M11_L45
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M11_L38
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M11_L03:
       test      ecx,ecx
       jne       near ptr M11_L44
M11_L04:
       mov       rdi,rbx
M11_L05:
       xor       ecx,ecx
       mov       [rbp-2B8],rcx
       mov       [rbp-2B4],ecx
       call      00007FFBEBFF8C00
       lea       rdx,[rbp-2B4]
       mov       ecx,1
       call      00007FFBEBFF8C18
       mov       ebx,eax
       call      00007FFBEBFF8C30
       mov       ecx,eax
       call      00007FFC4BCA6B40
       test      ebx,ebx
       setne     cl
       movzx     ecx,cl
       mov       [rbp-2B8],cl
       movzx     ecx,byte ptr [rbp-2B8]
       mov       [rbp-2CC],cl
       mov       ecx,[rbp-2B4]
       mov       [rbp-2D0],ecx
       test      rdi,rdi
       je        near ptr M11_L29
       mov       ebx,[rdi+8]
       cmp       ebx,104
       jl        near ptr M11_L21
M11_L06:
       lea       r14,[rdi+0C]
       mov       rdx,r14
       mov       ecx,ebx
       cmp       ecx,2
       jl        near ptr M11_L26
       movzx     eax,word ptr [rdx]
       mov       r8d,eax
       cmp       r8d,5C
       je        near ptr M11_L14
       cmp       r8d,2F
       je        near ptr M11_L14
       cmp       ecx,3
       jl        near ptr M11_L26
       cmp       word ptr [rdx+2],3A
       jne       near ptr M11_L26
       movzx     edx,word ptr [rdx+4]
       cmp       edx,5C
       je        short M11_L07
       cmp       edx,2F
       jne       near ptr M11_L26
M11_L07:
       mov       edx,eax
       or        edx,20
       add       edx,0FFFFFF9F
       cmp       edx,19
       ja        near ptr M11_L26
M11_L08:
       mov       rdx,r14
       mov       ecx,ebx
       cmp       ecx,4
       jl        short M11_L09
       cmp       eax,5C
       je        near ptr M11_L23
M11_L09:
       cmp       ecx,4
       jl        short M11_L11
M11_L10:
       cmp       eax,5C
       je        near ptr M11_L16
       cmp       eax,2F
       je        near ptr M11_L16
M11_L11:
       cmp       dword ptr [rdi+0C],5C005C
       je        near ptr M11_L27
       lea       edx,[rbx+4]
       test      edx,edx
       jl        near ptr M11_L28
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       rdx,5C003F005C005C
       mov       [r8],rdx
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,r14
       lea       rcx,[r15+14]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M11_L12:
       test      r15,r15
       je        near ptr M11_L20
       add       r15,0C
M11_L13:
       mov       [rbp-2C0],r15
       xor       ecx,ecx
       call      00007FFBEBFF8C00
       lea       r8,[rbp-2A8]
       mov       rcx,r15
       xor       edx,edx
       call      00007FFBEBFF8D80
       mov       ebx,eax
       call      00007FFBEBFF8C30
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2C0],rax
       call      00007FFC4BCA6B40
       test      ebx,ebx
       jne       near ptr M11_L33
       call      00007FFC4BCA6B20
       mov       esi,eax
       mov       ecx,esi
       call      qword ptr [7FFBEC5AF0A8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M11_L33
       jmp       near ptr M11_L30
M11_L14:
       cmp       word ptr [rdx+2],3F
       je        near ptr M11_L08
       movzx     edx,word ptr [rdx+2]
       cmp       edx,5C
       je        near ptr M11_L22
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M11_L15:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M11_L26
       jmp       near ptr M11_L08
M11_L16:
       movzx     ecx,word ptr [rdx+2]
       cmp       ecx,5C
       je        short M11_L17
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M11_L11
M11_L17:
       cmp       word ptr [rdx+4],2E
       je        short M11_L18
       cmp       word ptr [rdx+4],3F
       jne       near ptr M11_L11
M11_L18:
       movzx     edx,word ptr [rdx+6]
       cmp       edx,5C
       je        short M11_L25
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M11_L19:
       test      edx,edx
       je        near ptr M11_L11
       jmp       short M11_L26
M11_L20:
       xor       r15d,r15d
       jmp       near ptr M11_L13
M11_L21:
       mov       rcx,rdi
       call      qword ptr [7FFBEC22FEE8]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
       test      eax,eax
       je        short M11_L29
       jmp       near ptr M11_L06
M11_L22:
       mov       edx,1
       jmp       short M11_L15
M11_L23:
       cmp       word ptr [rdx+2],5C
       je        short M11_L24
       cmp       word ptr [rdx+2],3F
       jne       near ptr M11_L09
M11_L24:
       cmp       word ptr [rdx+4],3F
       jne       near ptr M11_L09
       cmp       word ptr [rdx+6],5C
       je        short M11_L26
       jmp       near ptr M11_L10
M11_L25:
       mov       edx,1
       jmp       short M11_L19
M11_L26:
       mov       r15,rdi
       jmp       near ptr M11_L12
M11_L27:
       mov       rcx,rdi
       mov       edx,2
       mov       r8,24DB35D0198
       call      qword ptr [7FFBEC6B7660]
       mov       r15,rax
       jmp       near ptr M11_L12
M11_L28:
       call      qword ptr [7FFBEC6B4E10]
       int       3
M11_L29:
       mov       r15,rdi
       jmp       near ptr M11_L12
M11_L30:
       lea       rcx,[rbp-280]
       mov       edx,250
       call      qword ptr [7FFBEC0057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-280]
       mov       rcx,rdi
       call      qword ptr [7FFBEC6B7678]
       mov       [rbp-2E8],rax
       mov       rcx,[rbp-2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC1003A8]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M11_L31
       call      00007FFC4BCA6B20
       mov       esi,eax
       jmp       short M11_L32
M11_L31:
       xor       esi,esi
       lea       rcx,[rbp-2A8]
       lea       rdx,[rbp-280]
       call      qword ptr [7FFBEC6B7690]
       nop
M11_L32:
       mov       rcx,[rbp-2E8]
       mov       edx,1
       call      qword ptr [7FFBEC00C780]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E8]
       call      qword ptr [7FFBEC007AF8]; System.GC.SuppressFinalize(System.Object)
       nop
M11_L33:
       cmp       byte ptr [rbp-2CC],0
       je        short M11_L34
       xor       ecx,ecx
       mov       [rbp-2C8],ecx
       call      00007FFBEBFF8C00
       lea       rdx,[rbp-2C8]
       mov       ecx,[rbp-2D0]
       call      00007FFBEBFF8C18
       call      00007FFBEBFF8C30
       mov       ecx,eax
       call      00007FFC4BCA6B40
M11_L34:
       test      esi,esi
       je        short M11_L37
M11_L35:
       xor       eax,eax
M11_L36:
       jmp       near ptr M11_L46
M11_L37:
       cmp       dword ptr [rbp-2A8],0FFFFFFFF
       je        short M11_L35
       test      byte ptr [rbp-2A8],10
       setne     al
       movzx     eax,al
       jmp       short M11_L36
M11_L38:
       mov       ecx,1
       jmp       near ptr M11_L03
M11_L39:
       xor       eax,eax
       jmp       near ptr M11_L46
M11_L40:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M11_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6B7150]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386F70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6B7168]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386F70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L42:
       cmp       word ptr [rdi+2],5C
       je        short M11_L43
       cmp       word ptr [rdi+2],3F
       jne       near ptr M11_L01
M11_L43:
       cmp       word ptr [rdi+4],3F
       jne       near ptr M11_L01
       cmp       word ptr [rdi+6],5C
       jne       near ptr M11_L01
       jmp       near ptr M11_L02
M11_L44:
       lea       rcx,[rbx+0C]
       mov       r14d,[rbx+8]
       mov       [rbp-2E0],rcx
       mov       [rbp-2D8],r14d
       lea       rcx,[rbp-2E0]
       call      qword ptr [7FFBEC5AF0D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r14d
       je        near ptr M11_L04
       mov       r8d,edi
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBEC17F450]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       jmp       near ptr M11_L05
M11_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L46:
       mov       r8,0F0051F828BB5
       cmp       [rbp-30],r8
       je        short M11_L47
       call      CORINFO_HELP_FAIL_FAST
M11_L47:
       nop
       add       rsp,2E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L48:
       xor       eax,eax
       mov       r8,0F0051F828BB5
       cmp       [rbp-30],r8
       je        short M11_L49
       call      CORINFO_HELP_FAIL_FAST
M11_L49:
       nop
       add       rsp,2E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2E8],0
       je        short M11_L50
       mov       rcx,[rbp-2E8]
       mov       edx,1
       call      qword ptr [7FFBEC00C780]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E8]
       call      qword ptr [7FFBEC007AF8]; System.GC.SuppressFinalize(System.Object)
M11_L50:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2CC],0
       je        short M11_L51
       xor       ecx,ecx
       mov       [rbp-2C8],ecx
       call      00007FFBEBFF8C00
       lea       rdx,[rbp-2C8]
       mov       ecx,[rbp-2D0]
       call      00007FFBEBFF8C18
       call      00007FFBEBFF8C30
       mov       ecx,eax
       call      00007FFC4BCA6B40
M11_L51:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M11_L48]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M11_L48]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M11_L48]
       add       rsp,28
       ret
; Total bytes of code 1697
```
```assembly
; System.String.op_Implicit(System.String)
       test      rdx,rdx
       jne       short M12_L01
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rcx+8],rdx
M12_L00:
       mov       rax,rcx
       ret
M12_L01:
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       jmp       short M12_L00
; Total bytes of code 33
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx]
       mov       ebp,[rcx+8]
       mov       edx,ebp
       add       edx,esi
       jo        near ptr M13_L02
       test      edx,edx
       je        short M13_L00
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        short M13_L01
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M13_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L00:
       mov       rax,24DB35C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L01:
       call      qword ptr [7FFBEC43E298]
       int       3
M13_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       test      rdx,rdx
       jne       short M14_L01
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        near ptr M14_L05
M14_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
M14_L01:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       short M14_L04
       mov       rcx,[rbx+18]
       call      qword ptr [7FFBEC006358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M14_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M14_L06
       mov       rcx,rax
M14_L02:
       mov       rdx,rsi
       cmp       [rdx],rcx
       je        short M14_L03
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M14_L03:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
M14_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L05:
       mov       rdx,7FFBEC816E10
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M14_L00
M14_L06:
       mov       rdx,7FFBEC816E00
       call      qword ptr [7FFBEC00C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L02
; Total bytes of code 214
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
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsi+14]
       mov       [rbx+10],eax
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 37
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
       jne       short M16_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M16_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M16_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M16_L00:
       call      qword ptr [7FFBEC22C150]
       int       3
M16_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M16_L02:
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
; DotNetTips.Spargine.IO.FileProcessor.MoveFileItemWithOriginalPath(System.IO.FileInfo, System.String, Boolean, System.Collections.Generic.HashSet`1<System.String>, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
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
; 			if (file.Directory?.Root is null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowInvalidOperationException(Resources.TheRootDirectoryOfTheFileIsNull);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newFilePath = file.FullName.Replace(file.Directory!.Root.FullName, destinationPath, StringComparison.OrdinalIgnoreCase);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var dirPath = Path.GetDirectoryName(newFilePath)!;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (createdDirs.Add(dirPath))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = Directory.CreateDirectory(dirPath);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FileHelper.RemoveReadOnlyAttribute(file);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			psw?.Start();
; 			^^^^^^^^^^^^^
; 			file.MoveTo(newFilePath, overwrite);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var perf = psw?.StopReset() ?? TimeSpan.Zero;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenMoved, Name = file.FullName, ProgressState = FileProgressState.FileMoved, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,208
       lea       rbp,[rsp+240]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M18_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M18_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       rsi,[rbp+30]
       mov       r15,[rbp+38]
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC651940]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M18_L163
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M18_L91
M18_L01:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M18_L93
       test      byte ptr [rbx+30],10
       jne       near ptr M18_L92
       cmp       dword ptr [rbx+28],0
       jne       near ptr M18_L93
       mov       ecx,[rbx+4C]
       shl       rcx,20
       mov       eax,[rbx+50]
       or        rcx,rax
       mov       [rbp-40],rcx
       mov       r13,[rbx+8]
       test      r13,r13
       je        near ptr M18_L95
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       test      eax,eax
       je        near ptr M18_L95
       xor       edx,edx
M18_L02:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M18_L94
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rbp-194],eax
       mov       ecx,eax
       xor       edx,edx
       mov       [rbp-48],edx
       cmp       ecx,4
       jl        short M18_L03
       cmp       word ptr [r12],5C
       je        near ptr M18_L96
M18_L03:
       cmp       eax,4
       jl        short M18_L05
M18_L04:
       movzx     r8d,word ptr [r12]
       cmp       r8d,5C
       je        near ptr M18_L23
       cmp       r8d,2F
       je        near ptr M18_L23
M18_L05:
       xor       r8d,r8d
M18_L06:
       mov       [rbp-4C],r8d
       test      r8d,r8d
       jne       near ptr M18_L100
       xor       r10d,r10d
M18_L07:
       movzx     ecx,r10b
       mov       r8d,[rbp-4C]
       test      r8d,r8d
       sete      r10b
       movzx     r10d,r10b
       or        r10d,ecx
       je        short M18_L08
       test      eax,eax
       jle       short M18_L08
       movzx     r10d,word ptr [r12]
       cmp       r10d,5C
       je        near ptr M18_L27
       cmp       r10d,2F
       je        near ptr M18_L27
M18_L08:
       test      r8d,r8d
       jne       near ptr M18_L101
       cmp       eax,2
       jl        short M18_L10
       cmp       word ptr [r12+2],3A
       jne       short M18_L10
       movzx     ecx,word ptr [r12]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       ja        short M18_L10
       mov       edx,2
       cmp       eax,2
       jle       near ptr M18_L110
       cmp       eax,2
       jbe       near ptr M18_L160
       movzx     ecx,word ptr [r12+4]
       cmp       ecx,5C
       je        short M18_L09
       cmp       ecx,2F
       jne       near ptr M18_L109
M18_L09:
       inc       edx
       mov       [rbp-48],edx
M18_L10:
       mov       edx,[rbp-48]
       mov       ecx,eax
       cmp       ecx,edx
       jle       near ptr M18_L111
M18_L11:
       dec       ecx
       cmp       ecx,eax
       jae       near ptr M18_L160
       mov       r8d,ecx
       movzx     r8d,word ptr [r12+r8*2]
       cmp       r8d,5C
       je        short M18_L12
       cmp       r8d,2F
       je        short M18_L12
       cmp       ecx,edx
       jg        short M18_L11
M18_L12:
       cmp       ecx,edx
       jg        near ptr M18_L112
M18_L13:
       mov       r8d,ecx
M18_L14:
       test      r8d,r8d
       jl        near ptr M18_L95
       cmp       [r13+8],r8d
       jb        near ptr M18_L114
       test      r8d,r8d
       je        near ptr M18_L115
       cmp       [r13+8],r8d
       je        near ptr M18_L36
       mov       r12d,r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       rcx,rax
       mov       [rbp-1D8],rcx
       cmp       [rcx],cl
       add       rcx,0C
       lea       rdx,[r13+0C]
       lea       r8,[r12+r12]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12,[rbp-1D8]
       mov       rcx,r12
M18_L15:
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r12,rax
M18_L16:
       test      r12,r12
       je        near ptr M18_L116
       mov       rcx,offset MT_System.IO.DirectoryInfo
       mov       [rbp-0E0],rcx
       mov       dword ptr [rbp-0B8],0FFFFFFFF
       mov       rcx,r12
       call      qword ptr [7FFBEC22FD80]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp-0D0],r12
       test      rax,rax
       cmove     rax,r12
       xor       ecx,ecx
       mov       [rbp-0C8],rcx
       mov       [rbp-0D8],rax
       mov       byte ptr [rbp-8C],1
       lea       rcx,[rbp-0E0]
M18_L17:
       test      rcx,rcx
       je        near ptr M18_L117
       mov       r13,[rcx+8]
       test      r13,r13
       jne       near ptr M18_L37
       xor       ecx,ecx
       xor       eax,eax
M18_L18:
       test      eax,eax
       je        near ptr M18_L119
       test      eax,eax
       jle       near ptr M18_L119
       xor       edx,edx
M18_L19:
       cmp       word ptr [rcx+rdx],20
       je        near ptr M18_L118
       test      r13,r13
       jne       near ptr M18_L38
       xor       r12d,r12d
       xor       eax,eax
M18_L20:
       mov       [rbp-198],eax
       test      eax,eax
       je        near ptr M18_L121
       test      eax,eax
       jle       near ptr M18_L121
       xor       ecx,ecx
       mov       edx,eax
M18_L21:
       cmp       word ptr [r12+rcx],20
       je        near ptr M18_L120
       mov       [rbp-1B0],r12
       mov       [rbp-1A8],eax
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC5AF0D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jle       near ptr M18_L121
       cmp       eax,[rbp-198]
       ja        near ptr M18_L135
M18_L22:
       mov       [rbp-60],r12
       mov       [rbp-58],eax
       mov       ecx,[r13+8]
       cmp       ecx,[rbp-58]
       jne       near ptr M18_L39
       mov       rcx,r13
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r12,rax
       jmp       near ptr M18_L40
M18_L23:
       movzx     ecx,word ptr [r12+2]
       cmp       ecx,5C
       je        short M18_L24
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M18_L05
M18_L24:
       cmp       word ptr [r12+4],2E
       je        short M18_L25
       cmp       word ptr [r12+4],3F
       jne       near ptr M18_L05
M18_L25:
       movzx     ecx,word ptr [r12+6]
       cmp       ecx,5C
       je        near ptr M18_L98
       cmp       ecx,2F
       sete      r8b
       movzx     r8d,r8b
M18_L26:
       jmp       near ptr M18_L06
M18_L27:
       test      ecx,ecx
       jne       short M18_L30
       cmp       eax,1
       jle       short M18_L29
       movzx     edx,word ptr [r12+2]
       cmp       edx,5C
       je        short M18_L28
       cmp       edx,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M18_L29
M18_L28:
       mov       edx,2
       jmp       short M18_L31
M18_L29:
       mov       edx,1
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L30:
       mov       edx,8
M18_L31:
       mov       ecx,2
       jmp       short M18_L33
M18_L32:
       inc       edx
M18_L33:
       cmp       edx,eax
       jge       short M18_L35
       mov       r8d,edx
       movzx     r8d,word ptr [r12+r8*2]
       cmp       r8d,5C
       je        short M18_L34
       cmp       r8d,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M18_L32
M18_L34:
       dec       ecx
       test      ecx,ecx
       jg        short M18_L32
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L35:
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L36:
       mov       rcx,r13
       jmp       near ptr M18_L15
M18_L37:
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       jmp       near ptr M18_L18
M18_L38:
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       jmp       near ptr M18_L20
M18_L39:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBEC1776D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,rax
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r12,rax
M18_L40:
       mov       rcx,offset MT_System.IO.DirectoryInfo
       mov       [rbp-138],rcx
       mov       dword ptr [rbp-110],0FFFFFFFF
       test      r12,r12
       je        near ptr M18_L137
       mov       rcx,r12
       call      qword ptr [7FFBEC22FD80]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp-128],r12
       test      rax,rax
       cmove     rax,r12
       xor       ecx,ecx
       mov       [rbp-120],rcx
       mov       [rbp-130],rax
       mov       byte ptr [rbp-0E4],1
M18_L41:
       mov       r13,[rbx+8]
       mov       r12,r13
       test      r13,r13
       je        near ptr M18_L125
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       test      eax,eax
       je        near ptr M18_L125
       test      eax,eax
       jle       near ptr M18_L125
       xor       edx,edx
M18_L42:
       cmp       word ptr [rcx+rdx],20
       je        near ptr M18_L124
       lea       rax,[r13+0C]
       mov       edx,[r13+8]
       mov       [rbp-210],rax
       mov       [rbp-19C],edx
       mov       [rbp-1B0],rax
       mov       [rbp-1A8],edx
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC5AF0D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edx,[rbp-19C]
       mov       ecx,edx
       cmp       ecx,eax
       jle       near ptr M18_L126
M18_L43:
       dec       ecx
       cmp       ecx,edx
       jae       near ptr M18_L160
       mov       r8d,ecx
       mov       r10,[rbp-210]
       movzx     r8d,word ptr [r10+r8*2]
       cmp       r8d,5C
       je        short M18_L44
       cmp       r8d,2F
       je        short M18_L44
       cmp       ecx,eax
       jle       short M18_L44
       jmp       short M18_L43
M18_L44:
       cmp       ecx,eax
       jg        near ptr M18_L127
M18_L45:
       mov       r8d,ecx
M18_L46:
       test      r8d,r8d
       jl        near ptr M18_L125
       cmp       [r13+8],r8d
       jb        near ptr M18_L129
       test      r8d,r8d
       je        near ptr M18_L130
       cmp       [r13+8],r8d
       je        near ptr M18_L55
       mov       eax,r8d
       mov       [rbp-68],rax
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       rcx,rax
       mov       [rbp-1E0],rcx
       cmp       [rcx],cl
       add       rcx,0C
       lea       rdx,[r13+0C]
       mov       r13,[rbp-68]
       lea       r8,[r13+r13]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13,[rbp-1E0]
       mov       rcx,r13
M18_L47:
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r13,rax
M18_L48:
       test      r13,r13
       je        near ptr M18_L131
       mov       rcx,offset MT_System.IO.DirectoryInfo
       mov       [rbp-190],rcx
       mov       dword ptr [rbp-168],0FFFFFFFF
       mov       rcx,r13
       call      qword ptr [7FFBEC22FD80]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp-180],r13
       test      rax,rax
       cmove     rax,r13
       xor       ecx,ecx
       mov       [rbp-178],rcx
       mov       [rbp-188],rax
       mov       byte ptr [rbp-13C],1
       lea       rcx,[rbp-190]
M18_L49:
       mov       r13,[rcx+8]
       test      r13,r13
       jne       near ptr M18_L56
       xor       ecx,ecx
       xor       eax,eax
M18_L50:
       test      eax,eax
       je        near ptr M18_L133
       test      eax,eax
       jle       near ptr M18_L133
       xor       edx,edx
M18_L51:
       cmp       word ptr [rcx+rdx],20
       je        near ptr M18_L132
       test      r13,r13
       jne       near ptr M18_L57
       xor       eax,eax
       xor       edx,edx
M18_L52:
       mov       [rbp-218],rax
       mov       [rbp-1A0],edx
       test      edx,edx
       je        near ptr M18_L136
       test      edx,edx
       jle       near ptr M18_L136
       xor       ecx,ecx
       mov       r8d,edx
M18_L53:
       cmp       word ptr [rax+rcx],20
       je        near ptr M18_L134
       mov       [rbp-1B0],rax
       mov       [rbp-1A8],edx
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC5AF0D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jle       near ptr M18_L136
       cmp       eax,[rbp-1A0]
       ja        near ptr M18_L135
       mov       rcx,[rbp-218]
M18_L54:
       mov       [rbp-78],rcx
       mov       [rbp-70],eax
       mov       ecx,[r13+8]
       cmp       ecx,[rbp-70]
       jne       short M18_L58
       mov       rcx,r13
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r13,rax
       jmp       short M18_L59
M18_L55:
       mov       rcx,r13
       jmp       near ptr M18_L47
M18_L56:
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       jmp       near ptr M18_L50
M18_L57:
       lea       rax,[r13+0C]
       mov       edx,[r13+8]
       jmp       near ptr M18_L52
M18_L58:
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBEC1776D8]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,rax
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r13,rax
M18_L59:
       test      r13,r13
       je        near ptr M18_L137
       mov       rcx,r13
       call      qword ptr [7FFBEC22FD80]; System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r13
       cmp       [r12],r12b
       mov       rdx,20D344001B0
       mov       r9,[rdx]
       test      rcx,rcx
       je        near ptr M18_L89
       cmp       dword ptr [rcx+8],0
       je        near ptr M18_L138
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       test      rdi,rdi
       jne       near ptr M18_L84
       xor       r10d,r10d
       xor       r11d,r11d
M18_L60:
       mov       [rbp-1B0],rdx
       mov       [rbp-1A8],r8d
       mov       [rbp-1C0],rax
       mov       [rbp-1B8],ecx
       mov       [rbp-1D0],r10
       mov       [rbp-1C8],r11d
       mov       dword ptr [rsp+20],10000000
       lea       rcx,[rbp-1B0]
       lea       rdx,[rbp-1C0]
       lea       r8,[rbp-1D0]
       call      qword ptr [7FFBEC627A50]; System.String.ReplaceCore(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       test      rax,rax
       cmove     rax,r12
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M18_L140
       lea       rcx,[rdi+0C]
       mov       eax,[rdi+8]
       test      eax,eax
       je        near ptr M18_L140
       test      eax,eax
       jle       near ptr M18_L140
       xor       edx,edx
M18_L61:
       cmp       word ptr [rcx+rdx],20
       je        near ptr M18_L139
       lea       r13,[rdi+0C]
       mov       r12d,[rdi+8]
       mov       [rbp-1B0],r13
       mov       [rbp-1A8],r12d
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC5AF0D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edx,r12d
       cmp       r12d,eax
       jle       near ptr M18_L141
M18_L62:
       dec       edx
       cmp       edx,r12d
       jae       near ptr M18_L160
       mov       ecx,edx
       movzx     ecx,word ptr [r13+rcx*2]
       cmp       ecx,5C
       je        short M18_L63
       cmp       ecx,2F
       je        short M18_L63
       cmp       edx,eax
       jg        short M18_L62
M18_L63:
       cmp       edx,eax
       jg        near ptr M18_L142
M18_L64:
       mov       r8d,edx
M18_L65:
       test      r8d,r8d
       jl        near ptr M18_L140
       cmp       [rdi+8],r8d
       jb        near ptr M18_L144
       test      r8d,r8d
       je        near ptr M18_L145
       cmp       [rdi+8],r8d
       je        near ptr M18_L85
       mov       r13d,r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r12,rax
       cmp       [r12],r12b
       lea       rcx,[r12+0C]
       lea       rdx,[rdi+0C]
       lea       r8,[r13+r13]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
M18_L66:
       call      qword ptr [7FFBEC6279D8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r13,rax
M18_L67:
       cmp       qword ptr [rsi+8],0
       je        near ptr M18_L146
M18_L68:
       mov       r12,[rsi+10]
       mov       rax,[rsi+18]
       mov       [rbp-1F8],rax
       xor       r8d,r8d
       mov       [rbp-7C],r8d
       test      r13,r13
       je        near ptr M18_L147
       mov       rcx,rax
       mov       rdx,r13
       mov       r11,7FFBEBF50C18
       call      qword ptr [r11]
M18_L69:
       mov       [rbp-80],eax
       mov       rcx,[rsi+8]
       mov       edx,eax
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M18_L160
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rbp-200],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M18_L72
M18_L70:
       cmp       r9d,[r12+8]
       jae       near ptr M18_L160
       mov       ecx,r9d
       shl       rcx,4
       lea       r9,[r12+rcx+10]
       mov       [rbp-208],r9
       cmp       [r9+8],eax
       je        near ptr M18_L86
M18_L71:
       mov       r9d,[r9+0C]
       mov       r8d,[rbp-7C]
       inc       r8d
       mov       [rbp-7C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M18_L149
       test      r9d,r9d
       mov       eax,[rbp-80]
       jge       short M18_L70
M18_L72:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M18_L150
       mov       edx,[rsi+28]
       mov       [rbp-84],edx
       cmp       [r12+8],edx
       je        near ptr M18_L88
M18_L73:
       mov       edx,[rbp-84]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r9,rcx
M18_L74:
       cmp       r12d,[r9+8]
       jae       near ptr M18_L160
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-1F0],r9
       lea       rcx,[r9+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-200]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-200]
       mov       [rdx],r12d
       inc       dword ptr [rsi+34]
       cmp       dword ptr [rbp-7C],64
       ja        near ptr M18_L151
M18_L75:
       mov       rcx,r13
       call      qword ptr [7FFBEC38F3A8]; System.IO.Directory.CreateDirectory(System.String)
M18_L76:
       mov       rcx,rbx
       call      qword ptr [7FFBEC651940]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        short M18_L78
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M18_L152
M18_L77:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M18_L153
       mov       edx,[rbx+30]
       and       edx,0FFFFFFFE
       mov       rcx,[rbx+8]
       call      qword ptr [7FFBEC627B58]; System.IO.FileSystem.SetAttributes(System.String, System.IO.FileAttributes)
       mov       dword ptr [rbx+28],0FFFFFFFF
M18_L78:
       test      r15,r15
       jne       near ptr M18_L154
M18_L79:
       movzx     r8d,r14b
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFBEC6278E8]; System.IO.FileInfo.MoveTo(System.String, Boolean)
       test      r15,r15
       jne       near ptr M18_L155
       xor       esi,esi
M18_L80:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rax,24DB35C0008
       mov       [rdi+8],rax
       mov       [rdi+10],rax
       call      qword ptr [7FFBEC627C48]; DotNetTips.Spargine.Properties.Resources.get_ResourceManager()
       mov       r8,offset MT_System.Resources.ResourceManager
       cmp       [rax],r8
       jne       near ptr M18_L156
       mov       r8,20D344001E0
       mov       r8,[r8]
       mov       rcx,rax
       mov       rdx,24DB35D1030
       call      qword ptr [7FFBEC148730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M18_L81:
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+28],3
       mov       rdx,[rbp-40]
       mov       [rdi+18],rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rsi
       vdivsd    xmm0,xmm0,[7FFBEC7285D8]
       vucomisd  xmm0,qword ptr [7FFBEC7285E0]
       ja        near ptr M18_L157
       vmovsd    xmm1,qword ptr [7FFBEC7285E8]
       vucomisd  xmm1,xmm0
       ja        near ptr M18_L158
M18_L82:
       vmovsd    qword ptr [rdi+20],xmm0
       mov       rdx,offset MT_DotNetTips.Spargine.IO.FileProcessor
       mov       rcx,[rbp+10]
       cmp       [rcx],rdx
       jne       near ptr M18_L161
       mov       rax,[rcx+8]
       test      rax,rax
       jne       near ptr M18_L159
M18_L83:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M18_L162
M18_L84:
       lea       r10,[rdi+0C]
       mov       r11d,[rdi+8]
       jmp       near ptr M18_L60
M18_L85:
       mov       rcx,rdi
       jmp       near ptr M18_L66
M18_L86:
       mov       rdx,[r9]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       r11,[rbp-1F8]
       cmp       [r11],rcx
       jne       near ptr M18_L148
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8d,5
       call      qword ptr [7FFBEC174B40]; System.String.Equals(System.String, System.String, System.StringComparison)
M18_L87:
       test      eax,eax
       mov       r9,[rbp-208]
       je        near ptr M18_L71
       jmp       near ptr M18_L76
M18_L88:
       mov       rcx,rsi
       call      qword ptr [7FFBEC62F7C8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       r12d,[rbp-80]
       mov       edx,r12d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M18_L160
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-200],rax
       mov       eax,r12d
       jmp       near ptr M18_L73
M18_L89:
       mov       [rbp-1E8],rcx
M18_L90:
       mov       ecx,0BF7
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rdx,rax
       mov       rcx,[rbp-1E8]
       call      qword ptr [7FFBEC6BD5D8]
       int       3
M18_L91:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FFBEC6B7618]
       jmp       near ptr M18_L01
M18_L92:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC6BD590]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FFBEC62ED90]; System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFBEC6BD5A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M18_L93:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FFBEC6B6F88]; System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M18_L94:
       inc       edx
       cmp       edx,eax
       jl        near ptr M18_L02
M18_L95:
       xor       r12d,r12d
       jmp       near ptr M18_L16
M18_L96:
       cmp       word ptr [r12+2],5C
       je        short M18_L97
       cmp       word ptr [r12+2],3F
       jne       near ptr M18_L03
M18_L97:
       cmp       word ptr [r12+4],3F
       jne       near ptr M18_L03
       cmp       word ptr [r12+6],5C
       je        short M18_L99
       jmp       near ptr M18_L04
M18_L98:
       mov       r8d,1
       jmp       near ptr M18_L26
M18_L99:
       mov       r8d,1
       jmp       near ptr M18_L06
M18_L100:
       mov       [rbp-1B0],r12
       mov       [rbp-1A8],eax
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC6B75E8]
       mov       r10d,eax
       mov       eax,[rbp-194]
       jmp       near ptr M18_L07
M18_L101:
       mov       edx,4
       jmp       short M18_L103
M18_L102:
       inc       edx
M18_L103:
       cmp       edx,eax
       jge       short M18_L104
       mov       ecx,edx
       movzx     ecx,word ptr [r12+rcx*2]
       cmp       ecx,5C
       je        short M18_L105
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M18_L102
       jmp       short M18_L106
M18_L104:
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L105:
       cmp       edx,4
       jg        short M18_L107
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L106:
       cmp       edx,4
       jle       short M18_L108
M18_L107:
       mov       ecx,edx
       movzx     ecx,word ptr [r12+rcx*2]
       cmp       ecx,5C
       je        near ptr M18_L09
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M18_L09
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L108:
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L109:
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L110:
       mov       [rbp-48],edx
       jmp       near ptr M18_L10
M18_L111:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M18_L14
M18_L112:
       lea       r8d,[rcx-1]
       cmp       r8d,eax
       jae       near ptr M18_L160
       lea       r8d,[rcx-1]
       movzx     r8d,word ptr [r12+r8*2]
       cmp       r8d,5C
       je        short M18_L113
       cmp       r8d,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M18_L13
M18_L113:
       dec       ecx
       jmp       near ptr M18_L12
M18_L114:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFBEC6B7090]
       int       3
M18_L115:
       mov       rcx,24DB35C0008
       jmp       near ptr M18_L15
M18_L116:
       xor       ecx,ecx
       jmp       near ptr M18_L17
M18_L117:
       xor       ecx,ecx
       jne       near ptr M18_L41
       jmp       short M18_L122
M18_L118:
       add       rdx,2
       dec       eax
       jne       near ptr M18_L19
M18_L119:
       xor       r12d,r12d
       jmp       near ptr M18_L40
M18_L120:
       add       rcx,2
       dec       edx
       jne       near ptr M18_L21
M18_L121:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M18_L22
M18_L122:
       call      qword ptr [7FFBEC627870]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M18_L123
       call      qword ptr [7FFBEC6BFB58]
       mov       rsi,rax
M18_L123:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFBEC386EC8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M18_L124:
       add       rdx,2
       dec       eax
       jne       near ptr M18_L42
M18_L125:
       xor       r13d,r13d
       jmp       near ptr M18_L48
M18_L126:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M18_L46
M18_L127:
       lea       r8d,[rcx-1]
       cmp       r8d,edx
       jae       near ptr M18_L160
       lea       r8d,[rcx-1]
       movzx     r8d,word ptr [r10+r8*2]
       cmp       r8d,5C
       je        short M18_L128
       cmp       r8d,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M18_L45
M18_L128:
       dec       ecx
       jmp       near ptr M18_L44
M18_L129:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFBEC6B7090]
       int       3
M18_L130:
       mov       rcx,24DB35C0008
       jmp       near ptr M18_L47
M18_L131:
       xor       ecx,ecx
       jmp       near ptr M18_L49
M18_L132:
       add       rdx,2
       dec       eax
       jne       near ptr M18_L51
M18_L133:
       xor       r13d,r13d
       jmp       near ptr M18_L59
M18_L134:
       add       rcx,2
       dec       r8d
       jne       near ptr M18_L53
       jmp       short M18_L136
M18_L135:
       call      qword ptr [7FFBEC177198]
       int       3
M18_L136:
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M18_L54
M18_L137:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC62EFB8]
       int       3
M18_L138:
       mov       [rbp-1E8],rcx
       jmp       near ptr M18_L90
M18_L139:
       add       rdx,2
       dec       eax
       jne       near ptr M18_L61
M18_L140:
       xor       r13d,r13d
       jmp       near ptr M18_L67
M18_L141:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M18_L65
M18_L142:
       lea       ecx,[rdx-1]
       cmp       ecx,r12d
       jae       near ptr M18_L160
       lea       ecx,[rdx-1]
       movzx     ecx,word ptr [r13+rcx*2]
       cmp       ecx,5C
       je        short M18_L143
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M18_L64
M18_L143:
       dec       edx
       jmp       near ptr M18_L63
M18_L144:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFBEC6B7090]
       int       3
M18_L145:
       mov       rcx,24DB35C0008
       jmp       near ptr M18_L66
M18_L146:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC00EE20]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M18_L68
M18_L147:
       xor       ecx,ecx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M18_L69
M18_L148:
       mov       r11,[rbp-1F8]
       mov       rcx,r11
       mov       r8,r13
       mov       r11,7FFBEBF50C20
       call      qword ptr [r11]
       jmp       near ptr M18_L87
M18_L149:
       call      qword ptr [7FFBEC227A20]
       int       3
M18_L150:
       mov       ecx,[rsi+2C]
       mov       r9d,ecx
       dec       dword ptr [rsi+30]
       mov       ecx,[rsi+2C]
       cmp       ecx,[r12+8]
       jae       near ptr M18_L160
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M18_L74
M18_L151:
       mov       rdx,[rbp-1F8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M18_L75
       mov       r12,[rbp-1F0]
       mov       edx,[r12+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFBEC38CBA0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFBEC00EEE0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M18_L75
M18_L152:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FFBEC6B7618]
       jmp       near ptr M18_L77
M18_L153:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FFBEC6B6F88]; System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M18_L154:
       mov       rcx,r15
       call      qword ptr [7FFBEC6278D0]
       jmp       near ptr M18_L79
M18_L155:
       mov       rcx,r15
       call      qword ptr [7FFBEC627900]
       mov       rsi,rax
       jmp       near ptr M18_L80
M18_L156:
       mov       r8,20D344001E0
       mov       r8,[r8]
       mov       rcx,rax
       mov       rdx,24DB35D1030
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M18_L81
M18_L157:
       vmovsd    xmm0,qword ptr [7FFBEC7285E0]
       jmp       near ptr M18_L82
M18_L158:
       vmovsd    xmm0,qword ptr [7FFBEC7285E8]
       jmp       near ptr M18_L82
M18_L159:
       mov       rdx,rcx
       mov       r8,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M18_L83
M18_L160:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L161:
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp+10]
       jmp       near ptr M18_L83
M18_L162:
       mov       eax,[rbp-44]
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L163:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC627798]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       call      qword ptr [7FFBEC6277B0]
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
       add       rsp,208
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
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC627798]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       mov       rcx,rbx
       mov       edx,2C
       call      qword ptr [7FFBEC627978]; DotNetTips.Spargine.Core.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC6277C8]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Message(System.String)
       mov       rcx,[rbp+18]
       call      qword ptr [7FFBEC3ED798]; System.IO.FileSystemInfo.get_FullName()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEC6277E0]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC6277F8]; DotNetTips.Spargine.IO.ProgressEventArgs.set_ProgressState(DotNetTips.Spargine.IO.FileProgressState)
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC627930]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Size(Int64)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       xor       eax,eax
       mov       [rbp-44],eax
       lea       rax,[M18_L162]
       add       rsp,28
       ret
; Total bytes of code 4724
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
       mov       dword ptr [rcx+28],0FFFFFFFF
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M20_L00
       mov       r11,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rcx],r11
       jne       short M20_L01
M20_L00:
       ret
M20_L01:
       mov       r11,7FFBEBF50FD8
       jmp       qword ptr [r11]
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       cmp       ecx,0FFFFFFFD
       je        short M21_L01
       cmp       ecx,1
       je        short M21_L01
M21_L00:
       xor       eax,eax
       mov       [rbx+20],rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       add       rsp,20
       pop       rbx
       ret
M21_L01:
       mov       rcx,rbx
       call      qword ptr [7FFBEC627678]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__32`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       jmp       short M21_L00
; Total bytes of code 51
```

