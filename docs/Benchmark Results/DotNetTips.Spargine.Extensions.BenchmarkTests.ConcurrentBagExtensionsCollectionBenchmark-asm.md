## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,1A7BBC00898
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC708D650]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
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
       call      qword ptr [7FFCC6885A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        near ptr M00_L09
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67D0DE0
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
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       jbe       short M00_L08
       mov       rcx,r10
       call      qword ptr [7FFCC72657A0]
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L27
       mov       rax,[rbp-90]
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L13
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L14
M00_L11:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L12
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67D0DD8
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L24
M00_L12:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L23
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L11
       jmp       short M00_L14
M00_L13:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L15
       mov       [rbp-84],edx
M00_L14:
       cmp       dword ptr [r15+40],0
       jle       short M00_L17
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L38
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L19
M00_L15:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L16
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L24
M00_L16:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L23
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L15
       mov       [rbp-84],edx
       jmp       short M00_L14
M00_L17:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L18
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A24FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC71D7408]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L18:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L19:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L38
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jmp       short M00_L22
M00_L20:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L37
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L39
M00_L21:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L22:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L40
M00_L23:
       call      qword ptr [7FFCC6B079A8]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FFCC7265E48]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L27:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71D57B8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71D57B8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC72657B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,1E83AC92968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FFCC708CE70]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC708D770]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L43
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L49
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L44
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L45
M00_L41:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC71E6110
       call      qword ptr [7FFCC71D5548]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L42:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC7214E70
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D70A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L43:
       call      qword ptr [7FFCC6F569E8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C85D90
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC708C738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC708C750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       rcx,rax
       mov       r11,7FFCC67D0E08
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L41
M00_L45:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D0E10
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L46:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D0E18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L48
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D0E20
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC708D788]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L47
       mov       rcx,r15
       call      qword ptr [7FFCC708D8A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L47:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC708D8D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L46
M00_L48:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D0E28
       call      qword ptr [r11]
       jmp       near ptr M00_L42
M00_L49:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D0DE8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D0DF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D0DF8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D2FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L50
M00_L51:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D0E00
       call      qword ptr [r11]
       jmp       near ptr M00_L42
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L52
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC708D770]; System.Threading.Lock.Exit(ThreadId)
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L53
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D0E28
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L54
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D0E00
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC708D698]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       lea       rax,[7FFD25671390]
       xor       ecx,ecx
       mov       edx,48
M02_L00:
       mov       r8d,[rax+rcx]
       cmp       r8d,ebx
       jl        short M02_L01
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       add       rcx,4
       dec       edx
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC08]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB200]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       cmp       esi,7FFFFFFF
       jge       short M02_L07
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFD262F7F98]
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
       jne       short M02_L06
M02_L05:
       add       esi,2
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L07
M02_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L07:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 177
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M03_L01
M03_L00:
       mov       ecx,edx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       jmp       qword ptr [rax]
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 37
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        short M05_L09
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       vzeroupper
       ret
M05_L06:
       cmp       r8,800
       ja        near ptr M05_L12
       cmp       r8,100
       jae       short M05_L10
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L04
M05_L10:
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
M05_L11:
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC7266388]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC72663A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M07_L08
M07_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M07_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M07_L03
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
       jne       short M07_L04
       cmp       r8,14
       jne       near ptr M07_L15
       jmp       near ptr M07_L14
M07_L04:
       cmp       r8,4000
       ja        near ptr M07_L13
       jmp       near ptr M07_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M07_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M07_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M07_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L05
M07_L13:
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
M07_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M07_L05
M07_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L05
M07_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M08_L05
M08_L01:
       add       rsp,38
       ret
M08_L02:
       cmp       r10,1
       je        short M08_L03
       mov       r8,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L01
M08_L03:
       movzx     r8d,byte ptr [rdx]
       mov       [rcx],r8b
       jmp       short M08_L01
M08_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFD262E9398]
       jmp       short M08_L01
M08_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M08_L01
; Total bytes of code 235
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M09_L02
       cmp       dword ptr [rcx+18],0
       jne       short M09_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M09_L03
M09_L00:
       add       rsp,28
       ret
M09_L01:
       dec       dword ptr [rcx+18]
       jmp       short M09_L00
M09_L02:
       call      qword ptr [7FFCC7264E40]
       int       3
M09_L03:
       call      qword ptr [7FFCC71D7DF8]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M10_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M10_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M10_L01
       cmp       [r10],rcx
       je        short M10_L07
M10_L00:
       cmp       [r10+8],rcx
       je        short M10_L07
       cmp       [r10+10],rcx
       je        short M10_L07
       cmp       [r10+18],rcx
       je        short M10_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M10_L05
       test      r8,r8
       je        short M10_L03
M10_L01:
       cmp       [r10],rcx
       je        short M10_L07
M10_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M10_L04
M10_L03:
       test      dword ptr [rax],500C0000
       je        short M10_L06
       jmp       qword ptr [7FFCC6D2EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M10_L04:
       cmp       [r10],rcx
       je        short M10_L07
       jmp       short M10_L02
M10_L05:
       cmp       [r10],rcx
       je        short M10_L07
       jmp       short M10_L00
M10_L06:
       xor       edx,edx
M10_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M11_L19
M11_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M11_L20
       test      eax,eax
       jl        near ptr M11_L20
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M11_L20
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M11_L20
       cmp       byte ptr [rdi+1C],0
       je        near ptr M11_L20
       mov       r14,[rcx+20]
M11_L01:
       test      r14,r14
       je        near ptr M11_L21
M11_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M11_L09
M11_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M11_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M11_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M11_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M11_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M11_L14
       mov       [r14+24],ecx
       jmp       near ptr M11_L17
M11_L05:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       mov       rcx,r14
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M11_L10
M11_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jge       near ptr M11_L11
M11_L07:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       jne       short M11_L08
       lock inc  qword ptr [rsi]
M11_L08:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       short M11_L04
M11_L09:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M11_L03
       mov       rcx,r14
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L03
M11_L10:
       mov       rcx,r14
       call      qword ptr [7FFCC71D7D38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L06
M11_L11:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M11_L12
       mov       rcx,rax
       jmp       short M11_L13
M11_L12:
       mov       rdx,7FFCC7221F30
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M11_L13:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       short M11_L15
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M11_L16
M11_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L15:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M11_L16:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
       jmp       near ptr M11_L07
M11_L17:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M11_L18
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M11_L22
M11_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC7220AE0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L00
M11_L20:
       mov       rcx,rdi
       call      qword ptr [7FFCC708D7A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M11_L01
M11_L21:
       mov       rcx,rsi
       call      qword ptr [7FFCC708D8A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M11_L02
M11_L22:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M11_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M11_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M11_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M11_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 859
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M12_L32
       test      rsi,rsi
       je        near ptr M12_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M12_L08
M12_L00:
       mov       rcx,1A7A5C01FF8
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M12_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M12_L34
M12_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M12_L09
M12_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M12_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M12_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M12_L28
M12_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M12_L29
M12_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M12_L30
       xor       esi,esi
M12_L05:
       test      edx,edx
       jne       near ptr M12_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M12_L35
       mov       r14d,ecx
       dec       r14d
M12_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC71E6CE0
       call      qword ptr [7FFCC71D5788]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M12_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC722B1B8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M12_L00
M12_L09:
       mov       rcx,r14
       mov       rdx,7FFCC722BB50
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L02
M12_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M12_L15
M12_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M12_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M12_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M12_L25
M12_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M12_L26
M12_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M12_L27
M12_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC7263090
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC71E6CE0
       xor       r8d,r8d
       call      qword ptr [7FFCC71D5788]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M12_L07
M12_L15:
       mov       rcx,r14
       mov       rdx,7FFCC722BB70
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L11
M12_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M12_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M12_L21
M12_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M12_L22
M12_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M12_L23
M12_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M12_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M12_L24
M12_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC7265F80]
       jmp       near ptr M12_L07
M12_L21:
       mov       rcx,r14
       mov       rdx,7FFCC722C0E0
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L17
M12_L22:
       mov       rdx,7FFCC722C3C8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M12_L18
M12_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC722C8E8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L19
M12_L24:
       mov       rcx,r14
       mov       rdx,7FFCC722C118
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M12_L20
M12_L25:
       mov       rcx,r14
       mov       rdx,7FFCC722C2E0
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M12_L12
M12_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC72AA920
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L13
M12_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC72AA938
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M12_L14
M12_L28:
       mov       rcx,r14
       mov       rdx,7FFCC722C318
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L03
M12_L29:
       mov       rdx,7FFCC722CBB8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M12_L04
M12_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M12_L05
M12_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M12_L06
M12_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC71E40B0
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC7264FA8]
       int       3
M12_L33:
       mov       ecx,38B
       mov       rdx,7FFCC71E40B0
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC7264FA8]
       int       3
M12_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC7265C50]
       int       3
M12_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,1E83AC80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFCC7267E88]
       int       3
; Total bytes of code 244
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
       je        short M15_L01
M15_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M15_L02
       test      ecx,ecx
       jl        short M15_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M15_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M15_L02
       cmp       byte ptr [rbx+1C],0
       je        short M15_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M15_L01:
       mov       rdx,7FFCC7220AE0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M15_L00
M15_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC708D7A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M16_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M16_L15
M16_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M16_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M16_L02
M16_L01:
       cmp       [rsi+30],eax
       je        near ptr M16_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M16_L01
M16_L02:
       xor       esi,esi
M16_L03:
       test      rsi,rsi
       jne       near ptr M16_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M16_L10
M16_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M16_L11
       mov       rcx,rax
M16_L05:
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
M16_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M16_L12
M16_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M16_L08
       test      ecx,ecx
       jl        short M16_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M16_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M16_L13
M16_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC708D7D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M16_L17
M16_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M16_L03
M16_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC7229BF0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M16_L04
M16_L11:
       mov       rdx,7FFCC7221F30
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M16_L05
M16_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC7220AE0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M16_L07
M16_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M16_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M16_L17
M16_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC7264FA8]
       int       3
M16_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC71D7D38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M16_L00
M16_L16:
       jmp       near ptr M16_L03
M16_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M16_L19
M16_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M16_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M16_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M16_L21
       cmp       qword ptr [rbp-28],0
       jne       short M16_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC7264FA8]
       int       3
M16_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M16_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M16_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M17_L09
M17_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M17_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M17_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M17_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M17_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M17_L12
       mov       [rcx+24],eax
       jmp       near ptr M17_L14
M17_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L10
M17_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       short M17_L06
M17_L04:
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
       jne       short M17_L05
       lock inc  qword ptr [rsi]
M17_L05:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M17_L01
M17_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L11
M17_L07:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M17_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M17_L08:
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
       jmp       near ptr M17_L04
M17_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M17_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M17_L00
M17_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71D7D38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L03
M17_L11:
       mov       rcx,rdx
       mov       rdx,7FFCC7221F30
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M17_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M17_L08
M17_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M17_L16
M17_L15:
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
M17_L16:
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L15
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M17_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M17_L17:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M17_L18
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L18
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 704
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M18_L19
M18_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M18_L20
       test      eax,eax
       jl        near ptr M18_L20
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M18_L20
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M18_L20
       cmp       byte ptr [rsi+1C],0
       je        near ptr M18_L20
       mov       rdi,[rcx+20]
M18_L01:
       test      rdi,rdi
       je        near ptr M18_L21
M18_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M18_L09
M18_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M18_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M18_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M18_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M18_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M18_L14
       mov       [rdi+24],ecx
       jmp       near ptr M18_L17
M18_L05:
       xor       eax,eax
       mov       [rdi+2C],eax
       mov       rcx,rdi
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M18_L10
M18_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jge       near ptr M18_L11
M18_L07:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       jne       short M18_L08
       lock inc  qword ptr [rsi]
M18_L08:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       short M18_L04
M18_L09:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M18_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L03
M18_L10:
       mov       rcx,rdi
       call      qword ptr [7FFCC71D7D38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L06
M18_L11:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M18_L12
       mov       rcx,rax
       jmp       short M18_L13
M18_L12:
       mov       rdx,7FFCC7221F30
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M18_L13:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       short M18_L15
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M18_L16
M18_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L15:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M18_L16:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       jmp       near ptr M18_L07
M18_L17:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M18_L18
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M18_L22
M18_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC7220AE0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L00
M18_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC708D7A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M18_L01
M18_L21:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC708D8A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M18_L02
M18_L22:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M18_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M18_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M18_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M18_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71D7E58]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M18_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 852
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,16DE9C00880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC71D51D0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67F12E8
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67F12E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A44FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC71DEF70]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B279A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC73B5FB0]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F7DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71DD290]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71DD290]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC72A5F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,1AE68C52968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC71D49F0]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D52F0]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC724A610
       call      qword ptr [7FFCC71DD020]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC7279058
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71DE988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F7E5C8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71D42B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71D42D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67F1310
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F1318
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1320
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1328
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5308]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC71D5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1330
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F12F0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F12F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1300
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D4FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1308
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D52F0]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1330
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1308
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC71D5218]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
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
       mov       rsi,7FFD25671390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCC7302C60
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
       mov       rcx,7FFCC7302C64
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC72A7CC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D459E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC72A7CD8]
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
       mov       rcx,7FFCC7302C6C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCC7302C70
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCC7302C68
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
       mov       rcx,7FFCC7302C74
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
       mov       rcx,7FFCC73228E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC73228D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC73228DC
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       jb        near ptr M06_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L11
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
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L00
M06_L02:
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L00
M06_L03:
       cmp       r8,40
       ja        short M06_L06
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L09
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L00
M06_L06:
       cmp       r8,800
       ja        near ptr M06_L12
       cmp       r8,100
       jae       short M06_L10
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
       ja        short M06_L04
       jmp       short M06_L05
M06_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L10:
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
M06_L11:
       cmp       rcx,rdx
       jne       short M06_L12
       cmp       [rdx],dl
       jmp       near ptr M06_L00
M06_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC73B6628]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC73B6640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC73AA218
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC73AA23C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC73AA234
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC73AA240
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC72A5F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F7DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC73AA21C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC73AA220
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC73AA224
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC73AA228
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC73AA22C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC73AA230
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC73AA238
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC73B4C48]
       int       3
M10_L03:
       call      qword ptr [7FFCC71DF978]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L07
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L07
       cmp       [r10+10],rcx
       je        short M11_L07
       cmp       [r10+18],rcx
       je        short M11_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L05
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L07
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L04
M11_L03:
       test      dword ptr [rax],500C0000
       je        short M11_L06
       jmp       qword ptr [7FFCC6D4EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L04:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L02
M11_L05:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L00
M11_L06:
       xor       edx,edx
M11_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L20
M12_L00:
       mov       rcx,rax
       call      qword ptr [7FFCC68A5908]; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L21
       test      eax,eax
       jl        near ptr M12_L21
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L21
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L21
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L21
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L22
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L12
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      qword ptr [7FFCC68A57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L16
       mov       [r14+24],ecx
       jmp       near ptr M12_L18
M12_L05:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       mov       rcx,r14
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M12_L13
M12_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jge       short M12_L09
M12_L07:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      qword ptr [7FFCC68A57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       jne       short M12_L08
       lock inc  qword ptr [rsi]
M12_L08:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       short M12_L04
M12_L09:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L15
       jmp       near ptr M12_L14
M12_L10:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L17
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L11:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
       jmp       near ptr M12_L07
M12_L12:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L13:
       mov       rcx,r14
       call      qword ptr [7FFCC71DF8B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M12_L06
M12_L14:
       mov       rcx,rax
       jmp       near ptr M12_L10
M12_L15:
       mov       rdx,7FFCC737F0B8
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L10
M12_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L17:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L11
M12_L18:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L19
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L23
M12_L19:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L20:
       mov       rcx,rdx
       mov       rdx,7FFCC737EF38
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L21:
       mov       rcx,rdi
       call      qword ptr [7FFCC71D5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L22:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L23:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L19
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L24
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M12_L24:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L25
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L25
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L25:
       nop
       add       rsp,28
       ret
; Total bytes of code 882
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,16DD3C02010
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC724B1E0
       call      qword ptr [7FFCC71DD260]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC73DBBD8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC73DC570
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC73B8780
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC724B1E0
       xor       r8d,r8d
       call      qword ptr [7FFCC71DD260]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC73DC590
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC73B6220]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC73DCB00
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC73DCDE8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC73DD308
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC73DCB38
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC73DCD00
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC74DF560
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC74DF578
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC73DCD38
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC73DD5D8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC72485B0
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A68F8]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC72485B0
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A68F8]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC73B52C0]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M15_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M15_L01
       test      rsi,rsi
       je        short M15_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M15_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M15_L00:
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
M15_L01:
       test      rsi,rsi
       je        short M15_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L03
M15_L02:
       mov       rax,1AE68C40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L03:
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
M15_L04:
       call      qword ptr [7FFCC72AD2A8]
       int       3
; Total bytes of code 244
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC737EF38
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC71D5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC71D5350]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC73D3F28
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC737F0B8
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC737EF38
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC72A68F8]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC71DF8B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC72A68F8]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M18_L09
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M18_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M18_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M18_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L12
       mov       [rcx+24],eax
       jmp       near ptr M18_L14
M18_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M18_L10
M18_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       short M18_L06
M18_L04:
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
       jne       short M18_L05
       lock inc  qword ptr [rsi]
M18_L05:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M18_L01
M18_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M18_L11
M18_L07:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M18_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M18_L08:
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
       jmp       near ptr M18_L04
M18_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71DF8B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L03
M18_L11:
       mov       rcx,rdx
       mov       rdx,7FFCC737F0B8
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L07
M18_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M18_L08
M18_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M18_L16
M18_L15:
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
M18_L16:
       call      00007FFD26476030
       test      eax,eax
       je        short M18_L15
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M18_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L17:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M18_L18
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       je        short M18_L18
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M18_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 704
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L19
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L20
       test      eax,eax
       jl        near ptr M19_L20
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L20
       mov       eax,eax
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L20
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L20
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L21
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L12
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L15
       mov       [rdi+24],ecx
       jmp       near ptr M19_L17
M19_L05:
       xor       eax,eax
       mov       [rdi+2C],eax
       mov       rcx,rdi
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M19_L13
M19_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jge       short M19_L09
M19_L07:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       jne       short M19_L08
       lock inc  qword ptr [rsi]
M19_L08:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       short M19_L04
M19_L09:
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L14
       mov       rcx,rax
M19_L10:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L16
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L11:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
       jmp       near ptr M19_L07
M19_L12:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L13:
       mov       rcx,rdi
       call      qword ptr [7FFCC71DF8B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M19_L06
M19_L14:
       mov       rdx,7FFCC737F0B8
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L10
M19_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L16:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L11
M19_L17:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L18
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L22
M19_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC737EF38
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L21:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71D5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L22:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M19_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 864
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,257D1000880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC71D52D8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67F1318
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67F1310
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A44FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC71DF090]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B279A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC73B6070]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71DD440]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71DD440]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC72A5ED8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,29850052968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC71D4AE0]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D53F8]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC724E728
       call      qword ptr [7FFCC71DD1D0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC727D240
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71DEB50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F7E6D0]
       mov       ecx,0AB
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71D43A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71D43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67F1340
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F1348
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1350
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1358
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5410]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC71D5530]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5560]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1360
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F1320
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1328
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1330
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D4FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1338
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D53F8]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1360
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1338
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC71D5320]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
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
       mov       rsi,7FFD25671390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCC73027D0
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
       mov       rcx,7FFCC73027D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC72A7C48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D459E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC72A7C60]
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
       mov       rcx,7FFCC73027DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCC73027E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCC73027D8
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
       mov       rcx,7FFCC73027E4
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
       mov       rcx,7FFCC73227C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC73227C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC73227C4
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       jb        near ptr M06_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L11
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
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L00
M06_L02:
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L00
M06_L03:
       cmp       r8,40
       ja        short M06_L06
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L09
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L00
M06_L06:
       cmp       r8,800
       ja        near ptr M06_L12
       cmp       r8,100
       jae       short M06_L10
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
       ja        short M06_L04
       jmp       short M06_L05
M06_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L10:
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
M06_L11:
       cmp       rcx,rdx
       jne       short M06_L12
       cmp       [rdx],dl
       jmp       near ptr M06_L00
M06_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC73B65E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC73B65F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC73AA218
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC73AA23C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC73AA234
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC73AA240
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC72A5ED8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC73AA21C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC73AA220
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC73AA224
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC73AA228
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC73AA22C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC73AA230
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC73AA238
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC73B47F8]
       int       3
M10_L03:
       call      qword ptr [7FFCC71DFA68]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L06
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L06
       cmp       [r10+10],rcx
       je        short M11_L06
       cmp       [r10+18],rcx
       je        short M11_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L04
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L06
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M11_L03
       cmp       [r10],rcx
       je        short M11_L06
       jmp       short M11_L02
M11_L03:
       test      dword ptr [rax],500C0000
       je        short M11_L05
       jmp       qword ptr [7FFCC6D4EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L04:
       cmp       [r10],rcx
       je        short M11_L06
       jmp       short M11_L00
M11_L05:
       xor       edx,edx
M11_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L18
M12_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L19
       test      eax,eax
       jl        near ptr M12_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L19
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L19
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L20
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L11
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L14
       mov       [r14+24],ecx
       jmp       near ptr M12_L16
M12_L05:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       mov       rcx,r14
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M12_L12
M12_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jl        short M12_L09
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L13
       mov       rcx,rax
M12_L07:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L15
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L08:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
M12_L09:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       jne       short M12_L10
       lock inc  qword ptr [rsi]
M12_L10:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       near ptr M12_L04
M12_L11:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L12:
       mov       rcx,r14
       call      qword ptr [7FFCC71DF0A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M12_L06
M12_L13:
       mov       rdx,7FFCC737F6F0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L07
M12_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L15:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L08
M12_L16:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L17
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L21
M12_L17:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L18:
       mov       rcx,rdx
       mov       rdx,7FFCC737EE08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L19:
       mov       rcx,rdi
       call      qword ptr [7FFCC71D5428]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D5530]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L21:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L17
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L22
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M12_L22:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L23
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L23
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 867
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,257BB002010
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC724F2F8
       call      qword ptr [7FFCC71DD410]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC73DC4D0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC73DCE68
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC73B86D8
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC724F2F8
       xor       r8d,r8d
       call      qword ptr [7FFCC71DD410]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC73DCE88
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC73B61D8]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC73DD3F8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC73DD6E0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC73DDC00
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC73DD430
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC73DD5F8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC74DE640
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC74DE658
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC73DD630
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC73DDED0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC724C6C8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6880]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC724C6C8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6880]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC73B52C0]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M15_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M15_L01
       test      rsi,rsi
       je        short M15_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M15_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M15_L00:
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
M15_L01:
       test      rsi,rsi
       je        short M15_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L03
M15_L02:
       mov       rax,29850040008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L03:
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
M15_L04:
       call      qword ptr [7FFCC72AD230]
       int       3
; Total bytes of code 244
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC737EE08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC71D5428]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC71D5458]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC73D4B80
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC737F6F0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC737EE08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6880]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC71DF0A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6880]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M18_L08
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M18_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M18_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M18_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L11
       mov       [rcx+24],eax
       jmp       near ptr M18_L13
M18_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M18_L09
M18_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M18_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M18_L10
M18_L04:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M18_L12
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M18_L05:
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
M18_L06:
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
       jne       short M18_L07
       lock inc  qword ptr [rsi]
M18_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M18_L01
M18_L08:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L09:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71DF0A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L03
M18_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC737F6F0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L04
M18_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L12:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M18_L05
M18_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M18_L15
M18_L14:
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
M18_L15:
       call      00007FFD26476030
       test      eax,eax
       je        short M18_L14
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M18_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M18_L17
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       je        short M18_L17
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M18_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 702
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L18
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L19
       test      eax,eax
       jl        near ptr M19_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L19
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L19
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L20
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L11
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L14
       mov       [rdi+24],ecx
       jmp       near ptr M19_L16
M19_L05:
       xor       eax,eax
       mov       [rdi+2C],eax
       mov       rcx,rdi
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M19_L12
M19_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jl        short M19_L09
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L13
       mov       rcx,rax
M19_L07:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L15
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
M19_L09:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       jne       short M19_L10
       lock inc  qword ptr [rsi]
M19_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       near ptr M19_L04
M19_L11:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L12:
       mov       rcx,rdi
       call      qword ptr [7FFCC71DF0A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M19_L06
M19_L13:
       mov       rdx,7FFCC737F6F0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L07
M19_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L15:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L08
M19_L16:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L17
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L21
M19_L17:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L18:
       mov       rcx,rdx
       mov       rdx,7FFCC737EE08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L19:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D5428]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L20:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71D5530]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L21:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L17
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L22
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M19_L22:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L23
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L23
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF9D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 860
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,25BD0800880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC71B51D0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6885A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67D1208
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67D1200
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A24FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC71BEEE0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B079A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC7395440]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F5E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71BD350]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71BD350]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC7285F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,29C4F7C2968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC71B4A20]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71B52F0]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC722E728
       call      qword ptr [7FFCC71BD0E0]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC725CA40
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71BE9A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F5E5C8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C85D90
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71B42E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71B4300]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67D1230
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D1238
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1240
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1248
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71B5308]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC71B5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71B5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1250
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D1210
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1218
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1220
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D2FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1228
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71B52F0]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1250
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1228
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC71B5218]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
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
       mov       rsi,7FFD25671390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCC72E2928
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
       mov       rcx,7FFCC72E292C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC7287C78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D259E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC7287C90]
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
       mov       rcx,7FFCC72E2934
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCC72E2938
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCC72E2930
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
       mov       rcx,7FFCC72E293C
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
       mov       rcx,7FFCC7302EE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC6885A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC7302ED8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC7302EDC
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFCC68866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC7395950]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC7395968]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC7389F78
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC7389F9C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC7389F94
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC7389FA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC7285F20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F5E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC7389F7C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC7389F80
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC7389F84
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC7389F88
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC7389F8C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC7389F90
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC7389F98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC7394780]
       int       3
M10_L03:
       call      qword ptr [7FFCC7285608]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L07
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L07
       cmp       [r10+10],rcx
       je        short M11_L07
       cmp       [r10+18],rcx
       je        short M11_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L05
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L07
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L04
M11_L03:
       test      dword ptr [rax],500C0000
       je        short M11_L06
       jmp       qword ptr [7FFCC6D2EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L04:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L02
M11_L05:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L00
M11_L06:
       xor       edx,edx
M11_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L19
M12_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L21
       test      eax,eax
       jl        near ptr M12_L21
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L21
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L21
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L21
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L20
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L12
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L15
       mov       [r14+24],ecx
       jmp       near ptr M12_L17
M12_L05:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       mov       rcx,r14
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M12_L13
M12_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jl        short M12_L09
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L14
       mov       rcx,rax
M12_L07:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L16
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L08:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
M12_L09:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       je        short M12_L11
M12_L10:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       near ptr M12_L04
M12_L11:
       lock inc  qword ptr [rsi]
       jmp       short M12_L10
M12_L12:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L13:
       mov       rcx,r14
       call      qword ptr [7FFCC72855D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M12_L06
M12_L14:
       mov       rdx,7FFCC735F638
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L07
M12_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L16:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L08
M12_L17:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L18
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L22
M12_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC735EA78
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71B5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L21:
       mov       rcx,rdi
       call      qword ptr [7FFCC71B5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L22:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M12_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 869
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,25BBA802010
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC722F2F8
       call      qword ptr [7FFCC71BD320]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC73B8488
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC73B8E20
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC7393990
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC722F2F8
       xor       r8d,r8d
       call      qword ptr [7FFCC71BD320]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC73B8E40
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC7395548]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC73B93B0
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC73B9698
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC73B9BB8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC73B93E8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC73B95B0
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC749AEB8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC749AED0
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC73B95E8
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC73B9E88
       call      qword ptr [7FFCC6B07AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC722C6C8
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC7286838]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC722C6C8
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC7286838]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC7395230]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M15_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M15_L01
       test      rsi,rsi
       je        short M15_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M15_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M15_L00:
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
M15_L01:
       test      rsi,rsi
       je        short M15_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L03
M15_L02:
       mov       rax,29C4F7B0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L03:
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
M15_L04:
       call      qword ptr [7FFCC728D2F0]
       int       3
; Total bytes of code 244
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC735EA78
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC71B5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC71B5350]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC73B4AC0
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC735F638
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC735EA78
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC7286838]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC72855D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC7286838]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M18_L09
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M18_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M18_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M18_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L12
       mov       [rcx+24],eax
       jmp       near ptr M18_L14
M18_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M18_L10
M18_L03:
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M18_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M18_L11
M18_L04:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M18_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M18_L05:
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
M18_L06:
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
       je        short M18_L08
M18_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M18_L01
M18_L08:
       lock inc  qword ptr [rsi]
       jmp       short M18_L07
M18_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC72855D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L03
M18_L11:
       mov       rcx,rdx
       mov       rdx,7FFCC735F638
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L04
M18_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M18_L05
M18_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M18_L16
M18_L15:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L16:
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M18_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M18_L17:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M18_L18
       mov       rcx,rdi
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M18_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 675
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L19
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L20
       test      eax,eax
       jl        near ptr M19_L20
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L20
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L20
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L20
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L21
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L12
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L15
       mov       [rdi+24],ecx
       jmp       near ptr M19_L17
M19_L05:
       xor       eax,eax
       mov       [rdi+2C],eax
       mov       rcx,rdi
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M19_L13
M19_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jl        short M19_L09
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L14
       mov       rcx,rax
M19_L07:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L16
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L08:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
M19_L09:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       je        short M19_L11
M19_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       near ptr M19_L04
M19_L11:
       lock inc  qword ptr [rsi]
       jmp       short M19_L10
M19_L12:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L13:
       mov       rcx,rdi
       call      qword ptr [7FFCC72855D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M19_L06
M19_L14:
       mov       rdx,7FFCC735F638
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L07
M19_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L16:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L08
M19_L17:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L18
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L22
M19_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC735EA78
       call      qword ptr [7FFCC688C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71B5320]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L21:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71B5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L22:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M19_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M19_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC72855F0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 862
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,2FA8B000880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC71D5350]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67F1070
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67F1068
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A44FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC71DEEC8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B279A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC73B5368]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71DD398]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71DD398]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC72A5F08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,33B09F82968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC71D4A08]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D5470]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC724E618
       call      qword ptr [7FFCC71DD128]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC727C6E0
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71DE940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F7E5C8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71D42D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71D42E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67F1098
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F10A0
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F10A8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F10B0
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5488]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC71D55A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D55D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F10B8
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F1078
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1088
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D4FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1090
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71D5470]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F10B8
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F1090
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC71D5398]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
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
       mov       rsi,7FFD25671390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCC73072C0
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
       mov       rcx,7FFCC73072C4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC72A7D20]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D459E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC72A7D38]
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
       mov       rcx,7FFCC73072CC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCC73072D0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCC73072C8
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
       mov       rcx,7FFCC73072D4
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
       mov       rcx,7FFCC7327A50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC7327A48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC7327A4C
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       jb        near ptr M06_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L11
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
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L00
M06_L02:
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L00
M06_L03:
       cmp       r8,40
       ja        short M06_L06
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M06_L09
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M06_L00
M06_L06:
       cmp       r8,800
       ja        near ptr M06_L12
       cmp       r8,100
       jae       short M06_L10
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
       ja        short M06_L04
       jmp       short M06_L05
M06_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M06_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L10:
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
M06_L11:
       cmp       rcx,rdx
       jne       short M06_L12
       cmp       [rdx],dl
       jmp       near ptr M06_L00
M06_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC73B5878]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC73B5890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC73AD3E8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC73AD40C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC73AD404
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC73AD410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC72A5F08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC73AD3EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC73AD3F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC73AD3F4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC73AD3F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC73AD3FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC73AD400
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC73AD408
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC73B4888]
       int       3
M10_L03:
       call      qword ptr [7FFCC71DF990]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L07
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L07
       cmp       [r10+10],rcx
       je        short M11_L07
       cmp       [r10+18],rcx
       je        short M11_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L05
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L07
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L04
M11_L03:
       test      dword ptr [rax],500C0000
       je        short M11_L06
       jmp       qword ptr [7FFCC6D4EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L04:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L02
M11_L05:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L00
M11_L06:
       xor       edx,edx
M11_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L19
M12_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L21
       test      eax,eax
       jl        near ptr M12_L21
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L21
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L21
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L21
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L20
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L11
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L14
       mov       [r14+24],ecx
       jmp       near ptr M12_L17
M12_L05:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       mov       rcx,r14
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M12_L12
M12_L06:
       mov       dword ptr [rbp-3C],1
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jl        short M12_L09
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L13
       mov       rcx,rax
M12_L07:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L15
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L08:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
M12_L09:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       je        near ptr M12_L16
M12_L10:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       near ptr M12_L04
M12_L11:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L12:
       mov       rcx,r14
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M12_L06
M12_L13:
       mov       rdx,7FFCC73D0A08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L07
M12_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L15:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L08
M12_L16:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L10
M12_L17:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L18
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L22
M12_L18:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L19:
       mov       rcx,rdx
       mov       rdx,7FFCC737FF20
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D55A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L21:
       mov       rcx,rdi
       call      qword ptr [7FFCC71D54A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L22:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L18
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L23
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M12_L23:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M12_L24
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L24
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L24:
       nop
       add       rsp,28
       ret
; Total bytes of code 876
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,2FA75002010
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC724F1E8
       call      qword ptr [7FFCC71DD368]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC73D7A28
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC73D83C0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC73B2DA8
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC724F1E8
       xor       r8d,r8d
       call      qword ptr [7FFCC71DD368]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC73D83E0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC73B5470]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC73D8950
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC73D8C38
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC73D9158
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC73D8988
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC73D8B50
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC73FBDC0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC73FBDD8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC73D8B88
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC73D9428
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC724C5B8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6988]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC724C5B8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6988]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC73B52C0]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M15_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M15_L01
       test      rsi,rsi
       je        short M15_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M15_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M15_L00:
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
M15_L01:
       test      rsi,rsi
       je        short M15_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L03
M15_L02:
       mov       rax,33B09F70008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L03:
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
M15_L04:
       call      qword ptr [7FFCC72AD410]
       int       3
; Total bytes of code 244
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC737FF20
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC71D54A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC71D54D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC73D4658
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC73D0A08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC737FF20
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6988]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC71DF948]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6988]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M18_L07
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M18_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M18_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M18_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L09
       mov       [rcx+24],eax
       jmp       near ptr M18_L12
M18_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        short M18_L05
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M18_L08
M18_L03:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M18_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M18_L04:
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
M18_L05:
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
       je        near ptr M18_L11
M18_L06:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M18_L01
M18_L07:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC73D0A08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L03
M18_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L10:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M18_L04
M18_L11:
       lock inc  qword ptr [rsi]
       jmp       near ptr M18_L06
M18_L12:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M18_L14
M18_L13:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L14:
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M18_L13
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L15
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L15:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M18_L16
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 657
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L17
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L19
       test      eax,eax
       jl        near ptr M19_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L19
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L19
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L18
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       mov       byte ptr [rbp-40],0
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L10
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L12
       mov       [rdi+24],ecx
       jmp       near ptr M19_L15
M19_L05:
       xor       edx,edx
       mov       [rdi+2C],edx
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jl        short M19_L08
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L11
       mov       rcx,rax
M19_L06:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L07:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
M19_L08:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       je        near ptr M19_L14
M19_L09:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       near ptr M19_L04
M19_L10:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L11:
       mov       rdx,7FFCC73D0A08
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L06
M19_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L07
M19_L14:
       lock inc  qword ptr [rsi]
       jmp       near ptr M19_L09
M19_L15:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L16
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L20
M19_L16:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L17:
       mov       rcx,rdx
       mov       rdx,7FFCC737FF20
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L18:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71D55A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L19:
       mov       rcx,rsi
       call      qword ptr [7FFCC71D54A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L20:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L21
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M19_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L22
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L22
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC71DF960]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 844
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,211FA802878
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC71C7078]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67F14B8
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67F14B0
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A44FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC72A5968]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B279A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC73C7690]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F75D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71CF2D0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71CF2D0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC70DE250]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2528F822968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC71C6880]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71C7198]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC7277358
       call      qword ptr [7FFCC71CF060]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC72B5888
       cmp       [rcx],ecx
       call      qword ptr [7FFCC72A4918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F7E5C8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71C6010]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71C6028]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67F14E0
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F14E8
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F14F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F14F8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71C73C0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC71C74E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71C7510]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1500
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67F14C0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F14C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F14D0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D4FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F14D8
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC71C7198]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67F1500
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67F14D8
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC71C70C0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
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
       mov       rsi,7FFD25671390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCC730F940
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
       mov       rcx,7FFCC730F944
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC72AC5A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D459E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC72AC5B8]
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
       mov       rcx,7FFCC730F94C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCC730F950
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCC730F948
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
       mov       rcx,7FFCC730F954
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
       mov       rcx,7FFCC7345538
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC68A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC7345530
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC7345534
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       je        short M06_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L00
M06_L02:
       test      r8,r8
       je        short M06_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
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
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC73C7BA0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC73C7BB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC7467E90
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC7467EB4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC7467EAC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC7467EB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC70DE250]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F7E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC7467E94
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC7467E98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC7467E9C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC7467EA0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC7467EA4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC7467EA8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC7467EB0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC73C6130]
       int       3
M10_L03:
       call      qword ptr [7FFCC72A6AF0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L07
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L07
       cmp       [r10+10],rcx
       je        short M11_L07
       cmp       [r10+18],rcx
       je        short M11_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L05
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L07
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L04
M11_L03:
       test      dword ptr [rax],500C0000
       je        short M11_L06
       jmp       qword ptr [7FFCC6D4EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L04:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L02
M11_L05:
       cmp       [r10],rcx
       je        short M11_L07
       jmp       short M11_L00
M11_L06:
       xor       edx,edx
M11_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L17
M12_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L19
       test      eax,eax
       jl        near ptr M12_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L19
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L19
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L18
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       mov       byte ptr [rbp-40],0
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L10
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L12
       mov       [r14+24],ecx
       jmp       near ptr M12_L15
M12_L05:
       xor       edx,edx
       mov       [r14+2C],edx
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jl        short M12_L08
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L11
       mov       rcx,rax
M12_L06:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L13
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L07:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
M12_L08:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       je        near ptr M12_L14
M12_L09:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       near ptr M12_L04
M12_L10:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L11:
       mov       rdx,7FFCC747A120
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L06
M12_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L13:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L07
M12_L14:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L09
M12_L15:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L16
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L20
M12_L16:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L17:
       mov       rcx,rdx
       mov       rdx,7FFCC7479FA0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L18:
       mov       rcx,rsi
       call      qword ptr [7FFCC71C74E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L19:
       mov       rcx,rdi
       call      qword ptr [7FFCC71C73D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L20:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L21
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M12_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L22
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L22
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 851
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,211FA802AD0
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC7277F28
       call      qword ptr [7FFCC71CF2A0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC74957C0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC7496158
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC73C9D40
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC7277F28
       xor       r8d,r8d
       call      qword ptr [7FFCC71CF2A0]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC7496178
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC73C7798]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC74966E8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC74969D0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC7496EF0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC7496720
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC74968E8
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC7534D38
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC7534D50
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC7496920
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC74971C0
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC72752F8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6BB0]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC72752F8
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC72A6BB0]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC73C75D0]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1383
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
       je        near ptr M15_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M15_L01
       test      rsi,rsi
       je        short M15_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M15_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M15_L00:
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
M15_L01:
       test      rsi,rsi
       je        short M15_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L03
M15_L02:
       mov       rax,2528F810008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L03:
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
M15_L04:
       call      qword ptr [7FFCC72ADC38]
       int       3
; Total bytes of code 244
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC7479FA0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC71C73D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 131
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC71C7408]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC7490CC0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC747A120
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC7479FA0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6BB0]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC72A6A48]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC72A6BB0]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 574
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
       je        near ptr M18_L07
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       short M18_L02
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       short M18_L02
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       short M18_L02
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L10
       mov       [rcx+24],eax
       jmp       near ptr M18_L13
M18_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M18_L05
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M18_L09
       jmp       near ptr M18_L08
M18_L03:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       near ptr M18_L11
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M18_L04:
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
M18_L05:
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
       je        near ptr M18_L12
M18_L06:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M18_L01
M18_L07:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L08:
       jmp       near ptr M18_L03
M18_L09:
       mov       rcx,rdx
       mov       rdx,7FFCC747A120
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L03
M18_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L11:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M18_L04
M18_L12:
       lock inc  qword ptr [rsi]
       jmp       near ptr M18_L06
M18_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M18_L15
M18_L14:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L15:
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M18_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M18_L17
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M18_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 671
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L18
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L20
       test      eax,eax
       jl        near ptr M19_L20
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L20
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L20
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L20
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L19
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       mov       byte ptr [rbp-40],0
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L10
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L13
       mov       [rdi+24],ecx
       jmp       near ptr M19_L16
M19_L05:
       xor       edx,edx
       mov       [rdi+2C],edx
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jl        short M19_L08
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L12
       jmp       near ptr M19_L11
M19_L06:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L14
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L07:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
M19_L08:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       je        near ptr M19_L15
M19_L09:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       near ptr M19_L04
M19_L10:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC68A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L11:
       mov       rcx,rax
       jmp       near ptr M19_L06
M19_L12:
       mov       rdx,7FFCC747A120
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L06
M19_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L14:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EFCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L07
M19_L15:
       lock inc  qword ptr [rsi]
       jmp       near ptr M19_L09
M19_L16:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L17
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L21
M19_L17:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L18:
       mov       rcx,rdx
       mov       rdx,7FFCC7479FA0
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L19:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC71C74E0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L20:
       mov       rcx,rsi
       call      qword ptr [7FFCC71C73D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L21:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L17
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L22
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
M19_L22:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L23
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L23
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC72A6AC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 854
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-70],rax
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
       mov       rcx,2211CC008F0
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCC7334420]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0D8],r15
       mov       [rbp-74],ecx
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
       mov       [rbp-90],rax
       test      r13d,r13d
       jle       near ptr M00_L03
       mov       rcx,[r15+8]
       mov       rdx,rcx
       mov       [rbp-98],rdx
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
       mov       rax,[rbp-90]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6885A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0B8],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C0],rax
       mov       dword ptr [r15+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+30],rax
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       mov       r10,[r15+18]
       mov       [rbp-0A8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r13d
       mov       r11,7FFCC67D1850
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
       mov       [rbp-0B0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0A8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       mov       [rbp-84],edx
       cmp       edx,r11d
       jbe       near ptr M00_L12
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0A0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-3C]
       mov       r11,7FFCC67D1848
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0A0]
       mov       r8,[rbp-0A8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-84]
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-84],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L09
       jmp       short M00_L12
M00_L11:
       mov       rcx,[rbp-0A0]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M00_L13
       mov       [rbp-84],edx
M00_L12:
       cmp       dword ptr [r15+40],0
       jle       short M00_L15
       mov       r10d,[r15+3C]
       mov       r13d,r10d
       cmp       r10d,[rbp-84]
       jae       near ptr M00_L37
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[rcx+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+3C],edx
       dec       dword ptr [r15+40]
       jmp       near ptr M00_L17
M00_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L14
       mov       r8d,[rbp-3C]
       cmp       [rcx+r11+18],r8d
       je        near ptr M00_L22
M00_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L21
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M00_L13
       mov       [rbp-84],edx
       jmp       short M00_L12
M00_L15:
       mov       r13d,[r15+38]
       cmp       [rbp-84],r13d
       jne       short M00_L16
       mov       ecx,[r15+38]
       call      qword ptr [7FFCC6A24FA8]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCC733E220]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       [rbp-0B0],r8
       mov       eax,ecx
M00_L16:
       lea       ecx,[r13+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
M00_L17:
       cmp       r13d,[rcx+8]
       jae       near ptr M00_L37
       mov       edx,r13d
       shl       rdx,4
       lea       rcx,[rcx+rdx+10]
       mov       [rcx],eax
       mov       r9,[rbp-0B0]
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
       jg        short M00_L18
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
       jmp       short M00_L20
M00_L18:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       ecx,[r15+10]
       cmp       r9d,ecx
       jae       near ptr M00_L36
       dec       ecx
       mov       [r15+10],ecx
       cmp       r9d,ecx
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
M00_L20:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFCC6B079A8]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCC74474C8]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCC6F55D28]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-90]
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
       call      qword ptr [7FFCC6F5DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCC71C4480]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-90]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCC71C4480]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-98]
       mov       edx,[rbp-40]
       mov       r8,[rbp-90]
       call      qword ptr [7FFCC70B5E90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-90]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2619BB52500
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCC70B7180]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-3C],r8d
       sub       ecx,r9d
       mov       [rsp+20],ecx
       mov       r8,[r15+8]
       mov       rcx,[r15+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC7334540]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       [rbx],bl
       lea       rdi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       mov       rdx,[r14+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       r15d,[rax+8]
       cmp       r15d,64
       jl        near ptr M00_L44
M00_L40:
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r15+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r15
       mov       r8,rdi
       mov       rdx,7FFCC73D46D0
       call      qword ptr [7FFCC733C150]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
M00_L41:
       mov       [rbp-70],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFCC7402170
       cmp       [rcx],ecx
       call      qword ptr [7FFCC733D968]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       call      qword ptr [7FFCC6F5E5C8]
       mov       ecx,0AB
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C85D90
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC70B65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC70B65C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,rax
       mov       r11,7FFCC67D1878
       call      qword ptr [r11]
       mov       r15d,eax
       cmp       r15d,64
       jge       near ptr M00_L40
M00_L44:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D1880
       call      qword ptr [r11]
       mov       [rbp-0D0],rax
M00_L45:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1888
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1890
       call      qword ptr [r11]
       mov       rdi,rax
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7334558]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L46
       mov       rcx,r15
       call      qword ptr [7FFCC7334678]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L46:
       lea       r8,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC73346A8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L45
M00_L47:
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1898
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L48:
       mov       rcx,[rdi]
       mov       r11,7FFCC67D1858
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L49:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1860
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L50
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1868
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6D2FB40]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L49
M00_L50:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1870
       call      qword ptr [r11]
       jmp       near ptr M00_L41
       sub       rsp,38
       cmp       qword ptr [rbp-0D8],0
       je        short M00_L51
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-74]
       call      qword ptr [7FFCC7334540]; System.Threading.Lock.Exit(ThreadId)
M00_L51:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0D0],0
       je        short M00_L52
       mov       rcx,[rbp-0D0]
       mov       r11,7FFCC67D1898
       call      qword ptr [r11]
M00_L52:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L53
       mov       rcx,[rbp-0C8]
       mov       r11,7FFCC67D1870
       call      qword ptr [r11]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 2488
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       add       rax,280
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M01_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M01_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M01_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCC7334468]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M02_L02
       mov       rcx,7FFD25671390
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
       call      qword ptr [7FFCC71C4888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D259E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCC71C48A0]
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
       mov       rcx,7FFCC726E000
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCC6885A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCC726DFF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCC726DFFC
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
       call      qword ptr [7FFD262E5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD262E9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD262E5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M04_L02
       cmp       [rdi+8],ebp
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
       call      qword ptr [7FFD262D7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L03:
       cmp       ecx,[rdi+8]
       jae       short M04_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M04_L04
       mov       eax,[rdi+rax+10]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+30]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       short M04_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M04_L03
       jmp       short M04_L02
M04_L05:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262E96A0]
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
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFCC68866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC744C5E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC744C600]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 96
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
       jne       near ptr M08_L08
M08_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M08_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M08_L03
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
       jne       short M08_L04
       cmp       r8,14
       jne       near ptr M08_L15
       jmp       near ptr M08_L14
M08_L04:
       cmp       r8,4000
       ja        near ptr M08_L13
       jmp       near ptr M08_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M08_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M08_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M08_L05
M08_L13:
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
M08_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M08_L05
M08_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       je        near ptr M09_L04
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L12
       test      r14d,r14d
       jl        near ptr M09_L11
       test      edi,edi
       jl        near ptr M09_L10
       test      ebp,ebp
       jl        near ptr M09_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M09_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L07
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
       je        short M09_L01
       mov       rcx,7FFCC7481F20
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M09_L05
M09_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       mov       rcx,7FFCC7481F44
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCC7481F3C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCC7481F48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCC70B5E90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L00
M09_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFCC6F5DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCC7481F24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCC7481F28
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCC7481F2C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCC7481F30
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCC7481F34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCC7481F38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCC7481F40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
; Total bytes of code 490
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M10_L02
       cmp       dword ptr [rcx+18],0
       jne       short M10_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M10_L03
M10_L00:
       add       rsp,28
       ret
M10_L01:
       dec       dword ptr [rcx+18]
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFCC7446BC8]
       int       3
M10_L03:
       call      qword ptr [7FFCC733EFD0]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L01
       cmp       [r10],rcx
       je        short M11_L04
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L04
       cmp       [r10+10],rcx
       je        short M11_L04
       cmp       [r10+18],rcx
       je        short M11_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L07
       test      r8,r8
       je        short M11_L03
M11_L01:
       cmp       [r10],rcx
       je        short M11_L04
M11_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L05
M11_L03:
       test      dword ptr [rax],500C0000
       jne       short M11_L06
       xor       edx,edx
M11_L04:
       mov       rax,rdx
       ret
M11_L05:
       cmp       [r10],rcx
       je        short M11_L04
       jmp       short M11_L02
M11_L06:
       jmp       qword ptr [7FFCC6D2EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M11_L07:
       cmp       [r10],rcx
       je        short M11_L04
       jmp       short M11_L00
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass1_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
; 					_ = Parallel.ForEach(items, item => bag.Add(item));
; 					                                    ^^^^^^^^^^^^^
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
       mov       rsi,[rcx+8]
       mov       rdi,[rsi+8]
       mov       rdx,[rdi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L17
M12_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rdi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M12_L19
       test      eax,eax
       jl        near ptr M12_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M12_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M12_L19
       cmp       byte ptr [rdi+1C],0
       je        near ptr M12_L19
       mov       r14,[rcx+20]
M12_L01:
       test      r14,r14
       je        near ptr M12_L18
M12_L02:
       mov       [rbp-50],r14
       add       rsi,18
       cmp       [r14],r14b
       mov       byte ptr [rbp-40],0
       lea       rdx,[r14+2C]
       mov       ecx,1
       xchg      ecx,[rdx]
       mov       edi,[r14+1C]
       cmp       edi,7FFFFFFF
       je        near ptr M12_L10
M12_L03:
       mov       r15d,[r14+18]
       cmp       byte ptr [r14+34],0
       jne       short M12_L05
       lea       edx,[rdi-1]
       mov       ecx,r15d
       sub       ecx,edx
       jns       short M12_L05
       add       r15d,[r14+20]
       mov       edx,edi
       sub       edx,r15d
       jns       short M12_L05
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [r14+1C],edi
M12_L04:
       mov       ecx,[r14+24]
       add       ecx,1
       jo        near ptr M12_L12
       mov       [r14+24],ecx
       jmp       near ptr M12_L15
M12_L05:
       xor       edx,edx
       mov       [r14+2C],edx
       lea       rdx,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       r15d,[r14+18]
       mov       r13d,edi
       sub       r13d,r15d
       cmp       r13d,[r14+20]
       jl        short M12_L08
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M12_L11
       mov       rcx,rax
M12_L06:
       mov       rdx,[r14+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r15d,[r14+20]
       jne       near ptr M12_L13
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M12_L07:
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+18],edx
       mov       edi,r13d
       mov       [r14+1C],edi
       mov       edx,[r14+20]
       add       edx,edx
       or        edx,1
       mov       [r14+20],edx
M12_L08:
       mov       edx,edi
       and       edx,[r14+20]
       movsxd    rdx,edx
       mov       rcx,[r14+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [r14+1C],ecx
       test      r13d,r13d
       je        near ptr M12_L14
M12_L09:
       mov       ecx,[r14+28]
       sub       [r14+24],ecx
       xor       ecx,ecx
       mov       [r14+28],ecx
       jmp       near ptr M12_L04
M12_L10:
       xor       edx,edx
       mov       [r14+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[r14+20]
       and       [r14+18],ecx
       mov       edi,[r14+20]
       and       edi,7FFFFFFF
       mov       [r14+1C],edi
       lea       rcx,[r14+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M12_L03
       mov       rcx,r14
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L03
M12_L11:
       mov       rdx,7FFCC74A5518
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L06
M12_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L13:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[r14+8]
       mov       edx,r15d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[r14+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[r14+8]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M12_L07
M12_L14:
       lock inc  qword ptr [rsi]
       jmp       near ptr M12_L09
M12_L15:
       xor       ecx,ecx
       mov       [r14+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L16
       mov       rcx,r14
       call      00007FFD26476030
       test      eax,eax
       jne       short M12_L20
M12_L16:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L17:
       mov       rcx,rdx
       mov       rdx,7FFCC74A5398
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L00
M12_L18:
       mov       rcx,rsi
       call      qword ptr [7FFCC7334678]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r14,rax
       jmp       near ptr M12_L02
M12_L19:
       mov       rcx,rdi
       call      qword ptr [7FFCC7334570]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       r14,rax
       jmp       near ptr M12_L01
M12_L20:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M12_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L21
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M12_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M12_L22
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M12_L22
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 849
```
```assembly
; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rdx
       mov       rdi,rcx
       mov       rbx,r8
       mov       rsi,r9
       test      rbx,rbx
       je        near ptr M13_L32
       test      rsi,rsi
       je        near ptr M13_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M13_L08
M13_L00:
       mov       rcx,2211CC00BB0
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M13_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M13_L34
M13_L01:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M13_L09
M13_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M13_L28
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M13_L28
M13_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M13_L29
M13_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+28],rcx
       mov       [rbx+30],rcx
       mov       rcx,[rbx+10]
       mov       rax,rcx
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,edx
       test      r8d,r8d
       jne       near ptr M13_L30
       xor       esi,esi
M13_L05:
       test      edx,edx
       jne       near ptr M13_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M13_L35
       mov       r14d,ecx
       dec       r14d
M13_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Parallel+<>c__DisplayClass31_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ForEachWorker>b__0(Int32)
       mov       [r13+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r13
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-70]
       mov       r8d,esi
       mov       r9d,r14d
       mov       rdx,7FFCC73D52A0
       call      qword ptr [7FFCC733C390]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M13_L07:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rdi],xmm0
       mov       rax,[rbp-40]
       mov       [rdi+10],rax
       mov       rax,rdi
       add       rsp,0B0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFCC74C07C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,r14
       mov       rdx,7FFCC74C1160
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L02
M13_L10:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M13_L15
M13_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M13_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M13_L25
       mov       rbx,[rcx+48]
       test      rbx,rbx
       je        near ptr M13_L25
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M13_L26
M13_L13:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        near ptr M13_L27
M13_L14:
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[r14+10]
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       esi,eax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC744A730
       mov       [rbx+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],rbx
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-88]
       mov       r9d,esi
       mov       rdx,7FFCC73D52A0
       xor       r8d,r8d
       call      qword ptr [7FFCC733C390]; System.Threading.Tasks.Parallel.ForWorker[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32, System.Threading.Tasks.ParallelOptions, System.Action`1<Int32>, System.Action`2<Int32,System.Threading.Tasks.ParallelLoopState>, System.Func`4<Int32,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M13_L07
M13_L15:
       mov       rcx,r14
       mov       rdx,7FFCC74C1180
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L11
M13_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M13_L21
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M13_L21
M13_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M13_L22
M13_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M13_L23
M13_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M13_L24
       mov       rdx,[rcx+40]
       test      rdx,rdx
       je        near ptr M13_L24
M13_L20:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-50]
       mov       r8,r13
       mov       r9,r15
       call      qword ptr [7FFCC744C0A8]
       jmp       near ptr M13_L07
M13_L21:
       mov       rcx,r14
       mov       rdx,7FFCC74C16F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L17
M13_L22:
       mov       rdx,7FFCC74C19D8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L18
M13_L23:
       mov       rcx,rdx
       mov       rdx,7FFCC74C1F00
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L19
M13_L24:
       mov       rcx,r14
       mov       rdx,7FFCC74C1728
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L20
M13_L25:
       mov       rcx,r14
       mov       rdx,7FFCC74C18F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M13_L12
M13_L26:
       mov       rcx,rbx
       mov       rdx,7FFCC75E0698
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L13
M13_L27:
       mov       rcx,rbx
       mov       rdx,7FFCC75E06B0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L14
M13_L28:
       mov       rcx,r14
       mov       rdx,7FFCC74C1928
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L29:
       mov       rdx,7FFCC74C21D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M13_L04
M13_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M13_L05
M13_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M13_L06
M13_L32:
       mov       ecx,3C3
       mov       rdx,7FFCC73D2670
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC70B6B20]
       int       3
M13_L33:
       mov       ecx,38B
       mov       rdx,7FFCC73D2670
       call      qword ptr [7FFCC6B07738]
       mov       rcx,rax
       call      qword ptr [7FFCC70B6B20]
       int       3
M13_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFCC7447420]
       int       3
M13_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1371
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
       je        near ptr M15_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M15_L00
       test      rbx,rbx
       je        near ptr M15_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M15_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M15_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M15_L00:
       test      rbx,rbx
       je        short M15_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M15_L02
M15_L01:
       mov       rax,2619BB40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M15_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M15_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M15_L04:
       call      qword ptr [7FFCC71CF348]
       int       3
; Total bytes of code 235
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
       je        short M16_L01
M16_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      rax,rax
       je        short M16_L02
       test      ecx,ecx
       jl        short M16_L02
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M16_L02
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M16_L02
       cmp       byte ptr [rbx+1C],0
       je        short M16_L02
       mov       rax,[rax+20]
       add       rsp,30
       pop       rbx
       ret
M16_L01:
       mov       rdx,7FFCC74A5398
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M16_L00
M16_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCC7334570]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
; Total bytes of code 128
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
       je        near ptr M17_L14
       mov       rcx,rdx
       call      00007FFD263B9E20
       test      eax,eax
       je        near ptr M17_L15
M17_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        near ptr M17_L09
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        short M17_L02
M17_L01:
       cmp       [rsi+30],eax
       je        near ptr M17_L16
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M17_L01
M17_L02:
       xor       esi,esi
M17_L03:
       test      rsi,rsi
       jne       near ptr M17_L06
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M17_L10
M17_L04:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M17_L11
       mov       rcx,rax
M17_L05:
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
M17_L06:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M17_L12
M17_L07:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M17_L08
       test      ecx,ecx
       jl        short M17_L08
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       short M17_L08
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M17_L13
M17_L08:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCC73345A0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M17_L17
M17_L09:
       xor       esi,esi
       mov       rcx,[rbp+10]
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,rdx
       mov       rdx,7FFCC74A7478
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L04
M17_L11:
       mov       rdx,7FFCC74A5518
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L12:
       mov       rcx,rdx
       mov       rdx,7FFCC74A5398
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M17_L07
M17_L13:
       cmp       byte ptr [rbx+1C],0
       je        short M17_L08
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       xor       ecx,ecx
       call      qword ptr [7FFCC70B6B20]
       int       3
M17_L15:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCC70BC330]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M17_L00
M17_L16:
       jmp       near ptr M17_L03
M17_L17:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       jne       short M17_L19
M17_L18:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L19:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M17_L18
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M17_L21
       cmp       qword ptr [rbp-28],0
       jne       short M17_L20
       xor       ecx,ecx
       call      qword ptr [7FFCC70B6B20]
       int       3
M17_L20:
       mov       rcx,[rbp-28]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L21
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 571
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
       je        short M18_L02
M18_L00:
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       cmp       byte ptr [rcx+34],0
       jne       near ptr M18_L03
       lea       edx,[rdi-1]
       mov       r8d,r14d
       sub       r8d,edx
       jns       near ptr M18_L03
       add       r14d,[rcx+20]
       mov       edx,edi
       sub       edx,r14d
       jns       near ptr M18_L03
       mov       edx,edi
       and       edx,[rcx+20]
       movsxd    rdx,edx
       mov       rcx,[rcx+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       rcx,[rbp+10]
       mov       [rcx+1C],edi
M18_L01:
       mov       eax,[rcx+24]
       add       eax,1
       jo        near ptr M18_L06
       mov       [rcx+24],eax
       jmp       near ptr M18_L11
M18_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       je        near ptr M18_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M18_L00
M18_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jl        near ptr M18_L09
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M18_L04
       jmp       short M18_L05
M18_L04:
       mov       rcx,rdx
       mov       rdx,7FFCC74A5518
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M18_L05:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M18_L07
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M18_L08
M18_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L07:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M18_L08:
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
M18_L09:
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
       jne       short M18_L10
       lock inc  qword ptr [rsi]
M18_L10:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M18_L01
M18_L11:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M18_L13
M18_L12:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L13:
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M18_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M18_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M18_L14:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M18_L15
       mov       rcx,rdi
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M18_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 645
```
```assembly
; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rsi,[rcx+8]
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M19_L17
M19_L00:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax+10]
       mov       eax,[rsi+18]
       not       eax
       test      rcx,rcx
       je        near ptr M19_L19
       test      eax,eax
       jl        near ptr M19_L19
       mov       edx,[rcx+8]
       cmp       edx,eax
       jle       near ptr M19_L19
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M19_L19
       cmp       byte ptr [rsi+1C],0
       je        near ptr M19_L19
       mov       rdi,[rcx+20]
M19_L01:
       test      rdi,rdi
       je        near ptr M19_L18
M19_L02:
       mov       [rbp-50],rdi
       mov       rcx,[rbp+10]
       lea       rsi,[rcx+18]
       cmp       [rdi],dil
       mov       byte ptr [rbp-40],0
       lea       rdx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rdx]
       mov       r14d,[rdi+1C]
       cmp       r14d,7FFFFFFF
       je        near ptr M19_L10
M19_L03:
       mov       r15d,[rdi+18]
       cmp       byte ptr [rdi+34],0
       jne       short M19_L05
       lea       edx,[r14-1]
       mov       r8d,r15d
       sub       r8d,edx
       jns       short M19_L05
       add       r15d,[rdi+20]
       mov       edx,r14d
       sub       edx,r15d
       jns       short M19_L05
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       mov       [rdi+1C],r14d
M19_L04:
       mov       ecx,[rdi+24]
       add       ecx,1
       jo        near ptr M19_L13
       mov       [rdi+24],ecx
       jmp       near ptr M19_L15
M19_L05:
       xor       edx,edx
       mov       [rdi+2C],edx
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       r15d,[rdi+18]
       mov       r13d,r14d
       sub       r13d,r15d
       cmp       r13d,[rdi+20]
       jl        short M19_L08
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M19_L12
       jmp       near ptr M19_L11
M19_L06:
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       and       r15d,[rdi+20]
       jne       near ptr M19_L14
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r14
       call      qword ptr [7FFCC6A24FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M19_L07:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rdi+18],edx
       mov       r14d,r13d
       mov       [rdi+1C],r14d
       mov       edx,[rdi+20]
       add       edx,edx
       or        edx,1
       mov       [rdi+20],edx
M19_L08:
       mov       edx,r14d
       and       edx,[rdi+20]
       movsxd    rdx,edx
       mov       rcx,[rdi+8]
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[r14+1]
       mov       [rdi+1C],ecx
       test      r13d,r13d
       jne       short M19_L09
       lock inc  qword ptr [rsi]
M19_L09:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       jmp       near ptr M19_L04
M19_L10:
       xor       edx,edx
       mov       [rdi+2C],edx
       mov       byte ptr [rbp-48],0
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       call      qword ptr [7FFCC6885998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       ecx,[rdi+20]
       and       [rdi+18],ecx
       mov       r14d,[rdi+20]
       and       r14d,7FFFFFFF
       mov       [rdi+1C],r14d
       lea       rcx,[rdi+2C]
       mov       eax,1
       xchg      eax,[rcx]
       cmp       byte ptr [rbp-48],0
       je        near ptr M19_L03
       mov       rcx,rdi
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M19_L03
M19_L11:
       mov       rcx,rax
       jmp       near ptr M19_L06
M19_L12:
       mov       rdx,7FFCC74A5518
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L06
M19_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M19_L14:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r15d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r15d
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r15d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r15d
       mov       rcx,[rdi+8]
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFCC6EDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M19_L07
M19_L15:
       xor       ecx,ecx
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L16
       mov       rcx,rdi
       call      00007FFD26476030
       test      eax,eax
       jne       short M19_L20
M19_L16:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L17:
       mov       rcx,rdx
       mov       rdx,7FFCC74A5398
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M19_L00
M19_L18:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCC7334678]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rdi,rax
       jmp       near ptr M19_L02
M19_L19:
       mov       rcx,rsi
       call      qword ptr [7FFCC7334570]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
       mov       rdi,rax
       jmp       near ptr M19_L01
M19_L20:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M19_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M19_L21
       mov       rcx,[rbp-50]
       call      qword ptr [7FFCC6886820]; System.Threading.Monitor.Exit(System.Object)
M19_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M19_L22
       mov       rcx,rax
       call      00007FFD26476030
       test      eax,eax
       je        short M19_L22
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FFCC70B7660]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 843
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L41
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L40
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC71F5F38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC71F5F38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC71FEDF0]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC71FED78]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC71FEE38]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L48
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L43
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbx+8]
       mov       ecx,[rsi+8]
       mov       r15,[rsi]
       mov       r13,[r14]
       cmp       r15,r13
       jne       short M00_L23
       cmp       dword ptr [r15+4],18
       jne       short M00_L23
       cmp       edi,[rsi+8]
       ja        short M00_L23
       cmp       edi,[r14+8]
       jbe       near ptr M00_L37
M00_L23:
       cmp       [rsi],r13
       je        short M00_L24
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,r13
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M00_L44
M00_L24:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L26
       xor       r15d,r15d
M00_L25:
       test      r15d,r15d
       jle       short M00_L27
       mov       ecx,167
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       r8,rax
       mov       edx,r15d
       xor       ecx,ecx
       call      qword ptr [7FFCC71FFA20]
       int       3
M00_L26:
       movsxd    rcx,ecx
       mov       r15d,[rsi+rcx*4+10]
       jmp       short M00_L25
M00_L27:
       neg       r15d
       js        near ptr M00_L45
       lea       ecx,[r15+rdi]
       cmp       ecx,[rsi+8]
       ja        near ptr M00_L45
       mov       rcx,r13
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L29
       xor       r12d,r12d
M00_L28:
       test      r12d,r12d
       jle       short M00_L30
       mov       ecx,17F
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       r8,rax
       mov       edx,r12d
       xor       ecx,ecx
       call      qword ptr [7FFCC71FFA20]
       int       3
M00_L29:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       short M00_L28
M00_L30:
       neg       r12d
       js        near ptr M00_L46
       lea       ecx,[r12+rdi]
       cmp       ecx,[r14+8]
       ja        near ptr M00_L46
       cmp       [rsi],r13
       je        short M00_L33
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFCC71FFAF8]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M00_L33
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8,r14
       mov       r9d,r12d
       call      qword ptr [7FFCC71FFB10]
M00_L31:
       mov       [rbx+10],edi
M00_L32:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFCC7203E30
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71F5608]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L33:
       mov       rcx,[rsi]
       movzx     edx,word ptr [rcx]
       mov       r8d,edi
       imul      r8,rdx
       mov       eax,r15d
       imul      rax,rdx
       lea       rax,[rsi+rax+10]
       mov       r10d,r12d
       imul      rdx,r10
       lea       r10,[r14+rdx+10]
       test      dword ptr [rcx],1000000
       jne       short M00_L35
       cmp       r8,14
       je        short M00_L34
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L31
M00_L34:
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmm1,xmmword ptr [rax+4]
       vmovdqu   xmmword ptr [r10],xmm0
       vmovdqu   xmmword ptr [r10+4],xmm1
       jmp       near ptr M00_L31
M00_L35:
       cmp       r8,4000
       jbe       short M00_L36
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFCC71FF630]
       jmp       near ptr M00_L31
M00_L36:
       mov       rcx,r10
       mov       rdx,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       je        near ptr M00_L31
       jmp       near ptr M00_L47
M00_L37:
       mov       r8d,edi
       movzx     ecx,word ptr [r15]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[r14+10]
       test      dword ptr [r15],1000000
       jne       short M00_L38
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L31
M00_L38:
       call      qword ptr [7FFCC68A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L31
M00_L39:
       call      qword ptr [7FFCC6F769E8]
       mov       ecx,0C5
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC70AC720]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC70AC738]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       call      M00_L48
       nop
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC68A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20931801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFCC6B27DF8]
       int       3
M00_L43:
       mov       rcx,20931801EF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L32
M00_L44:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC71FFA98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC71FFAB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFCC71FFAC8]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFCC6D478D0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCC71FFAE0]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCC6D478D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L31
M00_L48:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L53
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L51
M00_L49:
       cmp       byte ptr [rsi+34],0
       je        short M00_L50
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC71FECE8]
M00_L50:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L49
M00_L51:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L52
       xor       ecx,ecx
       call      qword ptr [7FFCC71FED78]
       int       3
M00_L52:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC71FECE8]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 1655
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71FED60]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC68AD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD262D8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD262D8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.CanAssignArrayType(System.Array, System.Array)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rax,[rcx]
       mov       rcx,[rax+30]
       mov       rbx,rcx
       mov       rax,[rdx]
       mov       rsi,[rax+30]
       mov       rdi,rsi
       cmp       rbx,rdi
       je        near ptr M03_L32
       mov       eax,ecx
       and       eax,2
       mov       edx,esi
       and       edx,2
       or        eax,edx
       jne       near ptr M03_L28
       mov       rbp,rbx
       mov       r14,rdi
       mov       eax,[rcx]
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M03_L04
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M03_L05
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rbx
       mov       rax,rdi
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L00:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       near ptr M03_L15
       mov       r9,rdi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L15
       cmp       r10d,[rax]
       jne       near ptr M03_L39
M03_L01:
       test      r9d,r9d
       je        near ptr M03_L16
       cmp       r9d,1
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L16
M03_L02:
       mov       eax,4
       jmp       near ptr M03_L14
M03_L03:
       test      r10d,r10d
       je        near ptr M03_L40
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L17
       jmp       near ptr M03_L40
M03_L04:
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M03_L23
M03_L05:
       mov       eax,[rcx]
       and       eax,0E0000
       cmp       eax,60000
       jne       short M03_L06
       mov       eax,[rsi]
       and       eax,0E0000
       cmp       eax,60000
       je        near ptr M03_L20
M03_L06:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbp
       rol       r8,20
       xor       r8,r14
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L07:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbp
       jne       near ptr M03_L34
       mov       r9,r14
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L34
       cmp       r10d,[rax]
       jne       near ptr M03_L41
M03_L08:
       test      r9d,r9d
       je        short M03_L09
       cmp       r9d,1
       je        near ptr M03_L32
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M03_L32
M03_L09:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,r14
       mov       rax,rbp
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L10:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,r14
       jne       near ptr M03_L35
       mov       r9,rbp
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L35
       cmp       r10d,[rax]
       jne       near ptr M03_L42
M03_L11:
       test      r9d,r9d
       je        short M03_L12
       cmp       r9d,1
       je        short M03_L13
       mov       rcx,r14
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       short M03_L13
M03_L12:
       mov       ecx,[r14]
       and       ecx,0F0000
       cmp       ecx,0C0000
       je        short M03_L13
       mov       ecx,[rbp]
       and       ecx,0F0000
       cmp       ecx,0C0000
       jne       near ptr M03_L19
M03_L13:
       mov       eax,2
M03_L14:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L15:
       test      r10d,r10d
       je        near ptr M03_L39
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L00
       jmp       near ptr M03_L39
M03_L16:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rdi
       mov       rax,rbx
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L17:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rdi
       jne       near ptr M03_L03
       mov       r9,rbx
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L03
       cmp       r10d,[rax]
       jne       near ptr M03_L40
M03_L18:
       test      r9d,r9d
       je        short M03_L19
       cmp       r9d,1
       je        near ptr M03_L02
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M03_L02
M03_L19:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L20:
       call      qword ptr [7FFD262F3EF0]
       mov       ebx,eax
       mov       rcx,rsi
       call      qword ptr [7FFD262F3EF0]
       mov       esi,eax
       mov       ecx,ebx
       call      qword ptr [7FFD262E9318]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       mov       edi,eax
       mov       ecx,esi
       call      qword ptr [7FFD262E9318]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       cmp       edi,eax
       je        near ptr M03_L32
       cmp       ebx,0E
       jge       short M03_L21
       cmp       ebx,0E
       jae       near ptr M03_L43
       mov       eax,ebx
       lea       rcx,[7FFD25668350]
       movsx     rax,word ptr [rcx+rax*2]
       bt        eax,esi
       jae       short M03_L19
       jmp       short M03_L22
M03_L21:
       cmp       ebx,esi
       jne       short M03_L19
M03_L22:
       mov       eax,5
       jmp       near ptr M03_L14
M03_L23:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rsi
       add       rdx,10
       mov       rax,rbx
       rol       rax,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L24:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M03_L27
       mov       r9,rsi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        short M03_L27
       cmp       r10d,[rax]
       jne       near ptr M03_L38
M03_L25:
       test      r9d,r9d
       je        near ptr M03_L19
       cmp       r9d,1
       je        short M03_L26
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L19
M03_L26:
       mov       eax,3
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L27:
       test      r10d,r10d
       je        near ptr M03_L38
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L24
       jmp       near ptr M03_L38
M03_L28:
       mov       rdi,rsi
       test      cl,2
       jne       short M03_L29
       test      sil,2
       jne       near ptr M03_L36
M03_L29:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbx
       rol       r8,20
       xor       r8,rdi
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L30:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M03_L33
       mov       rsi,rdi
       xor       rsi,[rax+10]
       cmp       rsi,1
       ja        short M03_L33
       cmp       r10d,[rax]
       jne       near ptr M03_L37
M03_L31:
       test      esi,esi
       je        near ptr M03_L19
       cmp       esi,1
       je        short M03_L32
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L19
M03_L32:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L33:
       test      r10d,r10d
       je        short M03_L37
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M03_L30
       jmp       short M03_L37
M03_L34:
       test      r10d,r10d
       je        short M03_L41
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L07
       jmp       short M03_L41
M03_L35:
       test      r10d,r10d
       je        short M03_L42
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L10
       jmp       short M03_L42
M03_L36:
       xor       esi,esi
       jmp       short M03_L31
M03_L37:
       mov       esi,2
       jmp       near ptr M03_L31
M03_L38:
       mov       r9d,2
       jmp       near ptr M03_L25
M03_L39:
       mov       r9d,2
       jmp       near ptr M03_L01
M03_L40:
       mov       r9d,2
       jmp       near ptr M03_L18
M03_L41:
       mov       r9d,2
       jmp       near ptr M03_L08
M03_L42:
       mov       r9d,2
       jmp       near ptr M03_L11
M03_L43:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 1451
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
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        short M05_L09
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       vzeroupper
       ret
M05_L06:
       cmp       r8,800
       ja        near ptr M05_L12
       cmp       r8,100
       jae       short M05_L10
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L04
M05_L10:
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
M05_L11:
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M06_L02
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M06_L01
M06_L00:
       add       rsp,28
       ret
M06_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M06_L00
M06_L02:
       add       rsp,28
       jmp       qword ptr [7FFCC71FF630]
; Total bytes of code 49
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,249C67A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FFCC71FFD50]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FFCC68A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L41
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L40
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC71DECB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC71DECB8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC71DEE80]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC71DEC70]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC71DEEE0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L48
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L43
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbx+8]
       mov       ecx,[rsi+8]
       mov       r15,[rsi]
       mov       r13,[r14]
       cmp       r15,r13
       jne       short M00_L23
       cmp       dword ptr [r15+4],18
       jne       short M00_L23
       cmp       edi,[rsi+8]
       ja        short M00_L23
       cmp       edi,[r14+8]
       jbe       near ptr M00_L37
M00_L23:
       cmp       [rsi],r13
       je        short M00_L24
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,r13
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M00_L44
M00_L24:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L26
       xor       r15d,r15d
M00_L25:
       test      r15d,r15d
       jle       short M00_L27
       mov       ecx,167
       mov       rdx,7FFCC67C4000
       call      qword ptr [7FFCC6B07738]
       mov       r8,rax
       mov       edx,r15d
       xor       ecx,ecx
       call      qword ptr [7FFCC71DFA98]
       int       3
M00_L26:
       movsxd    rcx,ecx
       mov       r15d,[rsi+rcx*4+10]
       jmp       short M00_L25
M00_L27:
       neg       r15d
       js        near ptr M00_L45
       lea       ecx,[r15+rdi]
       cmp       ecx,[rsi+8]
       ja        near ptr M00_L45
       mov       rcx,r13
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M00_L29
       xor       r12d,r12d
M00_L28:
       test      r12d,r12d
       jle       short M00_L30
       mov       ecx,17F
       mov       rdx,7FFCC67C4000
       call      qword ptr [7FFCC6B07738]
       mov       r8,rax
       mov       edx,r12d
       xor       ecx,ecx
       call      qword ptr [7FFCC71DFA98]
       int       3
M00_L29:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       short M00_L28
M00_L30:
       neg       r12d
       js        near ptr M00_L46
       lea       ecx,[r12+rdi]
       cmp       ecx,[r14+8]
       ja        near ptr M00_L46
       cmp       [rsi],r13
       je        short M00_L33
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFCC71DFB70]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M00_L33
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8,r14
       mov       r9d,r12d
       call      qword ptr [7FFCC71DFB88]
M00_L31:
       mov       [rbx+10],edi
M00_L32:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFCC71E3E40
       cmp       [rcx],ecx
       call      qword ptr [7FFCC71D5608]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L33:
       mov       rcx,[rsi]
       movzx     edx,word ptr [rcx]
       mov       r8d,edi
       imul      r8,rdx
       mov       eax,r15d
       imul      rax,rdx
       lea       rax,[rsi+rax+10]
       mov       r10d,r12d
       imul      rdx,r10
       lea       r10,[r14+rdx+10]
       test      dword ptr [rcx],1000000
       jne       short M00_L35
       cmp       r8,14
       je        short M00_L34
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L31
M00_L34:
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmm1,xmmword ptr [rax+4]
       vmovdqu   xmmword ptr [r10],xmm0
       vmovdqu   xmmword ptr [r10+4],xmm1
       jmp       near ptr M00_L31
M00_L35:
       cmp       r8,4000
       jbe       short M00_L36
       mov       rcx,r10
       mov       rdx,rax
       call      qword ptr [7FFCC71DF6C0]
       jmp       near ptr M00_L31
M00_L36:
       mov       rcx,r10
       mov       rdx,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       je        near ptr M00_L31
       jmp       near ptr M00_L47
M00_L37:
       mov       r8d,edi
       movzx     ecx,word ptr [r15]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[r14+10]
       test      dword ptr [r15],1000000
       jne       short M00_L38
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L31
M00_L38:
       call      qword ptr [7FFCC68857A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L31
M00_L39:
       call      qword ptr [7FFCC6F569E8]
       mov       ecx,0C5
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C85D90
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC708C738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC708C750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       call      M00_L48
       nop
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC6885728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A595801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFCC6B07DF8]
       int       3
M00_L43:
       mov       rcx,1A595801EF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L32
M00_L44:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC71DFB10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC71DFB28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFCC71DFB40]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FFCC67C4000
       call      qword ptr [7FFCC6B07738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFCC6D278D0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCC71DFB58]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFCC67C4000
       call      qword ptr [7FFCC6B07738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCC6D278D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L31
M00_L48:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L53
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L51
M00_L49:
       cmp       byte ptr [rsi+34],0
       je        short M00_L50
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC71DEC88]
M00_L50:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L49
M00_L51:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L52
       xor       ecx,ecx
       call      qword ptr [7FFCC71DEC70]
       int       3
M00_L52:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC71DEC88]
M00_L53:
       nop
       add       rsp,38
       ret
; Total bytes of code 1655
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71DED48]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC688D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD262D8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD262D8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.CanAssignArrayType(System.Array, System.Array)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rax,[rcx]
       mov       rcx,[rax+30]
       mov       rbx,rcx
       mov       rax,[rdx]
       mov       rsi,[rax+30]
       mov       rdi,rsi
       cmp       rbx,rdi
       je        near ptr M03_L32
       mov       eax,ecx
       and       eax,2
       mov       edx,esi
       and       edx,2
       or        eax,edx
       jne       near ptr M03_L28
       mov       rbp,rbx
       mov       r14,rdi
       mov       eax,[rcx]
       and       eax,0C0000
       cmp       eax,40000
       je        near ptr M03_L04
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M03_L05
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rbx
       mov       rax,rdi
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L00:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       near ptr M03_L15
       mov       r9,rdi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L15
       cmp       r10d,[rax]
       jne       near ptr M03_L39
M03_L01:
       test      r9d,r9d
       je        near ptr M03_L16
       cmp       r9d,1
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L16
M03_L02:
       mov       eax,4
       jmp       near ptr M03_L14
M03_L03:
       test      r10d,r10d
       je        near ptr M03_L40
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L17
       jmp       near ptr M03_L40
M03_L04:
       mov       eax,[rsi]
       and       eax,0C0000
       cmp       eax,40000
       jne       near ptr M03_L23
M03_L05:
       mov       eax,[rcx]
       and       eax,0E0000
       cmp       eax,60000
       jne       short M03_L06
       mov       eax,[rsi]
       and       eax,0E0000
       cmp       eax,60000
       je        near ptr M03_L20
M03_L06:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbp
       rol       r8,20
       xor       r8,r14
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L07:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbp
       jne       near ptr M03_L34
       mov       r9,r14
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L34
       cmp       r10d,[rax]
       jne       near ptr M03_L41
M03_L08:
       test      r9d,r9d
       je        short M03_L09
       cmp       r9d,1
       je        near ptr M03_L32
       mov       rcx,rbp
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M03_L32
M03_L09:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,r14
       mov       rax,rbp
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L10:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,r14
       jne       near ptr M03_L35
       mov       r9,rbp
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L35
       cmp       r10d,[rax]
       jne       near ptr M03_L42
M03_L11:
       test      r9d,r9d
       je        short M03_L12
       cmp       r9d,1
       je        short M03_L13
       mov       rcx,r14
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       short M03_L13
M03_L12:
       mov       ecx,[r14]
       and       ecx,0F0000
       cmp       ecx,0C0000
       je        short M03_L13
       mov       ecx,[rbp]
       and       ecx,0F0000
       cmp       ecx,0C0000
       jne       near ptr M03_L19
M03_L13:
       mov       eax,2
M03_L14:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L15:
       test      r10d,r10d
       je        near ptr M03_L39
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L00
       jmp       near ptr M03_L39
M03_L16:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rdi
       mov       rax,rbx
       add       rdx,10
       rol       r8,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L17:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rdi
       jne       near ptr M03_L03
       mov       r9,rbx
       xor       r9,[rax+10]
       cmp       r9,1
       ja        near ptr M03_L03
       cmp       r10d,[rax]
       jne       near ptr M03_L40
M03_L18:
       test      r9d,r9d
       je        short M03_L19
       cmp       r9d,1
       je        near ptr M03_L02
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       jne       near ptr M03_L02
M03_L19:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L20:
       call      qword ptr [7FFD262F3EF0]
       mov       ebx,eax
       mov       rcx,rsi
       call      qword ptr [7FFD262F3EF0]
       mov       esi,eax
       mov       ecx,ebx
       call      qword ptr [7FFD262E9318]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       mov       edi,eax
       mov       ecx,esi
       call      qword ptr [7FFD262E9318]; Precode of System.Array.GetNormalizedIntegralArrayElementType(System.Reflection.CorElementType)
       cmp       edi,eax
       je        near ptr M03_L32
       cmp       ebx,0E
       jge       short M03_L21
       cmp       ebx,0E
       jae       near ptr M03_L43
       mov       eax,ebx
       lea       rcx,[7FFD25668350]
       movsx     rax,word ptr [rcx+rax*2]
       bt        eax,esi
       jae       short M03_L19
       jmp       short M03_L22
M03_L21:
       cmp       ebx,esi
       jne       short M03_L19
M03_L22:
       mov       eax,5
       jmp       near ptr M03_L14
M03_L23:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       mov       r8,rsi
       add       rdx,10
       mov       rax,rbx
       rol       rax,20
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L24:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M03_L27
       mov       r9,rsi
       xor       r9,[rax+10]
       cmp       r9,1
       ja        short M03_L27
       cmp       r10d,[rax]
       jne       near ptr M03_L38
M03_L25:
       test      r9d,r9d
       je        near ptr M03_L19
       cmp       r9d,1
       je        short M03_L26
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L19
M03_L26:
       mov       eax,3
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L27:
       test      r10d,r10d
       je        near ptr M03_L38
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L24
       jmp       near ptr M03_L38
M03_L28:
       mov       rdi,rsi
       test      cl,2
       jne       short M03_L29
       test      sil,2
       jne       near ptr M03_L36
M03_L29:
       call      qword ptr [7FFD262D8C00]
       mov       rdx,[rax]
       add       rdx,10
       mov       r8,rbx
       rol       r8,20
       xor       r8,rdi
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       ecx,[rdx]
       shr       r8,cl
       xor       ecx,ecx
M03_L30:
       lea       eax,[r8+1]
       cdqe
       lea       rax,[rax+rax*2]
       lea       rax,[rdx+rax*8]
       mov       r10d,[rax]
       mov       r9,[rax+8]
       and       r10d,0FFFFFFFE
       cmp       r9,rbx
       jne       short M03_L33
       mov       rsi,rdi
       xor       rsi,[rax+10]
       cmp       rsi,1
       ja        short M03_L33
       cmp       r10d,[rax]
       jne       near ptr M03_L37
M03_L31:
       test      esi,esi
       je        near ptr M03_L19
       cmp       esi,1
       je        short M03_L32
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD262F3F10]; Precode of System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       test      eax,eax
       je        near ptr M03_L19
M03_L32:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L33:
       test      r10d,r10d
       je        short M03_L37
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        short M03_L30
       jmp       short M03_L37
M03_L34:
       test      r10d,r10d
       je        short M03_L41
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L07
       jmp       short M03_L41
M03_L35:
       test      r10d,r10d
       je        short M03_L42
       inc       ecx
       add       r8d,ecx
       and       r8d,[rdx+4]
       cmp       ecx,8
       jl        near ptr M03_L10
       jmp       short M03_L42
M03_L36:
       xor       esi,esi
       jmp       short M03_L31
M03_L37:
       mov       esi,2
       jmp       near ptr M03_L31
M03_L38:
       mov       r9d,2
       jmp       near ptr M03_L25
M03_L39:
       mov       r9d,2
       jmp       near ptr M03_L01
M03_L40:
       mov       r9d,2
       jmp       near ptr M03_L18
M03_L41:
       mov       r9d,2
       jmp       near ptr M03_L08
M03_L42:
       mov       r9d,2
       jmp       near ptr M03_L11
M03_L43:
       call      qword ptr [7FFD262D7FC0]
       int       3
; Total bytes of code 1451
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
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        near ptr M05_L12
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
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M06_L02
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M06_L01
M06_L00:
       add       rsp,28
       ret
M06_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M06_L00
M06_L02:
       add       rsp,28
       jmp       qword ptr [7FFCC71DF6C0]
; Total bytes of code 49
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
       je        near ptr M07_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M07_L01
       test      rsi,rsi
       je        short M07_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M07_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M07_L00:
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
M07_L01:
       test      rsi,rsi
       je        short M07_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L03
M07_L02:
       mov       rax,1E62A6E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
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
M07_L04:
       call      qword ptr [7FFCC71DFD20]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FFCC6885C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L26
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L28
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L27
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC71DEDF0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC71DEDF0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC71DEFB8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC71DEDA8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC71DF2D0]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L30
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       jbe       short M00_L23
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC7084F30]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L24
M00_L23:
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L31
M00_L24:
       mov       [rbx+10],edi
M00_L25:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L26:
       call      qword ptr [7FFCC6F56A00]
       mov       ecx,0C5
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C85D90
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DB5118
       call      qword ptr [7FFCC6B07738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6887858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC708C798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC708C7B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       call      M00_L34
       nop
M00_L28:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC6885728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2553C402000
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L29:
       mov       ecx,11
       call      qword ptr [7FFCC6B07DF8]
       int       3
M00_L30:
       mov       rcx,2553C401EF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L24
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC71DF288]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L24
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC71DEDC0]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC71DEDA8]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC71DEDC0]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1111
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71DEE80]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC688D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M02_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 199
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6885818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,295D12A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFCC71DFDB0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFCC6885C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        near ptr M05_L12
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
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M06_L07
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L00
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
       jne       near ptr M06_L08
M06_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M06_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L02:
       sub       ebp,eax
       js        near ptr M06_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M06_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M06_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L16
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
M06_L03:
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
       jne       short M06_L04
       cmp       r8,14
       jne       near ptr M06_L15
       jmp       near ptr M06_L14
M06_L04:
       cmp       r8,4000
       ja        near ptr M06_L13
       jmp       near ptr M06_L12
M06_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M06_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L05
M06_L13:
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
M06_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M06_L05
M06_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L25
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L26
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC7265E78]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC7265E78]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC7265E60]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC72647C8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC726E550]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L29
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       ja        near ptr M00_L31
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L30
M00_L23:
       mov       [rbx+10],edi
M00_L24:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L25:
       call      qword ptr [7FFCC6F4E5C8]
       mov       ecx,0C5
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C75D90
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71A4288]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71A42A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      M00_L34
       nop
M00_L27:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC6875728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E88C002C00
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFCC6AF7DF8]
       int       3
M00_L29:
       mov       rcx,1E88C001F08
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L31:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6F4E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC71AFE88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L23
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC72652C0]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC72647C8]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC72652C0]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71AF6D8]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC687D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22920F70008
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
       call      qword ptr [7FFCC7267198]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFCC6875C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        short M05_L09
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       vzeroupper
       ret
M05_L06:
       cmp       r8,800
       ja        near ptr M05_L12
       cmp       r8,100
       jae       short M05_L10
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L04
M05_L10:
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
M05_L11:
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       je        near ptr M06_L07
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L00
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
       jne       near ptr M06_L08
M06_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M06_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L02:
       sub       ebp,eax
       js        near ptr M06_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M06_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M06_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L16
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
M06_L03:
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
       jne       short M06_L04
       cmp       r8,14
       jne       near ptr M06_L15
       jmp       near ptr M06_L14
M06_L04:
       cmp       r8,4000
       ja        near ptr M06_L13
       jmp       near ptr M06_L12
M06_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M06_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L05
M06_L13:
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
M06_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M06_L05
M06_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L25
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L26
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC72A5EF0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC72A5EF0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC72A5ED8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC72A47C8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC72AE550]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L29
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       ja        near ptr M00_L31
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L30
M00_L23:
       mov       [rbx+10],edi
M00_L24:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L25:
       call      qword ptr [7FFCC6F8E5C8]
       mov       ecx,0C5
       mov       rdx,7FFCC6DE5118
       call      qword ptr [7FFCC6B37738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CB5D90
       call      qword ptr [7FFCC6B37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DE5118
       call      qword ptr [7FFCC6B37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68B7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71E4270]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71E4288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      M00_L34
       nop
M00_L27:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC68B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B6AF000C08
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFCC6B37DF8]
       int       3
M00_L29:
       mov       rcx,1B699001F08
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L31:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6F8DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC68B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC71EFE88]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L23
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC72A52C0]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC72A47C8]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC72A52C0]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71EF690]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC68BD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F72DF20008
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
       call      qword ptr [7FFCC72A7228]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFCC68B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        near ptr M05_L12
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
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68B66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M06_L07
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L00
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
       jne       near ptr M06_L08
M06_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M06_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L02:
       sub       ebp,eax
       js        near ptr M06_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M06_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M06_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L16
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
M06_L03:
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
       jne       short M06_L04
       cmp       r8,14
       jne       near ptr M06_L15
       jmp       near ptr M06_L14
M06_L04:
       cmp       r8,4000
       ja        near ptr M06_L13
       jmp       near ptr M06_L12
M06_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M06_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L05
M06_L13:
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
M06_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M06_L05
M06_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L25
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L26
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC7295E90]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC7295E90]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC7295E78]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC72947E0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC729E628]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L29
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       ja        near ptr M00_L31
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L30
M00_L23:
       mov       [rbx+10],edi
M00_L24:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L25:
       call      qword ptr [7FFCC6F7E5E0]
       mov       ecx,0C5
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6CA5D90
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DD5118
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC71D43D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC71D43F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      M00_L34
       nop
M00_L27:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC68A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1471B800C08
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFCC6B27DF8]
       int       3
M00_L29:
       mov       rcx,14705801F08
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L31:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6F7DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC71DFEA0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L23
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC72952D8]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC72947E0]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC72952D8]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71DF6A8]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC68AD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1879A9D0008
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
       call      qword ptr [7FFCC7297240]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FFCC68A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        near ptr M05_L12
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
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
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
       je        near ptr M06_L07
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L00
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
       jne       near ptr M06_L08
M06_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M06_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L02:
       sub       ebp,eax
       js        near ptr M06_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M06_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M06_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L16
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
M06_L03:
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
       jne       short M06_L04
       cmp       r8,14
       jne       near ptr M06_L15
       jmp       near ptr M06_L14
M06_L04:
       cmp       r8,4000
       ja        near ptr M06_L13
       jmp       near ptr M06_L12
M06_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M06_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L05
M06_L13:
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
M06_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M06_L05
M06_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L26
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L28
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L27
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC71CE7C0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC71CE7C0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC71CF090]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC71CE898]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC71CF3A8]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L30
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       jbe       short M00_L23
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6FCCF60]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L24
M00_L23:
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L31
M00_L24:
       mov       [rbx+10],edi
M00_L25:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L26:
       call      qword ptr [7FFCC6F46A00]
       mov       ecx,0C5
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C75D90
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC707C8A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC707C8B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       call      M00_L34
       nop
M00_L28:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCC6875728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29819C02010
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L29:
       mov       ecx,11
       call      qword ptr [7FFCC6AF7DF8]
       int       3
M00_L30:
       mov       rcx,29819C01EF0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L24
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC71CF360]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L24
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC71CE7F0]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC71CE898]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC71CE7F0]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1111
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       call      qword ptr [7FFCC71CE868]
       int       3
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M01_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC687D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD26475D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD267DF778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2D8AEBD0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FFCC7244000]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFCC6875C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L11
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
       ja        short M05_L09
M05_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L05:
       vzeroupper
       ret
M05_L06:
       cmp       r8,800
       ja        near ptr M05_L12
       cmp       r8,100
       jae       short M05_L10
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
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M05_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L04
M05_L10:
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
M05_L11:
       cmp       rcx,rdx
       jne       short M05_L12
       cmp       [rdx],dl
       jmp       near ptr M05_L05
M05_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCC68766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
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
       je        near ptr M06_L07
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L00
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
       jne       near ptr M06_L08
M06_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M06_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M06_L02:
       sub       ebp,eax
       js        near ptr M06_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M06_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M06_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M06_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L16
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
M06_L03:
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
       jne       short M06_L04
       cmp       r8,14
       jne       near ptr M06_L15
       jmp       near ptr M06_L14
M06_L04:
       cmp       r8,4000
       ja        near ptr M06_L13
       jmp       near ptr M06_L12
M06_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M06_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M06_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L05
M06_L13:
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
M06_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M06_L05
M06_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L25
       mov       [rbp-60],rbx
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L27
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,rsi
       call      00007FFD263B9E20
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
       call      00007FFD263B9E20
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
       mov       rbx,[rbp-60]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M00_L08
M00_L07:
       mov       eax,[rcx+24]
       sub       eax,[rcx+28]
       add       edx,eax
       jo        near ptr M00_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L07
M00_L08:
       test      edx,edx
       jle       near ptr M00_L26
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
       jae       short M00_L17
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
       mov       [rbp-68],rsi
       jmp       short M00_L21
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFCC70AC6C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCC70AC6C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCC71C4C48]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCC70A6AD8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       xor       ecx,ecx
       mov       [rbp-48],ecx
M00_L20:
       lea       rcx,[rbp-48]
       mov       edx,14
       call      qword ptr [7FFCC7444F18]
       cmp       dword ptr [rbx+2C],0
       jne       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       call      M00_L34
       nop
       mov       rsi,[rbp-68]
M00_L22:
       test      rsi,rsi
       je        near ptr M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L29
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbx+8]
       mov       ecx,[rsi+8]
       mov       rcx,[rsi]
       cmp       rcx,[r8]
       jne       near ptr M00_L33
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       edi,[rsi+8]
       ja        near ptr M00_L33
       cmp       edi,[r8+8]
       ja        near ptr M00_L33
       mov       edx,edi
       movzx     eax,word ptr [rcx]
       imul      rax,rdx
       lea       rdx,[rsi+10]
       add       r8,10
       test      dword ptr [rcx],1000000
       je        near ptr M00_L32
       cmp       rax,4000
       ja        near ptr M00_L31
       mov       rcx,r8
       mov       r8,rax
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
       jne       near ptr M00_L30
M00_L23:
       mov       [rbx+10],edi
M00_L24:
       mov       [rbp-58],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-58]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L25:
       call      qword ptr [7FFCC6F4E580]
       mov       ecx,0C5
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCC6C75D90
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCC6DA5118
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC70A7F78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC70A7F90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      M00_L34
       nop
M00_L27:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22DAF800C68
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFCC6AF7DF8]
       int       3
M00_L29:
       mov       rcx,22D99801F40
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L31:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6F4DFE0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L32:
       mov       rcx,r8
       mov       r8,rax
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L23
M00_L33:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC70A5EA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L23
M00_L34:
       sub       rsp,38
       cmp       dword ptr [rbp-3C],0
       je        short M00_L39
       mov       rbx,[rbp-60]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L37
M00_L35:
       cmp       byte ptr [rsi+34],0
       je        short M00_L36
       mov       byte ptr [rsi+34],0
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L36
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC70A7630]
M00_L36:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L35
M00_L37:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L38
       xor       ecx,ecx
       call      qword ptr [7FFCC70A6AD8]
       int       3
M00_L38:
       mov       rcx,rbx
       call      00007FFD26476030
       test      eax,eax
       je        short M00_L39
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC70A7630]
M00_L39:
       nop
       add       rsp,38
       ret
; Total bytes of code 1117
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M01_L01
       cmp       rdx,[r8]
       je        short M01_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M01_L03
M01_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD264C7B10
M01_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M01_L02:
       call      qword ptr [7FFCC70A55A8]
       int       3
M01_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCC687D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD262D8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD262D8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M03_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L00
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD264C8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       test      rbx,rbx
       je        short M03_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L02
M03_L01:
       mov       rax,26E2E770008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFCC7297DE0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFCC6875C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      00007FFD26475D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD267DF778],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
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
       call      00007FFD26475D60
       cmp       dword ptr [7FFD267DF778],0
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
       jmp       qword ptr [7FFCC68766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M07_L07
       test      rsi,rsi
       je        near ptr M07_L06
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
       jne       near ptr M07_L08
M07_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M07_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD262E9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD263009C8]
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
       call      qword ptr [7FFD262E9320]
       test      eax,eax
       je        short M07_L03
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
       jne       short M07_L04
       cmp       r8,14
       jne       near ptr M07_L15
       jmp       near ptr M07_L14
M07_L04:
       cmp       r8,4000
       ja        near ptr M07_L13
       jmp       near ptr M07_L12
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
       call      qword ptr [7FFD262EB268]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD262EB268]
       int       3
M07_L08:
       call      qword ptr [7FFD262E2830]
       mov       rbx,rax
       call      qword ptr [7FFD262EDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EC810]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD263009B0]
       int       3
M07_L10:
       call      qword ptr [7FFD262E25F8]
       mov       rbx,rax
       call      qword ptr [7FFD262ECC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD262EB218]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FFD262E25F8]
       mov       r14,rax
       call      qword ptr [7FFD262ECC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD262EB218]
       mov       rcx,r14
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262E96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M07_L05
       call      qword ptr [7FFD262D8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L05
M07_L13:
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
M07_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M07_L05
M07_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD262EC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L05
M07_L16:
       call      qword ptr [7FFD262E2620]
       mov       rbx,rax
       call      qword ptr [7FFD262ED730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD262EB298]
       mov       rcx,rbx
       call      qword ptr [7FFD262D7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

