## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagBenchmark.Add()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rdx,rcx
       mov       rbx,[rdx+1B0]
       mov       rcx,20D5CC01EB8
       mov       rsi,[rcx]
       mov       r14,[rsi+20]
       test      r14,r14
       je        near ptr M00_L52
M00_L01:
       test      rbx,rbx
       je        near ptr M00_L53
       test      r14,r14
       je        near ptr M00_L54
       mov       [rbp-168],r14
       cmp       byte ptr [r14+119],2
       jne       near ptr M00_L55
M00_L02:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-48]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF97667DA70]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0D
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r13,[rcx+68]
       test      r13,r13
       je        near ptr M00_L56
M00_L03:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M00_L04
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,24DF1EA6D78
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L04:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L10
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L58
       mov       rcx,20D5CC01EF8
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9766643A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L05:
       mov       [rbp-60],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-170],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-3C]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r13+7C],8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L09
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L06:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L59
       mov       r15,24DF1EA1718
M00_L07:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L08
       mov       dword ptr [r13+78],3E8
M00_L08:
       mov       [rbp-178],r13
       jmp       near ptr M00_L16
M00_L09:
       mov       eax,2
       jmp       short M00_L06
M00_L10:
       mov       rcx,[rax+8]
       mov       [rbp-170],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-170]
       cmp       [rcx],cl
       mov       rcx,[rbp-170]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L14
M00_L11:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-3C]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r13+7C],8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L15
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L12:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L57
       mov       rsi,24DF1EA1718
M00_L13:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L08
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L08
M00_L14:
       mov       edx,r15d
       call      qword ptr [7FF97667DB00]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L11
M00_L15:
       mov       eax,2
       jmp       short M00_L12
M00_L16:
       mov       [rbp-68],rbx
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L20
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        short M00_L17
       cmp       qword ptr [rbp-68],0
       je        short M00_L17
       mov       rcx,[r14+0B8]
       lea       r8,[rbp-110]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF97667EAD8]; System.Text.Json.JsonSerializerOptions.TryGetPolymorphicTypeInfoForRootType(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo ByRef)
       test      eax,eax
       jne       near ptr M00_L19
M00_L17:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-108],ymm0
       vmovdqu   ymmword ptr [rbp-0E8],ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   ymmword ptr [rbp-88],ymm0
       mov       [rbp-0A0],r14
       mov       rcx,[r14+0D0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx+0C8]
       mov       [rbp-78],rcx
       mov       byte ptr [rbp-0BA],0
       mov       byte ptr [rbp-0B9],0
       mov       rsi,[r14+0B8]
       cmp       dword ptr [rsi+8C],0
       jne       near ptr M00_L26
M00_L18:
       lea       rcx,[rbp-108]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-68]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF97667FFD8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       jmp       short M00_L21
M00_L19:
       mov       rcx,[rbp-110]
       mov       rdx,r13
       mov       r8,[rbp-68]
       mov       rax,[rbp-110]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M00_L22
M00_L20:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M00_L21:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF97667E3A0]; System.Text.Json.Utf8JsonWriter.Flush()
M00_L22:
       xor       ecx,ecx
       mov       [rbp-110],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-170]
       cmp       [rcx],cl
       mov       rcx,[rbp-170]
       add       rcx,18
       mov       rax,[rcx]
       mov       edx,[rcx+8]
       mov       r8d,edx
       mov       ecx,[rcx+0C]
       sub       ecx,edx
       test      rax,rax
       je        short M00_L23
       mov       edx,r8d
       mov       r10d,ecx
       add       rdx,r10
       mov       r10d,[rax+8]
       cmp       rdx,r10
       ja        short M00_L25
       mov       r8d,r8d
       lea       rax,[rax+r8+10]
       jmp       short M00_L24
M00_L23:
       or        r8d,ecx
       jne       short M00_L25
       xor       eax,eax
       xor       ecx,ecx
M00_L24:
       mov       [rbp-150],rax
       mov       [rbp-148],ecx
       lea       rcx,[rbp-150]
       call      qword ptr [7FF9764F5FE0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-180],rax
       jmp       short M00_L27
M00_L25:
       call      qword ptr [7FF97614F1B0]
       int       3
M00_L26:
       mov       rcx,[rsi+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-0E8],rax
       cmp       dword ptr [rsi+8C],2
       jne       near ptr M00_L18
       mov       rcx,[r14+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M00_L18
       mov       rcx,[rbp-0E8]
       mov       rdx,rbx
       mov       rax,[rbp-0E8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M00_L18
M00_L27:
       call      M00_L70
       nop
       cmp       qword ptr [rbp-180],0
       je        near ptr M00_L60
       mov       rcx,[rbp-168]
       cmp       byte ptr [rcx+119],2
       jne       near ptr M00_L61
M00_L28:
       mov       rdx,[rbp-180]
       lea       r8,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rbp-160],r8
       mov       [rbp-158],edx
       lea       rdx,[rbp-160]
       mov       r8,[rbp-168]
       mov       rcx,7FF9766B38E0
       call      qword ptr [7FF97667E7C0]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbx,rax
       mov       esi,[rbx+10]
       test      esi,esi
       je        near ptr M00_L62
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rbx,[rbx+8]
       test      rbx,rbx
       je        near ptr M00_L66
       mov       rcx,[rbx]
       cmp       rcx,[rdi]
       jne       near ptr M00_L67
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L67
       cmp       esi,[rbx+8]
       ja        near ptr M00_L67
       cmp       esi,[rdi+8]
       ja        near ptr M00_L67
       mov       r8d,esi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rbx+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L65
       cmp       r8,4000
       ja        near ptr M00_L64
       mov       rcx,rax
       call      00007FF9D5B62CC0
       cmp       dword ptr [7FF9D5ECF778],0
       jne       near ptr M00_L63
M00_L29:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
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
       mov       rcx,20D5CC02878
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF9766E5248]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       r12d,eax
       mov       [rbp-1B8],r13
       mov       [rbp-13C],r12d
       mov       rax,[r15+10]
       mov       ecx,[rax+10]
       mov       edx,ecx
       mov       [rbp-12C],edx
       test      edx,edx
       jg        short M00_L30
       mov       r8d,[r15+20]
       jmp       short M00_L31
M00_L30:
       mov       r8,rax
       lea       r10d,[rdx-1]
       cmp       r10d,ecx
       jae       near ptr M00_L39
       mov       rcx,[r8+8]
       cmp       r10d,[rcx+8]
       jae       near ptr M00_L40
       mov       r8d,r10d
       mov       r8d,[rcx+r8*4+10]
       mov       [rbp-130],r8d
       mov       edx,[rbp-12C]
       mov       r8d,[rbp-130]
M00_L31:
       mov       [rbp-1B0],rax
       mov       rcx,[r15+8]
       mov       r10d,[rcx+38]
       sub       r10d,[rcx+40]
       inc       r10d
       cmp       [rax],al
       test      r10d,r10d
       jl        near ptr M00_L38
       mov       rcx,[rax+8]
       cmp       [rcx+8],r10d
       jl        short M00_L32
       jmp       short M00_L34
M00_L32:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L35
       mov       r9d,4
       mov       [rbp-130],r8d
M00_L33:
       mov       ecx,7FFFFFC7
       cmp       r9d,7FFFFFC7
       cmova     r9d,ecx
       cmp       r9d,r10d
       cmovl     r9d,r10d
       mov       rcx,rax
       mov       edx,r9d
       call      qword ptr [7FF9766E52C0]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].set_Capacity(Int32)
       mov       rax,[rbp-1B0]
       mov       r8d,[rbp-130]
M00_L34:
       mov       rcx,[rax+8]
       mov       ecx,[rcx+8]
       mov       rcx,[r15+8]
       cmp       [rcx],cl
       mov       [rbp-130],r8d
       mov       edx,r8d
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF9766E52D8]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].TryInsert(Int32, Boolean, System.Collections.Generic.InsertionBehavior)
       mov       edx,[rbp-12C]
       test      edx,edx
       jle       short M00_L36
       mov       rcx,[r15+10]
       dec       edx
       cmp       [rcx],ecx
       call      qword ptr [7FF976193810]; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L37
M00_L35:
       mov       r9,[rax+8]
       mov       r9d,[r9+8]
       add       r9d,r9d
       mov       [rbp-130],r8d
       jmp       near ptr M00_L33
M00_L36:
       mov       eax,[rbp-130]
       lea       ecx,[rax+1]
       mov       [r15+20],ecx
M00_L37:
       inc       dword ptr [r15+24]
       jmp       short M00_L41
M00_L38:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9764F5E00]
       int       3
M00_L39:
       call      qword ptr [7FF9766E4A80]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r13
       mov       edx,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FF9766E5368]; System.Threading.Lock.Exit(ThreadId)
       mov       r15d,[rbp-130]
       mov       ecx,r15d
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9766E5110]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,7FF97677A070
       call      qword ptr [7FF97620CB10]; System.SZArrayHelper.GetEnumerator[[System.__Canon, System.Private.CoreLib]]()
       mov       rsi,rax
       mov       [rbp-1A8],rsi
       cmp       qword ptr [rbp-1A8],0
       je        short M00_L47
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-1A8]
       cmp       [rdi],rsi
       jne       short M00_L47
M00_L42:
       mov       rcx,rdi
       call      qword ptr [7FF97623E030]; System.SZGenericArrayEnumeratorBase.MoveNext()
       test      eax,eax
       je        near ptr M00_L50
       mov       rcx,rdi
       call      qword ptr [7FF97623E418]; System.SZGenericArrayEnumerator`1[[System.__Canon, System.Private.CoreLib]].get_Current()
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF976363150]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M00_L42
M00_L43:
       cmp       [rdi],rsi
       jne       short M00_L49
       mov       rcx,rdi
       call      qword ptr [7FF97623E418]; System.SZGenericArrayEnumerator`1[[System.__Canon, System.Private.CoreLib]].get_Current()
M00_L44:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF976363150]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L45:
       cmp       [rdi],rsi
       jne       short M00_L48
       mov       rcx,rdi
       call      qword ptr [7FF97623E030]; System.SZGenericArrayEnumeratorBase.MoveNext()
M00_L46:
       test      eax,eax
       jne       short M00_L43
       jmp       short M00_L50
M00_L47:
       mov       rdi,[rbp-1A8]
       cmp       [rdi],edi
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       jmp       short M00_L45
M00_L48:
       mov       rcx,rdi
       mov       r11,7FF975EB1318
       call      qword ptr [r11]
       jmp       short M00_L46
M00_L49:
       mov       rcx,rdi
       mov       r11,7FF975EB1320
       call      qword ptr [r11]
       jmp       short M00_L44
M00_L50:
       cmp       [rdi],rsi
       jne       near ptr M00_L69
M00_L51:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+48]
       mov       rcx,rbx
       call      qword ptr [7FF976363150]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+50]
       mov       rcx,rbx
       call      qword ptr [7FF976363150]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       [rbp-138],rbx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+60]
       lea       r8,[rbp-138]
       mov       rdx,7FF9767C3070
       cmp       [rcx],ecx
       call      qword ptr [7FF9766ED3E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L52:
       mov       rcx,rsi
       call      qword ptr [7FF9765C7DB0]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rcx,rax
       mov       rdx,24DF1EB03B0
       cmp       [rcx],ecx
       call      qword ptr [7FF9765C7DC8]; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       mov       rdx,rax
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L53:
       call      qword ptr [7FF9764FE6E8]
       mov       ecx,886
       mov       rdx,7FF976364DF8
       call      qword ptr [7FF975F6F210]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF976364DF8
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9766E4348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9766E4360]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FF9764FE6E8]
       mov       ecx,874
       mov       rdx,7FF976364DF8
       call      qword ptr [7FF975F6F210]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF976364DF8
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9766E4348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9766E4360]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,r14
       call      qword ptr [7FF976476A00]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L02
M00_L56:
       mov       ecx,0D
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L57:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20D5CC02C48
       mov       rsi,[rcx]
       jmp       near ptr M00_L13
M00_L58:
       mov       rax,24DF1EA6D78
       jmp       near ptr M00_L05
M00_L59:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20D5CC02C48
       mov       r15,[rcx]
       jmp       near ptr M00_L07
M00_L60:
       mov       ecx,3888
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976804708]
       int       3
M00_L61:
       mov       rcx,[rbp-168]
       call      qword ptr [7FF976476A00]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L28
M00_L62:
       mov       rcx,20D5CC01F20
       mov       rdi,[rcx]
       jmp       near ptr M00_L29
M00_L63:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L29
M00_L64:
       mov       rcx,rax
       call      qword ptr [7FF9764FE0A0]
       jmp       near ptr M00_L29
M00_L65:
       mov       rcx,rax
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L29
M00_L66:
       xor       r14d,r14d
       jmp       short M00_L68
M00_L67:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF976806E80]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M00_L68:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF976806E80]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       edx,r14d
       mov       r8,rdi
       call      qword ptr [7FF976804318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L29
M00_L69:
       mov       rcx,rdi
       mov       r11,7FF975EB1328
       call      qword ptr [r11]
       jmp       near ptr M00_L51
M00_L70:
       sub       rsp,38
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0D
       jle       short M00_L71
       mov       rcx,[rcx+240]
       mov       r13,[rcx+68]
       test      r13,r13
       jne       short M00_L72
M00_L71:
       mov       ecx,0D
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M00_L72:
       mov       rbx,[r13+10]
       xor       ecx,ecx
       mov       rax,[rbp-178]
       mov       [rax+34],ecx
       mov       [rax+20],rcx
       mov       [rax+40],rcx
       mov       [rax+48],rcx
       mov       byte ptr [rax+38],0
       mov       word ptr [rax+39],0
       mov       [rax+28],ecx
       mov       [rax+50],rcx
       mov       [rax+58],rcx
       mov       [rax+60],rcx
       mov       [rax+68],cx
       mov       [rax+6A],cl
       mov       byte ptr [rax+3B],0
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       [rax+8],rcx
       mov       rcx,[rbp-170]
       cmp       [rcx],cl
       mov       rcx,[rbp-170]
       add       rcx,18
       xor       eax,eax
       mov       [rcx+8],eax
       mov       [rcx+0C],eax
       mov       rsi,[rcx]
       mov       rax,24DF1EA6D78
       mov       [rcx],rax
       cmp       byte ptr [rcx+10],0
       je        near ptr M00_L91
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L91
       mov       rcx,20D5CC01EF8
       mov       r14,[rcx]
       lea       ecx,[rdi-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       short M00_L73
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       jne       short M00_L74
M00_L73:
       mov       ecx,9
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M00_L74:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L75
       mov       rcx,r14
       call      qword ptr [7FF9765CF870]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M00_L75:
       xor       r13d,r13d
       mov       r12d,1
       mov       ecx,[rax+8]
       cmp       ecx,r15d
       jbe       near ptr M00_L87
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       edi,ecx
       je        short M00_L76
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF976674348]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9762E79A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L76:
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp-190],rax
       mov       r8,[rax]
       mov       [rbp-198],r8
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-190]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-198],0
       je        near ptr M00_L87
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L88
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M00_L77
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF976674B10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       mov       r8,rax
M00_L77:
       mov       r12,[r8+8]
       call      qword ptr [7FF976674918]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M00_L84
M00_L78:
       cmp       eax,[r12+8]
       jae       near ptr M00_L88
       mov       [rbp-11C],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-1A0],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-124],r10d
       mov       rcx,r8
       call      qword ptr [7FF97647DAD0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1A0]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-128],r8d
       cmp       [rcx+8],r8d
       jbe       short M00_L80
       test      r8d,r8d
       jne       short M00_L81
       xor       edx,edx
       mov       [rax+14],edx
M00_L79:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp-198]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-128]
       inc       ecx
       mov       rax,[rbp-1A0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-124],1
M00_L80:
       mov       rcx,rax
       call      qword ptr [7FF975F66820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-124],0
       je        short M00_L82
       jmp       short M00_L85
M00_L81:
       jmp       short M00_L79
M00_L82:
       mov       eax,[rbp-11C]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M00_L83
       xor       ecx,ecx
M00_L83:
       mov       edx,[rbp-120]
       inc       edx
       mov       eax,ecx
M00_L84:
       mov       [rbp-120],edx
       cmp       [r12+8],edx
       jg        near ptr M00_L78
       jmp       short M00_L86
M00_L85:
       mov       r12d,1
       jmp       short M00_L87
M00_L86:
       xor       r12d,r12d
M00_L87:
       mov       rcx,20D5CC00C90
       mov       rax,[rcx]
       mov       [rbp-188],rax
       cmp       byte ptr [rax+9D],0
       je        near ptr M00_L91
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-114],eax
       mov       [rbp-118],edi
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-188]
       mov       r8d,[rbp-114]
       mov       r9d,[rbp-118]
       mov       edx,3
       call      qword ptr [7FF97680DC08]
       test      r12d,r13d
       jne       short M00_L91
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M00_L89
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M00_L90
M00_L88:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L89:
       mov       ecx,r15d
       xor       edx,edx
M00_L90:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rbp-188]
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FF9766743C0]
M00_L91:
       dec       dword ptr [rbx+18]
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-1A8],0
       je        short M00_L92
       mov       rsi,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,[rbp-1A8]
       cmp       [rdi],rsi
       je        short M00_L92
       mov       rcx,rdi
       mov       r11,7FF975EB1328
       call      qword ptr [r11]
M00_L92:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-1B8],0
       je        short M00_L93
       mov       rcx,[rbp-1B8]
       mov       edx,[rbp-13C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9766E5368]; System.Threading.Lock.Exit(ThreadId)
M00_L93:
       nop
       add       rsp,38
       ret
; Total bytes of code 4216
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M01_L11
       and       esi,0FFFFFFF7
M01_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M01_L10
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M01_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M01_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M01_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M01_L14
M01_L02:
       mov       rcx,24DF1EB0D30
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],1
       jne       short M01_L03
       cmp       word ptr [r8+0C],0A
       je        short M01_L04
M01_L03:
       mov       rcx,24DF1EA1718
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],2
       jne       short M01_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L08
M01_L04:
       mov       rcx,24DF1EA1718
       cmp       r8,rcx
       je        short M01_L05
       cmp       dword ptr [r8+8],2
       jne       short M01_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L09
M01_L05:
       and       esi,0FFFFFFFB
M01_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       r8d,2
       jmp       near ptr M01_L01
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF97680F588]
       int       3
M01_L09:
       or        esi,4
       jmp       short M01_L06
M01_L10:
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF97680F570]
       int       3
M01_L11:
       cmp       edx,9
       je        short M01_L12
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF97680F558]
       int       3
M01_L12:
       or        esi,8
       jmp       near ptr M01_L00
M01_L13:
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976805680]
       int       3
M01_L14:
       mov       r8,24DF1EA1718
       mov       [rcx+50],r8
       jmp       near ptr M01_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,20D5CC00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       short M02_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M02_L02
M02_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M02_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M02_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M02_L03
M02_L01:
       mov       rax,r14
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
M02_L02:
       mov       ecx,9
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M02_L00
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9765CFED0]
       jmp       short M02_L01
M02_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M02_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M02_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF976674918]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M02_L08
M02_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M02_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF97647DAD0]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M02_L06:
       mov       rcx,r13
       call      qword ptr [7FF975F66820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M02_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M02_L07
       xor       ebx,ebx
M02_L07:
       inc       r15d
M02_L08:
       cmp       [r14+8],r15d
       jg        short M02_L05
       jmp       short M02_L10
M02_L09:
       mov       r14,r12
       jmp       short M02_L11
M02_L10:
       xor       r14d,r14d
M02_L11:
       test      r14,r14
       je        short M02_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9765CFED0]
       jmp       near ptr M02_L01
M02_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L15
M02_L13:
       test      ebx,ebx
       jne       short M02_L14
       mov       rax,24DF1EA6D78
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
M02_L14:
       mov       ecx,ebx
       mov       rdx,24DF1EA6F28
       call      qword ptr [7FF97620D950]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L15:
       cmp       ebx,800
       jge       short M02_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L17
M02_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9765CF5A0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M02_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9765CFED0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF9765CFF18]
       jmp       near ptr M02_L01
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       r8,[rbx]
       cmp       dword ptr [r8+8],0
       je        near ptr M03_L08
       mov       eax,[rbx+8]
       mov       ecx,[r8+8]
       mov       esi,[rbx+0C]
       sub       ecx,esi
       add       ecx,eax
       cmp       edx,ecx
       jle       near ptr M03_L09
       sub       esi,eax
       add       edx,esi
       cmp       edx,7FFFFFC7
       ja        near ptr M03_L10
       mov       ecx,[r8+8]
       add       ecx,ecx
       mov       eax,7FFFFFC7
       cmp       rcx,7FFFFFC7
       cmovl     rax,rcx
       cmp       edx,eax
       cmovl     edx,eax
       cmp       byte ptr [rbx+10],0
       je        near ptr M03_L11
       mov       rcx,20D5CC01EF8
       mov       rcx,[rcx]
       call      qword ptr [7FF9766643A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M03_L00:
       mov       rdi,[rbx]
       mov       ebp,[rbx+0C]
       mov       r14d,[rbx+8]
       sub       ebp,r14d
       je        near ptr M03_L03
       test      rdi,rdi
       je        near ptr M03_L12
       test      rsi,rsi
       je        near ptr M03_L13
       mov       r15d,[rdi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rdi],rcx
       jne       near ptr M03_L14
M03_L01:
       mov       r13,r15
       cmp       rdi,rsi
       je        short M03_L02
       mov       r13d,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rsi],rcx
       jne       near ptr M03_L16
M03_L02:
       test      r14d,r14d
       jl        near ptr M03_L18
       test      ebp,ebp
       jl        near ptr M03_L19
       mov       r8d,ebp
       mov       edx,r14d
       lea       rcx,[rdx+r8]
       cmp       rcx,r15
       ja        near ptr M03_L20
       cmp       r13,r8
       jb        near ptr M03_L20
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+rdx+10]
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M03_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M03_L07
       mov       rcx,20D5CC01EF8
       mov       rsi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M03_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M03_L21
M03_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M03_L22
M03_L05:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M03_L06
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       ebx,ecx
       jne       near ptr M03_L23
       mov       ecx,ebp
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       near ptr M03_L24
M03_L06:
       mov       rcx,20D5CC00C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M03_L36
M03_L07:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L08:
       mov       rcx,20D5CC01EF8
       mov       rcx,[rcx]
       call      qword ptr [7FF9766643A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L07
M03_L09:
       mov       edx,esi
       sub       edx,eax
       mov       [rsp+20],edx
       mov       edx,eax
       mov       rcx,r8
       xor       r9d,r9d
       call      qword ptr [7FF976205F80]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       jmp       short M03_L07
M03_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF976805068]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,257
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976804708]
       int       3
M03_L13:
       mov       ecx,25F
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976804708]
       int       3
M03_L14:
       mov       rcx,rdi
       call      00007FF9D5B3F400
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M03_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF976806FE8]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9762E79A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L15:
       mov       rcx,[rdi]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M03_L01
M03_L16:
       mov       rcx,rsi
       call      00007FF9D5B3F400
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M03_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF976806FE8]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF9762E79A8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M03_L17:
       mov       rcx,[rsi]
       movzx     ecx,word ptr [rcx]
       imul      r13,rcx
       jmp       near ptr M03_L02
M03_L18:
       mov       ecx,267
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9768046D8]
       int       3
M03_L19:
       mov       ecx,28F
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF9768046D8]
       int       3
M03_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF976807000]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9762E5AB8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
       mov       ecx,9
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L04
M03_L22:
       mov       rcx,rsi
       call      qword ptr [7FF9765CF870]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M03_L05
M03_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF976674348]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9762E79A8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L24:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L39
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L25
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FF976674B10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
M03_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FF976674918]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       jmp       near ptr M03_L32
M03_L26:
       cmp       r13d,[r15+8]
       jae       near ptr M03_L39
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF97647DAD0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M03_L28
       test      r8d,r8d
       jne       short M03_L29
       xor       edx,edx
       mov       [rax+14],edx
M03_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M03_L28:
       mov       rcx,rax
       call      qword ptr [7FF975F66820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M03_L30
       jmp       short M03_L33
M03_L29:
       jmp       short M03_L27
M03_L30:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M03_L31
       xor       r13d,r13d
M03_L31:
       mov       eax,[rsp+40]
       inc       eax
M03_L32:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M03_L26
       jmp       short M03_L34
M03_L33:
       mov       r15d,1
       jmp       short M03_L35
M03_L34:
       xor       r15d,r15d
M03_L35:
       jmp       near ptr M03_L06
M03_L36:
       mov       rcx,rdi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF97680DC08]
       test      r15d,r14d
       jne       near ptr M03_L07
       mov       rcx,rdi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M03_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M03_L38
M03_L37:
       mov       ecx,ebp
       xor       edx,edx
M03_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9766743C0]
       jmp       near ptr M03_L07
M03_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1552
```
```assembly
; System.Text.Json.JsonSerializerOptions.TryGetPolymorphicTypeInfoForRootType(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,r8
       mov       rcx,rdx
       call      qword ptr [7FFA1BF5ADB0]; Precode of System.Object.GetType()
       mov       rdi,rax
       call      qword ptr [7FFA1BF585C0]
       cmp       [rax],rdi
       je        short M04_L04
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFA1BF5E450]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoForRootType(System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA1BF58280]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rsi,[rbx]
       cmp       byte ptr [rsi+11A],0
       je        short M04_L02
M04_L00:
       mov       rdx,[rsi+0F8]
       test      rdx,rdx
       jne       short M04_L03
M04_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       call      qword ptr [7FFA1BF5F030]
       lea       rcx,[rsi+0F8]
       mov       rdx,rax
       call      qword ptr [7FFA1BF58278]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+11A],1
       jmp       short M04_L00
M04_L03:
       mov       rcx,rbx
       call      qword ptr [7FFA1BF58280]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L01
M04_L04:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 161
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rax,[rbp+30]
       mov       [rsp+20],rax
       call      qword ptr [7FFA1BF5FC88]; Precode of System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].TryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbp+30]
       cmp       byte ptr [rax+4F],0
       jne       short M05_L00
       mov       rcx,rax
       call      qword ptr [7FFA1BF5E660]
M05_L00:
       mov       rcx,rbx
       call      qword ptr [7FFA1BF5A5F0]
       test      rax,rax
       jne       short M05_L02
       mov       rcx,rbx
       call      qword ptr [7FFA1BF5A648]
       mov       rsi,rax
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFA1BF5D4B0]
       test      rax,rax
       jne       near ptr M05_L04
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFA1BF5CF78]
       jmp       near ptr M05_L04
M05_L01:
       mov       rcx,rbx
       call      qword ptr [7FFA1BF5A5F8]
       test      rax,rax
       je        short M05_L04
       mov       rcx,rbx
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rdx,[rdx]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M05_L04
       jmp       short M05_L03
M05_L02:
       mov       rcx,rbx
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rdx,[rdx]
       call      qword ptr [7FFA1BF5ADB8]; Precode of System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M05_L04
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA1BF5CF70]
       jmp       short M05_L04
M05_L03:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA1BF5CFC0]
M05_L04:
       call      qword ptr [7FFA1BF58258]; CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 262
```
```assembly
; System.Text.Json.Utf8JsonWriter.Flush()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M06_L00
       cmp       qword ptr [rbx+8],0
       je        short M06_L03
M06_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M06_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M06_L06
       add       rcx,18
       add       [rcx+0C],edx
M06_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M06_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M06_L03:
       call      qword ptr [7FF97680EAA8]
       int       3
M06_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M06_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9768A3B30]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF97680EAD8]
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       rcx,[rbx+18]
       movsxd    rcx,dword ptr [rcx+10]
       add       [rbx+20],rcx
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF97680EAF0]
M06_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M06_L02
M06_L06:
       mov       r11,7FF975EB12A0
       call      qword ptr [r11]
       jmp       near ptr M06_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,20D5CC013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M07_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF97614CD08]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M07_L05
M07_L00:
       test      r14d,r14d
       je        near ptr M07_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF9D5BBAFA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M07_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M07_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF97614CD38]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M07_L08
M07_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M07_L03
M07_L02:
       mov       r15,24DF1EA0008
M07_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF9764FE0B8]
       int       3
M07_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF9766EF948]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF9766EF960]
       int       3
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF9764FE0B8]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF9764F5E00]
       int       3
M07_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF9764FE0D0]
       jmp       near ptr M07_L01
M07_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF9766EF978]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M08_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M08_L00
       mov       rax,7DE8B4D50DDB
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M08_L15
       cmp       edi,15555555
       jg        near ptr M08_L16
       mov       rcx,20D5CC01EF8
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,20D5CC00C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M08_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+48]
       test      rdx,rdx
       je        near ptr M08_L17
M08_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M08_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M08_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M08_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M08_L18
M08_L02:
       mov       [rbp+38],r8
M08_L03:
       test      r8,r8
       je        near ptr M08_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M08_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FF97637C0F0]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M08_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M08_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M08_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+40],r14
       mov       [rbp+48],eax
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF9764F5650]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M08_L10
M08_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M08_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M08_L11
       xor       r9d,r9d
M08_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9764F56E0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M08_L13
M08_L07:
       call      qword ptr [7FF97614F1B0]
       int       3
M08_L08:
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976805668]
       int       3
M08_L09:
       mov       ecx,38A0
       mov       rdx,7FF97639DD30
       call      qword ptr [7FF975F6F210]
       mov       rcx,rax
       call      qword ptr [7FF976805680]
       int       3
M08_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M08_L05
M08_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M08_L06
M08_L12:
       mov       r9d,1
       jmp       near ptr M08_L06
M08_L13:
       call      M08_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,7DE8B4D50DDB
       cmp       [rbp],r8
       je        short M08_L14
       call      CORINFO_HELP_FAIL_FAST
M08_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M08_L04
M08_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FF976377540]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M08_L03
M08_L17:
       mov       ecx,9
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF9765CFED0]
       mov       r8,r13
       jmp       near ptr M08_L02
M08_L19:
       mov       eax,[rbp+234]
       jmp       short M08_L21
M08_L20:
       mov       eax,[rbp+234]
M08_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M08_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M08_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF976674918]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M08_L25
M08_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M08_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FF97647DAD0]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M08_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M08_L23:
       mov       rcx,rdx
       call      qword ptr [7FF975F66820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M08_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M08_L24
       xor       r14d,r14d
M08_L24:
       mov       eax,[rbp+220]
       inc       eax
M08_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M08_L22
       jmp       short M08_L27
M08_L26:
       mov       r13,rcx
       jmp       short M08_L28
M08_L27:
       xor       r13d,r13d
M08_L28:
       test      r13,r13
       je        short M08_L30
       cmp       byte ptr [r12+9D],0
       je        short M08_L29
       mov       rcx,r13
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF9765CFED0]
       mov       r8,r13
       jmp       near ptr M08_L02
M08_L29:
       mov       r8,r13
       jmp       near ptr M08_L02
M08_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M08_L33
M08_L31:
       test      r13d,r13d
       jne       short M08_L32
       mov       r8,24DF1EA6D78
       jmp       near ptr M08_L02
M08_L32:
       mov       ecx,r13d
       mov       rdx,24DF1EA6F28
       call      qword ptr [7FF97620D950]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M08_L33:
       cmp       r13d,800
       jge       short M08_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M08_L35
M08_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF9765CF5A0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M08_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M08_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF9765CFED0]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF9765CFF18]
       mov       r8,r13
       jmp       near ptr M08_L02
M08_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M08_L04
M08_L37:
       mov       r8,r13
       jmp       near ptr M08_L02
M08_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M08_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FF975F657E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,20D5CC01EF8
       mov       rbx,[rcx]
       mov       rcx,[rbp+38]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       short M08_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       jne       short M08_L41
M08_L40:
       mov       ecx,9
       call      qword ptr [7FF976804E40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M08_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M08_L42
       mov       rcx,rbx
       call      qword ptr [7FF9765CF870]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M08_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M08_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M08_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF976674348]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF975EA4000
       call      qword ptr [7FF975F6F210]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9762E79A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+38]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M08_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M08_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF976674B10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
M08_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF976674918]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M08_L51
M08_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FF97647DAD0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L47
       test      r8d,r8d
       jne       short M08_L48
       xor       edx,edx
       mov       [rax+14],edx
M08_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M08_L47:
       mov       rcx,rax
       call      qword ptr [7FF975F66820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M08_L49
       jmp       short M08_L52
M08_L48:
       jmp       short M08_L46
M08_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L50
       xor       r15d,r15d
M08_L50:
       inc       r12d
M08_L51:
       cmp       [r14+8],r12d
       jg        near ptr M08_L45
       jmp       short M08_L53
M08_L52:
       mov       r14d,1
       jmp       short M08_L54
M08_L53:
       xor       r14d,r14d
M08_L54:
       mov       rcx,20D5CC00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M08_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M08_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF97680DC08]
       test      r14d,edi
       jne       short M08_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF97637CE28]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M08_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L57
M08_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L56:
       mov       ecx,esi
       xor       edx,edx
M08_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF9766743C0]
M08_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
```
```assembly
; System.Threading.Lock.EnterAndGetCurrentThreadId()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       add       rax,284
       mov       r8d,[rax+10]
       test      r8d,r8d
       je        short M09_L01
       mov       eax,[rcx+14]
       mov       [rsp+24],eax
       test      al,3
       jne       short M09_L01
       lea       edx,[rax+1]
       lea       r10,[rcx+14]
       lock cmpxchg [r10],edx
       mov       edx,[rsp+24]
       cmp       eax,edx
       jne       short M09_L01
       mov       [rcx+10],r8d
       mov       eax,r8d
M09_L00:
       add       rsp,28
       ret
M09_L01:
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9766E5290]; System.Threading.Lock.TryEnterSlow(Int32, ThreadId)
       jmp       short M09_L00
; Total bytes of code 88
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
       jl        short M10_L02
       mov       rcx,[rbx+8]
       cmp       [rcx+8],edx
       je        short M10_L01
       test      edx,edx
       jle       short M10_L03
       mov       ecx,edx
       call      qword ptr [7FF9D39D4BF0]
       mov       rdi,rax
       test      esi,esi
       jle       short M10_L00
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF9D39D8378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
M10_L00:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      qword ptr [7FF9D39C6FD0]; CORINFO_HELP_ASSIGN_REF
M10_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L02:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF9D39DD438]
       int       3
M10_L03:
       call      qword ptr [7FF9D39C8210]
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      qword ptr [7FF9D39C6FD0]; CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L01
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
       je        near ptr M11_L06
M11_L00:
       mov       r14,[rbx+10]
       mov       r15,[rbx+18]
       test      r15,r15
       jne       near ptr M11_L07
       mov       r13d,esi
M11_L01:
       xor       r12d,r12d
       mov       rdx,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M11_L22
       mov       ecx,ecx
       lea       rax,[rdx+rcx*4+10]
       mov       r10d,[rax]
       dec       r10d
       test      r15,r15
       jne       near ptr M11_L15
       mov       r15d,[r14+8]
M11_L02:
       cmp       r15d,r10d
       ja        near ptr M11_L08
M11_L03:
       mov       ecx,[rbx+40]
       test      ecx,ecx
       jle       near ptr M11_L20
       mov       edx,[rbx+3C]
       mov       ebp,edx
       cmp       edx,r15d
       jae       near ptr M11_L22
       shl       rdx,4
       mov       edx,[r14+rdx+14]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rbx+3C],edx
       dec       ecx
       mov       [rbx+40],ecx
M11_L04:
       cmp       ebp,[r14+8]
       jae       near ptr M11_L22
       mov       ecx,ebp
       shl       rcx,4
       lea       rcx,[r14+rcx+10]
       mov       [rcx],r13d
       mov       edx,[rax]
       dec       edx
       mov       [rcx+4],edx
       mov       [rcx+8],esi
       mov       [rcx+0C],dil
       inc       ebp
       mov       [rax],ebp
       inc       dword ptr [rbx+44]
M11_L05:
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
M11_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9766E52F0]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M11_L00
M11_L07:
       mov       rcx,r15
       mov       edx,esi
       mov       r11,7FF975EB1630
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M11_L01
M11_L08:
       mov       edx,r10d
       shl       rdx,4
       cmp       [r14+rdx+10],r13d
       jne       short M11_L09
       mov       edx,r10d
       shl       rdx,4
       cmp       [r14+rdx+18],esi
       je        short M11_L10
M11_L09:
       mov       r10d,r10d
       shl       r10,4
       mov       r10d,[r14+r10+14]
       inc       r12d
       cmp       r15d,r12d
       jae       near ptr M11_L02
       jmp       near ptr M11_L19
M11_L10:
       cmp       bpl,1
       jne       short M11_L12
M11_L11:
       mov       eax,r10d
       shl       rax,4
       mov       [r14+rax+1C],dil
       jmp       near ptr M11_L05
M11_L12:
       cmp       bpl,2
       jne       near ptr M11_L18
       jmp       near ptr M11_L17
M11_L13:
       mov       edx,r10d
       shl       rdx,4
       cmp       [r14+rdx+10],r13d
       jne       short M11_L14
       mov       [rsp+28],rax
       mov       [rsp+34],r10d
       mov       edx,r10d
       shl       rdx,4
       mov       edx,[r14+rdx+18]
       mov       rcx,r15
       mov       r8d,esi
       mov       r11,7FF975EB1628
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+28]
       mov       r10d,[rsp+34]
       jne       short M11_L16
M11_L14:
       mov       r10d,r10d
       shl       r10,4
       mov       r10d,[r14+r10+14]
       mov       edx,r10d
       inc       r12d
       cmp       [rsp+30],r12d
       mov       r10d,edx
       jb        short M11_L19
M11_L15:
       mov       edx,[r14+8]
       mov       r9d,edx
       mov       [rsp+30],r9d
       cmp       r9d,r10d
       ja        short M11_L13
       mov       r15d,[rsp+30]
       jmp       near ptr M11_L03
M11_L16:
       cmp       bpl,1
       je        near ptr M11_L11
       cmp       bpl,2
       jne       short M11_L18
M11_L17:
       mov       ecx,esi
       call      qword ptr [7FF97680F450]
       int       3
M11_L18:
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
M11_L19:
       call      qword ptr [7FF975F6F480]
       int       3
M11_L20:
       mov       ebp,[rbx+38]
       cmp       r15d,ebp
       jne       short M11_L21
       mov       rcx,rbx
       call      qword ptr [7FF9766ED698]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize()
       mov       rax,[rbx+8]
       mov       ecx,r13d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       imul      rcx,rdx
       shr       rcx,20
       cmp       ecx,[rax+8]
       jae       short M11_L22
       mov       ecx,ecx
       lea       rax,[rax+rcx*4+10]
       mov       r15,rax
       mov       rax,r15
M11_L21:
       lea       ecx,[rbp+1]
       mov       [rbx+38],ecx
       mov       r14,[rbx+10]
       jmp       near ptr M11_L04
M11_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 651
```
```assembly
; System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       r9d,edx
       mov       r8d,[rbx+10]
       cmp       r9d,r8d
       jae       short M12_L01
       dec       r8d
       mov       [rbx+10],r8d
       cmp       r9d,r8d
       jl        short M12_L02
M12_L00:
       inc       dword ptr [rbx+14]
       add       rsp,30
       pop       rbx
       ret
M12_L01:
       call      qword ptr [7FF9766E4A80]
       int       3
M12_L02:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF97647CD68]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M12_L00
; Total bytes of code 76
```
```assembly
; System.Threading.Lock.Exit(ThreadId)
       sub       rsp,28
       cmp       [rcx+10],edx
       jne       short M13_L02
       cmp       dword ptr [rcx+18],0
       jne       short M13_L01
       xor       edx,edx
       mov       [rcx+10],edx
       lea       rdx,[rcx+14]
       mov       eax,0FFFFFFFF
       lock xadd [rdx],eax
       lea       edx,[rax-1]
       cmp       edx,80
       jae       short M13_L03
M13_L00:
       add       rsp,28
       ret
M13_L01:
       dec       dword ptr [rcx+18]
       jmp       short M13_L00
M13_L02:
       call      qword ptr [7FF97680F1E0]
       int       3
M13_L03:
       call      qword ptr [7FF97680F1F8]
       jmp       short M13_L00
; Total bytes of code 69
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
       je        near ptr M14_L06
M14_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M14_L07
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       xor       r14d,r14d
       mov       r15,offset MT_System.Object
M14_L01:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       cmp       r14d,0C
       jae       near ptr M14_L08
       lea       rcx,[rbp+r14*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M14_L09
       movsxd    rdx,r14d
       cmp       rdx,0C
       jl        short M14_L01
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M14_L04
M14_L02:
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M14_L05
M14_L03:
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
M14_L04:
       mov       rcx,rsi
       mov       rdx,7FF976781008
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L02
M14_L05:
       mov       rcx,rsi
       mov       rdx,7FF976781250
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L03
M14_L06:
       mov       rcx,rsi
       mov       rdx,7FF976780CF0
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L00
M14_L07:
       call      qword ptr [7FF9764FE6E8]
       mov       ecx,50C9
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rsi,rax
       mov       ecx,1B55
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,110B
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9766E4348]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9766E4360]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M14_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 550
```
```assembly
; System.SZArrayHelper.GetEnumerator[[System.__Canon, System.Private.CoreLib]]()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,rcx
       mov       rax,rdx
       mov       esi,[rbx+8]
       test      esi,esi
       jne       short M15_L02
       mov       rcx,[rax+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M15_L01
M15_L00:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L01:
       mov       rcx,rax
       mov       rdx,7FF97683A070
       call      qword ptr [7FF975F6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M15_L00
M15_L02:
       mov       rcx,[rax+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M15_L04
M15_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF976807360]; System.SZGenericArrayEnumeratorBase..ctor(Int32)
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L04:
       mov       rcx,rax
       mov       rdx,7FF97683A070
       call      qword ptr [7FF975F6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M15_L03
; Total bytes of code 157
```
```assembly
; System.SZGenericArrayEnumeratorBase.MoveNext()
       mov       eax,[rcx+8]
       inc       eax
       cmp       eax,[rcx+0C]
       jae       short M16_L00
       mov       [rcx+8],eax
       mov       eax,1
       ret
M16_L00:
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
       jae       short M17_L00
       mov       rax,[rcx+10]
       cmp       edx,[rax+8]
       jae       short M17_L01
       mov       ecx,edx
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M17_L00:
       mov       ecx,edx
       call      qword ptr [7FF976807F60]
       int       3
M17_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
; 		if (item is null)
; 		^^^^^^^^^^^^^^^^^
; 			throw new ArgumentNullException(nameof(item));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this._uniqueItems.TryAdd(item))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._bag.Add(item);
; 			^^^^^^^^^^^^^^^^^^^^
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
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-68],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       r8,rdx
       test      r8,r8
       je        near ptr M18_L73
       mov       rdx,[rcx+10]
       mov       [rbp-60],rdx
       cmp       [rdx],dl
       mov       rbx,r8
       mov       rax,[rdx]
       mov       r10,[rax+30]
       mov       r10,[r10]
       mov       r11,[r10+38]
       test      r11,r11
       je        near ptr M18_L68
M18_L00:
       mov       rdx,[rbp-60]
       mov       rax,[rdx+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M18_L79
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M18_L74
       mov       r10,20D5CC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M18_L78
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0FBC5C364
       mov       r11d,3D2E5057
       cmp       eax,8
       jb        near ptr M18_L71
       mov       ebx,eax
       shr       ebx,3
       nop
M18_L01:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M18_L01
       test      al,4
       jne       near ptr M18_L72
M18_L02:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M18_L03:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       eax,r10d
M18_L04:
       mov       [rbp-44],eax
       xor       eax,eax
       mov       [rbp-50],eax
       mov       r8,[rbp+18]
       mov       [rbp-68],r8
M18_L05:
       mov       rdx,[rbp-60]
       mov       rax,[rdx+10]
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       mov       rax,[rax+8]
       mov       ecx,[rax+8]
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r10d,[r8+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       ebx,edx
       mov       eax,ebx
       cdq
       idiv      r10d
       mov       [rbp-48],edx
       xor       esi,esi
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,[r8+8]
       cmp       [rbp-48],ecx
       jae       near ptr M18_L17
       mov       edi,[rbp-48]
       mov       r14,[r8+rdi*8+10]
       test      r14,r14
       je        near ptr M18_L12
       mov       rcx,r14
       call      00007FF9D5AF3170
       test      eax,eax
       je        near ptr M18_L13
M18_L06:
       mov       dword ptr [rbp-4C],1
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-60]
       cmp       rcx,[rdx+10]
       jne       near ptr M18_L81
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+8]
       cmp       ebx,[rcx+8]
       jae       near ptr M18_L17
       mov       eax,ebx
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       near ptr M18_L09
M18_L07:
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M18_L11
       mov       rcx,rax
M18_L08:
       mov       r14,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+8]
       mov       edx,ebx
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r14,rax
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+8]
       cmp       ebx,[rcx+8]
       jae       near ptr M18_L17
       mov       edx,ebx
       mov       rbx,[rcx+rdx*8+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-44]
       mov       [r15+18],ecx
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       near ptr M18_L17
       lea       rcx,[rcx+rdi*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M18_L18
       mov       [rcx],eax
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       near ptr M18_L17
       mov       ecx,[rcx+rdi*4+10]
       mov       eax,1
       mov       rdx,[rbp-60]
       cmp       ecx,[rdx+18]
       cmovg     esi,eax
       jmp       near ptr M18_L19
M18_L09:
       mov       ecx,[rbp-44]
       cmp       ecx,[r14+18]
       je        short M18_L14
M18_L10:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M18_L09
       jmp       near ptr M18_L07
M18_L11:
       mov       rdx,7FF9767817F0
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L08
M18_L12:
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M18_L13:
       mov       rcx,r14
       call      qword ptr [7FF976805BD8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L06
M18_L14:
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+40]
       test      r11,r11
       je        short M18_L15
       jmp       short M18_L16
M18_L15:
       mov       rdx,7FF9767817D8
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M18_L16:
       mov       rdx,[rbp-60]
       mov       rcx,[rdx+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-68]
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rbp-60]
       je        short M18_L10
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       near ptr M18_L82
M18_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L19:
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+10]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       near ptr M18_L89
       mov       rcx,[rcx+rdi*8+10]
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M18_L87
       mov       rcx,rbx
       call      00007FF9D5B62F90
       test      eax,eax
       jne       near ptr M18_L80
M18_L20:
       test      esi,esi
       jne       near ptr M18_L23
M18_L21:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       [rbp-78],rbx
       mov       rsi,[rbx+8]
       mov       [rbp-88],rsi
       mov       rdx,[rsi]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+80]
       test      rax,rax
       je        short M18_L24
M18_L22:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,rax
       mov       [rbp-90],rdi
       mov       rax,[rdi+10]
       mov       ecx,[rsi+18]
       not       ecx
       test      rax,rax
       je        short M18_L25
       test      ecx,ecx
       jl        short M18_L25
       cmp       [rax+8],ecx
       jle       short M18_L25
       cmp       ecx,[rax+8]
       jae       near ptr M18_L89
       mov       ecx,ecx
       mov       r14,[rax+rcx*8+10]
       test      r14,r14
       je        short M18_L25
       cmp       byte ptr [rsi+1C],0
       je        short M18_L25
       mov       rcx,[r14+20]
       mov       rbx,rcx
       jmp       near ptr M18_L30
M18_L23:
       mov       rcx,[rbp-60]
       mov       rdx,[rbp-70]
       call      qword ptr [7FF9766E55D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon>)
       jmp       near ptr M18_L21
M18_L24:
       mov       rcx,rdx
       mov       rdx,7FF976890DD8
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M18_L22
M18_L25:
       mov       eax,[rsi+18]
       not       eax
       test      eax,eax
       jl        near ptr M18_L83
       cmp       dword ptr [7FF9D5ECF778],0
       jne       near ptr M18_L84
M18_L26:
       mov       rax,7FF9D5B82A10
       call      rax
       test      eax,eax
       jne       near ptr M18_L85
M18_L27:
       mov       rsi,[rbp-88]
       cmp       qword ptr [rsi+8],0
       jne       near ptr M18_L86
       xor       ebx,ebx
M18_L28:
       mov       rdi,[rbp-90]
       mov       r8,[rdi+10]
       mov       ecx,[rsi+18]
       not       ecx
       test      r8,r8
       je        short M18_L29
       test      ecx,ecx
       jl        short M18_L29
       cmp       [r8+8],ecx
       jle       short M18_L29
       cmp       ecx,[r8+8]
       jae       near ptr M18_L89
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       jne       near ptr M18_L69
M18_L29:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9766E5638]; System.Threading.ThreadLocal`1[[System.__Canon, System.Private.CoreLib]].SetValueSlow(System.__Canon, LinkedSlotVolatile<System.__Canon>[])
M18_L30:
       test      rbx,rbx
       je        near ptr M18_L70
M18_L31:
       mov       [rbp-80],rbx
       mov       rsi,[rbp-78]
       add       rsi,18
       cmp       [rbx],bl
       xor       ecx,ecx
       mov       [rbp-54],ecx
       lea       rcx,[rbx+2C]
       mov       eax,1
       xchg      eax,[rcx]
       mov       edi,[rbx+1C]
       cmp       edi,7FFFFFFF
       jne       short M18_L35
       xor       ecx,ecx
       mov       [rbx+2C],ecx
       mov       [rbp-58],ecx
       mov       rcx,rbx
       call      00007FF9D5AF3170
       test      eax,eax
       je        short M18_L33
M18_L32:
       mov       dword ptr [rbp-58],1
       mov       ecx,[rbx+20]
       and       [rbx+18],ecx
       mov       edi,[rbx+20]
       and       edi,7FFFFFFF
       mov       [rbx+1C],edi
       lea       rcx,[rbx+2C]
       mov       eax,1
       xchg      eax,[rcx]
       jmp       short M18_L34
M18_L33:
       mov       rcx,rbx
       call      qword ptr [7FF976805BD8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M18_L32
M18_L34:
       mov       rcx,rbx
       call      00007FF9D5B62F90
       test      eax,eax
       jne       near ptr M18_L48
M18_L35:
       mov       r14d,[rbx+18]
       cmp       byte ptr [rbx+34],0
       jne       short M18_L36
       lea       ecx,[rdi-1]
       mov       eax,r14d
       sub       eax,ecx
       jns       short M18_L36
       add       r14d,[rbx+20]
       mov       ecx,edi
       sub       ecx,r14d
       js        near ptr M18_L47
M18_L36:
       xor       ecx,ecx
       mov       [rbx+2C],ecx
       mov       rcx,rbx
       call      00007FF9D5AF3170
       test      eax,eax
       je        near ptr M18_L49
M18_L37:
       mov       dword ptr [rbp-54],1
       mov       r14d,[rbx+18]
       mov       r15d,edi
       sub       r15d,r14d
       cmp       r15d,[rbx+20]
       jl        near ptr M18_L44
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M18_L39
       mov       rcx,rax
M18_L38:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       and       r14d,[rbx+20]
       jne       near ptr M18_L40
       mov       r14,[rbx+8]
       mov       rcx,[rbx+8]
       mov       r13d,[rcx+8]
       test      r14,r14
       je        near ptr M18_L54
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M18_L55
       cmp       dword ptr [rcx+4],18
       jne       near ptr M18_L55
       cmp       r13d,[r14+8]
       ja        near ptr M18_L55
       cmp       r13d,[rdi+8]
       ja        near ptr M18_L55
       mov       r8d,r13d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M18_L53
       cmp       r8,4000
       ja        near ptr M18_L52
       mov       rcx,rax
       call      00007FF9D5B62CC0
       cmp       dword ptr [7FF9D5ECF778],0
       je        near ptr M18_L42
       jmp       near ptr M18_L50
M18_L39:
       mov       rdx,7FF976890F58
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L38
M18_L40:
       mov       rcx,[rbx+8]
       mov       rdx,[rbx+8]
       mov       eax,[rdx+8]
       sub       eax,r14d
       test      rcx,rcx
       je        near ptr M18_L60
       mov       rdx,[rcx]
       cmp       rdx,[rdi]
       jne       near ptr M18_L60
       cmp       dword ptr [rdx+4],18
       jne       near ptr M18_L60
       mov       r8d,eax
       or        r8d,r14d
       jl        near ptr M18_L60
       lea       r8d,[r14+rax]
       cmp       r8d,[rcx+8]
       ja        near ptr M18_L60
       cmp       eax,[rdi+8]
       ja        near ptr M18_L60
       movzx     r8d,word ptr [rdx]
       imul      rax,r8
       mov       r10d,r14d
       imul      r8,r10
       lea       r10,[rcx+r8+10]
       lea       rcx,[rdi+10]
       test      dword ptr [rdx],1000000
       je        near ptr M18_L59
       cmp       rax,4000
       ja        near ptr M18_L58
       mov       rdx,r10
       mov       r8,rax
       call      00007FF9D5B62CC0
       cmp       dword ptr [7FF9D5ECF778],0
       jne       near ptr M18_L57
M18_L41:
       mov       rcx,[rbx+8]
       mov       rdx,[rbx+8]
       mov       r9d,[rdx+8]
       sub       r9d,r14d
       test      rcx,rcx
       je        near ptr M18_L64
       mov       rdx,[rcx]
       cmp       rdx,[rdi]
       jne       near ptr M18_L64
       cmp       dword ptr [rdx+4],18
       jne       near ptr M18_L64
       mov       r8d,r14d
       or        r8d,r9d
       jl        near ptr M18_L64
       cmp       r14d,[rcx+8]
       ja        near ptr M18_L64
       lea       r8d,[r9+r14]
       cmp       r8d,[rdi+8]
       ja        near ptr M18_L64
       movzx     r8d,word ptr [rdx]
       mov       eax,r14d
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rdi+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M18_L63
       cmp       rax,4000
       ja        near ptr M18_L62
       mov       rdx,r10
       mov       r8,rax
       call      00007FF9D5B62CC0
       cmp       dword ptr [7FF9D5ECF778],0
       jne       near ptr M18_L61
M18_L42:
       cmp       dword ptr [7FF9D5ECF778],0
       jne       near ptr M18_L51
M18_L43:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+18],edx
       mov       edi,r15d
       mov       [rbx+1C],edi
       mov       edx,[rbx+20]
       add       edx,edx
       or        edx,1
       mov       [rbx+20],edx
M18_L44:
       mov       edx,edi
       and       edx,[rbx+20]
       movsxd    rdx,edx
       mov       rcx,[rbx+8]
       mov       r8,[rbp+18]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       mov       [rbx+1C],edi
       test      r15d,r15d
       jne       short M18_L45
       lock inc  qword ptr [rsi]
M18_L45:
       mov       edx,[rbx+28]
       sub       [rbx+24],edx
       xor       edx,edx
       mov       [rbx+28],edx
M18_L46:
       mov       ecx,[rbx+24]
       add       ecx,1
       jo        near ptr M18_L65
       mov       [rbx+24],ecx
       jmp       near ptr M18_L66
M18_L47:
       mov       edx,edi
       and       edx,[rbx+20]
       movsxd    rdx,edx
       mov       rcx,[rbx+8]
       mov       r8,[rbp+18]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       lea       ecx,[rdi+1]
       mov       [rbx+1C],ecx
       jmp       short M18_L46
M18_L48:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF976804F90]
       jmp       near ptr M18_L35
M18_L49:
       mov       rcx,rbx
       call      qword ptr [7FF976805BD8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M18_L37
M18_L50:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L42
M18_L51:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L43
M18_L52:
       mov       rcx,rax
       call      qword ptr [7FF9764FE0A0]
       jmp       near ptr M18_L43
M18_L53:
       mov       rcx,rax
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M18_L43
M18_L54:
       xor       r12d,r12d
       jmp       short M18_L56
M18_L55:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF976806E80]; System.Array.GetLowerBound(Int32)
       mov       r12d,eax
M18_L56:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF976806E80]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8,rdi
       call      qword ptr [7FF976804318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M18_L43
M18_L57:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L41
M18_L58:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9764FE0A0]
       jmp       near ptr M18_L41
M18_L59:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M18_L41
M18_L60:
       mov       [rsp+20],eax
       xor       edx,edx
       mov       [rsp+28],edx
       mov       edx,r14d
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF976804318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M18_L41
M18_L61:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L42
M18_L62:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9764FE0A0]
       jmp       near ptr M18_L43
M18_L63:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M18_L43
M18_L64:
       mov       [rsp+20],r14d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FF976804318]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M18_L43
M18_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M18_L66:
       xor       ecx,ecx
       mov       [rbx+2C],ecx
       cmp       dword ptr [rbp-54],0
       je        short M18_L67
       mov       rcx,rbx
       call      00007FF9D5B62F90
       test      eax,eax
       jne       near ptr M18_L88
M18_L67:
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
M18_L68:
       mov       rcx,rax
       mov       rdx,7FF9767816E8
       call      qword ptr [7FF975F6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M18_L00
M18_L69:
       cmp       byte ptr [rsi+1C],0
       je        near ptr M18_L29
       lea       rcx,[rcx+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M18_L30
M18_L70:
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9766E5710]; System.Collections.Concurrent.ConcurrentBag`1[[System.__Canon, System.Private.CoreLib]].CreateWorkStealingQueueForCurrentThread()
       mov       rbx,rax
       jmp       near ptr M18_L31
M18_L71:
       cmp       eax,4
       jb        short M18_L75
M18_L72:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M18_L02
M18_L73:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,206F
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9762E71B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M18_L74:
       xor       eax,eax
       jmp       near ptr M18_L04
M18_L75:
       mov       ebx,80
       test      al,1
       je        short M18_L76
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M18_L76:
       test      al,2
       je        short M18_L77
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M18_L03
M18_L77:
       mov       eax,ebx
       jmp       near ptr M18_L03
M18_L78:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M18_L04
M18_L79:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [r11]
       jmp       near ptr M18_L04
M18_L80:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF976804F90]
       jmp       near ptr M18_L20
M18_L81:
       call      M18_L90
       jmp       near ptr M18_L05
M18_L82:
       call      M18_L90
       nop
       mov       ecx,[rbp-50]
       test      ecx,ecx
       je        near ptr M18_L67
       jmp       near ptr M18_L21
M18_L83:
       mov       rsi,[rbp-88]
       mov       rcx,rsi
       call      qword ptr [7FF97680F498]
       int       3
M18_L84:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L26
M18_L85:
       call      qword ptr [7FF97680F4B0]
       jmp       near ptr M18_L27
M18_L86:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       mov       rcx,rsi
       call      qword ptr [7FF97680F4C8]
       test      eax,eax
       je        near ptr M18_L28
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF97680F4E0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9762E7900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M18_L87:
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M18_L88:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF976804F90]
       jmp       near ptr M18_L67
M18_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L90:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-4C],0
       je        short M18_L91
       mov       rcx,[rbp-70]
       mov       rcx,[rcx+10]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       short M18_L93
       mov       edi,[rbp-48]
       mov       rsi,[rcx+rdi*8+10]
       test      rsi,rsi
       je        short M18_L92
       mov       rcx,rsi
       call      00007FF9D5B62F90
       test      eax,eax
       je        short M18_L91
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF976804F90]
M18_L91:
       nop
       add       rsp,38
       ret
M18_L92:
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M18_L93:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-58],0
       je        short M18_L95
       cmp       qword ptr [rbp-80],0
       jne       short M18_L94
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M18_L94:
       mov       rcx,[rbp-80]
       call      00007FF9D5B62F90
       test      eax,eax
       je        short M18_L95
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF976804F90]
M18_L95:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       xor       ecx,ecx
       mov       rdx,[rbp-80]
       mov       [rdx+2C],ecx
       cmp       dword ptr [rbp-54],0
       je        short M18_L96
       mov       rcx,rdx
       call      00007FF9D5B62F90
       test      eax,eax
       je        short M18_L96
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF976804F90]
M18_L96:
       nop
       add       rsp,38
       ret
; Total bytes of code 3190
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
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L01
M20_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M20_L01:
       call      qword ptr [7FFA1BF59CB8]
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA1BF5E4A8]; Precode of System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA1BF5E4B8]; Precode of System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFA1BF5E4D0]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFA1BF58278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M20_L00
; Total bytes of code 82
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FFA1BF5AE88]; Precode of System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rcx,rbx
       call      qword ptr [7FFA1BF5EF58]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.IsInvalidForSerialization(System.Type)
       test      eax,eax
       jne       short M21_L00
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFA1BF5E448]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M21_L00:
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA1BF5CE30]
       int       3
; Total bytes of code 118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M22_L00
       cmp       [rdx],rcx
       jne       short M22_L01
M22_L00:
       mov       rax,rdx
       ret
M22_L01:
       jmp       qword ptr [7FF976144D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
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
       je        near ptr M23_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M23_L00
       test      rbx,rbx
       je        near ptr M23_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M23_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M23_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9D5BBAFA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M23_L00:
       test      rbx,rbx
       je        short M23_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M23_L02
M23_L01:
       mov       rax,24DF1EA0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M23_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M23_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M23_L04:
       call      qword ptr [7FF976806EC8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M24_L07
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M24_L08
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M24_L09
M24_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M24_L02
       mov       rcx,rsi
       call      00007FF9D5AF3170
       test      eax,eax
       je        short M24_L03
M24_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M24_L05
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M24_L04
       mov       rcx,7FF97682C700
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF976476A18]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M24_L05
M24_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M24_L03:
       mov       rcx,rsi
       call      qword ptr [7FF976805BD8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M24_L01
M24_L04:
       mov       rcx,7FF97682C6FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF976805BF0]
       int       3
M24_L05:
       mov       rcx,7FF97682C704
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF9D5B62F90
       test      eax,eax
       jne       near ptr M24_L11
M24_L06:
       mov       rcx,7FF97682C708
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF97682C70C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M24_L07:
       call      qword ptr [7FF9768063A0]
       int       3
M24_L08:
       mov       rcx,7FF97682C6F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF976805BF0]
       int       3
M24_L09:
       mov       rcx,rbx
       call      qword ptr [7FF97637CCD8]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M24_L10
       call      qword ptr [7FF976804C18]
       int       3
M24_L10:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF9D5B6B3A0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M24_L00
M24_L11:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF976804F90]
       jmp       near ptr M24_L06
       sub       rsp,28
       call      qword ptr [7FF9768063B8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M24_L13
       mov       rcx,7FF97682C704
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M24_L12
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M24_L12:
       mov       rcx,[rbp-20]
       call      00007FF9D5B62F90
       test      eax,eax
       je        short M24_L13
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF976804F90]
M24_L13:
       mov       rcx,7FF97682C708
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 537
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF9D39DFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M25_L01
       cmp       [rax],ecx
       jle       short M25_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M25_L03
M25_L00:
       add       rsp,20
       pop       rbx
       ret
M25_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M25_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M25_L00
M25_L02:
       cmp       [rax+4],edx
       jle       short M25_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M25_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M25_L03
       jmp       short M25_L00
M25_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M26_L00
       ret
M26_L00:
       jmp       qword ptr [7FF975F65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M27_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M27_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M27_L03
       test      r8b,18
       jne       short M27_L00
       test      r8b,4
       je        short M27_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M27_L01
M27_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M27_L01:
       vzeroupper
       ret
M27_L02:
       test      r8,r8
       je        short M27_L01
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M27_L01
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M27_L01
M27_L03:
       cmp       r8,40
       ja        short M27_L07
M27_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M27_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M27_L06
M27_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M27_L01
M27_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M27_L05
M27_L07:
       cmp       r8,800
       ja        short M27_L11
       cmp       r8,100
       jb        short M27_L08
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
M27_L08:
       mov       r9,r8
       shr       r9,6
M27_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M27_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M27_L04
       jmp       near ptr M27_L05
M27_L10:
       cmp       rcx,rdx
       jne       short M27_L11
       cmp       [rdx],dl
       jmp       near ptr M27_L01
M27_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF975F666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        short M28_L00
       cmp       edx,eax
       jae       short M28_L01
       add       eax,edx
       cdqe
       mov       eax,[rcx+rax*4+10]
       add       rsp,20
       pop       rbx
       ret
M28_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M28_L01:
       call      qword ptr [7FF9D39D1710]
       mov       rbx,rax
       call      qword ptr [7FF9D39DC948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9D39DB0D8]
       mov       rcx,rbx
       call      qword ptr [7FF9D39C6FA8]; CORINFO_HELP_THROW
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
       je        near ptr M29_L07
       test      rsi,rsi
       je        near ptr M29_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M29_L00
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
       jne       near ptr M29_L08
M29_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M29_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9D39D8400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M29_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF9D39EF9D0]
       int       3
M29_L01:
       sub       edi,eax
       js        near ptr M29_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M29_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9D39D8400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M29_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF9D39EF9D0]
       int       3
M29_L02:
       sub       ebp,eax
       js        near ptr M29_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M29_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M29_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9D39D8320]
       test      eax,eax
       je        short M29_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M29_L16
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
M29_L03:
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
       jne       short M29_L04
       cmp       r8,14
       jne       near ptr M29_L15
       jmp       near ptr M29_L14
M29_L04:
       cmp       r8,4000
       ja        near ptr M29_L13
       jmp       near ptr M29_L12
M29_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M29_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF9D39DA268]
       int       3
M29_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF9D39DA268]
       int       3
M29_L08:
       call      qword ptr [7FF9D39D1830]
       mov       rbx,rax
       call      qword ptr [7FF9D39DCDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9D39DB810]
       mov       rcx,rbx
       call      qword ptr [7FF9D39C6FA8]; CORINFO_HELP_THROW
       int       3
M29_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF9D39EF9B8]
       int       3
M29_L10:
       call      qword ptr [7FF9D39D15F8]
       mov       rbx,rax
       call      qword ptr [7FF9D39DBC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF9D39DA218]
       mov       rcx,rbx
       call      qword ptr [7FF9D39C6FA8]; CORINFO_HELP_THROW
       int       3
M29_L11:
       call      qword ptr [7FF9D39D15F8]
       mov       r14,rax
       call      qword ptr [7FF9D39DBC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FF9D39DA218]
       mov       rcx,r14
       call      qword ptr [7FF9D39C6FA8]; CORINFO_HELP_THROW
       int       3
M29_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF9D39D86A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M29_L05
       call      qword ptr [7FF9D39C7028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M29_L05
M29_L13:
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
M29_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M29_L05
M29_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF9D39DB980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M29_L05
M29_L16:
       call      qword ptr [7FF9D39D1620]
       mov       rbx,rax
       call      qword ptr [7FF9D39DC730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9D39DA298]
       mov       rcx,rbx
       call      qword ptr [7FF9D39C6FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,1B
       call      qword ptr [7FF9D39D4CC8]
       mov       rsi,rax
       call      qword ptr [7FF9D39C8F10]
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF9D39C6FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9D39ED908]; Precode of System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       lea       rax,[rbx+18]
       mov       ecx,1
       xchg      cl,[rax]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M30_L01
M30_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M30_L01:
       call      qword ptr [7FF9D39C8020]
       mov       rdi,rax
       mov       rbp,[rdi+8]
       test      rbp,rbp
       jne       short M30_L02
       call      qword ptr [7FF9D39D2EB0]
       mov       rbp,rax
       mov       rdx,[rdi]
       mov       rcx,rbp
       call      qword ptr [7FF9D39D79F8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      qword ptr [7FF9D39C6FD0]; CORINFO_HELP_ASSIGN_REF
M30_L02:
       call      qword ptr [7FF9D39D1700]
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      qword ptr [7FF9D39C6FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9D39E25E0]
       test      rax,rax
       je        short M30_L04
M30_L03:
       mov       [rsp+20],rax
       mov       rax,[rsp+20]
       mov       [rdi+18],rax
       jmp       short M30_L00
M30_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9D39E25E8]
       jmp       short M30_L03
; Total bytes of code 211
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,edx
       call      qword ptr [7FF9D39D1B70]
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9D39DF878]; Precode of System.Buffers.SharedArrayPoolPartitions..ctor()
       mov       rcx,[rsi+10]
       cmp       ebx,[rcx+8]
       jae       short M31_L01
       mov       edx,ebx
       lea       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        short M31_L00
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9D39DFC28]
       test      rax,rax
       cmove     rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L00:
       call      qword ptr [7FF9D39DD468]
       int       3
M31_L01:
       call      qword ptr [7FF9D39C6FC0]
       int       3
; Total bytes of code 92
```
```assembly
; System.Threading.Thread.GetCurrentProcessorNumber()
       sub       rsp,28
       vzeroupper
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+20]
       mov       rax,7FFA48E12320
       call      rax
       cmp       dword ptr [7FF9D5ECF778],0
       jne       short M32_L01
M32_L00:
       movzx     eax,word ptr [rsp+20]
       shl       eax,6
       movzx     ecx,byte ptr [rsp+22]
       or        eax,ecx
       add       rsp,28
       ret
M32_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M32_L00
; Total bytes of code 66
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M33_L00
       mov       rcx,rbx
       call      qword ptr [7FF9D39DFC38]
       test      eax,eax
       je        short M33_L01
       add       rsp,20
       pop       rbx
       ret
M33_L00:
       xor       ecx,ecx
       call      qword ptr [7FF9D39DA268]
       int       3
M33_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M34_L00
       mov       rcx,rbx
       call      00007FF9D5B62F90
       test      eax,eax
       jne       short M34_L01
       add       rsp,20
       pop       rbx
       ret
M34_L00:
       xor       ecx,ecx
       call      qword ptr [7FF976804708]
       int       3
M34_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF976804F90]
; Total bytes of code 56
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF9D39E2E48]
       test      eax,eax
       je        short M35_L00
       add       rsp,20
       pop       rbx
       ret
M35_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       mov       rsi,[rbx+1A0]
       cmp       [rcx],cl
       test      rsi,rsi
       je        near ptr M00_L19
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,1E88A000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,58A0FB5C
       mov       r8d,4438885
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rdi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L20
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L18
M00_L04:
       cmp       ebp,[r14+18]
       jne       near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,[r14+8]
       mov       r11,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r11,7FF975ED10A8
       call      qword ptr [r11]
M00_L05:
       test      eax,eax
       je        near ptr M00_L16
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9766FCE70]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF976307900]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rdx,rsi
       mov       r11,7FF975ED1098
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       near ptr M00_L04
       jmp       short M00_L18
M00_L17:
       mov       r8,rsi
       mov       r11,7FF975ED10A0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L18:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L19:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 730
```

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.DistinctConcurrentBagBenchmark.ContainsAny()
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
       mov       rbx,[rcx+270]
       mov       rsi,[rcx+278]
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-34],eax
       test      rsi,rsi
       je        near ptr M00_L29
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rax
       jne       near ptr M00_L31
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L28
       test      byte ptr [7FF976768338],1
       je        near ptr M00_L30
M00_L00:
       mov       rax,2823FC00C40
       mov       r14,[rax]
M00_L01:
       mov       [rbp-40],r14
M00_L02:
       mov       r11,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r14,[rbp-40]
       cmp       [r14],r11
       jne       near ptr M00_L21
       mov       r11d,[r14+8]
       inc       r11d
       cmp       r11d,[r14+0C]
       jae       near ptr M00_L10
       mov       [r14+8],r11d
       mov       r11d,[r14+8]
       cmp       r11d,[r14+0C]
       jae       near ptr M00_L22
       mov       r11,[r14+10]
       mov       eax,[r14+8]
       cmp       eax,[r11+8]
       jae       near ptr M00_L25
       mov       rsi,[r11+rax*8+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdi,[rbx+10]
       mov       rax,[rdi+8]
       test      rax,rax
       je        near ptr M00_L23
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L19
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L14
       mov       rax,28229C00068
       mov       rax,[rax]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rax],r8
       jne       near ptr M00_L18
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,0CF8427A6
       mov       r10d,0DA51E2DA
       cmp       edx,8
       jb        near ptr M00_L11
       mov       r9d,edx
       shr       r9d,3
       nop       dword ptr [rax]
M00_L04:
       add       r8d,[rax]
       mov       r11d,[rax+4]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       add       r11d,r8d
       mov       r8d,r10d
       xor       r8d,r11d
       rol       r11d,14
       add       r11d,r8d
       rol       r8d,9
       xor       r8d,r11d
       rol       r11d,1B
       add       r11d,r8d
       rol       r8d,13
       mov       r10d,r11d
       add       rax,8
       dec       r9d
       mov       ecx,r8d
       mov       r8d,r10d
       mov       r10d,ecx
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L12
M00_L05:
       mov       r9d,edx
       and       r9,7
       mov       eax,[rax+r9-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M00_L06:
       add       edx,r8d
       mov       eax,r10d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       r15d,edx
       rol       r15d,14
       add       r15d,eax
       rol       eax,9
       xor       eax,r15d
       rol       r15d,1B
       add       r15d,eax
       mov       r13d,eax
       rol       r13d,13
       xor       r15d,r13d
M00_L07:
       mov       rax,[rdi+10]
       mov       [rbp-48],rax
       mov       eax,r15d
       and       eax,7FFFFFFF
       mov       rdx,[rbp-48]
       mov       r8,[rdx+8]
       cdq
       idiv      dword ptr [r8+8]
       cmp       edx,[r8+8]
       jae       near ptr M00_L25
       mov       r13,[r8+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L02
M00_L08:
       cmp       r15d,[r13+18]
       je        near ptr M00_L20
M00_L09:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M00_L08
       jmp       near ptr M00_L02
M00_L10:
       mov       eax,[r14+0C]
       mov       [r14+8],eax
       jmp       near ptr M00_L26
M00_L11:
       cmp       edx,4
       jb        short M00_L15
M00_L12:
       add       r8d,[rax]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L05
M00_L13:
       mov       rcx,r14
       mov       r11,7FF975EB10A8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L14:
       xor       r15d,r15d
       jmp       near ptr M00_L07
M00_L15:
       mov       r9d,80
       test      dl,1
       je        short M00_L16
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rax+r9]
       or        r9d,8000
M00_L16:
       test      dl,2
       je        short M00_L17
       shl       r9d,10
       movzx     edx,word ptr [rax]
       or        r9d,edx
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L17:
       mov       edx,r9d
       jmp       near ptr M00_L06
M00_L18:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M00_L07
M00_L19:
       mov       rcx,rax
       mov       rdx,rsi
       mov       r11,7FF975EB10B8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L07
M00_L20:
       mov       rcx,[rdi+8]
       mov       rdx,[r13+8]
       mov       r8,rsi
       mov       r11,7FF975EB10C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L09
       jmp       short M00_L24
M00_L21:
       mov       rcx,r14
       mov       r11,7FF975EB10A0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L13
       jmp       near ptr M00_L32
M00_L22:
       mov       ecx,[r14+8]
       call      qword ptr [7FF97680C1E0]
       int       3
M00_L23:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9766DCF90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9762E7900]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L33
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       xor       ebx,ebx
M00_L27:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
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
M00_L28:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L29:
       call      qword ptr [7FF9764FE250]
       mov       ecx,2481
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       r14,rax
       mov       ecx,1B55
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF976243D38
       call      qword ptr [7FF975F6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF975F6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF97666FED0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF97666FEE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L30:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF975F65728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L31:
       mov       rcx,rsi
       mov       r11,7FF975EB1098
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L32:
       mov       rcx,r14
       mov       r11,7FF975EB10B0
       call      qword ptr [r11]
       jmp       near ptr M00_L26
M00_L33:
       call      M00_L34
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L27
M00_L34:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L35
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-40]
       cmp       [rax],rcx
       je        short M00_L35
       mov       rcx,rax
       mov       r11,7FF975EB10B0
       call      qword ptr [r11]
M00_L35:
       nop
       add       rsp,28
       ret
; Total bytes of code 1276
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
       call      00007FF9D5BBAFA0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF975F65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
       mov       rax,2C2BEC50008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF976807138]
       int       3
; Total bytes of code 244
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
       jmp       qword ptr [7FF975F65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

