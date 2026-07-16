## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

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
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       mov       rdi,[rbx+1A0]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L86
       mov       r14,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34<System.IO.FileInfo>
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
       mov       rcx,2774A8001F8
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [r15+28],0FFFFFFFE
       jne       near ptr M00_L83
       mov       r13d,[r15+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r13d,eax
       jne       near ptr M00_L83
       xor       ecx,ecx
       mov       [r15+28],ecx
       mov       r13,r15
M00_L00:
       mov       rdx,[r15+18]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-78],r13
M00_L01:
       mov       rcx,[rbp-78]
       mov       [rbp-80],rcx
       mov       edx,[rcx+28]
       test      edx,edx
       je        near ptr M00_L06
       cmp       edx,1
       jne       near ptr M00_L11
M00_L02:
       mov       dword ptr [rcx+28],0FFFFFFFD
M00_L03:
       mov       rdx,[rbp-80]
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
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+20]
       mov       r11,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L15
       mov       rdx,[rcx+10]
M00_L05:
       test      rdx,rdx
       je        near ptr M00_L03
       mov       rax,[rbp-80]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-80]
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
       mov       rcx,[rbp-78]
       lea       rcx,[rcx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-78]
       jmp       near ptr M00_L02
M00_L08:
       xor       edx,edx
       mov       [r14+8],rdx
       mov       dword ptr [r14+14],0FFFFFFFF
M00_L09:
       mov       r11,[rbp-80]
       mov       dword ptr [r11+28],0FFFFFFFF
       mov       r11,[rbp-80]
       mov       r11,[r11+20]
       test      r11,r11
       je        short M00_L10
       mov       rax,offset MT_System.Collections.Generic.List<System.IO.FileInfo>+Enumerator
       cmp       [r11],rax
       jne       near ptr M00_L19
M00_L10:
       mov       rax,[rbp-80]
       xor       edx,edx
       mov       [rax+20],rdx
       mov       rcx,[rbp-78]
M00_L11:
       xor       r14d,r14d
       jmp       near ptr M00_L20
M00_L12:
       call      qword ptr [7FF9C1DFF0C0]
       mov       ecx,65
       mov       rdx,7FF9C1C50BD8
       call      qword ptr [7FF9C186F210]
       mov       r14,rax
       mov       ecx,191A
       mov       rdx,7FF9C1B34C98
       call      qword ptr [7FF9C186F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9C186D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FF9C1C50BD8
       call      qword ptr [7FF9C186F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9C186D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C20943C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1F2CA98]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2774A800450
       mov       r15,[rcx]
       jmp       near ptr M00_L07
M00_L14:
       mov       rcx,r14
       mov       r11,7FF9C17B10C8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L15:
       mov       r11,7FF9C17B10D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,rax
       mov       r11,7FF9C17B10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
       jmp       near ptr M00_L09
M00_L17:
       call      qword ptr [7FF9C186FC48]
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       mov       rcx,r11
       mov       r11,7FF9C17B10E0
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L20:
       test      r14d,r14d
       je        near ptr M00_L74
       mov       rcx,[rbp-78]
       mov       r14,[rcx+8]
       cmp       qword ptr [rdi+8],0
       je        near ptr M00_L32
M00_L21:
       mov       r15,[rdi+10]
       mov       r13,[rdi+18]
       xor       r12d,r12d
       test      r14,r14
       je        near ptr M00_L55
       mov       rax,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.IO.FileInfo>
       cmp       [r13],rax
       jne       near ptr M00_L57
       mov       [rbp-58],r14
       xor       eax,eax
       mov       [rbp-60],rax
       lea       rax,[rbp-58]
       cmp       qword ptr [rbp-60],0
       jne       short M00_L22
       mov       rax,[rbp-58]
       mov       [rbp-60],rax
       lea       rax,[rbp-60]
       cmp       qword ptr [rbp-60],0
       je        near ptr M00_L56
M00_L22:
       mov       rax,[rax]
       mov       [rbp-0A0],rax
       mov       rdx,offset MT_System.IO.FileInfo
       cmp       [rax],rdx
       jne       near ptr M00_L36
       mov       rcx,rax
       call      00007FFA2146A6D0
       test      eax,eax
       je        near ptr M00_L35
M00_L23:
       mov       edx,eax
M00_L24:
       xor       ecx,ecx
       mov       [rbp-60],rcx
M00_L25:
       mov       eax,edx
M00_L26:
       mov       [rbp-48],eax
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
       mov       [rbp-90],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L29
M00_L27:
       cmp       r9d,[r15+8]
       jae       near ptr M00_L73
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r15+rdx+10]
       mov       [rbp-98],r9
       cmp       [r9+8],eax
       je        near ptr M00_L58
M00_L28:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M00_L72
       test      r9d,r9d
       mov       eax,[rbp-48]
       jge       short M00_L27
M00_L29:
       cmp       dword ptr [rdi+30],0
       jg        near ptr M00_L59
       mov       edx,[rdi+28]
       mov       [rbp-4C],edx
       cmp       [r15+8],edx
       je        near ptr M00_L37
M00_L30:
       mov       edx,[rbp-4C]
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
       mov       [rbp-88],r8
       lea       r9,[r8+rdx+10]
       mov       [r9+8],eax
       mov       r10,[rbp-90]
       mov       edx,[r10]
       dec       edx
       mov       [r9+0C],edx
       mov       rcx,r9
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-90]
       mov       [rdx],r15d
       inc       dword ptr [rdi+34]
       cmp       r12d,64
       jbe       near ptr M00_L01
       jmp       near ptr M00_L71
M00_L32:
       mov       rax,7FF9E87715F8
       xor       edx,edx
       mov       r8d,48
M00_L33:
       mov       r15d,[rax+rdx]
       test      r15d,r15d
       jge       short M00_L34
       add       rdx,4
       dec       r8d
       jne       short M00_L33
       jmp       near ptr M00_L49
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
       xchg      ax,ax
M00_L35:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FF9C1A372A0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       ja        near ptr M00_L60
M00_L38:
       mov       ecx,r10d
       call      qword ptr [7FF9C1865A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
M00_L39:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A8],rax
       mov       r10d,[rdi+28]
       mov       [rbp-64],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-0B0],rdx
       test      rdx,rdx
       je        near ptr M00_L68
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
       je        near ptr M00_L44
       mov       rax,[rbp-0A8]
       cmp       r8,4000
       ja        near ptr M00_L67
       mov       rcx,r9
       call      00007FFA2146A2B0
       cmp       dword ptr [7FFA217A4A90],0
       jne       near ptr M00_L62
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
       mov       r15d,[rbp-64]
       test      r15d,r15d
       jle       near ptr M00_L48
       mov       r8,[rbp-0A8]
       cmp       [r8+8],r15d
       jl        near ptr M00_L45
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
       mov       r15d,[rbp-48]
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
       mov       [rbp-90],rax
       mov       eax,r15d
       jmp       near ptr M00_L30
M00_L44:
       mov       rcx,r9
       call      qword ptr [7FF9C1865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L40
M00_L45:
       mov       eax,[r8+8]
M00_L46:
       cmp       ecx,[r8+8]
       jae       near ptr M00_L73
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[r8+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M00_L47
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
M00_L47:
       inc       ecx
       cmp       ecx,r15d
       jl        short M00_L46
       jmp       near ptr M00_L43
M00_L48:
       mov       r8,[rbp-0A8]
       jmp       near ptr M00_L43
M00_L49:
       mov       r15d,1
       jmp       short M00_L52
M00_L50:
       mov       ecx,r15d
       call      qword ptr [7FF9C1F2F0D8]
       test      eax,eax
       je        short M00_L51
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
       jne       short M00_L53
M00_L51:
       add       r15d,2
M00_L52:
       cmp       r15d,7FFFFFFF
       jl        short M00_L50
       jmp       short M00_L54
M00_L53:
       jmp       near ptr M00_L34
M00_L54:
       xor       r15d,r15d
       jmp       near ptr M00_L34
M00_L55:
       xor       eax,eax
       jmp       near ptr M00_L26
M00_L56:
       xor       edx,edx
       jmp       near ptr M00_L24
M00_L57:
       mov       rcx,r13
       mov       rdx,r14
       mov       r11,7FF9C17B10B8
       call      qword ptr [r11]
       mov       edx,eax
       jmp       near ptr M00_L25
M00_L58:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,r14
       mov       r11,7FF9C17B10C0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-98]
       jne       near ptr M00_L01
       jmp       near ptr M00_L28
M00_L59:
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
M00_L60:
       cmp       r8d,7FFFFFC3
       jge       short M00_L61
       mov       r15d,7FFFFFC3
       jmp       near ptr M00_L39
M00_L61:
       jmp       near ptr M00_L38
M00_L62:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L40
M00_L63:
       jmp       short M00_L69
M00_L64:
       jmp       short M00_L69
M00_L65:
       jmp       short M00_L69
M00_L66:
       jmp       short M00_L69
M00_L67:
       mov       rcx,r9
       call      qword ptr [7FF9C1DFECE8]
       jmp       near ptr M00_L40
M00_L68:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       jmp       short M00_L70
M00_L69:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9C1E967F0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-68],eax
       mov       rax,[rbp-0A8]
M00_L70:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9C1E967F0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-64]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-68]
       mov       r8,[rbp-0A8]
       call      qword ptr [7FF9C1E96808]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L40
M00_L71:
       mov       r15,[rbp-88]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L01
       mov       edx,[r15+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF9C1BEC120]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF9C1A372B8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L01
M00_L72:
       call      qword ptr [7FF9C186F480]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       mov       rcx,[rbp-78]
       mov       r14d,[rcx+28]
       cmp       r14d,0FFFFFFFD
       je        near ptr M00_L84
       cmp       r14d,1
       je        near ptr M00_L84
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
       jg        near ptr M00_L85
M00_L76:
       mov       rcx,offset MT_System.Collections.Generic.List<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9C1E9EDF0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       dword ptr [r15+10],0
       je        near ptr M00_L86
M00_L77:
       test      r15,r15
       je        near ptr M00_L87
       xor       edi,edi
       cmp       qword ptr [rsi+8],0
       jne       near ptr M00_L88
       xor       r14d,r14d
M00_L78:
       mov       r13d,[r15+10]
       cmp       qword ptr [rbp-40],0
       setne     r12b
       movzx     r12d,r12b
       xor       eax,eax
       test      r13d,r13d
       jle       short M00_L81
M00_L79:
       test      r12d,r12d
       jne       near ptr M00_L89
M00_L80:
       mov       rcx,r15
       mov       [rbp-44],eax
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1953578]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,r14
       call      qword ptr [7FF9C1E9F078]; DotNetTips.Spargine.IO.FileProcessor.DeleteFileItem(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       add       edi,eax
       jo        near ptr M00_L90
       mov       eax,[rbp-44]
       add       eax,1
       jo        near ptr M00_L90
       cmp       eax,r13d
       jl        short M00_L79
M00_L81:
       mov       ecx,edi
M00_L82:
       mov       [rbp-70],ecx
       mov       rcx,[rbx+88]
       lea       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E9F618]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
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
M00_L83:
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9C1E9F180]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       near ptr M00_L00
M00_L84:
       call      qword ptr [7FF9C1E9F210]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-78]
       jmp       near ptr M00_L75
M00_L85:
       mov       edx,ecx
       sub       edx,[rdi+30]
       mov       rcx,rdi
       call      qword ptr [7FF9C2094570]
       jmp       near ptr M00_L76
M00_L86:
       xor       r15d,r15d
       jmp       near ptr M00_L77
M00_L87:
       xor       ecx,ecx
       jmp       short M00_L82
M00_L88:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2B7C9830F68
       call      qword ptr [7FF9C1E9F2D0]
       jmp       near ptr M00_L78
M00_L89:
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L80
       mov       rcx,[rbp-40]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L80
       lea       rcx,[rbp-40]
       call      qword ptr [7FF9C20945A0]
       int       3
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-80]
       call      qword ptr [7FF9C1F07008]; Precode of DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-78]
       mov       r14d,[rcx+28]
       cmp       r14d,0FFFFFFFD
       je        short M00_L91
       cmp       r14d,1
       jne       short M00_L92
M00_L91:
       call      qword ptr [7FF9C1E9F210]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<RemoveNulls>d__34`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-78]
M00_L92:
       xor       eax,eax
       mov       [rcx+20],rax
       mov       dword ptr [rcx+28],0FFFFFFFE
       add       rsp,38
       ret
; Total bytes of code 3090
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
       call      00007FFA214E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B7C9820008
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
       call      qword ptr [7FF9C1F27A80]
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
       jmp       qword ptr [7FF9C1865C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rax,7FF9C1A2B648
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA21486C50
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M03_L01
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FF9E87715F8
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
       call      qword ptr [7FF9C1F2F0C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BE4630]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M04_L06
M04_L04:
       mov       ecx,esi
       call      qword ptr [7FF9C1F2F0D8]
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
       jbe       near ptr M05_L06
       cmp       r8,40
       ja        short M05_L03
M05_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M05_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L02:
       vzeroupper
       ret
M05_L03:
       cmp       r8,800
       ja        near ptr M05_L11
       cmp       r8,100
       jae       near ptr M05_L09
M05_L04:
       mov       r9,r8
       shr       r9,6
M05_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M05_L00
       jmp       short M05_L01
M05_L06:
       test      r8b,18
       jne       short M05_L08
       test      r8b,4
       jne       short M05_L07
       test      r8,r8
       je        short M05_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M05_L02
M05_L07:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M05_L02
M05_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M05_L02
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
       jmp       near ptr M05_L04
M05_L10:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L02
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9C18666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 335
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
       call      qword ptr [7FF9E93E3668]
       mov       rbx,rax
       call      qword ptr [7FF9E93EE8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E93ED080]
       mov       rcx,rbx
       call      qword ptr [7FF9E93D8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M07_L09
       test      rsi,rsi
       je        near ptr M07_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M07_L00
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
       jne       near ptr M07_L10
M07_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M07_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E93EA390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M07_L07
       sub       edi,eax
       js        near ptr M07_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9E93EA390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M07_L06
       sub       ebp,eax
       js        near ptr M07_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M07_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M07_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9E93EA2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M07_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M07_L16
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
M07_L01:
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
       jne       short M07_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF9E93ED928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M07_L15
M07_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       cmp       r8,4000
       jbe       short M07_L05
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
M07_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF9E93EA630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M07_L02
       jmp       near ptr M07_L14
M07_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF9E9401920]
       int       3
M07_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF9E9401920]
       int       3
M07_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF9E93EC210]
       int       3
M07_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF9E93EC210]
       int       3
M07_L10:
       call      qword ptr [7FF9E93E3788]
       mov       rbx,rax
       call      qword ptr [7FF9E93EED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E93ED7B8]
       mov       rcx,rbx
       call      qword ptr [7FF9E93D8FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF9E9401908]
       int       3
M07_L12:
       call      qword ptr [7FF9E93E3550]
       mov       rdi,rax
       call      qword ptr [7FF9E93EDC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF9E93EC1C0]
       mov       rcx,rdi
       call      qword ptr [7FF9E93D8FC0]; CORINFO_HELP_THROW
       int       3
M07_L13:
       call      qword ptr [7FF9E93E3550]
       mov       rbp,rax
       call      qword ptr [7FF9E93EDC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF9E93EC1C0]
       mov       rcx,rbp
       call      qword ptr [7FF9E93D8FC0]; CORINFO_HELP_THROW
       int       3
M07_L14:
       call      qword ptr [7FF9E93D9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L02
M07_L15:
       call      qword ptr [7FF9E93D9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L03
M07_L16:
       call      qword ptr [7FF9E93E3578]
       mov       rbx,rax
       call      qword ptr [7FF9E93EE6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E93EC240]
       mov       rcx,rbx
       call      qword ptr [7FF9E93D8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
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
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M09_L06
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
       ja        near ptr M09_L10
       mov       rcx,rax
       call      00007FFA2146A2B0
       cmp       dword ptr [7FFA217A4A90],0
       jne       near ptr M09_L09
M09_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M09_L15
M09_L02:
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
       jle       short M09_L05
       cmp       [rbp+8],r14d
       jl        near ptr M09_L07
M09_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L04
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
M09_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L03
M09_L05:
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
M09_L06:
       mov       rdx,7FF9C2065F00
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L00
M09_L07:
       cmp       ecx,[rbp+8]
       jae       near ptr M09_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L08
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
M09_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L07
       jmp       near ptr M09_L05
M09_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M09_L01
M09_L10:
       mov       rcx,rax
       call      qword ptr [7FF9C1DFECE8]
       jmp       near ptr M09_L01
M09_L11:
       mov       rcx,rax
       call      qword ptr [7FF9C1865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L01
M09_L12:
       xor       r13d,r13d
       jmp       short M09_L14
M09_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9C1E967F0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M09_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF9C1E967F0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FF9C1E96808]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M09_L01
M09_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M09_L16
       jmp       short M09_L17
M09_L16:
       mov       rdx,7FF9C2065F18
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jge       near ptr M09_L02
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
       mov       rdx,7FF9C1F6EA48
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       near ptr M09_L02
M09_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 857
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
       mov       r11,[rdx+78]
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
       call      00007FFA2146A6D0
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
       mov       rdx,7FF9C1F6EA48
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L09:
       mov       rcx,r15
       call      qword ptr [7FF9C1A372A0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FF9C1F6EA60
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9C186F480]
       int       3
M10_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M11_L30
       mov       rsi,[rcx]
       mov       rdx,rsi
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0A8]
       test      rax,rax
       je        near ptr M11_L04
M11_L00:
       mov       rcx,rax
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M11_L14
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C0]
       test      r11,r11
       je        near ptr M11_L05
M11_L01:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M11_L31
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M11_L06
M11_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0C8]
       test      r11,r11
       je        near ptr M11_L07
M11_L03:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       mov       r8,offset MT_System.Collections.Generic.HashSet<System.IO.FileInfo>
       cmp       [rdi],r8
       jne       near ptr M11_L11
       xor       r14d,r14d
       mov       r15d,[rdi+28]
       sub       r15d,[rdi+30]
       js        near ptr M11_L34
       mov       r8d,[rsi+8]
       cmp       [rsi+8],r15d
       jge       short M11_L08
       mov       ecx,6
       call      qword ptr [7FF9C1F255A8]
       int       3
M11_L04:
       mov       rcx,rdx
       mov       rdx,7FF9C20662C8
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L00
M11_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C2066308
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L01
M11_L06:
       mov       rcx,rsi
       mov       rdx,7FF9C1F3B840
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L02
M11_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C2066320
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L03
M11_L08:
       mov       r13,[rdi+10]
       xor       r12d,r12d
       cmp       dword ptr [rdi+28],0
       jle       short M11_L12
M11_L09:
       test      r15d,r15d
       je        short M11_L12
       cmp       r12d,[r13+8]
       jae       near ptr M11_L38
       mov       r8,r12
       shl       r8,4
       lea       r8,[r13+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M11_L10
       lea       edx,[r14+1]
       mov       [rbp-44],edx
       mov       r8,[r8]
       movsxd    rdx,r14d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r15d
       mov       r14d,[rbp-44]
M11_L10:
       inc       r12d
       cmp       r12d,[rdi+28]
       jge       short M11_L12
       jmp       short M11_L09
M11_L11:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
M11_L12:
       mov       rcx,[rbp+10]
       mov       [rcx+10],ebx
M11_L13:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L14:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M11_L28
M11_L15:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B0]
       test      r11,r11
       je        near ptr M11_L29
M11_L16:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>
       cmp       [rbx],rcx
       jne       near ptr M11_L36
       lea       rcx,[rbx+8]
       xor       eax,eax
       mov       rdi,rax
       xchg      rdi,[rcx]
       test      rdi,rdi
       je        near ptr M11_L35
M11_L17:
       mov       [rbp-50],rdi
       cmp       qword ptr [rbp-50],0
       je        near ptr M11_L21
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       mov       rdi,[rbp-50]
       cmp       [rdi],rcx
       jne       near ptr M11_L21
M11_L18:
       mov       rcx,rdi
       call      qword ptr [7FF9C1F020B8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M11_L27
       mov       r8,[rdi+30]
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       ebx,[rcx+10]
       cmp       [r10+8],ebx
       jbe       near ptr M11_L23
       lea       edx,[rbx+1]
       mov       [rcx+10],edx
       mov       edx,ebx
       mov       rcx,r10
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L18
M11_L19:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rdi],rcx
       jne       near ptr M11_L25
       mov       r8,[rdi+30]
M11_L20:
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       r10,[rcx+8]
       mov       ebx,[rcx+10]
       cmp       [r10+8],ebx
       jbe       near ptr M11_L26
       lea       edx,[rbx+1]
       mov       [rcx+10],edx
       mov       edx,ebx
       mov       rcx,r10
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
M11_L21:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       mov       rdi,[rbp-50]
       cmp       [rdi],rcx
       jne       short M11_L24
       mov       rcx,rdi
       call      qword ptr [7FF9C1F020B8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M11_L22:
       test      eax,eax
       je        short M11_L27
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+0B8]
       test      r11,r11
       jne       short M11_L19
       mov       rcx,rsi
       mov       rdx,7FF9C20662F0
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L19
M11_L23:
       mov       rdx,r8
       call      qword ptr [7FF9C18671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M11_L18
M11_L24:
       mov       rcx,rdi
       mov       r11,7FF9C17B0F38
       call      qword ptr [r11]
       jmp       short M11_L22
M11_L25:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r8,rax
       jmp       near ptr M11_L20
M11_L26:
       mov       rdx,r8
       call      qword ptr [7FF9C18671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M11_L21
M11_L27:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rdi],rcx
       jne       near ptr M11_L37
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9C1E9EF70]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rbx,[rdi]
       test      dword ptr [rbx],100000
       je        near ptr M11_L13
       mov       rcx,rdi
       call      00007FFA2149D4D0
       jmp       near ptr M11_L13
M11_L28:
       mov       rcx,rsi
       mov       rdx,7FF9C2062578
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L15
M11_L29:
       mov       rcx,rsi
       mov       rdx,7FF9C20662D8
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L16
M11_L30:
       mov       ecx,17
       call      qword ptr [7FF9C186FD38]
       int       3
M11_L31:
       mov       rdx,[rsi+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M11_L32
       jmp       short M11_L33
M11_L32:
       mov       rcx,rsi
       mov       rdx,7FF9C2062578
       call      qword ptr [7FF9C186F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L33:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L13
M11_L34:
       mov       ecx,28F
       mov       rdx,7FF9C17A4000
       call      qword ptr [7FF9C186F210]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF9C1F27510]
       int       3
M11_L35:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9C2094150]
       jmp       near ptr M11_L17
M11_L36:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M11_L17
M11_L37:
       mov       rcx,rdi
       mov       r11,7FF9C17B0F40
       call      qword ptr [r11]
       jmp       near ptr M11_L13
M11_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M11_L39
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       mov       rdi,[rbp-50]
       cmp       [rdi],rcx
       jne       short M11_L40
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9C1E9EF70]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rbx,[rdi]
       test      dword ptr [rbx],100000
       je        short M11_L39
       mov       rcx,rdi
       call      00007FFA2149D4D0
M11_L39:
       nop
       add       rsp,28
       ret
M11_L40:
       mov       rcx,rdi
       mov       r11,7FF9C17B0F40
       call      qword ptr [r11]
       jmp       short M11_L39
; Total bytes of code 1304
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       sub       rsp,28
       cmp       edx,[rcx+10]
       jae       short M12_L00
       mov       rax,[rcx+8]
       cmp       edx,[rax+8]
       jae       short M12_L01
       mov       ecx,edx
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M12_L00:
       call      qword ptr [7FF9C1F24F60]
       int       3
M12_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.IO.FileProcessor.DeleteFileItem(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
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
; 			var perf = ExecuteDelete(file, psw);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenDeleted, Name = fileFullName, ProgressState = FileProgressState.FileDeleted, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFCF20]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M13_L26
       xor       ecx,ecx
       mov       [rbp-38],rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       je        near ptr M13_L08
M13_L00:
       cmp       dword ptr [rbx+28],0
       jne       near ptr M13_L10
       test      byte ptr [rbx+30],10
       jne       near ptr M13_L09
       cmp       dword ptr [rbx+28],0
       jne       near ptr M13_L10
       mov       ecx,[rbx+4C]
       shl       rcx,20
       mov       edx,[rbx+50]
       or        rcx,rdx
       mov       [rbp-38],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9C1E9F3A8]; DotNetTips.Spargine.IO.FileProcessor.ExecuteDelete(System.IO.FileInfo, DotNetTips.Spargine.Core.Diagnostics.PerformanceStopwatch)
       mov       [rbp-50],rax
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,2B7C9820008
       mov       rbx,[rbp-60]
       mov       [rbx+8],rcx
       mov       [rbx+10],rcx
       mov       rcx,2774A800220
       cmp       qword ptr [rcx],0
       je        near ptr M13_L11
M13_L01:
       mov       rcx,2774A800220
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Resources.ResourceManager
       cmp       [rsi],rcx
       jne       near ptr M13_L21
       mov       rcx,2774A800228
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M13_L03
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M13_L12
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M13_L12
M13_L02:
       mov       rdi,[rax+18]
       test      rdi,rdi
       jne       short M13_L03
       mov       rax,27734800188
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M13_L03
       mov       rax,27734800178
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M13_L03
       call      qword ptr [7FF9C1AFC0C0]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rdi,rax
M13_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9C1C87180]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       r14,rax
       test      r14,r14
       je        near ptr M13_L15
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [r14],rcx
       jne       near ptr M13_L14
       mov       rcx,r14
       mov       rdx,2B7C9831038
       mov       r9d,1
       call      qword ptr [7FF9C1C87B70]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       rdx,rax
       test      rdx,rdx
       je        short M13_L04
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M13_L13
M13_L04:
       test      rdx,rdx
       je        near ptr M13_L15
M13_L05:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       mov       rdx,[rbp-38]
       mov       [rbx+18],rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,qword ptr [rbp-50]
       vdivsd    xmm0,xmm0,[7FF9C1FC6680]
       vucomisd  xmm0,qword ptr [7FF9C1FC6688]
       ja        near ptr M13_L22
       vmovsd    xmm1,qword ptr [7FF9C1FC6690]
       vucomisd  xmm1,xmm0
       ja        near ptr M13_L23
M13_L06:
       vmovsd    qword ptr [rbx+20],xmm0
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
       test      rax,rax
       jne       near ptr M13_L24
M13_L07:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M13_L25
M13_L08:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx+30],ymm0
       vmovdqu   xmmword ptr [rbx+44],xmm0
       mov       rcx,rbx
       call      qword ptr [7FF9C1F2E5F8]
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1F2F108]
       mov       rcx,rax
       mov       rdx,[rbx+8]
       call      qword ptr [7FF9C1F2E520]
       mov       rdx,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF9C1F2F120]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M13_L10:
       mov       ecx,[rbx+28]
       mov       rdx,[rbx+8]
       xor       r8d,r8d
       call      qword ptr [7FF9C1F27D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L11:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2B7C98310E0
       call      qword ptr [7FF9C2094768]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,2B7C9831078
       call      qword ptr [7FF9C1C86C10]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,2774A800220
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M13_L01
M13_L12:
       mov       ecx,2
       call      qword ptr [7FF9C1F27810]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M13_L02
M13_L13:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M13_L14:
       mov       rcx,r14
       mov       rdx,2B7C9831038
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L15:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,[rsi+30]
       mov       rcx,r15
       mov       rdx,rdi
       mov       r9d,1
       call      qword ptr [7FF9C1F2F0F0]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rdi+20],ecx
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],rdi
M13_L16:
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9C1CFA0E8]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M13_L19
       mov       rcx,[rbp-68]
       mov       rdi,[rcx+8]
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF9C1A5CF98]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r15,rax
       test      r15,r15
       je        near ptr M13_L19
       cmp       r15,r14
       je        short M13_L16
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,r15
       mov       rdx,2B7C9831038
       mov       rax,[r15]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r13,rax
       test      r13,r13
       jne       short M13_L17
       mov       r14,r15
       jmp       short M13_L16
M13_L17:
       cmp       qword ptr [rsi+38],0
       je        short M13_L18
       mov       rdx,[rsi+38]
       mov       [rbp-78],rdx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9C1865998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+8]
       mov       [rbp-80],rcx
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-80]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-48],0
       je        short M13_L18
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9C1866820]; System.Threading.Monitor.Exit(System.Object)
M13_L18:
       mov       [rbp-70],r13
       jmp       short M13_L20
M13_L19:
       xor       edx,edx
       mov       rcx,[rbp-68]
       mov       [rcx+18],rdx
       mov       dword ptr [rcx+20],0FFFFFFFE
       jmp       near ptr M13_L05
M13_L20:
       call      M13_L28
       nop
       mov       rdx,[rbp-70]
       mov       rbx,[rbp-60]
       jmp       near ptr M13_L05
M13_L21:
       mov       r8,2774A800228
       mov       r8,[r8]
       mov       rcx,rsi
       mov       rdx,2B7C9831038
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       jmp       near ptr M13_L05
M13_L22:
       vmovsd    xmm0,qword ptr [7FF9C1FC6688]
       jmp       near ptr M13_L06
M13_L23:
       vmovsd    xmm0,qword ptr [7FF9C1FC6690]
       jmp       near ptr M13_L06
M13_L24:
       mov       rdx,rcx
       mov       r8,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,[rbp+10]
       jmp       near ptr M13_L07
M13_L25:
       mov       eax,[rbp-3C]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L26:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.ProgressEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1E9F300]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       call      qword ptr [7FF9C1E9F318]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+28],ecx
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF9C1E9F378]; DotNetTips.Spargine.IO.FileProcessor.OnProcessed(DotNetTips.Spargine.IO.ProgressEventArgs)
       xor       eax,eax
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M13_L27
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9C1866820]; System.Threading.Monitor.Exit(System.Object)
M13_L27:
       nop
       add       rsp,28
       ret
M13_L28:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-68]
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
       call      qword ptr [7FF9C1E9F300]; DotNetTips.Spargine.IO.ProgressEventArgs..ctor()
       mov       rcx,rbx
       mov       edx,2C
       call      qword ptr [7FF9C1E9F420]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9C1E9F330]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Message(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FF9C1E9F348]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Name(System.String)
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9C1E9F360]; DotNetTips.Spargine.IO.ProgressEventArgs.set_ProgressState(DotNetTips.Spargine.IO.FileProgressState)
       mov       rcx,rsi
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9C1E9F3D8]; DotNetTips.Spargine.IO.ProgressEventArgs.set_Size(Int64)
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF9C1E9F378]; DotNetTips.Spargine.IO.FileProcessor.OnProcessed(DotNetTips.Spargine.IO.ProgressEventArgs)
       xor       eax,eax
       mov       [rbp-3C],eax
       lea       rax,[M13_L25]
       add       rsp,28
       ret
; Total bytes of code 1561
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
       mov       rcx,7FF9C2088EB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax+20]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rdx,7FF9C2088EB8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r11,7FF9C17B0E20
       call      qword ptr [r11]
M16_L00:
       mov       rcx,7FF9C2088FC0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 139
```

