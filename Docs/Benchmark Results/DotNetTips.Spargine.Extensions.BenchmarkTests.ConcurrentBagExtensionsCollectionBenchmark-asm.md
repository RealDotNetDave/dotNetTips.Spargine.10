## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,2A3308027A8
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D28F240]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L37
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L38
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L25
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       short M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L26
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        short M00_L04
       test      edx,edx
       jle       near ptr M00_L36
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jg        near ptr M00_L07
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        near ptr M00_L09
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAE0ED0
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L33
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L31
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L30
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L29
       cmp       r13d,[rax+8]
       ja        near ptr M00_L28
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       mov       rax,[rbp-70]
       cmp       r8,4000
       jbe       short M00_L08
       mov       rcx,r10
       call      qword ptr [7FFB0D13F930]
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L27
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L09:
       mov       r9d,r13d
       mov       eax,r9d
M00_L10:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L13
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L16
M00_L11:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L12
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAE0EC8
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L24
M00_L12:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L11
       jmp       short M00_L16
M00_L13:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L16
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L24
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
M00_L16:
       cmp       dword ptr [r15+40],0
       jg        short M00_L18
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD05020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D377378]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L38
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L17:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L19
M00_L18:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L38
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L19:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L38
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L20
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L22
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L37
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L39
M00_L21:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L22:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L40
M00_L23:
       call      qword ptr [7FFB0CDBC2A0]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FFB0D405FE0]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D137360]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D137360]
       int       3
M00_L27:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L28:
       jmp       short M00_L34
M00_L29:
       jmp       short M00_L34
M00_L30:
       jmp       short M00_L34
M00_L31:
       jmp       short M00_L34
M00_L32:
       mov       rcx,r10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1D7468]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1D7468]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1D7480]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,2E3C57411C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FFB0D13F570]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0CE2E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28F348]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L70
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L73
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L71
       test      byte ptr [7FFB0D3A2960],1
       je        near ptr M00_L72
M00_L41:
       mov       rcx,2A330802B30
       mov       r15,[rcx]
M00_L42:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L55
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L55
       jmp       short M00_L48
M00_L43:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28F480]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L47
M00_L44:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D406D48]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L60
       xor       r12d,r12d
M00_L45:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28F390]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L46:
       test      rcx,rcx
       je        short M00_L43
M00_L47:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28F4B0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L69
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L59
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L59
M00_L49:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L44
       test      eax,eax
       jl        near ptr M00_L44
       cmp       [r12+8],eax
       jle       near ptr M00_L44
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L44
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L44
       mov       rcx,[rax+20]
       jmp       near ptr M00_L46
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28F480]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L54
M00_L51:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D406D48]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L64
       xor       r12d,r12d
M00_L52:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28F390]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L53:
       test      rcx,rcx
       je        short M00_L50
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28F4B0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L56:
       test      eax,eax
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L62
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L57:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L63
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L63
M00_L58:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L51
       test      eax,eax
       jl        near ptr M00_L51
       cmp       [r12+8],eax
       jle       near ptr M00_L51
       cmp       eax,[r12+8]
       jae       near ptr M00_L68
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L51
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L51
       mov       rcx,[rax+20]
       jmp       near ptr M00_L53
M00_L59:
       mov       ecx,0E
       call      qword ptr [7FFB0D404D50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L49
M00_L60:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D406058]
       test      eax,eax
       je        near ptr M00_L45
       jmp       short M00_L67
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAE0EE0
       call      qword ptr [r11]
       jmp       near ptr M00_L56
M00_L62:
       mov       rcx,r15
       mov       r11,7FFB0CAE0EE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L57
M00_L63:
       mov       ecx,0E
       call      qword ptr [7FFB0D404D50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L58
M00_L64:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D406058]
       test      eax,eax
       je        near ptr M00_L52
       jmp       short M00_L67
M00_L65:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D405DD0]
       int       3
M00_L66:
       mov       rcx,r13
       call      qword ptr [7FFB0D404C78]
       int       3
M00_L67:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D406070]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEFC6F0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L74
M00_L70:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D3A2B60
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3770C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L72:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,rdi
       mov       r11,7FFB0CAE0ED8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L74:
       mov       rcx,r15
       mov       r11,7FFB0CAE0EF0
       call      qword ptr [r11]
       jmp       near ptr M00_L70
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L75
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28F348]; System.Threading.Lock.Exit(ThreadId)
M00_L75:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L76
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L76
       mov       rcx,r15
       mov       r11,7FFB0CAE0EF0
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D28F288]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB04791660
       xor       eax,eax
       mov       edx,48
       nop       dword ptr [rax]
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D13F798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEF6898]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D13F7B0]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D3A6720
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D3A6718
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D3A671C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
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
       jbe       near ptr M05_L04
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
       ja        short M05_L04
M05_L02:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L03:
       vzeroupper
       ret
M05_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L02
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L02
M05_L05:
       test      r8b,18
       je        short M05_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M05_L03
M05_L06:
       test      r8b,4
       je        short M05_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L03
M05_L07:
       test      r8,r8
       je        short M05_L03
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L03
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M05_L03
M05_L08:
       cmp       rcx,rdx
       jne       short M05_L09
       cmp       [rdx],dl
       jmp       short M05_L03
M05_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M07_L07
       sub       edi,eax
       js        near ptr M07_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
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
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
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
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M07_L02
       jmp       near ptr M07_L14
M07_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M07_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M07_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M07_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M07_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M07_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L02
M07_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L03
M07_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M08_L04
       test      r8,r8
       je        near ptr M08_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M08_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M08_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M08_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M08_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M08_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M08_L02
       cmp       r10,4000
       jbe       short M08_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M08_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M08_L05
M08_L01:
       add       rsp,38
       ret
M08_L02:
       cmp       r10,10
       je        short M08_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L01
M08_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M08_L01
M08_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M08_L01
M08_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M08_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M09_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M09_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M09_L01
       call      qword ptr [7FFB0D405FC8]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L01
M09_L00:
       dec       ebx
       mov       [rcx+18],ebx
M09_L01:
       add       rsp,20
       pop       rbx
       ret
M09_L02:
       call      qword ptr [7FFB0D405FB0]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M10_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M10_L12
M10_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M10_L13
       xor       esi,esi
M10_L01:
       test      rsi,rsi
       jne       near ptr M10_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M10_L07
M10_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M10_L08
       mov       rcx,rax
M10_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M10_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M10_L09
M10_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M10_L06
       test      ecx,ecx
       jl        short M10_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M10_L06
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M10_L10
M10_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D28F3A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D4512C8
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFB0D42F8B8
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D42F738
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L05
M10_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M10_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L14
M10_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D13EFE8]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D13F408]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFB0D4060A0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M10_L16
M10_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M10_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D13F000]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D13EFE8]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D13F000]
M10_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 540
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M11_L01
M11_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M11_L02
       add       rsp,28
       ret
M11_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L00
M11_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D406040]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M12_L02
M12_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M12_L01
       test      ecx,ecx
       jl        short M12_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M12_L01
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M12_L03
M12_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D28F3A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M12_L02:
       mov       rdx,7FFB0D42F738
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M12_L00
M12_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M12_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 150
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M13_L09
M13_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M13_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M13_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M13_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M13_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M13_L11
       mov       [rcx+24],eax
       jmp       near ptr M13_L13
M13_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M13_L10
M13_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M13_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M13_L08
M13_L04:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M13_L12
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CD05050]; System.Array.Copy(System.Array, System.Array, Int32)
M13_L05:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M13_L06:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       jne       short M13_L07
       lock inc  qword ptr [rsi]
M13_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M13_L01
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFB0D42F8B8
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L04
M13_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M13_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M13_L00
M13_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D13F408]
       jmp       near ptr M13_L03
M13_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
M13_L12:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0CE2E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0CE2E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M13_L05
M13_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M13_L15
M13_L14:
       mov       rcx,[rbp+10]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L15:
       call      00007FFB6C83E040
       test      eax,eax
       je        short M13_L14
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFB0D13F000]
       jmp       short M13_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M13_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M13_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M13_L17
       mov       rcx,rdi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M13_L17
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFB0D13F000]
M13_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 702
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M14_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M14_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M15_L01
       cmp       [rax],ecx
       jle       short M15_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M15_L03
M15_L00:
       add       rsp,20
       pop       rbx
       ret
M15_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M15_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M15_L00
M15_L02:
       cmp       [rax+4],edx
       jle       short M15_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M15_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M15_L03
       jmp       short M15_L00
M15_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FFB0CB95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,2AC370027A8
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D29E1A8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L37
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L38
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L25
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       short M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L26
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        short M00_L04
       test      edx,edx
       jle       near ptr M00_L36
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jg        near ptr M00_L07
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CBB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        near ptr M00_L09
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CB00E10
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L33
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L31
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L30
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L29
       cmp       r13d,[rax+8]
       ja        near ptr M00_L28
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       mov       rax,[rbp-70]
       cmp       r8,4000
       jbe       short M00_L08
       mov       rcx,r10
       call      qword ptr [7FFB0D37C078]
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L27
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L09:
       mov       r9d,r13d
       mov       eax,r9d
M00_L10:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L13
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L16
M00_L11:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L12
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CB00E08
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L24
M00_L12:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L11
       jmp       short M00_L16
M00_L13:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L16
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L24
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
M00_L16:
       cmp       dword ptr [r15+40],0
       jg        short M00_L18
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD25020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D376370]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L38
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L17:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L19
M00_L18:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L38
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L19:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L38
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L20
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L22
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L37
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L39
M00_L21:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L22:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L40
M00_L23:
       call      qword ptr [7FFB0CDD7A08]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FFB0D37F3D8]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D156AD8]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D156AD8]
       int       3
M00_L27:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L28:
       jmp       short M00_L34
M00_L29:
       jmp       short M00_L34
M00_L30:
       jmp       short M00_L34
M00_L31:
       jmp       short M00_L34
M00_L32:
       mov       rcx,r10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1D6388]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1D6388]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1D63A0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,2ECCC0F11C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FFB0D29CD80]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0DDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D29E2C8]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L70
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L73
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L71
       test      byte ptr [7FFB0D3A5C18],1
       je        near ptr M00_L72
M00_L41:
       mov       rcx,2AC37002AD0
       mov       r15,[rcx]
M00_L42:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L55
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L55
       jmp       short M00_L48
M00_L43:
       mov       rcx,rsi
       call      qword ptr [7FFB0D29E400]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L47
M00_L44:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D444168]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L60
       xor       r12d,r12d
M00_L45:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D29E310]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L46:
       test      rcx,rcx
       je        short M00_L43
M00_L47:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D29E430]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFB0CE6EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L69
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L59
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L59
M00_L49:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L44
       test      eax,eax
       jl        near ptr M00_L44
       cmp       [r12+8],eax
       jle       near ptr M00_L44
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L44
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L44
       mov       rcx,[rax+20]
       jmp       near ptr M00_L46
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FFB0D29E400]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L54
M00_L51:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D444168]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L64
       xor       r12d,r12d
M00_L52:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D29E310]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L53:
       test      rcx,rcx
       je        short M00_L50
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D29E430]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       rcx,r15
       call      qword ptr [7FFB0CE6EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L56:
       test      eax,eax
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L62
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L57:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L63
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L63
M00_L58:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L51
       test      eax,eax
       jl        near ptr M00_L51
       cmp       [r12+8],eax
       jle       near ptr M00_L51
       cmp       eax,[r12+8]
       jae       near ptr M00_L68
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L51
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L51
       mov       rcx,[rax+20]
       jmp       near ptr M00_L53
M00_L59:
       mov       ecx,0E
       call      qword ptr [7FFB0D37D458]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L49
M00_L60:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D37F498]
       test      eax,eax
       je        near ptr M00_L45
       jmp       short M00_L67
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CB00E20
       call      qword ptr [r11]
       jmp       near ptr M00_L56
M00_L62:
       mov       rcx,r15
       mov       r11,7FFB0CB00E28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L57
M00_L63:
       mov       ecx,0E
       call      qword ptr [7FFB0D37D458]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L58
M00_L64:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D37F498]
       test      eax,eax
       je        near ptr M00_L52
       jmp       short M00_L67
M00_L65:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D37F1B0]
       int       3
M00_L66:
       mov       rcx,r13
       call      qword ptr [7FFB0D37F468]
       int       3
M00_L67:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D37F4B0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CF07E58]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L74
M00_L70:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D3A5E18
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3760A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L72:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,rdi
       mov       r11,7FFB0CB00E18
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L74:
       mov       rcx,r15
       mov       r11,7FFB0CB00E30
       call      qword ptr [r11]
       jmp       near ptr M00_L70
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L75
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D29E2C8]; System.Threading.Lock.Exit(ThreadId)
M00_L75:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L76
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L76
       mov       rcx,r15
       mov       r11,7FFB0CB00E30
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D29E1F0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D402128
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D40212C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D37E148]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CF06010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D37E160]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D402134
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D402138
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D402130
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D40213C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D42A818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CBB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D42A810
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D42A814
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M05_L02
       test      r8b,18
       je        short M05_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M05_L05
M05_L00:
       test      r8b,4
       je        short M05_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M05_L05
M05_L01:
       test      r8,r8
       je        short M05_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M05_L05
M05_L02:
       cmp       r8,40
       ja        short M05_L06
M05_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M05_L10
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       vzeroupper
       ret
M05_L06:
       cmp       r8,800
       ja        near ptr M05_L11
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
       ja        short M05_L03
       jmp       short M05_L04
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M05_L04
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CBB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M05_L12:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L05
; Total bytes of code 329
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
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M07_L07
       sub       edi,eax
       js        near ptr M07_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
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
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
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
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M07_L02
       jmp       near ptr M07_L14
M07_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M07_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M07_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M07_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M07_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M07_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M07_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L02
M07_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L03
M07_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M08_L04
       test      r8,r8
       je        near ptr M08_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M08_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M08_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M08_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M08_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M08_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M08_L02
       cmp       r10,4000
       jbe       short M08_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M08_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M08_L05
M08_L01:
       add       rsp,38
       ret
M08_L02:
       cmp       r10,10
       je        short M08_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L01
M08_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M08_L01
M08_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M08_L01
M08_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M08_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M09_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M09_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M09_L01
       call      qword ptr [7FFB0D37F3C0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L01
M09_L00:
       dec       ebx
       mov       [rcx+18],ebx
M09_L01:
       add       rsp,20
       pop       rbx
       ret
M09_L02:
       call      qword ptr [7FFB0D37F3A8]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M10_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M10_L12
M10_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M10_L13
       xor       esi,esi
M10_L01:
       test      rsi,rsi
       jne       near ptr M10_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M10_L07
M10_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M10_L08
       mov       rcx,rax
M10_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M10_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M10_L09
M10_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M10_L06
       test      ecx,ecx
       jl        short M10_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M10_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M10_L10
M10_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D29E328]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D41B058
       call      qword ptr [7FFB0CBBC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFB0D419640
       call      qword ptr [7FFB0CBBC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D4194C0
       call      qword ptr [7FFB0CBBC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L05
M10_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M10_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L14
M10_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D230]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D37E1A8]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFB0D37F4E0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M10_L16
M10_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M10_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D37D350]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D230]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D37D350]
M10_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M11_L01
M11_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M11_L02
       add       rsp,28
       ret
M11_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M11_L00
M11_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D37F480]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M12_L02
M12_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M12_L01
       test      ecx,ecx
       jl        short M12_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M12_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M12_L03
M12_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D29E328]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M12_L02:
       mov       rdx,7FFB0D4194C0
       call      qword ptr [7FFB0CBBC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M12_L00
M12_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M12_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M13_L09
M13_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M13_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M13_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M13_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M13_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M13_L12
       mov       [rcx+24],eax
       jmp       near ptr M13_L14
M13_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M13_L10
M13_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M13_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M13_L11
M13_L04:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M13_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CD25050]; System.Array.Copy(System.Array, System.Array, Int32)
M13_L05:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M13_L06:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       je        short M13_L08
M13_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M13_L01
M13_L08:
       lock inc  qword ptr [rsi]
       jmp       short M13_L07
M13_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CBB5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M13_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBB6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M13_L00
M13_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D37E1A8]
       jmp       near ptr M13_L03
M13_L11:
       mov       rcx,rdx
       mov       rdx,7FFB0D419640
       call      qword ptr [7FFB0CBBC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L04
M13_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M13_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0DDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0DDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M13_L05
M13_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M13_L16
M13_L15:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L16:
       call      qword ptr [7FFB0CBB6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M13_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M13_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBB6820]; System.Threading.Monitor.Exit(System.Object)
M13_L17:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M13_L18
       mov       rcx,rdi
       call      qword ptr [7FFB0CBB6820]; System.Threading.Monitor.Exit(System.Object)
M13_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 675
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M14_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M14_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M15_L01
       cmp       [rax],ecx
       jle       short M15_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M15_L03
M15_L00:
       add       rsp,20
       pop       rbx
       ret
M15_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M15_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M15_L00
M15_L02:
       cmp       [rax+4],edx
       jle       short M15_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M15_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M15_L03
       jmp       short M15_L00
M15_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FFB0CBB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,219FF4007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D28E8E0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L36
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L23
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       near ptr M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L24
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        near ptr M00_L04
       test      edx,edx
       jle       near ptr M00_L35
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L32
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L29
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L28
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L27
       cmp       r13d,[rax+8]
       ja        near ptr M00_L26
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L31
       mov       rax,[rbp-70]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L25
       mov       rax,[rbp-70]
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAE0E08
       call      qword ptr [r11]
       jmp       short M00_L08
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       r9d,r13d
       mov       eax,r9d
M00_L08:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L11
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L14
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAE0E00
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L14
M00_L11:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L14
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L22
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L12
M00_L14:
       cmp       dword ptr [r15+40],0
       jg        short M00_L16
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L15
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD05038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D376AA8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L37
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L15:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L17
M00_L16:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L37
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L18
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L36
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFB0CDB7A08]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFB0D37F8B8]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D136AD8]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D136AD8]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L26:
       jmp       short M00_L33
M00_L27:
       jmp       short M00_L33
M00_L28:
       jmp       short M00_L33
M00_L29:
       jmp       short M00_L33
M00_L30:
       mov       rcx,r10
       call      qword ptr [7FFB0D13EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1D6AD8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1D6AD8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1D6AF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,25A7E2611C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFB0D28D470]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0BDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28EA00]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFB0D398CC0],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,219FF400AD8
       mov       r15,[rcx]
M00_L41:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L54
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L54
       jmp       short M00_L47
M00_L42:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28EB38]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D37FB58]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28EB68]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L68
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L58
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L58
M00_L48:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L43
       test      eax,eax
       jl        near ptr M00_L43
       cmp       [r12+8],eax
       jle       near ptr M00_L43
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L43
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L43
       mov       rcx,[rax+20]
       jmp       near ptr M00_L45
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28EB38]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D37FB58]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28EA48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28EB68]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L55:
       test      eax,eax
       je        near ptr M00_L68
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L56:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L62
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L62
M00_L57:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L50
       test      eax,eax
       jl        near ptr M00_L50
       cmp       [r12+8],eax
       jle       near ptr M00_L50
       cmp       eax,[r12+8]
       jae       near ptr M00_L67
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L50
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L50
       mov       rcx,[rax+20]
       jmp       near ptr M00_L52
M00_L58:
       mov       ecx,0E
       call      qword ptr [7FFB0D37DA40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D37F978]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFB0CAE0E18
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAE0E20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFB0D37DA40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D37F978]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D37F6A8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB0D37F948]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D37F990]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEE7E58]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L73
M00_L69:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D398EC0
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3767F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L70:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L72:
       mov       rcx,rdi
       mov       r11,7FFB0CAE0E10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFB0CAE0E28
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28EA00]; System.Threading.Lock.Exit(ThreadId)
M00_L74:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L75
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L75
       mov       rcx,r15
       mov       r11,7FFB0CAE0E28
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D28E928]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D3EAF18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D3EAF1C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D37E6E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEE6010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D37E700]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D3EAF24
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D3EAF28
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D3EAF20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D3EAF2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D413760
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D413758
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D41375C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
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
       je        short M05_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M05_L06
M05_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L05
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
M05_L07:
       cmp       rdi,4000
       ja        short M05_L06
       jmp       short M05_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L02
       test      r8b,18
       je        short M06_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M06_L05
M06_L00:
       test      r8b,4
       je        short M06_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L05
M06_L01:
       test      r8,r8
       je        short M06_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L05
M06_L02:
       cmp       r8,40
       ja        short M06_L06
M06_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M06_L10
M06_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L05:
       vzeroupper
       ret
M06_L06:
       cmp       r8,800
       ja        near ptr M06_L11
       cmp       r8,100
       jae       short M06_L09
M06_L07:
       mov       r9,r8
       shr       r9,6
M06_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L08
       and       r8,3F
       cmp       r8,10
       ja        short M06_L03
       jmp       short M06_L04
M06_L09:
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
       jmp       short M06_L07
M06_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M06_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M06_L04
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M06_L12:
       cmp       rcx,rdx
       jne       short M06_L11
       cmp       [rdx],dl
       jmp       near ptr M06_L05
; Total bytes of code 329
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,10
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M10_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M10_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M10_L01
       call      qword ptr [7FFB0D37F8A0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FFB0D37F888]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M11_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M11_L12
M11_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M11_L13
       xor       esi,esi
M11_L01:
       test      rsi,rsi
       jne       near ptr M11_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M11_L07
M11_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M11_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M11_L09
M11_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M11_L06
       test      ecx,ecx
       jl        short M11_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M11_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D28EA60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D3FA6E0
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFB0D3F8C30
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D3F8AB0
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D818]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D37E748]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFB0D37F9C0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M11_L16
M11_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D37D908]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D818]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D37D908]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M12_L02
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D37F960]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M13_L02
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L01
       test      ecx,ecx
       jl        short M13_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M13_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D28EA60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFB0D3F8AB0
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M13_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M14_L07
M14_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M14_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M14_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M14_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M14_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M14_L09
       mov       [rcx+24],eax
       jmp       near ptr M14_L12
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M14_L05
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M14_L08
M14_L03:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M14_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CB97048]; System.Array.Copy(System.Array, System.Array, Int32)
M14_L04:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M14_L05:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       je        near ptr M14_L11
M14_L06:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M14_L01
M14_L07:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M14_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L08:
       mov       rcx,rdx
       mov       rdx,7FFB0D3F8C30
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M14_L03
M14_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L10:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0BDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0BDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M14_L04
M14_L11:
       lock inc  qword ptr [rsi]
       jmp       near ptr M14_L06
M14_L12:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M14_L14
M14_L13:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L14:
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L13
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L15
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M14_L16
       mov       rcx,rdi
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 657
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M15_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M15_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M16_L01
       cmp       [rax],ecx
       jle       short M16_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L03
M16_L00:
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M16_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M16_L00
M16_L02:
       cmp       [rax+4],edx
       jle       short M16_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M16_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M16_L03
       jmp       short M16_L00
M16_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FFB0CB95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,1E1210007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D28E340]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L37
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L38
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L25
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       short M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L26
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        short M00_L04
       test      edx,edx
       jle       near ptr M00_L36
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jg        near ptr M00_L07
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CBA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        near ptr M00_L09
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAF0C80
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L33
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L31
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L30
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L29
       cmp       r13d,[rax+8]
       ja        near ptr M00_L28
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       mov       rax,[rbp-70]
       cmp       r8,4000
       jbe       short M00_L08
       mov       rcx,r10
       call      qword ptr [7FFB0D28C2B8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L27
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L09:
       mov       r9d,r13d
       mov       eax,r9d
M00_L10:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L13
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L16
M00_L11:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L12
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAF0C78
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L24
M00_L12:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L11
       jmp       short M00_L16
M00_L13:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L16
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L24
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L23
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
M00_L16:
       cmp       dword ptr [r15+40],0
       jg        short M00_L18
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD15038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D366508]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L38
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L17:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L19
M00_L18:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L38
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L19:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L38
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L20
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L22
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L37
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L39
M00_L21:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L22:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L40
M00_L23:
       call      qword ptr [7FFB0CDC7A08]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FFB0D36F3C0]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D146AD8]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D146AD8]
       int       3
M00_L27:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L28:
       jmp       short M00_L34
M00_L29:
       jmp       short M00_L34
M00_L30:
       jmp       short M00_L34
M00_L31:
       jmp       short M00_L34
M00_L32:
       mov       rcx,r10
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1C6580]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1C6580]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1C6598]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,221A00411C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FFB0D28CF30]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0CDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28E460]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L70
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L73
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L71
       test      byte ptr [7FFB0D396CE0],1
       je        near ptr M00_L72
M00_L41:
       mov       rcx,1E121000AD8
       mov       r15,[rcx]
M00_L42:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L55
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L55
       jmp       short M00_L48
M00_L43:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28E598]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L47
M00_L44:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D36F678]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L60
       xor       r12d,r12d
M00_L45:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28E4A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L46:
       test      rcx,rcx
       je        short M00_L43
M00_L47:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28E5C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L69
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L59
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L59
M00_L49:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L44
       test      eax,eax
       jl        near ptr M00_L44
       cmp       [r12+8],eax
       jle       near ptr M00_L44
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L44
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L44
       mov       rcx,[rax+20]
       jmp       near ptr M00_L46
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FFB0D28E598]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L54
M00_L51:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFB0D36F678]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L64
       xor       r12d,r12d
M00_L52:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D28E4A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L53:
       test      rcx,rcx
       je        short M00_L50
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D28E5C8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L56:
       test      eax,eax
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L62
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L65
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L68
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L57:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L63
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L63
M00_L58:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L51
       test      eax,eax
       jl        near ptr M00_L51
       cmp       [r12+8],eax
       jle       near ptr M00_L51
       cmp       eax,[r12+8]
       jae       near ptr M00_L68
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L51
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L51
       mov       rcx,[rax+20]
       jmp       near ptr M00_L53
M00_L59:
       mov       ecx,0E
       call      qword ptr [7FFB0D36D440]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L49
M00_L60:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D36F480]
       test      eax,eax
       je        near ptr M00_L45
       jmp       short M00_L67
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAF0C90
       call      qword ptr [r11]
       jmp       near ptr M00_L56
M00_L62:
       mov       rcx,r15
       mov       r11,7FFB0CAF0C98
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L57
M00_L63:
       mov       ecx,0E
       call      qword ptr [7FFB0D36D440]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L58
M00_L64:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D36F480]
       test      eax,eax
       je        near ptr M00_L52
       jmp       short M00_L67
M00_L65:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D36F1B0]
       int       3
M00_L66:
       mov       rcx,r13
       call      qword ptr [7FFB0D36F450]
       int       3
M00_L67:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D36F498]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEF7E58]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L69:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L74
M00_L70:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D396EE0
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D366250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L72:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,rdi
       mov       r11,7FFB0CAF0C88
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L74:
       mov       rcx,r15
       mov       r11,7FFB0CAF0CA0
       call      qword ptr [r11]
       jmp       near ptr M00_L70
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L75
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D28E460]; System.Threading.Lock.Exit(ThreadId)
M00_L75:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L76
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L76
       mov       rcx,r15
       mov       r11,7FFB0CAF0CA0
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D28E388]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D3F2950
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D3F2954
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D36E190]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEF6010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D36E1A8]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D3F295C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D3F2960
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D3F2958
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D3F2964
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
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
       call      qword ptr [7FFB0540A630]
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
       call      qword ptr [7FFB0540A630]
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
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       rcx,7FFB0D41B0B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CBA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L02
       mov       rcx,7FFB0D41B0B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       mov       rcx,7FFB0D41B0B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M05_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L06
       jmp       short M05_L02
M05_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L03
M05_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M05_L01
       jmp       short M05_L00
M05_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M05_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M05_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L03
M05_L06:
       cmp       ecx,edx
       jae       short M05_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M05_L05
       jmp       short M05_L04
M05_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L02
       test      r8b,18
       je        short M06_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M06_L05
M06_L00:
       test      r8b,4
       je        short M06_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L05
M06_L01:
       test      r8,r8
       je        short M06_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L05
M06_L02:
       cmp       r8,40
       ja        short M06_L06
M06_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M06_L10
M06_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L05:
       vzeroupper
       ret
M06_L06:
       cmp       r8,800
       ja        near ptr M06_L11
       cmp       r8,100
       jae       short M06_L09
M06_L07:
       mov       r9,r8
       shr       r9,6
M06_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L08
       and       r8,3F
       cmp       r8,10
       ja        short M06_L03
       jmp       short M06_L04
M06_L09:
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
       jmp       short M06_L07
M06_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M06_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M06_L04
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CBA66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M06_L12:
       cmp       rcx,rdx
       jne       short M06_L11
       cmp       [rdx],dl
       jmp       near ptr M06_L05
; Total bytes of code 329
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,10
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M10_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M10_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M10_L01
       call      qword ptr [7FFB0D36F3A8]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FFB0D36F390]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M11_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M11_L12
M11_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M11_L13
       xor       esi,esi
M11_L01:
       test      rsi,rsi
       jne       near ptr M11_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M11_L07
M11_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M11_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M11_L09
M11_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M11_L06
       test      ecx,ecx
       jl        short M11_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M11_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D28E4C0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D40AF78
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFB0D409560
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D4093E0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D36D218]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D36E1F0]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFB0D36F4C8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M11_L16
M11_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D36D338]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D36D218]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D36D338]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M12_L02
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D36F468]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M13_L02
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L01
       test      ecx,ecx
       jl        short M13_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M13_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D28E4C0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFB0D4093E0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M13_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M14_L06
M14_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M14_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M14_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M14_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M14_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M14_L11
       mov       [rcx+24],eax
       jmp       near ptr M14_L15
M14_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M14_L07
M14_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       near ptr M14_L08
M14_L04:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       je        near ptr M14_L14
M14_L05:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M14_L01
M14_L06:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CBA5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M14_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L07:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0D36E1F0]
       jmp       near ptr M14_L03
M14_L08:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M14_L09
       jmp       short M14_L10
M14_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D409560
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M14_L10:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M14_L12
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CBA7048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M14_L13
M14_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L12:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0CDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0CDA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M14_L13:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
       jmp       near ptr M14_L04
M14_L14:
       lock inc  qword ptr [rsi]
       jmp       near ptr M14_L05
M14_L15:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M14_L17
M14_L16:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L17:
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L18
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
M14_L18:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M14_L19
       mov       rcx,rdi
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
M14_L19:
       nop
       add       rsp,28
       ret
; Total bytes of code 674
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M15_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M15_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M16_L01
       cmp       [rax],ecx
       jle       short M16_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L03
M16_L00:
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M16_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M16_L00
M16_L02:
       cmp       [rax+4],edx
       jle       short M16_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M16_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M16_L03
       jmp       short M16_L00
M16_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FFB0CBA5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,14CA14007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D29E910]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L36
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L23
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       near ptr M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L24
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        near ptr M00_L04
       test      edx,edx
       jle       near ptr M00_L35
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L32
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L29
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L28
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L27
       cmp       r13d,[rax+8]
       ja        near ptr M00_L26
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L31
       mov       rax,[rbp-70]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L25
       mov       rax,[rbp-70]
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CBA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAF0CA0
       call      qword ptr [r11]
       jmp       short M00_L08
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       r9d,r13d
       mov       eax,r9d
M00_L08:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L11
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L14
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAF0C98
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L14
M00_L11:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L14
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L22
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L12
M00_L14:
       cmp       dword ptr [r15+40],0
       jg        short M00_L16
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L15
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD15038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D386AD8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L37
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L15:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L17
M00_L16:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L37
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L18
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L36
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFB0CDC7A08]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFB0D38F990]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D146B08]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D146B08]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L26:
       jmp       short M00_L33
M00_L27:
       jmp       short M00_L33
M00_L28:
       jmp       short M00_L33
M00_L29:
       jmp       short M00_L33
M00_L30:
       mov       rcx,r10
       call      qword ptr [7FFB0D14F3D8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1E6B08]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1E6B08]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1E6B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,18D202611C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFB0D29D4A0]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0CDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D29EA30]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFB0D3A8760],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,14CA1400A58
       mov       r15,[rcx]
M00_L41:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L54
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L54
       jmp       short M00_L47
M00_L42:
       mov       rcx,rsi
       call      qword ptr [7FFB0D29EB68]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D38FBA0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D29EA78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D29EB98]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L68
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L58
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L58
M00_L48:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L43
       test      eax,eax
       jl        near ptr M00_L43
       cmp       [r12+8],eax
       jle       near ptr M00_L43
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L43
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L43
       mov       rcx,[rax+20]
       jmp       near ptr M00_L45
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FFB0D29EB68]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D38FBA0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D29EA78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D29EB98]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFB0CE5EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L55:
       test      eax,eax
       je        near ptr M00_L68
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L56:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L62
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L62
M00_L57:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L50
       test      eax,eax
       jl        near ptr M00_L50
       cmp       [r12+8],eax
       jle       near ptr M00_L50
       cmp       eax,[r12+8]
       jae       near ptr M00_L67
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L50
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L50
       mov       rcx,[rax+20]
       jmp       near ptr M00_L52
M00_L58:
       mov       ecx,0E
       call      qword ptr [7FFB0D38DB48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D38FA20]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFB0CAF0CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAF0CB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFB0D38DB48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D38FA20]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D386BF8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB0D38F9F0]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D38FA38]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEF7E88]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L73
M00_L69:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D3A8960
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D386730]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L70:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L72:
       mov       rcx,rdi
       mov       r11,7FFB0CAF0CA8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFB0CAF0CC0
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D29EA30]; System.Threading.Lock.Exit(ThreadId)
M00_L74:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L75
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L75
       mov       rcx,r15
       mov       r11,7FFB0CAF0CC0
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D29E958]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D3FB850
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D3FB854
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D38E7C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEF6040]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D38E7D8]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D3FB85C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D3FB860
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D3FB858
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D3FB864
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D424260
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CBA5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D424258
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D42425C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
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
       je        short M05_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M05_L06
M05_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L05
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
M05_L07:
       cmp       rdi,4000
       ja        short M05_L06
       jmp       short M05_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L02
       test      r8b,18
       je        short M06_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M06_L05
M06_L00:
       test      r8b,4
       je        short M06_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L05
M06_L01:
       test      r8,r8
       je        short M06_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L05
M06_L02:
       cmp       r8,40
       ja        short M06_L06
M06_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L09
M06_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L05:
       vzeroupper
       ret
M06_L06:
       cmp       r8,800
       ja        short M06_L10
       cmp       r8,100
       jae       short M06_L11
M06_L07:
       mov       r9,r8
       shr       r9,6
M06_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L08
       and       r8,3F
       cmp       r8,10
       ja        short M06_L03
       jmp       short M06_L04
M06_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L04
M06_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CBA66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M06_L11:
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
       jmp       near ptr M06_L07
M06_L12:
       cmp       rcx,rdx
       jne       short M06_L10
       cmp       [rdx],dl
       jmp       near ptr M06_L05
; Total bytes of code 317
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,10
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M10_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M10_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M10_L01
       call      qword ptr [7FFB0D38F8E8]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FFB0D38F8D0]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M11_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M11_L12
M11_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M11_L13
       xor       esi,esi
M11_L01:
       test      rsi,rsi
       jne       near ptr M11_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M11_L07
M11_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L04:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M11_L09
M11_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M11_L06
       test      ecx,ecx
       jl        short M11_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M11_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D29EA90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D37BF90
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFB0D37BFA0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D37BEA0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D386BB0]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D386BC8]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFB0D38FA68]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M11_L16
M11_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D386BE0]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D386BB0]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D386BE0]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M12_L02
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D38FA08]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M13_L02
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L01
       test      ecx,ecx
       jl        short M13_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M13_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D29EA90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFB0D37BEA0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M13_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        short M14_L02
M14_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       near ptr M14_L03
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       near ptr M14_L03
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       near ptr M14_L03
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M14_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M14_L06
       mov       [rcx+24],eax
       jmp       near ptr M14_L11
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CBA5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M14_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFB0CBA5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M14_L09
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M14_L04
       jmp       short M14_L05
M14_L04:
       mov       rcx,rdx
       mov       rdx,7FFB0D37BFA0
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M14_L05:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M14_L07
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CBA7048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M14_L08
M14_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L07:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0CDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0CDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M14_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M14_L09:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       jne       short M14_L10
       lock inc  qword ptr [rsi]
M14_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M14_L01
M14_L11:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M14_L13
M14_L12:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L13:
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
M14_L14:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M14_L15
       mov       rcx,rdi
       call      qword ptr [7FFB0CBA6820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 646
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M15_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M15_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M16_L01
       cmp       [rax],ecx
       jle       short M16_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L03
M16_L00:
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M16_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M16_L00
M16_L02:
       cmp       [rax+4],edx
       jle       short M16_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M16_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M16_L03
       jmp       short M16_L00
M16_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FFB0CBA5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,1EF8B8007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D26E490]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B8],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L01
       mov       eax,[r14+20]
M00_L00:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jge       short M00_L02
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D126AD8]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L24
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L36
       mov       edx,edx
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       jmp       short M00_L00
M00_L02:
       mov       rdx,[r15+8]
       mov       r8,rdx
       cmp       [r8+8],ecx
       jge       short M00_L05
       cmp       dword ptr [r8+8],0
       jne       near ptr M00_L07
       mov       edx,4
M00_L03:
       mov       r10d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r10d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L28
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        short M00_L05
       test      edx,edx
       jle       near ptr M00_L39
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       test      r13d,r13d
       jg        near ptr M00_L08
M00_L04:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L05:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L06
       xor       ecx,ecx
       call      qword ptr [7FFB0CB85A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A8],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       r8,[r15+10]
       mov       [rbp-88],r8
       mov       r10,[r15+18]
       mov       [rbp-90],r10
       test      r10,r10
       je        near ptr M00_L10
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAD0CA0
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L07:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,[rbp-0C0]
       mov       rdx,rcx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L32
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L31
       cmp       r13d,[rax+8]
       ja        near ptr M00_L30
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L34
       mov       rax,[rbp-78]
       cmp       r8,4000
       jbe       short M00_L09
       mov       rcx,r10
       call      qword ptr [7FFB0D26C3A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L29
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L10:
       mov       r9d,r13d
       mov       eax,r9d
M00_L11:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L36
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-98],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-90]
       test      r8,r8
       je        near ptr M00_L14
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       mov       [rbp-6C],edx
       cmp       edx,r11d
       jbe       near ptr M00_L15
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       [rbp-88],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAD0C98
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L23
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L22
       cmp       edx,r11d
       mov       [rbp-6C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L12
       jmp       short M00_L15
M00_L14:
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L16
       mov       [rbp-6C],edx
M00_L15:
       cmp       dword ptr [r15+40],0
       jle       short M00_L18
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-6C]
       jae       near ptr M00_L36
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L20
M00_L16:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L17
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L23
M00_L17:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L22
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L16
       mov       [rbp-6C],edx
       jmp       short M00_L15
M00_L18:
       mov       r13d,[r15+38]
       cmp       [rbp-6C],r13d
       jne       short M00_L19
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CCF5038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D356658]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       edx,[rbp-44]
       mov       r8d,edx
       imul      r8,[r15+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M00_L36
       mov       r8d,r8d
       lea       r9,[rcx+r8*4+10]
       mov       rcx,r9
       mov       [rbp-98],rcx
       mov       eax,edx
M00_L19:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L20:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L36
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-98]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+4],edx
       mov       r8d,[rbp-3C]
       mov       [rcx+8],r8d
       mov       byte ptr [rcx+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L25
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L21:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L49
M00_L22:
       call      qword ptr [7FFB0CDA7A08]
       int       3
M00_L23:
       mov       ecx,r13d
       call      qword ptr [7FFB0D35F930]
       int       3
M00_L24:
       call      qword ptr [7FFB0D26D020]
       int       3
M00_L25:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L24
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L27
       mov       rcx,[r15+8]
       mov       rdx,rcx
       lea       r10d,[r9+1]
       mov       r11,rcx
       sub       eax,r9d
       test      rdx,rdx
       je        near ptr M00_L45
       mov       rcx,[rdx]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L44
       mov       r13d,eax
       or        r13d,r10d
       or        r13d,r9d
       jl        near ptr M00_L43
       lea       r13d,[r10+rax]
       mov       r12d,[rdx+8]
       cmp       r13d,r12d
       ja        near ptr M00_L42
       lea       r13d,[r9+rax]
       cmp       r13d,r12d
       ja        near ptr M00_L41
       movzx     r11d,word ptr [rcx]
       imul      rax,r11
       add       rdx,10
       imul      r10,r11
       add       r10,rdx
       mov       r9d,r9d
       imul      r9,r11
       add       rdx,r9
       test      dword ptr [rcx],1000000
       je        near ptr M00_L46
       cmp       rax,4000
       jbe       short M00_L26
       mov       [rbp-3C],r8d
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFB0D26C3A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       short M00_L27
M00_L26:
       mov       [rbp-3C],r8d
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8,rax
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L40
       mov       r8d,[rbp-3C]
M00_L27:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L28:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D126AD8]
       int       3
M00_L29:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L30:
       jmp       short M00_L37
M00_L31:
       jmp       short M00_L37
M00_L32:
       jmp       short M00_L37
M00_L33:
       jmp       short M00_L37
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FFB0CB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L35:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L38
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1B6670]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1B6670]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FFB0D1B6688]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,2300A8711C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L40:
       call      CORINFO_HELP_POLL_GC
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L27
M00_L41:
       mov       [rbp-3C],r8d
       jmp       short M00_L48
M00_L42:
       mov       [rbp-3C],r8d
       jmp       short M00_L48
M00_L43:
       mov       [rbp-3C],r8d
       jmp       short M00_L48
M00_L44:
       mov       [rbp-3C],r8d
       jmp       short M00_L48
M00_L45:
       mov       [rbp-3C],r8d
       jmp       short M00_L48
M00_L46:
       cmp       rax,10
       jne       short M00_L47
       vmovdqu   xmm0,xmmword ptr [r10]
       vmovdqu   xmmword ptr [rdx],xmm0
       jmp       near ptr M00_L27
M00_L47:
       mov       [rbp-3C],r8d
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFB0CB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L27
M00_L48:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdx
       mov       edx,r10d
       mov       r8,r11
       call      qword ptr [7FFB0D1B6688]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L27
M00_L49:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D26E5B0]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L64
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       test      byte ptr [7FFB0D37B750],1
       je        near ptr M00_L66
M00_L50:
       mov       rcx,1EF8B800A58
       mov       r15,[rcx]
M00_L51:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L60
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       jmp       short M00_L54
M00_L52:
       mov       rcx,rsi
       call      qword ptr [7FFB0D26E6E8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D26E718]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L54:
       mov       rcx,r15
       call      qword ptr [7FFB0CE3EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L63
       mov       rcx,r15
       call      qword ptr [7FFB0CE3EF38]; System.SZGenericArrayEnumerator`1[[System.__Canon, System.Private.CoreLib]].get_Current()
       mov       rdi,rax
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D26E5C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L53
       jmp       short M00_L52
M00_L55:
       mov       rcx,rsi
       call      qword ptr [7FFB0D26E6E8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L56:
       lea       r8,[rsi+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D26E718]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L61
       mov       rcx,r15
       call      qword ptr [7FFB0CE3EB50]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L58:
       test      eax,eax
       je        short M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L62
       mov       rcx,r15
       call      qword ptr [7FFB0CE3EF38]; System.SZGenericArrayEnumerator`1[[System.__Canon, System.Private.CoreLib]].get_Current()
       mov       rdi,rax
M00_L59:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D26E5C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L56
       jmp       short M00_L55
M00_L60:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L57
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAD0CB0
       call      qword ptr [r11]
       jmp       short M00_L58
M00_L62:
       mov       rcx,r15
       mov       r11,7FFB0CAD0CB8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M00_L59
M00_L63:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L68
M00_L64:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D37B950
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D356388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L51
M00_L66:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L50
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFB0CAD0CA8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L51
M00_L68:
       mov       rcx,r15
       mov       r11,7FFB0CAD0CC0
       call      qword ptr [r11]
       jmp       near ptr M00_L64
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L69
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D26E5B0]; System.Threading.Lock.Exit(ThreadId)
M00_L69:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L70
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       je        short M00_L70
       mov       rcx,r15
       mov       r11,7FFB0CAD0CC0
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,38
       ret
; Total bytes of code 2558
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D26E4D8]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D3DAE80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D3DAE84
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D35E778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CED6010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D35E790]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D3DAE8C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D3DAE90
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D3DAE88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D3DAE94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
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
       call      qword ptr [7FFB0540A630]
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
       call      qword ptr [7FFB0540A630]
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
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       rcx,7FFB0D403778
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CB85A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L02
       mov       rcx,7FFB0D403770
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       mov       rcx,7FFB0D403774
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M05_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M05_L06
       jmp       short M05_L02
M05_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M05_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L03
M05_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M05_L01
       jmp       short M05_L00
M05_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M05_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M05_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M05_L03
M05_L06:
       cmp       ecx,edx
       jae       short M05_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M05_L05
       jmp       short M05_L04
M05_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L02
       test      r8b,18
       je        short M06_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M06_L05
M06_L00:
       test      r8b,4
       je        short M06_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L05
M06_L01:
       test      r8,r8
       je        short M06_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L05
M06_L02:
       cmp       r8,40
       ja        short M06_L06
M06_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L09
M06_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L05:
       vzeroupper
       ret
M06_L06:
       cmp       r8,800
       ja        short M06_L10
       cmp       r8,100
       jae       short M06_L11
M06_L07:
       mov       r9,r8
       shr       r9,6
M06_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L08
       and       r8,3F
       cmp       r8,10
       ja        short M06_L03
       jmp       short M06_L04
M06_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L04
M06_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M06_L11:
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
       jmp       near ptr M06_L07
M06_L12:
       cmp       rcx,rdx
       jne       short M06_L10
       cmp       [rdx],dl
       jmp       near ptr M06_L05
; Total bytes of code 317
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M09_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M09_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M09_L01
       call      qword ptr [7FFB0D35F888]
       jmp       short M09_L01
M09_L00:
       dec       ebx
       mov       [rcx+18],ebx
M09_L01:
       add       rsp,20
       pop       rbx
       ret
M09_L02:
       call      qword ptr [7FFB0D35F870]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M10_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M10_L12
M10_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M10_L13
       xor       esi,esi
M10_L01:
       test      rsi,rsi
       jne       near ptr M10_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M10_L07
M10_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M10_L08
       mov       rcx,rax
M10_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M10_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M10_L09
M10_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M10_L06
       test      ecx,ecx
       jl        short M10_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M10_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M10_L10
M10_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D26E610]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D36AEE8
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFB0D36AEF8
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D36ADF8
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L05
M10_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M10_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L14
M10_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D356730]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D356748]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFB0D35FA08]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M10_L16
M10_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M10_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D356760]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D356730]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D356760]
M10_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        short M11_L02
M11_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       near ptr M11_L03
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       near ptr M11_L03
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       near ptr M11_L03
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M11_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M11_L06
       mov       [rcx+24],eax
       jmp       near ptr M11_L11
M11_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CB85998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M11_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB86820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFB0CB85998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M11_L09
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M11_L04
       jmp       short M11_L05
M11_L04:
       mov       rcx,rdx
       mov       rdx,7FFB0D36AEF8
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M11_L05:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M11_L07
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CB87048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M11_L08
M11_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L07:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0ADA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0ADA58]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M11_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M11_L09:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       jne       short M11_L10
       lock inc  qword ptr [rsi]
M11_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M11_L01
M11_L11:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M11_L13
M11_L12:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L13:
       call      qword ptr [7FFB0CB86820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M11_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB86820]; System.Threading.Monitor.Exit(System.Object)
M11_L14:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M11_L15
       mov       rcx,rdi
       call      qword ptr [7FFB0CB86820]; System.Threading.Monitor.Exit(System.Object)
M11_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 646
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M12_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M12_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.SZGenericArrayEnumerator`1[[System.__Canon, System.Private.CoreLib]].get_Current()
       sub       rsp,28
       mov       edx,[rcx+8]
       cmp       edx,[rcx+0C]
       jae       short M13_L00
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M13_L01
       mov       ecx,edx
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M13_L00:
       mov       ecx,edx
       call      qword ptr [7FFB0D356778]
       int       3
M13_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 48
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M14_L01
M14_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M14_L02
       test      ecx,ecx
       jl        short M14_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M14_L02
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M14_L02
       cmp       byte ptr [rbx+1C],0
       je        short M14_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M14_L01:
       mov       rdx,7FFB0D36ADF8
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L00
M14_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFB0D26E5E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 129
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M16_L00
       ret
M16_L00:
       jmp       qword ptr [7FFB0CB85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,253EE0007D0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D374F30]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L36
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L23
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       near ptr M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L24
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        near ptr M00_L04
       test      edx,edx
       jle       near ptr M00_L35
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L32
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L29
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L28
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L27
       cmp       r13d,[rax+8]
       ja        near ptr M00_L26
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L31
       mov       rax,[rbp-70]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L25
       mov       rax,[rbp-70]
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAE0FC0
       call      qword ptr [r11]
       jmp       short M00_L08
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       r9d,r13d
       mov       eax,r9d
M00_L08:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L11
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L14
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAE0FB8
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L14
M00_L11:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L14
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L22
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L12
M00_L14:
       cmp       dword ptr [r15+40],0
       jg        short M00_L16
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L15
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD05038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D37D758]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L37
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L15:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L17
M00_L16:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L37
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L18
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L36
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFB0CDB7A08]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFB0D4445E8]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D136B08]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D136B08]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L26:
       jmp       short M00_L33
M00_L27:
       jmp       short M00_L33
M00_L28:
       jmp       short M00_L33
M00_L29:
       jmp       short M00_L33
M00_L30:
       mov       rcx,r10
       call      qword ptr [7FFB0D13EF40]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1D6B20]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1D6B20]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1D6B38]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2946CE611C0
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFB0D28E778]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D375050]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFB0D3C69C0],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,253EE000A78
       mov       r15,[rcx]
M00_L41:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L54
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L54
       jmp       short M00_L47
M00_L42:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3752D8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D444870]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D3751E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D375308]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L68
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L58
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L58
M00_L48:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L43
       test      eax,eax
       jl        near ptr M00_L43
       cmp       [r12+8],eax
       jle       near ptr M00_L43
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L43
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L43
       mov       rcx,[rax+20]
       jmp       near ptr M00_L45
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3752D8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D444870]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D3751E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D375308]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L55:
       test      eax,eax
       je        near ptr M00_L68
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L56:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L62
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L62
M00_L57:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L50
       test      eax,eax
       jl        near ptr M00_L50
       cmp       [r12+8],eax
       jle       near ptr M00_L50
       cmp       eax,[r12+8]
       jae       near ptr M00_L67
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L50
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L50
       mov       rcx,[rax+20]
       jmp       near ptr M00_L52
M00_L58:
       mov       ecx,0E
       call      qword ptr [7FFB0D28E928]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D444678]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFB0CAE0FD0
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAE0FD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFB0D28E928]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D444678]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D37D740]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB0D444648]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D444690]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEE7E88]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L73
M00_L69:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D3C6BC0
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D37CE40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L70:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L72:
       mov       rcx,rdi
       mov       r11,7FFB0CAE0FC8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFB0CAE0FE0
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D375050]; System.Threading.Lock.Exit(ThreadId)
M00_L74:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L75
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L75
       mov       rcx,r15
       mov       r11,7FFB0CAE0FE0
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D374F78]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rsi,7FFB04791660
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFB0D401660
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L01:
       mov       rcx,7FFB0D401664
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D37ED90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEE6040]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D37EDA8]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
       mov       rcx,7FFB0D40166C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFB0D401670
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFB0D401668
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FFB0D401674
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 288
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D436DD0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D436DC8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D436DCC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
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
       je        short M05_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M05_L06
M05_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB6C7B37A0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M05_L05
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       je        short M05_L07
       call      CORINFO_HELP_POLL_GC
M05_L07:
       cmp       rdi,4000
       ja        short M05_L06
       jmp       short M05_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L03
       test      r8b,18
       je        short M06_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M06_L00:
       vzeroupper
       ret
M06_L01:
       test      r8b,4
       jne       short M06_L02
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L00
M06_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M06_L00
M06_L03:
       cmp       r8,40
       ja        short M06_L07
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M06_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M06_L06
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L00
M06_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L07:
       cmp       r8,800
       ja        short M06_L11
       cmp       r8,100
       jb        short M06_L08
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
M06_L08:
       mov       r9,r8
       shr       r9,6
M06_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M06_L04
       jmp       near ptr M06_L05
M06_L10:
       cmp       rcx,rdx
       jne       short M06_L11
       cmp       [rdx],dl
       jmp       near ptr M06_L00
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,10
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M10_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M10_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M10_L01
       call      qword ptr [7FFB0D4445A0]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FFB0D444588]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M11_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M11_L12
M11_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M11_L13
       xor       esi,esi
M11_L01:
       test      rsi,rsi
       jne       near ptr M11_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M11_L07
M11_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L04:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M11_L09
M11_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M11_L06
       test      ecx,ecx
       jl        short M11_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M11_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D375200]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D3B5400
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFB0D3B5410
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D3B5310
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D28E670]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D37D728]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFB0D4446C0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M11_L16
M11_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D28E760]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D28E670]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D28E760]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M12_L02
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D444660]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M13_L02
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L01
       test      ecx,ecx
       jl        short M13_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M13_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D375200]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFB0D3B5310
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M13_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        short M14_L02
M14_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       near ptr M14_L03
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       near ptr M14_L03
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       near ptr M14_L03
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M14_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M14_L06
       mov       [rcx+24],eax
       jmp       near ptr M14_L11
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M14_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M14_L09
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M14_L04
       jmp       short M14_L05
M14_L04:
       mov       rcx,rdx
       mov       rdx,7FFB0D3B5410
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M14_L05:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M14_L07
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CB97048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M14_L08
M14_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L07:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M14_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M14_L09:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       jne       short M14_L10
       lock inc  qword ptr [rsi]
M14_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M14_L01
M14_L11:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M14_L13
M14_L12:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L13:
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L14:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M14_L15
       mov       rcx,rdi
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 646
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M15_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M15_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M16_L01
       cmp       [rax],ecx
       jle       short M16_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L03
M16_L00:
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M16_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M16_L00
M16_L02:
       cmp       [rax+4],edx
       jle       short M16_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M16_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M16_L03
       jmp       short M16_L00
M16_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FFB0CB95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.AddRange()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       byte ptr [rdi+1D],0
       mov       rcx,1A515400820
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFB0D3A6E80]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0B0],r15
       mov       [rbp-5C],ecx
       mov       r15,[r14+10]
       mov       r13d,[r15+10]
       mov       r12d,r13d
       test      r12d,r12d
       jg        short M00_L00
       mov       eax,[r14+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L36
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
M00_L01:
       mov       rdx,[r14+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r15],r15b
       test      ecx,ecx
       jl        near ptr M00_L23
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       jge       near ptr M00_L04
       mov       rdx,[r15+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r13d
       jl        near ptr M00_L24
       mov       rcx,[r15+8]
       cmp       [rcx+8],edx
       je        near ptr M00_L04
       test      edx,edx
       jle       near ptr M00_L35
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-78],rdx
       test      rdx,rdx
       je        near ptr M00_L32
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L29
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L28
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L27
       cmp       r13d,[rax+8]
       ja        near ptr M00_L26
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L31
       mov       rax,[rbp-70]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       near ptr M00_L25
       mov       rax,[rbp-70]
M00_L03:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-3C]
M00_L04:
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       mov       r15,[r14+8]
       mov       [rbp-3C],eax
       mov       r13d,eax
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-98],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-80],r8
       mov       r10,[r15+18]
       mov       [rbp-88],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFB0CAE1128
       call      qword ptr [r11]
       jmp       short M00_L08
M00_L06:
       mov       rdx,[r15+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       r9d,r13d
       mov       eax,r9d
M00_L08:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-88]
       test      r8,r8
       je        short M00_L11
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L14
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-80],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFB0CAE1120
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-80]
       mov       r8,[rbp-88]
       mov       r11,[rbp-68]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L14
M00_L11:
       mov       rcx,[rbp-80]
       cmp       [rcx+8],r11d
       jbe       short M00_L14
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       edx,[rbp-3C]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L22
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L12
M00_L14:
       cmp       dword ptr [r15+40],0
       jg        short M00_L16
       mov       r13d,[r15+38]
       cmp       [rcx+8],r13d
       jne       short M00_L15
       mov       ecx,[r15+38]
       call      qword ptr [7FFB0CD05038]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0D3AF618]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r15+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M00_L37
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-90],r8
       mov       eax,ecx
M00_L15:
       lea       r8d,[r13+1]
       mov       [r15+38],r8d
       mov       rcx,[r15+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L17
M00_L16:
       mov       r8d,[r15+3C]
       mov       r13d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L37
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r15+3C],r8d
       dec       dword ptr [r15+40]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       r8d,r13d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-90]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-3C]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [r15+44]
       test      r12d,r12d
       jg        short M00_L18
       mov       [rbp-3C],edx
       lea       r8d,[rdx+1]
       mov       [r14+20],r8d
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       r8d,[r15+10]
       cmp       r9d,r8d
       jae       near ptr M00_L36
       dec       r8d
       mov       [r15+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],edx
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFB0CDB7A08]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFB0D444B10]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB0D136B08]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D136B08]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L26:
       jmp       short M00_L33
M00_L27:
       jmp       short M00_L33
M00_L28:
       jmp       short M00_L33
M00_L29:
       jmp       short M00_L33
M00_L30:
       mov       rcx,r10
       call      qword ptr [7FFB0D13EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB0D1D6AA8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB0D1D6AA8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFB0D1D6AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,1E594341348
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFB0D286280]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D3A6FA0]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+2F0]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFB0D41EA90],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1A515400B10
       mov       r15,[rcx]
M00_L41:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L54
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L54
       jmp       short M00_L47
M00_L42:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3A7228]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D444D98]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D3A7138]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3A7258]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L68
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L58
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L58
M00_L48:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L43
       test      eax,eax
       jl        near ptr M00_L43
       cmp       [r12+8],eax
       jle       near ptr M00_L43
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L43
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L43
       mov       rcx,[rax+20]
       jmp       near ptr M00_L45
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3A7228]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFB0D444D98]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFB0D3A7138]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3A7258]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFB0CE4EB70]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L55:
       test      eax,eax
       je        near ptr M00_L68
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L64
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L67
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L56:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L62
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L62
M00_L57:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L50
       test      eax,eax
       jl        near ptr M00_L50
       cmp       [r12+8],eax
       jle       near ptr M00_L50
       cmp       eax,[r12+8]
       jae       near ptr M00_L67
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L50
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L50
       mov       rcx,[rax+20]
       jmp       near ptr M00_L52
M00_L58:
       mov       ecx,0E
       call      qword ptr [7FFB0D286430]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D444BA0]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFB0CAE1138
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFB0CAE1140
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFB0D286430]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFB0D444BA0]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFB0D3AF600]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFB0D444B70]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFB0D444BB8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB0CEE7E88]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L73
M00_L69:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-58]
       mov       rdx,7FFB0D41EC90
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3AEC40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L70:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L72:
       mov       rcx,rdi
       mov       r11,7FFB0CAE1130
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFB0CAE1148
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFB0D3A6FA0]; System.Threading.Lock.Exit(ThreadId)
M00_L74:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0A8],0
       je        short M00_L75
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       je        short M00_L75
       mov       rcx,r15
       mov       r11,7FFB0CAE1148
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2803
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M01_L02
M01_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB0D3A6EC8]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M01_L01:
       nop
       add       rsp,28
       ret
M01_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M01_L01
; Total bytes of code 89
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFB04791660
       xor       eax,eax
       mov       edx,48
M02_L00:
       mov       r8d,[rcx+rax]
       cmp       r8d,ebx
       jge       short M02_L01
       add       rax,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0D28FE40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CEE6040]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFB0D28FE58]
       test      eax,eax
       je        short M02_L05
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
       jne       short M02_L07
M02_L05:
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 182
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FFB0D459440
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0CB95A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFB0D459438
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFB0D45943C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       movsxd    rcx,esi
       call      qword ptr [7FFB05406F18]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFB0540A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFB05406B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L03
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M04_L06
       jmp       short M04_L02
M04_L00:
       mov       eax,[rdi+rdx+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M04_L07
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdi+rdx+14],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L01:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L02:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
       jmp       short M04_L00
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFB053F8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       eax,[rdi+rax+10]
       mov       r10,[rbx+8]
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      rax,r11
       shr       rax,20
       cmp       eax,r9d
       jae       short M04_L07
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L05:
       inc       ecx
       cmp       ecx,ebp
       jge       short M04_L03
M04_L06:
       cmp       ecx,edx
       jae       short M04_L07
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L05
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 325
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
       je        short M05_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M05_L06
M05_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFB6C7B37A0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M05_L05
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       je        short M05_L07
       call      CORINFO_HELP_POLL_GC
M05_L07:
       cmp       rdi,4000
       ja        short M05_L06
       jmp       short M05_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L03
       test      r8b,18
       jne       short M06_L02
       test      r8b,4
       je        short M06_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M06_L00:
       vzeroupper
       ret
M06_L01:
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L00
M06_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M06_L00
M06_L03:
       cmp       r8,40
       ja        short M06_L07
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L06
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L00
M06_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L07:
       cmp       r8,800
       ja        short M06_L11
       cmp       r8,100
       jb        short M06_L08
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
M06_L08:
       mov       r9,r8
       shr       r9,6
M06_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M06_L04
       jmp       near ptr M06_L05
M06_L10:
       cmp       rcx,rdx
       jne       short M06_L11
       cmp       [rdx],dl
       jmp       near ptr M06_L00
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        short M07_L00
       cmp       edx,eax
       jae       short M07_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFB05403668]
       mov       rbx,rax
       call      qword ptr [7FFB0540E8F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D080]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L10
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M08_L07
       sub       edi,eax
       js        near ptr M08_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0540A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M08_L06
       sub       ebp,eax
       js        near ptr M08_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0540A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M08_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L16
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
M08_L01:
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
       jne       short M08_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L15
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L04:
       cmp       r8,4000
       jbe       short M08_L05
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
M08_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M08_L02
       jmp       near ptr M08_L14
M08_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFB05421920]
       int       3
M08_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFB0540C210]
       int       3
M08_L10:
       call      qword ptr [7FFB05403788]
       mov       rbx,rax
       call      qword ptr [7FFB0540ED58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540D7B8]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFB05421908]
       int       3
M08_L12:
       call      qword ptr [7FFB05403550]
       mov       rdi,rax
       call      qword ptr [7FFB0540DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rdi
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L13:
       call      qword ptr [7FFB05403550]
       mov       rbp,rax
       call      qword ptr [7FFB0540DC08]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FFB0540C1C0]
       mov       rcx,rbp
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
M08_L14:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L02
M08_L15:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7FFB05403578]
       mov       rbx,rax
       call      qword ptr [7FFB0540E6D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0540C240]
       mov       rcx,rbx
       call      qword ptr [7FFB053F8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFB0540A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,10
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFB0540D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movups    xmm0,[rdx]
       movups    [rcx],xmm0
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFB0540A328]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFB053F9040]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 234
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M10_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M10_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M10_L01
       call      qword ptr [7FFB0D444AC8]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FFB0D444AB0]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-18],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       mov       [rbp-28],rdx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdx,rdx
       je        near ptr M11_L11
       mov       rcx,rdx
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M11_L12
M11_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M11_L13
       xor       esi,esi
M11_L01:
       test      rsi,rsi
       jne       near ptr M11_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M11_L07
M11_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M11_L08
       mov       rcx,rax
M11_L03:
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+20],1F
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M11_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M11_L09
M11_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M11_L06
       test      ecx,ecx
       jl        short M11_L06
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M11_L06
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D3A7150]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFB0D423218
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFB0D423228
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFB0D423128
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FFB0D286178]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFB0D2874B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFB0D444BE8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       jne       short M11_L16
M11_L15:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M11_L16:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D286268]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFB0D286178]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFB6C83E040
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFB0D286268]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 538
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFB6C7EE990
       call      rax
       test      eax,eax
       jne       short M12_L02
       add       rsp,28
       ret
M12_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L02:
       add       rsp,28
       jmp       qword ptr [7FFB0D444B88]
; Total bytes of code 54
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M13_L02
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L01
       test      ecx,ecx
       jl        short M13_L01
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M13_L01
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0D3A7150]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFB0D423128
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L03:
       cmp       byte ptr [rbx+1C],0
       je        short M13_L01
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 148
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        short M14_L02
M14_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       near ptr M14_L03
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       near ptr M14_L03
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       near ptr M14_L03
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M14_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M14_L06
       mov       [rcx+24],eax
       jmp       near ptr M14_L11
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp-50]
       mov       eax,[rcx+20]
       and       [rcx+18],eax
       mov       edi,[rcx+20]
       and       edi,7FFFFFFF
       mov       [rcx+1C],edi
       add       rcx,2C
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M14_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFB0CB95998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M14_L09
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M14_L04
       jmp       short M14_L05
M14_L04:
       mov       rcx,rdx
       mov       rdx,7FFB0D423228
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M14_L05:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M14_L07
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFB0CB97048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M14_L08
M14_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L07:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFB0D0BDA88]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M14_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r15d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       mov       rcx,rdi
       mov       edi,r14d
M14_L09:
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       rdi,[rbp+10]
       mov       [rdi+1C],ecx
       test      r15d,r15d
       jne       short M14_L10
       lock inc  qword ptr [rsi]
M14_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M14_L01
M14_L11:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M14_L13
M14_L12:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L13:
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L14:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M14_L15
       mov       rcx,rdi
       call      qword ptr [7FFB0CB96820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 646
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M15_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M15_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M16_L01
       cmp       [rax],ecx
       jle       short M16_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L03
M16_L00:
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M16_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M16_L00
M16_L02:
       cmp       [rax+4],edx
       jle       short M16_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M16_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M16_L03
       jmp       short M16_L00
M16_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FFB0CB95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CBB6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CD2F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,247F0C01FD0
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D39E6D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D39E6D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D39E6B8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D39D7A0]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D39FC78]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D3B8A88],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,24806C00AD0
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       jbe       short M00_L26
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       jbe       short M00_L30
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CB00DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CB00DD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D39F630]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       call      qword ptr [7FFB0CDDDED8]
       mov       ecx,0BD
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE84F28
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D39CFC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D39CFD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L41:
       mov       rcx,rsi
       mov       r11,7FFB0CB00DE8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,247F0C01FD0
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L42:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CB00DF0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24806C00AD8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CB00DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CB00DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CB00DE0
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D39D890]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D39D7A0]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D39D890]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1669
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CF0F5A0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D39C618]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBBD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       r14d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M05_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D156AD8]
       int       3
M05_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M05_L00
M05_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M05_L08
       test      r14d,r14d
       jg        short M05_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFB0D4156A8
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M05_L09
       mov       rcx,rax
M05_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M05_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBB7048]; System.Array.Copy(System.Array, System.Array, Int32)
M05_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L09:
       mov       rdx,7FFB0D38E0C0
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
; Total bytes of code 309
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
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28885D00008
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
       call      qword ptr [7FFB0D39F150]
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
       jmp       qword ptr [7FFB0CBB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CB96850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CD0F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,1999C001FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D357CC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D357CC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D357D68]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D357C60]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D35C300]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D334FD0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,199B2000A50
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       ja        short M00_L26
       call      qword ptr [7FFB0CD0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       ja        short M00_L30
       call      qword ptr [7FFB0CD0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CAE0B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CAE0B48
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D357C90]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       call      qword ptr [7FFB0CDBDED8]
       mov       ecx,0BD
       mov       rdx,7FFB0CFB2518
       call      qword ptr [7FFB0CDB7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE64F28
       call      qword ptr [7FFB0CDB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CB97858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFB2518
       call      qword ptr [7FFB0CDB7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CB97858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D35C768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D35C780]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L41:
       mov       rcx,rsi
       mov       r11,7FFB0CAE0B58
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,1999C001FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L42:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CAE0B60
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CB95728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,199B2000A58
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      qword ptr [7FFB0CB95728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CAE0B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CAE0B50
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CAE0B50
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D357C78]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D357C60]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D357C78]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1671
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CEEF5A0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D357C48]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CB9D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       r14d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M05_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D136AD8]
       int       3
M05_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M05_L00
M05_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M05_L08
       test      r14d,r14d
       jg        short M05_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      qword ptr [7FFB0CB95728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFB0D32C8C8
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M05_L09
       mov       rcx,rax
M05_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M05_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CB97048]; System.Array.Copy(System.Array, System.Array, Int32)
M05_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L09:
       mov       rdx,7FFB0D32C8D8
       call      qword ptr [7FFB0CB9C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
; Total bytes of code 310
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
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1DA30E70008
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
       call      qword ptr [7FFB0D35C9C0]
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
       jmp       qword ptr [7FFB0CB95C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CBA6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CD1F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,1F64D801FD0
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D38E670]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D38E670]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D38E658]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D38D7A0]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D38FC48]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D3A8A78],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,1F663800AD0
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       call      qword ptr [7FFB0CD1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       jbe       short M00_L26
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       call      qword ptr [7FFB0CD1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       jbe       short M00_L30
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CAF0DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CAF0DD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D38F630]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       call      qword ptr [7FFB0CDCDED8]
       mov       ecx,0BD
       mov       rdx,7FFB0CFC2518
       call      qword ptr [7FFB0CDC7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE74F28
       call      qword ptr [7FFB0CDC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBA7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFC2518
       call      qword ptr [7FFB0CDC7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBA7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D38D6C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D38D6E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L41:
       mov       rcx,rsi
       mov       r11,7FFB0CAF0DE8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,1F64D801FD0
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L42:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CAF0DF0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F663800AD8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CAF0DC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CAF0DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CAF0DE0
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D38D890]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D38D7A0]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D38D890]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1669
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CEFF5A0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D38C5D0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBAD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       r14d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M05_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D146AD8]
       int       3
M05_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M05_L00
M05_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M05_L08
       test      r14d,r14d
       jg        short M05_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFB0D4058C8
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M05_L09
       mov       rcx,rax
M05_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M05_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBA7048]; System.Array.Copy(System.Array, System.Array, Int32)
M05_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L09:
       mov       rdx,7FFB0D37E368
       call      qword ptr [7FFB0CBAC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
; Total bytes of code 309
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
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,236E28B0008
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
       call      qword ptr [7FFB0D38F150]
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
       jmp       qword ptr [7FFB0CBA5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CBB6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CD2F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,265F0801FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3775B8]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D3775B8]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D377F00]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D377D38]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D37C720]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D355880],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,26606800A58
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       ja        short M00_L26
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       ja        short M00_L30
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CB00B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CB00B48
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D377DC8]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       call      qword ptr [7FFB0CDDDF08]
       mov       ecx,0BD
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE84F28
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D37CA20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D37CA38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L41:
       mov       rcx,rsi
       mov       r11,7FFB0CB00B58
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,265F0801FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L42:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CB00B60
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26606800A60
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CB00B38
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CB00B50
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CB00B50
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D3775E8]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D377D38]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D3775E8]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1669
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CF0F5D0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D377DB0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBBD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M04_L01
       mov       r14d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M04_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D156B08]
       int       3
M04_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M04_L00
M04_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M04_L08
       test      r14d,r14d
       jg        short M04_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M04_L04
M04_L03:
       mov       rcx,rdx
       call      qword ptr [7FFB0CBB5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L04:
       mov       rdx,7FFB0D34CF78
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M04_L09
       mov       rcx,rax
M04_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M04_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBB7048]; System.Array.Copy(System.Array, System.Array, Int32)
M04_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L09:
       mov       rdx,7FFB0D34CF88
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L06
; Total bytes of code 310
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
       je        near ptr M05_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M05_L01
       test      rsi,rsi
       je        short M05_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M05_L00:
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
M05_L01:
       test      rsi,rsi
       je        short M05_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L03
M05_L02:
       mov       rax,2A6859A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
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
M05_L04:
       call      qword ptr [7FFB0D37CA98]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFB0CBB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L41
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CB86850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CCFF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,157D3401FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D34E160]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D34E160]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D34E148]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D34D1B8]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D34F738]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L40
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D376788],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,157D3402AC8
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       call      qword ptr [7FFB0CCFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       jbe       short M00_L26
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       call      qword ptr [7FFB0CCFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       jbe       short M00_L30
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CAD0DC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CAD0DC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D34F150]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB0CAD0DD8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,157D3401FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L39:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CAD0DE0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L40:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L41:
       call      qword ptr [7FFB0CDADED8]
       mov       ecx,0BD
       mov       rdx,7FFB0CFA2518
       call      qword ptr [7FFB0CDA7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE54F28
       call      qword ptr [7FFB0CDA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CB87858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFA2518
       call      qword ptr [7FFB0CDA7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CB87858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D34F840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D34E670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,157D3402AD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CAD0DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CAD0DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CAD0DD0
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D34D2D8]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D34D1B8]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D34D2D8]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1666
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CEDF5A0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D34C5D0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CB8D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M04_L01
       mov       r14d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M04_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D126AD8]
       int       3
M04_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M04_L00
M04_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M04_L08
       test      r14d,r14d
       jg        short M04_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L04
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L04:
       mov       rdx,7FFB0D3E5E18
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M04_L09
       mov       rcx,rax
M04_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M04_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CB87048]; System.Array.Copy(System.Array, System.Array, Int32)
M04_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L09:
       mov       rdx,7FFB0D3A2F88
       call      qword ptr [7FFB0CB8C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L06
; Total bytes of code 309
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
       je        near ptr M05_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M05_L01
       test      rsi,rsi
       je        short M05_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M05_L00:
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
M05_L01:
       test      rsi,rsi
       je        short M05_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L03
M05_L02:
       mov       rax,19868400008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
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
M05_L04:
       call      qword ptr [7FFB0D34EC58]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFB0CB85C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L41
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB0CD2F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,27D73401FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D37E160]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D37E160]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D37E148]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D1E8]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D37F798]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L40
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D3A5870],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,27D89400AD0
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       jbe       short M00_L26
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       jbe       short M00_L30
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CB00DC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CB00DC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D37F180]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB0CB00DD8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,27D73401FB8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L39:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CB00DE0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L40:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L41:
       call      qword ptr [7FFB0CDDDF08]
       mov       ecx,0BD
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE84F28
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D37F870]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D37E6A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27D89400AD8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CB00DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CB00DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CB00DD0
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D37D308]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D37D1E8]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D37D308]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1665
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L04
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L04
       cmp       [r10+10],rcx
       je        short M02_L04
       cmp       [r10+18],rcx
       je        short M02_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L04
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L06
M02_L03:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
M02_L04:
       mov       rax,rdx
       ret
M02_L05:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L00
M02_L06:
       cmp       [r10],rcx
       je        short M02_L04
       jmp       short M02_L02
M02_L07:
       jmp       qword ptr [7FFB0CF0F5D0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       call      qword ptr [7FFB0D37C600]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBBD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M04_L01
       mov       r14d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M04_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D156B08]
       int       3
M04_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M04_L00
M04_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M04_L08
       test      r14d,r14d
       jg        short M04_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M04_L04
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L04:
       mov       rdx,7FFB0D415E28
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M04_L09
       mov       rcx,rax
M04_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M04_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBB7048]; System.Array.Copy(System.Array, System.Array, Int32)
M04_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L09:
       mov       rdx,7FFB0D3D1ED0
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L06
; Total bytes of code 309
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
       je        near ptr M05_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M05_L01
       test      rsi,rsi
       je        short M05_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M05_L00:
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
M05_L01:
       test      rsi,rsi
       je        short M05_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L03
M05_L02:
       mov       rax,2BE083C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
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
M05_L04:
       call      qword ptr [7FFB0D37EC88]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFB0CBB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L41
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,17A6AC01FE8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D2AFE28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D2AFE28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D3AEC10]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D2AE0A0]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D464BA0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L40
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D3FF1F8],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,17A80C00B30
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       ja        short M00_L26
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       ja        short M00_L30
       call      qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CB00FC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CB00FD0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D4645A0]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB0CB00FE0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,17A6AC01FE8
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L39:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CB00FE8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L40:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L41:
       call      qword ptr [7FFB0CDDDF08]
       mov       ecx,0BD
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE84F28
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFD2518
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D2AFE88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D2AFEA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17A80C00B38
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CB00FC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CB00FD8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CB00FD8
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D2AE268]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D2AE0A0]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D2AE268]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1664
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
       je        short M01_L03
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
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L04
       cmp       [r10],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       cmp       [r10+8],rcx
       je        short M02_L00
       jmp       short M02_L03
M02_L02:
       cmp       [r10],rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L03:
       cmp       [r10+10],rcx
       je        short M02_L00
       cmp       [r10+18],rcx
       je        short M02_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L02
       test      r8,r8
       je        short M02_L06
M02_L04:
       cmp       [r10],rcx
       je        short M02_L00
M02_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L06
       cmp       [r10],rcx
       je        short M02_L00
       jmp       short M02_L05
M02_L06:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
       jmp       short M02_L00
M02_L07:
       jmp       qword ptr [7FFB0CF0F5D0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L01
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       call      qword ptr [7FFB0D2AD470]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBBD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
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
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       r14d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M05_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D156B08]
       int       3
M05_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M05_L00
M05_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M05_L08
       test      r14d,r14d
       jg        short M05_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFB0D37C8B8
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M05_L09
       mov       rcx,rax
M05_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M05_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBB7048]; System.Array.Copy(System.Array, System.Array, Int32)
M05_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L09:
       mov       rdx,7FFB0D2C4810
       call      qword ptr [7FFB0CBBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
; Total bytes of code 303
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
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,1BAFF9D0008
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
       call      qword ptr [7FFB0D3AFA20]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FFB0CBB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.ToList()
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       test      rbx,rbx
       je        near ptr M00_L41
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,236FAC02008
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L46
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L13
M00_L00:
       mov       dword ptr [rbp-3C],1
       mov       rbx,[rbx+10]
       mov       rsi,rbx
       test      rbx,rbx
       je        short M00_L03
M00_L01:
       lea       rdi,[rsi+34]
       cmp       byte ptr [rdi],0
       jne       near ptr M00_L15
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFB6C83E120
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       byte ptr [rdi],1
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L01
M00_L03:
       lock or   dword ptr [rsp],0
       test      rbx,rbx
       je        short M00_L06
M00_L04:
       cmp       dword ptr [rbx+2C],0
       jne       near ptr M00_L19
M00_L05:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M00_L04
M00_L06:
       xor       edx,edx
       mov       rbx,[rbp-70]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L43
       mov       edx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       r14,[rbx+10]
       test      r14,r14
       je        short M00_L12
M00_L09:
       mov       r15d,[r14+18]
       mov       r13d,[r14+24]
       sub       r13d,[r14+28]
       lea       r12d,[rdi+r13-1]
       cmp       r12d,edi
       jl        short M00_L11
M00_L10:
       lea       r8d,[r15+1]
       mov       [rbp-4C],r8d
       mov       r8,[r14+8]
       and       r15d,[r14+20]
       cmp       r15d,[r8+8]
       jae       short M00_L18
       mov       edx,r15d
       mov       r8,[r8+rdx*8+10]
       movsxd    rdx,r12d
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r12d
       cmp       r12d,edi
       mov       r15d,[rbp-4C]
       jge       short M00_L10
M00_L11:
       add       edi,r13d
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
M00_L12:
       mov       [rbp-78],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFB0D287108]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFB0D287108]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFB0D28FDB0]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFB0D285C50]
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFB0D454DB0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L49
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jne       near ptr M00_L40
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFB0D43B438],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,236FAC02B40
       mov       r14,[rcx]
M00_L24:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L25
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        near ptr M00_L31
M00_L25:
       mov       r14,[rbp-68]
       cmp       [r14],r14d
       jmp       short M00_L27
M00_L26:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L34
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L27:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdi
       jne       near ptr M00_L32
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L33
       mov       rbx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r8d,[rbx+8]
       jae       near ptr M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
M00_L28:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [rsi+8],r15d
       ja        short M00_L26
       call      qword ptr [7FFB0CD1E400]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L27
M00_L29:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L35
M00_L30:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[rsi+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L31:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       short M00_L29
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       short M00_L33
       mov       rbx,[r14+10]
       cmp       r8d,[rbx+8]
       jae       short M00_L34
       mov       ecx,r8d
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       rsi,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[rsi+8]
       cmp       eax,r15d
       ja        short M00_L30
       call      qword ptr [7FFB0CD1E400]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFB0CAF10E8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFB0CAF10F0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFB0D4547B0]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L47
M00_L36:
       mov       rcx,[rbp-60]
M00_L37:
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFB0CAF1100
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,236FAC02008
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L39:
       movsxd    rdx,r14d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FFB0CAF1108
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L40:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],ebx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L41:
       call      qword ptr [7FFB0CDCDF08]
       mov       ecx,0BD
       mov       rdx,7FFB0CFC2518
       call      qword ptr [7FFB0CDC77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB0CE74F28
       call      qword ptr [7FFB0CDC77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBA7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB0CFC2518
       call      qword ptr [7FFB0CDC77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0CBA7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0D286D78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0D286D90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L37
M00_L43:
       call      M00_L49
       nop
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,236FAC02B48
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFB0CAF10E0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFB0CAF10F8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L48
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L48
       mov       rcx,r14
       mov       r11,7FFB0CAF10F8
       call      qword ptr [r11]
M00_L48:
       nop
       add       rsp,28
       ret
M00_L49:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L54
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L52
M00_L50:
       cmp       byte ptr [rsi+34],0
       je        short M00_L51
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFB0D285E18]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFB0D285C50]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFB6C83E040
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFB0D285E18]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1664
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L04
       cmp       [r10],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       cmp       [r10+8],rcx
       je        short M02_L00
       jmp       short M02_L03
M02_L02:
       cmp       [r10],rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L03:
       cmp       [r10+10],rcx
       je        short M02_L00
       cmp       [r10+18],rcx
       je        short M02_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L02
       test      r8,r8
       je        short M02_L06
M02_L04:
       cmp       [r10],rcx
       je        short M02_L00
M02_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L06
       cmp       [r10],rcx
       je        short M02_L00
       jmp       short M02_L05
M02_L06:
       test      dword ptr [rax],500C0000
       jne       short M02_L07
       xor       edx,edx
       jmp       short M02_L00
M02_L07:
       jmp       qword ptr [7FFB0CEFF5D0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L01
       cmp       rdx,[r8]
       je        short M03_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6C8340D0
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FFB0D284C78]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0CBAD938]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M04_L01
       mov       r14d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M04_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D146B08]
       int       3
M04_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M04_L00
M04_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M04_L08
       test      r14d,r14d
       jg        short M04_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M04_L04
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L04:
       mov       rdx,7FFB0D2B7F80
       call      qword ptr [7FFB0CBAC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+50]
       test      rax,rax
       je        short M04_L09
       mov       rcx,rax
M04_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M04_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CBA6FA0]; System.Array.Copy(System.Array, System.Array, Int32)
M04_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L09:
       mov       rdx,7FFB0D26DBD0
       call      qword ptr [7FFB0CBAC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L06
; Total bytes of code 303
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
       je        near ptr M05_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M05_L00
       test      rbx,rbx
       je        near ptr M05_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M05_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0CBA5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L00:
       test      rbx,rbx
       je        short M05_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L02
M05_L01:
       mov       rax,2778FB80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       call      qword ptr [7FFB0D3BF480]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFB0CBA5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

