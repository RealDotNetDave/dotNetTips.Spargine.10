## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.TempFileManagerDeleteAllFilesBenchmark.DeleteAllFiles()
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
       mov       [rbp-40],rax
       mov       rbx,[rcx+1A8]
       mov       rdx,[rbx+8]
       mov       [rbp-80],rdx
       cmp       [rdx],dl
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,17F184004A8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L07
M00_L00:
       mov       rcx,[rdx+8]
       mov       rcx,[rcx+18]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L11
       mov       rdi,[rcx+10]
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      00007FFC146DE120
       test      eax,eax
       je        near ptr M00_L08
M00_L01:
       mov       dword ptr [rbp-44],1
       mov       rdx,[rbp-80]
       mov       rcx,[rdx+8]
       mov       rdi,[rcx+18]
       mov       r14d,1
       mov       r15d,[rdi+8]
       cmp       r15d,1
       jle       short M00_L04
M00_L02:
       mov       r13,[rdi+r14*8+10]
       test      r13,r13
       je        near ptr M00_L10
       mov       rcx,r13
       call      00007FFC146DE120
       test      eax,eax
       je        short M00_L09
M00_L03:
       mov       ecx,[rbp-44]
       inc       ecx
       mov       [rbp-44],ecx
       inc       r14d
       cmp       r15d,r14d
       jg        short M00_L02
M00_L04:
       xor       ecx,ecx
       mov       rdx,[rbp-80]
       mov       rax,[rdx+8]
       mov       rax,[rax+20]
       mov       r8d,[rax+8]
       test      r8d,r8d
       jle       short M00_L06
       add       rax,10
M00_L05:
       add       ecx,[rax]
       jo        short M00_L12
       add       rax,4
       dec       r8d
       jne       short M00_L05
M00_L06:
       mov       edi,ecx
       jmp       short M00_L13
M00_L07:
       mov       rcx,[rdx+8]
       mov       rcx,[rcx+10]
       mov       edx,[rcx+8]
       mov       rcx,rsi
       call      qword ptr [7FFBB5285D70]
       mov       rdx,[rbp-80]
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rdi
       call      qword ptr [7FFBB514F948]
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,r13
       call      qword ptr [7FFBB514F948]
       jmp       short M00_L03
M00_L10:
       xor       ecx,ecx
       call      qword ptr [7FFBB514E4F0]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L13:
       mov       r14d,[rbp-44]
       mov       rcx,[rdx+8]
       mov       r15,[rcx+18]
       xor       r13d,r13d
       test      r14d,r14d
       jle       short M00_L16
       test      r15,r15
       je        near ptr M00_L76
       cmp       [r15+8],r14d
       jl        near ptr M00_L76
       add       r15,10
M00_L14:
       mov       r12,[r15]
       test      r12,r12
       je        near ptr M00_L83
       mov       rcx,r12
       call      00007FFC146DE040
       test      eax,eax
       jne       near ptr M00_L79
M00_L15:
       add       r15,8
       dec       r14d
       jne       short M00_L14
M00_L16:
       test      edi,edi
       je        near ptr M00_L69
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-40],rax
       xor       r14d,r14d
       mov       rdx,[rbx+8]
       mov       [rbp-88],rdx
       mov       rdx,[rbp-88]
       cmp       [rdx],dl
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L28
M00_L17:
       mov       rcx,[rdx+8]
       mov       rcx,[rcx+18]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L33
       mov       r15,[rcx+10]
       test      r15,r15
       je        near ptr M00_L31
       mov       rcx,r15
       call      00007FFC146DE120
       test      eax,eax
       je        near ptr M00_L29
M00_L18:
       mov       dword ptr [rbp-48],1
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+8]
       mov       r13,[rcx+18]
       mov       esi,1
       mov       r15d,[r13+8]
       cmp       r15d,1
       jle       short M00_L21
M00_L19:
       mov       r12,[r13+rsi*8+10]
       test      r12,r12
       je        near ptr M00_L31
       mov       rcx,r12
       call      00007FFC146DE120
       test      eax,eax
       je        near ptr M00_L30
M00_L20:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
       inc       esi
       cmp       r15d,esi
       jg        short M00_L19
M00_L21:
       xor       edx,edx
       mov       rax,[rbp-88]
       mov       rcx,[rax+8]
       mov       rcx,[rcx+20]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jle       short M00_L23
       add       rcx,10
M00_L22:
       add       edx,[rcx]
       jo        near ptr M00_L34
       add       rcx,4
       dec       r8d
       jne       short M00_L22
M00_L23:
       test      edx,edx
       je        near ptr M00_L32
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       r15d,r15d
       mov       rax,[rbp-88]
       mov       rcx,[rax+8]
       mov       r13,[rcx+10]
       mov       r12d,[r13+8]
       test      r12d,r12d
       jle       short M00_L27
       mov       r8d,10
       jmp       short M00_L25
M00_L24:
       mov       r8,[rbp-70]
       add       r8,8
       dec       r12d
       je        short M00_L27
M00_L25:
       mov       [rbp-70],r8
       mov       r10,[r8+r13]
       test      r10,r10
       je        short M00_L24
       mov       r9d,[rsi+8]
       mov       [rbp-68],r9
M00_L26:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L33
       movsxd    rcx,r15d
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-90],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L26
       jmp       short M00_L24
M00_L27:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L28:
       mov       rcx,[rdx+8]
       mov       rcx,[rcx+10]
       mov       edx,[rcx+8]
       mov       rcx,rsi
       call      qword ptr [7FFBB5285D70]
       mov       rdx,[rbp-88]
       jmp       near ptr M00_L17
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFBB514F948]
       jmp       near ptr M00_L18
M00_L30:
       mov       rcx,r12
       call      qword ptr [7FFBB514F948]
       jmp       near ptr M00_L20
M00_L31:
       xor       ecx,ecx
       call      qword ptr [7FFBB514E4F0]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F184006A0
       mov       r15,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       mov       esi,[rbp-48]
       mov       rax,[rbp-88]
       mov       rcx,[rax+8]
       mov       r13,[rcx+18]
       xor       r12d,r12d
       test      esi,esi
       jle       short M00_L38
       test      r13,r13
       je        near ptr M00_L73
       cmp       [r13+8],esi
       jl        near ptr M00_L73
       mov       r12d,10
M00_L36:
       mov       rdx,[r12+r13]
       test      rdx,rdx
       je        near ptr M00_L83
       mov       [rbp-98],rdx
       mov       rcx,rdx
       call      00007FFC146DE040
       test      eax,eax
       jne       near ptr M00_L81
M00_L37:
       add       r12,8
       dec       esi
       jne       short M00_L36
M00_L38:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       cmp       [r15],rcx
       jne       near ptr M00_L88
       mov       rcx,[r15+8]
       mov       r11,offset MT_System.String[]
       cmp       [rcx],r11
       jne       near ptr M00_L84
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M00_L87
M00_L39:
       mov       r15,[r15+8]
       mov       rcx,offset MT_System.String[]
       cmp       [r15],rcx
       jne       near ptr M00_L86
       mov       r13d,[r15+8]
       test      r13d,r13d
       jne       near ptr M00_L75
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
       mov       rcx,r12
       test      byte ptr [7FFBB4CFF078],1
       je        near ptr M00_L85
M00_L40:
       mov       rcx,17F184006A8
       mov       rcx,[rcx]
M00_L41:
       mov       [rbp-78],rcx
       cmp       qword ptr [rbp-78],0
       je        near ptr M00_L43
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       short M00_L43
M00_L42:
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       near ptr M00_L46
       mov       [rcx+8],eax
       mov       edx,[rcx+8]
       cmp       edx,[rcx+0C]
       jae       near ptr M00_L48
       mov       rsi,[rcx+10]
       mov       r15d,[rcx+8]
       cmp       r15d,[rsi+8]
       jae       near ptr M00_L49
       mov       edx,r15d
       mov       rdx,[rsi+rdx*8+10]
       mov       eax,r14d
       add       eax,1
       jo        near ptr M00_L50
       mov       r13d,eax
       mov       rax,[rbp-40]
       cmp       r14d,[rax+8]
       jae       near ptr M00_L49
       mov       rax,[rbp-40]
       mov       r8d,r14d
       lea       rcx,[rax+r8*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,r13d
       mov       rcx,[rbp-78]
       jmp       short M00_L42
M00_L43:
       mov       rcx,[rbp-78]
       cmp       [rcx],ecx
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
M00_L44:
       cmp       [rcx],r12
       jne       short M00_L47
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M00_L46
       mov       [rcx+8],eax
       mov       r11d,[rcx+8]
       cmp       r11d,[rcx+0C]
       jae       short M00_L48
       mov       rsi,[rcx+10]
       mov       r15d,[rcx+8]
       cmp       r15d,[rsi+8]
       jae       short M00_L49
       mov       r11d,r15d
       mov       rdx,[rsi+r11*8+10]
M00_L45:
       mov       eax,r14d
       add       eax,1
       jo        short M00_L50
       mov       esi,eax
       mov       rax,[rbp-40]
       cmp       r14d,[rax+8]
       jae       short M00_L49
       mov       rax,[rbp-40]
       mov       r8d,r14d
       lea       rcx,[rax+r8*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,esi
       mov       rcx,[rbp-78]
       jmp       short M00_L44
M00_L46:
       mov       r11d,[rcx+0C]
       mov       [rcx+8],r11d
       jmp       short M00_L51
M00_L47:
       mov       r11,7FFBB4990F40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       mov       rcx,[rbp-78]
       mov       r11,7FFBB4990F48
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L45
M00_L48:
       mov       ecx,[rcx+8]
       call      qword ptr [7FFBB5285230]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L51:
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       jne       near ptr M00_L89
M00_L52:
       mov       rdx,[rbp-40]
       cmp       [rdx+8],r14d
       jne       near ptr M00_L90
M00_L53:
       mov       rsi,[rbp-40]
       test      rsi,rsi
       je        near ptr M00_L92
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult<System.Collections.ObjectModel.ReadOnlyCollection<System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r12,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],rcx
       mov       byte ptr [r12+1D],0
       mov       rcx,17F184004E0
       mov       rax,[rcx]
       mov       [rbp-0A0],rax
       mov       rdx,[rax+18]
       mov       [rbp-0B0],rdx
       cmp       [rdx],dl
       mov       rcx,rdx
       call      qword ptr [7FFBB5146F10]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       [rbp-5C],eax
       mov       r8,[rbp-0B0]
       mov       [rbp-0C0],r8
       mov       [rbp-58],eax
       mov       r10,[rbp-0A0]
       mov       r9,[r10+10]
       mov       ecx,[r9+10]
       mov       edx,ecx
       mov       [rbp-4C],edx
       test      edx,edx
       jg        short M00_L54
       mov       r11d,[r10+20]
       mov       [rbp-50],r11d
       jmp       short M00_L55
M00_L54:
       mov       [rbp-0B8],r9
       lea       r11d,[rdx-1]
       cmp       r11d,ecx
       jae       near ptr M00_L63
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+8]
       cmp       r11d,[rcx+8]
       jae       near ptr M00_L64
       mov       r11d,[rcx+r11*4+10]
       mov       [rbp-50],r11d
       mov       edx,[rbp-4C]
M00_L55:
       mov       [rbp-0A8],r9
       mov       rcx,[r10+8]
       mov       r11d,[rcx+38]
       sub       r11d,[rcx+40]
       inc       r11d
       cmp       [r9],r9b
       test      r11d,r11d
       jl        near ptr M00_L62
       mov       rcx,[r9+8]
       cmp       [rcx+8],r11d
       jl        short M00_L56
       jmp       short M00_L58
M00_L56:
       mov       rcx,[r9+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L59
       mov       ecx,4
M00_L57:
       mov       [rbp-54],ecx
       mov       ecx,7FFFFFC7
       mov       [rbp-0C4],ecx
       mov       ecx,[rbp-54]
       cmp       ecx,7FFFFFC7
       cmova     ecx,[rbp-0C4]
       cmp       ecx,r11d
       cmovl     ecx,r11d
       mov       [rbp-54],ecx
       mov       rcx,r9
       mov       edx,[rbp-54]
       call      qword ptr [7FFBB5146F88]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].set_Capacity(Int32)
       mov       r9,[rbp-0A8]
M00_L58:
       mov       rcx,[r9+8]
       mov       ecx,[rcx+8]
       mov       r10,[rbp-0A0]
       mov       rcx,[r10+8]
       cmp       [rcx],cl
       mov       edx,[rbp-50]
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFBB5146FA0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].TryInsert(Int32, Boolean, System.Collections.Generic.InsertionBehavior)
       mov       edx,[rbp-4C]
       test      edx,edx
       jle       short M00_L60
       mov       r8,[rbp-0A0]
       mov       rcx,[r8+10]
       dec       edx
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4BA6868]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L61
M00_L59:
       mov       rcx,[r9+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L57
M00_L60:
       mov       eax,[rbp-50]
       lea       ecx,[rax+1]
       mov       r8,[rbp-0A0]
       mov       [r8+20],ecx
M00_L61:
       mov       rcx,[rbp-0A0]
       inc       dword ptr [rcx+24]
       jmp       short M00_L65
M00_L62:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFBB4FD68B0]
       int       3
M00_L63:
       call      qword ptr [7FFBB51478B8]
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-5C]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5147030]; System.Threading.Lock.Exit(ThreadId)
       mov       ecx,[rbp-50]
       not       ecx
       mov       [r12+18],ecx
       mov       byte ptr [r12+1C],1
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17F184004F8
       mov       rdx,[rcx]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FFBB5146D78]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFBB5146D48]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[r14+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+20],rcx
       mov       r15d,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,r15d
       call      qword ptr [7FFBB4F6F8B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r12d,r12d
       test      r15d,r15d
       jle       short M00_L67
       mov       rcx,offset MT_System.String[]
       cmp       [rsi],rcx
       jne       near ptr M00_L70
M00_L66:
       mov       rcx,rsi
       mov       r8d,r12d
       mov       rdx,7FFBB505F078
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5074420]; System.SZArrayHelper.get_Item[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFBB5146D18]; DotNetTips.Spargine.IO.FileHelper.ProcessFileDeletion(System.String, DotNetTips.Spargine.Core.SimpleResult`1<System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>>, System.Collections.Generic.List`1<System.String>, Boolean)
       test      eax,eax
       jne       short M00_L67
       add       r12d,1
       jo        near ptr M00_L95
       cmp       r12d,r15d
       jl        short M00_L66
M00_L67:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFBB5146D30]; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].SetValue(System.__Canon)
       mov       rcx,[r14+20]
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.String[]
       cmp       [rcx],r11
       jne       near ptr M00_L72
       mov       esi,[rcx+8]
M00_L68:
       cmp       esi,edi
       jne       near ptr M00_L93
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5095FF8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].Clear()
M00_L69:
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
M00_L70:
       mov       rcx,offset MT_System.String[]
       cmp       [rsi],rcx
       jne       near ptr M00_L91
       mov       rcx,rsi
       mov       r8d,r12d
       mov       rdx,7FFBB505F078
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5074420]; System.SZArrayHelper.get_Item[[System.__Canon, System.Private.CoreLib]](Int32)
M00_L71:
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,r13
       xor       r9d,r9d
       call      qword ptr [7FFBB5146D18]; DotNetTips.Spargine.IO.FileHelper.ProcessFileDeletion(System.String, DotNetTips.Spargine.Core.SimpleResult`1<System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>>, System.Collections.Generic.List`1<System.String>, Boolean)
       test      eax,eax
       jne       near ptr M00_L67
       add       r12d,1
       jo        near ptr M00_L95
       cmp       r12d,r15d
       jl        short M00_L70
       jmp       near ptr M00_L67
M00_L72:
       mov       r11,7FFBB4990F78
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L68
M00_L73:
       cmp       r12d,[r13+8]
       jae       near ptr M00_L94
       mov       ecx,r12d
       mov       rdx,[r13+rcx*8+10]
       mov       rax,rdx
       test      rax,rax
       je        near ptr M00_L83
       mov       [rbp-98],rax
       mov       rcx,rax
       call      00007FFC146DE040
       test      eax,eax
       jne       near ptr M00_L82
M00_L74:
       inc       r12d
       cmp       r12d,esi
       jl        short M00_L73
       jmp       near ptr M00_L38
M00_L75:
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
       mov       rcx,r12
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0FFFFFFFF
       mov       [rsi+0C],r13d
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       jmp       near ptr M00_L41
M00_L76:
       mov       ecx,[r15+8]
M00_L77:
       cmp       r13d,[r15+8]
       jae       near ptr M00_L94
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L83
       mov       rcx,r12
       call      00007FFC146DE040
       test      eax,eax
       jne       short M00_L80
M00_L78:
       inc       r13d
       cmp       r13d,r14d
       jl        short M00_L77
       jmp       near ptr M00_L16
M00_L79:
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FFBB514E5F8]
       jmp       near ptr M00_L15
M00_L80:
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FFBB514E5F8]
       jmp       short M00_L78
M00_L81:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFBB514E5F8]
       jmp       near ptr M00_L37
M00_L82:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFBB514E5F8]
       jmp       near ptr M00_L74
M00_L83:
       xor       ecx,ecx
       call      qword ptr [7FFBB514E4F0]
       int       3
M00_L84:
       mov       r11,7FFBB4990F58
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M00_L87
       jmp       near ptr M00_L39
M00_L85:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L86:
       mov       rcx,r15
       mov       r11,7FFBB4990F60
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L41
M00_L87:
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
       mov       rcx,r12
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F184006A8
       mov       rcx,[rcx]
       jmp       near ptr M00_L41
M00_L88:
       mov       rcx,r15
       mov       r11,7FFBB4990F38
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L41
M00_L89:
       mov       r11,7FFBB4990F50
       call      qword ptr [r11]
       jmp       near ptr M00_L52
M00_L90:
       lea       rdx,[rbp-40]
       mov       r8d,r14d
       mov       rcx,7FFBB5057760
       call      qword ptr [7FFBB4A4D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edi,r14d
       jmp       near ptr M00_L53
M00_L91:
       mov       rcx,rsi
       mov       edx,r12d
       mov       r11,7FFBB4990F70
       call      qword ptr [r11]
       jmp       near ptr M00_L71
M00_L92:
       mov       ecx,14
       call      qword ptr [7FFBB4C6C228]
       int       3
M00_L93:
       mov       rdx,[r14+20]
       mov       rcx,rbx
       call      qword ptr [7FFBB5146BB0]
       jmp       near ptr M00_L69
M00_L94:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L96
       mov       r12,offset MT_System.SZGenericArrayEnumerator<System.String>
       mov       rcx,[rbp-78]
       cmp       [rcx],r12
       je        short M00_L96
       mov       r11,7FFBB4990F50
       call      qword ptr [r11]
M00_L96:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       r14d,[rbp-44]
       mov       rdx,[rbp-80]
       mov       rcx,[rdx+8]
       mov       r15,[rcx+18]
       xor       r13d,r13d
       cmp       r13d,r14d
       jge       near ptr M00_L103
       test      r15,r15
       je        short M00_L99
       cmp       [r15+8],r14d
       jl        short M00_L99
       add       r15,10
       mov       r13d,r14d
M00_L97:
       mov       r12,[r15]
       test      r12,r12
       je        short M00_L101
       mov       rcx,r12
       call      00007FFC146DE040
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FFBB514E5F8]
M00_L98:
       add       r15,8
       dec       r13d
       jne       short M00_L97
       jmp       short M00_L103
M00_L99:
       cmp       r13d,[r15+8]
       jae       short M00_L102
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L101
       mov       rcx,r12
       call      00007FFC146DE040
       test      eax,eax
       je        short M00_L100
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FFBB514E5F8]
M00_L100:
       inc       r13d
       cmp       r13d,r14d
       jl        short M00_L99
       jmp       short M00_L103
M00_L101:
       xor       ecx,ecx
       call      qword ptr [7FFBB514E4F0]
       int       3
M00_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L103:
       add       rsp,28
       ret
       sub       rsp,28
       mov       esi,[rbp-48]
       mov       rdx,[rbp-88]
       mov       rcx,[rdx+8]
       mov       r13,[rcx+18]
       xor       r12d,r12d
       cmp       r12d,esi
       jge       near ptr M00_L110
       test      r13,r13
       je        short M00_L106
       cmp       [r13+8],esi
       jl        short M00_L106
       mov       r12d,10
M00_L104:
       mov       rdx,[r12+r13]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M00_L108
       mov       rcx,rbx
       call      00007FFC146DE040
       test      eax,eax
       je        short M00_L105
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFBB514E5F8]
M00_L105:
       add       r12,8
       dec       esi
       jne       short M00_L104
       jmp       short M00_L110
M00_L106:
       cmp       r12d,[r13+8]
       jae       short M00_L109
       mov       ecx,r12d
       mov       rbx,[r13+rcx*8+10]
       test      rbx,rbx
       je        short M00_L108
       mov       rcx,rbx
       call      00007FFC146DE040
       test      eax,eax
       je        short M00_L107
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFBB514E5F8]
M00_L107:
       inc       r12d
       cmp       r12d,esi
       jl        short M00_L106
       jmp       short M00_L110
M00_L108:
       xor       ecx,ecx
       call      qword ptr [7FFBB514E4F0]
       int       3
M00_L109:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L110:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-0C0],0
       je        short M00_L111
       mov       rcx,[rbp-0C0]
       mov       edx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB5147030]; System.Threading.Lock.Exit(ThreadId)
M00_L111:
       nop
       add       rsp,28
       ret
; Total bytes of code 3498
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFBB4A45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,280
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M02_L00
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       je        short M02_L02
M02_L00:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBB5146F58]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
M02_L01:
       nop
       add       rsp,28
       ret
M02_L02:
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M02_L00
       mov       [rcx+10],r8d
       mov       eax,r8d
       jmp       short M02_L01
; Total bytes of code 89
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,[rbx+10]
       cmp       edx,esi
       jl        short M03_L02
       mov       rcx,[rbx+8]
       cmp       [rcx+8],edx
       je        short M03_L01
       test      edx,edx
       jle       short M03_L03
       mov       ecx,edx
       call      qword ptr [7FFC0D896B68]
       mov       rdi,rax
       test      esi,esi
       jle       short M03_L00
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFC0D89A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
M03_L00:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
M03_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFC0D89F3E0]
       int       3
M03_L03:
       call      qword ptr [7FFC0D88A230]
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L01
; Total bytes of code 121
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].TryInsert(Int32, Boolean, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebp,r9d
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L08
M04_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M04_L09
       mov       rcx,7FFBB52C01C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r13d,esi
M04_L01:
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M04_L30
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rsp+28],rax
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M04_L10
       cmp       [r14+8],r8d
       ja        near ptr M04_L13
M04_L02:
       mov       rcx,7FFBB52C02E4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M04_L07
       mov       ebp,[rbx+38]
       cmp       [r14+8],ebp
       je        near ptr M04_L29
M04_L04:
       mov       rcx,7FFBB52C0414
       call      CORINFO_HELP_COUNTPROFILE32
       lea       ecx,[rbp+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
M04_L05:
       cmp       ebp,[r14+8]
       jae       near ptr M04_L30
       mov       ecx,ebp
       shl       rcx,4
       lea       rcx,[r14+rcx+10]
       mov       [rcx],r13d
       mov       r15,[rsp+28]
       mov       eax,[r15]
       dec       eax
       mov       [rcx+4],eax
       mov       [rcx+8],esi
       mov       [rcx+0C],dil
       inc       ebp
       mov       [r15],ebp
       inc       dword ptr [rbx+44]
       mov       rcx,7FFBB52C0418
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       mov       eax,1
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
M04_L07:
       mov       ecx,[rbx+3C]
       mov       ebp,ecx
       cmp       ecx,[r14+8]
       jae       near ptr M04_L30
       shl       rcx,4
       mov       ecx,[r14+rcx+14]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+3C],ecx
       dec       dword ptr [rbx+40]
       jmp       short M04_L05
M04_L08:
       mov       rcx,7FFBB52C00B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBB5146FB8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M04_L00
M04_L09:
       mov       rcx,7FFBB52C00B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,r15
       mov       rdx,7FFBB52C00B8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FFBB4990B48
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M04_L01
M04_L10:
       mov       [rsp+34],r8d
       mov       rcx,7FFBB52C01C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L23
M04_L11:
       mov       rcx,17F02400258
       mov       r10,[rcx]
       mov       rcx,r10
       mov       [rsp+20],rcx
       mov       rdx,7FFBB52C01C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,[rsp+20]
       mov       edx,[r14+r15+18]
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       short M04_L15
       mov       rcx,7FFBB52C02D4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L12:
       mov       r8d,[r14+r15+14]
       mov       r15d,r8d
       inc       r12d
       cmp       [r14+8],r12d
       jae       short M04_L14
       jmp       near ptr M04_L19
M04_L13:
       mov       [rsp+34],r8d
       mov       r15d,r8d
       shl       r15,4
       cmp       [r14+r15+10],r13d
       jne       short M04_L12
       jmp       short M04_L11
M04_L14:
       mov       rcx,7FFBB52C02E8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [r14+8],r15d
       mov       r8d,r15d
       ja        short M04_L13
       jmp       near ptr M04_L02
M04_L15:
       cmp       bpl,1
       jne       short M04_L17
       mov       rcx,7FFBB52C02D0
       call      CORINFO_HELP_COUNTPROFILE32
M04_L16:
       mov       eax,[rsp+34]
       shl       rax,4
       mov       [r14+rax+1C],dil
       jmp       near ptr M04_L06
M04_L17:
       cmp       bpl,2
       jne       short M04_L18
       mov       rcx,7FFBB52C02D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       call      qword ptr [7FFBB5285E18]
       int       3
M04_L18:
       mov       rcx,7FFBB52C02DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L27
M04_L19:
       mov       rcx,7FFBB52C02E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBB4C67A08]
       int       3
M04_L20:
       mov       [rsp+34],eax
       mov       ecx,eax
       shl       rcx,4
       cmp       [r14+rcx+10],r13d
       jne       short M04_L22
       mov       rcx,r15
       mov       rdx,7FFBB52C02F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       edx,[rsp+34]
       shl       rdx,4
       mov       edx,[r14+rdx+18]
       mov       r8d,esi
       mov       r11,7FFBB4990B40
       call      qword ptr [r11]
       test      eax,eax
       jne       short M04_L24
       mov       rcx,7FFBB52C03FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L22
M04_L21:
       mov       rcx,7FFBB52C0408
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L23
M04_L22:
       mov       eax,[rsp+34]
       shl       rax,4
       mov       eax,[r14+rax+14]
       mov       [rsp+34],eax
       inc       r12d
       cmp       [r14+8],r12d
       jae       short M04_L21
       jmp       short M04_L28
M04_L23:
       mov       eax,[rsp+34]
       cmp       [r14+8],eax
       ja        near ptr M04_L20
       jmp       near ptr M04_L03
M04_L24:
       cmp       bpl,1
       jne       short M04_L25
       mov       rcx,7FFBB52C03F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L16
M04_L25:
       cmp       bpl,2
       jne       short M04_L26
       mov       rcx,7FFBB52C0400
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       call      qword ptr [7FFBB5285E18]
       int       3
M04_L26:
       mov       rcx,7FFBB52C0404
       call      CORINFO_HELP_COUNTPROFILE32
M04_L27:
       xor       eax,eax
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
M04_L28:
       mov       rcx,7FFBB52C040C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBB4C67A08]
       int       3
M04_L29:
       mov       rcx,7FFBB52C0410
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFBB5285E48]
       mov       rcx,[rbx+8]
       mov       eax,r13d
       imul      rax,[rbx+30]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       short M04_L30
       mov       eax,eax
       lea       rax,[rcx+rax*4+10]
       mov       r15,rax
       mov       [rsp+28],r15
       jmp       near ptr M04_L04
M04_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1070
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       r8d,[rbx+10]
       cmp       r9d,r8d
       jae       short M05_L01
       dec       r8d
       mov       [rbx+10],r8d
       cmp       r9d,r8d
       jl        short M05_L02
M05_L00:
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M05_L01:
       call      qword ptr [7FFBB51478B8]
       int       3
M05_L02:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFBB4F6D818]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M05_L00
; Total bytes of code 76
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       push      rbx
       sub       rsp,20
       cmp       [rcx+10],edx
       jne       short M06_L02
       mov       ebx,[rcx+18]
       test      ebx,ebx
       jne       short M06_L00
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jb        short M06_L01
       call      qword ptr [7FFBB5285D58]
       jmp       short M06_L01
M06_L00:
       dec       ebx
       mov       [rcx+18],ebx
M06_L01:
       add       rsp,20
       pop       rbx
       ret
M06_L02:
       call      qword ptr [7FFBB5285D40]
       int       3
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
; 		: this(DefaultConcurrencyLevel, DefaultCapacity, true, EqualityComparer<T>.Default)
; 		  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M07_L06
M07_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M07_L07
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       xor       r14d,r14d
       mov       r15,offset MT_System.Object
M07_L01:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbp+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M07_L08
       cmp       r14d,0C
       jl        short M07_L01
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L04
M07_L02:
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M07_L05
M07_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C],1
       mov       dword ptr [rbx+18],2
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       mov       rcx,rsi
       mov       rdx,7FFBB516F920
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L02
M07_L05:
       mov       rcx,rsi
       mov       rdx,7FFBB516FB68
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L03
M07_L06:
       mov       rcx,rsi
       mov       rdx,7FFBB516F6B8
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L00
M07_L07:
       call      qword ptr [7FFBB4FDF2E8]
       mov       ecx,6955
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rsi,rax
       mov       ecx,191A
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB4A47840]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,0F32
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB4A47840]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBB5286EB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBB514F078]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 531
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]]..ctor()
; 	private readonly ConcurrentBag<T> _bag = [];
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	private readonly IEqualityComparer<T> _comparer = EqualityComparer<T>.Default;
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	private readonly ConcurrentHashSet<T> _uniqueItems = [];
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	public DistinctConcurrentBag()
; 	^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L42
M08_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M08_L43
M08_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M08_L44
M08_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       byte ptr [rsi+1D],0
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        near ptr M08_L45
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       mov       r14,[rdi+18]
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFBB5146F10]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       [rbp-90],r14
       mov       [rbp-50],eax
       mov       r14,[rdi+10]
       mov       ecx,[r14+10]
       mov       r15d,ecx
       test      r15d,r15d
       jg        short M08_L04
       mov       r13d,[rdi+20]
       jmp       short M08_L05
M08_L04:
       mov       rdx,r14
       lea       eax,[r15-1]
       cmp       eax,ecx
       jae       near ptr M08_L27
       mov       rcx,[rdx+8]
       cmp       eax,[rcx+8]
       jae       near ptr M08_L28
       mov       edx,eax
       mov       r13d,[rcx+rdx*4+10]
M08_L05:
       mov       rcx,[rdi+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       inc       edx
       cmp       [r14],r14b
       test      edx,edx
       jl        near ptr M08_L26
       mov       rcx,[r14+8]
       cmp       [rcx+8],edx
       jge       short M08_L07
       mov       rcx,[r14+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M08_L09
       mov       eax,4
M08_L06:
       mov       ecx,7FFFFFC7
       cmp       eax,7FFFFFC7
       cmova     eax,ecx
       cmp       eax,edx
       cmovl     eax,edx
       mov       rcx,r14
       mov       edx,eax
       call      qword ptr [7FFBB5146F88]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].set_Capacity(Int32)
M08_L07:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       r14,[rdi+8]
       mov       r12d,r13d
       cmp       qword ptr [r14+8],0
       jne       short M08_L08
       xor       ecx,ecx
       call      qword ptr [7FFBB4A45A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-4C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-80],rax
       movsxd    rdx,dword ptr [rbp-4C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-88],rax
       mov       dword ptr [r14+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-4C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r14+30],rax
       lea       rcx,[r14+8]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       mov       rax,[r14+10]
       mov       [rbp-68],rax
       mov       r8,[r14+18]
       mov       [rbp-70],r8
       test      r8,r8
       je        short M08_L10
       mov       rcx,r8
       mov       edx,r12d
       mov       r11,7FFBB4990E10
       call      qword ptr [r11]
       jmp       short M08_L11
M08_L09:
       mov       rax,[r14+8]
       mov       eax,[rax+8]
       add       eax,eax
       jmp       near ptr M08_L06
M08_L10:
       mov       r10d,r12d
       mov       eax,r10d
M08_L11:
       mov       [rbp-44],eax
       xor       r10d,r10d
       mov       [rbp-48],r10d
       mov       rdx,[r14+8]
       mov       ecx,eax
       imul      rcx,[r14+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M08_L28
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-78],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-70]
       test      r8,r8
       je        short M08_L14
       mov       rcx,[rbp-68]
       mov       edx,[rcx+8]
       mov       [rbp-5C],edx
       cmp       edx,r11d
       jbe       short M08_L15
M08_L12:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-58],r11
       cmp       [rcx+r11+10],eax
       jne       short M08_L13
       mov       [rbp-68],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,r13d
       mov       r11,7FFBB4990E08
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r11,[rbp-58]
       jne       near ptr M08_L25
M08_L13:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       mov       edx,[rbp-5C]
       cmp       edx,r10d
       jb        near ptr M08_L24
       cmp       edx,r11d
       mov       [rbp-5C],edx
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M08_L12
       jmp       short M08_L15
M08_L14:
       mov       rcx,[rbp-68]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       ja        short M08_L16
       mov       [rbp-5C],edx
M08_L15:
       cmp       dword ptr [r14+40],0
       jle       short M08_L18
       mov       r8d,[r14+3C]
       mov       r12d,r8d
       cmp       r8d,[rbp-5C]
       jae       near ptr M08_L28
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r14+3C],r8d
       dec       dword ptr [r14+40]
       jmp       near ptr M08_L20
M08_L16:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M08_L17
       cmp       [rcx+r11+18],r13d
       je        near ptr M08_L25
M08_L17:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-48]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M08_L24
       cmp       edx,r11d
       mov       [rbp-48],r10d
       mov       eax,[rbp-44]
       ja        short M08_L16
       mov       [rbp-5C],edx
       jmp       short M08_L15
M08_L18:
       mov       r12d,[r14+38]
       cmp       [rbp-5C],r12d
       jne       short M08_L19
       mov       ecx,[r14+38]
       call      qword ptr [7FFBB4BB5020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFBB52870D8]
       mov       r8,[r14+8]
       mov       ecx,[rbp-44]
       mov       edx,ecx
       imul      rdx,[r14+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M08_L28
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-78],r8
       mov       eax,ecx
M08_L19:
       lea       r8d,[r12+1]
       mov       [r14+38],r8d
       mov       rcx,[r14+10]
       mov       r8,rcx
       mov       rcx,r8
M08_L20:
       cmp       r12d,[rcx+8]
       jae       near ptr M08_L28
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-78]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       [r8+8],r13d
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r14+44]
       test      r15d,r15d
       jg        short M08_L21
       lea       r8d,[r13+1]
       mov       [rdi+20],r8d
       jmp       short M08_L23
M08_L21:
       mov       r14,[rdi+10]
       lea       r9d,[r15-1]
       mov       r8d,[r14+10]
       cmp       r9d,r8d
       jae       short M08_L27
       dec       r8d
       mov       [r14+10],r8d
       cmp       r9d,r8d
       jl        short M08_L29
M08_L22:
       inc       dword ptr [r14+14]
M08_L23:
       inc       dword ptr [rdi+24]
       jmp       short M08_L30
M08_L24:
       call      qword ptr [7FFBB4C67A08]
       int       3
M08_L25:
       mov       ecx,r12d
       call      qword ptr [7FFBB5285E18]
       int       3
M08_L26:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFBB4FD68B0]
       int       3
M08_L27:
       call      qword ptr [7FFBB51478B8]
       int       3
M08_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r14+8]
       mov       rcx,[r14+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFBB4F6D818]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M08_L22
M08_L30:
       mov       rcx,[rbp-90]
       mov       edx,[rbp-50]
       call      qword ptr [7FFBB5147030]; System.Threading.Lock.Exit(ThreadId)
       mov       ecx,r13d
       not       ecx
       mov       [rsi+18],ecx
       mov       byte ptr [rsi+1C],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M08_L39
M08_L31:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M08_L40
M08_L32:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M08_L41
M08_L33:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M08_L46
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       xor       r14d,r14d
       mov       r15,offset MT_System.Object
M08_L34:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M08_L47
       cmp       r14d,0C
       jl        short M08_L34
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L37
       mov       rcx,rax
M08_L35:
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M08_L38
M08_L36:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C],1
       mov       dword ptr [rbx+18],2
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
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
M08_L37:
       mov       rdx,7FFBB516F920
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L35
M08_L38:
       mov       rdx,7FFBB516FB68
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L36
M08_L39:
       mov       rcx,rdx
       mov       rdx,7FFBB516E3B0
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L31
M08_L40:
       mov       rcx,rdx
       mov       rdx,7FFBB516E950
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L32
M08_L41:
       mov       rdx,7FFBB516F6B8
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L33
M08_L42:
       mov       rcx,rdx
       mov       rdx,7FFBB516E290
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L00
M08_L43:
       mov       rdx,7FFBB52AA748
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L44:
       mov       rdx,7FFBB52AA7D8
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L02
M08_L45:
       mov       rdx,7FFBB52AA908
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L46:
       call      qword ptr [7FFBB4FDF2E8]
       mov       ecx,6955
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4A47840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFBB4D14F20
       call      qword ptr [7FFBB4C67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4A47840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB5286EB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB514F078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-90],0
       je        short M08_L48
       mov       rcx,[rbp-90]
       mov       edx,[rbp-50]
       call      qword ptr [7FFBB5147030]; System.Threading.Lock.Exit(ThreadId)
M08_L48:
       nop
       add       rsp,28
       ret
; Total bytes of code 2066
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M09_L03
       test      ebx,ebx
       je        short M09_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+50]
       test      rax,rax
       je        short M09_L02
       mov       rcx,rax
M09_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M09_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rdx,7FFBB5197100
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M09_L00
M09_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFBB4FD68B0]
       int       3
M09_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M09_L05
       jmp       short M09_L06
M09_L05:
       mov       rdx,7FFBB52D0180
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M09_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L01
; Total bytes of code 173
```
```assembly
; System.SZArrayHelper.get_Item[[System.__Canon, System.Private.CoreLib]](Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jbe       short M10_L00
       mov       eax,r8d
       mov       rax,[rcx+rax*8+10]
       add       rsp,28
       ret
M10_L00:
       call      qword ptr [7FFBB51478B8]
       int       3
; Total bytes of code 32
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.ProcessFileDeletion(System.String, DotNetTips.Spargine.Core.SimpleResult`1<System.Collections.ObjectModel.ReadOnlyCollection`1<System.String>>, System.Collections.Generic.List`1<System.String>, Boolean)
; 		if (TryDeleteFile(fileName, out var exception))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			filesDeleted.Add(fileName);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		if (exception is null)
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		result.AddException(exception);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return stopOnFirstError;
; 		^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FFBB5147198]; DotNetTips.Spargine.IO.FileHelper.TryDeleteFile(System.String, System.Exception ByRef)
       test      eax,eax
       je        short M11_L02
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M11_L01
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L00:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBB4BBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M11_L00
M11_L02:
       cmp       qword ptr [rsp+20],0
       je        short M11_L00
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB51471B0]
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Core.SimpleResult`1[[System.__Canon, System.Private.CoreLib]].SetValue(System.__Canon)
; 		this._value = value.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this._valueSet = true;
; 		^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       je        short M12_L00
       mov       rax,[rbp-28]
       mov       [rbp-18],rax
       jmp       short M12_L01
M12_L00:
       mov       rcx,[rbp-20]
       mov       rdx,7FFBB5190268
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-18],rax
M12_L01:
       mov       rax,1BF973A4EE8
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-10]
       mov       r9,1BF973A0008
       call      qword ptr [7FFBB4DCE6B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       byte ptr [rax+28],1
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 178
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       xor       edx,edx
       mov       [rbp-38],edx
       lea       rdx,[rbp-38]
       call      qword ptr [7FFBB5146BC8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].AcquireAllLocks(Int32 ByRef)
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB5147228]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].AreAllBucketsEmpty()
       test      eax,eax
       jne       near ptr M13_L04
       mov       rcx,7FFBB52E0868
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+0A8]
       test      rsi,rsi
       je        near ptr M13_L02
M13_L00:
       mov       rcx,[rbp+10]
       mov       ecx,[rcx+14]
       call      qword ptr [7FFBB4C6DB60]; System.Collections.HashHelpers.GetPrime(Int32)
       movsxd    rdx,eax
       mov       rcx,rsi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rdi,[rbx+18]
       mov       rdx,[rbx+20]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       test      rax,rax
       je        near ptr M13_L03
M13_L01:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rbx,[rbx+8]
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+28],rax
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       mov       rcx,[r15+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       jmp       short M13_L04
M13_L02:
       mov       rcx,rdx
       mov       rdx,7FFBB52D1E80
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M13_L00
M13_L03:
       mov       rcx,rdx
       mov       rdx,7FFBB52D1E98
       call      qword ptr [7FFBB4A4C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M13_L01
M13_L04:
       mov       rcx,7FFBB52E086C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-38]
       call      qword ptr [7FFBB5146C40]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].ReleaseLocks(Int32)
       mov       rcx,7FFBB52E0870
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,7FFBB52E086C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       edx,[rbp-38]
       call      qword ptr [7FFBB5146C40]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.Byte, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 479
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M14_L03
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M14_L04
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M14_L02
       call      qword ptr [7FFC0D88ED58]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFC0D889088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       jbe       short M14_L00
       call      qword ptr [7FFC0D89A668]
       jmp       short M14_L01
M14_L00:
       call      qword ptr [7FFC0D89A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L05
M14_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFC0D888FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
M14_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M14_L03:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC0D89F3E0]
       int       3
M14_L04:
       call      qword ptr [7FFC0D88ED58]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFC0D889088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC0D888FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M14_L02
M14_L05:
       call      qword ptr [7FFC0D889040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L01
; Total bytes of code 195
```

