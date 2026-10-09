## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L95
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577F42A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L81
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L85
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L82
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L84
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD575CE7C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L83
M00_L08:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r12,[rbp-78]
       cmp       [r12],rcx
       jne       short M00_L11
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FFD57976E30]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       jmp       short M00_L10
M00_L11:
       mov       r12,[rbp-78]
       cmp       [r12],r12d
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
M00_L13:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       short M00_L15
       mov       rcx,r12
       call      qword ptr [7FFD57976E30]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFD570F0E88
       call      qword ptr [r11]
       jmp       short M00_L14
       nop       dword ptr [rax+rax]
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       near ptr M00_L86
       xor       ecx,ecx
       mov       [r12+20],rcx
       mov       dword ptr [r12+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L80
       mov       rcx,25A918027B0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L87
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L88
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L89
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L91
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L92
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       short M00_L22
       jmp       short M00_L23
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L75
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L51
       cmp       ecx,2
       jne       near ptr M00_L77
M00_L26:
       mov       rcx,[rbx+28]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       near ptr M00_L73
       call      qword ptr [7FFD57976E30]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L71
       mov       rsi,[rcx+8]
       mov       r14,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [r14+18],rcx
       jne       near ptr M00_L72
       test      rsi,rsi
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rdi+8]
M00_L29:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L65
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L76
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L62
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L34
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD575CE7C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L30:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L32
M00_L31:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L31
M00_L32:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L33
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L33:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L35
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L61
M00_L36:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L37:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L41
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L41
M00_L38:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57976E30]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0EC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L38
       jmp       near ptr M00_L45
M00_L39:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L44
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L40:
       test      rcx,rcx
       je        short M00_L41
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0EC8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57976E30]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0EA8
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0EB0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L40
       nop       dword ptr [rax]
M00_L45:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L64
M00_L46:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L63
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L47:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD578BFC60]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
       jmp       near ptr M00_L65
M00_L48:
       cmp       qword ptr [rbx+28],0
       je        short M00_L50
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L74
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L49:
       xor       ecx,ecx
       mov       [rbx+28],rcx
M00_L50:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L77
M00_L51:
       mov       rcx,[rbx+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L70
       cmp       byte ptr [rcx+38],0
       jne       near ptr M00_L67
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L69
       mov       rcx,[rsi+8]
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       qword ptr [rbp-98],0
       je        short M00_L56
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFD575CE7C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L52:
       mov       dword ptr [rbp-48],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L54
M00_L53:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L53
M00_L54:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L55
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L55:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L57
M00_L56:
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L68
M00_L58:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L59:
       lea       rcx,[rbx+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L60:
       mov       rcx,rdi
       mov       r11,7FFD570F0E68
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD575CE358]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFD570F0EC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0EB8
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L64:
       call      M00_L96
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       je        near ptr M00_L47
M00_L65:
       call      qword ptr [7FFD578BF900]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFD57A26A60]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573CC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD5750C7C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFD57A25200]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD575CE358]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFD570F0EE8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFD570F0ED0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFD570F0EE0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       r14,[rbx+20]
M00_L72:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L73:
       mov       r11,7FFD570F0ED8
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFD570F0EF0
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFD570F0E60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFD57A25200]
       int       3
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L94
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L93
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       mov       rcx,rdi
       call      qword ptr [7FFD5746D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-50]
       mov       rdx,7FFD579CEE08
       cmp       [rcx],ecx
       call      qword ptr [7FFD57997840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFD575AFEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
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
M00_L81:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573CC060]
       mov       rdi,rax
       call      qword ptr [7FFD57A268C8]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57995908]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFD57A25200]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD575CE358]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFD570F0E98
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFD570F0E80
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFD570F0E90
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,25A918027A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,25A918027B0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L88:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L89:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L90
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25A91802B80
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A26A00]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A26A18]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFD570F0E58
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFD570F0EF8
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFD570F0E70
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFD575AFEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       ret
M00_L96:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L98
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L97
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L98
M00_L97:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0EB8
       call      qword ptr [r11]
M00_L98:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L100
       cmp       qword ptr [rbp-90],0
       jne       short M00_L99
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD575CE358]
M00_L100:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M00_L102
       cmp       qword ptr [rbp-98],0
       jne       short M00_L101
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD575CE358]
M00_L102:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L107
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L106
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L105
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L103
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L104
M00_L103:
       mov       r11,7FFD570F0EF8
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFD5746D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFD570F0E70
       call      qword ptr [r11]
M00_L107:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L109
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M00_L108
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],0FFFFFFFE
       jmp       short M00_L109
M00_L108:
       mov       rcx,rax
       mov       r11,7FFD570F0E90
       call      qword ptr [r11]
M00_L109:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L111
       cmp       qword ptr [rbp-80],0
       jne       short M00_L110
       xor       ecx,ecx
       call      qword ptr [7FFD575CE340]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD575CE358]
M00_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3858
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+38]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A4F018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578BF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD578BF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD57A26340]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+38]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A4F018
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578BF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD578BF9C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 696
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
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M03_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       short M03_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M03_L06
M03_L01:
       cmp       ecx,5
       ja        near ptr M03_L13
       mov       ecx,ecx
       lea       rdx,[7FFD5794A188]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L14
       mov       ecx,[rcx+0A0]
M03_L02:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M03_L15
M03_L03:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L13
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L09
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M03_L06:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M03_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M03_L07:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M03_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M03_L29
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M03_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M03_L08:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L09:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L12
M03_L10:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M03_L30
       mov       rcx,rdx
M03_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD578BFD38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       short M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        short M03_L10
M03_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L14:
       mov       ecx,[rbx+2C]
       jmp       near ptr M03_L02
M03_L15:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M03_L20
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L19
M03_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L17
       mov       rcx,rdx
       jmp       short M03_L18
M03_L17:
       mov       rdx,7FFD57A4E860
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BFD38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L19:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L16
       jmp       near ptr M03_L03
M03_L20:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L24
M03_L21:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L22
       mov       rcx,rdx
       jmp       short M03_L23
M03_L22:
       mov       rdx,7FFD57A4E860
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L23:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BFD38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L24:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M03_L21
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L28
M03_L25:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L26
       mov       rcx,rdx
       jmp       short M03_L27
M03_L26:
       mov       rdx,7FFD57A4E860
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L27:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BFD38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L28:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L25
       jmp       near ptr M03_L03
M03_L29:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD57A26340]
       jmp       near ptr M03_L07
M03_L30:
       mov       rdx,7FFD57A4E860
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 865
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M06_L38
       cmp       qword ptr [rbp+28],0
       je        short M06_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M06_L37
M06_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M06_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M06_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M06_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD57A26400]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M06_L02
       test      esi,esi
       je        short M06_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       call      qword ptr [7FFD57A26418]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57A26448]
       mov       [rbp-44],eax
       jmp       short M06_L02
M06_L01:
       mov       ecx,46
       call      qword ptr [7FFD57A26430]
       int       3
M06_L02:
       call      M06_L46
       nop
M06_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M06_L24
       xor       eax,eax
       mov       [rbp-50],eax
M06_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M06_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M06_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M06_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M06_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M06_L07
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M06_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M06_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M06_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M06_L10
M06_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7FD8]; System.Threading.Thread.Sleep(Int32)
       jmp       short M06_L10
M06_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M06_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M06_L12
M06_L09:
       cmp       eax,400
       jge       near ptr M06_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M06_L40
M06_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M06_L42
       mov       ecx,[rbp-50]
       inc       ecx
M06_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M06_L04
M06_L12:
       mov       eax,ecx
       jmp       short M06_L09
M06_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M06_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M06_L19
M06_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M06_L18
M06_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M06_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD578BFCC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M06_L20
M06_L16:
       mov       edi,1
M06_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M06_L23
       jmp       short M06_L22
M06_L18:
       mov       rdx,7FFD57A4FAC8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L15
M06_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD57A26358]
       int       3
M06_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD578BFCD8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M06_L16
M06_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M06_L17
M06_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57A26460]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5750C720]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578BFD08]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M06_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M06_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M06_L30
M06_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57A263E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5750C720]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L27:
       mov       ecx,1
       call      qword ptr [7FFD573C7FD8]; System.Threading.Thread.Sleep(Int32)
M06_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M06_L45
       mov       ecx,[rbp-50]
       inc       ecx
M06_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M06_L26
M06_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M06_L34
       cmp       dword ptr [rbp-50],14
       jge       short M06_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M06_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M06_L33
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M06_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M06_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M06_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M06_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M06_L28
M06_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7FD8]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M06_L28
M06_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M06_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M06_L36
M06_L35:
       cmp       eax,400
       jge       near ptr M06_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M06_L28
       jmp       short M06_L43
M06_L36:
       mov       eax,ecx
       jmp       short M06_L35
M06_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD57A26358]
       int       3
M06_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD57A25200]
       int       3
M06_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD57A263E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5750C720]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L10
M06_L41:
       mov       ecx,eax
       call      qword ptr [7FFD57A269E8]
       jmp       near ptr M06_L10
M06_L42:
       mov       ecx,0A
       jmp       near ptr M06_L11
M06_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L44:
       mov       ecx,eax
       call      qword ptr [7FFD57A269E8]
       jmp       near ptr M06_L28
M06_L45:
       mov       ecx,0A
       jmp       near ptr M06_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD578BFC78]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD57A26478]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5750C720]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M06_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M06_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M06_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M06_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD570F0E40
       call      qword ptr [r11]
M06_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M06_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M06_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M06_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M06_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A80040]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M06_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M06_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M06_L51
M06_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M06_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M06_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M06_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578BFD08]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M06_L54
M06_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M06_L54
       mov       edx,1
       call      qword ptr [7FFD578BFD08]; System.Threading.SemaphoreSlim.Release(Int32)
M06_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1777
```
```assembly
; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       eax,eax
       mov       [rcx+8],rax
       mov       dword ptr [rcx+14],0FFFFFFFF
       ret
; Total bytes of code 14
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
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       jne       short M09_L02
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M09_L03
M09_L00:
       mov       rsi,[rbx+18]
       mov       rcx,rsi
       mov       edx,1
       mov       rdi,[rsi]
       mov       rax,[rdi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rdi],100000
       jne       short M09_L04
M09_L01:
       mov       byte ptr [rbx+38],1
M09_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       jmp       short M09_L00
M09_L04:
       mov       rcx,rsi
       call      00007FFDB6E00B60
       jmp       short M09_L01
; Total bytes of code 106
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M10_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M10_L01
       add       rsp,28
       ret
M10_L00:
       mov       ecx,707
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573CC060]
       mov       rcx,rax
       call      qword ptr [7FFD575CE340]
       int       3
M10_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L95
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577D1698]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L81
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L85
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L82
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L84
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD5797E8F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L83
M00_L08:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r12,[rbp-78]
       cmp       [r12],rcx
       jne       short M00_L11
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       jmp       short M00_L10
M00_L11:
       mov       r12,[rbp-78]
       cmp       [r12],r12d
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
M00_L13:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       short M00_L15
       mov       rcx,r12
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFD570F0D90
       call      qword ptr [r11]
       jmp       short M00_L14
       nop       dword ptr [rax+rax]
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       near ptr M00_L86
       xor       ecx,ecx
       mov       [r12+20],rcx
       mov       dword ptr [r12+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L80
       mov       rcx,129674027B0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L87
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L88
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L89
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L91
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L92
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       short M00_L22
       jmp       short M00_L23
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L75
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L51
       cmp       ecx,2
       jne       near ptr M00_L77
M00_L26:
       mov       rcx,[rbx+28]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       near ptr M00_L73
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L71
       mov       rsi,[rcx+8]
       mov       r14,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [r14+18],rcx
       jne       near ptr M00_L72
       test      rsi,rsi
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rdi+8]
M00_L29:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L65
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L76
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L62
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L34
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD5797E8F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L30:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L32
M00_L31:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L31
M00_L32:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L33
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L33:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L35
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L61
M00_L36:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L37:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L41
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L41
M00_L38:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L38
       jmp       near ptr M00_L45
M00_L39:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L44
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L40:
       test      rcx,rcx
       je        short M00_L41
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0DB0
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0DB8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L40
       nop       dword ptr [rax]
M00_L45:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L64
M00_L46:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L63
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L47:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD5789EC10]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
       jmp       near ptr M00_L65
M00_L48:
       cmp       qword ptr [rbx+28],0
       je        short M00_L50
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L74
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L49:
       xor       ecx,ecx
       mov       [rbx+28],rcx
M00_L50:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L77
M00_L51:
       mov       rcx,[rbx+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L70
       cmp       byte ptr [rcx+38],0
       jne       near ptr M00_L67
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L69
       mov       rcx,[rsi+8]
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       qword ptr [rbp-98],0
       je        short M00_L56
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFD5797E8F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L52:
       mov       dword ptr [rbp-48],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L54
M00_L53:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L53
M00_L54:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L55
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L55:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L57
M00_L56:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L68
M00_L58:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L59:
       lea       rcx,[rbx+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L60:
       mov       rcx,rdi
       mov       r11,7FFD570F0D70
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797DAE8]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFD570F0DC8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L64:
       call      M00_L96
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       je        near ptr M00_L47
M00_L65:
       call      qword ptr [7FFD5789E8B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFD57A44048]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD574F7F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFD5797FCF0]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5797DAE8]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFD570F0DF0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFD570F0DD8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFD570F0DE8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       r14,[rbx+20]
M00_L72:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L73:
       mov       r11,7FFD570F0DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFD570F0DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFD570F0D68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFD5797FCF0]
       int       3
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L94
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L93
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       mov       rcx,rdi
       call      qword ptr [7FFD5745D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-50]
       mov       rdx,7FFD579AAC78
       cmp       [rcx],ecx
       call      qword ptr [7FFD57976940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFD5759FEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
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
M00_L81:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rdi,rax
       call      qword ptr [7FFD5797FF48]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD579748D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFD5797FCF0]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797DAE8]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFD570F0DA0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFD570F0D88
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFD570F0D98
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,129674027A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,129674027B0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L88:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L89:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L90
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,12967402B10
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD5797FFC0]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD5797FFD8]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFD570F0D60
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFD570F0E00
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFD570F0D78
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFD5759FEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       ret
M00_L96:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L98
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L97
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L98
M00_L97:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0DC0
       call      qword ptr [r11]
M00_L98:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L100
       cmp       qword ptr [rbp-90],0
       jne       short M00_L99
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797DAE8]
M00_L100:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M00_L102
       cmp       qword ptr [rbp-98],0
       jne       short M00_L101
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5797DAE8]
M00_L102:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L107
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L106
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L105
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L103
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L104
M00_L103:
       mov       r11,7FFD570F0E00
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFD5745D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFD570F0D78
       call      qword ptr [r11]
M00_L107:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L109
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M00_L108
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],0FFFFFFFE
       jmp       short M00_L109
M00_L108:
       mov       rcx,rax
       mov       r11,7FFD570F0D98
       call      qword ptr [r11]
M00_L109:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L111
       cmp       qword ptr [rbp-80],0
       jne       short M00_L110
       xor       ecx,ecx
       call      qword ptr [7FFD5797D9F8]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797DAE8]
M00_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3858
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+38]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A18BD0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E970]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD5789E970]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD5797FCD8]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+38]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A18BD0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E970]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD5789E970]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 698
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
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M03_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       short M03_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M03_L08
M03_L01:
       cmp       ecx,5
       ja        short M03_L03
       mov       ecx,ecx
       lea       rdx,[7FFD5790E4A8]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L02:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        near ptr M03_L12
M03_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L14
       mov       ecx,[rcx+0A0]
M03_L04:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M03_L15
M03_L05:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M03_L03
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L07
M03_L06:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M03_L07:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L11
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M03_L08:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M03_L06
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M03_L09:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M03_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M03_L29
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M03_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M03_L10:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L11:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       near ptr M03_L02
M03_L12:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M03_L30
       mov       rcx,rdx
M03_L13:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5789ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       short M03_L10
M03_L14:
       mov       ecx,[rbx+2C]
       jmp       near ptr M03_L04
M03_L15:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M03_L20
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L19
M03_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L17
       mov       rcx,rdx
       jmp       short M03_L18
M03_L17:
       mov       rdx,7FFD57A184F0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M03_L10
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L19:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L16
       jmp       near ptr M03_L05
M03_L20:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L24
M03_L21:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L22
       mov       rcx,rdx
       jmp       short M03_L23
M03_L22:
       mov       rdx,7FFD57A184F0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L23:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M03_L10
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L24:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M03_L21
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L28
M03_L25:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L26
       mov       rcx,rdx
       jmp       short M03_L27
M03_L26:
       mov       rdx,7FFD57A184F0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L27:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M03_L10
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L28:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L25
       jmp       near ptr M03_L05
M03_L29:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5797FCD8]
       jmp       near ptr M03_L09
M03_L30:
       mov       rdx,7FFD57A184F0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L13
M03_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 868
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M06_L38
       cmp       qword ptr [rbp+28],0
       je        short M06_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M06_L37
M06_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M06_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M06_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M06_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5797FE70]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M06_L02
       test      esi,esi
       je        short M06_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       call      qword ptr [7FFD5797FE88]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5797FEB8]
       mov       [rbp-44],eax
       jmp       short M06_L02
M06_L01:
       mov       ecx,46
       call      qword ptr [7FFD5797FEA0]
       int       3
M06_L02:
       call      M06_L46
       nop
M06_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M06_L24
       xor       eax,eax
       mov       [rbp-50],eax
M06_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M06_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M06_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M06_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M06_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M06_L07
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M06_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M06_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M06_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M06_L10
M06_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       short M06_L10
M06_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M06_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M06_L12
M06_L09:
       cmp       eax,400
       jge       near ptr M06_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M06_L40
M06_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M06_L42
       mov       ecx,[rbp-50]
       inc       ecx
M06_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M06_L04
M06_L12:
       mov       eax,ecx
       jmp       short M06_L09
M06_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M06_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M06_L19
M06_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M06_L18
M06_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M06_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5789EC70]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M06_L20
M06_L16:
       mov       edi,1
M06_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M06_L23
       jmp       short M06_L22
M06_L18:
       mov       rdx,7FFD57A19BF8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L15
M06_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797FD08]
       int       3
M06_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD5789EC88]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M06_L16
M06_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M06_L17
M06_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FED0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECB8]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M06_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M06_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M06_L30
M06_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FE58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L27:
       mov       ecx,1
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
M06_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M06_L45
       mov       ecx,[rbp-50]
       inc       ecx
M06_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M06_L26
M06_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M06_L34
       cmp       dword ptr [rbp-50],14
       jge       short M06_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M06_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M06_L33
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M06_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M06_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M06_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M06_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M06_L28
M06_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M06_L28
M06_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M06_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M06_L36
M06_L35:
       cmp       eax,400
       jge       near ptr M06_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M06_L28
       jmp       short M06_L43
M06_L36:
       mov       eax,ecx
       jmp       short M06_L35
M06_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797FD08]
       int       3
M06_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD5797FCF0]
       int       3
M06_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FE58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L10
M06_L41:
       mov       ecx,eax
       call      qword ptr [7FFD5797FFA8]
       jmp       near ptr M06_L10
M06_L42:
       mov       ecx,0A
       jmp       near ptr M06_L11
M06_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L44:
       mov       ecx,eax
       call      qword ptr [7FFD5797FFA8]
       jmp       near ptr M06_L28
M06_L45:
       mov       ecx,0A
       jmp       near ptr M06_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5789EC28]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5797FEE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M06_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M06_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M06_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M06_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD570F0D40
       call      qword ptr [r11]
M06_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M06_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M06_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M06_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M06_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A31458]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M06_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M06_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M06_L51
M06_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M06_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M06_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M06_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECB8]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M06_L54
M06_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M06_L54
       mov       edx,1
       call      qword ptr [7FFD5789ECB8]; System.Threading.SemaphoreSlim.Release(Int32)
M06_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1778
```
```assembly
; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       eax,eax
       mov       [rcx+8],rax
       mov       dword ptr [rcx+14],0FFFFFFFF
       ret
; Total bytes of code 14
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
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       jne       short M09_L02
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M09_L03
M09_L00:
       mov       rsi,[rbx+18]
       mov       rcx,rsi
       mov       edx,1
       mov       rdi,[rsi]
       mov       rax,[rdi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rdi],100000
       jne       short M09_L04
M09_L01:
       mov       byte ptr [rbx+38],1
M09_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       jmp       short M09_L00
M09_L04:
       mov       rcx,rsi
       call      00007FFDB6E00B60
       jmp       short M09_L01
; Total bytes of code 106
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M10_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M10_L01
       add       rsp,28
       ret
M10_L00:
       mov       ecx,707
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rcx,rax
       call      qword ptr [7FFD5797D9F8]
       int       3
M10_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L95
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577D3D20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L81
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L85
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L82
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L84
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD5799E940]
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L83
M00_L08:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r12,[rbp-78]
       cmp       [r12],rcx
       jne       short M00_L11
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FFD57964958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       jmp       short M00_L10
M00_L11:
       mov       r12,[rbp-78]
       cmp       [r12],r12d
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
M00_L13:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       short M00_L15
       mov       rcx,r12
       call      qword ptr [7FFD57964958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFD57110D90
       call      qword ptr [r11]
       jmp       short M00_L14
       nop       dword ptr [rax+rax]
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       near ptr M00_L86
       xor       ecx,ecx
       mov       [r12+20],rcx
       mov       dword ptr [r12+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L80
       mov       rcx,1F81FC007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L87
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L88
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L89
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L91
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L92
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       short M00_L22
       jmp       short M00_L23
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L75
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L51
       cmp       ecx,2
       jne       near ptr M00_L77
M00_L26:
       mov       rcx,[rbx+28]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       near ptr M00_L73
       call      qword ptr [7FFD57964958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L71
       mov       rsi,[rcx+8]
       mov       r14,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [r14+18],rcx
       jne       near ptr M00_L72
       test      rsi,rsi
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rdi+8]
M00_L29:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L65
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L76
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L62
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L34
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD5799E940]
M00_L30:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L32
M00_L31:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L31
M00_L32:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L33
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L33:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L35
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L61
M00_L36:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L37:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L41
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L41
M00_L38:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57964958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFD57110DD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L38
       jmp       near ptr M00_L45
M00_L39:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L44
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L40:
       test      rcx,rcx
       je        short M00_L41
       mov       rdx,[rbp-70]
       mov       r11,7FFD57110DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57964958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57110DB0
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57110DB8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L40
       nop       dword ptr [rax]
M00_L45:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L64
M00_L46:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L63
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L47:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD578AE7F0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
       jmp       near ptr M00_L65
M00_L48:
       cmp       qword ptr [rbx+28],0
       je        short M00_L50
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L74
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L49:
       xor       ecx,ecx
       mov       [rbx+28],rcx
M00_L50:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L77
M00_L51:
       mov       rcx,[rbx+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L70
       cmp       byte ptr [rcx+38],0
       jne       near ptr M00_L67
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L69
       mov       rcx,[rsi+8]
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       qword ptr [rbp-98],0
       je        short M00_L56
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFD5799E940]
M00_L52:
       mov       dword ptr [rbp-48],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L54
M00_L53:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L53
M00_L54:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L55
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L55:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L57
M00_L56:
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L68
M00_L58:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L59:
       lea       rcx,[rbx+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L60:
       mov       rcx,rdi
       mov       r11,7FFD57110D70
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5799DB00]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFD57110DC8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57110DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L64:
       call      M00_L96
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       je        near ptr M00_L47
M00_L65:
       call      qword ptr [7FFD578AE490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFD57A64030]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFD57494F20
       call      qword ptr [7FFD573E77C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57517F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFD5799F960]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5799DB00]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFD57110DF0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFD57110DD8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFD57110DE8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       r14,[rbx+20]
M00_L72:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L73:
       mov       r11,7FFD57110DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFD57110DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFD57110D68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFD5799F960]
       int       3
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L94
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L93
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       mov       rcx,rdi
       call      qword ptr [7FFD5747D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-50]
       mov       rdx,7FFD579BD0C8
       cmp       [rcx],ecx
       call      qword ptr [7FFD57996538]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFD575BFEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
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
M00_L81:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E77C8]
       mov       rdi,rax
       call      qword ptr [7FFD5799FF18]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD579944B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFD5799F960]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5799DB00]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFD57110DA0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFD57110D88
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFD57110D98
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1F81FC007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,1F81FC007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L88:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L89:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L90
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F81FC00B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A64000]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A64018]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFD57110D60
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFD57110E00
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFD57110D78
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFD575BFEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       ret
M00_L96:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L98
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L97
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L98
M00_L97:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57110DC0
       call      qword ptr [r11]
M00_L98:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L100
       cmp       qword ptr [rbp-90],0
       jne       short M00_L99
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5799DB00]
M00_L100:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M00_L102
       cmp       qword ptr [rbp-98],0
       jne       short M00_L101
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5799DB00]
M00_L102:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L107
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L106
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L105
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L103
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L104
M00_L103:
       mov       r11,7FFD57110E00
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFD5747D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFD57110D78
       call      qword ptr [r11]
M00_L107:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L109
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M00_L108
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],0FFFFFFFE
       jmp       short M00_L109
M00_L108:
       mov       rcx,rax
       mov       r11,7FFD57110D98
       call      qword ptr [r11]
M00_L109:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L111
       cmp       qword ptr [rbp-80],0
       jne       short M00_L110
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA10]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5799DB00]
M00_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3858
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+38]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A29710
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578AE550]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD578AE550]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD5799F948]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+38]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A29710
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578AE550]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD578AE550]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 698
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M02_L04
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M02_L01:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       near ptr M02_L05
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M02_L02:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M02_L25
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M02_L03:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L04:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5791D4C8]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
M02_L05:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L26
M02_L06:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M02_L01
M02_L07:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        near ptr M02_L27
       jmp       near ptr M02_L30
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M02_L08
       mov       ecx,[rcx+0A0]
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rbx+2C]
M02_L09:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M02_L14
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M02_L15
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L13
M02_L10:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L11
       mov       rcx,rdx
       jmp       short M02_L12
M02_L11:
       mov       rdx,7FFD57A28F58
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L12:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578AE8C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L13:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L10
M02_L14:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L30
       jmp       near ptr M02_L24
M02_L15:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L19
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L17
       mov       rcx,rdx
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFD57A28F58
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578AE8C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L19:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M02_L16
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L23
M02_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L21
       mov       rcx,rdx
       jmp       short M02_L22
M02_L21:
       mov       rdx,7FFD57A28F58
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578AE8C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L23:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L20
       jmp       near ptr M02_L14
M02_L24:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M02_L06
       jmp       short M02_L26
M02_L25:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5799F948]
       jmp       near ptr M02_L02
M02_L26:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       near ptr M02_L07
M02_L27:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L28
       mov       rcx,rdx
       jmp       short M02_L29
M02_L28:
       mov       rdx,7FFD57A28F58
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L29:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD578AE8C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
       jmp       near ptr M02_L07
M02_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 901
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       qword ptr [rbp+28],0
       je        short M05_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M05_L37
M05_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M05_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M05_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5799FA38]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFD5799FA50]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5799FA80]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFD5799FA68]
       int       3
M05_L02:
       call      M05_L46
       nop
M05_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M05_L24
       xor       eax,eax
       mov       [rbp-50],eax
M05_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M05_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M05_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L07
       mov       rax,7FFD57201058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD57201078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L12
M05_L09:
       cmp       eax,400
       jge       near ptr M05_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M05_L40
M05_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L42
       mov       ecx,[rbp-50]
       inc       ecx
M05_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M05_L04
M05_L12:
       mov       eax,ecx
       jmp       short M05_L09
M05_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M05_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M05_L19
M05_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M05_L18
M05_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M05_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD578AE850]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M05_L20
M05_L16:
       mov       edi,1
M05_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M05_L23
       jmp       short M05_L22
M05_L18:
       mov       rdx,7FFD57A2A1C0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5799F978]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD578AE868]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M05_L16
M05_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M05_L17
M05_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FA98]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578AE898]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M05_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M05_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M05_L30
M05_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FA20]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
M05_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L45
       mov       ecx,[rbp-50]
       inc       ecx
M05_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M05_L26
M05_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L34
       cmp       dword ptr [rbp-50],14
       jge       short M05_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L33
       mov       rax,7FFD57201058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD57201078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L36
M05_L35:
       cmp       eax,400
       jge       near ptr M05_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5799F978]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD5799F960]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FA20]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFD5799FFA8]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFD5799FFA8]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD578AE808]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5799FAB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57517E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M05_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M05_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M05_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M05_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD57110D48
       call      qword ptr [r11]
M05_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M05_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A513A0]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
M05_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M05_L51
M05_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M05_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M05_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M05_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578AE898]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFD578AE898]; System.Threading.SemaphoreSlim.Release(Int32)
M05_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1778
```
```assembly
; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       eax,eax
       mov       [rcx+8],rax
       mov       dword ptr [rcx+14],0FFFFFFFF
       ret
; Total bytes of code 14
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
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       jne       short M08_L02
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M08_L03
M08_L00:
       mov       rsi,[rbx+18]
       mov       rcx,rsi
       mov       edx,1
       mov       rdi,[rsi]
       mov       rax,[rdi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rdi],100000
       jne       short M08_L04
M08_L01:
       mov       byte ptr [rbx+38],1
M08_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rsi
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
       jmp       short M08_L00
M08_L04:
       mov       rcx,rsi
       call      00007FFDB6E00B60
       jmp       short M08_L01
; Total bytes of code 106
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M09_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M09_L01
       add       rsp,28
       ret
M09_L00:
       mov       ecx,707
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E77C8]
       mov       rcx,rax
       call      qword ptr [7FFD5799DA10]
       int       3
M09_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFD571C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L96
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577D1698]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L84
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L88
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L85
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L87
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD5797E928]
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L86
M00_L08:
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L11
M00_L10:
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       mov       rcx,[rbp-78]
       jmp       short M00_L10
M00_L11:
       mov       rcx,[rbp-78]
       cmp       [rcx],ecx
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
       mov       rcx,[rbp-78]
M00_L13:
       cmp       [rcx],r12
       jne       short M00_L15
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       r11,7FFD570F0CC8
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       near ptr M00_L89
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L80
       mov       rcx,26F784007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L81
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD571A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L90
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L91
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD571A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L93
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L94
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M00_L82
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L75
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L51
       cmp       ecx,2
       jne       near ptr M00_L77
M00_L26:
       mov       rcx,[rbx+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       near ptr M00_L73
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,[rbx+28]
       cmp       [rcx],r12
       jne       near ptr M00_L71
       mov       r12,[rcx+8]
       mov       rsi,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L72
       test      r12,r12
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rdi+8]
M00_L29:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L65
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L76
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L62
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L34
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD5797E928]
M00_L30:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L32
M00_L31:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L31
M00_L32:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L33
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L33:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L35
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L61
M00_L36:
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L37:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L41
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L41
M00_L38:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0D08
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L38
       jmp       near ptr M00_L45
M00_L39:
       cmp       rbx,r12
       jne       short M00_L44
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L40:
       test      rcx,rcx
       je        short M00_L41
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F0D08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0CE8
       call      qword ptr [r11]
       jmp       short M00_L42
       nop       word ptr [rax+rax]
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0CF0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L40
       nop       dword ptr [rax]
M00_L45:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L64
M00_L46:
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       near ptr M00_L63
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L47:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD5789EC40]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
       jmp       near ptr M00_L65
M00_L48:
       cmp       qword ptr [rbx+28],0
       je        short M00_L50
       mov       rcx,[rbx+28]
       cmp       [rcx],r12
       jne       near ptr M00_L74
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L49:
       xor       ecx,ecx
       mov       [rbx+28],rcx
M00_L50:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
       jmp       near ptr M00_L77
M00_L51:
       mov       rcx,[rbx+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L70
       cmp       byte ptr [rcx+38],0
       jne       near ptr M00_L67
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L69
       mov       rcx,[rsi+8]
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       qword ptr [rbp-98],0
       je        short M00_L56
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFD5797E928]
M00_L52:
       mov       dword ptr [rbp-48],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L54
M00_L53:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L53
M00_L54:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L55
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L55:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L57
M00_L56:
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L68
M00_L58:
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L59:
       lea       rcx,[rbx+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L60:
       mov       rcx,rdi
       mov       r11,7FFD570F0CA8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797DB18]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFD570F0D00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0CF8
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L64:
       call      M00_L97
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       je        near ptr M00_L47
M00_L65:
       call      qword ptr [7FFD5789E8E0]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L66
       call      qword ptr [7FFD57A34048]
       mov       r12,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,24B5
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFD574F7F30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFD5797F960]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5797DB18]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFD570F0D28
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFD570F0D10
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFD570F0D20
       call      qword ptr [r11]
       mov       r12,rax
       mov       rsi,[rbx+20]
M00_L72:
       mov       rdx,r12
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L73:
       mov       r11,7FFD570F0D18
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFD570F0D30
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFD570F0CA0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFD5797F960]
       int       3
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L83
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       near ptr M00_L95
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       mov       rcx,rdi
       call      qword ptr [7FFD5745D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-50]
       mov       rdx,7FFD579AAC78
       cmp       [rcx],ecx
       call      qword ptr [7FFD57976970]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFD5759FEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
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
M00_L81:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,26F784007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,26F784007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L82:
       jmp       near ptr M00_L23
M00_L83:
       mov       rcx,rdi
       mov       r11,7FFD570F0CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L84:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rdi,rax
       call      qword ptr [7FFD5797FF78]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57974900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L85:
       mov       rcx,rbx
       call      qword ptr [7FFD5797F960]
       int       3
M00_L86:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797DB18]
       jmp       near ptr M00_L08
M00_L87:
       mov       rcx,rsi
       mov       r11,7FFD570F0CD8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L88:
       mov       rcx,rbx
       mov       r11,7FFD570F0CC0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L89:
       mov       r11,7FFD570F0CD0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L90:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L91:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L92
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26F78400B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A34018]
       jmp       near ptr M00_L21
M00_L93:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A34030]
       jmp       near ptr M00_L21
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFD570F0C98
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L95:
       mov       r11,7FFD570F0D38
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L96:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFD5759FEF0]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       ret
M00_L97:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L99
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L98
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L99
M00_L98:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F0CF8
       call      qword ptr [r11]
M00_L99:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L101
       cmp       qword ptr [rbp-90],0
       jne       short M00_L100
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L100:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L101
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797DB18]
M00_L101:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M00_L103
       cmp       qword ptr [rbp-98],0
       jne       short M00_L102
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L102:
       mov       rcx,[rbp-98]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L103
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFD5797DB18]
M00_L103:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L108
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L107
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L106
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       short M00_L104
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L105
M00_L104:
       mov       r11,7FFD570F0D38
       call      qword ptr [r11]
M00_L105:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L106:
       mov       rcx,rdi
       call      qword ptr [7FFD5745D2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L108
M00_L107:
       mov       rcx,rdi
       mov       r11,7FFD570F0CB0
       call      qword ptr [r11]
M00_L108:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L110
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L109
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L110
M00_L109:
       mov       r11,7FFD570F0CD0
       call      qword ptr [r11]
M00_L110:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L112
       cmp       qword ptr [rbp-80],0
       jne       short M00_L111
       xor       ecx,ecx
       call      qword ptr [7FFD5797DA28]
       int       3
M00_L111:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L112
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797DB18]
M00_L112:
       nop
       add       rsp,28
       ret
; Total bytes of code 3831
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+38]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A18B30
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD5797F948]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+38]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A18B30
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 698
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M02_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M02_L01:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jl        short M02_L03
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L25
M02_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       short M02_L01
M02_L03:
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M02_L04:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M02_L24
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M02_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5790CF30]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M02_L07
       mov       ecx,[rcx+0A0]
       jmp       short M02_L08
M02_L07:
       mov       ecx,[rbx+2C]
M02_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M02_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M02_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L12
M02_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L10
       mov       rcx,rdx
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FFD57A17A08
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L09
M02_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L30
       jmp       near ptr M02_L23
M02_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L18
M02_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L16
       mov       rcx,rdx
       jmp       short M02_L17
M02_L16:
       mov       rdx,7FFD57A17A08
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M02_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L22
M02_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L20
       mov       rcx,rdx
       jmp       short M02_L21
M02_L20:
       mov       rdx,7FFD57A17A08
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L19
       jmp       near ptr M02_L13
M02_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M02_L02
       jmp       short M02_L25
M02_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5797F948]
       jmp       near ptr M02_L04
M02_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L29
M02_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L27
       mov       rcx,rdx
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FFD57A17A08
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M02_L26
M02_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       qword ptr [rbp+28],0
       je        short M05_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M05_L37
M05_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M05_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M05_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5797FAE0]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFD5797FAF8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5797FB28]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFD5797FB10]
       int       3
M05_L02:
       call      M05_L46
       nop
M05_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M05_L24
       xor       eax,eax
       mov       [rbp-50],eax
M05_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M05_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M05_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L07
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L12
M05_L09:
       cmp       eax,400
       jge       near ptr M05_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M05_L40
M05_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L42
       mov       ecx,[rbp-50]
       inc       ecx
M05_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M05_L04
M05_L12:
       mov       eax,ecx
       jmp       short M05_L09
M05_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M05_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M05_L19
M05_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M05_L18
M05_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M05_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5789ECA0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M05_L20
M05_L16:
       mov       edi,1
M05_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M05_L23
       jmp       short M05_L22
M05_L18:
       mov       rdx,7FFD57A19110
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797F978]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD5789ECB8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M05_L16
M05_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M05_L17
M05_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FB40]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M05_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M05_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M05_L30
M05_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
M05_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L45
       mov       ecx,[rbp-50]
       inc       ecx
M05_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M05_L26
M05_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L34
       cmp       dword ptr [rbp-50],14
       jge       short M05_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L33
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L36
M05_L35:
       cmp       eax,400
       jge       near ptr M05_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797F978]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD5797F960]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797FAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFD5797FFC0]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFD5797FFC0]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5789EC58]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5797FB58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M05_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M05_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M05_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M05_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD570F0C78
       call      qword ptr [r11]
M05_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M05_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A2F260]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M05_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M05_L51
M05_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M05_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M05_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M05_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
M05_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1778
```
```assembly
; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       eax,eax
       mov       [rcx+8],rax
       mov       dword ptr [rcx+14],0FFFFFFFF
       ret
; Total bytes of code 14
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
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       jne       short M08_L02
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M08_L03
M08_L00:
       mov       rsi,[rbx+18]
       mov       rcx,rsi
       mov       edx,1
       mov       rdi,[rsi]
       mov       rax,[rdi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rdi],100000
       jne       short M08_L04
M08_L01:
       mov       byte ptr [rbx+38],1
M08_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
       jmp       short M08_L00
M08_L04:
       mov       rcx,rsi
       call      00007FFDB6E00B60
       jmp       short M08_L01
; Total bytes of code 106
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M09_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M09_L01
       add       rsp,28
       ret
M09_L00:
       mov       ecx,707
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rcx,rax
       call      qword ptr [7FFD5797DA28]
       int       3
M09_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L85
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577F1710]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L65
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L70
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L67
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L69
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD5799E970]
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA40]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L68
M00_L08:
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L11
M00_L10:
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       mov       rcx,[rbp-78]
       jmp       short M00_L10
M00_L11:
       mov       rcx,[rbp-78]
       cmp       [rcx],ecx
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
       mov       rcx,[rbp-78]
M00_L13:
       cmp       [rcx],r12
       jne       short M00_L15
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       r11,7FFD57110FE8
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       near ptr M00_L71
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L66
       mov       rcx,29A54C007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L82
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L72
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L73
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L75
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L84
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M00_L83
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L63
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L57
       cmp       ecx,2
       jne       near ptr M00_L56
M00_L26:
       mov       rcx,[rbx+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       near ptr M00_L60
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,[rbx+28]
       cmp       [rcx],r12
       jne       near ptr M00_L58
       mov       r12,[rcx+8]
       mov       rsi,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L59
       test      r12,r12
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L29:
       mov       rbx,[rdi+8]
M00_L30:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L49
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L64
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L53
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L35
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L31
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD5799E970]
M00_L31:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L33
M00_L32:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L32
M00_L33:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L34
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L34:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L36
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA40]
       int       3
M00_L36:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L52
M00_L37:
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L38:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        near ptr M00_L42
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L42
M00_L39:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L39
       mov       rdx,[rbp-70]
       mov       r11,7FFD57111028
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L39
       jmp       near ptr M00_L46
M00_L40:
       cmp       rbx,r12
       jne       short M00_L45
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L41:
       test      rcx,rcx
       je        short M00_L42
       mov       rdx,[rbp-70]
       mov       r11,7FFD57111028
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L46
M00_L42:
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L44
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L43:
       test      eax,eax
       jne       short M00_L40
       jmp       short M00_L47
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57111008
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L45:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57111010
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L41
M00_L46:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L55
M00_L47:
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       near ptr M00_L54
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L48:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD578BEC40]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
M00_L49:
       call      qword ptr [7FFD5799F138]
       mov       rcx,rax
       mov       r8,29A3EC01E60
       mov       r8,[r8]
       mov       rdx,2DAD3AA19F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L50
       call      qword ptr [7FFD5799F138]
       mov       rcx,rax
       mov       r8,29A3EC01E60
       mov       r8,[r8]
       mov       rdx,2DAD3AA1A60
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r12,rax
M00_L50:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,24B5
       mov       rdx,7FFD57494F20
       call      qword ptr [7FFD573E77C8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFD57517F30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L29
       mov       rcx,rdi
       mov       r11,7FFD57110FC8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L52:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5799DB30]
       jmp       near ptr M00_L37
M00_L53:
       mov       rcx,rbx
       mov       r11,7FFD57111020
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L38
M00_L54:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57111018
       call      qword ptr [r11]
       jmp       near ptr M00_L48
M00_L55:
       call      M00_L91
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       jne       near ptr M00_L49
       jmp       near ptr M00_L48
M00_L56:
       xor       ebx,ebx
       jmp       short M00_L62
M00_L57:
       mov       rcx,[rbx+18]
       mov       r11,7FFD57111030
       call      qword ptr [r11]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L58:
       mov       r11,7FFD57111040
       call      qword ptr [r11]
       mov       r12,rax
       mov       rsi,[rbx+20]
M00_L59:
       mov       rdx,r12
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L60:
       mov       r11,7FFD57111038
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L61:
       mov       rcx,rbx
       call      qword ptr [7FFD57569200]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L56
M00_L62:
       test      ebx,ebx
       jne       near ptr M00_L51
       jmp       near ptr M00_L76
M00_L63:
       mov       rcx,rdi
       mov       r11,7FFD57110FC0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M00_L62
M00_L64:
       mov       rcx,r8
       call      qword ptr [7FFD5799F120]
       int       3
M00_L65:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E77C8]
       mov       rdi,rax
       call      qword ptr [7FFD57A64078]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57994900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L66:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       jmp       near ptr M00_L81
M00_L67:
       mov       rcx,rbx
       call      qword ptr [7FFD5799F120]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5799DB30]
       jmp       near ptr M00_L08
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFD57110FF8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L70:
       mov       rcx,rbx
       mov       r11,7FFD57110FE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L71:
       mov       r11,7FFD57110FF0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L72:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L73:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L74
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29A54C00B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L74:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A640C0]
       jmp       near ptr M00_L21
M00_L75:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A640D8]
       jmp       near ptr M00_L21
M00_L76:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       short M00_L80
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       short M00_L77
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L78
M00_L77:
       mov       r11,7FFD57111048
       call      qword ptr [r11]
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L66
M00_L80:
       mov       rcx,rdi
       mov       r11,7FFD57110FD0
       call      qword ptr [r11]
       jmp       near ptr M00_L66
M00_L81:
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       call      M00_L86
       nop
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
M00_L82:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,29A54C007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,29A54C007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L83:
       jmp       near ptr M00_L23
M00_L84:
       mov       rcx,rdi
       mov       r11,7FFD57110FB8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L86:
       sub       rsp,28
       mov       rcx,[rbp-58]
       cmp       byte ptr [rcx+38],0
       jne       short M00_L89
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M00_L87
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rbx
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
M00_L87:
       mov       rcx,[rbp-58]
       mov       rbx,[rcx+18]
       mov       rcx,rbx
       mov       edx,1
       mov       rsi,[rbx]
       mov       rax,[rsi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rsi],100000
       je        short M00_L88
       mov       rcx,rbx
       call      00007FFDB6E00B60
M00_L88:
       mov       rcx,[rbp-58]
       mov       byte ptr [rcx+38],1
M00_L89:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L90
       call      00007FFDB6E00B60
M00_L90:
       nop
       add       rsp,28
       ret
M00_L91:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L93
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L92
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L93
M00_L92:
       mov       rcx,[rbp-88]
       mov       r11,7FFD57111018
       call      qword ptr [r11]
M00_L93:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L95
       cmp       qword ptr [rbp-90],0
       jne       short M00_L94
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA40]
       int       3
M00_L94:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L95
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5799DB30]
M00_L95:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L100
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L99
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L98
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       short M00_L96
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L97
M00_L96:
       mov       r11,7FFD57111048
       call      qword ptr [r11]
M00_L97:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L98:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L100
M00_L99:
       mov       rcx,rdi
       mov       r11,7FFD57110FD0
       call      qword ptr [r11]
M00_L100:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L102
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L101
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L102
M00_L101:
       mov       r11,7FFD57110FF0
       call      qword ptr [r11]
M00_L102:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L104
       cmp       qword ptr [rbp-80],0
       jne       short M00_L103
       xor       ecx,ecx
       call      qword ptr [7FFD5799DA40]
       int       3
M00_L103:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L104
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5799DB30]
M00_L104:
       nop
       add       rsp,28
       ret
; Total bytes of code 3509
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+40]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A39520
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578BE9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD578BE9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD5799FC90]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+40]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A39520
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD578BE9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD578BE9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571C6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 698
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M02_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       short M02_L03
M02_L01:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L25
M02_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M02_L03:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jge       short M02_L01
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M02_L04:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M02_L24
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M02_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5792C670]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M02_L07
       mov       ecx,[rcx+0A0]
       jmp       short M02_L08
M02_L07:
       mov       ecx,[rbx+2C]
M02_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M02_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M02_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L12
M02_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L10
       mov       rcx,rdx
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FFD57A38E78
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L09
M02_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L30
       jmp       near ptr M02_L23
M02_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L18
M02_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L16
       mov       rcx,rdx
       jmp       short M02_L17
M02_L16:
       mov       rdx,7FFD57A38E78
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M02_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L22
M02_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L20
       mov       rcx,rdx
       jmp       short M02_L21
M02_L20:
       mov       rdx,7FFD57A38E78
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L19
       jmp       near ptr M02_L13
M02_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M02_L02
       jmp       short M02_L25
M02_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5799FC90]
       jmp       near ptr M02_L04
M02_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L29
M02_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L27
       mov       rcx,rdx
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FFD57A38E78
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M02_L26
M02_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       qword ptr [rbp+28],0
       je        short M05_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M05_L37
M05_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M05_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M05_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5799FD68]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFD5799FD80]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5799FDB0]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFD5799FD98]
       int       3
M05_L02:
       call      M05_L46
       nop
M05_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M05_L24
       xor       eax,eax
       mov       [rbp-50],eax
M05_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M05_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M05_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L07
       mov       rax,7FFD57201058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD57201078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L12
M05_L09:
       cmp       eax,400
       jge       near ptr M05_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M05_L40
M05_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L42
       mov       ecx,[rbp-50]
       inc       ecx
M05_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M05_L04
M05_L12:
       mov       eax,ecx
       jmp       short M05_L09
M05_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M05_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M05_L19
M05_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+38]
       test      r11,r11
       je        short M05_L18
M05_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M05_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD578BECA0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M05_L20
M05_L16:
       mov       edi,1
M05_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M05_L23
       jmp       short M05_L22
M05_L18:
       mov       rdx,7FFD57A39ED8
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5799FCA8]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD578BECB8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M05_L16
M05_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M05_L17
M05_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FDC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578BECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M05_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M05_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M05_L30
M05_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FD50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
M05_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L45
       mov       ecx,[rbp-50]
       inc       ecx
M05_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M05_L26
M05_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L34
       cmp       dword ptr [rbp-50],14
       jge       short M05_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L33
       mov       rax,7FFD57201058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD57201078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573E7750]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L36
M05_L35:
       cmp       eax,400
       jge       near ptr M05_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5799FCA8]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD5799F120]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5799FD50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD57517E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFD5799FF00]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFD5799FF00]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD578BEC58]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5799FDE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57517E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M05_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M05_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M05_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M05_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD57110CB0
       call      qword ptr [r11]
M05_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M05_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A4E1B0]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571C7B28]; System.GC.SuppressFinalize(System.Object)
M05_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M05_L51
M05_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M05_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M05_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M05_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD578BECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFD578BECE8]; System.Threading.SemaphoreSlim.Release(Int32)
M05_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1778
```
```assembly
; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M06_L01
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M06_L02
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M06_L00:
       xor       eax,eax
       mov       [rbx+28],rax
M06_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L02:
       mov       r11,7FFD57111100
       call      qword ptr [r11]
       jmp       short M06_L00
; Total bytes of code 86
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
       jmp       qword ptr [7FFD571C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M08_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M08_L01
       add       rsp,28
       ret
M08_L00:
       mov       ecx,707
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E77C8]
       mov       rcx,rax
       call      qword ptr [7FFD5799DA40]
       int       3
M08_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2E8]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1F
       xor       ecx,ecx
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L01
M00_L00:
       mov       rdx,[rdi+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M00_L84
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M00_L00
M00_L01:
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFD577D1710]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edi,eax
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       dword ptr [rax+30],0FFFFFFFF
       mov       byte ptr [rax+38],0
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.CancellationTokenSource
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-60]
       lea       rcx,[r8+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rbp-60]
       mov       [r8+10],rcx
       mov       rcx,offset MT_System.Threading.SemaphoreSlim
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      edi,edi
       jl        near ptr M00_L64
       mov       dword ptr [rsi+2C],7FFFFFFF
       mov       [rsi+28],edi
       mov       rcx,offset MT_System.Runtime.CompilerServices.StrongBox<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-60]
       lea       rcx,[r8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L69
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L66
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L68
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD5797E808]
M00_L02:
       mov       dword ptr [rbp-3C],1
       mov       r14,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,r14
       mov       byte ptr [r14+1C],1
       cmp       r14,rsi
       je        short M00_L04
M00_L03:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L03
M00_L04:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L05
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L05:
       mov       r15d,[r14+60]
       mov       r13d,[rsi+0A0]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D908]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L67
M00_L08:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       xor       ecx,ecx
       mov       [r12+28],ecx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+30],r15d
       lea       rcx,[r12+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+2C],r13d
M00_L09:
       mov       [rbp-78],r12
       cmp       qword ptr [rbp-78],0
       je        short M00_L11
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r12,[rbp-78]
       cmp       [r12],rcx
       jne       short M00_L11
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L17
       add       rdi,1
       jo        short M00_L16
       jmp       short M00_L10
M00_L11:
       mov       r12,[rbp-78]
       cmp       [r12],r12d
       jmp       short M00_L13
M00_L12:
       add       rdi,1
       jo        short M00_L16
M00_L13:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       short M00_L15
       mov       rcx,r12
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFD570F1030
       call      qword ptr [r11]
       jmp       short M00_L14
       nop       word ptr [rax+rax]
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r12],rcx
       jne       near ptr M00_L70
       xor       ecx,ecx
       mov       [r12+20],rcx
       mov       dword ptr [r12+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L65
       mov       rcx,1BAAF8007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L81
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L71
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L72
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L74
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L21:
       mov       rax,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L83
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M00_L82
M00_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rdi+18]
       mov       rdi,[rdi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+10],eax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,rbx
M00_L23:
       mov       dword ptr [rdi+14],1
M00_L24:
       mov       [rbp-68],rdi
M00_L25:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       rbx,rdi
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M00_L56
       cmp       ecx,2
       jne       near ptr M00_L55
M00_L26:
       mov       rcx,[rbx+28]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       near ptr M00_L59
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L27:
       test      eax,eax
       je        near ptr M00_L60
       mov       rcx,[rbx+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L57
       mov       rsi,[rcx+8]
       mov       r14,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       cmp       [r14+18],rcx
       jne       near ptr M00_L58
       test      rsi,rsi
       je        short M00_L26
M00_L28:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L29:
       mov       rbx,[rdi+8]
M00_L30:
       mov       [rbp-70],rbx
       test      rbx,rbx
       je        near ptr M00_L49
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       r8,[rbp-60]
       cmp       byte ptr [r8+38],0
       jne       near ptr M00_L63
       mov       rbx,[r8+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],rcx
       jne       near ptr M00_L53
       mov       rcx,[rbx+8]
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-90],0
       je        short M00_L35
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L31
       mov       rcx,[rbp-90]
       call      qword ptr [7FFD5797E808]
M00_L31:
       mov       dword ptr [rbp-44],1
       mov       rsi,[rbx+18]
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       mov       byte ptr [rsi+1C],1
       cmp       rsi,rbx
       je        short M00_L33
M00_L32:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rbx
       jne       short M00_L32
M00_L33:
       cmp       byte ptr [rbx+1D],0
       jne       short M00_L34
       mov       byte ptr [rbx+1D],1
       lea       rcx,[rbx+0A0]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L34:
       mov       r14d,[rsi+60]
       mov       r15d,[rbx+0A0]
       jmp       short M00_L36
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D908]
       int       3
M00_L36:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L52
M00_L37:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L38:
       mov       [rbp-88],r13
       cmp       qword ptr [rbp-88],0
       je        short M00_L41
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L41
M00_L39:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L39
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F1070
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L39
M00_L40:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L46
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L44
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L45
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
M00_L43:
       test      rcx,rcx
       je        short M00_L41
       mov       rdx,[rbp-70]
       mov       r11,7FFD570F1070
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L41
       jmp       short M00_L40
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F1050
       call      qword ptr [r11]
       jmp       short M00_L42
M00_L45:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F1058
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L43
M00_L46:
       call      M00_L90
       nop
       mov       ecx,[rbp-40]
       test      ecx,ecx
       mov       rdi,[rbp-68]
       jne       short M00_L49
       jmp       short M00_L48
M00_L47:
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       near ptr M00_L54
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L48:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFD5789EC40]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
M00_L49:
       call      qword ptr [7FFD5797FDC8]
       mov       rcx,rax
       mov       r8,1BA99801E60
       mov       r8,[r8]
       mov       rdx,1FB2E7319F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L50
       call      qword ptr [7FFD5797FDC8]
       mov       rcx,rax
       mov       r8,1BA99801E60
       mov       r8,[r8]
       mov       rdx,1FB2E731A60
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
M00_L50:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD574F7F30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L29
       mov       rcx,rdi
       mov       r11,7FFD570F1010
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L52:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797D9F8]
       jmp       near ptr M00_L37
M00_L53:
       mov       rcx,rbx
       mov       r11,7FFD570F1068
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L38
M00_L54:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F1060
       call      qword ptr [r11]
       jmp       near ptr M00_L48
M00_L55:
       xor       ebx,ebx
       jmp       short M00_L61
M00_L56:
       mov       rcx,[rbx+18]
       mov       r11,7FFD570F1078
       call      qword ptr [r11]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L57:
       mov       r11,7FFD570F1088
       call      qword ptr [r11]
       mov       rsi,rax
       mov       r14,[rbx+20]
M00_L58:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L26
       jmp       near ptr M00_L28
M00_L59:
       mov       r11,7FFD570F1080
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L60:
       mov       rcx,rbx
       call      qword ptr [7FFD57549200]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L55
M00_L61:
       test      ebx,ebx
       jne       near ptr M00_L51
       jmp       near ptr M00_L75
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFD570F1008
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M00_L61
M00_L63:
       mov       rcx,r8
       call      qword ptr [7FFD5797F840]
       int       3
M00_L64:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rdi,rax
       call      qword ptr [7FFD57A441B0]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57974900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L65:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       jmp       near ptr M00_L80
M00_L66:
       mov       rcx,rbx
       call      qword ptr [7FFD5797F840]
       int       3
M00_L67:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797D9F8]
       jmp       near ptr M00_L08
M00_L68:
       mov       rcx,rsi
       mov       r11,7FFD570F1040
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L69:
       mov       rcx,rbx
       mov       r11,7FFD570F1028
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L70:
       mov       rcx,r12
       mov       r11,7FFD570F1038
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L71:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L72:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L73
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BAAF800B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L73:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A441E0]
       jmp       near ptr M00_L21
M00_L74:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFD57A441F8]
       jmp       near ptr M00_L21
M00_L75:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       short M00_L79
       cmp       qword ptr [rdi+28],0
       je        short M00_L78
       mov       rcx,[rdi+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L76
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L77
M00_L76:
       mov       r11,7FFD570F1090
       call      qword ptr [r11]
M00_L77:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L78:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L65
M00_L79:
       mov       rcx,rdi
       mov       r11,7FFD570F1018
       call      qword ptr [r11]
       jmp       near ptr M00_L65
M00_L80:
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       call      M00_L85
       nop
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
M00_L81:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1BAAF8007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,1BAAF8007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L82:
       jmp       near ptr M00_L23
M00_L83:
       mov       rcx,rdi
       mov       r11,7FFD570F1000
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L84:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L85:
       sub       rsp,28
       mov       rcx,[rbp-58]
       cmp       byte ptr [rcx+38],0
       jne       short M00_L88
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M00_L86
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rbx
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M00_L86:
       mov       rcx,[rbp-58]
       mov       rbx,[rcx+18]
       mov       rcx,rbx
       mov       edx,1
       mov       rsi,[rbx]
       mov       rax,[rsi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rsi],100000
       je        short M00_L87
       mov       rcx,rbx
       call      00007FFDB6E00B60
M00_L87:
       mov       rcx,[rbp-58]
       mov       byte ptr [rcx+38],1
M00_L88:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L89
       call      00007FFDB6E00B60
M00_L89:
       nop
       add       rsp,28
       ret
M00_L90:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L92
       mov       rcx,[rbp-88]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L91
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L92
M00_L91:
       mov       rcx,[rbp-88]
       mov       r11,7FFD570F1060
       call      qword ptr [r11]
M00_L92:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L94
       cmp       qword ptr [rbp-90],0
       jne       short M00_L93
       xor       ecx,ecx
       call      qword ptr [7FFD5797D908]
       int       3
M00_L93:
       mov       rcx,[rbp-90]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L94
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFD5797D9F8]
M00_L94:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L99
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       jne       short M00_L98
       mov       rcx,[rdi+28]
       test      rcx,rcx
       je        short M00_L97
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L95
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L96
M00_L95:
       mov       r11,7FFD570F1090
       call      qword ptr [r11]
M00_L96:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L97:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       short M00_L99
M00_L98:
       mov       rcx,rdi
       mov       r11,7FFD570F1018
       call      qword ptr [r11]
M00_L99:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L101
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       short M00_L100
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],0FFFFFFFE
       jmp       short M00_L101
M00_L100:
       mov       rcx,rax
       mov       r11,7FFD570F1038
       call      qword ptr [r11]
M00_L101:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L103
       cmp       qword ptr [rbp-80],0
       jne       short M00_L102
       xor       ecx,ecx
       call      qword ptr [7FFD5797D908]
       int       3
M00_L102:
       mov       rcx,[rbp-80]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L103
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFD5797D9F8]
M00_L103:
       nop
       add       rsp,28
       ret
; Total bytes of code 3535
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-48],edx
M01_L00:
       mov       rbx,[rcx+18]
       mov       rsi,[rcx+10]
       mov       edi,[rbx+60]
       mov       r14d,[rbx+0A0]
       cmp       rbx,rsi
       jne       short M01_L05
       cmp       rsi,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rsi+60]
       jne       near ptr M01_L12
       cmp       r14d,[rsi+0A0]
       jne       near ptr M01_L12
       cmp       edi,r14d
       je        short M01_L01
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       mov       edx,r14d
       sub       edx,eax
       cmp       edx,edi
       jne       short M01_L03
M01_L01:
       xor       eax,eax
M01_L02:
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
M01_L03:
       mov       eax,[rsi+18]
       and       edi,eax
       and       eax,r14d
       cmp       edi,eax
       jge       short M01_L04
       sub       eax,edi
       jmp       short M01_L02
M01_L04:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       sub       edx,edi
       add       eax,edx
       jmp       short M01_L02
M01_L05:
       cmp       [rbx+10],rsi
       jne       short M01_L06
       mov       r15d,[rsi+60]
       mov       r13d,[rsi+0A0]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L12
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L12
       cmp       edi,[rbx+60]
       jne       near ptr M01_L12
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L12
       cmp       r15d,[rsi+60]
       jne       near ptr M01_L12
       cmp       r13d,[rsi+0A0]
       jne       near ptr M01_L12
       jmp       near ptr M01_L13
M01_L06:
       mov       rdx,[rcx+8]
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+18]
       jne       near ptr M01_L11
       cmp       rsi,[rcx+10]
       jne       near ptr M01_L11
       mov       r12d,[rsi+60]
       mov       r15d,[rsi+0A0]
       cmp       edi,[rbx+60]
       jne       near ptr M01_L11
       cmp       r14d,[rbx+0A0]
       jne       near ptr M01_L11
       cmp       r12d,[rsi+60]
       jne       near ptr M01_L11
       cmp       r15d,[rsi+0A0]
       jne       near ptr M01_L11
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r13,[rax+40]
       test      r13,r13
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FFD57A197A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,edi
       mov       rcx,[rbx+10]
       cmp       rcx,rsi
       je        short M01_L10
M01_L09:
       mov       edx,[rcx+0A0]
       mov       r8,[rcx+8]
       mov       r8d,[r8+8]
       add       r8d,r8d
       sub       edx,r8d
       add       eax,edx
       mov       rcx,[rcx+10]
       cmp       rcx,rsi
       jne       short M01_L09
M01_L10:
       mov       [rbp-54],eax
       jmp       near ptr M01_L16
M01_L11:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rbp-50],0
       je        short M01_L12
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFD5797F828]
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
M01_L13:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r12,[rax+40]
       test      r12,r12
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdx
       mov       rdx,7FFD57A197A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFD5789E9A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       add       eax,ebx
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
M01_L16:
       call      M01_L17
       nop
       mov       eax,[rbp-54]
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
M01_L17:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L18
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD571A6820]; System.Threading.Monitor.Exit(System.Object)
M01_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 698
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M02_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       short M02_L03
M02_L01:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L25
M02_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M02_L03:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jge       short M02_L01
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M02_L04:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M02_L24
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M02_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L06:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5790B550]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M02_L07
       mov       ecx,[rcx+0A0]
       jmp       short M02_L08
M02_L07:
       mov       ecx,[rbx+2C]
M02_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M02_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M02_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L12
M02_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L10
       mov       rcx,rdx
       jmp       short M02_L11
M02_L10:
       mov       rdx,7FFD57A17CE0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L09
M02_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L30
       jmp       near ptr M02_L23
M02_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L18
M02_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L16
       mov       rcx,rdx
       jmp       short M02_L17
M02_L16:
       mov       rdx,7FFD57A17CE0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M02_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L22
M02_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L20
       mov       rcx,rdx
       jmp       short M02_L21
M02_L20:
       mov       rdx,7FFD57A17CE0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L19
       jmp       near ptr M02_L13
M02_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M02_L02
       jmp       short M02_L25
M02_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5797F828]
       jmp       near ptr M02_L04
M02_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L29
M02_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L27
       mov       rcx,rdx
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FFD57A17CE0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M02_L26
M02_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
; 			foreach (var item in collection.Where(p => p is not null))
; 			                                           ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-60],rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       qword ptr [rbp+28],0
       je        short M05_L00
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M05_L37
M05_L00:
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L38
       cmp       dword ptr [rbx+34],80000000
       je        near ptr M05_L39
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rbx+10],0
       je        short M05_L03
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFD5797F918]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFD5797F930]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5797F960]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFD5797F948]
       int       3
M05_L02:
       call      M05_L46
       nop
M05_L03:
       cmp       dword ptr [rbp-44],0
       je        near ptr M05_L24
       xor       eax,eax
       mov       [rbp-50],eax
M05_L04:
       mov       rbx,[rbp+10]
       mov       eax,[rbx+34]
       mov       [rbp-58],eax
       test      eax,80000000
       jne       near ptr M05_L25
       lea       rdx,[rbx+34]
       lea       ecx,[rax+1]
       lock cmpxchg [rdx],ecx
       cmp       eax,[rbp-58]
       je        near ptr M05_L13
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L08
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L08
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L07
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L06
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L09
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L12
M05_L09:
       cmp       eax,400
       jge       near ptr M05_L41
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       jne       near ptr M05_L40
M05_L10:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L42
       mov       ecx,[rbp-50]
       inc       ecx
M05_L11:
       mov       [rbp-50],ecx
       jmp       near ptr M05_L04
M05_L12:
       mov       eax,ecx
       jmp       short M05_L09
M05_L13:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       qword ptr [rbp+28],0
       je        short M05_L14
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+20],0
       jne       short M05_L19
M05_L14:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M05_L18
M05_L15:
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       short M05_L21
       mov       rcx,[rsi+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD5789ECA0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M05_L20
M05_L16:
       mov       edi,1
M05_L17:
       mov       [rbp-54],edi
       test      edi,edi
       jne       short M05_L23
       jmp       short M05_L22
M05_L18:
       mov       rdx,7FFD57A185D0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797F858]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD5789ECB8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
       jmp       short M05_L16
M05_L21:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M05_L17
M05_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797F978]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
M05_L24:
       mov       rbx,[rbp+10]
       mov       eax,[rbp-44]
       movzx     eax,al
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
M05_L25:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       dword ptr [rbx+34],80000000
       jne       short M05_L30
M05_L26:
       mov       rbx,[rbp+10]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
M05_L28:
       cmp       dword ptr [rbp-50],7FFFFFFF
       je        near ptr M05_L45
       mov       ecx,[rbp-50]
       inc       ecx
M05_L29:
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       cmp       dword ptr [rbx+34],80000000
       je        short M05_L26
M05_L30:
       cmp       dword ptr [rbp-50],0A
       jl        near ptr M05_L34
       cmp       dword ptr [rbp-50],14
       jge       short M05_L27
       mov       ecx,[rbp-50]
       add       ecx,0FFFFFFF6
       test      cl,1
       jne       near ptr M05_L34
       mov       r8d,ecx
       shr       r8d,1F
       add       ecx,r8d
       sar       ecx,1
       mov       edx,66666667
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       eax,edx
       lea       eax,[rax+rax*4]
       sub       ecx,eax
       cmp       ecx,4
       je        short M05_L33
       mov       rax,7FFD571E1058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFD571E1078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M05_L32
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFD573C7750]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFDB6E41CE0
       cmp       dword ptr [rbp-50],1E
       jg        short M05_L35
       mov       ecx,[rbp-50]
       mov       edx,1
       shlx      ecx,edx,ecx
       cmp       ecx,eax
       jl        short M05_L36
M05_L35:
       cmp       eax,400
       jge       near ptr M05_L44
       mov       ecx,eax
       mov       rax,7FFDB6D903E0
       call      rax
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5797F858]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD5797F840]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5797F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFD5797FA80]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFD5797FA80]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD5789EC58]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5797F990]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD574F7E88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L46:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M05_L52
       mov       rcx,[rbp-0A0]
       mov       rdx,offset MT_System.Threading.CancellationTokenSource
       cmp       [rcx],rdx
       jne       near ptr M05_L50
       mov       rcx,[rbp-0A0]
       cmp       byte ptr [rcx+24],0
       jne       near ptr M05_L51
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M05_L47
       mov       r11,[rbp-0A0]
       xor       eax,eax
       mov       [r11+8],rax
       mov       r11,7FFD570F0C08
       call      qword ptr [r11]
M05_L47:
       mov       rcx,[rbp-0A0]
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+10],0
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       add       rcx,10
       xor       edx,edx
       mov       rbx,rdx
       xchg      rbx,[rcx]
       test      rbx,rbx
       je        short M05_L49
       mov       rcx,[rbp-0A0]
       cmp       dword ptr [rcx+20],1
       je        short M05_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L48
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFD57A2BF90]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFD571A7B28]; System.GC.SuppressFinalize(System.Object)
M05_L49:
       mov       rcx,[rbp-0A0]
       mov       byte ptr [rcx+24],1
       jmp       short M05_L51
M05_L50:
       mov       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,[rbp-0A0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L51:
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx]
       test      dword ptr [rcx],100000
       je        short M05_L52
       mov       rcx,[rbp-0A0]
       call      00007FFDB6E00B60
M05_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-54],0
       je        short M05_L53
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFD5789ECE8]; System.Threading.SemaphoreSlim.Release(Int32)
M05_L54:
       lea       rcx,[rbx+34]
       lock dec  dword ptr [rcx]
       add       rsp,28
       ret
; Total bytes of code 1778
```
```assembly
; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M06_L01
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M06_L02
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M06_L00:
       xor       eax,eax
       mov       [rbx+28],rax
M06_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L02:
       mov       r11,7FFD570F0FF0
       call      qword ptr [r11]
       jmp       short M06_L00
; Total bytes of code 86
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
       jmp       qword ptr [7FFD571A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M08_L00
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       jne       short M08_L01
       add       rsp,28
       ret
M08_L00:
       mov       ecx,707
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C77C8]
       mov       rcx,rax
       call      qword ptr [7FFD5797D908]
       int       3
M08_L01:
       add       rsp,28
       jmp       near ptr 00007FFDB6E00B60
; Total bytes of code 65
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD575F0530]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clone()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFD57A764B0
       call      qword ptr [7FFD579CF8B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       call      M00_L00
       nop
       mov       rcx,7FFD57AD2FB4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbp
       ret
M00_L00:
       sub       rsp,28
       cmp       qword ptr [rbp-8],0
       je        short M00_L01
       mov       rcx,7FFD57AD2EA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFD57AD2EA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       r11,7FFD571213B0
       call      qword ptr [r11]
M00_L01:
       mov       rcx,7FFD57AD2FB0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 204
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
       mov       rdx,7FFD57A69210
       call      qword ptr [7FFD573F7B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD579CFD20]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD579CFCD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD575F0530]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clone()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFD57B0A0D0
       call      qword ptr [7FFD579EFDB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       call      M00_L00
       nop
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       sub       rsp,28
       cmp       qword ptr [rbp-8],0
       je        short M00_L01
       mov       rcx,[rbp-8]
       mov       r11,7FFD57120FA0
       call      qword ptr [r11]
M00_L01:
       nop
       add       rsp,28
       ret
; Total bytes of code 114
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
       mov       rdx,7FFD57B14950
       call      qword ptr [7FFD573F7B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD57B24330]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57B242E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       test      rbx,rbx
       je        near ptr M00_L29
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L18
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L26
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD5799E7C0]
M00_L00:
       mov       dword ptr [rbp-34],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD5799D890]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L25
M00_L06:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L12
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r13,[rbp-40]
       cmp       [r13],rcx
       jne       near ptr M00_L12
M00_L08:
       mov       rcx,r13
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD57110E28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       jmp       near ptr M00_L15
M00_L09:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r13],rcx
       jne       short M00_L13
       mov       rcx,r13
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r13],rcx
       jne       short M00_L14
       mov       rcx,[r13+8]
M00_L11:
       test      rcx,rcx
       je        short M00_L09
       mov       rdx,rbx
       mov       r11,7FFD57110E28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       jmp       short M00_L15
M00_L12:
       mov       r13,[rbp-40]
       cmp       [r13],r13d
       jmp       short M00_L09
M00_L13:
       mov       rcx,r13
       mov       r11,7FFD57110E08
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFD57110E10
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L11
M00_L15:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r13],rcx
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
M00_L16:
       mov       ebx,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,rax
       call      qword ptr [7FFD571CC9F0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L19
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L22
M00_L19:
       mov       rcx,rax
       call      qword ptr [7FFD571C7C78]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M00_L20:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       je        short M00_L23
M00_L21:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD57A643C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rsi,rbx
       jmp       short M00_L20
M00_L23:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFD57334B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L24
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFD57334B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       xor       ebx,ebx
       jmp       short M00_L21
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5799D980]
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFD57110E20
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       call      M00_L30
       jmp       short M00_L29
M00_L28:
       mov       rcx,r13
       mov       r11,7FFD57110E18
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L30:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L32
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       r13,[rbp-40]
       cmp       [r13],rcx
       jne       short M00_L31
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
       jmp       short M00_L32
M00_L31:
       mov       rcx,r13
       mov       r11,7FFD57110E18
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L34
       cmp       qword ptr [rbp-48],0
       jne       short M00_L33
       xor       ecx,ecx
       call      qword ptr [7FFD5799D890]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5799D980]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 909
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M01_L04
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M01_L01:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       near ptr M01_L07
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L02:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L30
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L27
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L30
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L03:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       cmp       ecx,5
       ja        near ptr M01_L29
       mov       ecx,ecx
       lea       rdx,[7FFD5792F458]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L12
       mov       ecx,[rcx+0A0]
M01_L05:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M01_L13
M01_L06:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L29
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        short M01_L09
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M01_L01
M01_L09:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
M01_L10:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jge       near ptr M01_L29
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L28
       mov       rcx,rdx
M01_L11:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD578BECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L03
M01_L12:
       mov       ecx,[rbx+2C]
       jmp       near ptr M01_L05
M01_L13:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M01_L18
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L17
M01_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L15
       mov       rcx,rdx
       jmp       short M01_L16
M01_L15:
       mov       rdx,7FFD57A38198
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L17:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L14
       jmp       near ptr M01_L06
M01_L18:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L20
       mov       rcx,rdx
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FFD57A38198
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L22:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L19
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L26
M01_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L24
       mov       rcx,rdx
       jmp       short M01_L25
M01_L24:
       mov       rdx,7FFD57A38198
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L25:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L26:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L23
       jmp       near ptr M01_L06
M01_L27:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5799F7F8]
       jmp       near ptr M01_L02
M01_L28:
       mov       rdx,7FFD57A38198
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L11
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
       jmp       near ptr M01_L10
M01_L29:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 882
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFD571C5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD57301B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M03_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD57A65AE8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5799F780]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD571C7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M04_L07
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L03
M04_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       test      rbx,rbx
       je        near ptr M00_L29
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L18
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L26
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD5797E7C0]
M00_L00:
       mov       dword ptr [rbp-34],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D8C0]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L25
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L12
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L12
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD570F0CA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       jmp       short M00_L15
M00_L09:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L13
       mov       rcx,rsi
       call      qword ptr [7FFD57952460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L27
       cmp       [rsi],r13
       jne       short M00_L14
       mov       rcx,[rsi+8]
M00_L11:
       test      rcx,rcx
       je        short M00_L09
       mov       rdx,rbx
       mov       r11,7FFD570F0CA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       jmp       short M00_L15
M00_L12:
       mov       rsi,[rbp-40]
       cmp       [rsi],esi
       jmp       short M00_L09
M00_L13:
       mov       rcx,rsi
       mov       r11,7FFD570F0C80
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFD570F0C88
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L11
M00_L15:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
M00_L16:
       mov       ebx,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,rax
       call      qword ptr [7FFD571AC9F0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L19
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L22
M00_L19:
       mov       rcx,rax
       call      qword ptr [7FFD571A7C78]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M00_L20:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       je        short M00_L23
M00_L21:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD5797F8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rsi,rbx
       jmp       short M00_L20
M00_L23:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFD57314B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L24
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFD57314B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       xor       ebx,ebx
       jmp       short M00_L21
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5797D9B0]
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFD570F0C98
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       call      M00_L30
       jmp       short M00_L29
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD570F0C90
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L29:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L30:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L32
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L31
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
       jmp       short M00_L32
M00_L31:
       mov       rcx,rsi
       mov       r11,7FFD570F0C90
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L34
       cmp       qword ptr [rbp-48],0
       jne       short M00_L33
       xor       ecx,ecx
       call      qword ptr [7FFD5797D8C0]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5797D9B0]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 886
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M01_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M01_L01:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M01_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L02:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L03:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M01_L25
M01_L05:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M01_L01
M01_L06:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5790B9D0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M01_L07
       mov       ecx,[rcx+0A0]
       jmp       short M01_L08
M01_L07:
       mov       ecx,[rbx+2C]
M01_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M01_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M01_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L12
M01_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L10
       mov       rcx,rdx
       jmp       short M01_L11
M01_L10:
       mov       rdx,7FFD57A18228
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L09
M01_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       jmp       near ptr M01_L23
M01_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L18
M01_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L16
       mov       rcx,rdx
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFD57A18228
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L20
       mov       rcx,rdx
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FFD57A18228
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L19
       jmp       near ptr M01_L13
M01_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M01_L05
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5797F828]
       jmp       near ptr M01_L02
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD57A18228
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5789ED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 879
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFD571A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD572E1B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M03_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD57A45980]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5797F7B0]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD571A7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M04_L07
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L03
M04_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       test      rbx,rbx
       je        near ptr M00_L19
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L28
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD5799E790]
M00_L00:
       mov       dword ptr [rbp-34],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD5799D8C0]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L12
       mov       r13,[rbp-40]
       mov       rsi,[r13]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rdi,rcx
       cmp       rsi,rdi
       jne       short M00_L12
M00_L08:
       mov       rcx,r13
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD57110C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       jmp       short M00_L15
M00_L09:
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       short M00_L13
       mov       rcx,r13
       call      qword ptr [7FFD57972460]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L10:
       test      eax,eax
       je        near ptr M00_L18
       cmp       rsi,rdi
       jne       short M00_L14
       mov       rcx,[r13+8]
M00_L11:
       test      rcx,rcx
       je        short M00_L09
       mov       rdx,rbx
       mov       r11,7FFD57110C98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
       jmp       short M00_L15
M00_L12:
       mov       r13,[rbp-40]
       cmp       [r13],r13d
       jmp       short M00_L09
M00_L13:
       mov       rcx,r13
       mov       r11,7FFD57110C78
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFD57110C80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L11
M00_L15:
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       near ptr M00_L29
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
M00_L16:
       mov       ebx,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       call      M00_L30
       nop
M00_L19:
       xor       ebx,ebx
       jmp       short M00_L17
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFD571CC9F0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L21
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L24
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFD571C7C78]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M00_L22:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       je        short M00_L25
M00_L23:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFD5799F900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       mov       rsi,rbx
       jmp       short M00_L22
M00_L25:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFD57334B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L26
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFD57334B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L23
M00_L26:
       xor       ebx,ebx
       jmp       short M00_L23
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5799D9B0]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD57110C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rcx,r13
       mov       r11,7FFD57110C88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
M00_L30:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L32
       mov       r13,[rbp-40]
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       short M00_L31
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
       jmp       short M00_L32
M00_L31:
       mov       rcx,r13
       mov       r11,7FFD57110C88
       call      qword ptr [r11]
M00_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L34
       cmp       qword ptr [rbp-48],0
       jne       short M00_L33
       xor       ecx,ecx
       call      qword ptr [7FFD5799D8C0]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5799D9B0]
M00_L34:
       nop
       add       rsp,28
       ret
; Total bytes of code 905
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       short M01_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M01_L06
M01_L01:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5792BC20]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L09
       mov       ecx,[rcx+0A0]
M01_L02:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M01_L10
M01_L03:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L25
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M01_L06:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M01_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L07:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L08:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,[rbx+2C]
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M01_L15
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L14
M01_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L12
       mov       rcx,rdx
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFD57A38418
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L13:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L14:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L11
       jmp       near ptr M01_L03
M01_L15:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L19
M01_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L17
       mov       rcx,rdx
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFD57A38418
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L19:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L16
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L23
M01_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L21
       mov       rcx,rdx
       jmp       short M01_L22
M01_L21:
       mov       rdx,7FFD57A38418
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L23:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L20
       jmp       near ptr M01_L03
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5799F840]
       jmp       near ptr M01_L07
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD57A38418
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD578BED18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 864
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFD571C5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD57301B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M03_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD57A65848]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5799F7C8]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD571C7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M04_L07
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L03
M04_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-34],edx
       test      rbx,rbx
       je        near ptr M00_L18
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L27
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-38],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD57977D50]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L00:
       mov       dword ptr [rbp-38],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD57977D98]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L26
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L13
       mov       r13,[rbp-40]
       mov       rsi,[r13]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rdi,rcx
       cmp       rsi,rdi
       jne       short M00_L13
M00_L08:
       mov       rcx,r13
       call      qword ptr [7FFD5788DC60]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD57100B98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
M00_L09:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L16
M00_L10:
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       short M00_L14
       mov       rcx,r13
       call      qword ptr [7FFD5788DC60]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L11:
       test      eax,eax
       je        short M00_L17
       cmp       rsi,rdi
       jne       short M00_L15
       mov       rcx,[r13+8]
M00_L12:
       test      rcx,rcx
       je        short M00_L10
       mov       rdx,rbx
       mov       r11,7FFD57100B98
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L09
M00_L13:
       mov       r13,[rbp-40]
       cmp       [r13],r13d
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFD57100B78
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       mov       rcx,r13
       mov       r11,7FFD57100B80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L12
M00_L16:
       call      M00_L29
       nop
       mov       ebx,[rbp-34]
       jmp       short M00_L19
M00_L17:
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
M00_L18:
       xor       ebx,ebx
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFD571BC9F0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M00_L23
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M00_L23
M00_L21:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        short M00_L24
M00_L22:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD57977FD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFD571B7C78]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFD57324B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFD57324B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD57977D80]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFD57100B90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,r13
       mov       r11,7FFD57100B88
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L29:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L31
       mov       r13,[rbp-40]
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       short M00_L30
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
       jmp       short M00_L31
M00_L30:
       mov       rcx,r13
       mov       r11,7FFD57100B88
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L33
       cmp       qword ptr [rbp-48],0
       jne       short M00_L32
       xor       ecx,ecx
       call      qword ptr [7FFD57977D98]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD57977D80]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 906
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
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M02_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       short M02_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M02_L06
M02_L01:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFD578B0C20]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L09
       mov       ecx,[rcx+0A0]
M02_L02:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M02_L10
M02_L03:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L30
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M02_L05:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        near ptr M02_L25
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M02_L06:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M02_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M02_L07:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M02_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M02_L08:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       ecx,[rbx+2C]
       jmp       near ptr M02_L02
M02_L10:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M02_L15
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L14
M02_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L12
       mov       rcx,rdx
       jmp       short M02_L13
M02_L12:
       mov       rdx,7FFD5794CD68
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L13:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57877060]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L14:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L11
       jmp       near ptr M02_L03
M02_L15:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M02_L19
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L17
       mov       rcx,rdx
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFD5794CD68
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57877060]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L19:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M02_L16
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L23
M02_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L21
       mov       rcx,rdx
       jmp       short M02_L22
M02_L21:
       mov       rdx,7FFD5794CD68
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57877060]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L23:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M02_L20
       jmp       near ptr M02_L03
M02_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD57977F18]
       jmp       near ptr M02_L07
M02_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M02_L29
M02_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L27
       mov       rcx,rdx
       jmp       short M02_L28
M02_L27:
       mov       rdx,7FFD5794CD68
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD57877060]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M02_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M02_L26
M02_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 864
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFD571B5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M03_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L08
M04_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M04_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M04_L09
M04_L01:
       test      rdi,rdi
       jne       near ptr M04_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M04_L10
M04_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M04_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD572F1B50
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M04_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M04_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M04_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M04_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M04_L11
M04_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M04_L07:
       mov       rax,rdi
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
M04_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD5797FCD8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5797DD58]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD571B7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M04_L02
M04_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M05_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M05_L00:
       test      eax,eax
       jne       short M05_L02
       cmp       rsi,rdi
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M05_L01:
       test      eax,eax
       jne       short M05_L07
M05_L02:
       cmp       rsi,rdi
       jne       short M05_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M05_L07
M05_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M05_L00
M05_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M05_L01
M05_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L03
M05_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-34],edx
       test      rbx,rbx
       je        near ptr M00_L18
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L27
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-38],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD5796E7F0]
M00_L00:
       mov       dword ptr [rbp-38],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD5796D8C0]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L26
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L13
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L13
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFD57941E88]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD570E0CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
M00_L09:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L16
M00_L10:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L14
       mov       rcx,rsi
       call      qword ptr [7FFD57941E88]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L11:
       test      eax,eax
       je        short M00_L17
       cmp       [rsi],r13
       jne       short M00_L15
       mov       rcx,[rsi+8]
M00_L12:
       test      rcx,rcx
       je        short M00_L10
       mov       rdx,rbx
       mov       r11,7FFD570E0CC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L09
M00_L13:
       mov       rsi,[rbp-40]
       cmp       [rsi],esi
       jmp       short M00_L10
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFD570E0CA8
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFD570E0CB0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L12
M00_L16:
       call      M00_L29
       nop
       mov       ebx,[rbp-34]
       jmp       short M00_L19
M00_L17:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
M00_L18:
       xor       ebx,ebx
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFD5719C9F0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M00_L23
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M00_L23
M00_L21:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        short M00_L24
M00_L22:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5796F888]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFD57197C78]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFD57304B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFD57304B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5796D9B0]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFD570E0CC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD570E0CB8
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L29:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L31
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L30
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
       jmp       short M00_L31
M00_L30:
       mov       rcx,rsi
       mov       r11,7FFD570E0CB8
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L33
       cmp       qword ptr [rbp-48],0
       jne       short M00_L32
       xor       ecx,ecx
       call      qword ptr [7FFD5796D8C0]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5796D9B0]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 883
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M01_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M01_L01:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M01_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L02:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L03:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M01_L25
M01_L05:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M01_L01
M01_L06:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD578FBCD0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M01_L07
       mov       ecx,[rcx+0A0]
       jmp       short M01_L08
M01_L07:
       mov       ecx,[rbx+2C]
M01_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M01_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M01_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L12
M01_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L10
       mov       rcx,rdx
       jmp       short M01_L11
M01_L10:
       mov       rdx,7FFD57A08470
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5788ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L09
M01_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       jmp       near ptr M01_L23
M01_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L18
M01_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L16
       mov       rcx,rdx
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFD57A08470
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5788ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L20
       mov       rcx,rdx
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FFD57A08470
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5788ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L19
       jmp       near ptr M01_L13
M01_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M01_L05
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5796F840]
       jmp       near ptr M01_L02
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD57A08470
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5788ECE8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 879
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFD57195C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD572D1B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M03_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD57A25848]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5796F7C8]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD57197CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M04_L07
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L03
M04_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-34],edx
       test      rbx,rbx
       je        near ptr M00_L18
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L27
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-38],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD5797E778]
M00_L00:
       mov       dword ptr [rbp-38],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD5797D8D8]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L26
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L13
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L13
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFD57952FC0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD570F0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
M00_L09:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L16
M00_L10:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L14
       mov       rcx,rsi
       call      qword ptr [7FFD57952FC0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L11:
       test      eax,eax
       je        short M00_L17
       cmp       [rsi],r13
       jne       short M00_L15
       mov       rcx,[rsi+8]
M00_L12:
       test      rcx,rcx
       je        short M00_L10
       mov       rdx,rbx
       mov       r11,7FFD570F0CC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       jmp       short M00_L09
M00_L13:
       mov       rsi,[rbp-40]
       cmp       [rsi],esi
       jmp       short M00_L10
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFD570F0CA0
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFD570F0CA8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L12
M00_L16:
       call      M00_L29
       nop
       mov       ebx,[rbp-34]
       jmp       short M00_L19
M00_L17:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
M00_L18:
       xor       ebx,ebx
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFD571AC9F0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M00_L23
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M00_L23
M00_L21:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        short M00_L24
M00_L22:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5797F918]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFD571A7C78]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFD57314B28]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFD57314B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5797D9C8]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFD570F0CB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFD570F0CB0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L29:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L31
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L30
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
       jmp       short M00_L31
M00_L30:
       mov       rcx,rsi
       mov       r11,7FFD570F0CB0
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L33
       cmp       qword ptr [rbp-48],0
       jne       short M00_L32
       xor       ecx,ecx
       call      qword ptr [7FFD5797D8D8]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD5797D9C8]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 883
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       short M01_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M01_L06
M01_L01:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5790C020]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L09
       mov       ecx,[rcx+0A0]
M01_L02:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M01_L10
M01_L03:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
       mov       rcx,[rbx+20]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L25
       mov       edx,[rcx+0A0]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       mov       [rbx+38],edx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M01_L06:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M01_L04
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L07:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L08:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,[rbx+2C]
       jmp       near ptr M01_L02
M01_L10:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       short M01_L15
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L14
M01_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L12
       mov       rcx,rdx
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFD57A091A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L13:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789EE38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L14:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L11
       jmp       near ptr M01_L03
M01_L15:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L19
M01_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L17
       mov       rcx,rdx
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFD57A091A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789EE38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L19:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L16
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L23
M01_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L21
       mov       rcx,rdx
       jmp       short M01_L22
M01_L21:
       mov       rdx,7FFD57A091A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD5789EE38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L23:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L20
       jmp       near ptr M01_L03
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD5797F7F8]
       jmp       near ptr M01_L07
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD57A091A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD5789EE38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 864
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFD571A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFD572E1B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFDB6CCA0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M03_L04
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFDB6E0EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFD57A55860]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFD5797F858]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFD571A7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFD9C9ABEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFD9C9AB7A8]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M04_L07
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L00
M04_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M04_L01
M04_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L03
M04_L07:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFD9C9AB1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD9C998FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-34],edx
       test      rbx,rbx
       je        near ptr M00_L18
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L22
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-38],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD57995FC8]
M00_L00:
       mov       dword ptr [rbp-38],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD578AE700]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L21
M00_L06:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L07:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        short M00_L10
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L10
M00_L08:
       mov       rcx,rsi
       call      qword ptr [7FFD5798D670]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFD57100F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
M00_L09:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L16
M00_L10:
       mov       rsi,[rbp-40]
       cmp       [rsi],esi
M00_L11:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L14
       mov       rcx,rsi
       call      qword ptr [7FFD5798D670]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L12:
       test      eax,eax
       je        short M00_L17
       cmp       [rsi],r13
       jne       short M00_L15
       mov       rcx,[rsi+8]
M00_L13:
       test      rcx,rcx
       je        short M00_L11
       mov       rdx,rbx
       mov       r11,7FFD57100F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L11
       jmp       short M00_L09
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFD57100F08
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFD57100F10
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L13
M00_L16:
       call      M00_L24
       nop
       mov       ebx,[rbp-34]
       jmp       short M00_L19
M00_L17:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L23
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
M00_L18:
       xor       ebx,ebx
M00_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFD57997C78]
       int       3
M00_L21:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD578AF630]
       jmp       near ptr M00_L06
M00_L22:
       mov       rcx,rsi
       mov       r11,7FFD57100F20
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFD57100F18
       call      qword ptr [r11]
       jmp       short M00_L18
M00_L24:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L26
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L25
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
       jmp       short M00_L26
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFD57100F18
       call      qword ptr [r11]
M00_L26:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L28
       cmp       qword ptr [rbp-48],0
       jne       short M00_L27
       xor       ecx,ecx
       call      qword ptr [7FFD578AE700]
       int       3
M00_L27:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L28
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD578AF630]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 750
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M01_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       short M01_L03
M01_L01:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M01_L25
M01_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M01_L03:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jge       short M01_L01
       mov       rdi,[rbx+20]
       lea       ebp,[rsi+1]
       and       ebp,[rdi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,esi
       shl       r14,4
M01_L04:
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rdi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rdi+8]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5793FBF0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M01_L07
       mov       ecx,[rcx+0A0]
       jmp       short M01_L08
M01_L07:
       mov       ecx,[rbx+2C]
M01_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M01_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M01_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L12
M01_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L10
       mov       rcx,rdx
       jmp       short M01_L11
M01_L10:
       mov       rdx,7FFD579FF448
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57994E40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L09
M01_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       jmp       near ptr M01_L23
M01_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L18
M01_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L16
       mov       rcx,rdx
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFD579FF448
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57994E40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L20
       mov       rcx,rdx
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FFD579FF448
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD57994E40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L19
       jmp       near ptr M01_L13
M01_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M01_L02
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD57997C60]
       jmp       near ptr M01_L04
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD579FF448
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD57994E40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Contains()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp+10],rcx
       mov       rax,[rcx+2E8]
       mov       rbx,[rcx+218]
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-34],edx
       test      rbx,rbx
       je        near ptr M00_L19
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L21
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L23
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-38],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFDB6E4E120
       test      eax,eax
       je        short M00_L05
M00_L00:
       mov       dword ptr [rbp-38],1
       mov       rdi,[rsi+18]
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       mov       byte ptr [rdi+1C],1
       cmp       rdi,rsi
       je        short M00_L02
M00_L01:
       mov       rcx,[rcx+10]
       mov       byte ptr [rcx+1C],1
       cmp       rcx,rsi
       jne       short M00_L01
M00_L02:
       cmp       byte ptr [rsi+1D],0
       jne       short M00_L03
       mov       byte ptr [rsi+1D],1
       lea       rcx,[rsi+0A0]
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       lock add  [rcx],eax
M00_L03:
       mov       r14d,[rdi+60]
       mov       r15d,[rsi+0A0]
       jmp       short M00_L06
M00_L04:
       xor       ecx,ecx
       call      qword ptr [7FFD578A6298]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFD578A75D0]
       jmp       short M00_L00
M00_L06:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       jne       near ptr M00_L22
M00_L07:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+28],ecx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+30],r14d
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+2C],r15d
M00_L08:
       mov       [rbp-40],r13
       cmp       qword ptr [rbp-40],0
       je        short M00_L11
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L11
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFD57A0A2A8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L09
       mov       rdx,rbx
       mov       r11,7FFD57101080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L09
M00_L10:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L17
M00_L11:
       mov       rsi,[rbp-40]
       cmp       [rsi],esi
M00_L12:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L15
       mov       rcx,rsi
       call      qword ptr [7FFD57A0A2A8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L13:
       test      eax,eax
       je        short M00_L18
       cmp       [rsi],r13
       jne       short M00_L16
       mov       rcx,[rsi+8]
M00_L14:
       test      rcx,rcx
       je        short M00_L12
       mov       rdx,rbx
       mov       r11,7FFD57101080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L12
       jmp       short M00_L10
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFD57101060
       call      qword ptr [r11]
       jmp       short M00_L13
M00_L16:
       mov       rcx,rsi
       mov       r11,7FFD57101068
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L14
M00_L17:
       call      M00_L25
       nop
       mov       ebx,[rbp-34]
       jmp       short M00_L20
M00_L18:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L24
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
M00_L19:
       xor       ebx,ebx
M00_L20:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+90]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFD579CC180]
       int       3
M00_L22:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD578A6388]
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFD57101078
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L08
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFD57101070
       call      qword ptr [r11]
       jmp       short M00_L19
M00_L25:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L27
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rsi,[rbp-40]
       cmp       [rsi],r13
       jne       short M00_L26
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       dword ptr [rsi+28],0FFFFFFFE
       jmp       short M00_L27
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFD57101070
       call      qword ptr [r11]
M00_L27:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       jne       short M00_L28
       xor       ecx,ecx
       call      qword ptr [7FFD578A6298]
       int       3
M00_L28:
       mov       rcx,[rbp-48]
       call      00007FFDB6E4E040
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFD578A6388]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 752
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
M01_L00:
       mov       ecx,[rbx+28]
       cmp       ecx,4
       jne       near ptr M01_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       short M01_L03
M01_L01:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M01_L25
M01_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M01_L03:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jge       short M01_L01
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M01_L04:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M01_L24
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M01_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       cmp       ecx,5
       ja        near ptr M01_L30
       mov       ecx,ecx
       lea       rdx,[7FFD5796AFB0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M01_L07
       mov       ecx,[rcx+0A0]
       jmp       short M01_L08
M01_L07:
       mov       ecx,[rbx+2C]
M01_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M01_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M01_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L12
M01_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L10
       mov       rcx,rdx
       jmp       short M01_L11
M01_L10:
       mov       rdx,7FFD57A246F0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD579C7288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L09
M01_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L30
       jmp       near ptr M01_L23
M01_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M01_L18
M01_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L16
       mov       rcx,rdx
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFD57A246F0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD579C7288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M01_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L22
M01_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L20
       mov       rcx,rdx
       jmp       short M01_L21
M01_L20:
       mov       rdx,7FFD57A246F0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFD579C7288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L19
       jmp       near ptr M01_L13
M01_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M01_L02
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFD579CC168]
       jmp       near ptr M01_L04
M01_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M01_L29
M01_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L27
       mov       rcx,rdx
       jmp       short M01_L28
M01_L27:
       mov       rdx,7FFD57A246F0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFD579C7288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M01_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M01_L26
M01_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD579868E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD575063E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD578AF8A0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578CB360
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578CB530
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5799A6E0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573DDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5798D188]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5798D1A0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578CB530
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57986940]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD575063E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD578AF900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578CB360
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578CB530
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5799A6E0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573DDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5798D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5798D188]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578CB530
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578CB320
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57986868]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD575063E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD578AF900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578CB380
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578CB3C0
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578CB590
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5799A5F8
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573DDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57484F20
       call      qword ptr [7FFD573D77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571B7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5798D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5798D188]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578CB380
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578CB590
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578CB380
       call      qword ptr [7FFD571BC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57976838]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD574F63E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD5789F8D0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578BB320
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578BB360
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578BB530
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5798A5F8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573CDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5797D860]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5797D878]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578BB320
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578BB530
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578BB320
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57976958]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD574F63E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD5789F900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578BB340
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578BB380
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578BB550
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5798A6E0
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573CDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5797D1A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5797D1B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578BB340
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578BB550
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578BB340
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2E8]
       mov       rdx,[rbx+2F0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57966958]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L05
M01_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax+18]
       test      rbp,rbp
       je        near ptr M01_L10
M01_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       r14,[rcx+20]
       test      r14,r14
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L07
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       call      qword ptr [7FFD574E63E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       [r15+18],rcx
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L08
M01_L04:
       mov       rdx,rbx
       mov       r8,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD5788F900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFD578AB3D0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFD578AB410
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFD578AB5E0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFD5797A6E0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFD573BDF08]
       mov       ecx,2A41
       mov       rdx,7FFD57464F20
       call      qword ptr [7FFD573B77C8]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57464F20
       call      qword ptr [7FFD573B77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57197888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD57464F20
       call      qword ptr [7FFD573B77C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57197888]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5796D158]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD5796D170]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFD578AB3D0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbp,rax
M01_L12:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       mov       rdx,7FFD578AB5E0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD57196BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFD578AB3D0
       call      qword ptr [7FFD5719C5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       jmp       near ptr M01_L01
; Total bytes of code 653
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+2F0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD579AF990]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD579AF978]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       sub       rsp,130
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-88],rax
       mov       rax,[rbp-88]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+48]
       mov       [rbp-90],rax
       cmp       qword ptr [rbp-90],0
       je        short M01_L00
       mov       rax,[rbp-90]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp-88]
       mov       rdx,7FFD57A4A170
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rax,2681F6A1A70
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2681F690008
       call      qword ptr [7FFD573EDED8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0A0],rax
       cmp       qword ptr [rbp-0A0],0
       je        short M01_L02
       mov       rax,[rbp-0A0]
       mov       [rbp-18],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-98]
       mov       rdx,7FFD579882A0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+18]
       mov       [rbp-20],rax
       mov       rax,[rbp+18]
       mov       [rbp-28],rax
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-20],0
       jne       near ptr M01_L10
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rax,[rbp-0A8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0B0],rax
       cmp       qword ptr [rbp-0B0],0
       je        short M01_L04
       mov       rax,[rbp-0B0]
       mov       [rbp-60],rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp-0A8]
       mov       rdx,7FFD579882A0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-60],rax
M01_L05:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+38]
       mov       [rbp-0C0],rax
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L06
       mov       rax,[rbp-0C0]
       mov       [rbp-70],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-0B8]
       mov       rdx,7FFD579884B0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M01_L07:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-68]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0C8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0D0],rax
       cmp       qword ptr [rbp-0D0],0
       je        short M01_L08
       mov       rax,[rbp-0D0]
       mov       [rbp-78],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp-0C8]
       mov       rdx,7FFD579882A0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-78],rax
M01_L09:
       mov       rcx,[rbp-78]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       mov       [rbp-30],rax
M01_L10:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+20]
       mov       [rbp-0E0],rax
       cmp       qword ptr [rbp-0E0],0
       je        short M01_L11
       mov       rax,[rbp-0E0]
       mov       [rbp-38],rax
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-0D8]
       mov       rdx,7FFD579882E0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-38],rax
M01_L12:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+38]
       mov       [rbp-0F0],rax
       cmp       qword ptr [rbp-0F0],0
       je        short M01_L13
       mov       rax,[rbp-0F0]
       mov       [rbp-48],rax
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp-0E8]
       mov       rdx,7FFD579884B0
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-48],rax
M01_L14:
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       call      qword ptr [7FFD575163E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+10]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       call      qword ptr [7FFD571C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-0F8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+50]
       mov       [rbp-100],rax
       cmp       qword ptr [rbp-100],0
       je        short M01_L15
       mov       rax,[rbp-100]
       mov       [rbp-58],rax
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp-0F8]
       mov       rdx,7FFD57A4A1C8
       call      qword ptr [7FFD571CC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-58],rax
M01_L16:
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-50]
       mov       r8,[rbp-40]
       call      qword ptr [7FFD579ACA50]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,130
       pop       rbp
       ret
; Total bytes of code 1033
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
       call      qword ptr [7FFD579AFE28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD579AFDF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+2F0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+2E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD579BFEA0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD579BFE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       sub       rsp,130
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		items = items.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-88],rax
       mov       rax,[rbp-88]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+48]
       mov       [rbp-90],rax
       cmp       qword ptr [rbp-90],0
       je        short M01_L00
       mov       rax,[rbp-90]
       mov       [rbp-10],rax
       jmp       short M01_L01
M01_L00:
       mov       rcx,[rbp-88]
       mov       rdx,7FFD57AE14A8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rax,2B289851B60
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2B289840008
       call      qword ptr [7FFD573CDED8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 		return items.Where(p => p is not null).Any(this.Contains);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-98],rax
       mov       rax,[rbp-98]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0A0],rax
       cmp       qword ptr [rbp-0A0],0
       je        short M01_L02
       mov       rax,[rbp-0A0]
       mov       [rbp-18],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-98]
       mov       rdx,7FFD579E9FB8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+18]
       mov       [rbp-20],rax
       mov       rax,[rbp+18]
       mov       [rbp-28],rax
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       cmp       qword ptr [rbp-20],0
       jne       near ptr M01_L10
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rax,[rbp-0A8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0B0],rax
       cmp       qword ptr [rbp-0B0],0
       je        short M01_L04
       mov       rax,[rbp-0B0]
       mov       [rbp-60],rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp-0A8]
       mov       rdx,7FFD579E9FB8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-60],rax
M01_L05:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0B8],rax
       mov       rax,[rbp-0B8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+38]
       mov       [rbp-0C0],rax
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L06
       mov       rax,[rbp-0C0]
       mov       [rbp-70],rax
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-0B8]
       mov       rdx,7FFD579EA1C8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M01_L07:
       mov       rcx,[rbp-70]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-60]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-68]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFD571A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0C8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+18]
       mov       [rbp-0D0],rax
       cmp       qword ptr [rbp-0D0],0
       je        short M01_L08
       mov       rax,[rbp-0D0]
       mov       [rbp-78],rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp-0C8]
       mov       rdx,7FFD579E9FB8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-78],rax
M01_L09:
       mov       rcx,[rbp-78]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
       mov       [rbp-30],rax
M01_L10:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+20]
       mov       [rbp-0E0],rax
       cmp       qword ptr [rbp-0E0],0
       je        short M01_L11
       mov       rax,[rbp-0E0]
       mov       [rbp-38],rax
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-0D8]
       mov       rdx,7FFD579E9FF8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-38],rax
M01_L12:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0E8],rax
       mov       rax,[rbp-0E8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+38]
       mov       [rbp-0F0],rax
       cmp       qword ptr [rbp-0F0],0
       je        short M01_L13
       mov       rax,[rbp-0F0]
       mov       [rbp-48],rax
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp-0E8]
       mov       rdx,7FFD579EA1C8
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-48],rax
M01_L14:
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       call      qword ptr [7FFD574F63E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+10]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       call      qword ptr [7FFD571A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-0F8]
       mov       rax,[rax+30]
       mov       rax,[rax+8]
       mov       rax,[rax+50]
       mov       [rbp-100],rax
       cmp       qword ptr [rbp-100],0
       je        short M01_L15
       mov       rax,[rbp-100]
       mov       [rbp-58],rax
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp-0F8]
       mov       rdx,7FFD57AE1500
       call      qword ptr [7FFD571AC5E8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-58],rax
M01_L16:
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-50]
       mov       r8,[rbp-40]
       call      qword ptr [7FFD579BCED0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,130
       pop       rbp
       ret
; Total bytes of code 1033
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
       call      qword ptr [7FFD57AF4150]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57AF4120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

