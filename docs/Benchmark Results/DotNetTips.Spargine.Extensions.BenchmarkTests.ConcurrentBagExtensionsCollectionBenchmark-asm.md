## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,23BF74027A8
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E62FB28]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF92DF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF92DE51058
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
       call      qword ptr [7FF92E49F018]
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       mov       r11,7FF92DE51050
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
       call      qword ptr [7FF92E075020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E707CF0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF92E12C2D0]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FF92E7972E8]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF92E496A48]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E496A48]
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
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF92E70DA70]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E70DA70]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FF92E70DA88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,27C8C520E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FF92E62E6B8]
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
       call      qword ptr [7FF92E41D9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E62FC48]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L73
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L70
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF92E62FD80]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FF92E797F48]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E62FC90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E62FDB0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FF92E62FD80]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FF92E797F48]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E62FC90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E62FDB0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FF92E795CC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E797360]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FF92DE51068
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FF92DE51070
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FF92E795CC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E797360]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E7970A8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FF92E7957E8]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF92E797378]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF92E25C3F0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L74
M00_L69:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E73E990
       cmp       [rcx],ecx
       call      qword ptr [7FF92E707960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       test      byte ptr [7FF92E73E790],1
       je        short M00_L72
M00_L71:
       mov       rcx,23BF7402AA0
       mov       r15,[rcx]
       jmp       near ptr M00_L41
M00_L72:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L71
M00_L73:
       mov       rcx,rdi
       mov       r11,7FF92DE51060
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L74:
       mov       rcx,r15
       mov       r11,7FF92DE51078
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L75
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E62FC48]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FF92DE51078
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,38
       ret
; Total bytes of code 2789
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
       call      qword ptr [7FF92E62FB70]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rcx,7FF98B530B00
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
       call      qword ptr [7FF92E49EE80]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E256598]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF92E49EE98]
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
       mov       rcx,7FF92E742C88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E742C80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E742C84
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       jmp       qword ptr [7FF92DF066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
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
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
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
       call      qword ptr [7FF98C1A5298]
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
       call      qword ptr [7FF98C1A5618]
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
       call      qword ptr [7FF98C1A71F0]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M07_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M07_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M07_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L04
M07_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L04
M07_L16:
       cmp       byte ptr [rsp+78],0
       je        short M07_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rbx,rbx
       je        near ptr M08_L10
       test      rsi,rsi
       je        near ptr M08_L09
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M08_L08
       cmp       dword ptr [rcx+4],18
       jne       near ptr M08_L07
       test      r14d,r14d
       jl        near ptr M08_L06
       test      edi,edi
       jl        near ptr M08_L05
       test      ebp,ebp
       jl        near ptr M08_L04
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L03
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M08_L02
       movzx     eax,word ptr [rcx]
       mov       r14d,r14d
       imul      r14,rax
       mov       edx,edi
       imul      rdx,rax
       lea       rbx,[rbx+rdx+10]
       mov       edx,ebp
       imul      rax,rdx
       lea       rdi,[rsi+rax+10]
       test      dword ptr [rcx],1000000
       je        short M08_L01
       mov       rcx,7FF92E7C3790
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       jbe       short M08_L00
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF92E49F018]
M08_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       je        near ptr M08_L11
       jmp       near ptr M08_L13
M08_L01:
       mov       rcx,7FF92E7C37B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L11
M08_L02:
       mov       rcx,7FF92E7C3794
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L03:
       mov       rcx,7FF92E7C3798
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L04:
       mov       rcx,7FF92E7C379C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L05:
       mov       rcx,7FF92E7C37A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L06:
       mov       rcx,7FF92E7C37A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L07:
       mov       rcx,7FF92E7C37A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L08:
       mov       rcx,7FF92E7C37AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L10
M08_L09:
       mov       rcx,7FF92E7C37B0
       call      CORINFO_HELP_COUNTPROFILE32
M08_L10:
       mov       rcx,7FF92E7C37B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FF92E70DA88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M08_L11:
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M08_L14
M08_L12:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L11
M08_L14:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L12
; Total bytes of code 487
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
       call      qword ptr [7FF92E7971E0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L01
M09_L00:
       dec       ebx
       mov       [rcx+18],ebx
M09_L01:
       add       rsp,20
       pop       rbx
       ret
M09_L02:
       call      qword ptr [7FF92E7971C8]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E62FCA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E7F28A0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FF92E7F0FC0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E7F0638
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E49E658]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E49EAC0]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FF92E7973A8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E49E670]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E49E658]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E49E670]
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
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M11_L01
M11_L00:
       mov       rax,7FF98DB57C00
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
       jmp       qword ptr [7FF92E797348]
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
       jmp       qword ptr [7FF92E62FCA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M12_L02:
       mov       rdx,7FF92E7F0638
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jo        near ptr M13_L12
       mov       [rcx+24],eax
       jmp       near ptr M13_L14
M13_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E075050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF92DF05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M13_L00
M13_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92E49EAC0]
       jmp       near ptr M13_L03
M13_L11:
       mov       rcx,rdx
       mov       rdx,7FF92E7F0FC0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E41D9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E41D9E0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M13_L05
M13_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M13_L16
M13_L15:
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
M13_L16:
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M13_L15
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FF92E49E670]
       jmp       short M13_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M13_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M13_L18
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF92E49E670]
M13_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 704
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
       call      qword ptr [7FF98C1ACCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,273FBC007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E61F138]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L26
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
       jge       near ptr M00_L05
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
       jl        near ptr M00_L27
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        near ptr M00_L05
       test      edx,edx
       jle       near ptr M00_L39
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       test      r13d,r13d
       jle       near ptr M00_L04
       mov       rcx,[rbp-0C0]
       mov       rdx,rcx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L32
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L31
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L30
       cmp       r13d,[rax+8]
       ja        near ptr M00_L29
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L34
       mov       rax,[rbp-78]
       cmp       r8,4000
       ja        near ptr M00_L33
       mov       rcx,r10
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       near ptr M00_L28
       mov       rax,[rbp-78]
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
       call      qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M00_L08
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FF92DE60DD8
       call      qword ptr [r11]
       jmp       short M00_L09
M00_L07:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M00_L03
M00_L08:
       mov       r9d,r13d
       mov       eax,r9d
M00_L09:
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
       je        near ptr M00_L12
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       mov       [rbp-6C],edx
       cmp       edx,r11d
       jbe       near ptr M00_L13
M00_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L11
       mov       [rbp-88],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FF92DE60DD0
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L25
M00_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-6C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L10
       jmp       short M00_L13
M00_L12:
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L14
       mov       [rbp-6C],edx
M00_L13:
       cmp       dword ptr [r15+40],0
       jle       short M00_L16
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
       jmp       near ptr M00_L18
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L25
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
       mov       [rbp-6C],edx
       jmp       short M00_L13
M00_L16:
       mov       r13d,[r15+38]
       cmp       [rbp-6C],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FF92E085020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E707390]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       edx,[rbp-44]
       mov       r8d,edx
       imul      r8,[r15+30]
       shr       r8,20
       inc       r8
       mov       r9d,[rcx+8]
       mov       eax,r9d
       imul      r8,rax
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M00_L36
       mov       r8d,r8d
       lea       r9,[rcx+r8*4+10]
       mov       rcx,r9
       mov       [rbp-98],rcx
       mov       eax,edx
M00_L17:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L18:
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
       jg        short M00_L20
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L19:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L46
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L26
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L22
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L23
       mov       [rbp-3C],r8d
M00_L21:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FF92E70D8C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L22:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L19
M00_L23:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L44
       jmp       near ptr M00_L40
M00_L24:
       call      qword ptr [7FF92E137A20]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FF92E7B4B28]
       int       3
M00_L26:
       call      qword ptr [7FF92E61DCE0]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L28:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L29:
       jmp       short M00_L37
M00_L30:
       jmp       short M00_L37
M00_L31:
       jmp       short M00_L37
M00_L32:
       jmp       short M00_L37
M00_L33:
       mov       rcx,r10
       call      qword ptr [7FF92E49E580]
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF92E70D8A8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E70D8A8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FF92E70D8C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,2B47AB60E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L40:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L43
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L42
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L41
       movzx     ecx,word ptr [r12]
       mov       eax,eax
       imul      rax,rcx
       add       r13,10
       mov       edx,edx
       imul      rdx,rcx
       add       rdx,r13
       mov       r10d,r9d
       imul      rcx,r10
       add       rcx,r13
       test      dword ptr [r12],1000000
       je        short M00_L45
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L41:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L45:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F270]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L62
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L66
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L56
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L56
       jmp       short M00_L50
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F3A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L49:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F3D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L50:
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F288]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L49
       jmp       short M00_L48
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F3A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F3D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L57
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F288]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L52
       jmp       short M00_L51
M00_L56:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L53
M00_L57:
       mov       rcx,r15
       mov       r11,7FF92DE60DE8
       call      qword ptr [r11]
       jmp       short M00_L54
M00_L58:
       mov       rcx,r15
       mov       r11,7FF92DE60DF0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L55
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E7B4918]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L67
M00_L62:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E735008
       cmp       [rcx],ecx
       call      qword ptr [7FF92E7070D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L63:
       test      byte ptr [7FF92E734E08],1
       je        short M00_L65
M00_L64:
       mov       rcx,273E5C02010
       mov       r15,[rcx]
       jmp       near ptr M00_L47
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L64
M00_L66:
       mov       rcx,rdi
       mov       r11,7FF92DE60DE0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L67:
       mov       rcx,r15
       mov       r11,7FF92DE60DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L62
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F270]; System.Threading.Lock.Exit(ThreadId)
M00_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       je        short M00_L69
       mov       rcx,r15
       mov       r11,7FF92DE60DF8
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 2503
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
       call      qword ptr [7FF92E61F180]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E78A724
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E78A720
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E70F588]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E285CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E70F5A0]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E78A72C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E78A730
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E78A728
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E78A734
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7C3810
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7C3808
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7C380C
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       je        near ptr M05_L07
       test      rsi,rsi
       je        near ptr M05_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M05_L00
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
       jne       near ptr M05_L08
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L02:
       sub       ebp,eax
       js        near ptr M05_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M05_L16
M05_L03:
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
       je        near ptr M05_L15
       cmp       r8,4000
       ja        near ptr M05_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L12
M05_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L13
M05_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M05_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L04
M05_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L05
M05_L14:
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
M05_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L04
M05_L16:
       cmp       byte ptr [rsp+78],0
       je        short M05_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L17:
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
       jmp       qword ptr [7FF92DF166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M08_L02
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M08_L01
M08_L00:
       add       rsp,28
       ret
M08_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L00
M08_L02:
       add       rsp,28
       jmp       qword ptr [7FF92E49E580]
; Total bytes of code 49
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
       call      qword ptr [7FF92E7B4B10]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L01
M09_L00:
       dec       ebx
       mov       [rcx+18],ebx
M09_L01:
       add       rsp,20
       pop       rbx
       ret
M09_L02:
       call      qword ptr [7FF92E7B4AF8]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E61F2D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E79DE50
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FF92E79C198
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E79C018
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E70E250]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E70F858]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FF92E7B4C30]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E70EC70]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E70E250]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E70EC70]
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
       mov       [rbp-3C],edx
       lea       rdx,[rcx+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       edi,[rcx+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M11_L08
M11_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M11_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M11_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M11_L02
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
       jo        near ptr M11_L11
       mov       [rcx+24],eax
       jmp       near ptr M11_L14
M11_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FF98DBB2D60
       test      eax,eax
       je        near ptr M11_L09
M11_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M11_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M11_L10
M11_L04:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M11_L12
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FF92E085050]; System.Array.Copy(System.Array, System.Array, Int32)
M11_L05:
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
M11_L06:
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
       je        near ptr M11_L13
M11_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M11_L01
M11_L08:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L09:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92E70F858]
       jmp       near ptr M11_L03
M11_L10:
       mov       rcx,rdx
       mov       rdx,7FF92E79C198
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L04
M11_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L12:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M11_L05
M11_L13:
       lock inc  qword ptr [rsi]
       jmp       near ptr M11_L07
M11_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M11_L16
M11_L15:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L16:
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M11_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M11_L17:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M11_L18
       mov       rcx,rdi
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 682
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
       je        short M13_L01
M13_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M13_L02
       test      ecx,ecx
       jl        short M13_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M13_L02
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M13_L02
       cmp       byte ptr [rbx+1C],0
       je        short M13_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M13_L01:
       mov       rdx,7FF92E79C018
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF92E61F2A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,207324027A8
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E60F120]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF92E4861A8]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L26
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
       jge       near ptr M00_L05
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
       jl        near ptr M00_L27
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        near ptr M00_L05
       test      edx,edx
       jle       near ptr M00_L39
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       test      r13d,r13d
       jle       near ptr M00_L04
       mov       rcx,[rbp-0C0]
       mov       rdx,rcx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L32
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L31
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L30
       cmp       r13d,[rax+8]
       ja        near ptr M00_L29
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L34
       mov       rax,[rbp-78]
       cmp       r8,4000
       ja        near ptr M00_L33
       mov       rcx,r10
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       near ptr M00_L28
       mov       rax,[rbp-78]
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
       call      qword ptr [7FF92DF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M00_L08
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FF92DE50DD0
       call      qword ptr [r11]
       jmp       short M00_L09
M00_L07:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M00_L03
M00_L08:
       mov       r9d,r13d
       mov       eax,r9d
M00_L09:
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
       je        near ptr M00_L12
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       mov       [rbp-6C],edx
       cmp       edx,r11d
       jbe       near ptr M00_L13
M00_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L11
       mov       [rbp-88],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FF92DE50DC8
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L25
M00_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-6C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L10
       jmp       short M00_L13
M00_L12:
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L14
       mov       [rbp-6C],edx
M00_L13:
       cmp       dword ptr [r15+40],0
       jle       short M00_L16
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
       jmp       near ptr M00_L18
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L25
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
       mov       [rbp-6C],edx
       jmp       short M00_L13
M00_L16:
       mov       r13d,[r15+38]
       cmp       [rbp-6C],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FF92E075020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E6F7378]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       edx,[rbp-44]
       mov       r8d,edx
       imul      r8,[r15+30]
       shr       r8,20
       inc       r8
       mov       r9d,[rcx+8]
       mov       eax,r9d
       imul      r8,rax
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M00_L36
       mov       r8d,r8d
       lea       r9,[rcx+r8*4+10]
       mov       rcx,r9
       mov       [rbp-98],rcx
       mov       eax,edx
M00_L17:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L18:
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
       jg        short M00_L20
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L19:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L46
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L26
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L22
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L23
       mov       [rbp-3C],r8d
M00_L21:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FF92E6FD8A8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L22:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L19
M00_L23:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L44
       jmp       near ptr M00_L40
M00_L24:
       call      qword ptr [7FF92E127A20]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FF92E7A4AF8]
       int       3
M00_L26:
       call      qword ptr [7FF92E60DCB0]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4861A8]
       int       3
M00_L28:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L29:
       jmp       short M00_L37
M00_L30:
       jmp       short M00_L37
M00_L31:
       jmp       short M00_L37
M00_L32:
       jmp       short M00_L37
M00_L33:
       mov       rcx,r10
       call      qword ptr [7FF92E48E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF92E6FD890]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E6FD890]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FF92E6FD8A8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,247C7590E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L40:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L43
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L42
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L41
       movzx     ecx,word ptr [r12]
       mov       eax,eax
       imul      rax,rcx
       add       r13,10
       mov       edx,edx
       imul      rdx,rcx
       add       rdx,r13
       mov       r10d,r9d
       imul      rcx,r10
       add       rcx,r13
       test      dword ptr [r12],1000000
       je        short M00_L45
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L41:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L45:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E60F258]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L62
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L66
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L56
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L56
       jmp       short M00_L50
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E60F390]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L49:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E60F3C0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L50:
       mov       rcx,r15
       call      qword ptr [7FF92E1BF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E60F270]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L49
       jmp       short M00_L48
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FF92E60F390]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E60F3C0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L57
       mov       rcx,r15
       call      qword ptr [7FF92E1BF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E60F270]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L52
       jmp       short M00_L51
M00_L56:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L53
M00_L57:
       mov       rcx,r15
       mov       r11,7FF92DE50DE0
       call      qword ptr [r11]
       jmp       short M00_L54
M00_L58:
       mov       rcx,r15
       mov       r11,7FF92DE50DE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L55
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E7A4900]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L67
M00_L62:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E725118
       cmp       [rcx],ecx
       call      qword ptr [7FF92E6F70C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L63:
       test      byte ptr [7FF92E724F18],1
       je        short M00_L65
M00_L64:
       mov       rcx,20732402010
       mov       r15,[rcx]
       jmp       near ptr M00_L47
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L64
M00_L66:
       mov       rcx,rdi
       mov       r11,7FF92DE50DD8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L67:
       mov       rcx,r15
       mov       r11,7FF92DE50DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L62
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E60F258]; System.Threading.Lock.Exit(ThreadId)
M00_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       je        short M00_L69
       mov       rcx,r15
       mov       r11,7FF92DE50DF0
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 2503
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
       call      qword ptr [7FF92E60F168]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E77A87C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E77A878
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E6FF570]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E275CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E6FF588]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E77A884
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E77A888
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E77A880
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E77A88C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7B3770
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF05A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7B3768
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7B376C
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       je        near ptr M05_L07
       test      rsi,rsi
       je        near ptr M05_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M05_L00
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
       jne       near ptr M05_L08
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L02:
       sub       ebp,eax
       js        near ptr M05_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M05_L16
M05_L03:
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
       je        near ptr M05_L15
       cmp       r8,4000
       ja        near ptr M05_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L12
M05_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L13
M05_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M05_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L04
M05_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L05
M05_L14:
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
M05_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L04
M05_L16:
       cmp       byte ptr [rsp+78],0
       je        short M05_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L17:
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M06_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M06_L06
M06_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L04
M06_L01:
       cmp       rdi,4000
       ja        short M06_L00
M06_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L05
M06_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L04:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L03
M06_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M06_L07
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
M06_L07:
       cmp       rdi,4000
       ja        short M06_L06
       jmp       short M06_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M07_L05
M07_L00:
       test      r8b,4
       je        short M07_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L05
M07_L01:
       test      r8,r8
       je        short M07_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M07_L05
M07_L02:
       cmp       r8,40
       ja        short M07_L06
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M07_L10
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M07_L05:
       vzeroupper
       ret
M07_L06:
       cmp       r8,800
       ja        near ptr M07_L11
       cmp       r8,100
       jae       short M07_L09
M07_L07:
       mov       r9,r8
       shr       r9,6
M07_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L08
       and       r8,3F
       cmp       r8,10
       ja        short M07_L03
       jmp       short M07_L04
M07_L09:
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
       jmp       short M07_L07
M07_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M07_L04
M07_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF92DF066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M07_L12:
       cmp       rcx,rdx
       jne       short M07_L11
       cmp       [rdx],dl
       jmp       near ptr M07_L05
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
       je        short M08_L00
       cmp       edx,eax
       jae       short M08_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF92E48E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
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
       call      qword ptr [7FF92E7A4AE0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E7A4AC8]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E60F2B8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E78DBE0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E78C138
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E78BFB8
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E6FE238]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E6FF8B8]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E7A4C00]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E6FEC58]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE238]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E6FEC58]
M11_L18:
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
       je        near ptr M12_L07
M12_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M12_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M12_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M12_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M12_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M12_L09
       mov       [rcx+24],eax
       jmp       near ptr M12_L12
M12_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DF05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M12_L05
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M12_L08
M12_L03:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M12_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FF92E075050]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L04:
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
M12_L05:
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
       je        near ptr M12_L11
M12_L06:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M12_L01
M12_L07:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF92DF05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M12_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L00
M12_L08:
       mov       rcx,rdx
       mov       rdx,7FF92E78C138
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L03
M12_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L10:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FF92E41D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E41D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L04
M12_L11:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L06
M12_L12:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M12_L14
M12_L13:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L14:
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M12_L13
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L15
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
M12_L15:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L16
       mov       rcx,rdi
       call      qword ptr [7FF92DF06820]; System.Threading.Monitor.Exit(System.Object)
M12_L16:
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
       jae       short M13_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M13_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
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
       mov       rdx,7FF92E78BFB8
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L00
M14_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF92E60F288]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,204350007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E5FF210]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF92E4761A8]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L26
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
       jge       near ptr M00_L05
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
       jl        near ptr M00_L27
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        near ptr M00_L05
       test      edx,edx
       jle       near ptr M00_L39
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       test      r13d,r13d
       jle       near ptr M00_L04
       mov       rcx,[rbp-0C0]
       mov       rdx,rcx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L32
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L31
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L30
       cmp       r13d,[rax+8]
       ja        near ptr M00_L29
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L34
       mov       rax,[rbp-78]
       cmp       r8,4000
       ja        near ptr M00_L33
       mov       rcx,r10
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       near ptr M00_L28
       mov       rax,[rbp-78]
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
       call      qword ptr [7FF92DEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M00_L08
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FF92DE40DD0
       call      qword ptr [r11]
       jmp       short M00_L09
M00_L07:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M00_L03
M00_L08:
       mov       r9d,r13d
       mov       eax,r9d
M00_L09:
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
       je        near ptr M00_L12
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       mov       [rbp-6C],edx
       cmp       edx,r11d
       jbe       near ptr M00_L13
M00_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L11
       mov       [rbp-88],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FF92DE40DC8
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L25
M00_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-6C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L10
       jmp       short M00_L13
M00_L12:
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L14
       mov       [rbp-6C],edx
M00_L13:
       cmp       dword ptr [r15+40],0
       jle       short M00_L16
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
       jmp       near ptr M00_L18
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L25
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
       mov       [rbp-6C],edx
       jmp       short M00_L13
M00_L16:
       mov       r13d,[r15+38]
       cmp       [rbp-6C],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FF92E065020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E6E7330]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       edx,[rbp-44]
       mov       r8d,edx
       imul      r8,[r15+30]
       shr       r8,20
       inc       r8
       mov       r9d,[rcx+8]
       mov       eax,r9d
       imul      r8,rax
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M00_L36
       mov       r8d,r8d
       lea       r9,[rcx+r8*4+10]
       mov       rcx,r9
       mov       [rbp-98],rcx
       mov       eax,edx
M00_L17:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L18:
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
       jg        short M00_L20
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L19:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L46
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L26
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L22
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L23
       mov       [rbp-3C],r8d
M00_L21:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FF92E6ED8C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L22:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L19
M00_L23:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L44
       jmp       near ptr M00_L40
M00_L24:
       call      qword ptr [7FF92E117A20]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FF92E794B40]
       int       3
M00_L26:
       call      qword ptr [7FF92E5FDC20]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4761A8]
       int       3
M00_L28:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L29:
       jmp       short M00_L37
M00_L30:
       jmp       short M00_L37
M00_L31:
       jmp       short M00_L37
M00_L32:
       jmp       short M00_L37
M00_L33:
       mov       rcx,r10
       call      qword ptr [7FF92E47EA18]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF92E6ED8A8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E6ED8A8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FF92E6ED8C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,244B3FF0E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L40:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L43
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L42
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L41
       movzx     ecx,word ptr [r12]
       mov       eax,eax
       imul      rax,rcx
       add       r13,10
       mov       edx,edx
       imul      rdx,rcx
       add       rdx,r13
       mov       r10d,r9d
       imul      rcx,r10
       add       rcx,r13
       test      dword ptr [r12],1000000
       je        short M00_L45
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DEF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L41:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L45:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E5FF348]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L62
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L66
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L56
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L56
       jmp       short M00_L50
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E5FF480]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L49:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E5FF4B0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L50:
       mov       rcx,r15
       call      qword ptr [7FF92E1AF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E5FF360]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L49
       jmp       short M00_L48
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FF92E5FF480]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E5FF4B0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L57
       mov       rcx,r15
       call      qword ptr [7FF92E1AF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E5FF360]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L52
       jmp       short M00_L51
M00_L56:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L53
M00_L57:
       mov       rcx,r15
       mov       r11,7FF92DE40DE0
       call      qword ptr [r11]
       jmp       short M00_L54
M00_L58:
       mov       rcx,r15
       mov       r11,7FF92DE40DE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L55
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E794930]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L67
M00_L62:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E715080
       cmp       [rcx],ecx
       call      qword ptr [7FF92E6E7078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L63:
       test      byte ptr [7FF92E714E80],1
       je        short M00_L65
M00_L64:
       mov       rcx,2041F002010
       mov       r15,[rcx]
       jmp       near ptr M00_L47
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L64
M00_L66:
       mov       rcx,rdi
       mov       r11,7FF92DE40DD8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L67:
       mov       rcx,r15
       mov       r11,7FF92DE40DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L62
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E5FF348]; System.Threading.Lock.Exit(ThreadId)
M00_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       je        short M00_L69
       mov       rcx,r15
       mov       r11,7FF92DE40DF0
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 2503
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
       call      qword ptr [7FF92E5FF258]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E76B734
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E76B730
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E6EF588]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E265CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E6EF5A0]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E76B73C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E76B740
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E76B738
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E76B744
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7A4FB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7A4FB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7A4FB4
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       je        near ptr M05_L07
       test      rsi,rsi
       je        near ptr M05_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M05_L00
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
       jne       near ptr M05_L08
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L02:
       sub       ebp,eax
       js        near ptr M05_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M05_L16
M05_L03:
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
       je        near ptr M05_L15
       cmp       r8,4000
       ja        near ptr M05_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L12
M05_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L13
M05_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M05_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L04
M05_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L05
M05_L14:
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
M05_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L04
M05_L16:
       cmp       byte ptr [rsp+78],0
       je        short M05_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L17:
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M06_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M06_L06
M06_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L04
M06_L01:
       cmp       rdi,4000
       ja        short M06_L00
M06_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L05
M06_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L04:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L03
M06_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M06_L07
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
M06_L07:
       cmp       rdi,4000
       ja        short M06_L06
       jmp       short M06_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M07_L05
M07_L00:
       test      r8b,4
       je        short M07_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L05
M07_L01:
       test      r8,r8
       je        short M07_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M07_L05
M07_L02:
       cmp       r8,40
       ja        short M07_L06
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L09
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M07_L05:
       vzeroupper
       ret
M07_L06:
       cmp       r8,800
       ja        short M07_L10
       cmp       r8,100
       jae       short M07_L11
M07_L07:
       mov       r9,r8
       shr       r9,6
M07_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L08
       and       r8,3F
       cmp       r8,10
       ja        short M07_L03
       jmp       short M07_L04
M07_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L04
M07_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF92DEF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M07_L11:
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
       jmp       near ptr M07_L07
M07_L12:
       cmp       rcx,rdx
       jne       short M07_L10
       cmp       [rdx],dl
       jmp       near ptr M07_L05
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
       je        short M08_L00
       cmp       edx,eax
       jae       short M08_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF92E47EA18]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
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
       call      qword ptr [7FF92E794B28]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E794B10]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E5FF3A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E77DAF8
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E77BE40
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E77BCC0
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E6EE250]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E6EF858]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E794C48]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E6EEC70]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E6EE250]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E6EEC70]
M11_L18:
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
       je        near ptr M12_L07
M12_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M12_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M12_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M12_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M12_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M12_L10
       mov       [rcx+24],eax
       jmp       near ptr M12_L13
M12_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DEF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M12_L05
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M12_L09
       jmp       near ptr M12_L08
M12_L03:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M12_L11
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FF92E065050]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L04:
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
M12_L05:
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
       je        near ptr M12_L12
M12_L06:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M12_L01
M12_L07:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF92DEF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M12_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L00
M12_L08:
       jmp       near ptr M12_L03
M12_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E77BE40
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L03
M12_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L11:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FF92E40D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E40D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L04
M12_L12:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L06
M12_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M12_L15
M12_L14:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L15:
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M12_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
M12_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L17
       mov       rcx,rdi
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
M12_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 671
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M13_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M13_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
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
       mov       ecx,ecx
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
       mov       rdx,7FF92E77BCC0
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L00
M14_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF92E5FF378]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1A5F84007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E61F258]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L26
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
       jge       near ptr M00_L05
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
       jl        near ptr M00_L27
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        near ptr M00_L05
       test      edx,edx
       jle       near ptr M00_L39
       mov       [rbp-3C],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       test      r13d,r13d
       jle       near ptr M00_L04
       mov       rcx,[rbp-0C0]
       mov       rdx,rcx
       mov       [rbp-80],rdx
       test      rdx,rdx
       je        near ptr M00_L35
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L32
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L31
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L30
       cmp       r13d,[rax+8]
       ja        near ptr M00_L29
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L34
       mov       rax,[rbp-78]
       cmp       r8,4000
       ja        near ptr M00_L33
       mov       rcx,r10
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       near ptr M00_L28
       mov       rax,[rbp-78]
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
       call      qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M00_L08
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FF92DE60E18
       call      qword ptr [r11]
       jmp       short M00_L09
M00_L07:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M00_L03
M00_L08:
       mov       r9d,r13d
       mov       eax,r9d
M00_L09:
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
       je        near ptr M00_L12
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       mov       [rbp-6C],edx
       cmp       edx,r11d
       jbe       near ptr M00_L13
M00_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-68],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L11
       mov       [rbp-88],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FF92DE60E10
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L25
M00_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-6C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L10
       jmp       short M00_L13
M00_L12:
       mov       rcx,[rbp-88]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L14
       mov       [rbp-6C],edx
M00_L13:
       cmp       dword ptr [r15+40],0
       jle       short M00_L16
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
       jmp       near ptr M00_L18
M00_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L15
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L25
M00_L15:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L24
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L14
       mov       [rbp-6C],edx
       jmp       short M00_L13
M00_L16:
       mov       r13d,[r15+38]
       cmp       [rbp-6C],r13d
       jne       short M00_L17
       mov       ecx,[r15+38]
       call      qword ptr [7FF92E085020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E707378]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       edx,[rbp-44]
       mov       r8d,edx
       imul      r8,[r15+30]
       shr       r8,20
       inc       r8
       mov       r9d,[rcx+8]
       mov       eax,r9d
       imul      r8,rax
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M00_L36
       mov       r8d,r8d
       lea       r9,[rcx+r8*4+10]
       mov       rcx,r9
       mov       [rbp-98],rcx
       mov       eax,edx
M00_L17:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L18:
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
       jg        short M00_L20
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L19:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L46
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L26
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L22
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L23
       mov       [rbp-3C],r8d
M00_L21:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FF92E70D9B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L22:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L19
M00_L23:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L44
       jmp       near ptr M00_L40
M00_L24:
       call      qword ptr [7FF92E137A20]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FF92E7B4BA0]
       int       3
M00_L26:
       call      qword ptr [7FF92E61DCB0]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L28:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L29:
       jmp       short M00_L37
M00_L30:
       jmp       short M00_L37
M00_L31:
       jmp       short M00_L37
M00_L32:
       jmp       short M00_L37
M00_L33:
       mov       rcx,r10
       call      qword ptr [7FF92E49E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF92E70D998]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E70D998]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FF92E70D9B0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,1E677380E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L40:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L43
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L42
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L41
       movzx     ecx,word ptr [r12]
       mov       eax,eax
       imul      rax,rcx
       add       r13,10
       mov       edx,edx
       imul      rdx,rcx
       add       rdx,r13
       mov       r10d,r9d
       imul      rcx,r10
       add       rcx,r13
       test      dword ptr [r12],1000000
       je        short M00_L45
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L41:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L21
M00_L45:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F390]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L62
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L66
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L56
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L56
       jmp       short M00_L50
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F4C8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L49:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F4F8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L50:
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L61
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F3A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L49
       jmp       short M00_L48
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F4C8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F4F8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L57
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L59
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L60
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F3A8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L52
       jmp       short M00_L51
M00_L56:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L53
M00_L57:
       mov       rcx,r15
       mov       r11,7FF92DE60E28
       call      qword ptr [r11]
       jmp       short M00_L54
M00_L58:
       mov       rcx,r15
       mov       r11,7FF92DE60E30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L55
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E707498]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L67
M00_L62:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E734AE8
       cmp       [rcx],ecx
       call      qword ptr [7FF92E706FE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L63:
       test      byte ptr [7FF92E7348E8],1
       je        short M00_L65
M00_L64:
       mov       rcx,1A5E2401FE0
       mov       r15,[rcx]
       jmp       near ptr M00_L47
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L64
M00_L66:
       mov       rcx,rdi
       mov       r11,7FF92DE60E20
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L67:
       mov       rcx,r15
       mov       r11,7FF92DE60E38
       call      qword ptr [r11]
       jmp       near ptr M00_L62
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F390]; System.Threading.Lock.Exit(ThreadId)
M00_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       je        short M00_L69
       mov       rcx,r15
       mov       r11,7FF92DE60E38
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 2503
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
       call      qword ptr [7FF92E61F2A0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E78B08C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E78B088
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E70F6C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E285CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E70F6D8]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E78B094
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E78B098
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E78B090
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E78B09C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7C3F88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7C3F80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7C3F84
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       je        near ptr M05_L07
       test      rsi,rsi
       je        near ptr M05_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M05_L00
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
       jne       near ptr M05_L08
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M05_L02:
       sub       ebp,eax
       js        near ptr M05_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M05_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M05_L16
M05_L03:
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
       je        near ptr M05_L15
       cmp       r8,4000
       ja        near ptr M05_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L12
M05_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M05_L13
M05_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M05_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M05_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L04
M05_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L05
M05_L14:
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
M05_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L04
M05_L16:
       cmp       byte ptr [rsp+78],0
       je        short M05_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M05_L17:
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M06_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M06_L06
M06_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L04
M06_L01:
       cmp       rdi,4000
       ja        short M06_L00
M06_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L05
M06_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L04:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L03
M06_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M06_L07
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
M06_L07:
       cmp       rdi,4000
       ja        short M06_L06
       jmp       short M06_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M07_L05
M07_L00:
       test      r8b,4
       je        short M07_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L05
M07_L01:
       test      r8,r8
       je        short M07_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M07_L05
M07_L02:
       cmp       r8,40
       ja        short M07_L06
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L09
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M07_L05:
       vzeroupper
       ret
M07_L06:
       cmp       r8,800
       ja        short M07_L10
       cmp       r8,100
       jae       short M07_L11
M07_L07:
       mov       r9,r8
       shr       r9,6
M07_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L08
       and       r8,3F
       cmp       r8,10
       ja        short M07_L03
       jmp       short M07_L04
M07_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L04
M07_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF92DF166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M07_L11:
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
       jmp       near ptr M07_L07
M07_L12:
       cmp       rcx,rdx
       jne       short M07_L10
       cmp       [rdx],dl
       jmp       near ptr M07_L05
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
       je        short M08_L00
       cmp       edx,eax
       jae       short M08_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF92E49E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
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
       call      qword ptr [7FF92E7B4B88]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E7B4B70]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E61F3F0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E71D688
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E71D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E71D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E707450]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E707468]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E7B4C90]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E707480]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E707450]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E707480]
M11_L18:
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
       je        near ptr M12_L05
M12_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M12_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M12_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M12_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M12_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M12_L09
       mov       [rcx+24],eax
       jmp       near ptr M12_L13
M12_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       near ptr M12_L06
M12_L03:
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
       je        near ptr M12_L12
M12_L04:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M12_L01
M12_L05:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M12_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L00
M12_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M12_L07
       jmp       short M12_L08
M12_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E71D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M12_L08:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M12_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FF92E085050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M12_L11
M12_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L10:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M12_L11:
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
       jmp       near ptr M12_L03
M12_L12:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L04
M12_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M12_L15
M12_L14:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L15:
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M12_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M12_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L17
       mov       rcx,rdi
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M12_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 649
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M13_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M13_L00:
       mov       eax,[rcx+0C]
       mov       [rcx+8],eax
       xor       eax,eax
       ret
; Total bytes of code 28
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
       mov       rdx,7FF92E71D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L00
M14_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FF92E61F3C0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,23F744007B0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E61F258]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       call      qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF92DE60DF0
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
       mov       r11,7FF92DE60DE8
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
       call      qword ptr [7FF92E085020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E707378]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF92E137A20]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FF92E7B4B88]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4961A8]
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
       call      qword ptr [7FF92E49E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF92E70D9F8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E70D9F8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FF92E70DA10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,27FF3680E50
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FF92E61DC80]
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
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F390]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L68
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L53
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L53
       jmp       short M00_L46
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F4C8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L45
M00_L42:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E7B4DB0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L58
       xor       r12d,r12d
M00_L43:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E61F3D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L44:
       test      rcx,rcx
       je        short M00_L41
M00_L45:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F4F8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L46:
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L67
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L57
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L57
M00_L47:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L42
       test      eax,eax
       jl        near ptr M00_L42
       cmp       [r12+8],eax
       jle       near ptr M00_L42
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L42
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L42
       mov       rcx,[rax+20]
       jmp       near ptr M00_L44
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E61F4C8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L52
M00_L49:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E7B4DB0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L62
       xor       r12d,r12d
M00_L50:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E61F3D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L51:
       test      rcx,rcx
       je        short M00_L48
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E61F4F8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L59
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L67
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L61
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L61
M00_L56:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L49
       test      eax,eax
       jl        near ptr M00_L49
       cmp       [r12+8],eax
       jle       near ptr M00_L49
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L49
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L49
       mov       rcx,[rax+20]
       jmp       near ptr M00_L51
M00_L57:
       mov       ecx,0E
       call      qword ptr [7FF92E70EAD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L47
M00_L58:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E7B4C48]
       test      eax,eax
       je        near ptr M00_L43
       jmp       short M00_L65
M00_L59:
       mov       rcx,r15
       mov       r11,7FF92DE60E00
       call      qword ptr [r11]
       jmp       near ptr M00_L54
M00_L60:
       mov       rcx,r15
       mov       r11,7FF92DE60E08
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L55
M00_L61:
       mov       ecx,0E
       call      qword ptr [7FF92E70EAD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L56
M00_L62:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E7B4C48]
       test      eax,eax
       je        near ptr M00_L50
       jmp       short M00_L65
M00_L63:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E707480]
       int       3
M00_L64:
       mov       rcx,r13
       call      qword ptr [7FF92E7B4C18]
       int       3
M00_L65:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF92E7B4C60]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF92E287B40]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L73
M00_L68:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E735080
       cmp       [rcx],ecx
       call      qword ptr [7FF92E7070C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L69:
       test      byte ptr [7FF92E734E80],1
       je        short M00_L71
M00_L70:
       mov       rcx,23F5E401FE0
       mov       r15,[rcx]
       jmp       near ptr M00_L40
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L70
M00_L72:
       mov       rcx,rdi
       mov       r11,7FF92DE60DF8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L40
M00_L73:
       mov       rcx,r15
       mov       r11,7FF92DE60E10
       call      qword ptr [r11]
       jmp       near ptr M00_L68
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E61F390]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FF92DE60E10
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2789
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
       call      qword ptr [7FF92E61F2A0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E78B734
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E78B730
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E70F6A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E285CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E70F6C0]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E78B73C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E78B740
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E78B738
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E78B744
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7C4FB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7C4FB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7C4FB4
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       call      qword ptr [7FF98C1A5618]
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
       call      qword ptr [7FF98C1A5618]
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
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FF92DF166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L07
       test      rsi,rsi
       je        near ptr M08_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L02:
       sub       ebp,eax
       js        near ptr M08_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M08_L16
M08_L03:
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
       je        near ptr M08_L15
       cmp       r8,4000
       ja        near ptr M08_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L12
M08_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L13
M08_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M08_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L04
M08_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L14:
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
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L04
M08_L16:
       cmp       byte ptr [rsp+78],0
       je        short M08_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L17:
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rbx,rbx
       je        near ptr M09_L09
       test      rsi,rsi
       je        near ptr M09_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L06
       test      r14d,r14d
       jl        near ptr M09_L05
       test      edi,edi
       jl        near ptr M09_L04
       test      ebp,ebp
       jl        near ptr M09_L03
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L02
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L01
       movzx     eax,word ptr [rcx]
       mov       r14d,r14d
       imul      r14,rax
       mov       edx,edi
       imul      rdx,rax
       lea       rbx,[rbx+rdx+10]
       mov       edx,ebp
       imul      rax,rdx
       lea       rdi,[rsi+rax+10]
       test      dword ptr [rcx],1000000
       je        short M09_L00
       mov       rcx,7FF92E778B30
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L14
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       je        near ptr M09_L10
       jmp       near ptr M09_L12
M09_L00:
       mov       rcx,7FF92E778B54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L10
M09_L01:
       mov       rcx,7FF92E778B34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L02:
       mov       rcx,7FF92E778B38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L03:
       mov       rcx,7FF92E778B3C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L04:
       mov       rcx,7FF92E778B40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L05:
       mov       rcx,7FF92E778B44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L06:
       mov       rcx,7FF92E778B48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L07:
       mov       rcx,7FF92E778B4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L08:
       mov       rcx,7FF92E778B50
       call      CORINFO_HELP_COUNTPROFILE32
M09_L09:
       mov       rcx,7FF92E778B58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FF92E70DA10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M09_L10:
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L13
M09_L11:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L10
M09_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L11
M09_L14:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF92E49E580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 491
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
       call      qword ptr [7FF92E7B4B70]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E7B4B58]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E61F3F0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E71D688
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E71D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E71D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E707438]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E707450]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E7B4C90]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E707468]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E707438]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E707468]
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
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FF98DB57C00
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
       jmp       qword ptr [7FF92E7B4C30]
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
       jmp       qword ptr [7FF92E61F3F0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FF92E71D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FF92E71D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E085050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF98C1ACCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2597A400808
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E705AA0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       call      qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF92DE61218
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
       mov       r11,7FF92DE61210
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
       call      qword ptr [7FF92E085020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E70DC80]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF92E137A20]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FF92E7C5B78]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF92E4961A8]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4961A8]
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
       call      qword ptr [7FF92E49FF30]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF92E5FF468]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E5FF468]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FF92E70FA68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,299F9200EE8
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FF92E5FFA20]
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
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E705BD8]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L68
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L53
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L53
       jmp       short M00_L46
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF92E705D10]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L45
M00_L42:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E7C5D40]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L58
       xor       r12d,r12d
M00_L43:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E705C20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L44:
       test      rcx,rcx
       je        short M00_L41
M00_L45:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E705D40]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L46:
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L67
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L57
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L57
M00_L47:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L42
       test      eax,eax
       jl        near ptr M00_L42
       cmp       [r12+8],eax
       jle       near ptr M00_L42
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L42
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L42
       mov       rcx,[rax+20]
       jmp       near ptr M00_L44
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E705D10]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L52
M00_L49:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E7C5D40]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L62
       xor       r12d,r12d
M00_L50:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E705C20]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L51:
       test      rcx,rcx
       je        short M00_L48
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E705D40]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L59
       mov       rcx,r15
       call      qword ptr [7FF92E1CF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L67
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L61
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L61
M00_L56:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L49
       test      eax,eax
       jl        near ptr M00_L49
       cmp       [r12+8],eax
       jle       near ptr M00_L49
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L49
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L49
       mov       rcx,[rax+20]
       jmp       near ptr M00_L51
M00_L57:
       mov       ecx,0E
       call      qword ptr [7FF92E5FEFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L47
M00_L58:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E7C5C20]
       test      eax,eax
       je        near ptr M00_L43
       jmp       short M00_L65
M00_L59:
       mov       rcx,r15
       mov       r11,7FF92DE61228
       call      qword ptr [r11]
       jmp       near ptr M00_L54
M00_L60:
       mov       rcx,r15
       mov       r11,7FF92DE61230
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L55
M00_L61:
       mov       ecx,0E
       call      qword ptr [7FF92E5FEFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L56
M00_L62:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E7C5C20]
       test      eax,eax
       je        near ptr M00_L50
       jmp       short M00_L65
M00_L63:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E70DC68]
       int       3
M00_L64:
       mov       rcx,r13
       call      qword ptr [7FF92E7C5BF0]
       int       3
M00_L65:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF92E7C5C38]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF92E287B40]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L73
M00_L68:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E760C50
       cmp       [rcx],ecx
       call      qword ptr [7FF92E70D830]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L69:
       test      byte ptr [7FF92E760A50],1
       je        short M00_L71
M00_L70:
       mov       rcx,25964401FD8
       mov       r15,[rcx]
       jmp       near ptr M00_L40
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L70
M00_L72:
       mov       rcx,rdi
       mov       r11,7FF92DE61220
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L40
M00_L73:
       mov       rcx,r15
       mov       r11,7FF92DE61238
       call      qword ptr [r11]
       jmp       near ptr M00_L68
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E705BD8]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FF92DE61238
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2789
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
       call      qword ptr [7FF92E705AE8]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FF98B530B00
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jge       short M02_L01
       mov       rcx,7FF92E79DABC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L01:
       mov       rcx,7FF92E79DAB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF92E70F6F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E285CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       r14d,ebx
       or        r14d,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,r14d
       call      qword ptr [7FF92E70F708]
       test      eax,eax
       je        short M02_L05
       lea       ecx,[r14-1]
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
       mov       rcx,7FF92E79DAC4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF92E79DAC8
       call      CORINFO_HELP_COUNTPROFILE32
       add       r14d,2
M02_L06:
       cmp       r14d,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FF92E79DAC0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,r14d
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L08:
       mov       rcx,7FF92E79DACC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 295
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       rcx,7FF92E7E5560
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DF15A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E7E5558
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E7E555C
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       call      00007FF98DB41380
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       jne       short M06_L00
       test      r8b,4
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L01
M06_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M06_L01:
       vzeroupper
       ret
M06_L02:
       test      r8,r8
       je        short M06_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L01
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
       jmp       short M06_L01
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
       jmp       near ptr M06_L01
M06_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF92DF166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L07
       test      rsi,rsi
       je        near ptr M08_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L02:
       sub       ebp,eax
       js        near ptr M08_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M08_L16
M08_L03:
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
       je        near ptr M08_L15
       cmp       r8,4000
       ja        near ptr M08_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L12
M08_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L13
M08_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M08_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L04
M08_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L14:
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
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L04
M08_L16:
       cmp       byte ptr [rsp+78],0
       je        short M08_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L17:
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       test      rbx,rbx
       je        near ptr M09_L09
       test      rsi,rsi
       je        near ptr M09_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L06
       test      r14d,r14d
       jl        near ptr M09_L05
       test      edi,edi
       jl        near ptr M09_L04
       test      ebp,ebp
       jl        near ptr M09_L03
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L02
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L01
       movzx     eax,word ptr [rcx]
       mov       r14d,r14d
       imul      r14,rax
       mov       edx,edi
       imul      rdx,rax
       lea       rbx,[rbx+rdx+10]
       mov       edx,ebp
       imul      rax,rdx
       lea       rdi,[rsi+rax+10]
       test      dword ptr [rcx],1000000
       je        short M09_L00
       mov       rcx,7FF92E7ACFC8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L14
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       je        near ptr M09_L10
       jmp       near ptr M09_L12
M09_L00:
       mov       rcx,7FF92E7ACFEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L10
M09_L01:
       mov       rcx,7FF92E7ACFCC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L02:
       mov       rcx,7FF92E7ACFD0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L03:
       mov       rcx,7FF92E7ACFD4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L04:
       mov       rcx,7FF92E7ACFD8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L05:
       mov       rcx,7FF92E7ACFDC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L06:
       mov       rcx,7FF92E7ACFE0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L07:
       mov       rcx,7FF92E7ACFE4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L08:
       mov       rcx,7FF92E7ACFE8
       call      CORINFO_HELP_COUNTPROFILE32
M09_L09:
       mov       rcx,7FF92E7ACFF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FF92E70FA68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M09_L10:
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L13
M09_L11:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L10
M09_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L11
M09_L14:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF92E49FF30]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 491
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
       call      qword ptr [7FF92E7C5B60]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E7C5B48]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E705C38]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E74D688
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E74D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E74D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E704690]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E5FF5E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E7C5C68]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E5FF600]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E704690]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E5FF600]
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
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FF98DB57C00
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
       jmp       qword ptr [7FF92E7C5C08]
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
       jmp       qword ptr [7FF92E705C38]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FF92E74D598
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M14_L05
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
       jmp       near ptr M14_L13
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       near ptr M14_L06
M14_L03:
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
       je        near ptr M14_L12
M14_L04:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M14_L01
M14_L05:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF92DF15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M14_L07
       jmp       short M14_L08
M14_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E74D698
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M14_L08:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M14_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FF92E085050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M14_L11
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
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E42D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M14_L11:
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
       jmp       near ptr M14_L03
M14_L12:
       lock inc  qword ptr [rsi]
       jmp       near ptr M14_L04
M14_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M14_L15
M14_L14:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L15:
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M14_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M14_L17
       mov       rcx,rdi
       call      qword ptr [7FF92DF16820]; System.Threading.Monitor.Exit(System.Object)
M14_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 649
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
       call      qword ptr [7FF98C1ACCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,117A7C02840
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FF92E70DB60]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       call      qword ptr [7FF92DEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF92DE41978
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
       mov       r11,7FF92DE41970
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
       call      qword ptr [7FF92E065020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF92E845B60]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF92E117A20]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FF92E846E80]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF92E4761A8]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4761A8]
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
       call      qword ptr [7FF92E47EA18]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF92E5F5F08]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF92E5F5F08]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FF92E5F5F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,1583CAA0FD8
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FF92E7052C0]
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
       call      qword ptr [7FF92E40D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E70DC98]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+280]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L68
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L69
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       [rbp-0A8],r15
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M00_L53
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L53
       jmp       short M00_L46
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF92E70DF20]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L45
M00_L42:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E847090]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L58
       xor       r12d,r12d
M00_L43:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E70DE30]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L44:
       test      rcx,rcx
       je        short M00_L41
M00_L45:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E70DF50]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L46:
       mov       rcx,r15
       call      qword ptr [7FF92E1AF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L67
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L57
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L57
M00_L47:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L42
       test      eax,eax
       jl        near ptr M00_L42
       cmp       [r12+8],eax
       jle       near ptr M00_L42
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L42
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L42
       mov       rcx,[rax+20]
       jmp       near ptr M00_L44
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF92E70DF20]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L52
M00_L49:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L64
       call      qword ptr [7FF92E847090]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L62
       xor       r12d,r12d
M00_L50:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF92E70DE30]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L51:
       test      rcx,rcx
       je        short M00_L48
M00_L52:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF92E70DF50]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L53:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L59
       mov       rcx,r15
       call      qword ptr [7FF92E1AF730]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L54:
       test      eax,eax
       je        near ptr M00_L67
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L63
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L66
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L55:
       mov       r13,[rsi+8]
       cmp       [r13],r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L61
       mov       rcx,[rcx+240]
       mov       rax,[rcx+70]
       test      rax,rax
       je        near ptr M00_L61
M00_L56:
       mov       r12,[rax+10]
       mov       eax,[r13+18]
       not       eax
       test      r12,r12
       je        near ptr M00_L49
       test      eax,eax
       jl        near ptr M00_L49
       cmp       [r12+8],eax
       jle       near ptr M00_L49
       cmp       eax,[r12+8]
       jae       near ptr M00_L66
       mov       eax,eax
       mov       rax,[r12+rax*8+10]
       test      rax,rax
       je        near ptr M00_L49
       cmp       byte ptr [r13+1C],0
       je        near ptr M00_L49
       mov       rcx,[rax+20]
       jmp       near ptr M00_L51
M00_L57:
       mov       ecx,0E
       call      qword ptr [7FF92E5F7438]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L47
M00_L58:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E846F10]
       test      eax,eax
       je        near ptr M00_L43
       jmp       short M00_L65
M00_L59:
       mov       rcx,r15
       mov       r11,7FF92DE41988
       call      qword ptr [r11]
       jmp       near ptr M00_L54
M00_L60:
       mov       rcx,r15
       mov       r11,7FF92DE41990
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L55
M00_L61:
       mov       ecx,0E
       call      qword ptr [7FF92E5F7438]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L56
M00_L62:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF92E846F10]
       test      eax,eax
       je        near ptr M00_L50
       jmp       short M00_L65
M00_L63:
       mov       ecx,[r15+8]
       call      qword ptr [7FF92E845B48]
       int       3
M00_L64:
       mov       rcx,r13
       call      qword ptr [7FF92E846EE0]
       int       3
M00_L65:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF92E846F28]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF92E267B40]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L73
M00_L68:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF92E870C50
       cmp       [rcx],ecx
       call      qword ptr [7FF92E845350]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L69:
       test      byte ptr [7FF92E870A50],1
       je        short M00_L71
M00_L70:
       mov       rcx,117A7C02AB0
       mov       r15,[rcx]
       jmp       near ptr M00_L40
M00_L71:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L70
M00_L72:
       mov       rcx,rdi
       mov       r11,7FF92DE41980
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L40
M00_L73:
       mov       rcx,r15
       mov       r11,7FF92DE41998
       call      qword ptr [r11]
       jmp       near ptr M00_L68
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FF92E70DC98]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FF92DE41998
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2789
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
       call      qword ptr [7FF92E70DBA8]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rcx,7FF98B530B00
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
       call      qword ptr [7FF92E704D98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92E265CF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF92E704DB0]
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
       mov       rcx,7FF92E77F590
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF92DEF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FF92E77F588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FF92E77F58C
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
       call      qword ptr [7FF98C1A1EF8]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FF98C1A52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FF98C1A1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        short M04_L03
M04_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M04_L01
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
       jae       near ptr M04_L05
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
       jl        short M04_L00
M04_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FF98C193FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,edx
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       r8,[rdi+rax+10]
       cmp       dword ptr [r8+4],0FFFFFFFF
       jl        short M04_L04
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
       jae       short M04_L05
       mov       eax,eax
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+4],r10d
       lea       r8d,[rcx+1]
       mov       [rax],r8d
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FF98C193FD8]
       int       3
; Total bytes of code 317
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
       call      00007FF98DB41380
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
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
       jmp       qword ptr [7FF92DEF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF98C19E650]
       mov       rbx,rax
       call      qword ptr [7FF98C1A98B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8058]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
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
       je        near ptr M08_L07
       test      rsi,rsi
       je        near ptr M08_L06
       mov       rax,[rbx]
       cmp       rax,[rsi]
       je        short M08_L00
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98C1A5378]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF98C1BC8F8]
       int       3
M08_L02:
       sub       ebp,eax
       js        near ptr M08_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M08_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M08_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98C1A5298]
       test      eax,eax
       jne       near ptr M08_L16
M08_L03:
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
       je        near ptr M08_L15
       cmp       r8,4000
       ja        near ptr M08_L14
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L12
M08_L04:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M08_L13
M08_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98C1A71F0]
       int       3
M08_L08:
       call      qword ptr [7FF98C19E770]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9D18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A8778]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF98C1BC8E0]
       int       3
M08_L10:
       call      qword ptr [7FF98C19E538]
       mov       rbx,rax
       call      qword ptr [7FF98C1A8BD0]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FF98C19E538]
       mov       r14,rax
       call      qword ptr [7FF98C1A8BC8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF98C1A71A0]
       mov       rcx,r14
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L12:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L04
M08_L13:
       call      qword ptr [7FF98C194040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L14:
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
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98C1A88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L04
M08_L16:
       cmp       byte ptr [rsp+78],0
       je        short M08_L17
       call      qword ptr [7FF98C19E560]
       mov       rbx,rax
       call      qword ptr [7FF98C1A9698]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98C1A7218]
       mov       rcx,rbx
       call      qword ptr [7FF98C193FC0]; CORINFO_HELP_THROW
       int       3
M08_L17:
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L06
       test      r8,r8
       je        near ptr M09_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M09_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M09_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M09_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M09_L05
       cmp       rax,4000
       ja        short M09_L04
       mov       r8,rax
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L02
M09_L00:
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M09_L03
M09_L01:
       add       rsp,38
       ret
M09_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L01
M09_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FF92E47EA18]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L05:
       mov       r8,rax
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FF92E5F5F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
; Total bytes of code 225
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
       call      qword ptr [7FF92E846E68]
       jmp       short M10_L01
M10_L00:
       dec       ebx
       mov       [rcx+18],ebx
M10_L01:
       add       rsp,20
       pop       rbx
       ret
M10_L02:
       call      qword ptr [7FF92E846E50]
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
       call      00007FF98DBB2D60
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
       call      qword ptr [7FF92E70DE48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FF92E864290
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FF92E8642A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FF92E8641A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M11_L05
M11_L10:
       cmp       byte ptr [rbx+1C],0
       je        short M11_L06
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L14
M11_L11:
       xor       ecx,ecx
       call      qword ptr [7FF92E5F6C58]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF92E5FC480]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FF92E846F58]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
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
       call      qword ptr [7FF92E5F7708]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FF92E5F6C58]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF92E5F7708]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 532
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FF98DB57C00
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
       jmp       qword ptr [7FF92E846EF8]
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
       jmp       qword ptr [7FF92E70DE48]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FF92E8641A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
; Total bytes of code 147
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
       call      qword ptr [7FF92DEF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FF92DEF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FF92E8642A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF92E065050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF92E40D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FF92E40D140]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF92DEF6820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 645
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
       call      qword ptr [7FF98C1ACCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E07F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,1A3FB001F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E6FF7F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E6FF7F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E6FF7E0]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE1F0]
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
       call      qword ptr [7FF92E7A49D8]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L36
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       jbe       short M00_L25
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       jbe       short M00_L29
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE50F20
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE50F28
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E7A48B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E7255E0],1
       je        near ptr M00_L43
M00_L37:
       mov       rcx,1A3FB002008
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L38:
       call      qword ptr [7FF92E48EC10]
       mov       ecx,89
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1D5508
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E6FDBF0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E6FDC08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FF92DE50F38
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L40
       mov       rcx,1A3FB001F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L35
M00_L40:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE50F40
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A3FB002010
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE50F18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE50F30
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE50F30
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E6FEC10]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE1F0]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E6FEC10]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1601
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E27F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E6FD020]
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
       jmp       qword ptr [7FF92DF0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FF98C194030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF98C194038]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L04
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L06
       cmp       [r14+8],r15d
       je        near ptr M04_L03
       test      r15d,r15d
       jle       near ptr M04_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L05
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M04_L02
       test      r14,r14
       je        near ptr M04_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M04_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L11
       cmp       edi,[r14+8]
       ja        near ptr M04_L11
       cmp       edi,[r15+8]
       ja        near ptr M04_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L09
       cmp       r8,4000
       ja        near ptr M04_L08
       mov       rcx,rax
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M04_L07
M04_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L05:
       mov       rdx,7FF92E7400F8
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4861A8]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FF92E48EA18]
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF92E6FD7D0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF92E6FD7D0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FF92E6FD7E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rdx,7FF92E785FE0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
; Total bytes of code 525
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
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E48FE50008
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
       call      qword ptr [7FF92E7A40A8]
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
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E07F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,206F0401F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E6FF828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E6FF828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E6FF810]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE220]
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
       call      qword ptr [7FF92E7A4A08]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L36
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       jbe       short M00_L25
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       jbe       short M00_L29
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE50F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE50F30
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E7A48E8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E7255E0],1
       je        near ptr M00_L43
M00_L37:
       mov       rcx,206F0402008
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L38:
       call      qword ptr [7FF92E48EC10]
       mov       ecx,89
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1D5508
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E6FDB78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E6FDB90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FF92DE50F40
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L40
       mov       rcx,206F0401F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L35
M00_L40:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE50F48
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,206F0402010
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE50F20
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE50F38
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE50F38
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E6FEC40]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE220]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E6FEC40]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1601
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E27F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E6FD008]
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
       jmp       qword ptr [7FF92DF0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FF98C194030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF98C194038]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L04
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L06
       cmp       [r14+8],r15d
       je        near ptr M04_L03
       test      r15d,r15d
       jle       near ptr M04_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L05
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M04_L02
       test      r14,r14
       je        near ptr M04_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M04_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L11
       cmp       edi,[r14+8]
       ja        near ptr M04_L11
       cmp       edi,[r15+8]
       ja        near ptr M04_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L09
       cmp       r8,4000
       ja        near ptr M04_L08
       mov       rcx,rax
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M04_L07
M04_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L05:
       mov       rdx,7FF92E7400F8
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4861A8]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FF92E48E580]
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF92E6FD800]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF92E6FD800]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FF92E6FD818]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rdx,7FF92E785FE0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
; Total bytes of code 525
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
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,247853B0008
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
       call      qword ptr [7FF92E7A40D8]
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
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E08F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,183D1001F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E70C630]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E70C630]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E70C840]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E70C5E8]
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
       call      qword ptr [7FF92E70C8D0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L36
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       ja        short M00_L25
       call      qword ptr [7FF92E08E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       ja        short M00_L29
       call      qword ptr [7FF92E08E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE60C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE60CA0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E70C798]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E6E2CB0],1
       je        near ptr M00_L43
M00_L37:
       mov       rcx,183D1001FC8
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L38:
       call      qword ptr [7FF92E496EE0]
       mov       ecx,89
       mov       rdx,7FF92E30A010
       call      qword ptr [7FF92E1377B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1E5508
       call      qword ptr [7FF92E1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E30A010
       call      qword ptr [7FF92E1377B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E70CC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E70CC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FF92DE60CB0
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L40
       mov       rcx,183D1001F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L35
M00_L40:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE60CB8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,183D1001FD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE60C90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE60CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE60CA8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E70C600]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E70C5E8]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E70C600]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1601
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E28F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E70C780]
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
       jmp       qword ptr [7FF92DF1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FF98C194030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF98C194038]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FF92E4961A8]
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
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M04_L04
M04_L03:
       mov       rcx,rdx
       call      qword ptr [7FF92DF15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L04:
       mov       rdx,7FF92E6CB790
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
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
       call      qword ptr [7FF92E085050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF92E6CB7A0
       call      qword ptr [7FF92DF1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L06
; Total bytes of code 310
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
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,1C465F30008
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
       call      qword ptr [7FF92E70CED0]
       int       3
; Total bytes of code 231
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
       jmp       qword ptr [7FF92DF15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E07F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,1D198401F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E6FC600]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E6FC600]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E6FC840]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E6FC648]
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
       call      qword ptr [7FF92E6FC8D0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L36
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       ja        short M00_L25
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       ja        short M00_L29
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE50C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE50CA0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E6FC798]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E6D2CA0],1
       je        near ptr M00_L43
M00_L37:
       mov       rcx,1D198401FC8
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L38:
       call      qword ptr [7FF92E486EE0]
       mov       ecx,89
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1D5508
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E6FCC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E6FCC78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FF92DE50CB0
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L40
       mov       rcx,1D198401F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L35
M00_L40:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE50CB8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D198401FD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L37
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE50C90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE50CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE50CA8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E6FC630]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E6FC648]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E6FC630]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1601
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E27F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E6FC780]
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
       jmp       qword ptr [7FF92DF0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       jne       short M03_L01
       mov       r14d,4
M03_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M03_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4861A8]
       int       3
M03_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M03_L00
M03_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M03_L08
       test      r14d,r14d
       jg        short M03_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M03_L04
M03_L03:
       mov       rcx,rdx
       call      qword ptr [7FF92DF05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L08
M03_L04:
       mov       rdx,7FF92E6BB718
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L03
M03_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        short M03_L09
       mov       rcx,rax
M03_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M03_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF92E075050]; System.Array.Copy(System.Array, System.Array, Int32)
M03_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
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
M03_L09:
       mov       rdx,7FF92E6BB728
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L06
; Total bytes of code 310
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2122D520008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      qword ptr [7FF92E6FCED0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E09F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L36
       mov       rcx,17A46001F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E71F810]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E71F810]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E71F7F8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E71E190]
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
       call      qword ptr [7FF92E7C4990]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       call      qword ptr [7FF92E09E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       jbe       short M00_L25
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       call      qword ptr [7FF92E09E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       jbe       short M00_L29
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE70D98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE70DA0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E7C4870]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF92DE70DB0
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L37
       mov       rcx,17A46001F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L37:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE70DB8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E745B00],1
       je        near ptr M00_L43
M00_L39:
       mov       rcx,17A46002008
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L40:
       call      qword ptr [7FF92E4AEBB0]
       mov       ecx,89
       mov       rdx,7FF92E31A010
       call      qword ptr [7FF92E1477B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1F5508
       call      qword ptr [7FF92E1477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E31A010
       call      qword ptr [7FF92E1477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E71DC08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E71DC20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17A46002010
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L39
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE70D90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE70DA8
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE70DA8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E71EBB0]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E71E190]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E71EBB0]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1598
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E29F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E71CFF0]
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
       jmp       qword ptr [7FF92DF2D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M03_L04
       mov       r15d,4
M03_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M03_L06
       cmp       [r14+8],r15d
       je        near ptr M03_L03
       test      r15d,r15d
       jle       near ptr M03_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M03_L05
       mov       rcx,rax
M03_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M03_L02
       test      r14,r14
       je        near ptr M03_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M03_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L11
       cmp       edi,[r14+8]
       ja        near ptr M03_L11
       cmp       edi,[r15+8]
       ja        near ptr M03_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L09
       cmp       r8,4000
       ja        near ptr M03_L08
       mov       rcx,rax
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M03_L07
M03_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M03_L00
M03_L05:
       mov       rdx,7FF92E760738
       call      qword ptr [7FF92DF2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4A61A8]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FF92E4AE580]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FF92DF25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF92E71D7E8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF92E71D7E8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FF92E71D800]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rdx,7FF92E7A5AA0
       call      qword ptr [7FF92DF2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M03_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L03
; Total bytes of code 525
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1BADAE10008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FF92E7C4048]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF92DF25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF92E06F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L36
       mov       rcx,218C7C01F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E6EC600]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E6EC600]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E6EC840]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E6EC648]
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
       call      qword ptr [7FF92E6EC8D0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       ja        short M00_L25
       call      qword ptr [7FF92E06E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       ja        short M00_L29
       call      qword ptr [7FF92E06E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE40C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE40CA0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E6EC798]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF92DE40CB0
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L37
       mov       rcx,218C7C01F18
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L37:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE40CB8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E6C26A8],1
       je        near ptr M00_L43
M00_L39:
       mov       rcx,218C7C01FC8
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L40:
       call      qword ptr [7FF92E476EE0]
       mov       ecx,89
       mov       rdx,7FF92E2EA010
       call      qword ptr [7FF92E1177B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1C5508
       call      qword ptr [7FF92E1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E2EA010
       call      qword ptr [7FF92E1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E6ECAF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E6ECB10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,218C7C01FD0
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L39
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE40C90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE40CA8
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE40CA8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E6EC630]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E6EC648]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E6EC630]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1598
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E26F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E6EC6C0]
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
       jmp       qword ptr [7FF92DEFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       jne       short M03_L01
       mov       r14d,4
M03_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M03_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4761A8]
       int       3
M03_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M03_L00
M03_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M03_L08
       test      r14d,r14d
       jg        short M03_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M03_L04
M03_L03:
       mov       rcx,rdx
       call      qword ptr [7FF92DEF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L08
M03_L04:
       mov       rdx,7FF92E6AB7A0
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M03_L03
M03_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        short M03_L09
       mov       rcx,rax
M03_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M03_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF92E065050]; System.Array.Copy(System.Array, System.Array, Int32)
M03_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
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
M03_L09:
       mov       rdx,7FF92E6AB7B0
       call      qword ptr [7FF92DEFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L06
; Total bytes of code 310
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2595CC10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      qword ptr [7FF92E6ECF78]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF92DEF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L36
       mov       rcx,2505D801F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E6FF5A0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E6FF5A0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E6FFE88]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE1A8]
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
       call      qword ptr [7FF92E7A5F80]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       jbe       short M00_L25
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       call      qword ptr [7FF92E07E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       jbe       short M00_L29
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE51130
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE51138
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E7A5E90]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF92DE51148
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L37
       mov       rcx,2505D801F30
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L37:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE51150
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E7388A0],1
       je        near ptr M00_L43
M00_L39:
       mov       rcx,2505D802AA8
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L40:
       call      qword ptr [7FF92E48EBC8]
       mov       ecx,89
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E1D5508
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E2FA010
       call      qword ptr [7FF92E1277B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E60FB10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E60FB28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2505D802AB0
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L39
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE51128
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE51140
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE51140
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E6FEBC8]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E6FE1A8]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E6FEBC8]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1597
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FF92E27F270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       call      qword ptr [7FF92E60ED90]
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
       jmp       qword ptr [7FF92DF0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M03_L04
       mov       r15d,4
M03_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M03_L06
       cmp       [r14+8],r15d
       je        near ptr M03_L03
       test      r15d,r15d
       jle       near ptr M03_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M03_L05
       mov       rcx,rax
M03_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M03_L02
       test      r14,r14
       je        near ptr M03_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M03_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L11
       cmp       edi,[r14+8]
       ja        near ptr M03_L11
       cmp       edi,[r15+8]
       ja        near ptr M03_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L09
       cmp       r8,4000
       ja        near ptr M03_L08
       mov       rcx,rax
       call      00007FF98DB41380
       cmp       dword ptr [7FF98DE63A10],0
       jne       short M03_L07
M03_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M03_L00
M03_L05:
       mov       rdx,7FF92E637388
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4861A8]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FF92E48EA18]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF92E60F540]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF92E60F540]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FF92E60F558]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M03_L14
       jmp       short M03_L15
M03_L14:
       mov       rdx,7FF92E74BDE0
       call      qword ptr [7FF92DF0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M03_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L03
; Total bytes of code 525
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,290F2970008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FF92E7A4A08]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF92DF05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+278]
       test      rbx,rbx
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L36
       mov       rcx,1BC3AC01F70
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L42
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FF98DBB2D60
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
       call      00007FF98DBB2D60
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
       jle       near ptr M00_L41
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
       call      qword ptr [7FF92E63C5B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FF92E63C5B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FF92E745200]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF92E636D90]
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
       call      qword ptr [7FF92E896C88]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L47
       nop
       mov       rsi,[rbp-78]
M00_L22:
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M00_L38
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],ebx
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       [rbp-68],rdi
       cmp       qword ptr [rbp-68],0
       je        short M00_L24
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        near ptr M00_L30
M00_L24:
       mov       rbx,[rbp-68]
       cmp       [rbx],ebx
       jmp       short M00_L26
M00_L25:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       cmp       r15d,[r14+8]
       jae       near ptr M00_L33
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rdi
       jne       near ptr M00_L31
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       ecx,[rbx+8]
       cmp       ecx,[rbx+0C]
       jae       near ptr M00_L32
       mov       rsi,[rbx+10]
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jae       near ptr M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
M00_L27:
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       cmp       [r14+8],r15d
       ja        short M00_L25
       call      qword ptr [7FF92E0AE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L26
M00_L28:
       mov       ecx,[rbx+0C]
       mov       [rbx+8],ecx
       jmp       near ptr M00_L34
M00_L29:
       lea       eax,[r15+1]
       mov       [rcx+10],eax
       mov       eax,r15d
       lea       rcx,[r14+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L30:
       mov       eax,[rbx+8]
       inc       eax
       cmp       eax,[rbx+0C]
       jae       short M00_L28
       mov       [rbx+8],eax
       mov       r8d,[rbx+8]
       cmp       r8d,[rbx+0C]
       jae       short M00_L32
       mov       rsi,[rbx+10]
       cmp       r8d,[rsi+8]
       jae       short M00_L33
       mov       ecx,r8d
       mov       rdx,[rsi+rcx*8+10]
       mov       rcx,[rbp-60]
       inc       dword ptr [rcx+14]
       mov       r14,[rcx+8]
       mov       r15d,[rcx+10]
       mov       eax,[r14+8]
       cmp       eax,r15d
       ja        short M00_L29
       call      qword ptr [7FF92E0AE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L30
M00_L31:
       mov       rcx,rbx
       mov       r11,7FF92DE81938
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L34
       mov       rcx,rbx
       mov       r11,7FF92DE81940
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L27
M00_L32:
       mov       ecx,[rbx+8]
       call      qword ptr [7FF92E896C10]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       cmp       [rbx],rdi
       jne       near ptr M00_L45
M00_L35:
       mov       rcx,[rbp-60]
       mov       [rbp-58],rcx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
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
M00_L36:
       mov       rcx,rsi
       mov       r11,7FF92DE81950
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M00_L37
       mov       rcx,1BC3AC01F70
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L37:
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+8]
       mov       rcx,rsi
       mov       r11,7FF92DE81958
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],ebx
       jmp       near ptr M00_L35
M00_L38:
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FF92E8B20A8],1
       je        near ptr M00_L43
M00_L39:
       mov       rcx,1BC3AC02BF8
       mov       rdi,[rcx]
       jmp       near ptr M00_L23
M00_L40:
       call      qword ptr [7FF92E4BEC10]
       mov       ecx,89
       mov       rdx,7FF92E32A010
       call      qword ptr [7FF92E1577B0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF92E205508
       call      qword ptr [7FF92E1577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF92E32A010
       call      qword ptr [7FF92E1577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF92DF37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF92E6366E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF92E636700]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BC3AC02C00
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L39
M00_L44:
       mov       rcx,rbx
       mov       r11,7FF92DE81930
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rcx,rbx
       mov       r11,7FF92DE81948
       call      qword ptr [r11]
       jmp       near ptr M00_L35
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rbx,[rbp-68]
       cmp       [rbx],rdi
       je        short M00_L46
       mov       rcx,rbx
       mov       r11,7FF92DE81948
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,28
       ret
M00_L47:
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L52
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L50
M00_L48:
       cmp       byte ptr [rsi+34],0
       je        short M00_L49
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF92E637918]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FF92E636D90]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FF98DBB2C80
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF92E637918]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1597
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L06
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
M01_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L06
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L05
M01_L06:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
       jmp       short M01_L01
M01_L07:
       jmp       qword ptr [7FF92E2AF270]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 123
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
       jmp       near ptr 00007FF98DBA8D10
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FF92E635758]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF92DF3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FF98C194030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF98C194038]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L04
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L06
       cmp       [r14+8],r15d
       je        short M04_L03
       test      r15d,r15d
       jle       near ptr M04_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M04_L05
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M04_L07
M04_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L05:
       mov       rdx,7FF92E616D80
       call      qword ptr [7FF92DF3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF92E4B61A8]
       int       3
M04_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FF92E0A5050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M04_L02
M04_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rdx,7FF92E66BFA8
       call      qword ptr [7FF92DF3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
; Total bytes of code 318
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
       call      00007FF98DBA9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF92DF35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF92DF35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FCCFAC0008
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
       call      qword ptr [7FF92E746D78]
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
       jmp       qword ptr [7FF92DF35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

