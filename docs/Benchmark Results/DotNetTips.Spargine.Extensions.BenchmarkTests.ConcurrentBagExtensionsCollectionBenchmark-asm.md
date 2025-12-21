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
       mov       rcx,23225000880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFB5230]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FFA8AD55D58]
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A685A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5D0FB8
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
       mov       r11,7FFA8A5D0FB0
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
       call      qword ptr [7FFA8A68F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFBD458]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8B074138]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FFA8A68F480]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FFA8B07E868]
       int       3
M00_L26:
       call      qword ptr [7FFA8AFB4A68]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD55D58]
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
       call      qword ptr [7FFA8AD5E028]
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFA8B07E940]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B07E940]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FFA8B074138]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,272A3F12968
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
       call      qword ptr [7FFA8A6857A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB5350]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L63
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L66
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       test      byte ptr [7FFA8B026E20],1
       je        near ptr M00_L65
M00_L47:
       mov       rcx,23225000C00
       mov       r15,[rcx]
M00_L48:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L57
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L57
       jmp       short M00_L51
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FFA8AFB5488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L50:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB54B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L51:
       mov       rcx,r15
       call      qword ptr [7FFA8AA6D230]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L62
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L60
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L61
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB5368]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L50
       jmp       short M00_L49
M00_L52:
       mov       rcx,rsi
       call      qword ptr [7FFA8AFB5488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB54B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       rcx,r15
       call      qword ptr [7FFA8AA6D230]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L55:
       test      eax,eax
       je        near ptr M00_L62
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L59
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L60
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L61
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L56:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB5368]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L53
       jmp       short M00_L52
M00_L57:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L54
M00_L58:
       mov       rcx,r15
       mov       r11,7FFA8A5D0FC8
       call      qword ptr [r11]
       jmp       short M00_L55
M00_L59:
       mov       rcx,r15
       mov       r11,7FFA8A5D0FD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L56
M00_L60:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8B07C390]
       int       3
M00_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L62:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L67
M00_L63:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B027020
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFBD0B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L64:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L48
M00_L65:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L47
M00_L66:
       mov       rcx,rdi
       mov       r11,7FFA8A5D0FC0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L48
M00_L67:
       mov       rcx,r15
       mov       r11,7FFA8A5D0FD8
       call      qword ptr [r11]
       jmp       near ptr M00_L63
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB5350]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5D0FD8
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 2514
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
       call      qword ptr [7FFA8AFB5278]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0B04E8
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
       mov       rcx,7FFA8B0B04EC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B075CE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB25A10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B075CF8]
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
       mov       rcx,7FFA8B0B04F4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0B04F8
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0B04F0
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
       mov       rcx,7FFA8B0B04FC
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
       mov       rcx,7FFA8B0D0418
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A685A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0D0410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0D0414
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
       int       3
; Total bytes of code 315
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
       jne       near ptr M05_L08
M05_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M05_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
       test      eax,eax
       je        short M05_L03
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
       jne       short M05_L04
       cmp       r8,14
       jne       near ptr M05_L15
       jmp       near ptr M05_L14
M05_L04:
       cmp       r8,4000
       ja        near ptr M05_L13
       jmp       near ptr M05_L12
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M05_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M05_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M05_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L05
M05_L13:
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
M05_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M05_L05
M05_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L05
M05_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       jmp       qword ptr [7FFA8A6866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M08_L02
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M08_L01
M08_L00:
       add       rsp,28
       ret
M08_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L00
M08_L02:
       add       rsp,28
       jmp       qword ptr [7FFA8AD5E028]
; Total bytes of code 49
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
       call      qword ptr [7FFA8B07E730]
       int       3
M09_L03:
       call      qword ptr [7FFA8B07E748]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
M10_L04:
       mov       rcx,[rbp+10]
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
       call      qword ptr [7FFA8AFB53B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B153D00
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFA8B152368
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B1518C0
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8B074918]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8AA4C060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFA8B07E928]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8B074918]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       je        near ptr M11_L09
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
       jo        near ptr M11_L12
       mov       [rcx+24],eax
       jmp       near ptr M11_L14
M11_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFAEA1A9E20
       test      eax,eax
       je        near ptr M11_L10
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
       je        near ptr M11_L11
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
       jne       near ptr M11_L13
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFA8A68F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       je        short M11_L08
M11_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M11_L01
M11_L08:
       lock inc  qword ptr [rsi]
       jmp       short M11_L07
M11_L09:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFA8A685998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8AA4C060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L03
M11_L11:
       mov       rcx,rdx
       mov       rdx,7FFA8B152368
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L04
M11_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L13:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFA8ACDCCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACDCCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M11_L05
M11_L14:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
       jne       short M11_L16
M11_L15:
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
M11_L16:
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L15
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M11_L18:
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
       mov       rdx,7FFA8B1518C0
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFA8AFB5380]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jmp       qword ptr [7FFA8A685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,1FD7F800880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AF95230]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A665A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5B1138
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
       mov       r11,7FFA8A5B1130
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
       call      qword ptr [7FFA8A66F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AF9D380]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A66F480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B05E898]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD35D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD35D28]
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
       call      qword ptr [7FFA8AD3DFF8]
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B05E9B8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B05E9B8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8AF9FFD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,23DFE7F2968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AF94A20]
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
       call      qword ptr [7FFA8ACBCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AF95350]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B006E90],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1FD7F800C00
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
       call      qword ptr [7FFA8AF95488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B05F6A8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AF95398]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AF954B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA5F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AF95488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B05F6A8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AF95398]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AF954B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA5F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B0552C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B05E928]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5B1148
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5B1150
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8B0552C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B05E928]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8B05C3C0]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8B05E8F8]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8B05E940]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB07828]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B007090
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AF9D0B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5B1140
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5B1158
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AF95350]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5B1158
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AF95278]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0906B8
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
       mov       rcx,7FFA8B0906BC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B055CF8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB059E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B055D10]
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
       mov       rcx,7FFA8B0906C4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0906C8
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0906C0
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
       mov       rcx,7FFA8B0906CC
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
       mov       rcx,7FFA8B0B04C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A665A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0B04B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0B04BC
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
       int       3
; Total bytes of code 315
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
       jmp       qword ptr [7FFA8A6666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M07_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M07_L01:
       sub       edi,eax
       js        near ptr M07_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M07_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M07_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M07_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M07_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M07_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M07_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M07_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L05
M07_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       je        near ptr M08_L04
       test      rsi,rsi
       je        near ptr M08_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M08_L03
       cmp       dword ptr [rcx+4],18
       jne       near ptr M08_L12
       test      r14d,r14d
       jl        near ptr M08_L11
       test      edi,edi
       jl        near ptr M08_L10
       test      ebp,ebp
       jl        near ptr M08_L09
       lea       eax,[rdi+r14]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L08
       lea       eax,[r14+rbp]
       cmp       eax,[rsi+8]
       ja        near ptr M08_L07
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
       mov       rcx,7FFA8B1289E8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M08_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M08_L05
M08_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L01:
       mov       rcx,7FFA8B128A0C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M08_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L00
M08_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M08_L00
M08_L03:
       mov       rcx,7FFA8B128A04
       call      CORINFO_HELP_COUNTPROFILE32
M08_L04:
       mov       rcx,7FFA8B128A10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8AF9FFD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M08_L00
M08_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L00
M08_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFA8AD3DFF8]
M08_L07:
       mov       rcx,7FFA8B1289EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L04
M08_L08:
       mov       rcx,7FFA8B1289F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L04
M08_L09:
       mov       rcx,7FFA8B1289F4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L04
M08_L10:
       mov       rcx,7FFA8B1289F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
M08_L11:
       mov       rcx,7FFA8B1289FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
M08_L12:
       mov       rcx,7FFA8B128A00
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,7FFA8B128A08
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
; Total bytes of code 490
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
       call      qword ptr [7FFA8B05E868]
       int       3
M09_L03:
       call      qword ptr [7FFA8B05E880]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M09_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AF953B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B133938
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFA8B131DE8
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B131C68
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8B054918]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8B056040]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFA8B05E970]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8B055410]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8B054918]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8B055410]
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M11_L01
M11_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8B05E910]
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
       jmp       qword ptr [7FFA8AF953B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M12_L02:
       mov       rdx,7FFA8B131C68
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       je        near ptr M13_L08
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
       jmp       near ptr M13_L14
M13_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFAEA1A9E20
       test      eax,eax
       je        near ptr M13_L09
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
       je        near ptr M13_L10
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
       call      qword ptr [7FFA8A66F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       je        near ptr M13_L13
M13_L07:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       near ptr M13_L01
M13_L08:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFA8A665998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A666820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M13_L00
M13_L09:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8B056040]
       jmp       near ptr M13_L03
M13_L10:
       mov       rcx,rdx
       mov       rdx,7FFA8B131DE8
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L04
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
       call      qword ptr [7FFA8ACBCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACBCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M13_L05
M13_L13:
       lock inc  qword ptr [rsi]
       jmp       near ptr M13_L07
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
       call      qword ptr [7FFA8A666820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M13_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M13_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A666820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A666820]; System.Threading.Monitor.Exit(System.Object)
M13_L18:
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A665C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,1BBA5400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFB5248]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A685A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5D1138
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
       mov       r11,7FFA8A5D1130
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
       call      qword ptr [7FFA8A68F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFBD470]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A68F480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B07E8B0]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD55D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD55D28]
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
       call      qword ptr [7FFA8AD5DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B07E9D0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B07E9D0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8B074000]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,1FC245D2968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AFB4A50]
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
       call      qword ptr [7FFA8ACDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB5368]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B028508],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1BBA5400C00
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
       call      qword ptr [7FFA8AFB54A0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B07F6D8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFB53B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB54D0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA7F868]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFB54A0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B07F6D8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFB53B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB54D0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA7F868]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B0752D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B07E940]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5D1148
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5D1150
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8B0752D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B07E940]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8B07C3D8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8B07E910]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8B07E958]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB27828]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B028708
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFBD0C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5D1140
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5D1158
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB5368]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5D1158
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AFB5290]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0B1DC8
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
       mov       rcx,7FFA8B0B1DCC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B075D10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB259E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B075D28]
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
       mov       rcx,7FFA8B0B1DD4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0B1DD8
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0B1DD0
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
       mov       rcx,7FFA8B0B1DDC
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
       mov       rcx,7FFA8B0D27C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A685A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0D27C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0D27C4
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFA8A6866E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B14A770
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B14A794
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B14A78C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B14A798
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8B074000]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD5DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B14A774
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B14A778
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B14A77C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B14A780
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B14A784
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B14A788
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B14A790
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
       call      qword ptr [7FFA8B07E880]
       int       3
M10_L03:
       call      qword ptr [7FFA8B07E898]; System.Threading.Lock.SignalWaiterIfNecessary(State)
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA8AFB53C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B153938
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B151DE8
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B151C68
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8B074930]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8B076058]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B07E988]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8B075428]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8B074930]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8B075428]
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 540
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8B07E928]
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
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M13_L03
M13_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA8AFB53C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B151C68
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A685998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A68F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFA8A685998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L08:
       mov       rcx,rdx
       mov       rdx,7FFA8B151DE8
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8ACDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACDCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L13
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L15
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A686820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,13E3DC00880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFC51D0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5E1130
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
       mov       r11,7FFA8A5E1128
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
       call      qword ptr [7FFA8A69F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFCD3F8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A69F480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B08E850]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD65D40]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D40]
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
       call      qword ptr [7FFA8AD6E010]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B08E970]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B08E970]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8AFCFF78]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,17EBCB22968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AFC49A8]
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
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFC52F0]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B036E20],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,13E3DC00C00
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
       call      qword ptr [7FFA8AFC5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B08EB50]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFC5338]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFC5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA8F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFC5428]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B08EB50]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFC5338]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFC5458]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA8F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B085260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B08E8E0]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5E1140
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5E1148
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8B085260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B08E8E0]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8B08C360]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8B08E8B0]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8B08E8F8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB37828]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B037020
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFCD050]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5E1138
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5E1150
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFC52F0]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5E1150
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AFC5218]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0C04E8
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
       mov       rcx,7FFA8B0C04EC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B085C98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB359E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B085CB0]
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
       mov       rcx,7FFA8B0C04F4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0C04F8
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0C04F0
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
       mov       rcx,7FFA8B0C04FC
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
       mov       rcx,7FFA8B0E0528
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0E0520
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0E0524
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFA8A6966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B158A30
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B158A54
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B158A4C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B158A58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8AFCFF78]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD6E010]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B158A34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B158A38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B158A3C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B158A40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B158A44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B158A48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B158A50
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
       call      qword ptr [7FFA8B08E820]
       int       3
M10_L03:
       call      qword ptr [7FFA8B08E838]
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFC5350]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B163938
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B161DE8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B161C68
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8B0848B8]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8B085F68]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B08E928]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8B0853B0]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8B0848B8]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8B0853B0]
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8B08E8C8]
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
       jmp       qword ptr [7FFA8AFC5350]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B161C68
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       near ptr M14_L11
M14_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A69F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       jne       short M14_L06
       lock inc  qword ptr [rsi]
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
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L08:
       mov       rcx,rdx
       mov       rdx,7FFA8B161DE8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M14_L04
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
M14_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 648
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A695C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,201FE000880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFA5230]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A675A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5C0FD0
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
       mov       r11,7FFA8A5C0FC8
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
       call      qword ptr [7FFA8A67F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFAD458]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A67F480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B06E8F8]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD45D28]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD45D28]
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
       call      qword ptr [7FFA8AD4E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A675818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B06E9B8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B06E9B8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8B064150]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2427CF72968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AFA4A38]
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
       call      qword ptr [7FFA8ACCCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFA5350]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B016E20],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,201E8002008
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
       call      qword ptr [7FFA8AFA5488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B06EA18]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFA5398]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFA54B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA6F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFA5488]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B06EA18]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFA5398]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFA54B8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA6F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B065410]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFAD548]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5C0FE0
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5C0FE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8B065410]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFAD548]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8AFAD5A8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8AFAD5C0]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8AFAD5D8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB17828]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B017020
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFAD0B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5C0FD8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5C0FF0
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFA5350]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5C0FF0
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AFA5278]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0A0C18
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
       mov       rcx,7FFA8B0A0C1C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B065E30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB159E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B065E48]
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
       mov       rcx,7FFA8B0A0C24
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0A0C28
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0A0C20
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
       mov       rcx,7FFA8B0A0C2C
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
       mov       rcx,7FFA8B0C1870
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A675A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0C1868
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0C186C
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFA8A6766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B139490
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B1394B4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A675818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B1394AC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B1394B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8B064150]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD4E4A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B139494
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B139498
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B13949C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B1394A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B1394A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B1394A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B1394B0
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
       call      qword ptr [7FFA8B06E8C8]
       int       3
M10_L03:
       call      qword ptr [7FFA8B06E8E0]
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFA53B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B022558
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B022568
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B022388
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8AFAD560]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8AFAD578]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B06E970]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8AFAD590]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8AFAD560]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AFAD590]
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8AFAD530]
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
       jmp       qword ptr [7FFA8AFA53B0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B022388
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A675998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A676820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFA8A675998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFA8B022568
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A67F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFA8ACCCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACCCC90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA8A676820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A676820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A676820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A675C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,158CA400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFD5350]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A6A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5F1150
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
       mov       r11,7FFA8A5F1148
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
       call      qword ptr [7FFA8A6AF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFDEF10]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A6AF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B09E880]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD75D58]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD75D58]
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
       call      qword ptr [7FFA8AD7E028]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A6A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B09E970]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B09E970]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8B094108]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,19949232968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AFD4B28]
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
       call      qword ptr [7FFA8ACFCCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFD5470]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B04C5B8],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,158B4402008
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
       call      qword ptr [7FFA8AFD55A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B09E9E8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFD54B8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFD55D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA25A68]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFD55A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B09E9E8]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFD54B8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFD55D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA25A68]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B0953C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFDEFE8]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5F1160
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5F1168
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8B0953C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFDEFE8]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8AFDF018]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8AFDF030]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8AFDF048]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB47858]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B04C7B8
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFDD170]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5F1158
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5F1170
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFD5470]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5F1170
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AFD5398]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0D27D0
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
       mov       rcx,7FFA8B0D27D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B095DE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB45A10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B095E00]
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
       mov       rcx,7FFA8B0D27DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0D27E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0D27D8
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
       mov       rcx,7FFA8B0D27E4
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
       mov       rcx,7FFA8B0F3168
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A6A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B0F3160
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B0F3164
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0D96A0]
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
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFA8A6A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B16A460
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B16A484
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A6A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B16A47C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B16A488
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8B094108]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD7E028]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B16A464
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B16A468
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B16A46C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B16A470
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B16A474
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B16A478
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B16A480
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
       call      qword ptr [7FFA8B09E820]
       int       3
M10_L03:
       call      qword ptr [7FFA8B09E838]
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFD54D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B052DA8
       call      qword ptr [7FFA8A6AF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B052DB8
       call      qword ptr [7FFA8A6AF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B052BD8
       call      qword ptr [7FFA8A6AF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8AFDF000]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8A97FA98]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B09E910]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8AA6CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8AFDF000]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AA6CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8AFDEFD0]
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
       jmp       qword ptr [7FFA8AFD54D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B052BD8
       call      qword ptr [7FFA8A6AF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A6A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A6A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFA8A6A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFA8B052DB8
       call      qword ptr [7FFA8A6AF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A6AF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFA8ACFCCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACFCCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA8A6A6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A6A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A6A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A6A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,264CD800880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFB5FC8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5E1318
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
       call      qword ptr [7FFA8AEC5728]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,r10
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       r11,7FFA8A5E1310
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
       call      qword ptr [7FFA8A69F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8AFBF330]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A69F480]
       int       3
M00_L24:
       mov       ecx,r13d
       call      qword ptr [7FFA8B07FFD8]
       int       3
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD65D58]
       int       3
M00_L26:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D58]
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
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L33:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L35
M00_L34:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8B2340C0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L35:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8B2340C0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8B074498]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L36:
       mov       rcx,2A54C7C2968
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L37:
       call      qword ptr [7FFA8AFB57B8]
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
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB60E8]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L70
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L73
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L71
       test      byte ptr [7FFA8B03E660],1
       je        near ptr M00_L72
M00_L41:
       mov       rcx,264CD800AD0
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
       call      qword ptr [7FFA8AFB6430]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L47
M00_L44:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFA8B234120]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L60
       xor       r12d,r12d
M00_L45:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFB6340]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L46:
       test      rcx,rcx
       je        short M00_L43
M00_L47:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB6460]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFA8AA76E28]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFB6430]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L54
M00_L51:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L66
       call      qword ptr [7FFA8B234120]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L64
       xor       r12d,r12d
M00_L52:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFB6340]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L53:
       test      rcx,rcx
       je        short M00_L50
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFB6460]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L61
       mov       rcx,r15
       call      qword ptr [7FFA8AA76E28]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8B075260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L49
M00_L60:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFBF2A0]
       test      eax,eax
       je        near ptr M00_L45
       jmp       short M00_L67
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5E1328
       call      qword ptr [r11]
       jmp       near ptr M00_L56
M00_L62:
       mov       rcx,r15
       mov       r11,7FFA8A5E1330
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L57
M00_L63:
       mov       ecx,0E
       call      qword ptr [7FFA8B075260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L58
M00_L64:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AFBF2A0]
       test      eax,eax
       je        near ptr M00_L52
       jmp       short M00_L67
M00_L65:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8AFBF2D0]
       int       3
M00_L66:
       mov       rcx,r13
       call      qword ptr [7FFA8AFBF2E8]
       int       3
M00_L67:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8AFBF300]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB37858]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B03E860
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFBDFF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5E1320
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L74:
       mov       rcx,r15
       mov       r11,7FFA8A5E1338
       call      qword ptr [r11]
       jmp       near ptr M00_L70
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L75
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFB60E8]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5E1338
       call      qword ptr [r11]
M00_L76:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
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
       call      qword ptr [7FFA8AFB6010]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFAE9461390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFA8B0C9B18
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
       mov       rcx,7FFA8B0C9B1C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B0765C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB35A10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8B0765E0]
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
       mov       rcx,7FFA8B0C9B24
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFA8B0C9B28
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFA8B0C9B20
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
       mov       rcx,7FFA8B0C9B2C
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
       call      00007FFAEA265D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       rcx,7FFA8B0EC068
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L02
       mov       rcx,7FFA8B0EC060
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       mov       rcx,7FFA8B0EC064
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       xor       ecx,ecx
       test      ebp,ebp
       jle       short M05_L02
       cmp       [rdi+8],ebp
       jl        short M05_L03
M05_L00:
       mov       edx,ecx
       shl       rdx,4
       cmp       dword ptr [rdi+rdx+14],0FFFFFFFF
       jl        short M05_L01
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
       jae       near ptr M05_L05
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
       jl        short M05_L00
M05_L02:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L03:
       cmp       ecx,[rdi+8]
       jae       short M05_L05
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rdi+rax+10]
       cmp       dword ptr [rdx+4],0FFFFFFFF
       jl        short M05_L04
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
       jae       short M05_L05
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+4],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L04:
       inc       ecx
       cmp       ecx,ebp
       jl        short M05_L03
       jmp       short M05_L02
M05_L05:
       call      qword ptr [7FFAEA0C7FC0]
       int       3
; Total bytes of code 315
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
       jne       short M06_L01
       test      r8b,4
       je        short M06_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L05
M06_L00:
       test      r8,r8
       je        short M06_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L05
M06_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
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
       jmp       qword ptr [7FFA8A6966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       je        near ptr M09_L05
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       jne       near ptr M09_L04
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
       je        short M09_L02
       mov       rcx,7FFA8B1909A8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       jbe       short M09_L00
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFA8AEC5728]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M09_L06
M09_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L02:
       mov       rcx,7FFA8B1909CC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L03
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L01
M09_L04:
       mov       rcx,7FFA8B1909C4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L05:
       mov       rcx,7FFA8B1909D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8B074498]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M09_L01
M09_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L01
M09_L07:
       mov       rcx,7FFA8B1909AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L08:
       mov       rcx,7FFA8B1909B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L09:
       mov       rcx,7FFA8B1909B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L10:
       mov       rcx,7FFA8B1909B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L11:
       mov       rcx,7FFA8B1909BC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L05
M09_L12:
       mov       rcx,7FFA8B1909C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L05
M09_L13:
       mov       rcx,7FFA8B1909C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L05
; Total bytes of code 483
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
       call      qword ptr [7FFA8B07FFA8]
       int       3
M10_L03:
       call      qword ptr [7FFA8B07FFC0]
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFB6358]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B0431B8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B0431C8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B042FE8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8AFBF2B8]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8AA57DF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B234048]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8AFBF2B8]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8AFBF288]
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
       jmp       qword ptr [7FFA8AFB6358]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B042FE8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFA8B0431C8
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A69F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A695C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       mov       rcx,1E1580008D8
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8AFEFAF8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFA8A5E1790
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
       mov       r11,7FFA8A5E1788
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
       call      qword ptr [7FFA8A69F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA8B137EB8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFA8A69F480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFA8B264A80]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD65D40]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D40]
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
       call      qword ptr [7FFA8AD6E010]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8AECC7B0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8AECC7B0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFA8AEC5FF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,221D6EF2500
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AEC70A8]
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
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFEFC18]; System.Threading.Lock.Exit(ThreadId)
       mov       r14d,[rbp-3C]
       mov       ecx,r14d
       not       ecx
       mov       [rdi+18],ecx
       mov       byte ptr [rdi+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+278]
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L69
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L72
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L70
       test      byte ptr [7FFA8B1B5398],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1E158000B80
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
       call      qword ptr [7FFA8AFEFD50]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B264BA0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFEFC60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFEFD80]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFA8AA8F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AFEFD50]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFA8B264BA0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA8AFEFC60]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA8AFEFD80]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFA8AA8F918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFA8AEC7510]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B137E40]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFA8A5E17A0
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFA8A5E17A8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFA8AEC7510]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFA8B137E40]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFA8B137E58]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFA8B137E70]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFA8B137E88]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA8AB37828]
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-58]
       mov       rdx,7FFA8B1B5598
       cmp       [rcx],ecx
       call      qword ptr [7FFA8B137870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFA8A5E1798
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFA8A5E17B0
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFA8AFEFC18]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFA8A5E17B0
       call      qword ptr [r11]
M00_L75:
       nop
       add       rsp,38
       ret
; Total bytes of code 2800
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
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
       call      qword ptr [7FFA8AFEFB40]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rcx,7FFAE9461390
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
       call      qword ptr [7FFA8AFE4960]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB359E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8AFE4978]
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
       mov       rcx,7FFA8B07DF30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B07DF28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B07DF2C
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      00007FFAEA265D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       jmp       qword ptr [7FFA8A6966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B24C0F8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B24C11C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B24C114
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B24C120
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8AEC5FF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD6E010]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B24C0FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B24C100
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B24C104
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B24C108
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B24C10C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B24C110
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B24C118
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
       call      qword ptr [7FFA8B264A50]
       int       3
M10_L03:
       call      qword ptr [7FFA8B264A68]
       jmp       short M10_L00
; Total bytes of code 69
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFEFC78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B1C1AD8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFA8B1C1AE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFA8B1C1908
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
       call      qword ptr [7FFA8AEC6B20]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8AECC348]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFA8B264AE0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
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
       call      qword ptr [7FFA8AEC7660]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFA8AEC6B20]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AEC7660]
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
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFAEA277470
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
       jmp       qword ptr [7FFA8B137E28]
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
       jmp       qword ptr [7FFA8AFEFC78]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFA8B1C1908
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L07:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8AECC348]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rdx,7FFA8B1C1AE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFA8A69F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACECCA8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L18
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
M14_L19:
       nop
       add       rsp,28
       ret
; Total bytes of code 673
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
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFA8A695C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ConcurrentBagExtensionsCollectionBenchmark.RemoveRange()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-70],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-88],rsi
       mov       [rbp+10],rbx
       mov       rdi,[rbx+278]
       mov       [rbp-90],rdi
       test      rdi,rdi
       je        near ptr M00_L55
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,288DA000910
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFA8B145068]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-0E0],r13
       mov       [rbp-74],ecx
       mov       r13,[r15+10]
       mov       r12d,[r13+10]
       mov       r9d,r12d
       mov       [rbp-3C],r9d
       test      r9d,r9d
       jg        short M00_L00
       mov       eax,[r15+20]
       jmp       short M00_L01
M00_L00:
       mov       rax,r13
       lea       edx,[r9-1]
       cmp       edx,r12d
       jae       near ptr M00_L36
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-40],eax
       mov       eax,[rbp-40]
       mov       r9d,[rbp-3C]
M00_L01:
       mov       rdx,[r15+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r13],r13b
       test      ecx,ecx
       jl        near ptr M00_L23
       mov       rdx,[r13+8]
       cmp       [rdx+8],ecx
       jge       near ptr M00_L04
       mov       rdx,[r13+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M00_L06
       mov       edx,4
M00_L02:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r12d
       jl        near ptr M00_L24
       mov       rcx,[r13+8]
       cmp       [rcx+8],edx
       je        near ptr M00_L04
       test      edx,edx
       jle       near ptr M00_L35
       mov       [rbp-40],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       test      r12d,r12d
       jle       near ptr M00_L03
       mov       rcx,[r13+8]
       mov       rdx,rcx
       mov       [rbp-0A8],rdx
       test      rdx,rdx
       je        near ptr M00_L32
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L29
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L28
       cmp       r12d,[rdx+8]
       ja        near ptr M00_L27
       cmp       r12d,[rax+8]
       ja        near ptr M00_L26
       mov       r8d,r12d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L31
       mov       rax,[rbp-0A0]
       cmp       r8,4000
       ja        near ptr M00_L30
       mov       rcx,r10
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       near ptr M00_L25
       mov       rax,[rbp-0A0]
M00_L03:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-40]
       mov       r9d,[rbp-3C]
M00_L04:
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       r13,[r15+8]
       mov       [rbp-40],eax
       mov       r12d,eax
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L05
       xor       ecx,ecx
       call      qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-50],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C8],rax
       movsxd    rdx,dword ptr [rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0D0],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-50]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9d,[rbp-3C]
M00_L05:
       mov       r8,[r13+10]
       mov       [rbp-0B0],r8
       mov       r10,[r13+18]
       mov       [rbp-0B8],r10
       test      r10,r10
       je        short M00_L07
       mov       rcx,r10
       mov       edx,r12d
       mov       r11,7FFA8A5E1918
       call      qword ptr [r11]
       jmp       short M00_L08
M00_L06:
       mov       rdx,[r13+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M00_L02
M00_L07:
       mov       r11d,r12d
       mov       eax,r11d
M00_L08:
       mov       [rbp-48],eax
       xor       r10d,r10d
       mov       [rbp-4C],r10d
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
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
       mov       [rbp-0C0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0B8]
       test      r8,r8
       je        near ptr M00_L11
       mov       rcx,[rbp-0B0]
       cmp       [rcx+8],r11d
       jbe       near ptr M00_L14
M00_L09:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-80],r11
       cmp       [rcx+r11+10],eax
       jne       short M00_L10
       mov       [rbp-0B0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-40]
       mov       r11,7FFA8A5E1910
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0B0]
       mov       r8,[rbp-0B8]
       mov       r11,[rbp-80]
       jne       near ptr M00_L22
M00_L10:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-4C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-4C],r10d
       mov       eax,[rbp-48]
       ja        short M00_L09
       jmp       short M00_L14
M00_L11:
       mov       rcx,[rbp-0B0]
       cmp       [rcx+8],r11d
       jbe       short M00_L14
M00_L12:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M00_L13
       mov       edx,[rbp-40]
       cmp       [rcx+r11+18],edx
       je        near ptr M00_L22
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-4C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M00_L21
       cmp       [rcx+8],r11d
       mov       [rbp-4C],r10d
       mov       eax,[rbp-48]
       ja        short M00_L12
M00_L14:
       cmp       dword ptr [r13+40],0
       jg        short M00_L16
       mov       r12d,[r13+38]
       cmp       [rcx+8],r12d
       jne       short M00_L15
       mov       ecx,[r13+38]
       call      qword ptr [7FFA8A69F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFA8B14FEE8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r13+8]
       mov       ecx,[rbp-48]
       mov       edx,ecx
       imul      rdx,[r13+30]
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
       mov       [rbp-0C0],r8
       mov       eax,ecx
M00_L15:
       lea       r8d,[r12+1]
       mov       [r13+38],r8d
       mov       rcx,[r13+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M00_L17
M00_L16:
       mov       r8d,[r13+3C]
       mov       r12d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L37
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r13+3C],r8d
       dec       dword ptr [r13+40]
M00_L17:
       cmp       r12d,[rcx+8]
       jae       near ptr M00_L37
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-0C0]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-40]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r13+44]
       mov       r13d,[rbp-3C]
       test      r13d,r13d
       jg        short M00_L18
       mov       [rbp-40],edx
       lea       r8d,[rdx+1]
       mov       [r15+20],r8d
       jmp       short M00_L20
M00_L18:
       mov       r12,[r15+10]
       lea       r9d,[r13-1]
       mov       r8d,[r12+10]
       cmp       r9d,r8d
       jae       near ptr M00_L36
       dec       r8d
       mov       [r12+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L38
M00_L19:
       inc       dword ptr [r12+14]
       mov       [rbp-40],edx
M00_L20:
       inc       dword ptr [r15+24]
       jmp       near ptr M00_L39
M00_L21:
       call      qword ptr [7FFA8A69F480]
       int       3
M00_L22:
       mov       ecx,r12d
       call      qword ptr [7FFA8B237C00]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD65D58]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D58]
       int       3
M00_L25:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-0A0]
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
       call      qword ptr [7FFA8AD6DCF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0A0]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0A0]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA8AECC7B0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-44],eax
       mov       rax,[rbp-0A0]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA8AECC7B0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r12d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0A8]
       mov       edx,[rbp-44]
       mov       r8,[rbp-0A0]
       call      qword ptr [7FFA8AEC5ED8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-0A0]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2C958F32568
       mov       [r13+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFA8AEC7120]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       [rbp-40],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r12+8]
       mov       rcx,[r12+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-40]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0E0]
       mov       edx,[rbp-74]
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
       mov       r15d,[rbp-40]
       mov       ecx,r15d
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsi+8]
       mov       [rbp-0D8],r14
       cmp       [r14],r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0E
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r15,[rcx+70]
       test      r15,r15
       je        near ptr M00_L56
M00_L40:
       mov       [rbp-0E8],r15
       mov       rax,[r15+10]
       mov       ecx,[r14+18]
       not       ecx
       test      rax,rax
       je        short M00_L41
       test      ecx,ecx
       jl        short M00_L41
       mov       edx,[rax+8]
       cmp       edx,ecx
       jle       short M00_L41
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       jne       near ptr M00_L57
M00_L41:
       mov       eax,[r14+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L51
       cmp       dword ptr [7FFAEA5CF778],0
       jne       near ptr M00_L59
M00_L42:
       mov       rax,7FFAEA277470
       call      rax
       test      eax,eax
       jne       near ptr M00_L60
M00_L43:
       mov       r14,[rbp-0D8]
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L61
       xor       r13d,r13d
M00_L44:
       mov       r15,[rbp-0E8]
       mov       r8,[r15+10]
       mov       ecx,[r14+18]
       not       ecx
       test      r8,r8
       je        near ptr M00_L48
       test      ecx,ecx
       jl        near ptr M00_L48
       mov       edx,[r8+8]
       cmp       edx,ecx
       jle       near ptr M00_L48
       cmp       ecx,edx
       jae       near ptr M00_L67
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       je        short M00_L48
       cmp       byte ptr [r14+1C],0
       je        short M00_L48
       lea       rcx,[rcx+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L45:
       test      r13,r13
       je        short M00_L49
M00_L46:
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       mov       rdi,[rbp-90]
       cmp       [rdi],rdx
       jne       near ptr M00_L64
       mov       r14d,[rdi+8]
       mov       ebx,r14d
       xor       esi,esi
       test      ebx,ebx
       je        near ptr M00_L62
M00_L47:
       cmp       esi,ebx
       jae       near ptr M00_L63
       cmp       esi,r14d
       jae       near ptr M00_L67
       mov       edx,esi
       mov       rdx,[rdi+rdx*8+10]
       mov       r15,[rbp-88]
       lea       r8,[r15+18]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFA8B1452F0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       inc       esi
       cmp       esi,ebx
       jae       short M00_L50
       jmp       short M00_L47
M00_L48:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FFA8B1451E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       short M00_L45
M00_L49:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFA8B1452C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       r13,rax
       jmp       near ptr M00_L46
M00_L50:
       mov       rbx,[rbp+10]
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass2_0<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2C958F32CE8
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       rcx,7FFA8B1ED100
       xor       r8d,r8d
       mov       r9,2C958F20008
       call      qword ptr [7FFA8AD6E538]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rsi,rax
       mov       rdx,2C958F32D08
       mov       [rsp+20],rdx
       mov       rdx,[rdi+8]
       mov       rcx,7FFA8B078910
       xor       r8d,r8d
       mov       r9,2C958F20008
       call      qword ptr [7FFA8AD6E538]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA8B144FC0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass2_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
       mov       [r14+18],rcx
       lea       rcx,[rbp-68]
       mov       r9,r14
       mov       r8,rsi
       mov       rdx,7FFA8B1ED2C0
       call      qword ptr [7FFA8B14CE88]; System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rcx,[rdi+10]
       mov       [rbp-70],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rbp-70]
       mov       rdx,7FFA8B216830
       cmp       [rcx],ecx
       call      qword ptr [7FFA8B14EE20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L51:
       mov       r14,[rbp-0D8]
       mov       rcx,r14
       call      qword ptr [7FFA8A9661C0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L58
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M00_L58
M00_L52:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       jne       short M00_L53
       mov       rcx,[rbx+8]
       call      qword ptr [7FFA8A96CBB8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L54
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFA8A96CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L53:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA8B237B88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       xor       esi,esi
       jmp       short M00_L53
M00_L55:
       mov       ecx,0AA4
       mov       rdx,7FFA8AAD1588
       call      qword ptr [7FFA8A69F210]
       mov       rcx,rax
       call      qword ptr [7FFA8AEC6B80]
       int       3
M00_L56:
       mov       ecx,0E
       call      qword ptr [7FFA8AEC7588]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M00_L40
M00_L57:
       cmp       byte ptr [r14+1C],0
       je        near ptr M00_L41
       mov       r13,[rax+20]
       jmp       near ptr M00_L45
M00_L58:
       mov       rcx,rax
       call      qword ptr [7FFA8A9656C8]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       near ptr M00_L52
M00_L59:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L42
M00_L60:
       call      qword ptr [7FFA8B237D50]
       jmp       near ptr M00_L43
M00_L61:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       mov       rcx,r14
       call      qword ptr [7FFA8B23C168]
       test      eax,eax
       je        near ptr M00_L44
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8B23C180]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB37858]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L62:
       mov       r15,[rbp-88]
       jmp       near ptr M00_L50
M00_L63:
       mov       ecx,esi
       call      qword ptr [7FFA8B144450]
       int       3
M00_L64:
       mov       rcx,rdi
       mov       r11,7FFA8A5E18F0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-98],rcx
M00_L65:
       mov       rcx,[rbp-98]
       mov       r11,[rcx]
       mov       r11,7FFA8A5E18F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L66
       mov       rcx,[rbp-98]
       mov       r11,7FFA8A5E1900
       call      qword ptr [r11]
       mov       rdx,rax
       mov       r15,[rbp-88]
       lea       r8,[r15+18]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFA8B1452F0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       jmp       short M00_L65
M00_L66:
       mov       r15,[rbp-88]
       mov       rcx,[rbp-98]
       mov       r11,7FFA8A5E1908
       call      qword ptr [r11]
       jmp       near ptr M00_L50
M00_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L68
       mov       rcx,[rbp-98]
       mov       r11,7FFA8A5E1908
       call      qword ptr [r11]
M00_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0E0],0
       je        short M00_L69
       mov       rcx,[rbp-0E0]
       mov       edx,[rbp-74]
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
M00_L69:
       nop
       add       rsp,38
       ret
; Total bytes of code 3018
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+30]
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
       call      qword ptr [7FFA8B1450B0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rcx,7FFAE9461390
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
       call      qword ptr [7FFA8AFE4AB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8AB35A10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFA8AFE4AC8]
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
       mov       rcx,7FFA8B07DFF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFA8B07DFF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFA8B07DFF4
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
       call      qword ptr [7FFAEA0D5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFAEA0D9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFAEA0D5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFAEA0C7FC0]
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
       call      00007FFAEA265D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       jmp       qword ptr [7FFA8A6966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAEA0D2710]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAEA0D9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFAEA0F09C8]
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
       call      qword ptr [7FFAEA0D9320]
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
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFAEA0DB268]
       int       3
M08_L08:
       call      qword ptr [7FFAEA0D2830]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DDDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DC810]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFAEA0F09B0]
       int       3
M08_L10:
       call      qword ptr [7FFAEA0D25F8]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DCC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFAEA0D25F8]
       mov       r14,rax
       call      qword ptr [7FFAEA0DCC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFAEA0DB218]
       mov       rcx,r14
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFAEA0D96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFAEA0C8028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFAEA0DC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFAEA0D2620]
       mov       rbx,rax
       call      qword ptr [7FFAEA0DD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DB298]
       mov       rcx,rbx
       call      qword ptr [7FFAEA0C7FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFA8B27A078
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rcx,7FFA8B27A09C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFA8B27A094
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFA8B27A0A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFA8AEC5ED8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFA8AD6DCF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFA8B27A07C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFA8B27A080
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFA8B27A084
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFA8B27A088
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFA8B27A08C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFA8B27A090
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFA8B27A098
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
       call      qword ptr [7FFA8B2374F8]
       int       3
M10_L03:
       call      qword ptr [7FFA8B237510]
       jmp       short M10_L00
; Total bytes of code 69
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
       je        near ptr M11_L05
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
       jo        near ptr M11_L09
       mov       [rcx+24],eax
       jmp       near ptr M11_L13
M11_L02:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       mov       r14d,[rcx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rcx+20]
       jge       near ptr M11_L06
M11_L03:
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
       je        near ptr M11_L12
M11_L04:
       mov       ecx,[rdi+28]
       sub       [rdi+24],ecx
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       rcx,rdi
       jmp       short M11_L01
M11_L05:
       xor       edx,edx
       mov       [rcx+2C],edx
       mov       [rbp-50],rcx
       mov       [rbp-48],edx
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFA8A695998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L06:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M11_L07
       jmp       short M11_L08
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFA8B29D388
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M11_L08:
       mov       rcx,rax
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       and       r14d,[rdi+20]
       jne       short M11_L10
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       rcx,[rdi+8]
       mov       rdx,r13
       call      qword ptr [7FFA8A69F588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M11_L11
M11_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L10:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       sub       ecx,r14d
       mov       [rsp+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,r14d
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M11_L11:
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
       jmp       near ptr M11_L03
M11_L12:
       lock inc  qword ptr [rsi]
       jmp       near ptr M11_L04
M11_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       byte ptr [rbp-40],0
       jne       short M11_L15
M11_L14:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L15:
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M11_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
M11_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       byte ptr [rbp-40],0
       je        short M11_L17
       mov       rcx,rdi
       call      qword ptr [7FFA8A696820]; System.Threading.Monitor.Exit(System.Object)
M11_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 648
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
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
       mov       [rbp+20],r8
       mov       rbx,rdx
       mov       edx,[rcx+18]
       mov       esi,edx
       not       esi
       test      esi,esi
       jl        near ptr M12_L14
       cmp       qword ptr [rbp+20],0
       je        near ptr M12_L24
M12_L00:
       mov       rdx,[rbp+20]
       cmp       [rdx+8],esi
       jle       near ptr M12_L18
M12_L01:
       mov       rdx,[rbp+20]
       cmp       esi,[rdx+8]
       jae       near ptr M12_L37
       mov       rdx,[rbp+20]
       mov       eax,esi
       cmp       qword ptr [rdx+rax*8+10],0
       jne       near ptr M12_L35
       mov       rdi,[rbp+20]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M12_L21
M12_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L22
M12_L03:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFA8B145068]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       r13d,eax
       mov       [rbp-50],r15
       mov       [rbp-44],r13d
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M12_L05
       mov       rdx,[rcx+10]
       mov       r12,[rdx+8]
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      r12,r12
       jne       near ptr M12_L11
M12_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       esi,[rdi+8]
       jae       near ptr M12_L10
       mov       ecx,esi
       lea       rcx,[rdi+rcx*8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L12
M12_L05:
       call      qword ptr [7FFA8A9661C0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M12_L09
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M12_L09
M12_L06:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       jne       short M12_L07
       mov       rcx,[rsi+8]
       call      qword ptr [7FFA8A96CBB8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M12_L08
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFA8A96CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M12_L07:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA8B237B88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L08:
       xor       ebx,ebx
       jmp       short M12_L07
M12_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A9656C8]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       short M12_L06
M12_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M12_L11:
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L04
M12_L12:
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
M12_L13:
       nop
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
M12_L14:
       call      qword ptr [7FFA8A9661C0]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M12_L23
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M12_L23
M12_L15:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       jne       short M12_L16
       mov       rcx,[rbx+8]
       call      qword ptr [7FFA8A96CBB8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M12_L17
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFA8A96CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M12_L16:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA8B237B88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M12_L17:
       xor       esi,esi
       jmp       short M12_L16
M12_L18:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L33
M12_L19:
       mov       rcx,rax
       lea       r8d,[rsi+1]
       lea       rdx,[rbp+20]
       call      qword ptr [7FFA8B14CE10]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GrowTable(LinkedSlotVolatile<System.__Canon>[] ByRef, Int32)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        near ptr M12_L34
M12_L20:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,rax
       mov       rcx,[rdi+18]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       near ptr M12_L01
M12_L21:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAC20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L02
M12_L22:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L03
M12_L23:
       mov       rcx,rax
       call      qword ptr [7FFA8A9656C8]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       near ptr M12_L15
M12_L24:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M12_L25
       jmp       short M12_L26
M12_L25:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M12_L26:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       cmp       qword ptr [rax+8],90
       jle       short M12_L27
       mov       r14,[rax+90]
       test      r14,r14
       je        short M12_L27
       jmp       short M12_L28
M12_L27:
       mov       rcx,rdx
       mov       rdx,7FFA8B2E0EA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M12_L28:
       lea       edx,[rsi+1]
       mov       rcx,rdi
       call      qword ptr [7FFA8B145260]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetNewTableSize(Int32)
       movsxd    rdx,eax
       mov       rcx,r14
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp+20],rax
       mov       rdi,[rbp+20]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       cmp       qword ptr [rax+8],98
       jle       short M12_L29
       mov       rax,[rax+98]
       test      rax,rax
       je        short M12_L29
       jmp       short M12_L30
M12_L29:
       mov       rcx,rdx
       mov       rdx,7FFA8B2E0EB8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M12_L30:
       mov       rcx,rax
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M12_L31
       jmp       short M12_L32
M12_L31:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M12_L32:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,rax
       lea       rcx,[rdi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       near ptr M12_L00
M12_L33:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L19
M12_L34:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M12_L20
M12_L35:
       mov       rdx,[rbp+20]
       cmp       esi,[rdx+8]
       jae       short M12_L37
       mov       rdx,[rbp+20]
       mov       eax,esi
       mov       rdx,[rdx+rax*8+10]
       cmp       byte ptr [rcx+1C],0
       jne       short M12_L36
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA8B2375B8]
       int       3
M12_L36:
       lea       rcx,[rdx+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L13
M12_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M12_L38
       mov       rcx,[rbp-50]
       mov       edx,[rbp-44]
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
M12_L38:
       nop
       add       rsp,28
       ret
; Total bytes of code 1266
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
       je        near ptr M13_L10
       mov       rcx,rdx
       call      00007FFAEA1A9E20
       test      eax,eax
       je        near ptr M13_L11
M13_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       jne       near ptr M13_L12
       xor       esi,esi
M13_L01:
       test      rsi,rsi
       jne       near ptr M13_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M13_L06
M13_L02:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M13_L07
       mov       rcx,rax
M13_L03:
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
M13_L04:
       mov       rbx,[rcx+8]
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M13_L08
M13_L05:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,[rax+10]
       mov       ecx,[rbx+18]
       not       ecx
       test      r8,r8
       je        short M13_L09
       test      ecx,ecx
       jl        short M13_L09
       cmp       [r8+8],ecx
       jle       short M13_L09
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       je        short M13_L09
       cmp       byte ptr [rbx+1C],0
       je        short M13_L09
       lea       rcx,[rcx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M13_L13
M13_L06:
       mov       rcx,rdx
       mov       rdx,7FFA8B2E1258
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L02
M13_L07:
       mov       rdx,7FFA8B29D388
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M13_L03
M13_L08:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L05
M13_L09:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA8B1451E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       short M13_L13
M13_L10:
       xor       ecx,ecx
       call      qword ptr [7FFA8AEC6B80]
       int       3
M13_L11:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA8AA57C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M13_L00
M13_L12:
       call      qword ptr [7FFA8B23C1B0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M13_L01
M13_L13:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       jne       short M13_L15
M13_L14:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M13_L15:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M13_L14
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M13_L17
       cmp       qword ptr [rbp-28],0
       jne       short M13_L16
       xor       ecx,ecx
       call      qword ptr [7FFA8AEC6B80]
       int       3
M13_L16:
       mov       rcx,[rbp-28]
       call      00007FFAEA266030
       test      eax,eax
       je        short M13_L17
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M13_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       test      rdx,rdx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M14_L01
M14_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L01:
       test      r8,r8
       je        short M14_L02
       mov       rdx,r8
       jmp       short M14_L00
M14_L02:
       call      qword ptr [7FFA8AD6E5B0]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2C958F20390
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M14_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M14_L04
M14_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M14_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8AECC390]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA8AECC3A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+88]
       test      rax,rax
       je        near ptr M15_L29
M15_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],rcx
       mov       byte ptr [rax+1D],0
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        near ptr M15_L30
M15_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       mov       rsi,[rbx+18]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFA8B145068]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       [rbp-78],rsi
       mov       [rbp-4C],eax
       mov       rsi,[rbx+10]
       mov       ecx,[rsi+10]
       mov       edi,ecx
       test      edi,edi
       jg        short M15_L02
       mov       r14d,[rbx+20]
       jmp       short M15_L03
M15_L02:
       mov       rdx,rsi
       lea       eax,[rdi-1]
       cmp       eax,ecx
       jae       near ptr M15_L25
       mov       rcx,[rdx+8]
       cmp       eax,[rcx+8]
       jae       near ptr M15_L26
       mov       edx,eax
       mov       r14d,[rcx+rdx*4+10]
M15_L03:
       mov       rcx,[rbx+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       inc       edx
       cmp       [rsi],sil
       test      edx,edx
       jl        near ptr M15_L24
       mov       rcx,[rsi+8]
       cmp       [rcx+8],edx
       jge       short M15_L05
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M15_L07
       mov       eax,4
M15_L04:
       mov       ecx,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,ecx
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFA8B1450E0]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].set_Capacity(Int32)
M15_L05:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx+8]
       mov       r15d,r14d
       cmp       qword ptr [rsi+8],0
       jne       short M15_L06
       xor       ecx,ecx
       call      qword ptr [7FFA8A695A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [rsi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+30],rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
M15_L06:
       mov       r13,[rsi+10]
       mov       r12,[rsi+18]
       test      r12,r12
       je        short M15_L08
       mov       rcx,r12
       mov       edx,r15d
       mov       r11,7FFA8A5E1840
       call      qword ptr [r11]
       jmp       short M15_L09
M15_L07:
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       near ptr M15_L04
M15_L08:
       mov       eax,r15d
M15_L09:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[rsi+8]
       mov       ecx,eax
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M15_L26
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-68],r9
       mov       r11d,[r9]
       dec       r11d
       test      r12,r12
       je        short M15_L12
       mov       r8d,[r13+8]
       mov       [rbp-5C],r8d
       cmp       r8d,r11d
       jbe       short M15_L13
M15_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-58],r11
       cmp       [r13+r11+10],eax
       jne       short M15_L11
       mov       edx,[r13+r11+18]
       mov       rcx,r12
       mov       r8d,r14d
       mov       r11,7FFA8A5E1838
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-58]
       jne       near ptr M15_L23
M15_L11:
       mov       r11d,[r13+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       r8d,[rbp-5C]
       cmp       r8d,r10d
       jb        near ptr M15_L22
       cmp       r8d,r11d
       mov       [rbp-5C],r8d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M15_L10
       jmp       short M15_L13
M15_L12:
       mov       r8d,[r13+8]
       cmp       r8d,r11d
       ja        short M15_L14
       mov       [rbp-5C],r8d
M15_L13:
       cmp       dword ptr [rsi+40],0
       jle       short M15_L16
       mov       ecx,[rsi+3C]
       mov       r15d,ecx
       cmp       ecx,[rbp-5C]
       jae       near ptr M15_L26
       mov       r8d,ecx
       shl       r8,4
       mov       r8d,[r13+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [rsi+3C],r8d
       dec       dword ptr [rsi+40]
       jmp       near ptr M15_L18
M15_L14:
       mov       r11d,r11d
       shl       r11,4
       cmp       [r13+r11+10],eax
       jne       short M15_L15
       cmp       [r13+r11+18],r14d
       je        near ptr M15_L23
M15_L15:
       mov       r11d,[r13+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       r8d,r10d
       jb        near ptr M15_L22
       cmp       r8d,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M15_L14
       mov       [rbp-5C],r8d
       jmp       short M15_L13
M15_L16:
       mov       r15d,[rsi+38]
       cmp       [rbp-5C],r15d
       jne       short M15_L17
       mov       ecx,[rsi+38]
       call      qword ptr [7FFA8A69F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA8B14FEE8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[rsi+8]
       mov       r12d,[rbp-44]
       mov       ecx,r12d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[r8+8]
       mov       r9d,edx
       imul      rcx,r9
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M15_L26
       mov       ecx,ecx
       lea       r9,[r8+rcx*4+10]
       mov       r13,r9
       mov       [rbp-68],r13
       mov       eax,r12d
M15_L17:
       lea       r8d,[r15+1]
       mov       [rsi+38],r8d
       mov       r13,[rsi+10]
M15_L18:
       cmp       r15d,[r13+8]
       jae       near ptr M15_L26
       mov       r8d,r15d
       shl       r8,4
       lea       r8,[r13+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-68]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       [r8+8],r14d
       mov       byte ptr [r8+0C],0
       inc       r15d
       mov       [r9],r15d
       inc       dword ptr [rsi+44]
       test      edi,edi
       jg        short M15_L19
       lea       r8d,[r14+1]
       mov       [rbx+20],r8d
       jmp       short M15_L21
M15_L19:
       mov       rsi,[rbx+10]
       lea       r9d,[rdi-1]
       mov       r8d,[rsi+10]
       cmp       r9d,r8d
       jae       short M15_L25
       dec       r8d
       mov       [rsi+10],r8d
       cmp       r9d,r8d
       jl        short M15_L27
M15_L20:
       inc       dword ptr [rsi+14]
M15_L21:
       inc       dword ptr [rbx+24]
       jmp       short M15_L28
M15_L22:
       call      qword ptr [7FFA8A69F480]
       int       3
M15_L23:
       mov       ecx,r15d
       call      qword ptr [7FFA8B237C00]
       int       3
M15_L24:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA8AD65D58]
       int       3
M15_L25:
       call      qword ptr [7FFA8AEC7120]
       int       3
M15_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L27:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rsi+8]
       mov       rcx,[rsi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFA8ACECCC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M15_L20
M15_L28:
       mov       rcx,[rbp-78]
       mov       edx,[rbp-4C]
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
       mov       eax,r14d
       not       eax
       mov       rcx,[rbp+10]
       mov       [rcx+18],eax
       mov       byte ptr [rcx+1C],1
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
M15_L29:
       mov       rcx,rdx
       mov       rdx,7FFA8B2BAC20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M15_L00
M15_L30:
       mov       rdx,7FFA8B2BAA78
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M15_L01
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M15_L31
       mov       rcx,[rbp-78]
       mov       edx,[rbp-4C]
       call      qword ptr [7FFA8B145188]; System.Threading.Lock.Exit(ThreadId)
M15_L31:
       nop
       add       rsp,28
       ret
; Total bytes of code 1203
```
```assembly
; DotNetTips.Spargine.Extensions.ConcurrentBagExtensions+<>c__DisplayClass2_0`1[[System.__Canon, System.Private.CoreLib]].<RemoveRange>b__0(System.__Canon)
; 				if (!items.Contains(item))
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					tempBag.Add(item);
; 					^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+10]
       test      rdi,rdi
       je        short M16_L04
M16_L00:
       mov       rbp,[rbx+8]
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M16_L05
M16_L01:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M16_L07
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],38
       jle       short M16_L06
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M16_L06
M16_L02:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
M16_L03:
       test      eax,eax
       je        near ptr M16_L14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       mov       rdx,7FFA8B204918
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M16_L00
M16_L05:
       mov       rcx,rdi
       mov       rdx,7FFA8B29E520
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M16_L01
M16_L06:
       mov       rcx,rdi
       mov       rdx,7FFA8B29E8A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M16_L02
M16_L07:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M16_L08
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M16_L08
       jmp       short M16_L09
M16_L08:
       mov       rcx,rdi
       mov       rdx,7FFA8B29E778
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M16_L09:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M16_L10
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       near ptr M16_L03
M16_L10:
       test      rbp,rbp
       jne       short M16_L11
       mov       ecx,11
       call      qword ptr [7FFA8A69F930]
       int       3
M16_L11:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M16_L12
       jmp       short M16_L13
M16_L12:
       mov       rcx,rdi
       mov       rdx,7FFA8B29E6D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M16_L13:
       mov       rdx,rbp
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA8B236CB8]
       jmp       near ptr M16_L03
M16_L14:
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFA8AB3FB70]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; Total bytes of code 362
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
       je        near ptr M17_L32
       test      rsi,rsi
       je        near ptr M17_L33
       mov       rcx,[rdx+18]
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M17_L08
M17_L00:
       mov       rcx,288DA000BE8
       mov       r15,[rcx]
       mov       rcx,[r15+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M17_L01
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M17_L34
M17_L01:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],38
       jle       near ptr M17_L09
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M17_L09
M17_L02:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M17_L10
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],60
       jle       near ptr M17_L28
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        near ptr M17_L28
M17_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M17_L29
M17_L04:
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
       jne       near ptr M17_L30
       xor       esi,esi
M17_L05:
       test      edx,edx
       jne       near ptr M17_L31
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jl        near ptr M17_L35
       mov       r14d,ecx
       dec       r14d
M17_L06:
       inc       r14d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFA8B238870
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
       mov       rdx,7FFA8B2DD1D8
       call      qword ptr [7FFA8B23C7C8]
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
M17_L07:
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
M17_L08:
       mov       rcx,rdx
       mov       rdx,7FFA8B2E1E40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M17_L00
M17_L09:
       mov       rcx,r14
       mov       rdx,7FFA8B2E2008
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L02
M17_L10:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],40
       jle       near ptr M17_L15
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M17_L15
M17_L11:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M17_L16
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],58
       jle       near ptr M17_L25
       mov       rbx,[rcx+58]
       test      rbx,rbx
       je        near ptr M17_L25
M17_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M17_L26
M17_L13:
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
       je        near ptr M17_L27
M17_L14:
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
       mov       rcx,7FFA8B2388E8
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
       mov       rdx,7FFA8B2DD1D8
       xor       r8d,r8d
       call      qword ptr [7FFA8B23C7C8]
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-40],rcx
       jmp       near ptr M17_L07
M17_L15:
       mov       rcx,r14
       mov       rdx,7FFA8B2E2028
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L11
M17_L16:
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],48
       jle       near ptr M17_L21
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M17_L21
M17_L17:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M17_L22
M17_L18:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M17_L23
M17_L19:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       word ptr [r13+8],1
       mov       byte ptr [r13+0A],1
       lea       rcx,[r13+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r13+0B],0
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+10],50
       jle       near ptr M17_L24
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M17_L24
M17_L20:
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
       call      qword ptr [7FFA8B14D098]; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       jmp       near ptr M17_L07
M17_L21:
       mov       rcx,r14
       mov       rdx,7FFA8B2E21D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L17
M17_L22:
       mov       rdx,7FFA8B2E23D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M17_L18
M17_L23:
       mov       rcx,rdx
       mov       rdx,7FFA8B2E27E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L19
M17_L24:
       mov       rcx,r14
       mov       rdx,7FFA8B2E2208
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M17_L20
M17_L25:
       mov       rcx,r14
       mov       rdx,7FFA8B2E2348
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M17_L12
M17_L26:
       mov       rcx,rbx
       mov       rdx,7FFA8B2E9968
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L13
M17_L27:
       mov       rcx,rbx
       mov       rdx,7FFA8B2E9980
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M17_L14
M17_L28:
       mov       rcx,r14
       mov       rdx,7FFA8B2E2380
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M17_L03
M17_L29:
       mov       rdx,7FFA8B2E8E98
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M17_L04
M17_L30:
       movsxd    r8,r8d
       mov       esi,[rax+r8*4+10]
       jmp       near ptr M17_L05
M17_L31:
       add       rcx,10
       mov       eax,[rcx]
       movsxd    rdx,edx
       mov       ecx,[rcx+rdx*4]
       lea       r14d,[rax+rcx-1]
       jmp       near ptr M17_L06
M17_L32:
       mov       ecx,3C3
       mov       rdx,7FFA8B1EBCE8
       call      qword ptr [7FFA8A69F210]
       mov       rcx,rax
       call      qword ptr [7FFA8AEC6B80]
       int       3
M17_L33:
       mov       ecx,38B
       mov       rdx,7FFA8B1EBCE8
       call      qword ptr [7FFA8A69F210]
       mov       rcx,rax
       call      qword ptr [7FFA8AEC6B80]
       int       3
M17_L34:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFA8B237CC0]
       int       3
M17_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1393
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
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M19_L01
M19_L00:
       add       rsp,20
       pop       rbx
       ret
M19_L01:
       call      qword ptr [7FFA8A695C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M19_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       cmp       [rcx],ecx
       call      qword ptr [7FFAEA0DAF10]; Precode of System.Type.GetRootElementType()
       mov       rbx,rax
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdi,[rbx]
       cmp       rsi,rdi
       jne       short M20_L04
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DA7C0]; Precode of System.RuntimeType.get_IsGenericTypeDefinition()
M20_L00:
       test      eax,eax
       jne       short M20_L02
       cmp       rsi,rdi
       jne       short M20_L05
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DA800]; Precode of System.RuntimeType.get_ContainsGenericParameters()
M20_L01:
       test      eax,eax
       jne       short M20_L07
M20_L02:
       cmp       rsi,rdi
       jne       short M20_L06
       mov       rcx,rbx
       call      qword ptr [7FFAEA0DA818]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1B
       je        short M20_L07
M20_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L04:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M20_L00
M20_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M20_L01
M20_L06:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       je        short M20_L03
M20_L07:
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
       call      qword ptr [7FFA8A96CBE8]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFAEA0E0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M22_L01
       cmp       [rax],ecx
       jle       short M22_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M22_L03
M22_L00:
       add       rsp,20
       pop       rbx
       ret
M22_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M22_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M22_L00
M22_L02:
       cmp       [rax+4],edx
       jle       short M22_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M22_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M22_L03
       jmp       short M22_L00
M22_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
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
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M23_L08
M23_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M23_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M23_L15
M23_L01:
       test      rdi,rdi
       jne       near ptr M23_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0B8],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFAEA271870
       mov       r14,rax
       test      r14,r14
       je        near ptr M23_L16
M23_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M23_L05
       mov       [rbp+10],rbx
       mov       [rbp-0C0],r14
       mov       [rbp-58],r14
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[rbp-58]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-58]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0B0]
       lea       rdx,[rbp-50]
       mov       rax,7FFA8A99C5A0
       mov       [rbp-80],rax
       lea       rax,[M23_L03]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAEA202C30
       call      rax
M23_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAEA5CF778],0
       je        short M23_L04
       call      qword ptr [7FFAEA5BD608]; CORINFO_HELP_STOP_FOR_GC
M23_L04:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-0C0]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M23_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0B8]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFAEA2804E0
       mov       rdx,rax
       test      rdx,rdx
       je        short M23_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       near ptr M23_L17
M23_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M23_L07:
       mov       rax,rdi
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
M23_L08:
       mov       [rbp+10],rbx
       mov       [rbp-40],rbx
       mov       rcx,[rbp-40]
       test      rcx,rcx
       je        near ptr M23_L12
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M23_L13
       mov       rcx,[rcx+18]
M23_L09:
       lea       rdx,[rbp-48]
       mov       [rbp-0A0],rdx
       mov       [rbp-98],rcx
       lea       rcx,[rbp-0A0]
       mov       edx,1
       mov       rax,7FFA8A7049E8
       mov       [rbp-80],rax
       lea       rax,[M23_L10]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAEA277490
       call      rax
M23_L10:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAEA5CF778],0
       je        short M23_L11
       call      qword ptr [7FFAEA5BD608]; CORINFO_HELP_STOP_FOR_GC
M23_L11:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       mov       rdx,rax
       mov       rbx,[rbp+10]
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M23_L00
       jmp       short M23_L14
M23_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA8AFE5068]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA8AECC3A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M23_L13:
       xor       ecx,ecx
       jmp       near ptr M23_L09
M23_L14:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA8AFEE6B8]
       jmp       near ptr M23_L00
M23_L15:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M23_L16:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA8A965710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M23_L02
M23_L17:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 772
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A686850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A68F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,21FB1801EE8
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AA4C918]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8AA4C918]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8AFEEEC8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8AFEED90]
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
       call      qword ptr [7FFA8AFEF720]
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
       test      byte ptr [7FFA8AFF3DE0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,21FB1801FF0
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFA8A5D0D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5D0D38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8AFEEE20]
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
       mov       rbx,[rcx+18]
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
       call      qword ptr [7FFA8AD56A18]
       mov       ecx,0C5
       mov       rdx,7FFA8ABB5118
       call      qword ptr [7FFA8A68F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA85770
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABB5118
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AE9C7B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AE9C7C8]
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
       mov       r11,7FFA8A5D0D48
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,21FB1801EE8
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
       mov       r11,7FFA8A5D0D50
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
       call      qword ptr [7FFA8A685728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,21FB1801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      qword ptr [7FFA8A685728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5D0D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5D0D40
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
       mov       r11,7FFA8A5D0D40
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8AFEED90]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8AA4CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1668
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
       jmp       qword ptr [7FFA8AB2EF88]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AFEEE08]
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
       jmp       qword ptr [7FFA8A956EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFA8AD55D58]
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
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      qword ptr [7FFA8A685728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFA8B004298
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
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
       call      qword ptr [7FFA8A68F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA8B0042A8
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,260468D0008
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
       call      qword ptr [7FFA8AFEFD80]
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
       jmp       qword ptr [7FFA8A685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 119
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A66F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,1EFCCC01F00
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8B055FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8B055FB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8B055F98]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8B054888]
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
       call      qword ptr [7FFA8B05EEB0]
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
       test      byte ptr [7FFA8B00AFD0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,1EFE2C00C00
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
       call      qword ptr [7FFA8A6671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFA8A5B10F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5B1100
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B05C360]
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
       mov       rbx,[rcx+18]
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
       call      qword ptr [7FFA8AD3E5C8]
       mov       ecx,0C5
       mov       rdx,7FFA8AB94180
       call      qword ptr [7FFA8A66F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA65618
       call      qword ptr [7FFA8A66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A66D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8AB94180
       call      qword ptr [7FFA8A66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A66D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AF94318]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AF94330]
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
       mov       r11,7FFA8A5B1110
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,1EFCCC01F00
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
       mov       r11,7FFA8A5B1118
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
       mov       rcx,1EFE2C00C08
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5B10F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5B1108
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
       mov       r11,7FFA8A5B1108
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8B055380]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8B054888]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8B055380]
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
       jmp       qword ptr [7FFA8AB0EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AF9F798]
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
       jmp       qword ptr [7FFA8A936EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       near ptr M05_L04
       mov       r15d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M05_L06
       cmp       [r14+8],r15d
       je        near ptr M05_L03
       test      r15d,r15d
       jle       near ptr M05_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M05_L05
       mov       rcx,rax
M05_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M05_L02
       test      r14,r14
       je        near ptr M05_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M05_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L11
       cmp       edi,[r14+8]
       ja        near ptr M05_L11
       cmp       edi,[r15+8]
       ja        near ptr M05_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L09
       cmp       r8,4000
       ja        near ptr M05_L08
       mov       rcx,rax
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M05_L07
M05_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
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
M05_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,7FFA8B014E50
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L01
M05_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD35D28]
       int       3
M05_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L02
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA8AD3E4A8]
       jmp       short M05_L02
M05_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L02
M05_L10:
       xor       r13d,r13d
       jmp       short M05_L12
M05_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA8B0568B0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA8B0568B0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA8AF9FF48]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M05_L14
       jmp       short M05_L15
M05_L14:
       mov       rdx,7FFA8B06F998
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23061E30008
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
       call      qword ptr [7FFA8B057288]
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
       jmp       qword ptr [7FFA8A665C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A676850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A67F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,11D44801EE8
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AFCEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8AFCEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8AFCEFB8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8AFCED78]
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
       call      qword ptr [7FFA8AFCF810]
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
       test      byte ptr [7FFA8AFDDCE0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,11D44801FF0
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
       call      qword ptr [7FFA8A6771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6771C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFA8A5C0D30
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5C0D38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8AFCEF28]
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
       mov       rbx,[rcx+18]
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
       call      qword ptr [7FFA8AD469E8]
       mov       ecx,0C5
       mov       rdx,7FFA8ABA4180
       call      qword ptr [7FFA8A67F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA75618
       call      qword ptr [7FFA8A67F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A67D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABA4180
       call      qword ptr [7FFA8A67F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A67D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AE8C7C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AE8C7E0]
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
       mov       r11,7FFA8A5C0D48
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,11D44801EE8
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
       mov       r11,7FFA8A5C0D50
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
       mov       rcx,11D44801FF8
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5C0D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5C0D40
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
       mov       r11,7FFA8A5C0D40
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8AFCED90]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8AFCED78]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8AFCED90]
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
       jmp       qword ptr [7FFA8AB1EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AFCEE50]
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
       jmp       qword ptr [7FFA8A946EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFA8AD45D28]
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
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M05_L04
M05_L03:
       mov       rcx,rdx
       call      qword ptr [7FFA8A675728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L04:
       mov       rdx,7FFA8AFE4700
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L03
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
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
       call      qword ptr [7FFA8A67F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA8AFE4710
       call      qword ptr [7FFA8A67F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A675818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A675818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,15DD9630008
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
       call      qword ptr [7FFA8AFCFD98]
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
       jmp       qword ptr [7FFA8A675C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
       test      rbx,rbx
       je        near ptr M00_L39
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A696850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFA8A69F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L41
       mov       rcx,1DF16C01F00
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8A96F888]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8A96F888]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8B085F50]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8B0848D0]
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
       call      qword ptr [7FFA8B08EEC8]
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
       test      byte ptr [7FFA8B0382D0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,1DF2CC00C00
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
       call      qword ptr [7FFA8A6971C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6971C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFA8A5E10F8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5E1100
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B08C378]
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
       mov       rbx,[rcx+18]
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
       call      qword ptr [7FFA8AD6E610]
       mov       ecx,0C5
       mov       rdx,7FFA8ABC5118
       call      qword ptr [7FFA8A69F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA95B10
       call      qword ptr [7FFA8A69F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABC5118
       call      qword ptr [7FFA8A69F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AFC4348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AFC4360]
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
       mov       r11,7FFA8A5E1110
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L42
       mov       rcx,1DF16C01F00
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
       mov       r11,7FFA8A5E1118
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
       mov       rcx,1DF2CC00C08
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5E10F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5E1108
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
       mov       r11,7FFA8A5E1108
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8B0848D0]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8AA5CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       jmp       qword ptr [7FFA8AB3EF88]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AFCF798]
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
       jmp       qword ptr [7FFA8A966EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       near ptr M05_L04
       mov       r15d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M05_L06
       cmp       [r14+8],r15d
       je        near ptr M05_L03
       test      r15d,r15d
       jle       near ptr M05_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M05_L05
       mov       rcx,rax
M05_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M05_L02
       test      r14,r14
       je        near ptr M05_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M05_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M05_L11
       cmp       edi,[r14+8]
       ja        near ptr M05_L11
       cmp       edi,[r15+8]
       ja        near ptr M05_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M05_L09
       cmp       r8,4000
       ja        near ptr M05_L08
       mov       rcx,rax
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       jne       short M05_L07
M05_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
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
M05_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,7FFA8B044E38
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L01
M05_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D58]
       int       3
M05_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L02
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA8AD6E028]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L02
M05_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L02
M05_L10:
       xor       r13d,r13d
       jmp       short M05_L12
M05_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA8B0867D8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M05_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA8B0867D8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA8AFCFF90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M05_L14
       jmp       short M05_L15
M05_L14:
       mov       rdx,7FFA8B09F930
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21FABC90008
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
       call      qword ptr [7FFA8B0872A0]
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
       jmp       qword ptr [7FFA8A695C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 119
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
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
       call      qword ptr [7FFA8A69F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,229AD401F00
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8B095EA8]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8B095EA8]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8B095E90]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8B0947F8]
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
       call      qword ptr [7FFA8B09EE20]
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
       test      byte ptr [7FFA8B023DE0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,229AD402BF8
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
       call      qword ptr [7FFA8A6971C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6971C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFA8A5E10F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5E10F8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B09C360]
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
       mov       rbx,[rcx+18]
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
       mov       r11,7FFA8A5E1108
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,229AD401F00
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
       mov       r11,7FFA8A5E1110
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
       call      qword ptr [7FFA8AD6E088]
       mov       ecx,0C5
       mov       rdx,7FFA8ABC4180
       call      qword ptr [7FFA8A69F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA95618
       call      qword ptr [7FFA8A69F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABC4180
       call      qword ptr [7FFA8A69F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A69D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AEBFD38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AEBFD50]
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
       mov       rcx,229AD402C00
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5E10E8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5E1100
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
       mov       r11,7FFA8A5E1100
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8B0952F0]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8B0947F8]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8B0952F0]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1662
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
       jmp       qword ptr [7FFA8AB3EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AFAF738]
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
       jmp       qword ptr [7FFA8A966EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       jne       near ptr M04_L02
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L07
       cmp       [r14+8],r15d
       je        near ptr M04_L06
       test      r15d,r15d
       jle       near ptr M04_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M04_L03
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       near ptr M04_L05
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
       ja        short M04_L04
       mov       rcx,rax
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
       je        short M04_L05
       jmp       short M04_L08
M04_L02:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L03:
       mov       rdx,7FFA8B03B410
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,rax
       call      qword ptr [7FFA8AEBC558]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M04_L05:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L06:
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
M04_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD65D40]
       int       3
M04_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L05
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L05
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA8B0967C0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA8B0967C0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA8AFAFFC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L05
M04_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M04_L14
       jmp       short M04_L15
M04_L14:
       mov       rdx,7FFA8B0D4E00
       call      qword ptr [7FFA8A69F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L06
; Total bytes of code 522
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A695818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26A42520008
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
       call      qword ptr [7FFA8B097288]
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
       jmp       qword ptr [7FFA8A695C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
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
       call      qword ptr [7FFA8A68F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L38
       mov       rcx,28016C01F00
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8B075FB0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8B075FB0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8B075F98]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8B074888]
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
       call      qword ptr [7FFA8B07EE98]
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
       test      byte ptr [7FFA8B02AFD0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,2802CC00C00
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFA8A5D10F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5D10F8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B07C3F0]
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
       mov       rbx,[rcx+18]
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
       mov       r11,7FFA8A5D1108
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,28016C01F00
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
       mov       r11,7FFA8A5D1110
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
       call      qword ptr [7FFA8AD5E5C8]
       mov       ecx,0C5
       mov       rdx,7FFA8ABB4180
       call      qword ptr [7FFA8A68F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA85618
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABB4180
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AFB4300]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AFB4318]
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
       mov       rcx,2802CC00C08
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5D10E8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5D1100
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
       mov       r11,7FFA8A5D1100
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8B075380]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8B074888]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8B075380]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1662
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
       jmp       qword ptr [7FFA8AB2EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       call      qword ptr [7FFA8AFBF750]
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
       jmp       qword ptr [7FFA8A956EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rdx,7FFA8B0353B8
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD55D28]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FFA8AD5DFF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA8B076850]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA8B076850]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA8AFBFF48]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFA8B08FA48
       call      qword ptr [7FFA8A68F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C0ABC50008
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
       call      qword ptr [7FFA8B077318]
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
       jmp       qword ptr [7FFA8A685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
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
       mov       rcx,1B58C001F00
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8B056160]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8B056160]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8B056730]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8B054A38]
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
       call      qword ptr [7FFA8B2045E8]
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
       test      byte ptr [7FFA8B031CD0],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,1B5A2000C38
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
       call      qword ptr [7FFA8A6671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6671C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFA8A5B13B8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5B13C0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B05CB28]
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
       mov       rbx,[rcx+18]
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
       mov       r11,7FFA8A5B13D0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,1B58C001F00
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
       mov       r11,7FFA8A5B13D8
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
       call      qword ptr [7FFA8AD3E688]
       mov       ecx,0C5
       mov       rdx,7FFA8AB94180
       call      qword ptr [7FFA8A66F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA65618
       call      qword ptr [7FFA8A66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A66D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8AB94180
       call      qword ptr [7FFA8A66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A66D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AF86010]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AF86028]
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
       mov       rcx,1B5A2000C40
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5B13B0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5B13C8
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
       mov       r11,7FFA8A5B13C8
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8B055530]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8B054A38]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8B055530]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1661
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
       jmp       qword ptr [7FFA8AB0EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FFAEA2B7B10
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
       call      qword ptr [7FFA8AD3DDE8]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFA8A936EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
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
       mov       rax,[rdx+98]
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
       call      00007FFAEA265D60
       cmp       dword ptr [7FFAEA5CF778],0
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
       mov       rdx,7FFA8AEB4130
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD35D28]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FFA8AD3E568]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA8B057000]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA8B057000]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFA8AE9E238]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFA8B069A00
       call      qword ptr [7FFA8A66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F621040008
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
       call      qword ptr [7FFA8B057AB0]
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
       jmp       qword ptr [7FFA8A665C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+270]
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
       mov       rcx,1C9C8401F38
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
       call      00007FFAEA1A9E20
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
       call      00007FFAEA1A9E20
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
       call      qword ptr [7FFA8AEBC360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFA8AEBC360]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFA8AFD4CC0]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFA8AEB6B38]
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
       call      qword ptr [7FFA8B255068]
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
       test      byte ptr [7FFA8B1A1790],1
       je        near ptr M00_L45
M00_L23:
       mov       rcx,1C9DE400C60
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA8A6871C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFA8A5D1758
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFA8A5D1760
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFA8B12CF90]
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
       mov       rbx,[rcx+18]
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
       mov       r11,7FFA8A5D1770
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L39
       mov       rcx,1C9C8401F38
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
       mov       r11,7FFA8A5D1778
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
       call      qword ptr [7FFA8AD5E5C8]
       mov       ecx,0C5
       mov       rdx,7FFA8ABB4180
       call      qword ptr [7FFA8A68F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFA8AA85618
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA8ABB4180
       call      qword ptr [7FFA8A68F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA8A68D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA8AEB65C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8AEB65E0]
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
       mov       rcx,1C9DE400C68
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L45:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rbx
       mov       r11,7FFA8A5D1750
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,r14
       mov       r11,7FFA8A5D1768
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
       mov       r11,7FFA8A5D1768
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
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA8AEB7678]
M00_L51:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L50
M00_L52:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FFA8AEB6B38]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FFAEA266030
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFA8AEB7678]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1661
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
       jmp       qword ptr [7FFA8AB2EF58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
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
       jmp       near ptr 00007FFAEA2B7B10
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FFA8AEB55C0]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFA8A956EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFAEA0C8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAEA0C8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       near ptr M05_L04
       mov       r15d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M05_L06
       cmp       [r14+8],r15d
       je        short M05_L03
       test      r15d,r15d
       jle       near ptr M05_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M05_L05
       mov       rcx,rax
M05_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M05_L07
M05_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
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
M05_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,7FFA8AE972F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L01
M05_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA8AD55D28]
       int       3
M05_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFA8A68F588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M05_L02
M05_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M05_L09
       jmp       short M05_L10
M05_L09:
       mov       rdx,7FFA8AEEEF38
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
; Total bytes of code 316
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
       call      00007FFAEA2B8D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA8A685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20A5D270008
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
       call      qword ptr [7FFA8AFDF3D8]
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
       jmp       qword ptr [7FFA8A685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

