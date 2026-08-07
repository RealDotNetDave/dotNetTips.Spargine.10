## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D2489E0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D01E580]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3CBB40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D3CBB40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFE2CB40FB8
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
       mov       rcx,188360027B0
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
       call      qword ptr [7FFE2D3CBB40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D01E580]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3CBB40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB40FF8
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
       mov       r11,7FFE2CB40FF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFE2D3CBB40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB40FD8
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB40FE0
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
       call      qword ptr [7FFE2D3E4528]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D01E580]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
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
       mov       r11,7FFE2CB40F98
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D01E0E8]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFE2CB40FF0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB40FE8
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
       call      qword ptr [7FFE2D3E41C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFE2D4669B8]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE1C030]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2CF5C618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFE2D4650C8]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D01E0E8]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFE2CB41018
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFE2CB41000
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFE2CB41010
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
       mov       r11,7FFE2CB41008
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFE2CB41020
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFE2CB40F90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFE2D4650C8]
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
       call      qword ptr [7FFE2CEBD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FFE2D433A00
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3ED350]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFE2CFFB630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFE2CBF7AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FFE2CB34000
       call      qword ptr [7FFE2CE1C030]
       mov       rdi,rax
       call      qword ptr [7FFE2D466868]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3E7408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFE2D4650C8]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D01E0E8]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFE2CB40FC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFE2CB40FB0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFE2CB40FC0
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,188360027A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,188360027B0
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
       mov       rcx,18836002B80
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D466988]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D4669A0]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFE2CB40F88
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFE2CB41028
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFE2CB40FA0
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFE2CFFB630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE2CBF7AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       r11,7FFE2CB40FE8
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D01E0E8]
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D01E0E8]
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
       mov       r11,7FFE2CB41028
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFE2CEBD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFE2CB40FA0
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
       mov       r11,7FFE2CB40FC0
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
       call      qword ptr [7FFE2D01E0D0]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D01E0E8]
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
       call      qword ptr [7FFE2CBF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D49D850
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D3E4288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D3E4288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CBF6820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D4661F0]
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
       mov       rdx,7FFE2D49D850
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D3E4288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D3E4288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CBF6820]; System.Threading.Monitor.Exit(System.Object)
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
       jne       short M03_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M03_L01:
       mov       esi,[rbx+3C]
       cmp       esi,[rbx+38]
       jl        near ptr M03_L08
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
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
       jmp       short M03_L01
M03_L03:
       cmp       ecx,5
       ja        short M03_L05
       mov       ecx,ecx
       lea       rdx,[7FFE2D38CC48]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L04:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        near ptr M03_L12
M03_L05:
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
M03_L06:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M03_L15
M03_L07:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M03_L05
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L02
M03_L08:
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
       jmp       near ptr M03_L04
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
       call      qword ptr [7FFE2D3E4600]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       short M03_L10
M03_L14:
       mov       ecx,[rbx+2C]
       jmp       near ptr M03_L06
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
       mov       rdx,7FFE2D49D088
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3E4600]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       jmp       near ptr M03_L07
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
       mov       rdx,7FFE2D49D088
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L23:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3E4600]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D49D088
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L27:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3E4600]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       jmp       near ptr M03_L07
M03_L29:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D4661F0]
       jmp       near ptr M03_L09
M03_L30:
       mov       rdx,7FFE2D49D088
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFE2D4662B0]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M06_L02
       test      esi,esi
       je        short M06_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       call      qword ptr [7FFE2D4662C8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D4662F8]
       mov       [rbp-44],eax
       jmp       short M06_L02
M06_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D4662E0]
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
       mov       rax,7FFE2CC31058
       mov       [rbp-88],rax
       lea       rax,[M06_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC31078]
M06_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M06_L10
M06_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE17FA8]; System.Threading.Thread.Sleep(Int32)
       jmp       short M06_L10
M06_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       call      qword ptr [7FFE2D3E4588]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D49E158
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L15
M06_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D466208]
       int       3
M06_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D3E45A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D466310]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF5C570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D3E45D0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D466298]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF5C570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE17FA8]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC31058
       mov       [rbp-88],rax
       lea       rax,[M06_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC31078]
M06_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M06_L28
M06_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE17FA8]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M06_L28
M06_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M06_L28
       jmp       short M06_L43
M06_L36:
       mov       eax,ecx
       jmp       short M06_L35
M06_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D466208]
       int       3
M06_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D4650C8]
       int       3
M06_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D466298]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF5C570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L10
M06_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D466970]
       jmp       near ptr M06_L10
M06_L42:
       mov       ecx,0A
       jmp       near ptr M06_L11
M06_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D466970]
       jmp       near ptr M06_L28
M06_L45:
       mov       ecx,0A
       jmp       near ptr M06_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3E4540]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D466328]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF5C570]
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
       mov       r11,7FFE2CB40EB0
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
       mov       rax,[7FFE2D4BFDB0]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CBF7AF8]; System.GC.SuppressFinalize(System.Object)
M06_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D3E45D0]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M06_L54
M06_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M06_L54
       mov       edx,1
       call      qword ptr [7FFE2D3E45D0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2CBF7AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       short M09_L00
M09_L04:
       mov       rcx,rsi
       call      00007FFE8C84D4D0
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
       mov       rdx,7FFE2CB34000
       call      qword ptr [7FFE2CE1C030]
       mov       rcx,rax
       call      qword ptr [7FFE2D01E0D0]
       int       3
M10_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
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
       jmp       qword ptr [7FFE2CBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D23EC30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D3FE328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D03A0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D3D03A0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFE2CB70D88
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
       mov       rcx,1614E8027B0
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
       call      qword ptr [7FFE2D3D03A0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3FE328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D03A0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB70DC8
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
       mov       r11,7FFE2CB70DC8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFE2D3D03A0]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DA8
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DB0
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
       call      qword ptr [7FFE2D31EAA8]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3FE328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
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
       mov       r11,7FFE2CB70D68
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD470]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFE2CB70DC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DB8
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
       call      qword ptr [7FFE2D31E748]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFE2D3FFA50]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE47798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFE2D3FF738]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3FD470]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFE2CB70DE8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFE2CB70DD0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFE2CB70DE0
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
       mov       r11,7FFE2CB70DD8
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFE2CB70DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFE2D3FF738]
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
       call      qword ptr [7FFE2CEDD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FFE2D4282D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F66D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFE2D01B630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rdi,rax
       call      qword ptr [7FFE2D3FF948]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3F4738]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FF738]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD470]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFE2CB70D98
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFE2CB70D80
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFE2CB70D90
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1614E8027A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,1614E8027B0
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
       mov       rcx,1614E802B10
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FF9F0]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FFA08]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D58
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFE2CB70DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D70
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFE2D01B630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       r11,7FFE2CB70DB8
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD470]
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3FD470]
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
       mov       r11,7FFE2CB70DF8
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFE2CEDD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D70
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
       mov       r11,7FFE2CB70D90
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
       call      qword ptr [7FFE2D3FD350]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD470]
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
       call      qword ptr [7FFE2CC25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D487CB0
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E808]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D31E808]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D3FF720]
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
       mov       rdx,7FFE2D487CB0
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E808]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D31E808]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
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
       jne       short M03_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M03_L01:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jl        short M03_L06
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M03_L09
M03_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       short M03_L01
M03_L03:
       cmp       ecx,5
       ja        short M03_L05
       mov       ecx,ecx
       lea       rdx,[7FFE2D38B698]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L04:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        near ptr M03_L10
M03_L05:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M03_L07:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M03_L29
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
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
       jmp       near ptr M03_L04
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
       call      qword ptr [7FFE2D31EB80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       short M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M03_L12
       mov       ecx,[rcx+0A0]
       jmp       short M03_L13
M03_L12:
       mov       ecx,[rbx+2C]
M03_L13:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M03_L18
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M03_L19
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L17
M03_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L15
       mov       rcx,rdx
       jmp       short M03_L16
M03_L15:
       mov       rdx,7FFE2D4874F8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L16:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EB80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L17:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L14
M03_L18:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L05
       jmp       near ptr M03_L28
M03_L19:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L23
M03_L20:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L21
       mov       rcx,rdx
       jmp       short M03_L22
M03_L21:
       mov       rdx,7FFE2D4874F8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EB80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L23:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M03_L20
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L27
M03_L24:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L25
       mov       rcx,rdx
       jmp       short M03_L26
M03_L25:
       mov       rdx,7FFE2D4874F8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L26:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EB80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M03_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L27:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L24
       jmp       near ptr M03_L18
M03_L28:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M03_L02
       jmp       near ptr M03_L09
M03_L29:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D3FF720]
       jmp       near ptr M03_L07
M03_L30:
       mov       rdx,7FFE2D4874F8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 883
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
       call      qword ptr [7FFE2D3FF810]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M06_L02
       test      esi,esi
       je        short M06_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       call      qword ptr [7FFE2D3FF828]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3FF858]
       mov       [rbp-44],eax
       jmp       short M06_L02
M06_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D3FF840]
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M06_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M06_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M06_L10
M06_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       short M06_L10
M06_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       call      qword ptr [7FFE2D31EB08]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D488760
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L15
M06_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FF750]
       int       3
M06_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D31EB20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D3FF870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D31EB50]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D3FF7F8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M06_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M06_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M06_L28
M06_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M06_L28
M06_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M06_L28
       jmp       short M06_L43
M06_L36:
       mov       eax,ecx
       jmp       short M06_L35
M06_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FF750]
       int       3
M06_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FF738]
       int       3
M06_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3FF7F8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L10
M06_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FF9D8]
       jmp       near ptr M06_L10
M06_L42:
       mov       ecx,0A
       jmp       near ptr M06_L11
M06_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FF9D8]
       jmp       near ptr M06_L28
M06_L45:
       mov       ecx,0A
       jmp       near ptr M06_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D31EAC0]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D3FF888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF97CD8]
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
       mov       r11,7FFE2CB70D40
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
       mov       rax,[7FFE2D4A7A08]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
M06_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D31EB50]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M06_L54
M06_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M06_L54
       mov       edx,1
       call      qword ptr [7FFE2D31EB50]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       short M09_L00
M09_L04:
       mov       rcx,rsi
       call      00007FFE8C84D4D0
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rcx,rax
       call      qword ptr [7FFE2D3FD350]
       int       3
M10_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
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
       jmp       qword ptr [7FFE2CC25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D23F1E8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D3FE820]
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFE2CB70D90
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
       mov       rcx,1F2098007B8
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3FE820]
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB70DD0
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
       mov       r11,7FFE2CB70DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
M00_L41:
       mov       rcx,[rbp-88]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],rax
       jne       short M00_L43
       mov       rcx,[rbp-88]
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DB0
       call      qword ptr [r11]
       jmp       short M00_L42
       xchg      ax,ax
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DB8
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
       call      qword ptr [7FFE2D31EB38]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3FE820]
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
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
       mov       r11,7FFE2CB70D70
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD9E0]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFE2CB70DC8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB70DC0
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
       call      qword ptr [7FFE2D31E7D8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFE2D3FFF00]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE47798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFE2D3FF840]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3FD9E0]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFE2CB70DF0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFE2CB70DD8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFE2CB70DE8
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
       mov       r11,7FFE2CB70DE0
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFE2CB70DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFE2D3FF840]
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
       call      qword ptr [7FFE2CEDD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FFE2D429020
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3F6850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFE2D01B630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rdi,rax
       call      qword ptr [7FFE2D3FFDF8]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3F47C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FF840]
       int       3
M00_L83:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD9E0]
       jmp       near ptr M00_L08
M00_L84:
       mov       rcx,rsi
       mov       r11,7FFE2CB70DA0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L85:
       mov       rcx,rbx
       mov       r11,7FFE2CB70D88
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,r12
       mov       r11,7FFE2CB70D98
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L87:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1F2098007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,1F2098007B8
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
       mov       rcx,1F209800B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FFED0]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FFEE8]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D60
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L93:
       mov       r11,7FFE2CB70E00
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D78
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFE2D01B630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       r11,7FFE2CB70DC0
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD9E0]
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3FD9E0]
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
       mov       r11,7FFE2CB70E00
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFE2CEDD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFE2CB70D78
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
       mov       r11,7FFE2CB70D98
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
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD9E0]
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
       call      qword ptr [7FFE2CC25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D498298
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D3FF7F8]
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
       mov       rdx,7FFE2D498298
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
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
       jne       near ptr M02_L07
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
M02_L01:
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
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L26
M02_L05:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M02_L01
M02_L06:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+2C]
       jl        near ptr M02_L27
       jmp       near ptr M02_L30
M02_L07:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFE2D38DD48]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M02_L00]
       add       rdx,rax
       jmp       rdx
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
       mov       rdx,7FFE2D497948
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L12:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D497948
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D497948
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       jne       near ptr M02_L05
       jmp       short M02_L26
M02_L25:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D3FF7F8]
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
       jmp       near ptr M02_L06
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
       mov       rdx,7FFE2D497948
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L29:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L03
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
       jmp       near ptr M02_L06
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
; Total bytes of code 897
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
       call      qword ptr [7FFE2D3FF918]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFE2D3FF930]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3FF960]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D3FF948]
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       call      qword ptr [7FFE2D31EB98]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D498D48
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FF858]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D31EBB0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D3FF978]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D3FF900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FF858]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FF840]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3FF900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FFE88]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FFE88]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D31EB50]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D3FF990]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF97CD8]
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
       mov       r11,7FFE2CB70D48
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
       mov       rax,[7FFE2D4AF8B0]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       short M08_L00
M08_L04:
       mov       rcx,rsi
       call      00007FFE8C84D4D0
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rcx,rax
       call      qword ptr [7FFE2D3FD8F0]
       int       3
M09_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
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
       jmp       qword ptr [7FFE2CC25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D1CF810]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       jl        near ptr M00_L82
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
       jne       near ptr M00_L86
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L83
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L85
       mov       rcx,[rsi+8]
       mov       [rbp-80],rcx
       xor       eax,eax
       mov       [rbp-3C],eax
       test      rcx,rcx
       je        short M00_L06
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D3C7870]
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L84
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
       call      qword ptr [7FFE2D2DCA98]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D2DCA98]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       r11,7FFE2CB50C88
       call      qword ptr [r11]
       jmp       short M00_L14
M00_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L17:
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       near ptr M00_L87
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L18:
       test      rdi,rdi
       jle       near ptr M00_L80
       mov       rcx,23A1AC007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L88
M00_L19:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L89
       mov       rsi,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rdx
       je        short M00_L20
       xor       esi,esi
M00_L20:
       test      rsi,rsi
       jne       near ptr M00_L90
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L92
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
       jne       near ptr M00_L81
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
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       near ptr M00_L73
       call      qword ptr [7FFE2D2DCA98]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L30
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3C7870]
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L35:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D2DCA98]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L38
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB50CC8
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
       mov       r11,7FFE2CB50CC8
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
       call      qword ptr [7FFE2D2DCA98]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L42:
       test      eax,eax
       jne       short M00_L39
       jmp       short M00_L46
M00_L43:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB50CA8
       call      qword ptr [r11]
       jmp       short M00_L42
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB50CB0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L40
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
       call      qword ptr [7FFE2D2C6E98]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L52
       mov       rcx,[rbp-98]
       call      qword ptr [7FFE2D3C7870]
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L57:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
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
       mov       r11,7FFE2CB50C68
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L29
M00_L61:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3C7708]
       jmp       near ptr M00_L36
M00_L62:
       mov       rcx,rbx
       mov       r11,7FFE2CB50CC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L37
M00_L63:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB50CB8
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
       call      qword ptr [7FFE2D2C6B38]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L66
       call      qword ptr [7FFE2D3CCA20]
       mov       r12,rax
M00_L66:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE2CF77D80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       call      qword ptr [7FFE2D3C76D8]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3C7708]
       jmp       near ptr M00_L58
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFE2CB50CE8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L70:
       mov       r11,7FFE2CB50CD0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L59
M00_L71:
       mov       r11,7FFE2CB50CE0
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
       mov       r11,7FFE2CB50CD8
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L74:
       mov       r11,7FFE2CB50CF0
       call      qword ptr [r11]
       jmp       near ptr M00_L49
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFE2CB50C60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L60
       jmp       short M00_L77
M00_L76:
       mov       rcx,r8
       call      qword ptr [7FFE2D3C76D8]
       int       3
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L94
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       near ptr M00_L93
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       mov       rcx,rdi
       call      qword ptr [7FFE2CEBD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L80:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FFE2D3A4BC0
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2CEAC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-60]
       mov       edx,1
       call      qword ptr [7FFE2CFFB630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-60]
       call      qword ptr [7FFE2CC07AF8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rcx,rdi
       mov       r11,7FFE2CB50C58
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L82:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1791D
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       rdi,rax
       call      qword ptr [7FFE2D3CC5A0]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D2CCB28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L83:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3C76D8]
       int       3
M00_L84:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3C7708]
       jmp       near ptr M00_L08
M00_L85:
       mov       rcx,rsi
       mov       r11,7FFE2CB50C98
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L86:
       mov       rcx,rbx
       mov       r11,7FFE2CB50C80
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L87:
       mov       r11,7FFE2CB50C90
       call      qword ptr [r11]
       jmp       near ptr M00_L18
M00_L88:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,23A1AC007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,23A1AC007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L89:
       mov       rcx,rax
       mov       rdx,r12
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L90:
       cmp       dword ptr [rsi+8],0
       jne       short M00_L91
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23A1AC00AA0
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L91:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3CC9F0]
       jmp       near ptr M00_L21
M00_L92:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3CCA08]
       jmp       near ptr M00_L21
M00_L93:
       mov       r11,7FFE2CB50CF8
       call      qword ptr [r11]
       jmp       near ptr M00_L78
M00_L94:
       mov       rcx,rdi
       mov       r11,7FFE2CB50C70
       call      qword ptr [r11]
       jmp       near ptr M00_L80
M00_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FFE2CFFB630]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE2CC07AF8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,28
       ret
M00_L96:
       sub       rsp,28
       cmp       qword ptr [rbp-88],0
       je        short M00_L98
       mov       rcx,[rbp-88]
       mov       rbx,[rcx]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rbx,r12
       jne       short M00_L97
       mov       rcx,[rbp-88]
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       rcx,[rbp-88]
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L98
M00_L97:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB50CB8
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L99:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3C7708]
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L101:
       mov       rcx,[rbp-98]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L102
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFE2D3C7708]
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
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       short M00_L103
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L104
M00_L103:
       mov       r11,7FFE2CB50CF8
       call      qword ptr [r11]
M00_L104:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L105:
       mov       rcx,rdi
       call      qword ptr [7FFE2CEBD2F0]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L107
M00_L106:
       mov       rcx,rdi
       mov       r11,7FFE2CB50C70
       call      qword ptr [r11]
M00_L107:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L109
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L108
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L109
M00_L108:
       mov       r11,7FFE2CB50C90
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
       call      qword ptr [7FFE2D3C76F0]
       int       3
M00_L110:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L111
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3C7708]
M00_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3809
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
       call      qword ptr [7FFE2CC05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D39E190
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D2C6BF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D2C6BF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC06820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D3C7660]
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
       mov       rdx,7FFE2D39E190
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D2C6BF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D2C6BF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC06820]; System.Threading.Monitor.Exit(System.Object)
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
M02_L02:
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
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M02_L25
M02_L05:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
       jmp       near ptr M02_L01
M02_L06:
       cmp       ecx,5
       ja        near ptr M02_L30
       mov       ecx,ecx
       lea       rdx,[7FFE2D2FF1F0]
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
       mov       rdx,7FFE2D39A5E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2C6F70]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M02_L03
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
       mov       rdx,7FFE2D39A5E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2C6F70]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M02_L03
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
       mov       rdx,7FFE2D39A5E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2C6F70]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M02_L03
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
       jne       near ptr M02_L05
       jmp       short M02_L25
M02_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D3C7660]
       jmp       near ptr M02_L02
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
       mov       rdx,7FFE2D39A5E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D2C6F70]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M02_L03
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
; Total bytes of code 879
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
       call      qword ptr [7FFE2D3C77E0]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFE2D3C77F8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C7828]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D3C7810]
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
       mov       rax,7FFE2CC41058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC41078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE27720]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       mov       r11,[rdx+28]
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
       call      qword ptr [7FFE2D2C6EF8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D39CE58
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3C7720]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D2C6F10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D3C7840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF77CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D2C6F40]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D3C77C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF77CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE27720]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC41058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC41078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE27720]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3C7720]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3C76D8]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3C77C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF77CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D3C7990]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D3C7990]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D2C6EB0]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D3C7858]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF77CD8]
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
       mov       r11,7FFE2CB50B10
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
       mov       rax,[7FFE2D3AE138]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CC07AF8]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D2C6F40]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFE2D2C6F40]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2CC07AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       short M08_L00
M08_L04:
       mov       rcx,rsi
       call      00007FFE8C84D4D0
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
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       rcx,rax
       call      qword ptr [7FFE2D3C76F0]
       int       3
M09_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
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
       jmp       qword ptr [7FFE2CC05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D23F1E8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D3FE7D8]
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
       call      qword ptr [7FFE2D3FD908]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       r11,7FFE2CB70FE8
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
       mov       rcx,17FE08007B8
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L83
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
       jne       near ptr M00_L76
       cmp       dword ptr [rdi+14],0
       jne       short M00_L22
       mov       ebx,[rdi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       je        near ptr M00_L84
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L31
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3FE7D8]
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
       call      qword ptr [7FFE2D3FD908]
       int       3
M00_L36:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L39
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB71028
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
       mov       r11,7FFE2CB71028
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L43:
       test      eax,eax
       jne       short M00_L40
       jmp       short M00_L47
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB71008
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L45:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB71010
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
       call      qword ptr [7FFE2D31EB38]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
M00_L49:
       call      qword ptr [7FFE2D3FF000]
       mov       rcx,rax
       mov       r8,17FCA801E60
       mov       r8,[r8]
       mov       rdx,1C05F7A1920
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r12,rax
       test      r12,r12
       jne       short M00_L50
       call      qword ptr [7FFE2D3FF000]
       mov       rcx,rax
       mov       r8,17FCA801E60
       mov       r8,[r8]
       mov       rdx,1C05F7A1990
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r12,rax
M00_L50:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CEF4D10
       call      qword ptr [7FFE2CE47798]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE2CF97D80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L29
       mov       rcx,rdi
       mov       r11,7FFE2CB70FC8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L52:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD9F8]
       jmp       near ptr M00_L37
M00_L53:
       mov       rcx,rbx
       mov       r11,7FFE2CB71020
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L38
M00_L54:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB71018
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
       mov       r11,7FFE2CB71030
       call      qword ptr [r11]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L58:
       mov       r11,7FFE2CB71040
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
       mov       r11,7FFE2CB71038
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L61:
       mov       rcx,rbx
       call      qword ptr [7FFE2CFC53A8]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L56
M00_L62:
       test      ebx,ebx
       jne       near ptr M00_L51
       jmp       near ptr M00_L77
M00_L63:
       mov       rcx,rdi
       mov       r11,7FFE2CB70FC0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M00_L62
M00_L64:
       mov       rcx,r8
       call      qword ptr [7FFE2D3FEFE8]
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rdi,rax
       call      qword ptr [7FFE2D3FFF30]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3F47C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L66:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       jmp       near ptr M00_L82
M00_L67:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FEFE8]
       int       3
M00_L68:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD9F8]
       jmp       near ptr M00_L08
M00_L69:
       mov       rcx,rsi
       mov       r11,7FFE2CB70FF8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L70:
       mov       rcx,rbx
       mov       r11,7FFE2CB70FE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L71:
       mov       r11,7FFE2CB70FF0
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
       mov       rcx,17FE0800B18
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L74:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FFF78]
       jmp       near ptr M00_L21
M00_L75:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3FFF90]
       jmp       near ptr M00_L21
M00_L76:
       mov       rcx,rdi
       mov       r11,7FFE2CB70FB8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L77:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       short M00_L81
       cmp       qword ptr [rdi+28],0
       je        short M00_L80
       mov       rcx,[rdi+28]
       mov       r12,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r12
       jne       short M00_L78
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L79
M00_L78:
       mov       r11,7FFE2CB71048
       call      qword ptr [r11]
M00_L79:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L80:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L66
M00_L81:
       mov       rcx,rdi
       mov       r11,7FFE2CB70FD0
       call      qword ptr [r11]
       jmp       near ptr M00_L66
M00_L82:
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
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
M00_L83:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,17FE08007B0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,17FE08007B8
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L84:
       jmp       near ptr M00_L23
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
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
M00_L88:
       mov       rcx,[rbp-58]
       mov       byte ptr [rcx+38],1
M00_L89:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L90
       call      00007FFE8C84D4D0
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
       mov       r11,7FFE2CB71018
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
       call      qword ptr [7FFE2D3FD908]
       int       3
M00_L94:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L95
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3FD9F8]
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
       mov       r11,7FFE2CB71048
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
       mov       r11,7FFE2CB70FD0
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
       mov       r11,7FFE2CB70FF0
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
       call      qword ptr [7FFE2D3FD908]
       int       3
M00_L103:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L104
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3FD9F8]
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
       call      qword ptr [7FFE2CC25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D499560
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D3FFB58]
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
       mov       rdx,7FFE2D499560
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D31E898]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC26820]; System.Threading.Monitor.Exit(System.Object)
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
       lea       rdx,[7FFE2D38C3F0]
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
       mov       rdx,7FFE2D498EB8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D498EB8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D498EB8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3FFB58]
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
       mov       rdx,7FFE2D498EB8
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3FFC30]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M05_L02
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       call      qword ptr [7FFE2D3FFC48]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M05_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3FFC78]
       mov       [rbp-44],eax
       jmp       short M05_L02
M05_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D3FFC60]
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M05_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M05_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M05_L10
M05_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       short M05_L10
M05_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       call      qword ptr [7FFE2D31EB98]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D499F18
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L15
M05_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FFB70]
       int       3
M05_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D31EBB0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D3FFC90]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D3FFC18]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC61058
       mov       [rbp-88],rax
       lea       rax,[M05_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC61078]
M05_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M05_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M05_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M05_L28
M05_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE47720]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M05_L28
M05_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M05_L28
       jmp       short M05_L43
M05_L36:
       mov       eax,ecx
       jmp       short M05_L35
M05_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3FFB70]
       int       3
M05_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3FEFE8]
       int       3
M05_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3FFC18]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF97CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L10
M05_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FFDC8]
       jmp       near ptr M05_L10
M05_L42:
       mov       ecx,0A
       jmp       near ptr M05_L11
M05_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L28
M05_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D3FFDC8]
       jmp       near ptr M05_L28
M05_L45:
       mov       ecx,0A
       jmp       near ptr M05_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D31EB50]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D3FFCA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF97CD8]
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
       mov       r11,7FFE2CB70CB0
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
       mov       rax,[7FFE2D4AD1E0]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
M05_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC27AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M05_L54
M05_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M05_L54
       mov       edx,1
       call      qword ptr [7FFE2D31EBE0]; System.Threading.SemaphoreSlim.Release(Int32)
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
       mov       r11,7FFE2CB71100
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
       jmp       qword ptr [7FFE2CC25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rdx,7FFE2CB64000
       call      qword ptr [7FFE2CE47798]
       mov       rcx,rax
       call      qword ptr [7FFE2D3FD908]
       int       3
M08_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
; Total bytes of code 65
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rbx,[rcx+2D8]
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
       call      qword ptr [7FFE2D21D458]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE2D3DE2C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3DD2F0]
       int       3
M00_L07:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D32EB08]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      qword ptr [7FFE2D32EB08]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L14:
       test      eax,eax
       jne       short M00_L12
       jmp       short M00_L17
M00_L15:
       mov       rcx,r12
       mov       r11,7FFE2CB61030
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
       mov       rcx,208E48027B0
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L82
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
       jne       near ptr M00_L75
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
       call      qword ptr [7FFE2D32EB08]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L31
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE2D3DE2C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3DD2F0]
       int       3
M00_L36:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D32EB08]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L39
       mov       rdx,[rbp-70]
       mov       r11,7FFE2CB61070
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
       call      qword ptr [7FFE2D32EB08]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB61070
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L41
       jmp       short M00_L40
M00_L44:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB61050
       call      qword ptr [r11]
       jmp       short M00_L42
M00_L45:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB61058
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
       call      qword ptr [7FFE2D2FE640]; System.Collections.Concurrent.BlockingCollection`1[[System.__Canon, System.Private.CoreLib]].TryAddWithNoTimeValidation(System.__Canon, Int32, System.Threading.CancellationToken)
       test      eax,eax
       jne       near ptr M00_L25
M00_L49:
       call      qword ptr [7FFE2D3DF8A0]
       mov       rcx,rax
       mov       r8,208E4801E60
       mov       r8,[r8]
       mov       rdx,249797A1920
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L50
       call      qword ptr [7FFE2D3DF8A0]
       mov       rcx,rax
       mov       r8,208E4801E60
       mov       r8,[r8]
       mov       rdx,249797A1990
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
M00_L50:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24B5
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2CF87D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L29
       mov       rcx,rdi
       mov       r11,7FFE2CB61010
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L52:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3DD410]
       jmp       near ptr M00_L37
M00_L53:
       mov       rcx,rbx
       mov       r11,7FFE2CB61068
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L38
M00_L54:
       mov       rcx,[rbp-88]
       mov       r11,7FFE2CB61060
       call      qword ptr [r11]
       jmp       near ptr M00_L48
M00_L55:
       xor       ebx,ebx
       jmp       short M00_L61
M00_L56:
       mov       rcx,[rbx+18]
       mov       r11,7FFE2CB61078
       call      qword ptr [r11]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M00_L26
M00_L57:
       mov       r11,7FFE2CB61088
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
       mov       r11,7FFE2CB61080
       call      qword ptr [r11]
       jmp       near ptr M00_L27
M00_L60:
       mov       rcx,rbx
       call      qword ptr [7FFE2CFB53A8]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L55
M00_L61:
       test      ebx,ebx
       jne       near ptr M00_L51
       jmp       near ptr M00_L76
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFE2CB61008
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M00_L61
M00_L63:
       mov       rcx,r8
       call      qword ptr [7FFE2D3DF318]
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
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rdi,rax
       call      qword ptr [7FFE2D3DFA68]
       mov       r9,rax
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D3D42D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L65:
       mov       r8,[rbp-60]
       mov       [rbp-58],r8
       jmp       near ptr M00_L81
M00_L66:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3DF318]
       int       3
M00_L67:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3DD410]
       jmp       near ptr M00_L08
M00_L68:
       mov       rcx,rsi
       mov       r11,7FFE2CB61040
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L69:
       mov       rcx,rbx
       mov       r11,7FFE2CB61028
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L09
M00_L70:
       mov       rcx,r12
       mov       r11,7FFE2CB61038
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
       mov       rcx,208E4802B10
       mov       rdi,[rcx]
       jmp       near ptr M00_L21
M00_L73:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3DFBD0]
       jmp       near ptr M00_L21
M00_L74:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r12
       call      qword ptr [7FFE2D3DFBE8]
       jmp       near ptr M00_L21
M00_L75:
       mov       rcx,rdi
       mov       r11,7FFE2CB61000
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdi,rcx
       jmp       near ptr M00_L24
M00_L76:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       short M00_L80
       cmp       qword ptr [rdi+28],0
       je        short M00_L79
       mov       rcx,[rdi+28]
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M00_L77
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L78
M00_L77:
       mov       r11,7FFE2CB61090
       call      qword ptr [r11]
M00_L78:
       xor       ecx,ecx
       mov       [rdi+28],rcx
M00_L79:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L65
M00_L80:
       mov       rcx,rdi
       mov       r11,7FFE2CB61018
       call      qword ptr [r11]
       jmp       near ptr M00_L65
M00_L81:
       mov       [rbp-50],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
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
M00_L82:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,208E48027A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<.ctor>b__2_0(System.__Canon)
       mov       [r12+18],rcx
       mov       rcx,208E48027B0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L19
M00_L83:
       jmp       near ptr M00_L23
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
       call      qword ptr [7FFE2CC17AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
M00_L87:
       mov       rcx,[rbp-58]
       mov       byte ptr [rcx+38],1
M00_L88:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L89
       call      00007FFE8C84D4D0
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
       mov       r11,7FFE2CB61060
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
       call      qword ptr [7FFE2D3DD2F0]
       int       3
M00_L93:
       mov       rcx,[rbp-90]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L94
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE2D3DD410]
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
       mov       r11,7FFE2CB61090
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
       mov       r11,7FFE2CB61018
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
       mov       r11,7FFE2CB61038
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
       call      qword ptr [7FFE2D3DD2F0]
       int       3
M00_L102:
       mov       rcx,[rbp-80]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L103
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE2D3DD410]
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
       call      qword ptr [7FFE2CC15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFE2D479928
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L08:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D2FE3A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       edi,eax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r12d
       mov       r9d,r15d
       call      qword ptr [7FFE2D2FE3A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC16820]; System.Threading.Monitor.Exit(System.Object)
M01_L12:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFE2D3DF300]
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
       mov       rdx,7FFE2D479928
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r12,rax
M01_L15:
       mov       rcx,r12
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFE2D2FE3A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
       mov       ebx,eax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       mov       r9d,r13d
       call      qword ptr [7FFE2D2FE3A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetCount(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32, Int32)
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
       call      qword ptr [7FFE2CC16820]; System.Threading.Monitor.Exit(System.Object)
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
       jne       near ptr M03_L06
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       short M03_L03
M03_L01:
       mov       rcx,[rbx+20]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       je        near ptr M03_L25
M03_L02:
       mov       ecx,[rsi+0A0]
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+38],ecx
       xor       ecx,ecx
       mov       [rbx+3C],ecx
M03_L03:
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jge       short M03_L01
       mov       rsi,[rbx+20]
       lea       ebp,[rdi+1]
       and       ebp,[rsi+18]
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       r14d,edi
       shl       r14,4
M03_L04:
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L31
       mov       ecx,[rcx+r14+18]
       and       ecx,[rsi+18]
       cmp       ecx,ebp
       jne       near ptr M03_L24
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L31
       mov       rdx,[rcx+r14+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],4
M03_L05:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L06:
       cmp       ecx,5
       ja        near ptr M03_L30
       mov       ecx,ecx
       lea       rdx,[7FFE2D3670B0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M03_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        short M03_L07
       mov       ecx,[rcx+0A0]
       jmp       short M03_L08
M03_L07:
       mov       ecx,[rbx+2C]
M03_L08:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jge       near ptr M03_L13
       mov       rdx,[rbx+10]
       mov       edx,[rdx+18]
       and       [rbx+30],edx
       mov       rdx,[rbx+10]
       and       ecx,[rdx+18]
       mov       [rbx+34],ecx
       mov       ecx,[rbx+30]
       cmp       ecx,[rbx+34]
       jge       near ptr M03_L14
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L12
M03_L09:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L10
       mov       rcx,rdx
       jmp       short M03_L11
M03_L10:
       mov       rdx,7FFE2D477FA0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE718]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M03_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L12:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L09
M03_L13:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M03_L30
       jmp       near ptr M03_L23
M03_L14:
       mov       ecx,[rbx+30]
       mov       [rbx+38],ecx
       jmp       short M03_L18
M03_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L16
       mov       rcx,rdx
       jmp       short M03_L17
M03_L16:
       mov       rdx,7FFE2D477FA0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE718]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M03_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L18:
       mov       ecx,[rbx+38]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jl        short M03_L15
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L22
M03_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L20
       mov       rcx,rdx
       jmp       short M03_L21
M03_L20:
       mov       rdx,7FFE2D477FA0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE718]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M03_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L22:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M03_L19
       jmp       near ptr M03_L13
M03_L23:
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+20]
       cmp       rsi,[rbx+18]
       jne       near ptr M03_L02
       jmp       short M03_L25
M03_L24:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D3DF300]
       jmp       near ptr M03_L04
M03_L25:
       xor       ecx,ecx
       mov       [rbx+20],rcx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       [rbx+2C],ecx
       xor       ecx,ecx
       mov       [rbx+38],ecx
       jmp       short M03_L29
M03_L26:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M03_L27
       mov       rcx,rdx
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FFE2D477FA0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D2FE718]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       near ptr M03_L05
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M03_L29:
       mov       esi,[rbx+38]
       cmp       esi,[rbx+2C]
       jl        short M03_L26
M03_L30:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 876
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
       call      qword ptr [7FFE2D3DF3F0]
       mov       [rbp-44],eax
       cmp       dword ptr [rbp-44],0
       jne       short M06_L02
       test      esi,esi
       je        short M06_L02
       mov       rcx,[rbp+28]
       mov       rdx,[rbx+28]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       call      qword ptr [7FFE2D3DF408]
       mov       [rbp-0A0],rax
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0A0]
       cmp       byte ptr [rdx+24],0
       jne       short M06_L01
       mov       edx,esi
       mov       r8,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3DF438]
       mov       [rbp-44],eax
       jmp       short M06_L02
M06_L01:
       mov       ecx,46
       call      qword ptr [7FFE2D3DF420]
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
       mov       rax,7FFE2CC51058
       mov       [rbp-88],rax
       lea       rax,[M06_L05]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC51078]
M06_L05:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L06
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       short M06_L10
M06_L07:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE37720]; System.Threading.Thread.Sleep(Int32)
       jmp       short M06_L10
M06_L08:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
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
       call      qword ptr [7FFE2D2FE6A0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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
       mov       rdx,7FFE2D478760
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M06_L15
M06_L19:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3DF330]
       int       3
M06_L20:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       call      qword ptr [7FFE2D2FE6B8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].EnqueueSlow(System.__Canon)
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
       call      qword ptr [7FFE2D3DF450]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF87CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L23:
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7FFE2D2FE6E8]; System.Threading.SemaphoreSlim.Release(Int32)
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
       call      qword ptr [7FFE2D3DF3D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF87CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L27:
       mov       ecx,1
       call      qword ptr [7FFE2CE37720]; System.Threading.Thread.Sleep(Int32)
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
       mov       rax,7FFE2CC51058
       mov       [rbp-88],rax
       lea       rax,[M06_L31]
       mov       [rbp-78],rax
       mov       rax,[rbp-60]
       lea       rcx,[rbp-98]
       mov       [rax+8],rcx
       mov       rax,[rbp-60]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FFE2CC51078]
M06_L31:
       mov       rcx,[rbp-60]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M06_L32
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M06_L32:
       mov       rcx,[rbp-60]
       mov       rax,[rbp-90]
       mov       [rcx+8],rax
       jmp       near ptr M06_L28
M06_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE2CE37720]; System.Threading.Thread.Sleep(Int32)
       jmp       near ptr M06_L28
M06_L34:
       call      00007FFE8C891B10
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
       mov       rax,7FFE8C810390
       call      rax
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M06_L28
       jmp       short M06_L43
M06_L36:
       mov       eax,ecx
       jmp       short M06_L35
M06_L37:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D3DF330]
       int       3
M06_L38:
       mov       rcx,rbx
       call      qword ptr [7FFE2D3DF318]
       int       3
M06_L39:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D3DF3D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF87CD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L10
M06_L41:
       mov       ecx,eax
       call      qword ptr [7FFE2D3DF558]
       jmp       near ptr M06_L10
M06_L42:
       mov       ecx,0A
       jmp       near ptr M06_L11
M06_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L44:
       mov       ecx,eax
       call      qword ptr [7FFE2D3DF558]
       jmp       near ptr M06_L28
M06_L45:
       mov       ecx,0A
       jmp       near ptr M06_L29
       sub       rsp,28
       vzeroupper
       lea       rcx,[rbp+28]
       call      qword ptr [7FFE2D2FE658]; System.Threading.CancellationToken.ThrowIfCancellationRequested()
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D3DF468]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF87CD8]
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
       mov       r11,7FFE2CB60C08
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
       mov       rax,[7FFE2D492620]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17AF8]; System.GC.SuppressFinalize(System.Object)
M06_L48:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFE8C84D4D0
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
       call      qword ptr [7FFE2D2FE6E8]; System.Threading.SemaphoreSlim.Release(Int32)
       jmp       short M06_L54
M06_L53:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M06_L54
       mov       edx,1
       call      qword ptr [7FFE2D2FE6E8]; System.Threading.SemaphoreSlim.Release(Int32)
M06_L54:
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
       je        short M07_L01
       mov       r11,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rcx],r11
       jne       short M07_L02
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M07_L00:
       xor       eax,eax
       mov       [rbx+28],rax
M07_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M07_L02:
       mov       r11,7FFE2CB60FF0
       call      qword ptr [r11]
       jmp       short M07_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFE2CC15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rcx,rax
       call      qword ptr [7FFE2D3DD2F0]
       int       3
M09_L01:
       add       rsp,28
       jmp       near ptr 00007FFE8C84D4D0
; Total bytes of code 65
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D01BB80]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clone()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE2D4C7560
       call      qword ptr [7FFE2D40F8E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       call      M00_L00
       nop
       mov       rcx,7FFE2D5B3A1C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,40
       pop       rbp
       ret
M00_L00:
       sub       rsp,28
       cmp       qword ptr [rbp-8],0
       je        short M00_L01
       mov       rcx,7FFE2D5B3908
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       rdx,7FFE2D5B3910
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       r11,7FFE2CB712D8
       call      qword ptr [r11]
M00_L01:
       mov       rcx,7FFE2D5B3A18
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
       mov       rdx,7FFE2D4D1090
       call      qword ptr [7FFE2CE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D40FD08]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D40FCC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.Clone()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CFEBB80]; Precode of DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Clone()
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFE2D5293C8
       call      qword ptr [7FFE2D40FD20]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       mov       r11,7FFE2CB40FA0
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
       mov       rdx,7FFE2D5347A8
       call      qword ptr [7FFE2CE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D544360]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D544318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3EE610]
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
       call      qword ptr [7FFE2D3ED770]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3B4958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB60E28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       jmp       near ptr M00_L15
M00_L09:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [r13],rcx
       jne       short M00_L13
       mov       rcx,r13
       call      qword ptr [7FFE2D3B4958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB60E28
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
       mov       r11,7FFE2CB60E08
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFE2CB60E10
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2CC1C9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L19
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L22
M00_L19:
       mov       rcx,rax
       call      qword ptr [7FFE2CC17C48]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFE2D4B42A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rsi,rbx
       jmp       short M00_L20
M00_L23:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE2CD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L24
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE2CD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       xor       ebx,ebx
       jmp       short M00_L21
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3ED860]
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFE2CB60E20
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       call      M00_L30
       jmp       short M00_L29
M00_L28:
       mov       rcx,r13
       mov       r11,7FFE2CB60E18
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
       mov       r11,7FFE2CB60E18
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
       call      qword ptr [7FFE2D3ED770]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3ED860]
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
       jne       short M01_L01
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+3C]
       jmp       near ptr M01_L06
M01_L01:
       cmp       ecx,5
       ja        near ptr M01_L29
       mov       ecx,ecx
       lea       rdx,[7FFE2D36DFD0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L12
       mov       ecx,[rcx+0A0]
M01_L02:
       mov       rdx,[rbx+10]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       sub       ecx,edx
       mov       [rbx+34],ecx
       cmp       [rbx+30],ecx
       jl        near ptr M01_L13
M01_L03:
       mov       rcx,[rbx+10]
       cmp       rcx,[rbx+18]
       je        near ptr M01_L29
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
       je        near ptr M01_L09
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
       call      qword ptr [7FFE2D2FE7A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],5
       jmp       short M01_L08
M01_L12:
       mov       ecx,[rbx+2C]
       jmp       near ptr M01_L02
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
       mov       rdx,7FFE2D488108
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L16:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE7A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],1
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L17:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L14
       jmp       near ptr M01_L03
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
       mov       rdx,7FFE2D488108
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE7A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],2
       jmp       near ptr M01_L08
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
       mov       rdx,7FFE2D488108
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L25:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FE7A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+28],3
       jmp       near ptr M01_L08
       mov       dword ptr [rbx+28],0FFFFFFFF
       inc       dword ptr [rbx+38]
M01_L26:
       mov       ecx,[rbx+38]
       cmp       ecx,[rbx+34]
       jl        short M01_L23
       jmp       near ptr M01_L03
M01_L27:
       lea       rcx,[rsp+20]
       mov       edx,14
       call      qword ptr [7FFE2D3EF6D8]
       jmp       near ptr M01_L07
M01_L28:
       mov       rdx,7FFE2D488108
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
; Total bytes of code 875
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
       call      qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD51B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M03_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D4B59C8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3EF660]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3BE658]
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
       call      qword ptr [7FFE2D3BD758]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D390C40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB30CA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       jmp       short M00_L15
M00_L09:
       mov       r13,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       [rsi],r13
       jne       short M00_L13
       mov       rcx,rsi
       call      qword ptr [7FFE2D390C40]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB30CA0
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
       mov       r11,7FFE2CB30C80
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFE2CB30C88
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2CBEC9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L19
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L22
M00_L19:
       mov       rcx,rax
       call      qword ptr [7FFE2CBE7C48]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFE2D3BF780]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rsi,rbx
       jmp       short M00_L20
M00_L23:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE2CD54AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L24
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE2CD54B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       xor       ebx,ebx
       jmp       short M00_L21
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3BD848]
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFE2CB30C98
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       call      M00_L30
       jmp       short M00_L29
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFE2CB30C90
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
       mov       r11,7FFE2CB30C90
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
       call      qword ptr [7FFE2D3BD758]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3BD848]
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
       mov       edi,[rbx+3C]
       cmp       edi,[rbx+38]
       jl        short M01_L03
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
       jmp       short M01_L01
M01_L03:
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
       lea       rdx,[7FFE2D34B390]
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
       mov       rdx,7FFE2D4581D8
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2DEBE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D4581D8
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2DEBE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D4581D8
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2DEBE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3BF6C0]
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
       mov       rdx,7FFE2D4581D8
       call      qword ptr [7FFE2CBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D2DEBE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2CBE5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD21B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M03_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D485818]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3BF648]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CBE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3FE670]
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
       call      qword ptr [7FFE2D3FD740]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3C4958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB70C98
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
       call      qword ptr [7FFE2D3C4958]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB70C98
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
       mov       r11,7FFE2CB70C78
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFE2CB70C80
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2CC2C9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L21
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L24
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFE2CC27C48]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFE2D3FF768]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       mov       rsi,rbx
       jmp       short M00_L22
M00_L25:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFE2CD94AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L26
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE2CD94B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M00_L23
M00_L26:
       xor       ebx,ebx
       jmp       short M00_L23
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3FD830]
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFE2CB70C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L29:
       mov       rcx,r13
       mov       r11,7FFE2CB70C88
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
       mov       r11,7FFE2CB70C88
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
       call      qword ptr [7FFE2D3FD740]
       int       3
M00_L33:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L34
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3FD830]
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
       lea       rdx,[7FFE2D37AA30]
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
       mov       rdx,7FFE2D498078
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30E790]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D498078
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30E790]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D498078
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30E790]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3FF690]
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
       mov       rdx,7FFE2D498078
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D30E790]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2CC25C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD61B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M03_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D4C57A0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3FF6C0]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CC27C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
       cmp       [rax],al
       test      rbx,rbx
       je        near ptr M00_L19
       cmp       byte ptr [rax+38],0
       jne       near ptr M00_L20
       mov       rsi,[rax+8]
       mov       rax,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L27
       mov       rdx,[rsi+8]
       mov       [rbp-48],rdx
       xor       eax,eax
       mov       [rbp-34],eax
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3EE628]
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
       call      qword ptr [7FFE2D3ED788]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       je        near ptr M00_L12
       mov       r13,[rbp-40]
       mov       rsi,[r13]
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       mov       rdi,rcx
       cmp       rsi,rdi
       jne       short M00_L12
M00_L08:
       mov       rcx,r13
       call      qword ptr [7FFE2D3C0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[r13+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB60C98
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
       call      qword ptr [7FFE2D3C0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB60C98
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
       mov       r11,7FFE2CB60C78
       call      qword ptr [r11]
       jmp       short M00_L10
M00_L14:
       mov       rcx,r13
       mov       r11,7FFE2CB60C80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M00_L11
M00_L15:
       mov       rsi,[r13]
       mov       rdi,offset MT_System.Collections.Concurrent.ConcurrentQueue<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<Enumerate>d__26
       cmp       rsi,rdi
       jne       near ptr M00_L28
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       dword ptr [r13+28],0FFFFFFFE
M00_L16:
       mov       ebx,1
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
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
       call      M00_L29
       nop
M00_L19:
       xor       ebx,ebx
       jmp       short M00_L17
M00_L20:
       mov       rcx,rax
       call      qword ptr [7FFE2CC1C9C0]; System.Object.GetType()
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
       call      qword ptr [7FFE2D3EF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFE2CC17C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFE2CD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2CD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3ED878]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFE2CB60C90
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,r13
       mov       r11,7FFE2CB60C88
       call      qword ptr [r11]
       jmp       near ptr M00_L16
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
       mov       r11,7FFE2CB60C88
       call      qword ptr [r11]
M00_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L33
       cmp       qword ptr [rbp-48],0
       jne       short M00_L32
       xor       ecx,ecx
       call      qword ptr [7FFE2D3ED788]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3ED878]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 900
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
       lea       rdx,[7FFE2D37B830]
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
       mov       rdx,7FFE2D488348
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D488348
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D488348
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D30EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3EF708]
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
       mov       rdx,7FFE2D488348
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D30EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD51B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M03_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D4B5818]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3EF690]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M04_L00:
       test      eax,eax
       jne       short M04_L02
       cmp       rsi,rdi
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M04_L01:
       test      eax,eax
       jne       short M04_L07
M04_L02:
       cmp       rsi,rdi
       jne       short M04_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3DE658]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3DD788]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3B0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB50CC8
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
       call      qword ptr [7FFE2D3B0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB50CC8
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
       mov       r11,7FFE2CB50CA8
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFE2CB50CB0
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2CC0C9C0]; System.Object.GetType()
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
       call      qword ptr [7FFE2D3DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFE2CC07C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFE2CD74AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2CD74B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3DD878]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFE2CB50CC0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFE2CB50CB8
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
       mov       r11,7FFE2CB50CB8
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
       call      qword ptr [7FFE2D3DD788]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3DD878]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 883
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
       lea       rdx,[7FFE2D36BF00]
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
       mov       rdx,7FFE2D478110
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L13:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FEC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D478110
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L18:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FEC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D478110
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L22:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D2FEC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3DF6F0]
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
       mov       rdx,7FFE2D478110
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D2FEC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2CC05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD41B50
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M04_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D495710]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3DF720]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M05_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M05_L00:
       test      eax,eax
       jne       short M05_L02
       cmp       rsi,rdi
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M05_L01:
       test      eax,eax
       jne       short M05_L07
M05_L02:
       cmp       rsi,rdi
       jne       short M05_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3FE688]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      qword ptr [7FFE2D3FD788]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB70CC0
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
       call      qword ptr [7FFE2D3D0CA8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB70CC0
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
       mov       r11,7FFE2CB70CA0
       call      qword ptr [r11]
       jmp       short M00_L11
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFE2CB70CA8
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2CC2C9C0]; System.Object.GetType()
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
       call      qword ptr [7FFE2D3FF7C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFE2CC27C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M00_L21
M00_L24:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFE2CD94AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L25
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2CD94B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M00_L22
M00_L25:
       xor       esi,esi
       jmp       short M00_L22
M00_L26:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3FD878]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFE2CB70CB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,rsi
       mov       r11,7FFE2CB70CB0
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
       mov       r11,7FFE2CB70CB0
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
       call      qword ptr [7FFE2D3FD788]
       int       3
M00_L32:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D3FD878]
M00_L33:
       nop
       add       rsp,28
       ret
; Total bytes of code 883
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
       lea       rdx,[7FFE2D38BEF0]
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
       mov       rdx,7FFE2D497908
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D497908
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D497908
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3FF6D8]
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
       mov       rdx,7FFE2D497908
       call      qword ptr [7FFE2CC2C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D31EC10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2CC25C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE8C8453D0
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
       mov       rax,7FFE2CD61B50
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7223D0
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M04_L04
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE8C85BEF0
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
       call      qword ptr [7FFE2D4C57D0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE2D3FF720]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE2CC27C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      qword ptr [7FFE8C67BEB8]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M05_L04
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B750]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M05_L00:
       test      eax,eax
       jne       short M05_L02
       cmp       rsi,rdi
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B790]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M05_L01:
       test      eax,eax
       jne       short M05_L07
M05_L02:
       cmp       rsi,rdi
       jne       short M05_L06
       mov       rcx,rbx
       call      qword ptr [7FFE8C67B7A8]; Precode of System.RuntimeType.GetCorElementType()
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
       call      qword ptr [7FFE8C67B1D0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE8C668FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L00
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D3F5F50]
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
       call      qword ptr [7FFE2D30E628]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D3EF2E8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L17
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L08
       mov       rdx,rbx
       mov       r11,7FFE2CB60F28
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
       call      qword ptr [7FFE2D3EF2E8]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB60F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L11
       jmp       short M00_L09
M00_L14:
       mov       rcx,rsi
       mov       r11,7FFE2CB60F08
       call      qword ptr [r11]
       jmp       short M00_L12
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFE2CB60F10
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2D3F7B88]
       int       3
M00_L21:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D30E718]
       jmp       near ptr M00_L06
M00_L22:
       mov       rcx,rsi
       mov       r11,7FFE2CB60F20
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFE2CB60F18
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
       mov       r11,7FFE2CB60F18
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
       call      qword ptr [7FFE2D30E628]
       int       3
M00_L27:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L28
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D30E718]
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
       lea       rdx,[7FFE2D391D50]
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
       mov       rdx,7FFE2D45FB40
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3F5248]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D45FB40
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3F5248]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D45FB40
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D3F5248]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D3F7B70]
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
       mov       rdx,7FFE2D45FB40
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D3F5248]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,[rcx+2D8]
       mov       rbx,[rcx+208]
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
       call      00007FFE8C89DF30
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
       call      qword ptr [7FFE2D2BEC88]
       int       3
M00_L05:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE2D2BE220]
       jmp       short M00_L00
M00_L06:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
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
       call      qword ptr [7FFE2D41D480]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        short M00_L09
       mov       rdx,rbx
       mov       r11,7FFE2CB41060
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
       call      qword ptr [7FFE2D41D480]; System.Collections.Concurrent.ConcurrentQueue`1+<Enumerate>d__26[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       r11,7FFE2CB41060
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L12
       jmp       short M00_L10
M00_L15:
       mov       rcx,rsi
       mov       r11,7FFE2CB41040
       call      qword ptr [r11]
       jmp       short M00_L13
M00_L16:
       mov       rcx,rsi
       mov       r11,7FFE2CB41048
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
       mov       rax,[rcx+88]
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
       call      qword ptr [7FFE2D4076F0]
       int       3
M00_L22:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2BE238]
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFE2CB41058
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L08
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFE2CB41050
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
       mov       r11,7FFE2CB41050
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
       call      qword ptr [7FFE2D2BEC88]
       int       3
M00_L28:
       mov       rcx,[rbp-48]
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FFE2D2BE238]
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
       lea       rdx,[7FFE2D3A2570]
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
       mov       rdx,7FFE2D453C60
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L11:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D4067A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D453C60
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D4067A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       mov       rdx,7FFE2D453C60
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       r8d,[rbx+38]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFE2D4067A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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
       call      qword ptr [7FFE2D4076D8]
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
       mov       rdx,7FFE2D453C60
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L28:
       mov       r8d,esi
       mov       rdx,[rbx+18]
       call      qword ptr [7FFE2D4067A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueueSegment`1<System.__Canon>, Int32)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3D66A0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF76238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D2FF738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D31B380
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D31B3C0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D31B590
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3EA5F8
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D1AF390]
       mov       ecx,2A41
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3DD020]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3DD038]
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
       mov       rdx,7FFE2D31B380
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D31B590
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CC06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D31B380
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3C67F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF66238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D2EF798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B380
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B3C0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B590
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3DA6E0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D19F3F0]
       mov       ecx,2A41
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3CD020]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3CD038]
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
       mov       rdx,7FFE2D30B380
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D30B590
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CBF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B380
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3E67F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF86238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D30F798]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B3C0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B590
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3FA6E0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D1BF3F0]
       mov       ecx,2A41
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3ED170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3ED188]
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
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D32B590
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CC16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3E6748]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF86238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D30F7E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B3C0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B590
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3FA5F8
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D1BF408]
       mov       ecx,2A41
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3EC8B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3EC8D0]
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
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D32B590
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CC16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B380
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3E6820]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF86238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D30F7C8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B3A0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B3E0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B5B0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3FA6E0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D1BF3F0]
       mov       ecx,2A41
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3ED068]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3ED080]
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
       mov       rdx,7FFE2D32B3A0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D32B5B0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CC16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D32B3A0
       call      qword ptr [7FFE2CC1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       rdx,[rbx+2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3D6730]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+88]
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
       call      qword ptr [7FFE2CF66238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       jmp       qword ptr [7FFE2D2EF6F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B3D0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B410
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B5E0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFE2D3CA6E0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFE2D19F090]
       mov       ecx,2A41
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D3DF9A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2D3DE700]
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
       mov       rdx,7FFE2D30B3D0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D30B5E0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1+<>c[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__10_0(System.__Canon)
       call      qword ptr [7FFE2CBF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFE2D30B3D0
       call      qword ptr [7FFE2CBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3EF900]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D3EF8E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rdx,7FFE2D48C118
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rax,1BBDD0419A0
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1BBDD030008
       call      qword ptr [7FFE2D1AEEE0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFE2D3CEED0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D3CEED0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D3CF0E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFE2CC06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFE2D3CEED0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D3CEF10
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D3CF0E0
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-48],rax
M01_L14:
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       call      qword ptr [7FFE2CF76238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+10]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       call      qword ptr [7FFE2CC06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFE2D48C170
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-58],rax
M01_L16:
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-50]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE2D3EC990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       call      qword ptr [7FFE2D3EFD50]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D3EFD20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctBlockingCollectionBenchmark.ContainsAny()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rdx,[rax+2E0]
       mov       rax,[rbp+10]
       mov       rcx,[rax+2D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D41FBE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].ContainsAny(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-4],eax
       mov       edx,[rbp-4]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE2D41FBD0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rdx,7FFE2D541440
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-10],rax
M01_L01:
       mov       rax,287D0411A90
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,287D0400008
       call      qword ptr [7FFE2D1AF348]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       mov       rdx,7FFE2D448B58
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D448B58
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D448D68
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFE2CC06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFE2D448B58
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D448B98
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFE2D448D68
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-48],rax
M01_L14:
       mov       rcx,[rbp-48]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-30]
       call      qword ptr [7FFE2CF76238]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+10]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctBlockingCollection`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       call      qword ptr [7FFE2CC06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFE2D541498
       call      qword ptr [7FFE2CC0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-58],rax
M01_L16:
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-50]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE2D41CD98]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       call      qword ptr [7FFE2D554030]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D554000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

