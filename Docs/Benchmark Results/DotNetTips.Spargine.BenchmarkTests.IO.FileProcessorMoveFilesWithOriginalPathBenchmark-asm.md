## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+140]
       mov       rdi,[rbx+148]
       mov       r14,[rbx+138]
       cmp       [rsi],sil
       test      r14,r14
       je        near ptr M00_L83
       test      rdi,rdi
       je        near ptr M00_L88
       mov       r15,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34<System.IO.FileInfo>
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
       mov       rcx,2C341C001B0
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [r13+28],0FFFFFFFE
       jne       near ptr M00_L84
       mov       r12d,[r13+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r12d,eax
       jne       near ptr M00_L84
       xor       ecx,ecx
       mov       [r13+28],ecx
       mov       r12,r13
M00_L00:
       mov       rdx,[r13+18]
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r12
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
       mov       rcx,[rbp-0A0]
       lea       rcx,[rcx+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0A0]
       jmp       near ptr M00_L02
M00_L08:
       xor       edx,edx
       mov       [r15+8],rdx
       mov       dword ptr [r15+14],0FFFFFFFF
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
       xor       r15d,r15d
       jmp       near ptr M00_L20
M00_L12:
       call      qword ptr [7FFCDE597F48]
       mov       ecx,65
       mov       rdx,7FFCDE3F07B0
       call      qword ptr [7FFCDDFFF228]
       mov       r13,rax
       mov       ecx,191A
       mov       rdx,7FFCDE2C5AB8
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FFCDE3F07B0
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDE6AFDB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCDE61F5A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C341C003E8
       mov       r13,[rcx]
       jmp       near ptr M00_L07
       nop       word ptr [rax+rax]
M00_L14:
       mov       rcx,r15
       mov       r11,7FFCDDF41120
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L15:
       mov       r11,7FFCDDF41130
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rax
       mov       r11,7FFCDDF41128
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
       jmp       near ptr M00_L09
M00_L17:
       call      qword ptr [7FFCDDFFFC60]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r11
       mov       r11,7FFCDDF41138
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L20:
       test      r15d,r15d
       je        near ptr M00_L73
       mov       rcx,[rbp-0A0]
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
       jne       near ptr M00_L58
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
       mov       [rbp-0D0],rdx
       mov       r8,offset MT_System.IO.FileInfo
       cmp       [rdx],r8
       jne       near ptr M00_L36
       mov       rcx,rdx
       call      00007FFD3DC3FEC0
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
       mov       [rbp-0B8],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L29
M00_L27:
       cmp       r9d,[r13+8]
       jae       near ptr M00_L72
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r13+rdx+10]
       mov       [rbp-0C0],r9
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
       mov       [rbp-0B0],r8
       lea       r9,[r8+r9+10]
       mov       [r9+8],eax
       mov       r10,[rbp-0B8]
       mov       eax,[r10]
       dec       eax
       mov       [r9+0C],eax
       mov       rcx,r9
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       rdx,[rbp-0B8]
       mov       [rdx],r13d
       inc       dword ptr [rdi+34]
       cmp       dword ptr [rbp-5C],64
       jbe       near ptr M00_L01
       jmp       near ptr M00_L70
M00_L32:
       mov       rax,7FFD3CE10BB8
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
       mov       [rbp-0C8],rax
       mov       dword ptr [rdi+2C],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-0C8]
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
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FFCDE1C77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L23
M00_L36:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r8d,eax
       jmp       near ptr M00_L24
M00_L37:
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FFCDDF41118
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-0C0]
       jne       near ptr M00_L01
       jmp       near ptr M00_L28
M00_L38:
       mov       r10d,[rdi+28]
       lea       r9d,[r10+r10]
       cmp       r9d,7FFFFFC3
       ja        near ptr M00_L60
M00_L39:
       mov       ecx,r9d
       call      qword ptr [7FFCDDFF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
M00_L40:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0D8],rax
       mov       r10d,[rdi+28]
       mov       [rbp-7C],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-0E0],rdx
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
       mov       rax,[rbp-0D8]
       cmp       r8,4000
       jbe       near ptr M00_L45
       mov       rcx,r9
       call      qword ptr [7FFCDE61F8D0]
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
       mov       r8,[rbp-0D8]
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
       mov       [rbp-0B8],rax
       mov       eax,r13d
       jmp       near ptr M00_L30
M00_L45:
       mov       rcx,r9
       call      00007FFD3DC3FAA0
       cmp       dword ptr [7FFD3DF639A0],0
       je        near ptr M00_L41
       jmp       near ptr M00_L62
M00_L46:
       mov       rcx,r9
       call      qword ptr [7FFCDDFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,[rbp-0D8]
       jmp       near ptr M00_L44
M00_L50:
       mov       r13d,1
       jmp       short M00_L53
M00_L51:
       mov       ecx,r13d
       call      qword ptr [7FFCDE61F918]
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
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FFCDDF41110
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L25
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
       call      qword ptr [7FFCDE61FE40]; System.Array.GetLowerBound(Int32)
       mov       [rbp-80],eax
       mov       rax,[rbp-0D8]
M00_L69:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCDE61FE40]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-7C]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0E0]
       mov       edx,[rbp-80]
       mov       r8,[rbp-0D8]
       call      qword ptr [7FFCDE61FE58]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L41
M00_L70:
       mov       r13,[rbp-0B0]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L01
       mov       edx,[r13+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFCDE37CC30]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFCDE1C7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L01
M00_L71:
       call      qword ptr [7FFCDDFFF498]
       int       3
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L73:
       mov       rcx,[rbp-0A0]
       mov       r15d,[rcx+28]
       cmp       r15d,0FFFFFFFD
       je        near ptr M00_L85
       cmp       r15d,1
       je        near ptr M00_L85
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
       jg        near ptr M00_L86
M00_L75:
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,rdi
       mov       r11,7FFCDDF41160
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        near ptr M00_L87
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.IO.FileInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r13+8]
       mov       rcx,rdi
       mov       r11,7FFCDDF41168
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [r13+10],r15d
M00_L76:
       cmp       dword ptr [r13+10],0
       je        near ptr M00_L88
M00_L77:
       test      r13,r13
       je        near ptr M00_L89
       mov       byte ptr [rbp-40],1
       mov       byte ptr [rbp-48],0
       lea       r8,[rbp-48]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       mov       r9,303C0D20008
       call      qword ptr [7FFCDE6175E8]; DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo, Boolean ByRef, Boolean ByRef, System.String)
       mov       rcx,[r14+8]
       call      qword ptr [7FFCDE617600]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       rdi,rax
       xor       r14d,r14d
       cmp       qword ptr [rsi+8],0
       jne       near ptr M00_L90
       xor       r15d,r15d
M00_L78:
       mov       r12d,[r13+10]
       cmp       qword ptr [rbp-50],0
       setne     al
       movzx     eax,al
       mov       [rbp-54],eax
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-90],rax
       mov       rdx,2C32BC00070
       mov       rdx,[rdx]
       mov       rcx,rax
       call      qword ptr [7FFCDE1C76D8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rax,[rbp-90]
       mov       [rbp-98],rax
       xor       r8d,r8d
       test      r12d,r12d
       jle       short M00_L81
M00_L79:
       cmp       dword ptr [rbp-54],0
       jne       near ptr M00_L91
M00_L80:
       mov       rcx,r13
       mov       [rbp-58],r8d
       mov       edx,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE0E3578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rdx,rax
       mov       rax,[rbp-98]
       mov       [rsp+20],rax
       mov       [rsp+28],r15
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      qword ptr [7FFCDE617678]; DotNetTips.Spargine.IO.FileProcessor.MoveFileItemWithOriginalPath(System.IO.FileInfo, System.String, Boolean, System.Collections.Generic.HashSet`1<System.String>, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       r14d,eax
       jo        near ptr M00_L92
       mov       r8d,[rbp-58]
       add       r8d,1
       jo        near ptr M00_L92
       cmp       r8d,r12d
       jl        short M00_L79
M00_L81:
       mov       ecx,r14d
M00_L82:
       mov       [rbp-88],ecx
       mov       rcx,[rbx+60]
       lea       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE6A6490]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
M00_L83:
       call      qword ptr [7FFCDE597F48]
       mov       ecx,7CD
       mov       rdx,7FFCDE3F0000
       call      qword ptr [7FFCDDFFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDE2C5AB8
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDE3F0000
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDE6AFDB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDE61F5A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L84:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFCDE617780]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L85:
       call      qword ptr [7FFCDE617810]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0A0]
       jmp       near ptr M00_L74
M00_L86:
       mov       edx,ecx
       sub       edx,[rdi+30]
       mov       rcx,rdi
       call      qword ptr [7FFCDE814C90]
       jmp       near ptr M00_L75
M00_L87:
       mov       rcx,2C341C001A8
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L76
       int       3
M00_L88:
       xor       r13d,r13d
       jmp       near ptr M00_L77
M00_L89:
       xor       ecx,ecx
       jmp       near ptr M00_L82
M00_L90:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,303C0D30D88
       call      qword ptr [7FFCDE617918]
       jmp       near ptr M00_L78
M00_L91:
       cmp       qword ptr [rbp-50],0
       je        near ptr M00_L80
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L80
       lea       rcx,[rbp-50]
       call      qword ptr [7FFCDE815068]
       int       3
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFCDE64A178]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-0A0]
       mov       r15d,[rcx+28]
       cmp       r15d,0FFFFFFFD
       je        short M00_L93
       cmp       r15d,1
       jne       short M00_L94
M00_L93:
       call      qword ptr [7FFCDE617810]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-0A0]
M00_L94:
       xor       r8d,r8d
       mov       [rcx+20],r8
       mov       dword ptr [rcx+28],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       int       3
; Total bytes of code 3611
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
       call      00007FFD3DCAA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDDFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDDFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,303C0D20008
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
       call      qword ptr [7FFCDE6A4E10]
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
       jmp       qword ptr [7FFCDDFF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rax,7FFCDE1BBDE0
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFD3DC4AC10
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFD3DF639A0],0
       je        short M03_L01
       call      qword ptr [7FFD3DF51648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFD3CE10BB8
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
       call      qword ptr [7FFCDE61F900]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE375110]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M04_L06
M04_L04:
       mov       ecx,esi
       call      qword ptr [7FFCDE61F918]
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
       jmp       qword ptr [7FFCDDFF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD3DA7F650]
       mov       rbx,rax
       call      qword ptr [7FFD3DA8A8B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3DA89058]
       mov       rcx,rbx
       call      qword ptr [7FFD3DA74FC0]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD3DA86378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD3DA9D908]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD3DA86378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD3DA9D908]
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
       call      qword ptr [7FFD3DA86298]
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
       call      qword ptr [7FFD3DA86618]
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
       call      qword ptr [7FFD3DA881F0]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD3DA881F0]
       int       3
M07_L08:
       call      qword ptr [7FFD3DA7F770]
       mov       rbx,rax
       call      qword ptr [7FFD3DA8AD18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3DA89778]
       mov       rcx,rbx
       call      qword ptr [7FFD3DA74FC0]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD3DA9D8F0]
       int       3
M07_L10:
       call      qword ptr [7FFD3DA7F538]
       mov       rbx,rax
       call      qword ptr [7FFD3DA89BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD3DA881A0]
       mov       rcx,rbx
       call      qword ptr [7FFD3DA74FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FFD3DA7F538]
       mov       r14,rax
       call      qword ptr [7FFD3DA89BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD3DA881A0]
       mov       rcx,r14
       call      qword ptr [7FFD3DA74FC0]; CORINFO_HELP_THROW
       int       3
M07_L12:
       call      qword ptr [7FFD3DA75040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L04
M07_L13:
       call      qword ptr [7FFD3DA75040]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD3DA898E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L04
M07_L16:
       cmp       byte ptr [rsp+78],0
       je        short M07_L17
       call      qword ptr [7FFD3DA7F560]
       mov       rbx,rax
       call      qword ptr [7FFD3DA8A698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3DA88218]
       mov       rcx,rbx
       call      qword ptr [7FFD3DA74FC0]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFCDDFFF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rcx,7FFCDE826C34
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
       mov       rcx,7FFCDE826C38
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       cmp       esi,r14d
       jl        short M09_L02
M09_L04:
       mov       rcx,7FFCDE826C3C
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
       mov       rdx,7FFCDE809358
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FFCDE826C34
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
       mov       rcx,7FFCDE826C38
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
       mov       rdx,7FFCDE8092B8
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M09_L10:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,7FFCDE826A10
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDDFF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       mov       rcx,7FFCDE826B18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r12,[rdx+80]
       test      r12,r12
       je        short M09_L13
       jmp       short M09_L14
M09_L13:
       mov       rdx,7FFCDE659D48
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M09_L14:
       mov       rcx,rdi
       mov       rdx,7FFCDE826B20
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       rdx,[r13]
       mov       r11,r12
       call      qword ptr [r12]
       mov       r12d,eax
M09_L15:
       mov       rcx,7FFCDE826C28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [r13+8],r12d
M09_L16:
       mov       rcx,7FFCDE826C2C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M09_L11
M09_L17:
       mov       rcx,7FFCDE826C30
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
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
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M10_L08
M10_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M10_L13
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M10_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M10_L12
M10_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.IO.FileInfo
       cmp       [r15],rcx
       jne       near ptr M10_L10
       mov       rcx,r15
       call      00007FFD3DC3FEC0
       test      eax,eax
       je        near ptr M10_L09
M10_L02:
       mov       r15d,eax
M10_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
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
       cmp       r13d,[rdi+8]
       jae       near ptr M10_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M10_L14
M10_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M10_L17
       test      r13d,r13d
       jge       short M10_L05
M10_L07:
       mov       eax,0FFFFFFFF
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
M10_L08:
       mov       rdx,7FFCDE659D48
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L09:
       mov       rcx,r15
       call      qword ptr [7FFCDE1C77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M10_L15
       jmp       short M10_L16
M10_L15:
       mov       rdx,7FFCDE659D60
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M10_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M10_L06
       mov       eax,r13d
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
M10_L17:
       call      qword ptr [7FFCDDFFF498]
       int       3
M10_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 535
```
```assembly
; DotNetTips.Spargine.Core.Validator.CheckExists(System.IO.DirectoryInfo, Boolean ByRef, Boolean ByRef, System.String)
; 		input = input.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var isValid = Directory.Exists(input.FullName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false && throwException)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowDirectoryNotFoundException(CreateExceptionMessage(errorMessage, input.FullName), input);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false && createDirectory)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input.Create();
; 			^^^^^^^^^^^^^^^
; 			isValid = Directory.Exists(input.FullName);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return isValid;
; 		^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       test      rbx,rbx
       je        short M11_L01
       mov       rcx,[rbx+8]
       call      qword ptr [7FFCDE6178D0]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       movzx     edx,byte ptr [rdi]
       test      edx,ecx
       jne       near ptr M11_L02
       movzx     edx,byte ptr [rsi]
       test      edx,ecx
       jne       near ptr M11_L06
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       call      qword ptr [7FFCDE597F48]
       mov       ecx,2047
       mov       rdx,7FFCDE2C5AB8
       call      qword ptr [7FFCDDFFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDE2C5AB8
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFCDE2C5AB8
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDDFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDE6AFDB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDE61F5A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L02:
       mov       rax,[rbx+8]
       test      rbp,rbp
       je        short M11_L03
       cmp       dword ptr [rbp+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M11_L04
M11_L03:
       mov       rbp,rax
M11_L04:
       test      rbp,rbp
       jne       short M11_L05
       call      qword ptr [7FFCDE8150C8]
       mov       rbp,rax
M11_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FFCDE8150E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L06:
       mov       rcx,rbx
       call      qword ptr [7FFCDE617900]
       mov       rcx,[rbx+8]
       call      qword ptr [7FFCDE6178D0]; System.IO.Directory.Exists(System.String)
       jmp       near ptr M11_L00
; Total bytes of code 330
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
; 		path = path.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!path.EndsWith(Path.DirectorySeparatorChar))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			path += Path.DirectorySeparatorChar;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return path;
; 		^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M12_L03
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M12_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M12_L05
       mov       rax,7FFD3CE06148
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L07
M12_L00:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M12_L06
       mov       rax,7FFD3CE06148
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L07
M12_L01:
       mov       rsi,rbx
       mov       edi,[rsi+8]
       mov       ebp,edi
       cmp       word ptr [rsi+rbp*2+0A],5C
       je        short M12_L02
       add       rbx,0C
       mov       dword ptr [rsp+24],5C
       mov       edx,edi
       add       edx,1
       jo        near ptr M12_L10
       test      edx,edx
       je        near ptr M12_L08
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD3DCAA1D0
       mov       rsi,rax
       lea       r14,[rsi+0C]
       mov       r15d,[rsi+8]
       cmp       edi,r15d
       ja        near ptr M12_L09
       lea       r8,[rbp+rbp]
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFCDDFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rax,[r14+rbp*2]
       sub       r15d,edi
       je        near ptr M12_L09
       lea       rcx,[rsp+24]
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
M12_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L03:
       call      qword ptr [7FFCDE425548]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M12_L04
       call      qword ptr [7FFCDE6AFDB0]
       mov       rbx,rax
M12_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,303C0D27DF8
       call      qword ptr [7FFCDE61F5A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L05:
       call      qword ptr [7FFCDE6A61D8]
       test      eax,eax
       jne       short M12_L07
       jmp       near ptr M12_L00
M12_L06:
       call      qword ptr [7FFCDE6A61D8]
       test      eax,eax
       je        near ptr M12_L01
M12_L07:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFCDE814CA8]
       mov       rbx,rax
       jmp       near ptr M12_L01
M12_L08:
       mov       rsi,303C0D20008
       jmp       near ptr M12_L02
M12_L09:
       call      qword ptr [7FFCDE42DD58]
       int       3
M12_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 411
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       test      rdx,rdx
       jne       short M13_L01
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        near ptr M13_L05
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
M13_L01:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       jne       short M13_L04
       mov       rcx,[rbx+18]
       call      qword ptr [7FFCDDFF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L04
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M13_L06
       mov       rcx,rax
M13_L02:
       mov       rdx,rsi
       cmp       [rdx],rcx
       je        short M13_L03
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M13_L03:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
M13_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L05:
       mov       rdx,7FFCDE8092C8
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L00
M13_L06:
       mov       rdx,7FFCDE8092B8
       call      qword ptr [7FFCDDFFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M13_L02
; Total bytes of code 214
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       sub       rsp,28
       cmp       edx,[rcx+10]
       jae       short M14_L00
       mov       rax,[rcx+8]
       cmp       edx,[rax+8]
       jae       short M14_L01
       mov       ecx,edx
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M14_L00:
       call      qword ptr [7FFCDE6A4F60]
       int       3
M14_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.MoveFileItemWithOriginalPath(System.IO.FileInfo, System.String, Boolean, System.Collections.Generic.HashSet`1<System.String>, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
; 		var fileFullName = file.FullName;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!file.Exists)
; 		^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		long fileLength = 0;
; 		^^^^^^^^^^^^^^^^^^^^
; 			fileLength = file.Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newFilePath = ComputeOriginalDestPath(fileFullName, destinationPath);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var dirPath = Path.GetDirectoryName(newFilePath)!;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (createdDirs.Add(dirPath))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = Directory.CreateDirectory(dirPath);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var perf = ExecuteMove(file, newFilePath, overwrite, psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenMoved, Name = fileFullName, ProgressState = FileProgressState.FileMoved, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return 1;
; 			^^^^^^^^^
; 	}
; 	^
; 		catch (Exception ex) // Report all errors
; 		^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,108
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-118],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-110],ymm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       rsi,[rbp+30]
       mov       r13,[rbx+8]
       mov       [rbp-0B8],r13
       mov       rcx,rbx
       call      qword ptr [7FFCDE6412F8]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M15_L118
       mov       r15,[rbp+38]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M15_L61
M15_L00:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M15_L63
       test      byte ptr [rbx+30],10
       jne       near ptr M15_L62
       cmp       dword ptr [rbx+28],0
       jne       near ptr M15_L63
       mov       ecx,[rbx+4C]
       shl       rcx,20
       mov       eax,[rbx+50]
       or        rcx,rax
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M15_L38
       xor       ecx,ecx
       xor       eax,eax
M15_L01:
       test      eax,eax
       je        near ptr M15_L65
       xor       edx,edx
M15_L02:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M15_L64
       mov       r13,[rbp-0B8]
       test      r13,r13
       jne       near ptr M15_L39
       xor       r12d,r12d
       xor       eax,eax
M15_L03:
       mov       [rbp-74],eax
       test      eax,eax
       je        near ptr M15_L83
       xor       ecx,ecx
M15_L04:
       cmp       word ptr [r12+rcx*2],20
       je        near ptr M15_L66
       mov       rdx,r12
       mov       [rbp-110],rdx
       mov       r8d,eax
       mov       [rbp-78],r8d
       xor       r10d,r10d
       mov       [rbp-48],r10d
       cmp       r8d,4
       jl        short M15_L05
       cmp       word ptr [rdx],5C
       je        near ptr M15_L67
M15_L05:
       cmp       r8d,4
       jl        short M15_L07
M15_L06:
       movzx     r9d,word ptr [rdx]
       cmp       r9d,5C
       je        near ptr M15_L40
       cmp       r9d,2F
       je        near ptr M15_L40
M15_L07:
       xor       r9d,r9d
M15_L08:
       mov       [rbp-4C],r9d
       test      r9d,r9d
       jne       near ptr M15_L71
       xor       r11d,r11d
M15_L09:
       movzx     ecx,r11b
       mov       r9d,[rbp-4C]
       test      r9d,r9d
       sete      r11b
       movzx     r11d,r11b
       or        r11d,ecx
       je        short M15_L10
       movzx     r11d,word ptr [rdx]
       cmp       r11d,5C
       je        near ptr M15_L44
       cmp       r11d,2F
       je        near ptr M15_L44
M15_L10:
       test      r9d,r9d
       jne       near ptr M15_L72
       mov       eax,[rbp-74]
       cmp       eax,2
       jl        short M15_L12
       cmp       eax,1
       jbe       near ptr M15_L115
       cmp       word ptr [r12+2],3A
       jne       short M15_L12
       movzx     ecx,word ptr [r12]
       or        ecx,20
       add       ecx,0FFFFFF9F
       cmp       ecx,19
       ja        short M15_L12
       mov       r10d,2
       cmp       eax,2
       jle       near ptr M15_L81
       cmp       eax,2
       jbe       near ptr M15_L115
       movzx     ecx,word ptr [r12+4]
       cmp       ecx,5C
       je        short M15_L11
       cmp       ecx,2F
       jne       near ptr M15_L80
M15_L11:
       inc       r10d
       mov       [rbp-48],r10d
M15_L12:
       mov       r10d,[rbp-48]
       test      r10d,r10d
       jle       near ptr M15_L83
       cmp       r10d,eax
       ja        near ptr M15_L82
       mov       eax,r10d
M15_L13:
       cmp       [r13+8],eax
       je        near ptr M15_L84
       mov       [rbp-90],r12
       mov       [rbp-88],eax
       lea       rcx,[rbp-90]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       call      qword ptr [7FFCDE617B58]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r12,rax
M15_L14:
       test      r12,r12
       je        near ptr M15_L85
       cmp       [r13],r13b
       mov       rcx,2C341C001E8
       mov       r9,[rcx]
       cmp       dword ptr [r12+8],0
       je        near ptr M15_L87
       lea       rcx,[r13+0C]
       mov       edx,[r13+8]
       lea       r8,[r12+0C]
       mov       eax,[r12+8]
       test      rdi,rdi
       jne       near ptr M15_L53
       xor       r10d,r10d
       xor       r11d,r11d
M15_L15:
       mov       [rbp-90],rcx
       mov       [rbp-88],edx
       mov       [rbp-0A0],r8
       mov       [rbp-98],eax
       mov       [rbp-0B0],r10
       mov       [rbp-0A8],r11d
       mov       dword ptr [rsp+20],10000000
       lea       rcx,[rbp-90]
       lea       rdx,[rbp-0A0]
       lea       r8,[rbp-0B0]
       call      qword ptr [7FFCDE617BA0]; System.String.ReplaceCore(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       test      rax,rax
       cmove     rax,r13
       mov       r12,rax
       test      r12,r12
       je        near ptr M15_L89
       lea       rcx,[r12+0C]
       mov       eax,[r12+8]
       test      eax,eax
       je        near ptr M15_L89
       test      eax,eax
       jle       near ptr M15_L89
       xor       edx,edx
M15_L16:
       cmp       word ptr [rcx+rdx],20
       je        near ptr M15_L88
       lea       rdi,[r12+0C]
       mov       eax,[r12+8]
       mov       [rbp-7C],eax
       mov       [rbp-90],rdi
       mov       [rbp-88],eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCDE59F198]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edx,[rbp-7C]
       mov       ecx,edx
       cmp       edx,eax
       jle       near ptr M15_L90
M15_L17:
       dec       ecx
       cmp       ecx,edx
       jae       near ptr M15_L115
       mov       r8d,ecx
       movzx     r8d,word ptr [rdi+r8*2]
       cmp       r8d,5C
       je        short M15_L18
       cmp       r8d,2F
       je        short M15_L18
       cmp       ecx,eax
       jg        short M15_L17
M15_L18:
       cmp       ecx,eax
       jg        near ptr M15_L91
M15_L19:
       mov       r8d,ecx
M15_L20:
       test      r8d,r8d
       jl        near ptr M15_L89
       cmp       [r12+8],r8d
       jb        near ptr M15_L93
       test      r8d,r8d
       je        near ptr M15_L94
       cmp       [r12+8],r8d
       je        near ptr M15_L54
       mov       edi,r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFD3DCAA1D0
       mov       rcx,rax
       mov       [rbp-0C8],rcx
       cmp       [rcx],cl
       add       rcx,0C
       lea       rdx,[r12+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FFCDDFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rbp-0C8]
       mov       rcx,rdi
M15_L21:
       call      qword ptr [7FFCDE617B58]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       rdi,rax
M15_L22:
       cmp       qword ptr [rsi+8],0
       je        near ptr M15_L95
M15_L23:
       mov       rax,[rsi+10]
       mov       [rbp-0D0],rax
       mov       r8,[rsi+18]
       mov       [rbp-0D8],r8
       xor       r10d,r10d
       mov       [rbp-50],r10d
       test      rdi,rdi
       je        near ptr M15_L96
       mov       rcx,r8
       mov       rdx,rdi
       mov       r11,7FFCDDF40BF0
       call      qword ptr [r11]
M15_L24:
       mov       [rbp-54],eax
       mov       rcx,[rsi+8]
       mov       edx,eax
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       r9d,[rcx+8]
       imul      rdx,r9
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M15_L115
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       [rbp-0E0],r9
       mov       r11d,[r9]
       dec       r11d
       js        short M15_L27
M15_L25:
       mov       rdx,[rbp-0D0]
       cmp       r11d,[rdx+8]
       jae       near ptr M15_L115
       mov       ecx,r11d
       shl       rcx,4
       mov       [rbp-0D0],rdx
       lea       r11,[rdx+rcx+10]
       mov       [rbp-0E8],r11
       cmp       [r11+8],eax
       je        near ptr M15_L55
M15_L26:
       mov       r11d,[r11+0C]
       mov       r10d,[rbp-50]
       inc       r10d
       mov       rdx,[rbp-0D0]
       mov       [rbp-50],r10d
       cmp       [rdx+8],r10d
       jb        near ptr M15_L100
       test      r11d,r11d
       mov       [rbp-0D0],rdx
       mov       eax,[rbp-54]
       jge       short M15_L25
M15_L27:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M15_L101
       mov       edx,[rsi+28]
       mov       [rbp-58],edx
       mov       r11,[rbp-0D0]
       cmp       [r11+8],edx
       je        near ptr M15_L60
M15_L28:
       mov       edx,[rbp-58]
       mov       r11d,edx
       lea       ecx,[r11+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
M15_L29:
       cmp       r11d,[rcx+8]
       jae       near ptr M15_L115
       mov       [rbp-5C],r11d
       mov       edx,r11d
       shl       rdx,4
       mov       [rbp-0D0],rcx
       lea       rdx,[rcx+rdx+10]
       mov       [rdx+8],eax
       mov       r9,[rbp-0E0]
       mov       eax,[r9]
       dec       eax
       mov       [rdx+0C],eax
       mov       rcx,rdx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-5C]
       inc       edx
       mov       rcx,[rbp-0E0]
       mov       [rcx],edx
       inc       dword ptr [rsi+34]
       cmp       dword ptr [rbp-50],64
       ja        near ptr M15_L102
M15_L30:
       mov       rcx,rdi
       call      qword ptr [7FFCDE37F438]; System.IO.Directory.CreateDirectory(System.String)
M15_L31:
       movzx     r8d,r14b
       mov       rcx,rbx
       mov       rdx,r12
       mov       r9,r15
       call      qword ptr [7FFCDE617A20]; DotNetTips.Spargine.IO.FileProcessor.ExecuteMove(System.IO.FileInfo, System.String, Boolean, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       mov       [rbp-70],rax
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       mov       rax,303C0D20008
       mov       rbx,[rbp-0C0]
       mov       [rbx+8],rax
       mov       [rbx+10],rax
       call      qword ptr [7FFCDE617DF8]; DotNetTips.Spargine.Properties.Resources.get_ResourceManager()
       mov       rsi,rax
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rsi],rcx
       jne       near ptr M15_L112
       mov       rcx,2C341C00220
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M15_L33
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M15_L103
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M15_L103
M15_L32:
       mov       rdi,[rax+18]
       test      rdi,rdi
       jne       short M15_L33
       mov       rax,2C32BC00188
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M15_L33
       mov       rax,2C32BC00178
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M15_L33
       call      qword ptr [7FFCDE28C0D8]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rdi,rax
M15_L33:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCDE427B40]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       r14,rax
       test      r14,r14
       je        near ptr M15_L106
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [r14],rcx
       jne       near ptr M15_L105
       mov       rcx,r14
       mov       rdx,303C0D30F80
       mov       r9d,1
       call      qword ptr [7FFCDE42C540]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       rdx,rax
       test      rdx,rdx
       je        short M15_L34
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M15_L104
M15_L34:
       test      rdx,rdx
       je        near ptr M15_L106
M15_L35:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       mov       rdx,[rbp-40]
       mov       [rbx+18],rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,qword ptr [rbp-70]
       vdivsd    xmm0,xmm0,[7FFCDE7375A8]
       vucomisd  xmm0,qword ptr [7FFCDE7375B0]
       ja        near ptr M15_L113
       vmovsd    xmm1,qword ptr [7FFCDE7375B8]
       vucomisd  xmm1,xmm0
       ja        near ptr M15_L114
M15_L36:
       vmovsd    qword ptr [rbx+20],xmm0
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       near ptr M15_L116
M15_L37:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M15_L117
M15_L38:
       mov       r13,[rbp-0B8]
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       jmp       near ptr M15_L01
M15_L39:
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       jmp       near ptr M15_L03
M15_L40:
       movzx     ecx,word ptr [rdx+2]
       cmp       ecx,5C
       je        short M15_L41
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M15_L07
M15_L41:
       cmp       word ptr [rdx+4],2E
       je        short M15_L42
       cmp       word ptr [rdx+4],3F
       jne       near ptr M15_L07
M15_L42:
       movzx     ecx,word ptr [rdx+6]
       cmp       ecx,5C
       je        near ptr M15_L69
       cmp       ecx,2F
       sete      r9b
       movzx     r9d,r9b
M15_L43:
       jmp       near ptr M15_L08
M15_L44:
       test      ecx,ecx
       jne       short M15_L47
       cmp       r8d,1
       jle       short M15_L46
       movzx     r10d,word ptr [rdx+2]
       cmp       r10d,5C
       je        short M15_L45
       cmp       r10d,2F
       sete      r9b
       movzx     r9d,r9b
       test      r9d,r9d
       je        short M15_L46
M15_L45:
       mov       r10d,2
       jmp       short M15_L48
M15_L46:
       mov       r10d,1
       mov       [rbp-48],r10d
       mov       eax,[rbp-74]
       jmp       near ptr M15_L12
M15_L47:
       mov       r10d,8
M15_L48:
       mov       ecx,2
       jmp       short M15_L50
M15_L49:
       inc       r10d
M15_L50:
       mov       eax,[rbp-74]
       cmp       r10d,eax
       jge       short M15_L52
       mov       edx,r10d
       movzx     edx,word ptr [r12+rdx*2]
       cmp       edx,5C
       je        short M15_L51
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M15_L49
M15_L51:
       dec       ecx
       test      ecx,ecx
       jg        short M15_L49
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L52:
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L53:
       lea       r10,[rdi+0C]
       mov       r11d,[rdi+8]
       jmp       near ptr M15_L15
M15_L54:
       mov       rcx,r12
       jmp       near ptr M15_L21
M15_L55:
       mov       [rbp+38],r15
       mov       rcx,[r11]
       mov       [rbp-0F0],rcx
       mov       r15,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalIgnoreCaseComparer
       mov       r8,[rbp-0D8]
       cmp       [r8],r15
       jne       near ptr M15_L99
       mov       r8,[rbp-0D8]
       cmp       rcx,rdi
       je        near ptr M15_L97
       test      rcx,rcx
       je        near ptr M15_L98
       test      rdi,rdi
       je        near ptr M15_L98
       mov       r15d,[rcx+8]
       cmp       r15d,[rdi+8]
       jne       near ptr M15_L98
       add       rcx,0C
       lea       r15,[rdi+0C]
       mov       r8d,[rdi+8]
       cmp       r8d,8
       jl        short M15_L57
       cmp       r8d,10
       jl        short M15_L56
       mov       rdx,r15
       call      qword ptr [7FFCDE6A7A68]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector256`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       short M15_L58
M15_L56:
       mov       rdx,r15
       call      qword ptr [7FFCDE617E70]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       short M15_L58
M15_L57:
       mov       rdx,r15
       call      qword ptr [7FFCDE617BE8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M15_L58:
       mov       r8,[rbp-0D8]
M15_L59:
       test      eax,eax
       mov       r11,[rbp-0E8]
       mov       r15,[rbp+38]
       je        near ptr M15_L26
       jmp       near ptr M15_L31
M15_L60:
       mov       rcx,rsi
       call      qword ptr [7FFCDE61F990]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rsi+8]
       mov       edx,[rbp-54]
       mov       eax,edx
       imul      rax,[rsi+20]
       shr       rax,20
       inc       rax
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rax,r10
       shr       rax,20
       cmp       eax,r8d
       jae       near ptr M15_L115
       mov       eax,eax
       lea       r9,[rcx+rax*4+10]
       mov       rax,r9
       mov       [rbp-0E0],rax
       mov       eax,edx
       jmp       near ptr M15_L28
M15_L61:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FFCDE6A75A0]
       jmp       near ptr M15_L00
M15_L62:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDE6AD848]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FFCDE61EF40]; System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFCDE6AD860]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L63:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FFCDE6A7138]; System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L64:
       inc       edx
       cmp       edx,eax
       jl        near ptr M15_L02
M15_L65:
       xor       r12d,r12d
       mov       r13,[rbp-0B8]
       jmp       near ptr M15_L14
M15_L66:
       inc       ecx
       cmp       ecx,eax
       jl        near ptr M15_L04
       jmp       near ptr M15_L83
M15_L67:
       cmp       word ptr [rdx+2],5C
       je        short M15_L68
       cmp       word ptr [rdx+2],3F
       jne       near ptr M15_L05
M15_L68:
       cmp       word ptr [rdx+4],3F
       jne       near ptr M15_L05
       cmp       word ptr [rdx+6],5C
       je        short M15_L70
       jmp       near ptr M15_L06
M15_L69:
       mov       r9d,1
       jmp       near ptr M15_L43
M15_L70:
       mov       r9d,1
       jmp       near ptr M15_L08
M15_L71:
       mov       [rbp-90],rdx
       mov       [rbp-88],r8d
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCDE6A7588]
       mov       r11d,eax
       mov       rdx,[rbp-110]
       mov       r8d,[rbp-78]
       jmp       near ptr M15_L09
M15_L72:
       mov       r10d,4
       jmp       short M15_L74
M15_L73:
       inc       r10d
M15_L74:
       mov       eax,[rbp-74]
       cmp       r10d,eax
       jge       short M15_L75
       mov       ecx,r10d
       movzx     ecx,word ptr [r12+rcx*2]
       cmp       ecx,5C
       je        short M15_L76
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M15_L73
       jmp       short M15_L77
M15_L75:
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L76:
       cmp       r10d,4
       jg        short M15_L78
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L77:
       cmp       r10d,4
       jle       short M15_L79
M15_L78:
       mov       ecx,r10d
       movzx     ecx,word ptr [r12+rcx*2]
       cmp       ecx,5C
       je        near ptr M15_L11
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M15_L11
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L79:
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L80:
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L81:
       mov       [rbp-48],r10d
       jmp       near ptr M15_L12
M15_L82:
       call      qword ptr [7FFCDE1CF228]
       int       3
M15_L83:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M15_L13
M15_L84:
       mov       rcx,r13
       call      qword ptr [7FFCDE617B58]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r12,rax
       jmp       near ptr M15_L14
M15_L85:
       call      qword ptr [7FFCDE617B10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M15_L86
       call      qword ptr [7FFCDE6AFD08]
       mov       rbx,rax
M15_L86:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCDE376F58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L87:
       mov       ecx,0BF7
       mov       rdx,7FFCDDF34000
       call      qword ptr [7FFCDDFFF228]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFCDE6AD9E0]
       int       3
M15_L88:
       add       rdx,2
       dec       eax
       jne       near ptr M15_L16
M15_L89:
       xor       edi,edi
       jmp       near ptr M15_L22
M15_L90:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M15_L20
M15_L91:
       lea       r8d,[rcx-1]
       cmp       r8d,edx
       jae       near ptr M15_L115
       lea       r8d,[rcx-1]
       movzx     r8d,word ptr [rdi+r8*2]
       cmp       r8d,5C
       je        short M15_L92
       cmp       r8d,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M15_L19
M15_L92:
       dec       ecx
       jmp       near ptr M15_L18
M15_L93:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFCDE6A7540]
       int       3
M15_L94:
       mov       rcx,303C0D20008
       jmp       near ptr M15_L21
M15_L95:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCDE1C7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M15_L23
M15_L96:
       xor       ecx,ecx
       xor       r9d,r9d
       mov       eax,r9d
       jmp       near ptr M15_L24
M15_L97:
       mov       ecx,1
       mov       eax,ecx
       jmp       near ptr M15_L59
M15_L98:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M15_L59
M15_L99:
       mov       r8,[rbp-0D8]
       mov       rcx,r8
       mov       r8,rdi
       mov       rdx,[rbp-0F0]
       mov       r11,7FFCDDF40BF8
       call      qword ptr [r11]
       mov       r8,[rbp-0D8]
       jmp       near ptr M15_L59
M15_L100:
       call      qword ptr [7FFCDDFFF498]
       int       3
M15_L101:
       mov       r11d,[rsi+2C]
       dec       dword ptr [rsi+30]
       mov       edx,[rsi+2C]
       mov       rcx,[rbp-0D0]
       cmp       edx,[rcx+8]
       jae       near ptr M15_L115
       shl       rdx,4
       mov       edx,[rcx+rdx+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+2C],edx
       jmp       near ptr M15_L29
M15_L102:
       mov       rdx,[rbp-0D8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M15_L30
       mov       rdx,[rbp-0D0]
       mov       edx,[rdx+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFCDE37CC30]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCDE1C7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M15_L30
M15_L103:
       mov       ecx,2
       call      qword ptr [7FFCDE6A6E50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M15_L32
M15_L104:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M15_L105:
       mov       rcx,r14
       mov       rdx,303C0D30F80
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M15_L34
M15_L106:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,[rsi+30]
       mov       rcx,r15
       mov       rdx,rdi
       mov       r9d,1
       call      qword ptr [7FFCDE6AD830]; System.Resources.ResourceFallbackManager..ctor(System.Globalization.CultureInfo, System.Globalization.CultureInfo, Boolean)
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rdi+20],ecx
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0F8],rdi
M15_L107:
       mov       rcx,[rbp-0F8]
       call      qword ptr [7FFCDE49A0B8]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M15_L110
       mov       rcx,[rbp-0F8]
       mov       rdi,[rcx+8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       mov       r9d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE1ED7A8]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r15,rax
       test      r15,r15
       je        near ptr M15_L110
       cmp       r15,r14
       je        short M15_L107
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,r15
       mov       rdx,303C0D30F80
       mov       rax,[r15]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r12,rax
       test      r12,r12
       jne       short M15_L108
       mov       r14,r15
       jmp       short M15_L107
M15_L108:
       cmp       qword ptr [rsi+38],0
       je        short M15_L109
       mov       rdx,[rsi+38]
       mov       [rbp-108],rdx
       mov       byte ptr [rbp-68],0
       lea       rdx,[rbp-68]
       mov       rcx,[rbp-108]
       call      qword ptr [7FFCDDFF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+8]
       mov       [rbp-118],rcx
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-118]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-68],0
       je        short M15_L109
       mov       rcx,[rbp-108]
       call      qword ptr [7FFCDDFF6820]; System.Threading.Monitor.Exit(System.Object)
M15_L109:
       mov       [rbp-100],r12
       jmp       short M15_L111
M15_L110:
       xor       edx,edx
       mov       rcx,[rbp-0F8]
       mov       [rcx+18],rdx
       mov       dword ptr [rcx+20],0FFFFFFFE
       jmp       near ptr M15_L35
M15_L111:
       call      M15_L120
       nop
       mov       rdx,[rbp-100]
       mov       rbx,[rbp-0C0]
       mov       r13,[rbp-0B8]
       jmp       near ptr M15_L35
M15_L112:
       mov       r8,2C341C00220
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,303C0D30F80
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       jmp       near ptr M15_L35
M15_L113:
       vmovsd    xmm0,qword ptr [7FFCDE7375B0]
       jmp       near ptr M15_L36
M15_L114:
       vmovsd    xmm0,qword ptr [7FFCDE7375B8]
       jmp       near ptr M15_L36
M15_L115:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L116:
       mov       rdx,rcx
       mov       r8,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M15_L37
M15_L117:
       mov       eax,[rbp-44]
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
M15_L118:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE617948]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       call      qword ptr [7FFCDE617960]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+28],ecx
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FFCDE6179C0]; DotNetTips.Spargine.IO.FileProcessor.OnProcessed(DotNetTips.Spargine.IO.ProgressEventArgs)
       xor       eax,eax
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
       sub       rsp,28
       cmp       byte ptr [rbp-68],0
       je        short M15_L119
       mov       rcx,[rbp-108]
       call      qword ptr [7FFCDDFF6820]; System.Threading.Monitor.Exit(System.Object)
M15_L119:
       nop
       add       rsp,28
       ret
M15_L120:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-0F8]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCDE617948]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       mov       rcx,rbx
       mov       edx,2C
       call      qword ptr [7FFCDE617A98]; DotNetTips.Spargine.Core.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCDE617978]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Message(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FFCDE617990]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCDE6179A8]; DotNetTips.Spargine.IO.ProgressEventArgs.set_ProgressState(DotNetTips.Spargine.IO.FileProgressState)
       mov       rcx,rsi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCDE617A50]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Size(Int64)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FFCDE6179C0]; DotNetTips.Spargine.IO.FileProcessor.OnProcessed(DotNetTips.Spargine.IO.ProgressEventArgs)
       xor       eax,eax
       mov       [rbp-44],eax
       lea       rax,[M15_L117]
       add       rsp,28
       ret
; Total bytes of code 4072
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       mov       eax,[rdx]
       mov       [rcx+38],eax
       ret
; Total bytes of code 6
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       dword ptr [rcx+28],0FFFFFFFF
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M18_L00
       mov       r11,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rcx],r11
       jne       short M18_L01
M18_L00:
       ret
M18_L01:
       mov       r11,7FFCDDF40FF0
       jmp       qword ptr [r11]
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       cmp       ecx,0FFFFFFFD
       je        short M19_L01
       cmp       ecx,1
       je        short M19_L01
M19_L00:
       xor       eax,eax
       mov       [rbx+20],rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       add       rsp,20
       pop       rbx
       ret
M19_L01:
       mov       rcx,rbx
       call      qword ptr [7FFCDE617810]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       jmp       short M19_L00
; Total bytes of code 51
```

