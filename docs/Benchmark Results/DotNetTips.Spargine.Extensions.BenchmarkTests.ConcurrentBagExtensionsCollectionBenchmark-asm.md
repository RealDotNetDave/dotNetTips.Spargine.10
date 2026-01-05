## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1E69A400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD0D4E58]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FFCFCE95E30]
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC711110
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
       mov       r11,7FFCFC711108
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
       call      qword ptr [7FFCFC7CF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD0DD080]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFD1B41F8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       call      qword ptr [7FFCFC7CF480]
       int       3
M00_L25:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1BE958]
       int       3
M00_L26:
       call      qword ptr [7FFCFD0D46C0]
       int       3
M00_L27:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCE95E30]
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
       call      qword ptr [7FFCFCE9E118]
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r10
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFCFD1BEA90]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L38:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1BEA90]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FFCFD1B41F8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L39:
       mov       rcx,227195A2960
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
       call      qword ptr [7FFCFC7C57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0D4F78]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD156208],1
       je        near ptr M00_L65
M00_L47:
       mov       rcx,1E69A400C20
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
       call      qword ptr [7FFCFD0D50B0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L50:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0D50E0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L51:
       mov       rcx,r15
       call      qword ptr [7FFCFCBBF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD0D4F90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L50
       jmp       short M00_L49
M00_L52:
       mov       rcx,rsi
       call      qword ptr [7FFCFD0D50B0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0D50E0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L58
       mov       rcx,r15
       call      qword ptr [7FFCFCBBF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD0D4F90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
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
       mov       r11,7FFCFC711120
       call      qword ptr [r11]
       jmp       short M00_L55
M00_L59:
       mov       rcx,r15
       mov       r11,7FFCFC711128
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L56
M00_L60:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD1BC4E0]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD156408
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0DCDB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC711118
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L48
M00_L67:
       mov       rcx,r15
       mov       r11,7FFCFC711130
       call      qword ptr [r11]
       jmp       near ptr M00_L63
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L68
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0D4F78]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC711130
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
       call      qword ptr [7FFCFD0D4EA0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD1F27D0
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
       mov       rcx,7FFCFD1F27D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1B5E18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC75AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1B5E30]
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
       mov       rcx,7FFCFD1F27DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD1F27E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD1F27D8
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
       mov       rcx,7FFCFD1F27E4
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
       mov       rcx,7FFCFD2127C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7C5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD2127C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD2127C4
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M05_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M05_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M05_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L05
M05_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       jmp       qword ptr [7FFCFC7C66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,4000
       jbe       short M08_L00
       mov       rcx,7FFCFCECF90C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFCFCE9E118]
M08_L00:
       mov       rcx,7FFCFCECF908
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M08_L02
M08_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L01
; Total bytes of code 115
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
       call      qword ptr [7FFCFD1BE928]
       int       3
M09_L03:
       call      qword ptr [7FFCFD1BE940]; System.Threading.Lock.SignalWaiterIfNecessary(State)
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD0D4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD28E318
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFCFD28C7C8
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD28C648
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD1B4A38]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFD1B60E8]
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFCFD1BEA30]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFD1B5530]
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD1B4A38]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFD1B5530]
M10_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 540
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFC7CF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFC7C5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7C6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L10:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD1B60E8]
       jmp       near ptr M11_L03
M11_L11:
       mov       rcx,rdx
       mov       rdx,7FFCFD28C7C8
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFCE1CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE1CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L15
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFCFD1B5530]
       jmp       short M11_L15
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L17
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7C6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FFCFD1B5530]
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
       mov       rdx,7FFCFD28C648
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCFD0D4FA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,136D2400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD0E4E58]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FFCFCEA5E60]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L28
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
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
       jl        near ptr M00_L29
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        short M00_L05
       test      edx,edx
       jle       near ptr M00_L40
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
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC721110
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
       je        near ptr M00_L36
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L34
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L32
       cmp       r13d,[rax+8]
       ja        near ptr M00_L31
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L35
       mov       rax,[rbp-78]
       cmp       r8,4000
       jbe       short M00_L09
       mov       rcx,r10
       call      qword ptr [7FFCFD0EF888]
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,r10
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L30
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
       jae       near ptr M00_L37
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
       mov       r11,7FFCFC721108
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L27
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L26
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
       jae       near ptr M00_L37
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
       je        near ptr M00_L27
M00_L17:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L26
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
       call      qword ptr [7FFCFC7DF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD0ED080]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       jae       near ptr M00_L37
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
       jae       near ptr M00_L37
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
       jg        short M00_L22
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L21:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L47
M00_L22:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L28
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L24
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L25
       mov       [rbp-3C],r8d
M00_L23:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FFCFD1C4108]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L24:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L21
M00_L25:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L45
       jmp       near ptr M00_L41
M00_L26:
       call      qword ptr [7FFCFC7DF480]
       int       3
M00_L27:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1CE940]
       int       3
M00_L28:
       call      qword ptr [7FFCFD0E4690]
       int       3
M00_L29:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA5E60]
       int       3
M00_L30:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L31:
       jmp       short M00_L38
M00_L32:
       jmp       short M00_L38
M00_L33:
       jmp       short M00_L38
M00_L34:
       jmp       short M00_L38
M00_L35:
       mov       rcx,r10
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L36:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L39
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1CEA60]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L39:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1CEA60]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FFCFD1C4108]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L40:
       mov       rcx,177513D2960
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L41:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L44
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L43
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L42
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
       je        short M00_L46
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FFCFC7D57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L24
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L45:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L46:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0E4F78]; System.Threading.Lock.Exit(ThreadId)
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
       je        near ptr M00_L64
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       test      byte ptr [7FFCFD162158],1
       je        near ptr M00_L66
M00_L48:
       mov       rcx,136D2400C20
       mov       r15,[rcx]
M00_L49:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L58
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L58
       jmp       short M00_L52
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E50B0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L51:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0E50E0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L52:
       mov       rcx,r15
       call      qword ptr [7FFCFCBB69F0]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L63
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L61
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L62
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0E4F90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L51
       jmp       short M00_L50
M00_L53:
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E50B0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0E50E0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L59
       mov       rcx,r15
       call      qword ptr [7FFCFCBB69F0]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L56:
       test      eax,eax
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L60
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L61
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L62
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L57:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0E4F90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L54
       jmp       short M00_L53
M00_L58:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L55
M00_L59:
       mov       rcx,r15
       mov       r11,7FFCFC721120
       call      qword ptr [r11]
       jmp       short M00_L56
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC721128
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L57
M00_L61:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD1CC498]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L68
M00_L64:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD162358
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0ECCD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       jmp       near ptr M00_L49
M00_L66:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L48
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFCFC721118
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L49
M00_L68:
       mov       rcx,r15
       mov       r11,7FFCFC721130
       call      qword ptr [r11]
       jmp       near ptr M00_L64
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L69
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0E4F78]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC721130
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,38
       ret
; Total bytes of code 2514
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
       call      qword ptr [7FFCFD0E4EA0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD201C70
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
       mov       rcx,7FFCFD201C74
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1C5DE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC85AE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1C5E00]
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
       mov       rcx,7FFCFD201C7C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD201C80
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD201C78
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
       mov       rcx,7FFCFD201C84
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
       mov       rcx,7FFCFD2227C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD2227C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD2227C4
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M05_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M05_L01:
       sub       edi,eax
       js        near ptr M05_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M05_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M05_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M05_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M05_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M05_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M05_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L05
M05_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,4000
       jbe       short M08_L00
       mov       rcx,7FFCFD1A1064
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFCFD0EF888]
M08_L00:
       mov       rcx,7FFCFD1A1060
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M08_L02
M08_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L01
; Total bytes of code 115
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
       call      qword ptr [7FFCFD1CE910]
       int       3
M09_L03:
       call      qword ptr [7FFCFD1CE928]; System.Threading.Lock.SignalWaiterIfNecessary(State)
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD0E4FD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M10_L14
M10_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD29E448
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M10_L02
M10_L08:
       mov       rdx,7FFCFD29C8F8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L03
M10_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD29C778
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD1C4A20]
       int       3
M10_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFCB97C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M10_L00
M10_L13:
       call      qword ptr [7FFCFD1CEA18]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFCB9CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M10_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M10_L18
       cmp       qword ptr [rbp-28],0
       jne       short M10_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C4A20]
       int       3
M10_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M10_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFCB9CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       jmp       near ptr M11_L13
M11_L02:
       xor       eax,eax
       mov       [rcx+2C],eax
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFC7DF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       jne       short M11_L07
       lock inc  qword ptr [rsi]
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
       call      qword ptr [7FFCFC7D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M11_L00
M11_L09:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFCB97C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L03
M11_L10:
       mov       rcx,rdx
       mov       rdx,7FFCFD29C8F8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFCE2CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE2CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M11_L05
M11_L13:
       xor       eax,eax
       mov       [rcx+2C],eax
       cmp       dword ptr [rbp-3C],0
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M11_L14
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M11_L16
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
M11_L16:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdi,[rbp+10]
       mov       [rdi+2C],ecx
       cmp       dword ptr [rbp-3C],0
       je        short M11_L17
       mov       rcx,rdi
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
M11_L17:
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
       mov       ecx,ecx
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
       mov       rdx,7FFCFD29C778
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M13_L00
M13_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCFD0E4FA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1FE47000898
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD074B58]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FFCFCEA5E30]
       int       3
M00_L01:
       mov       rax,r15
       lea       edx,[r12-1]
       cmp       edx,r13d
       jae       near ptr M00_L28
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L37
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
       jl        near ptr M00_L29
       mov       [rbp-0C0],r8
       cmp       [r8+8],edx
       je        short M00_L05
       test      edx,edx
       jle       near ptr M00_L40
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
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC720F88
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
       je        near ptr M00_L36
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M00_L34
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L33
       cmp       r13d,[rdx+8]
       ja        near ptr M00_L32
       cmp       r13d,[rax+8]
       ja        near ptr M00_L31
       mov       r8d,r13d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L35
       mov       rax,[rbp-78]
       cmp       r8,4000
       jbe       short M00_L09
       mov       rcx,r10
       call      qword ptr [7FFCFCFFC438]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,r10
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L30
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
       jae       near ptr M00_L37
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
       mov       r11,7FFCFC720F80
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-88]
       mov       r8,[rbp-90]
       mov       r11,[rbp-68]
       jne       near ptr M00_L27
M00_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-6C]
       cmp       edx,r10d
       jb        near ptr M00_L26
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
       jae       near ptr M00_L37
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
       je        near ptr M00_L27
M00_L17:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M00_L26
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
       call      qword ptr [7FFCFC7DF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD07CD80]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       jae       near ptr M00_L37
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
       jae       near ptr M00_L37
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
       jg        short M00_L22
       mov       [rbp-3C],r8d
       lea       ecx,[r8+1]
       mov       [r14+20],ecx
M00_L21:
       inc       dword ptr [r14+24]
       jmp       near ptr M00_L47
M00_L22:
       mov       r15,[r14+10]
       lea       r9d,[r12-1]
       mov       eax,[r15+10]
       cmp       r9d,eax
       jae       short M00_L28
       dec       eax
       mov       [r15+10],eax
       cmp       r9d,eax
       jge       short M00_L24
       mov       rcx,[r15+8]
       mov       r13,rcx
       lea       edx,[r9+1]
       mov       r10,rcx
       sub       eax,r9d
       test      r13,r13
       jne       short M00_L25
       mov       [rbp-3C],r8d
M00_L23:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       r8,r10
       call      qword ptr [7FFCFD1C4198]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       r8d,[rbp-3C]
M00_L24:
       inc       dword ptr [r15+14]
       mov       [rbp-3C],r8d
       jmp       short M00_L21
M00_L25:
       mov       r12,[r13]
       cmp       dword ptr [r12+4],18
       jne       near ptr M00_L45
       jmp       near ptr M00_L41
M00_L26:
       call      qword ptr [7FFCFC7DF480]
       int       3
M00_L27:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1CE9A0]
       int       3
M00_L28:
       call      qword ptr [7FFCFD074390]
       int       3
M00_L29:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA5E30]
       int       3
M00_L30:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L31:
       jmp       short M00_L38
M00_L32:
       jmp       short M00_L38
M00_L33:
       jmp       short M00_L38
M00_L34:
       jmp       short M00_L38
M00_L35:
       mov       rcx,r10
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L36:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L39
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1CEA78]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-78]
M00_L39:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1CEA78]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-80]
       mov       edx,[rbp-40]
       mov       r8,[rbp-78]
       call      qword ptr [7FFCFD1C4198]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L04
M00_L40:
       mov       rcx,23EC60B2960
       mov       [r15+8],rcx
       jmp       near ptr M00_L05
M00_L41:
       mov       ecx,eax
       or        ecx,edx
       or        ecx,r9d
       jl        short M00_L44
       lea       ecx,[rdx+rax]
       mov       r11d,[r13+8]
       cmp       ecx,r11d
       ja        short M00_L43
       lea       ecx,[r9+rax]
       cmp       ecx,r11d
       ja        short M00_L42
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
       je        short M00_L46
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FFCFC7D57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L24
M00_L42:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L43:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L44:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L45:
       mov       [rbp-3C],r8d
       jmp       near ptr M00_L23
M00_L46:
       mov       [rbp-3C],r8d
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-3C]
       jmp       near ptr M00_L24
M00_L47:
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD074C78]; System.Threading.Lock.Exit(ThreadId)
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
       je        near ptr M00_L64
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       test      byte ptr [7FFCFD167F90],1
       je        near ptr M00_L66
M00_L48:
       mov       rcx,1FE47000C20
       mov       r15,[rcx]
M00_L49:
       mov       [rbp-0B0],r15
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L58
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0B0]
       cmp       [r15],rcx
       jne       near ptr M00_L58
       jmp       short M00_L52
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FFCFD074DB0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L51:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD074DE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L52:
       mov       rcx,r15
       call      qword ptr [7FFCFCBCF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L63
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       near ptr M00_L61
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       near ptr M00_L62
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD074C90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L51
       jmp       short M00_L50
M00_L53:
       mov       rcx,rsi
       call      qword ptr [7FFCFD074DB0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
M00_L54:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD074DE0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L59
       mov       rcx,r15
       call      qword ptr [7FFCFCBCF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L56:
       test      eax,eax
       je        near ptr M00_L63
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       short M00_L60
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       jae       short M00_L61
       mov       rdi,[r15+10]
       cmp       edx,[rdi+8]
       jae       short M00_L62
       mov       ecx,edx
       mov       r14,[rdi+rcx*8+10]
M00_L57:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD074C90]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L54
       jmp       short M00_L53
M00_L58:
       mov       r15,[rbp-0B0]
       cmp       [r15],r15d
       jmp       short M00_L55
M00_L59:
       mov       rcx,r15
       mov       r11,7FFCFC720F98
       call      qword ptr [r11]
       jmp       short M00_L56
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC720FA0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       short M00_L57
M00_L61:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD1CC4B0]
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L68
M00_L64:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD168190
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD07CA98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       jmp       near ptr M00_L49
M00_L66:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L48
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFCFC720F90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L49
M00_L68:
       mov       rcx,r15
       mov       r11,7FFCFC720FA8
       call      qword ptr [r11]
       jmp       near ptr M00_L64
       sub       rsp,38
       cmp       qword ptr [rbp-0B8],0
       je        short M00_L69
       mov       rcx,[rbp-0B8]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD074C78]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC720FA8
       call      qword ptr [r11]
M00_L70:
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
       call      qword ptr [7FFCFD074BA0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD201C70
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
       mov       rcx,7FFCFD201C74
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1C5DE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC85AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1C5E00]
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
       mov       rcx,7FFCFD201C7C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD201C80
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD201C78
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
       mov       rcx,7FFCFD201C84
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       mov       rcx,7FFCFD2227C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L02
       mov       rcx,7FFCFD2227C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       mov       rcx,7FFCFD2227C4
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M06_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M06_L01:
       sub       edi,eax
       js        near ptr M06_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M06_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M06_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M06_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M06_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M06_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M06_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M06_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L05
M06_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
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
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 88
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,4000
       jbe       short M09_L00
       mov       rcx,7FFCFD1A146C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFCFCFFC438]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L00:
       mov       rcx,7FFCFD1A1468
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,rbx
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M09_L02
M09_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 115
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
       call      qword ptr [7FFCFD1CE880]
       int       3
M10_L03:
       call      qword ptr [7FFCFD1CE898]; System.Threading.Lock.SignalWaiterIfNecessary(State)
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD074CD8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD29E950
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD29CFB8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD29C630
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD1C4930]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFD1C60B8]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD1CEA60]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFD1C5428]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C4930]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFD1C5428]
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
       call      qword ptr [7FFCFC7D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7DF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFC7D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M12_L00
M12_L08:
       mov       rcx,rdx
       mov       rdx,7FFCFD29CFB8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFCE2CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE2CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M12_L13
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M12_L15
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rdx,7FFCFD29C630
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L00
M14_L02:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [7FFCFD074CA8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].GetValueSlow()
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1CD04400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD105350]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC720F88
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
       mov       r11,7FFCFC720F80
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
       call      qword ptr [7FFCFC7DF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD10D578]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFC7DF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1CE9B8]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCFCEA5E30]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA5E30]
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
       call      qword ptr [7FFCFCEAE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1CEAD8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1CEAD8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFCFD1C40F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,20D83292960
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCFD104B58]
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
       call      qword ptr [7FFCFCE2CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD105470]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD17C520],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1CD04400C20
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
       call      qword ptr [7FFCFD1055A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1CECD0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD1054B8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1055D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFCFCBCF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1055A8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1CECD0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD1054B8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1055D8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFCFCBCF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1C53C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD1CEA48]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC720F98
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFCFC720FA0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFCFD1C53C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD1CEA48]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD1CC4C8]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFCFD1CEA18]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFCFD1CEA60]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCFCC87900]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD17C720
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D2A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC720F90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFCFC720FA8
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD105470]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC720FA8
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
       call      qword ptr [7FFCFD105398]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD201810
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
       mov       rcx,7FFCFD201814
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1C5E00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC85AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1C5E18]
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
       mov       rcx,7FFCFD20181C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD201820
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD201818
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
       mov       rcx,7FFCFD201824
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
       mov       rcx,7FFCFD221870
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD221868
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD22186C
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M08_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFCFD299B28
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rcx,7FFCFD299B4C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCFD299B44
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCFD299B50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCFD1C40F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFCFCEAE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCFD299B2C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCFD299B30
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCFD299B34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCFD299B38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCFD299B3C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCFD299B40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCFD299B48
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
       call      qword ptr [7FFCFD1CE988]
       int       3
M10_L03:
       call      qword ptr [7FFCFD1CE9A0]
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1054D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD2A3938
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD2A1BD8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD2A1A58
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD1C4A20]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFD1C6148]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD1CEA90]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFD1C5518]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C4A20]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFD1C5518]
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
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFD5C3D7470
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
       jmp       qword ptr [7FFCFD1CEA30]
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
       jmp       qword ptr [7FFCFD1054D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFCFD2A1A58
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFC7D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L07:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD1C6148]
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
       mov       rdx,7FFCFD2A1BD8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7DF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFCE2CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE2CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L16
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L18
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7D6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD5A7B0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,12C08C00880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD0F5068]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC730FA8
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
       mov       r11,7FFCFC730FA0
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
       call      qword ptr [7FFCFC7EF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD0FD158]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFC7EF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1DEA48]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCFCEB5E60]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB5E60]
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
       call      qword ptr [7FFCFCEBE130]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1DEB08]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1DEB08]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFCFD1D42D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,16C87C72960
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCFD0F4750]
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
       call      qword ptr [7FFCFCE3CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0F5188]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD175EA8],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,12C08C00AE0
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
       call      qword ptr [7FFCFD0F52C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1DEB80]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD0F51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0F52F0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFCFCB5AF48]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD0F52C0]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1DEB80]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD0F51D0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0F52F0]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFCFCB5AF48]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1D5578]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD0FD260]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC730FB8
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFCFC730FC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFCFD1D5578]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD0FD260]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD0FD290]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFCFD0FD2A8]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFCFD0FD2C0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCFCC97930]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD1760A8
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FCE70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC730FB0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFCFC730FC8
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD0F5188]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC730FC8
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
       call      qword ptr [7FFCFD0F50B0]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD213800
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
       mov       rcx,7FFCFD213804
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1D5F98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC95AE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1D5FB0]
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
       mov       rcx,7FFCFD21380C
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD213810
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD213808
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
       mov       rcx,7FFCFD213814
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
       mov       rcx,7FFCFD234228
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD234220
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD234224
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFCFC7E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M08_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFCFD2BBE40
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rcx,7FFCFD2BBE64
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCFD2BBE5C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCFD2BBE68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCFD1D42D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFCFCEBE130]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCFD2BBE44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCFD2BBE48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCFD2BBE4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCFD2BBE50
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCFD2BBE54
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCFD2BBE58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCFD2BBE60
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
       call      qword ptr [7FFCFD1DEA18]
       int       3
M10_L03:
       call      qword ptr [7FFCFD1DEA30]
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD0F51E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD182480
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD182490
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD1822B0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD0FD278]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFCABF8B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD1DEAC0]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFCBACE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD0FD278]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFCBACE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFD5C3D7470
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
       jmp       qword ptr [7FFCFD0FD248]
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
       jmp       qword ptr [7FFCFD0F51E8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFCFD1822B0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7E5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7E6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCFC7E5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFCFD182490
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7EF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFCE3CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE3CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7E6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7E6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7E6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD5A7B0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,18788400880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD1254E8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC740FA8
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
       mov       r11,7FFCFC740FA0
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
       call      qword ptr [7FFCFC7FF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD12D5D8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFC7FF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCFD1EEA60]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E30]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
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
       call      qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1EEB20]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1EEB20]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFCFD1E42B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,1C8076A2960
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCFD124BA0]
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
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD125608]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD19C520],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,18788400AE0
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
       call      qword ptr [7FFCFD125740]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1EEB80]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD125650]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD125770]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFCFCBEF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD125740]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD1EEB80]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD125650]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD125770]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFCFCBEF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1E5578]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD12D6B0]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC740FB8
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFCFC740FC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFCFD1E5578]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD12D6B0]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD12D710]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFCFD12D728]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFCFD12D740]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCFCCA7900]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD19C720
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD12D308]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC740FB0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFCFC740FC8
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD125608]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC740FC8
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
       call      qword ptr [7FFCFD125530]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD2227D0
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
       mov       rcx,7FFCFD2227D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1E5F98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCCA5AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1E5FB0]
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
       mov       rcx,7FFCFD2227DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD2227E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD2227D8
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
       mov       rcx,7FFCFD2227E4
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
       mov       rcx,7FFCFD243228
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD243220
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD243224
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A7A96A0]
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
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L03
M05_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M05_L07
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M08_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFCFD2BA6A0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rcx,7FFCFD2BA6C4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCFD2BA6BC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCFD2BA6C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCFD1E42B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCFD2BA6A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCFD2BA6A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCFD2BA6AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCFD2BA6B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCFD2BA6B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCFD2BA6B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCFD2BA6C0
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
       call      qword ptr [7FFCFD1EEA30]
       int       3
M10_L03:
       call      qword ptr [7FFCFD1EEA48]
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD125668]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD1A2480
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD1A2490
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD1A22B0
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD12D6C8]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFD12D6E0]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD1EEAD8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFD12D6F8]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD12D6C8]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFD12D6F8]
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
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFD5C3D7470
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
       jmp       qword ptr [7FFCFD12D698]
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
       jmp       qword ptr [7FFCFD125668]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFCFD1A22B0
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFCFD1A2490
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7FF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD5A7B0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1EF10C00880
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD117150]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC7412A8
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
       mov       r11,7FFCFC7412A0
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
       call      qword ptr [7FFCFC7FF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD11F5B8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFC7FF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCFD394180]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E30]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
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
       call      qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD1D7330]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD1D7330]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFCFD02E550]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,22F8FBA2960
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCFD116988]
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
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD117270]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD1C4018],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,1EF10C00AF0
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
       call      qword ptr [7FFCFD1175B8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD3942A0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD1174C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1175E8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFCFCBEF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1175B8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD3942A0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD1174C8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1175E8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFCFCBEF918]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD1D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD11F4F8]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC7412B8
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFCFC7412C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFCFD1D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD11F4F8]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD11F558]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFCFD11F570]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFCFD11F588]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCFCCA7900]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD1C4218
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD11F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC7412B0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFCFC7412C8
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD117270]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC7412C8
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
       call      qword ptr [7FFCFD117198]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rsi,7FFD59B31390
       xor       edi,edi
       mov       ebp,48
M02_L00:
       mov       r14d,[rsi+rdi]
       cmp       r14d,ebx
       jl        short M02_L01
       mov       rcx,7FFCFD22A1D0
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
       mov       rcx,7FFCFD22A1D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rdi,4
       dec       ebp
       jne       short M02_L00
       jmp       short M02_L03
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCFD1D6730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCCA5AB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1D6748]
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
       mov       rcx,7FFCFD22A1DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FFCFD22A1E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       esi,2
M02_L06:
       cmp       esi,7FFFFFFF
       jl        short M02_L04
       jmp       short M02_L08
M02_L07:
       mov       rcx,7FFCFD22A1D8
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
       mov       rcx,7FFCFD22A1E4
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
       mov       rcx,7FFCFD24FE18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD24FE10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD24FE14
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M08_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFCFD2F3738
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rcx,7FFCFD2F375C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCFD2F3754
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCFD2F3760
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCFD02E550]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCFD2F373C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCFD2F3740
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCFD2F3744
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCFD2F3748
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCFD2F374C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCFD2F3750
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCFD2F3758
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
       call      qword ptr [7FFCFD394150]
       int       3
M10_L03:
       call      qword ptr [7FFCFD394168]
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1174E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD19B308
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD19B318
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD19B138
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD11F510]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFD11F528]
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD3941F8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFD11F540]
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD11F510]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFD11F540]
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
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFD5C3D7470
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
       jmp       qword ptr [7FFCFD11F4E0]
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
       jmp       qword ptr [7FFCFD1174E0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFCFD19B138
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFCFD19B318
       call      qword ptr [7FFCFC7FF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7FF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE4CD98]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD5A7B0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,29C4C800900
       mov       r14,[rcx]
       mov       r15,[r14+18]
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFCFD2A4870]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FFCFC7417B8
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
       mov       r11,7FFCFC7417B0
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
       call      qword ptr [7FFCFC7FF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFD2ACC18]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FFCFC7FF480]
       int       3
M00_L22:
       mov       ecx,r13d
       call      qword ptr [7FFCFD3C4C78]
       int       3
M00_L23:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFCFCEC5E60]
       int       3
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E60]
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
       call      qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L31:
       mov       rcx,r10
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L32:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L34
M00_L33:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFCFD144798]; System.Array.GetLowerBound(Int32)
       mov       [rbp-40],eax
       mov       rax,[rbp-70]
M00_L34:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFCFD144798]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-78]
       mov       edx,[rbp-40]
       mov       r8,[rbp-70]
       call      qword ptr [7FFCFD016478]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,2DCCB912538
       mov       [r15+8],rcx
       jmp       near ptr M00_L04
M00_L36:
       call      qword ptr [7FFCFD017288]
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
       call      qword ptr [7FFCFCE4CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-3C]
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD2A4990]; System.Threading.Lock.Exit(ThreadId)
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
       test      byte ptr [7FFCFD345C08],1
       je        near ptr M00_L71
M00_L40:
       mov       rcx,29C4C800BD8
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
       call      qword ptr [7FFCFD2A4AC8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L46
M00_L43:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD3C4DB0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L59
       xor       r12d,r12d
M00_L44:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD2A49D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L45:
       test      rcx,rcx
       je        short M00_L42
M00_L46:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD2A4AF8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
M00_L47:
       mov       rcx,r15
       call      qword ptr [7FFCFCBD69E0]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD2A4AC8]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rcx,rax
       jmp       short M00_L53
M00_L50:
       mov       eax,[r13+18]
       not       eax
       test      eax,eax
       jl        near ptr M00_L65
       call      qword ptr [7FFCFD3C4DB0]; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       cmp       qword ptr [r13+8],0
       jne       near ptr M00_L63
       xor       r12d,r12d
M00_L51:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFCFD2A49D8]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rcx,r12
M00_L52:
       test      rcx,rcx
       je        short M00_L49
M00_L53:
       lea       r8,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD2A4AF8]; System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.__Canon, System.Private.CoreLib]].LocalPush(System.__Canon, Int64 ByRef)
       nop
M00_L54:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-0A8]
       cmp       [r15],rcx
       jne       near ptr M00_L60
       mov       rcx,r15
       call      qword ptr [7FFCFCBD69E0]; System.SZGenericArrayEnumeratorBase.MoveNext()
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
       call      qword ptr [7FFCFD0176F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L48
M00_L59:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD2ACBB8]
       test      eax,eax
       je        near ptr M00_L44
       jmp       short M00_L66
M00_L60:
       mov       rcx,r15
       mov       r11,7FFCFC7417C8
       call      qword ptr [r11]
       jmp       near ptr M00_L55
M00_L61:
       mov       rcx,r15
       mov       r11,7FFCFC7417D0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L56
M00_L62:
       mov       ecx,0E
       call      qword ptr [7FFCFD0176F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L57
M00_L63:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FFCFD2ACBB8]
       test      eax,eax
       je        near ptr M00_L51
       jmp       short M00_L66
M00_L64:
       mov       ecx,[r15+8]
       call      qword ptr [7FFCFD2A4540]
       int       3
M00_L65:
       mov       rcx,r13
       call      qword ptr [7FFCFD2ACBD0]
       int       3
M00_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFCFD2ACBE8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFCFCCA7930]
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
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD345E08
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD2AC660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFCFC7417C0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L41
M00_L73:
       mov       rcx,r15
       mov       r11,7FFCFC7417D8
       call      qword ptr [r11]
       jmp       near ptr M00_L69
       sub       rsp,38
       cmp       qword ptr [rbp-0B0],0
       je        short M00_L74
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFCFD2A4990]; System.Threading.Lock.Exit(ThreadId)
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
       mov       r11,7FFCFC7417D8
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
       call      qword ptr [7FFCFD2A48B8]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
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
       mov       rcx,7FFD59B31390
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
       call      qword ptr [7FFCFD144B28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCCA5AE8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD144B40]
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
       mov       rcx,7FFCFD1F0D68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7F5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M03_L01:
       cmp       ecx,7FFFFFC3
       jge       short M03_L02
       mov       rcx,7FFCFD1F0D60
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       mov       rcx,7FFCFD1F0D64
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
       call      qword ptr [7FFD5A7A5F98]
       mov       rdi,rax
       mov       ebp,[rbx+38]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       mov       r8d,ebp
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFD5A797FC0]
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
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L04
M05_L01:
       cmp       rdi,4000
       ja        short M05_L00
M05_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFD5A7A2710]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC0D8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M08_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M08_L01:
       sub       edi,eax
       js        near ptr M08_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M08_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M08_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
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
       call      qword ptr [7FFD5A7A9320]
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
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M08_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M08_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M08_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
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
       mov       rcx,7FFCFD3B1088
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,4000
       ja        near ptr M09_L06
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rcx,7FFCFD3B10AC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       r14,1
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,r14
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L00
M09_L02:
       movzx     ecx,byte ptr [rbx]
       mov       [rdi],cl
       jmp       short M09_L00
M09_L03:
       mov       rcx,7FFCFD3B10A4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FFCFD3B10B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       call      qword ptr [7FFCFD016478]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       jmp       qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M09_L07:
       mov       rcx,7FFCFD3B108C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L08:
       mov       rcx,7FFCFD3B1090
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L09:
       mov       rcx,7FFCFD3B1094
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L04
M09_L10:
       mov       rcx,7FFCFD3B1098
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L11:
       mov       rcx,7FFCFD3B109C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,7FFCFD3B10A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FFCFD3B10A8
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
       call      qword ptr [7FFCFD3C4BA0]
       int       3
M10_L03:
       call      qword ptr [7FFCFD3C4BB8]
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
       call      00007FFD5C309E20
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
       mov       ecx,ecx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       short M11_L10
M11_L06:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCFD2A49F0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
       jmp       near ptr M11_L14
M11_L07:
       mov       rcx,rdx
       mov       rdx,7FFCFD31C7D0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M11_L02
M11_L08:
       mov       rdx,7FFCFD31C7E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M11_L03
M11_L09:
       mov       rcx,rdx
       mov       rdx,7FFCFD31C510
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFD016D00]
       int       3
M11_L12:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCFCBB7C78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M11_L00
M11_L13:
       call      qword ptr [7FFCFD3C4CD8]
       mov       rsi,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M11_L01
M11_L14:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
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
       call      qword ptr [7FFCFCBBCE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M11_L15
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M11_L18
       cmp       qword ptr [rbp-28],0
       jne       short M11_L17
       xor       ecx,ecx
       call      qword ptr [7FFCFD016D00]
       int       3
M11_L17:
       mov       rcx,[rbp-28]
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M11_L18
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FFCFCBBCE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M11_L18:
       nop
       add       rsp,28
       ret
; Total bytes of code 537
```
```assembly
; System.Diagnostics.Debugger.NotifyOfCrossThreadDependency()
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M12_L01
M12_L00:
       mov       rax,7FFD5C3D7470
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
       jmp       qword ptr [7FFCFD2ACBA0]
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
       jmp       qword ptr [7FFCFD2A49F0]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M13_L02:
       mov       rdx,7FFCFD31C510
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
; Total bytes of code 149
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
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M14_L00
M14_L03:
       xor       edx,edx
       mov       [rcx+2C],edx
       lea       rdx,[rbp-40]
       call      qword ptr [7FFCFC7F5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFCFD31C7E0
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
       call      qword ptr [7FFCFC7FF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCFCE4CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rsp+20],r14d
       mov       r9,[rdi+8]
       mov       r9d,[r9+8]
       sub       r9d,r14d
       mov       rcx,[rdi+8]
       mov       r8,r13
       xor       edx,edx
       call      qword ptr [7FFCFCE4CDC8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M14_L12
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M14_L14
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCFC7F6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD5A7B0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC99F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,2B321C01F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1E6028]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1E6010]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4978]
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
       call      qword ptr [7FFCFD1EEAA8]
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
       jne       near ptr M00_L37
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD199100],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,2B337C00C20
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7410D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1EC450]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
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
M00_L38:
       call      qword ptr [7FFCFCECE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD124450]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD124468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L40
       mov       rcx,2B321C01F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L40:
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
       mov       r11,7FFCFC7410F0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2B337C00C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1E5470]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4978]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1E5470]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1617
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
       jmp       qword ptr [7FFCFCCAF030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD12F840]
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
       jmp       qword ptr [7FFCFC7FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD5A798018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD5A798020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD1A4F48
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCECE100]
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1E7330]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1E7330]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1E4048]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD20FAD0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2F3B6B00008
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
       call      qword ptr [7FFCFD1E7378]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC99F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,22F3A001F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1E5FE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1E5FE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1E5FC8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4930]
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
       call      qword ptr [7FFCFD1EEA90]
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
       jne       near ptr M00_L37
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD19D218],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,22F3A002C18
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7410D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1EC408]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
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
M00_L38:
       call      qword ptr [7FFCFCECE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD124408]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD124420]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L40
       mov       rcx,22F3A001F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L40:
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
       mov       r11,7FFCFC7410F0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22F3A002C20
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1E5428]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4930]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1E5428]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1617
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
       jmp       qword ptr [7FFCFCCAF030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD12F7F8]
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
       jmp       qword ptr [7FFCFC7FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD5A798018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD5A798020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD1A4F40
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCECE100]
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1E6958]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1E6958]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1E4000]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD20FAD0
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26FCEE80008
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
       call      qword ptr [7FFCFD1E7330]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC97F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,2C78AC01F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1C6058]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1C6058]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1C6040]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C49A8]
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
       call      qword ptr [7FFCFD1CEAF0]
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
       jne       near ptr M00_L37
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD17D218],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,2C7A0C00C20
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7210D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1CC480]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
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
M00_L38:
       call      qword ptr [7FFCFCEAE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD05AC8
       call      qword ptr [7FFCFCA57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD05AC8
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104468]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FFCFC7210E8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L40
       mov       rcx,2C78AC01F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L40:
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
       mov       r11,7FFCFC7210F0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C7A0C00C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7210C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7210E0
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1C54A0]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C49A8]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1C54A0]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1617
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
       jmp       qword ptr [7FFCFCC8F030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD10F870]
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
       jmp       qword ptr [7FFCFC7DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD5A798018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD5A798020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD184F40
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA5E30]
       int       3
M04_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L02
M04_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCEAE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L02
M04_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L10:
       xor       r13d,r13d
       jmp       short M04_L12
M04_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1C6910]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M04_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1C6910]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1C4078]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD1EFAB8
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,3081FD80008
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
       call      qword ptr [7FFCFD1C73A8]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC99F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L39
       mov       rcx,14CAE001F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1E6010]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1E6010]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1E5FF8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4960]
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
       call      qword ptr [7FFCFD1EEAC0]
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
       jne       near ptr M00_L37
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD19D218],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,14CC4000C20
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7410D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1EC438]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
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
M00_L38:
       call      qword ptr [7FFCFCECE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD124438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD124450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L40
       mov       rcx,14CAE001F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L36
M00_L40:
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
       mov       r11,7FFCFC7410F0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,14CC4000C28
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7410E0
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1E5458]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4960]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1E5458]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1617
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
       jmp       qword ptr [7FFCFCCAF030]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD12F870]
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
       jmp       qword ptr [7FFCFC7FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD1A4F40
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCECE5B0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1E6898]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1E6898]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1E4030]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD20FA68
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18D431B0008
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
       call      qword ptr [7FFCFD1E7360]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC97F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L37
       mov       rcx,20997001F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1C6010]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1C6010]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1C5FF8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C4960]
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
       call      qword ptr [7FFCFD1CEAA8]
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
       jne       near ptr M00_L39
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD17D218],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,20997002C18
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC97E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7210C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7210D0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1CC4C8]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
       mov       rcx,rsi
       mov       r11,7FFCFC7210E0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L38
       mov       rcx,20997001F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L38:
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
       mov       r11,7FFCFC7210E8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L39:
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
M00_L40:
       call      qword ptr [7FFCFCEAE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD05AC8
       call      qword ptr [7FFCFCA57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD05AC8
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20997002C20
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7210C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7210D8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7210D8
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1C5458]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1C4960]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1C5458]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1614
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
       jmp       qword ptr [7FFCFCC8F030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD10F828]
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
       jmp       qword ptr [7FFCFC7DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD184F40
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA5E30]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCEAE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1C6928]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1C6928]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1C4030]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD1EFA78
       call      qword ptr [7FFCFC7DC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24A2C160008
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
       call      qword ptr [7FFCFD1C73F0]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFC99F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L37
       mov       rcx,2C807C01F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1E6010]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1E6010]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1E5FF8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4960]
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
       call      qword ptr [7FFCFD1EEAA8]
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
       jne       near ptr M00_L39
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD19D208],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,2C807C02C18
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC99E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7410C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7410D0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1EC4C8]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
       mov       rcx,rsi
       mov       r11,7FFCFC7410E0
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L38
       mov       rcx,2C807C01F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L38:
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
       mov       r11,7FFCFC7410E8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L39:
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
M00_L40:
       call      qword ptr [7FFCFCECE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD25AC8
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD124438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD124450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C807C02C20
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7410C0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC7410D8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC7410D8
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1E5458]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1E4960]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1E5458]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1614
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
       jmp       qword ptr [7FFCFCCAF030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD12F828]
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
       jmp       qword ptr [7FFCFC7FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD1A4F88
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC5E30]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCECE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1E6928]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1E6928]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1E4030]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD20FA68
       call      qword ptr [7FFCFC7FC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,3089CAA0008
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
       call      qword ptr [7FFCFD1E73F0]
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
       jmp       qword ptr [7FFCFC7F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L37
       mov       rcx,1FD96801F20
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFD1D61C0]
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFD1D61C0]
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD1D61A8]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFD1D4B10]
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
       call      qword ptr [7FFCFD394180]
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
       jne       near ptr M00_L39
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD18BF80],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,1FDAC800C58
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
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r11,7FFCFC7312F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC7312F8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD1DCB88]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
       mov       rcx,rsi
       mov       r11,7FFCFC731308
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L38
       mov       rcx,1FD96801F20
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L38:
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
       mov       r11,7FFCFC731310
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L39:
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
M00_L40:
       call      qword ptr [7FFCFCEBE6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCD15AC8
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD15AC8
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F5518]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F5530]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FDAC800C60
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC7312E8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC731300
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC731300
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFD1D5608]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFD1D4B10]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFD1D5608]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1613
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
       jmp       qword ptr [7FFCFCC9F030]
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       call      qword ptr [7FFCFD0FF228]
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
       jmp       qword ptr [7FFCFC7ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
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
       mov       rdx,7FFCFD195E48
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB5E30]
       int       3
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L02
M03_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCEBE100]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L02
M03_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L10:
       xor       r13d,r13d
       jmp       short M03_L12
M03_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1D70A8]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M03_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1D70A8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1D42A0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,7FFCFD228440
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23E2B7F0008
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
       call      qword ptr [7FFCFD1D7B10]
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M00_L37
       mov       rcx,23D3E801F58
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
       call      00007FFD5C309E20
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
       call      00007FFD5C309E20
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
       call      qword ptr [7FFCFCFFC840]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rsi
       call      qword ptr [7FFCFCFFC840]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L02
M00_L15:
       call      qword ptr [7FFCFD104D50]
       int       3
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FFCFCFF6CA0]
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
       call      qword ptr [7FFCFD394C90]
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
       jne       near ptr M00_L39
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rdi
       test      byte ptr [7FFCFD2E9AE8],1
       je        near ptr M00_L43
M00_L23:
       mov       rcx,23D54800C80
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
       call      qword ptr [7FFCFC96E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFCFC96E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L31
M00_L32:
       mov       rcx,r14
       mov       r11,7FFCFC711728
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L35
       mov       rcx,r14
       mov       r11,7FFCFC711730
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L28
M00_L33:
       mov       ecx,[r14+8]
       call      qword ptr [7FFCFD26D038]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       [r14],rdi
       jne       near ptr M00_L45
M00_L36:
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
M00_L37:
       mov       rcx,rsi
       mov       r11,7FFCFC711740
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jne       short M00_L38
       mov       rcx,23D3E801F58
       mov       rdx,[rcx]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L36
M00_L38:
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
       mov       r11,7FFCFC711748
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp-60]
       mov       [rcx+10],r14d
       jmp       near ptr M00_L36
M00_L39:
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
M00_L40:
       call      qword ptr [7FFCFCE9E6D0]
       mov       ecx,0CF
       mov       rdx,7FFCFCCF5AC8
       call      qword ptr [7FFCFCA47738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5D90
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF5AC8
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFF6BC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFF6BE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       call      M00_L47
       nop
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23D54800C88
       mov       rsi,[rcx]
       jmp       near ptr M00_L22
M00_L43:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L44:
       mov       rcx,rbx
       mov       r11,7FFCFC711720
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,r14
       mov       r11,7FFCFC711738
       call      qword ptr [r11]
       jmp       near ptr M00_L36
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-68]
       cmp       [r14],rdi
       je        short M00_L46
       mov       rcx,r14
       mov       r11,7FFCFC711738
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
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCFCFF77E0]
M00_L49:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L48
M00_L50:
       mov       rbx,[rbx+8]
       test      rbx,rbx
       jne       short M00_L51
       xor       ecx,ecx
       call      qword ptr [7FFCFCFF6CA0]
       int       3
M00_L51:
       mov       rcx,rbx
       call      00007FFD5C3C6030
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCFCFF77E0]
M00_L52:
       nop
       add       rsp,28
       ret
; Total bytes of code 1613
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
       jmp       qword ptr [7FFCFCC7F030]
; Total bytes of code 121
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
       jmp       near ptr 00007FFD5C417B10
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFCFCFF5728]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCFC7CD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FFD5A798018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD5A798020]; CORINFO_HELP_JIT_PINVOKE_END
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
       mov       rdx,7FFCFCFD72F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCE95E30]
       int       3
M04_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFCFC964FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFCFD02CFA0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27DD36C0008
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
       call      qword ptr [7FFCFD10F4B0]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

