## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       vmovdqu   xmm0,xmmword ptr [rsi+40]
       vmovdqu   xmmword ptr [rdi+40],xmm0
       mov       rcx,[rsi+50]
       mov       [rdi+50],rcx
       mov       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+30]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-218],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-210],xmm4
       vmovdqa   xmmword ptr [rbp-200],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rax,[rbx+48]
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,1D17DC00220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFA02F977F8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r15,rax
       cmp       byte ptr [r15+9F],0
       je        near ptr M00_L48
M00_L01:
       mov       rdx,[r15+18]
       test      rdx,rdx
       jne       near ptr M00_L05
       xor       esi,esi
       cmp       byte ptr [r15+9E],0
       je        short M00_L04
       mov       rsi,[r15+8]
       test      rsi,rsi
       je        near ptr M00_L49
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,1D17DC01960
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M00_L50
M00_L03:
       mov       [rsp+20],rsi
       mov       rcx,rdi
       mov       rdx,7FFA02DE19F0
       mov       r8,21212CE19B8
       cmp       [rcx],ecx
       call      qword ptr [7FFA02D5D0F8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L51
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        short M00_L04
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L52
M00_L04:
       test      rsi,rsi
       je        near ptr M00_L46
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L05:
       mov       r15,rdx
       test      r15,r15
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r15],rcx
       jne       near ptr M00_L53
M00_L06:
       mov       rsi,[r15+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F97B40]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r13d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L54
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L54
M00_L07:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L08
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21212CE62A0
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L08:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r13d,r13d
       je        near ptr M00_L56
       mov       rcx,1D17DC01E00
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFA02FBB970]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L09:
       mov       [rbp-70],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-238],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r12+7C],8
       cmove     ecx,eax
       mov       [r12+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L13
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L10:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L57
       mov       r13,21212CE1518
M00_L11:
       mov       ecx,[r13+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       short M00_L12
       mov       dword ptr [r12+78],3E8
M00_L12:
       mov       [rbp-240],r12
       jmp       near ptr M00_L20
M00_L13:
       mov       eax,2
       jmp       short M00_L10
M00_L14:
       mov       rcx,[rax+8]
       mov       [rbp-238],rcx
       mov       r12,[rax+10]
       mov       rcx,[rbp-238]
       cmp       [rcx],cl
       mov       rcx,[rbp-238]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r13d
       jl        near ptr M00_L18
M00_L15:
       lea       rcx,[r12+8]
       mov       rdx,[rbp-238]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r12+7C],8
       cmove     ecx,eax
       mov       [r12+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L19
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L16:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L55
       mov       rsi,21212CE1518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r12+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r13d
       call      qword ptr [7FFA02F97BD0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L15
M00_L19:
       mov       eax,2
       jmp       short M00_L16
M00_L20:
       cmp       byte ptr [r15+116],0
       jne       near ptr M00_L34
       mov       rcx,[r15+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L32
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L32
       mov       rsi,[r15+0B8]
       mov       rcx,[rbp-48]
       cmp       [rsi],sil
       call      qword ptr [7FFA0293C9A8]; System.Object.GetType()
       mov       r9,21212CE19B8
       cmp       rax,r9
       je        near ptr M00_L32
       mov       r15,[rsi+10]
       test      r15,r15
       je        near ptr M00_L35
       mov       r9,[r15+0C0]
       cmp       r9,rax
       jne       near ptr M00_L35
M00_L21:
       cmp       byte ptr [r15+11A],0
       je        near ptr M00_L28
M00_L22:
       mov       rcx,[r15+0F8]
       test      rcx,rcx
       cmovne    r15,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L40
       mov       rsi,[rbp-48]
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L23
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rcx],rax
       jne       near ptr M00_L36
M00_L23:
       mov       [rbp-118],rcx
       cmp       byte ptr [r15+116],0
       jne       near ptr M00_L37
       mov       rcx,[r15+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L30
       cmp       qword ptr [rbp-118],0
       je        near ptr M00_L30
       mov       rdi,[r15+0B8]
       mov       rcx,[rbp-118]
       cmp       [rdi],dil
       call      qword ptr [7FFA0293C9A8]; System.Object.GetType()
       mov       r9,21212CE19B8
       cmp       rax,r9
       je        near ptr M00_L30
       mov       r15,[rdi+10]
       test      r15,r15
       je        near ptr M00_L38
       mov       r9,[r15+0C0]
       cmp       r9,rax
       jne       near ptr M00_L38
M00_L24:
       cmp       byte ptr [r15+11A],0
       je        near ptr M00_L29
M00_L25:
       mov       rcx,[r15+0F8]
       test      rcx,rcx
       cmovne    r15,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rcx
       jne       near ptr M00_L39
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-118]
       call      qword ptr [7FFA02DC9158]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M00_L26:
       xor       edx,edx
       mov       [rbp-118],rdx
M00_L27:
       mov       r9,[rbp-238]
       cmp       [r9],r9b
       mov       rdx,[rbp-238]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-1C8]
       call      qword ptr [7FFA02F9FB58]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-1C8]
       mov       eax,[rbp-1C0]
       mov       [rbp-208],rcx
       mov       [rbp-200],eax
       lea       rcx,[rbp-208]
       call      qword ptr [7FFA02EC5E48]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L41
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFA02F9E298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L22
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFA02F9E298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L25
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-1B8]
       mov       rdx,r15
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA02F9F1F8]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-1B8]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-118]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9F210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9FB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L26
M00_L32:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-110],ymm0
       vmovdqu   ymmword ptr [rbp-0F0],ymm0
       vmovdqu   ymmword ptr [rbp-0D0],ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   ymmword ptr [rbp-90],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-110]
       mov       rdx,r15
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA02F9F1F8]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9F210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L33:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9FB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L27
M00_L34:
       mov       rax,[r15+148]
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L33
M00_L35:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D5CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L36:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L37:
       mov       rax,[r15+148]
       mov       rdx,r12
       mov       r8,[rbp-118]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L31
M00_L38:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rdi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D5CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-118]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L40:
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L27
M00_L41:
       mov       rcx,r12
       mov       rdx,[rbp-238]
       call      qword ptr [7FFA02F9FB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFA02A8F960]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFA030578D0]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       call      qword ptr [7FFA03057A68]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-1D8]
       call      qword ptr [7FFA03057AE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-1D8]
       mov       edi,[rbp-1D0]
       mov       rcx,1D17DC01D08
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFA02B5FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L58
       mov       rcx,rax
       call      qword ptr [7FFA02F3E178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L42:
       mov       [rbp-228],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L44
       mov       r13,offset MT_System.Byte
       mov       rcx,1D17DC00100
       mov       r12,[rcx]
       mov       rax,offset MT_System.ReadOnlySpan<System.Object>
       mov       [rbp-220],rax
M00_L43:
       movzx     edx,byte ptr [rsi+r15]
       mov       [rbp-3C],edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-230],r12
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-1E0],rax
       mov       rax,[rbp-228]
       cmp       [rax],al
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1F0],xmm0
       lea       rcx,[rbp-1F0]
       lea       r8,[rbp-1E0]
       mov       rdx,[rbp-220]
       call      qword ptr [7FFA0339C360]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-218],xmm0
       lea       r9,[rbp-218]
       mov       rdx,[rbp-230]
       mov       rcx,[rbp-228]
       mov       r8,21212CF1970
       call      qword ptr [7FFA03266280]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L43
M00_L44:
       mov       rcx,[rbp-228]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B22100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-228]
       mov       rcx,r14
       call      qword ptr [7FFA02B5FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA02F94F30]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L59
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFA02F94F48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L45:
       mov       [rbp-1F8],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-1F8]
       mov       rdx,7FFA0328CED0
       cmp       [rcx],ecx
       call      qword ptr [7FFA032662F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L46:
       mov       rdx,[r15+20]
       mov       rcx,21212CE19B8
       call      qword ptr [7FFA03394CC0]
       int       3
M00_L47:
       call      qword ptr [7FFA02ECE6A0]
       mov       ecx,886
       mov       rdx,7FFA02D1A368
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C14878
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D1A368
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02937840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA0339C138]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0326DF08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFA02D57378]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFA02D5CBA0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L50:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFA0287D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,1D17DC01960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M00_L03
M00_L51:
       call      qword ptr [7FFA03395C08]
       int       3
M00_L52:
       mov       rcx,rsi
       call      qword ptr [7FFA02E46880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L53:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L54:
       mov       ecx,9
       call      qword ptr [7FFA0326DA28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L55:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D193C00510
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L56:
       mov       rax,21212CE62A0
       jmp       near ptr M00_L09
M00_L57:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D193C00510
       mov       r13,[rcx]
       jmp       near ptr M00_L11
M00_L58:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L59:
       mov       rcx,rdi
       mov       rdx,r15
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L45
       sub       rsp,38
       mov       rcx,1D17DC01D08
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B5FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-228]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA02F94F30]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L60
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFA02F94F48]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L61
M00_L60:
       mov       rcx,rsi
       mov       rdx,r15
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L61:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-240]
       mov       rdx,[rbp-238]
       call      qword ptr [7FFA02F9FB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,38
       ret
; Total bytes of code 3137
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1D17DC01CD8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1D17DC01CD8
       xor       edx,edx
       jmp       qword ptr [7FFA02F97810]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rdx
       mov       rsi,rcx
       mov       r14,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M02_L02
       test      rdi,rdi
       je        near ptr M02_L03
       mov       r15,[rsi+8]
       mov       r13,[r15+8]
       cmp       byte ptr [rsi+19],0
       je        near ptr M02_L04
       mov       rcx,rbx
       lea       r11,[7FFA8C6C10A8]
       call      qword ptr [r11]
       mov       r12d,eax
M02_L00:
       mov       rcx,r14
       call      qword ptr [7FFA8C6C1960]
       mov       rcx,rax
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r12d
       call      qword ptr [7FFA8C6C23E0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M02_L01
       mov       rdx,rbx
       mov       r8,[rbp+30]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA8C6C2408]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M02_L01:
       mov       rax,[rbp-48]
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
M02_L02:
       mov       rcx,[7FFA8C6C27B0]
       mov       rcx,[rcx]
       call      qword ptr [7FFA8C6C1F78]
       int       3
M02_L03:
       mov       rcx,[7FFA8C6C28F0]
       mov       rcx,[rcx]
       call      qword ptr [7FFA8C6C1F78]
       int       3
M02_L04:
       mov       rcx,[rsi]
       call      qword ptr [7FFA8C6C18E8]
       mov       rcx,r13
       mov       r11,rax
       mov       rdx,rbx
       call      qword ptr [rax]
       mov       r12d,eax
       jmp       near ptr M02_L00
; Total bytes of code 291
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
       jne       near ptr M03_L10
       and       esi,0FFFFFFF7
M03_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M03_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M03_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M03_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M03_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M03_L14
M03_L02:
       mov       rcx,21212CEFFF8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,21212CE1518
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,21212CE1518
       cmp       r8,rcx
       je        short M03_L05
       cmp       dword ptr [r8+8],2
       jne       short M03_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L09
M03_L05:
       and       esi,0FFFFFFFB
M03_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       mov       r8d,2
       jmp       near ptr M03_L01
M03_L08:
       mov       ecx,38A0
       mov       rdx,7FFA02D714E8
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA03396BB0]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       cmp       edx,9
       je        short M03_L11
       mov       ecx,38A0
       mov       rdx,7FFA02D714E8
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA03396B68]
       int       3
M03_L11:
       or        esi,8
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,38A0
       mov       rdx,7FFA02D714E8
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFA03396B80]
       int       3
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FFA02D714E8
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA03396B98]
       int       3
M03_L14:
       mov       r8,21212CE1518
       mov       [rcx+50],r8
       jmp       near ptr M03_L02
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
       mov       rcx,1D17DC00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M04_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M04_L02
M04_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M04_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M04_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M04_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M04_L03
M04_L01:
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
M04_L02:
       mov       ecx,0A
       call      qword ptr [7FFA0326DA28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA03395320]
       jmp       short M04_L01
M04_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M04_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M04_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFA0287B1BC],0
       je        short M04_L05
       call      qword ptr [7FFA03395338]
       mov       ebx,eax
       jmp       short M04_L07
M04_L05:
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M04_L06
       call      qword ptr [7FFA03395368]
       mov       ebx,eax
       jmp       short M04_L07
M04_L06:
       sar       ebx,10
M04_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFA0287B1B0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M04_L11
M04_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M04_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFA02E4D938]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M04_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M04_L09:
       mov       rcx,r13
       call      qword ptr [7FFA02936820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M04_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M04_L10
       xor       ebx,ebx
M04_L10:
       inc       r15d
M04_L11:
       cmp       [r14+8],r15d
       jg        short M04_L08
       jmp       short M04_L13
M04_L12:
       mov       r14,r12
       jmp       short M04_L14
M04_L13:
       xor       r14d,r14d
M04_L14:
       test      r14,r14
       je        short M04_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       mov       rcx,r14
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA03395320]
       jmp       near ptr M04_L01
M04_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L18
M04_L16:
       test      ebx,ebx
       jne       short M04_L17
       mov       rax,21212CE62A0
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
M04_L17:
       mov       ecx,ebx
       mov       rdx,21212CE6F28
       call      qword ptr [7FFA02B5D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M04_L18:
       cmp       ebx,800
       jge       short M04_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L20
M04_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFA02F97C78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA03395320]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFA03395380]
       jmp       near ptr M04_L01
M04_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 798
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
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbx]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M05_L23
       mov       rcx,1D17DC01E00
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1D17DC00C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L04
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M05_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M05_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M05_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M05_L05
M05_L01:
       mov       rdx,r13
M05_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L03:
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
M05_L04:
       mov       ecx,0A
       call      qword ptr [7FFA0326DA28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L05:
       mov       rcx,r13
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA03395320]
       jmp       short M05_L01
M05_L06:
       mov       rcx,[rdi+10]
       cmp       [rcx+8],r15d
       jbe       near ptr M05_L18
       mov       eax,r15d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L17
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFA0287B1BC],0
       je        short M05_L07
       call      qword ptr [7FFA03395338]
       mov       ebp,eax
       jmp       short M05_L09
M05_L07:
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M05_L08
       call      qword ptr [7FFA03395368]
       mov       ebp,eax
       jmp       short M05_L09
M05_L08:
       sar       ebp,10
M05_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFA0287B1B0]
       mov       esi,edx
       xor       ebp,ebp
       jmp       short M05_L13
M05_L10:
       cmp       esi,[r13+8]
       jae       near ptr M05_L29
       mov       ecx,esi
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFA02E4D938]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L11
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M05_L11:
       mov       rcx,r12
       call      qword ptr [7FFA02936820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M05_L14
       inc       esi
       cmp       [r13+8],esi
       jne       short M05_L12
       xor       esi,esi
M05_L12:
       inc       ebp
M05_L13:
       cmp       [r13+8],ebp
       jg        short M05_L10
       jmp       short M05_L15
M05_L14:
       mov       r13,r12
       jmp       short M05_L16
M05_L15:
       xor       r13d,r13d
M05_L16:
       test      r13,r13
       je        short M05_L17
       cmp       byte ptr [r14+9D],0
       je        near ptr M05_L01
       mov       rcx,r13
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA03395320]
       jmp       near ptr M05_L01
M05_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M05_L20
M05_L18:
       test      ebp,ebp
       jne       short M05_L19
       mov       rdx,21212CE62A0
       jmp       near ptr M05_L02
M05_L19:
       mov       ecx,ebp
       mov       rdx,21212CE6F28
       call      qword ptr [7FFA02B5D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L20:
       cmp       ebp,800
       jge       short M05_L21
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M05_L22
M05_L21:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FFA02F97C78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M05_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M05_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA03395320]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,ebp
       call      qword ptr [7FFA03395380]
       jmp       near ptr M05_L01
M05_L23:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M05_L24
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FFA02AADF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M05_L03
M05_L24:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M05_L25
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA03395C80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L25:
       mov       rdx,[rbx]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FFFFFC7
       cmp       rdx,7FFFFFC7
       cmovl     rax,rdx
       cmp       ecx,eax
       mov       edx,eax
       cmovge    edx,ecx
       cmp       byte ptr [rbx+10],0
       jne       short M05_L26
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M05_L27
M05_L26:
       mov       rcx,1D17DC01E00
       mov       rcx,[rcx]
       call      qword ptr [7FFA02FBB970]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M05_L27:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M05_L28
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA02AADF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M05_L28:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M05_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M05_L03
       mov       rcx,1D17DC01E00
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02FBB978]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M05_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       je        short M06_L01
M06_L00:
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFA02935C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M06_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M07_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E8
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       [rsp+0E0],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+48]
       test      rax,rax
       je        near ptr M07_L06
M07_L01:
       mov       rcx,[rax+18]
       mov       rcx,[rcx]
       mov       rax,rsi
       test      rax,rax
       je        short M07_L02
       cmp       [rax],rcx
       je        short M07_L02
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M07_L02:
       mov       [rsp+0D8],rax
       cmp       byte ptr [rbx+116],0
       jne       near ptr M07_L12
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M07_L09
       cmp       qword ptr [rsp+0D8],0
       je        near ptr M07_L09
       mov       rbp,[rbx+0B8]
       mov       rcx,[rsp+0D8]
       cmp       [rbp],bpl
       call      qword ptr [7FFA0293C9A8]; System.Object.GetType()
       mov       r9,21212CE19B8
       cmp       rax,r9
       je        near ptr M07_L09
       mov       rsi,[rbp+10]
       test      rsi,rsi
       je        short M07_L07
       mov       r9,[rsi+0C0]
       cmp       r9,rax
       jne       short M07_L07
M07_L03:
       cmp       byte ptr [rsi+11A],0
       je        near ptr M07_L08
M07_L04:
       mov       rcx,[rsi+0F8]
       test      rcx,rcx
       cmovne    rsi,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M07_L13
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       call      qword ptr [7FFA02DC9158]
M07_L05:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L06:
       mov       rdx,7FFA033D3400
       call      qword ptr [7FFA0293C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M07_L01
M07_L07:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rbp
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D5CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
M07_L08:
       mov       rcx,rsi
       call      qword ptr [7FFA02F9E298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rsi+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+11A],1
       jmp       near ptr M07_L04
M07_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+38],ymm0
       vmovdqu   ymmword ptr [rsp+58],ymm0
       vmovdqu   ymmword ptr [rsp+78],ymm0
       vmovdqu   ymmword ptr [rsp+98],ymm0
       vmovdqu   ymmword ptr [rsp+0B8],ymm0
       mov       [rsp+0A0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+98],rcx
       mov       rcx,[rsp+98]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0C8],rcx
       mov       byte ptr [rsp+86],0
       mov       byte ptr [rsp+87],0
       mov       rbp,[rbx+0B8]
       cmp       dword ptr [rbp+8C],0
       jne       short M07_L14
M07_L10:
       lea       rcx,[rsp+38]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rsp+0D8]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9F210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M07_L11:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F9FB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M07_L05
M07_L12:
       mov       rax,[rbx+148]
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M07_L11
M07_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M07_L05
M07_L14:
       mov       rcx,[rbp+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+58],rax
       cmp       dword ptr [rbp+8C],2
       jne       near ptr M07_L10
       test      rsi,rsi
       je        near ptr M07_L10
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M07_L10
       mov       rcx,[rsp+58]
       mov       rdx,rsi
       mov       rax,[rsp+58]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M07_L10
; Total bytes of code 774
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M08_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M08_L00:
       add       rsp,28
       ret
M08_L01:
       or        r8d,r9d
       jne       short M08_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFA02AA7198]
       int       3
; Total bytes of code 69
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
       mov       r8,1D17DC013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M09_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFA02AA4C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M09_L05
M09_L00:
       test      r14d,r14d
       je        near ptr M09_L03
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M09_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M09_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FFA02AA4C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M09_L08
M09_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M09_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M09_L09
M09_L03:
       mov       r15,21212CE0008
       jmp       short M09_L02
M09_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFA02ECDDB8]
       int       3
M09_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFA02ECDD88]
       add       r14d,eax
       jns       near ptr M09_L00
       call      qword ptr [7FFA02ECDDD0]
       int       3
M09_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFA02ECDDB8]
       int       3
M09_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFA02EC5C68]
       int       3
M09_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFA02ECE028]
       jmp       near ptr M09_L01
M09_L09:
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
       call      qword ptr [7FFA02ECE568]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+80],0
       jne       near ptr M10_L08
       xor       esi,esi
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       je        short M10_L02
M10_L00:
       mov       rdx,[rbx+0B8]
       mov       rcx,rdi
       call      qword ptr [7FFA6200E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M10_L01
       mov       rcx,[rax+80]
       test      rcx,rcx
       jne       short M10_L04
M10_L01:
       mov       rcx,rdi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M10_L00
M10_L02:
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       xor       ebp,ebp
       cmp       [rdi+8],ebp
       jg        short M10_L05
M10_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       rsi,rax
       jmp       short M10_L02
M10_L05:
       mov       r14,[rdi+rbp*8+10]
       mov       rdx,[rbx+0B8]
       mov       rcx,r14
       call      qword ptr [7FFA6200E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       test      r15,r15
       je        short M10_L07
       mov       rcx,[r15+80]
       test      rcx,rcx
       je        short M10_L07
       test      rsi,rsi
       je        short M10_L06
       mov       rcx,[rsi+0C0]
       mov       rdx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M10_L06
       mov       rdx,[rsi+0C0]
       mov       rcx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M10_L07
       jmp       short M10_L08
M10_L06:
       mov       rsi,r15
M10_L07:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        short M10_L05
       jmp       near ptr M10_L03
M10_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 292
```
```assembly
; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       edi,r9d
       lea       rcx,[rbx+68]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rsi+0D0]
       lea       rcx,[rbx+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+60]
       mov       rcx,[rcx+0C8]
       mov       [rbx+90],rcx
       mov       [rbx+4E],dil
       movzx     edi,byte ptr [rsp+70]
       mov       [rbx+4F],dil
       mov       rdi,[rsi+0B8]
       cmp       dword ptr [rdi+8C],0
       jne       short M11_L01
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       rcx,[rdi+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       short M11_L00
       test      rbp,rbp
       je        short M11_L00
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M11_L00
       mov       rcx,[rbx+20]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 196
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       mov       r15d,[rbx+28]
       and       r15d,7FFFFFFF
       cmp       r15d,[r14+88]
       jge       near ptr M12_L21
       cmp       byte ptr [rsi+17],0
       jne       short M12_L00
       cmp       qword ptr [rdi],0
       je        near ptr M12_L22
M12_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M12_L11
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M12_L23
M12_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M12_L25
       test      r8,r8
       je        near ptr M12_L08
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M12_L24
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M12_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,1D17DC013F8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,edi
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,[rbp+30]
       jmp       short M12_L03
M12_L02:
       mov       eax,0FFFFFFFF
M12_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M12_L06
       test      byte ptr [rbx+7C],2
       jne       short M12_L04
       movzx     eax,byte ptr [rbx+38]
       cmp       eax,10
       sete      dl
       movzx     edx,dl
       movzx     r8d,byte ptr [rbx+3A]
       cmp       eax,r8d
       sete      al
       movzx     eax,al
       or        eax,edx
       jne       short M12_L04
       mov       rcx,rbx
       call      qword ptr [7FFA03396688]
       mov       rcx,[rbp+30]
M12_L04:
       test      byte ptr [rbx+7C],1
       jne       short M12_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFA02F9F618]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M12_L07
M12_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFA033966A0]
       jmp       short M12_L07
M12_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFA03396658]
M12_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M12_L09
M12_L08:
       mov       rcx,rbx
       call      qword ptr [7FFA02F9F828]
M12_L09:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M12_L26
M12_L10:
       mov       eax,1
       jmp       near ptr M12_L33
M12_L11:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M12_L17
       cmp       byte ptr [rcx+8E],1
       je        short M12_L17
       cmp       dword ptr [rcx+40],0
       jne       short M12_L12
       mov       r8,[rcx+68]
       jmp       short M12_L14
M12_L12:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M12_L27
M12_L13:
       mov       r8,r13
       mov       rcx,[rbp+30]
M12_L14:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M12_L28
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M12_L28
       xor       r13d,r13d
M12_L15:
       test      r15d,r15d
       jne       short M12_L16
       cmp       dword ptr [r14+8C],0
       jne       near ptr M12_L29
M12_L16:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M12_L30
M12_L17:
       call      qword ptr [7FFA02F9F240]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M12_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFA02E6F598]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M12_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFA02F9F678]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M12_L19
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M12_L31
M12_L19:
       mov       eax,r15d
       jmp       near ptr M12_L33
M12_L20:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M12_L18
M12_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FFA02F9F7F8]
       int       3
M12_L22:
       mov       rcx,rbx
       call      qword ptr [7FFA02F9F828]
       jmp       near ptr M12_L10
M12_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M12_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFA02EC5D40]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M12_L09
M12_L24:
       mov       ecx,edi
       call      qword ptr [7FFA03396640]
       int       3
M12_L25:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M12_L09
M12_L26:
       mov       rcx,rsi
       call      qword ptr [7FFA02F9F798]
       int       3
M12_L27:
       mov       rcx,r13
       call      qword ptr [7FFA02E46880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M12_L13
M12_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFA033965B0]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M12_L15
M12_L29:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFA033965C8]
       test      eax,eax
       je        near ptr M12_L16
       jmp       near ptr M12_L10
M12_L30:
       mov       [rsp+20],rcx
       mov       r8,[rdi]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       lea       rax,[rcx+50]
       xor       edx,edx
       mov       r8d,2
       test      r15d,r15d
       cmove     edx,r8d
       mov       [rax+3E],dl
       test      r15d,r15d
       je        near ptr M12_L19
       cmp       byte ptr [rcx+8F],0
       je        near ptr M12_L19
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M12_L32
M12_L31:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M12_L32:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M12_L19
M12_L33:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+4F],0
       jne       short M12_L34
       call      qword ptr [7FFA03396C58]
M12_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M12_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M12_L35
       mov       rcx,rsi
       call      qword ptr [7FFA03396C70]
       test      rax,rax
       jne       near ptr M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFA03396C88]
       jmp       near ptr M12_L38
M12_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M12_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,21212CEEFC0
       cmp       [rcx],ecx
       call      qword ptr [7FFA03396CB8]
       test      eax,eax
       jne       short M12_L38
       jmp       short M12_L37
M12_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,21212CEEF70
       call      qword ptr [7FFA02B54F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA03396CA0]
       jmp       short M12_L38
M12_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA03396CD0]
M12_L38:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1287
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
       jne       short M13_L00
       cmp       qword ptr [rbx+8],0
       je        short M13_L03
M13_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M13_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M13_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M13_L06
       add       rcx,18
       add       [rcx+0C],edx
M13_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M13_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M13_L03:
       call      qword ptr [7FFA033970D8]
       int       3
M13_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M13_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA033E3160]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA03397108]
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
       call      qword ptr [7FFA03397120]
M13_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M13_L02
M13_L06:
       mov       r11,7FFA02880E28
       call      qword ptr [r11]
       jmp       near ptr M13_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M14_L01
       cmp       byte ptr [rsp+70],0
       je        short M14_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA6200D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
M14_L00:
       test      rbp,rbp
       jne       short M14_L06
       cmp       byte ptr [rsp+69],0
       je        short M14_L06
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFA6200C050]
       int       3
M14_L01:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        short M14_L07
M14_L02:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA6200D548]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r14,rax
       cmp       byte ptr [rsp+78],0
       jne       short M14_L08
M14_L03:
       mov       rcx,[r14+10]
       test      rcx,rcx
       jne       short M14_L09
M14_L04:
       mov       rbp,[r14+8]
M14_L05:
       test      dil,dil
       je        short M14_L00
       test      rbp,rbp
       je        short M14_L00
       cmp       byte ptr [rbp+119],2
       je        short M14_L00
       jmp       short M14_L11
M14_L06:
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FFA6200D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M14_L02
M14_L08:
       cmp       byte ptr [r14+20],0
       je        short M14_L10
       jmp       short M14_L03
M14_L09:
       call      qword ptr [7FFA6200A218]
       jmp       short M14_L04
M14_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFA6200D558]
       mov       rbp,rax
       jmp       short M14_L05
M14_L11:
       mov       rcx,rbp
       call      qword ptr [7FFA6200DF90]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M14_L00
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M15_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
M15_L00:
       test      rax,rax
       je        short M15_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       test      rax,rax
       je        short M15_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       test      rax,rax
       je        short M15_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       test      rax,rax
       je        short M15_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M15_L00
M15_L01:
       mov       rax,rdx
       ret
M15_L02:
       jmp       qword ptr [7FFA0326DF50]
; Total bytes of code 88
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M16_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M16_L40
M16_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,21212CE62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M16_L39
       cmp       dword ptr [rbx+8],0
       je        near ptr M16_L39
       mov       rcx,1D17DC01E00
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M16_L41
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M16_L41
M16_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M16_L16
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolThreadLocalArray[]
       mov       edx,1B
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       mov       rcx,[r15+8]
       mov       [rbp-88],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-88],0
       je        near ptr M16_L07
       mov       rcx,[rbp-88]
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M16_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFA0326E0B8]
M16_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B5CF30]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M16_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M16_L09
M16_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M16_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M16_L06
M16_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M16_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-90],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FFA625B3160
       test      rax,rax
       je        near ptr M16_L12
M16_L05:
       mov       rcx,[rbp-90]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M16_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M16_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M16_L13
M16_L06:
       mov       rcx,r13
       call      qword ptr [7FFA0293E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L04
M16_L07:
       xor       ecx,ecx
       call      qword ptr [7FFA0326D320]
       int       3
M16_L08:
       mov       ecx,36
       call      qword ptr [7FFA0339C480]
       int       3
M16_L09:
       mov       rcx,r12
       call      qword ptr [7FFA0339C498]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L03
M16_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA0339C4B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CC5FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M16_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M16_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA0339C4C8]
       jmp       near ptr M16_L05
M16_L13:
       mov       rcx,[rbp-88]
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M16_L42
M16_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M16_L30
M16_L15:
       mov       rax,r13
M16_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M16_L26
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M16_L44
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-80],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-80]
       test      r12,r12
       je        near ptr M16_L26
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M16_L53
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M16_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFA03396B50]
M16_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFA03176C98],1
       je        near ptr M16_L45
M16_L18:
       cmp       byte ptr [7FFA0287B1BC],0
       je        near ptr M16_L46
       call      qword ptr [7FFA03395338]
       mov       edx,eax
M16_L19:
       test      byte ptr [7FFA03150BA0],1
       je        near ptr M16_L48
M16_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFA0287B1B0]
       mov       eax,edx
       mov       edx,[r13+8]
       mov       [rbp-74],edx
       test      edx,edx
       jle       near ptr M16_L52
       mov       [rbp-78],edx
M16_L21:
       cmp       eax,edx
       jae       near ptr M16_L53
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-98],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       rcx,r10
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M16_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFA0326E0B8]
M16_L22:
       mov       rax,[rbp-98]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M16_L24
       test      r8d,r8d
       je        near ptr M16_L33
M16_L23:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-6C]
       inc       ecx
       mov       rax,[rbp-98]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-68],1
M16_L24:
       mov       rcx,rax
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M16_L49
M16_L25:
       cmp       dword ptr [rbp-68],0
       je        near ptr M16_L50
       mov       r13d,1
M16_L26:
       mov       rcx,1D17DC00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M16_L39
       mov       rcx,rbx
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M16_L34
       mov       [rbp-70],eax
M16_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M16_L35
M16_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-70]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFA03395428]
       test      r13d,r15d
       jne       near ptr M16_L39
       mov       rcx,rbx
       call      qword ptr [7FFA02D5CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFA6254E4B0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M16_L36
M16_L29:
       test      r15d,r15d
       jne       near ptr M16_L37
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M16_L38
M16_L30:
       mov       r15,1D17DC01F50
       mov       r12,[r15]
       test      r12,r12
       jne       short M16_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1D17DC01F48
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M16_L31:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FFA6257B5A0
       test      rax,rax
       je        near ptr M16_L43
M16_L32:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M16_L15
M16_L33:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M16_L23
M16_L34:
       mov       rcx,rbx
       call      qword ptr [7FFA0293E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-70],eax
       jmp       near ptr M16_L27
M16_L35:
       mov       rcx,rsi
       call      qword ptr [7FFA0293E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L28
M16_L36:
       mov       rcx,rsi
       call      qword ptr [7FFA0293E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M16_L29
M16_L37:
       xor       ecx,ecx
M16_L38:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFA03395440]
M16_L39:
       dec       dword ptr [rdi+18]
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
M16_L40:
       mov       ecx,9
       call      qword ptr [7FFA0326DA28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M16_L00
M16_L41:
       mov       ecx,0A
       call      qword ptr [7FFA0326DA28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M16_L01
M16_L42:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFA0326DC50]
       jmp       near ptr M16_L14
M16_L43:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA0339C4E0]
       jmp       near ptr M16_L32
M16_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA033953F8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA02CC6070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M16_L45:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M16_L18
M16_L46:
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       mov       eax,[rax+10]
       mov       [rbp-64],eax
       mov       ecx,0C
       call      qword ptr [7FFA03395350]
       mov       edx,[rbp-64]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M16_L47
       call      qword ptr [7FFA03395368]
       mov       edx,eax
       jmp       near ptr M16_L19
M16_L47:
       sar       edx,10
       mov       [rbp-60],edx
       mov       edx,[rbp-60]
       jmp       near ptr M16_L19
M16_L48:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02935740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M16_L20
M16_L49:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFA0326DC50]
       jmp       near ptr M16_L25
M16_L50:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-74]
       cmp       edx,ecx
       jne       short M16_L51
       xor       ecx,ecx
M16_L51:
       mov       r8d,[rbp-78]
       dec       r8d
       mov       [rbp-78],r8d
       mov       eax,ecx
       jne       near ptr M16_L21
M16_L52:
       xor       r13d,r13d
       jmp       near ptr M16_L26
M16_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M16_L55
       cmp       qword ptr [rbp-88],0
       jne       short M16_L54
       xor       ecx,ecx
       call      qword ptr [7FFA0326D320]
       int       3
M16_L54:
       mov       rcx,[rbp-88]
       call      00007FFA625EDA10
       test      eax,eax
       je        short M16_L55
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFA0326DC50]
M16_L55:
       nop
       add       rsp,38
       ret
; Total bytes of code 2041
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M17_L04
       mov       edi,[rbx+8]
       cmp       edi,20
       jle       near ptr M17_L03
       cmp       [rsi],sil
       lea       r8,[rbx+0C]
       mov       [rbp-38],r8
       mov       r14,[rbp-38]
       mov       r15d,edi
       lea       r8,[rbp-40]
       lea       r9,[rbp-48]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFA0293FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-40]
       cmp       r13,7FFFFFFF
       ja        near ptr M17_L06
       cmp       r9d,r15d
       jne       near ptr M17_L05
M17_L00:
       xor       edx,edx
       mov       [rbp-38],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M17_L07
       add       rbx,0C
       mov       [rbp-50],rbx
       mov       rbx,[rbp-50]
       mov       [rbp-58],r14
       test      r15d,r15d
       je        near ptr M17_L08
       lea       r13,[r14+10]
M17_L01:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r15d
       call      qword ptr [7FFA0293FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-60]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-68]
       sub       edx,r13d
       cmp       ecx,edi
       jne       near ptr M17_L09
M17_L02:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rax,r14
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M17_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02E4ED30]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M17_L04:
       mov       ecx,0BC5
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA0326D320]
       int       3
M17_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFA033959C8]
       add       r13d,eax
       jns       near ptr M17_L00
M17_L06:
       call      qword ptr [7FFA02ECDDD0]
       int       3
M17_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFA02EC5C68]
       int       3
M17_L08:
       xor       r13d,r13d
       jmp       near ptr M17_L01
M17_L09:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFA0326EA48]
       jmp       near ptr M17_L02
; Total bytes of code 478
```
```assembly
; System.Security.Cryptography.SHA256.HashData(Byte[])
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
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       test      rbx,rbx
       je        near ptr M18_L02
       lea       rdi,[rbx+10]
       mov       ebx,[rbx+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       [rbp-88],r14
       lea       rcx,[r14+10]
       mov       [rbp-40],rdi
       mov       r9,rdi
       mov       [rbp-48],rcx
       mov       [rsp+20],ebx
       mov       dword ptr [rsp+30],20
       mov       [rsp+28],rcx
       mov       ecx,41
       xor       edx,edx
       xor       r8d,r8d
       mov       rax,7FFA02F520A0
       mov       [rbp-70],rax
       lea       rax,[M18_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3BE0
       call      rax
M18_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M18_L01
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
M18_L01:
       mov       rcx,[rbp-78]
       mov       [rsi+8],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M18_L03
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rax
       mov       r14,[rbp-88]
       mov       rax,r14
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
M18_L02:
       mov       ecx,4C93
       mov       rdx,7FFA02D70AB0
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA0326D320]
       int       3
M18_L03:
       call      qword ptr [7FFA03397270]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 325
```
```assembly
; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M19_L00
       mov       rdx,offset MT_System.Byte[]
       cmp       [rcx],rdx
       jne       near ptr M19_L13
       xor       ecx,ecx
M19_L00:
       test      rcx,rcx
       jne       near ptr M19_L14
       mov       rsi,rbx
       test      rsi,rsi
       je        short M19_L01
       mov       rdx,offset MT_System.Byte[]
       cmp       [rsi],rdx
       jne       near ptr M19_L15
M19_L01:
       test      rsi,rsi
       je        near ptr M19_L26
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.Byte[]
       cmp       rbx,rdi
       jne       near ptr M19_L16
       mov       ebp,[rsi+8]
M19_L02:
       test      ebp,ebp
       je        near ptr M19_L25
       movsxd    rdx,ebp
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       rbx,rdi
       jne       near ptr M19_L24
       mov       edi,[rsi+8]
       cmp       dword ptr [rbx+4],18
       jne       near ptr M19_L23
       cmp       edi,[rsi+8]
       ja        near ptr M19_L23
       cmp       edi,[rbp+8]
       ja        near ptr M19_L23
       mov       r8d,edi
       movzx     ecx,word ptr [rbx]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbp+10]
       test      dword ptr [rbx],1000000
       jne       near ptr M19_L17
       mov       rax,rcx
       mov       r10,rdx
       mov       r9,r8
       mov       r11,rax
       sub       r11,r10
       cmp       r11,r9
       jb        near ptr M19_L21
       mov       r11,r10
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M19_L21
       lea       r11,[r10+r9]
       lea       rdi,[rax+r9]
       cmp       r9,10
       ja        short M19_L06
       test      r8b,18
       je        short M19_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[r11-8]
       mov       [rdi-8],rdx
M19_L03:
       mov       rax,rbp
M19_L04:
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L05:
       test      r8b,4
       je        near ptr M19_L19
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[r11-4]
       mov       [rdi-4],edx
       jmp       short M19_L03
M19_L06:
       cmp       r9,40
       ja        short M19_L09
M19_L07:
       vmovups   xmm0,[r10]
       vmovups   [rax],xmm0
       cmp       r9,20
       ja        short M19_L12
M19_L08:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
       jmp       short M19_L03
M19_L09:
       cmp       r9,800
       ja        near ptr M19_L22
       cmp       r9,100
       jae       near ptr M19_L20
M19_L10:
       mov       rcx,r9
       shr       rcx,6
M19_L11:
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rax+20],ymm0
       add       rax,40
       add       r10,40
       dec       rcx
       jne       short M19_L11
       and       r9,3F
       cmp       r9,10
       ja        short M19_L07
       jmp       short M19_L08
M19_L12:
       vmovups   xmm0,[r10+10]
       vmovups   [rax+10],xmm0
       cmp       r9,30
       jbe       short M19_L08
       jmp       short M19_L18
M19_L13:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M19_L00
M19_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+30]
M19_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M19_L01
M19_L16:
       mov       rcx,rsi
       mov       r11,7FFA02880E40
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M19_L02
M19_L17:
       call      qword ptr [7FFA029357A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M19_L03
M19_L18:
       vmovups   xmm0,[r10+20]
       vmovups   [rax+20],xmm0
       jmp       near ptr M19_L08
M19_L19:
       test      r8,r8
       je        near ptr M19_L03
       movzx     r9d,byte ptr [rdx]
       mov       [rcx],r9b
       test      r8b,2
       je        near ptr M19_L03
       movsx     rcx,word ptr [r11-2]
       mov       [rdi-2],cx
       jmp       near ptr M19_L03
M19_L20:
       mov       r10,rcx
       and       r10,3F
       mov       r9,r10
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       lea       r10,[rdx+r9]
       lea       rax,[rcx+r9]
       sub       r8,r9
       mov       r9,r8
       jmp       near ptr M19_L10
M19_L21:
       cmp       rcx,rdx
       je        near ptr M19_L03
M19_L22:
       cmp       [rcx],cl
       call      qword ptr [7FFA029366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M19_L03
M19_L23:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFA0326C5E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M19_L03
M19_L24:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFA02880E48
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M19_L03
M19_L25:
       mov       rax,21212CE62A0
       jmp       near ptr M19_L04
M19_L26:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA03057AF8]
; Total bytes of code 780
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       test      rdx,rdx
       je        short M20_L01
       lea       rax,[rdx+10]
       mov       [rcx],rax
       mov       eax,[rdx+8]
       mov       [rcx+8],eax
M20_L00:
       ret
M20_L01:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M20_L00
; Total bytes of code 30
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M21_L00
       mov       rax,[rcx+18]
       ret
M21_L00:
       jmp       qword ptr [7FFA02B5FE88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       mov       [rsp+28],rcx
       cmp       qword ptr [rsp+28],0
       je        short M22_L02
       lea       rcx,[rbx+20]
       mov       r8,[rsp+28]
       test      rcx,rcx
       je        short M22_L01
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rsp+28]
       jne       short M22_L02
M22_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M22_L01:
       call      qword ptr [7FFA0326D7D0]
       int       3
M22_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F94E88]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M22_L03
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M22_L00
M22_L03:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 119
```
```assembly
; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       mov       [rcx],r8
       mov       dword ptr [rcx+8],1
       ret
; Total bytes of code 11
```
```assembly
; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       mov       [rsp+80],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rbx,rbx
       je        near ptr M24_L21
       test      rdi,rdi
       je        near ptr M24_L22
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M24_L23
       xor       edx,edx
M24_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M24_L01:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       ja        short M24_L03
M24_L02:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M24_L03:
       mov       r8d,r13d
       lea       rax,[rbx+r8*2+0C]
       mov       [rsp+38],rax
       mov       r10d,r12d
       sub       r10d,r13d
       mov       [rsp+94],r10d
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,rax
       mov       r9d,r10d
       call      qword ptr [7FFA02B5C630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+90],eax
       test      eax,eax
       jl        near ptr M24_L57
       mov       r10d,[rsp+94]
       cmp       eax,r10d
       ja        near ptr M24_L64
       test      eax,eax
       jne       near ptr M24_L24
M24_L04:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M24_L66
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       eax,r13d
       movzx     edx,word ptr [rbx+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M24_L28
       cmp       ecx,7B
       jne       near ptr M24_L58
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M24_L59
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       mov       r11d,ecx
       cmp       r11d,7D
       je        near ptr M24_L10
M24_L05:
       lea       ecx,[r11-30]
       cmp       ecx,9
       jbe       near ptr M24_L30
M24_L06:
       cmp       r11d,20
       je        near ptr M24_L31
       cmp       r11d,2C
       je        near ptr M24_L32
M24_L07:
       cmp       r11d,7D
       je        short M24_L10
       cmp       r11d,3A
       jne       near ptr M24_L61
       mov       r10d,r13d
       lea       r13d,[r10+1]
       cmp       r12d,r13d
       jbe       near ptr M24_L60
M24_L08:
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,7D
       je        short M24_L09
       cmp       r11d,7B
       je        near ptr M24_L61
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L08
       jmp       near ptr M24_L60
M24_L09:
       inc       r10d
       mov       r9d,r13d
       sub       r9d,r10d
       mov       ecx,r10d
       mov       r11d,r9d
       add       rcx,r11
       mov       r11d,r12d
       cmp       rcx,r11
       ja        near ptr M24_L62
       mov       ecx,r10d
       lea       r10,[rbx+rcx*2+0C]
       mov       r12,r10
       mov       r10d,r9d
       mov       r9d,r10d
       mov       r10,r12
M24_L10:
       inc       r13d
       xor       r12d,r12d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr M24_L63
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+48],rdx
       test      r15,r15
       jne       near ptr M24_L37
M24_L11:
       test      r12,r12
       jne       near ptr M24_L52
       mov       [rsp+0A0],eax
       test      eax,eax
       jne       short M24_L12
       mov       [rsp+0A4],r8d
       test      r8d,r8d
       jne       near ptr M24_L41
       mov       r8d,[rsp+0A4]
M24_L12:
       mov       rdx,[rsp+48]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M24_L13
       mov       r12,offset MT_System.Byte
       cmp       [rcx],r12
       jne       near ptr M24_L39
M24_L13:
       test      rcx,rcx
       mov       [rsp+30],r10
       mov       [rsp+0A4],r8d
       mov       [rsp+50],r11
       je        near ptr M24_L40
       mov       r12,[rsi+8]
       mov       r11,r12
       mov       r8d,[rsi+18]
       mov       r10d,r8d
       mov       r12d,[r12+8]
       sub       r12d,r8d
       mov       r8d,r10d
       mov       edx,r12d
       add       rdx,r8
       mov       r8d,[r11+8]
       cmp       rdx,r8
       ja        near ptr M24_L64
       mov       edx,r10d
       lea       rdx,[r11+rdx*2+10]
       mov       r8,offset MT_System.Byte
       cmp       [rcx],r8
       jne       near ptr M24_L43
       add       rcx,8
       movzx     ecx,byte ptr [rcx]
       test      r9d,r9d
       jne       near ptr M24_L42
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r11,7FFA5377C180
       add       r10,[r11+r8*8]
       sar       r10,20
       cmp       r10d,r12d
       jle       short M24_L14
       xor       r10d,r10d
       mov       [rsp+98],r10d
       jmp       near ptr M24_L18
M24_L14:
       mov       [rsp+98],r10d
       mov       [rsp+80],rdx
       movsxd    r8,r10d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M24_L20
       cmp       ecx,64
       jb        short M24_L16
       mov       r8,21212CE1234
M24_L15:
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r10d,ecx
       imul      r10,51EB851F
       shr       r10,25
       imul      r11d,r10d,64
       sub       ecx,r11d
       mov       r11,r8
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [rdx],ecx
       cmp       r10d,64
       mov       ecx,r10d
       jae       short M24_L15
M24_L16:
       cmp       ecx,0A
       jb        near ptr M24_L20
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r8,21212CE1234
       shl       ecx,2
       mov       r8d,[r8+rcx]
       mov       [rdx],r8d
M24_L17:
       xor       edx,edx
       mov       [rsp+80],rdx
       mov       r10d,1
M24_L18:
       xor       edx,edx
       mov       [rsp+80],rdx
M24_L19:
       test      r10d,r10d
       mov       [rsp+7C],r9d
       je        near ptr M24_L46
       mov       r8d,[rsp+98]
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       r10d,[rsi+18]
       mov       r9d,r10d
       mov       ecx,[rcx+8]
       sub       ecx,r10d
       mov       r11d,ecx
       add       r9,r11
       mov       edx,[rdx+8]
       cmp       r9,rdx
       ja        near ptr M24_L64
       cmp       r8d,ecx
       ja        near ptr M24_L65
       add       r10d,[rsp+98]
       mov       [rsi+18],r10d
       cmp       dword ptr [rsp+0A0],0
       je        near ptr M24_L01
       jmp       near ptr M24_L44
M24_L20:
       lea       r8d,[rcx+30]
       mov       [rdx-2],r8w
       jmp       near ptr M24_L17
M24_L21:
       mov       ecx,3B9
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rcx,rax
       call      qword ptr [7FFA0326D320]
       int       3
M24_L22:
       xor       edx,edx
       jmp       near ptr M24_L00
M24_L23:
       mov       rcx,rdi
       mov       r11,7FFA02880E60
       mov       rdx,21212CF5C28
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M24_L00
M24_L24:
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+8C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M24_L27
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        short M24_L25
       mov       r9,[rsp+38]
       movzx     r8d,word ptr [r9]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M24_L26
       movzx     r8d,word ptr [r9+2]
       mov       [rcx+2],r8w
       jmp       short M24_L26
M24_L25:
       mov       r9,[rsp+38]
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r9
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+90]
M24_L26:
       mov       r10d,eax
       add       r10d,[rsp+8C]
       mov       [rsi+18],r10d
       jmp       near ptr M24_L04
M24_L27:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FFA02AAF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+90]
       jmp       near ptr M24_L04
M24_L28:
       mov       rcx,rsi
       call      qword ptr [7FFA02AAF180]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M24_L01
M24_L29:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L05
M24_L30:
       cmp       edx,0F4240
       jl        short M24_L29
       jmp       near ptr M24_L06
M24_L31:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L06
M24_L32:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,20
       je        short M24_L32
       cmp       r11d,2D
       jne       short M24_L33
       mov       dword ptr [rsp+0A0],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       mov       eax,[rsp+0A0]
M24_L33:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M24_L59
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L35
       jmp       near ptr M24_L60
M24_L34:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+0A4],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+0A4]
       jbe       near ptr M24_L60
M24_L35:
       cmp       r13d,r12d
       jae       near ptr M24_L66
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M24_L36
       cmp       r8d,0F4240
       jl        short M24_L34
M24_L36:
       cmp       r11d,20
       jne       near ptr M24_L07
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L60
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       short M24_L36
M24_L37:
       test      r9d,r9d
       mov       [rsp+0A0],eax
       mov       [rsp+0A4],r8d
       je        near ptr M24_L45
       mov       [rsp+30],r10
       mov       [rsp+68],r10
       mov       [rsp+7C],r9d
       mov       [rsp+70],r9d
       lea       rcx,[rsp+68]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M24_L38:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+50],r11
       mov       rdx,r11
       mov       r8,[rsp+48]
       mov       r11,7FFA02880E78
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+7C]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M24_L11
M24_L39:
       mov       [rsp+7C],r9d
       mov       [rsp+30],r10
       mov       [rsp+0A4],r8d
       mov       [rsp+50],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+48]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+7C]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M24_L13
M24_L40:
       mov       [rsp+7C],r9d
       jmp       near ptr M24_L46
M24_L41:
       mov       [rsp+7C],r9d
       mov       [rsp+30],r10
       mov       [rsp+50],r11
       jmp       near ptr M24_L46
M24_L42:
       mov       r11,[rsp+30]
       mov       [rsp+68],r11
       mov       [rsp+7C],r9d
       mov       [rsp+70],r9d
       mov       [rsp+58],rdx
       mov       [rsp+60],r12d
       lea       rdx,[rsp+98]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+68]
       lea       r9,[rsp+58]
       mov       r8,rdi
       call      qword ptr [7FFA032662C8]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r10d,eax
       mov       r9d,[rsp+7C]
       jmp       near ptr M24_L19
M24_L43:
       mov       [rsp+58],rdx
       mov       [rsp+60],r12d
       mov       r12,[rsp+30]
       mov       [rsp+68],r12
       mov       [rsp+7C],r9d
       mov       [rsp+70],r9d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+58]
       lea       r9,[rsp+68]
       lea       r8,[rsp+98]
       mov       r11,7FFA02880E70
       call      qword ptr [r11]
       mov       r10d,eax
       mov       [rsp+30],r12
       mov       r9d,[rsp+7C]
       jmp       near ptr M24_L19
M24_L44:
       mov       r12d,[rsp+0A4]
       cmp       r12d,[rsp+98]
       jle       near ptr M24_L01
       mov       r8d,r12d
       sub       r8d,[rsp+98]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033960B8]
       jmp       near ptr M24_L01
M24_L45:
       mov       [rsp+7C],r9d
       mov       [rsp+30],r10
       jmp       near ptr M24_L38
M24_L46:
       mov       rdx,[rsp+48]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+40],rax
       test      rax,rax
       je        short M24_L49
       mov       rax,[rsp+40]
       mov       ecx,[rsp+7C]
       test      ecx,ecx
       je        short M24_L48
       mov       rdx,[rsp+50]
       test      rdx,rdx
       mov       r12,rdx
       jne       short M24_L47
       mov       r12,[rsp+30]
       mov       [rsp+68],r12
       mov       [rsp+70],ecx
       lea       rcx,[rsp+68]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       rax,[rsp+40]
M24_L47:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFA02880E68
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M24_L51
M24_L48:
       mov       r12,[rsp+50]
       jmp       short M24_L47
M24_L49:
       mov       r12,[rsp+48]
       test      r12,r12
       jne       short M24_L50
       xor       r12d,r12d
       jmp       short M24_L51
M24_L50:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M24_L51:
       test      r12,r12
       jne       short M24_L54
       mov       r12,21212CE0008
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
M24_L52:
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       jl        short M24_L55
M24_L53:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02AAF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M24_L01
M24_L54:
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       jmp       short M24_L52
M24_L55:
       test      eax,eax
       je        short M24_L56
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02AAF228]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033960B8]
       jmp       near ptr M24_L01
M24_L56:
       mov       r8d,[rsp+0A4]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033960B8]
       jmp       short M24_L53
M24_L57:
       mov       rbx,[rsp+38]
       mov       [rsp+68],rbx
       mov       ebx,[rsp+94]
       mov       [rsp+70],ebx
       lea       rdx,[rsp+68]
       mov       rcx,rsi
       call      qword ptr [7FFA0305D1A0]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M24_L02
M24_L58:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFA033960D0]
       int       3
M24_L59:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFA033960D0]
       int       3
M24_L60:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFA033960D0]
       int       3
M24_L61:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFA033960D0]
       int       3
M24_L62:
       mov       ecx,21
       call      qword ptr [7FFA02B578D0]
       int       3
M24_L63:
       call      qword ptr [7FFA033960E8]
       int       3
M24_L64:
       call      qword ptr [7FFA02AA7198]
       int       3
M24_L65:
       call      qword ptr [7FFA03396100]
       int       3
M24_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2485
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M25_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M25_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M25_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M25_L03
       cmp       [rdx+8],r8d
       jb        short M25_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M25_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M25_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M25_L02:
       mov       rax,21212CE0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M25_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rbx,rax
       call      qword ptr [7FFA0326D860]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B5D8D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M26_L01
       cmp       esi,[rbx+20]
       jg        short M26_L02
       test      esi,esi
       jne       near ptr M26_L03
       cmp       qword ptr [rbx+10],0
       jne       short M26_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M26_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M26_L01:
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFA0326D2F0]
       int       3
M26_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA03395C68]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5D8D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M26_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M26_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA033960B8]
       jmp       near ptr M26_L00
M26_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFA03396988]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M26_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M26_L07
       cmp       ecx,400
       jge       short M26_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M26_L06
M26_L05:
       xor       edx,edx
       call      qword ptr [7FFA02ECE7C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M26_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M26_L08
M26_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M26_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M26_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M26_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M27_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M27_L11
       cmp       dword ptr [rbx+20],0
       jl        short M27_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M27_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M27_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M27_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M27_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       jne       near ptr M27_L13
M27_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M27_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02874000
       call      qword ptr [7FFA02B57798]
       mov       rsi,rax
       call      qword ptr [7FFA03395C68]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B5D8D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M27_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M27_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA033960B8]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA03396988]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M27_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M27_L07
       cmp       ecx,400
       jge       short M27_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M27_L06
M27_L05:
       xor       edx,edx
       call      qword ptr [7FFA02ECE7C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA02AA5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M27_L08
M27_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M27_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M27_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M27_L00
M27_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M27_L00
M27_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M27_L12:
       call      qword ptr [7FFA0326D7D0]
       int       3
M27_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M27_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F94F78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       near ptr M27_L01
M27_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M27_L11
; Total bytes of code 543
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
       je        near ptr M29_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M29_L01
       test      rsi,rsi
       je        short M29_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M29_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M29_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02935818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M29_L00:
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
M29_L01:
       test      rsi,rsi
       je        short M29_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M29_L03
M29_L02:
       mov       rax,21212CE0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M29_L03:
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
M29_L04:
       call      qword ptr [7FFA0326E850]
       int       3
; Total bytes of code 244
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FFA620074E0]
       cmp       byte ptr [rax],0
       je        near ptr M30_L03
       call      qword ptr [7FFA6200DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M30_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
M30_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M30_L01:
       call      qword ptr [7FFA62009688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M30_L00
       call      qword ptr [7FFA620074D8]
       cmp       byte ptr [rax],0
       je        short M30_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFA6200F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFA6200DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M30_L00
       cmp       [rsi+10],rbx
       je        short M30_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M30_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA6200D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M30_L00
M30_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M30_L00
M30_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M30_L04
       call      qword ptr [7FFA620096A0]
       test      rax,rax
       je        near ptr M30_L00
M30_L04:
       call      qword ptr [7FFA6200BE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFA6200D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA6200B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       call      qword ptr [7FFA62008CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA6200D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M32_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFA62008CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFA6200A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA6200D570]
       mov       [rbp-20],rsi
       lea       rax,[M32_L00]
       add       rsp,28
       ret
; Total bytes of code 138
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M33_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M33_L07
M33_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M33_L08
M33_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FFA6200A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M33_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M33_L03
M33_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFA6200DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M33_L04
M33_L03:
       mov       rcx,rax
       call      qword ptr [7FFA6200A218]
       jmp       short M33_L02
M33_L04:
       cmp       byte ptr [rbp-10],0
       je        short M33_L05
       mov       rcx,rbx
       call      qword ptr [7FFA6200A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M33_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M33_L06:
       call      qword ptr [7FFA6200BE50]
       int       3
M33_L07:
       mov       rcx,rax
       call      qword ptr [7FFA6200A218]
       jmp       near ptr M33_L00
M33_L08:
       mov       rcx,rax
       call      qword ptr [7FFA6200D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M33_L01
       sub       rsp,28
       call      qword ptr [7FFA6200A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FFA62007258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M33_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FFA6200A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M33_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA54400CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M34_L01
       cmp       [rax],ecx
       jle       short M34_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M34_L03
M34_L00:
       add       rsp,20
       pop       rbx
       ret
M34_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M34_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M34_L00
M34_L02:
       cmp       [rax+4],edx
       jle       short M34_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M34_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M34_L03
       jmp       short M34_L00
M34_L03:
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
       jne       short M35_L00
       ret
M35_L00:
       jmp       qword ptr [7FFA02935C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-218],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-210],xmm4
       vmovdqa   xmmword ptr [rbp-200],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rax,[rbx+38]
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,1C8CF800220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFA02FA77F8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r15,rax
       cmp       byte ptr [r15+9F],0
       je        near ptr M00_L48
M00_L01:
       mov       rdx,[r15+18]
       test      rdx,rdx
       jne       near ptr M00_L05
       xor       esi,esi
       cmp       byte ptr [r15+9E],0
       je        near ptr M00_L04
       mov       rsi,[r15+8]
       test      rsi,rsi
       je        near ptr M00_L49
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,1C8CF801960
       mov       r9,[rcx]
       test      r9,r9
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFA0288D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,1C8CF801960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
M00_L03:
       mov       [rsp+20],rsi
       mov       rcx,rdi
       mov       rdx,7FFA02DF19F0
       mov       r8,209649619B8
       cmp       [rcx],ecx
       call      qword ptr [7FFA02D6D0F8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L50
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        short M00_L04
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L51
M00_L04:
       test      rsi,rsi
       je        near ptr M00_L46
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L05:
       mov       r15,rdx
       test      r15,r15
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r15],rcx
       jne       near ptr M00_L52
M00_L06:
       mov       rsi,[r15+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FA7B40]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r13d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L53
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L53
M00_L07:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L08
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,209649662A0
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L08:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r13d,r13d
       je        near ptr M00_L55
       mov       rcx,1C8CF801E00
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFA02FCB5C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L09:
       mov       [rbp-70],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-238],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r12+7C],8
       cmove     ecx,eax
       mov       [r12+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L13
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L10:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L56
       mov       r13,20964961518
M00_L11:
       mov       ecx,[r13+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       short M00_L12
       mov       dword ptr [r12+78],3E8
M00_L12:
       mov       [rbp-240],r12
       jmp       near ptr M00_L20
M00_L13:
       mov       eax,2
       jmp       short M00_L10
M00_L14:
       mov       rcx,[rax+8]
       mov       [rbp-238],rcx
       mov       r12,[rax+10]
       mov       rcx,[rbp-238]
       cmp       [rcx],cl
       mov       rcx,[rbp-238]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r13d
       jl        near ptr M00_L18
M00_L15:
       lea       rcx,[r12+8]
       mov       rdx,[rbp-238]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r12+7C],8
       cmove     ecx,eax
       mov       [r12+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L19
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L16:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L54
       mov       rsi,20964961518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r12+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r13d
       call      qword ptr [7FFA02FA7BD0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L15
M00_L19:
       mov       eax,2
       jmp       short M00_L16
M00_L20:
       cmp       byte ptr [r15+116],0
       jne       near ptr M00_L34
       mov       rcx,[r15+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L32
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L32
       mov       rsi,[r15+0B8]
       mov       rcx,[rbp-48]
       cmp       [rsi],sil
       call      qword ptr [7FFA0294C9A8]; System.Object.GetType()
       mov       r9,209649619B8
       cmp       rax,r9
       je        near ptr M00_L32
       mov       r15,[rsi+10]
       test      r15,r15
       je        near ptr M00_L35
       mov       r9,[r15+0C0]
       cmp       r9,rax
       jne       near ptr M00_L35
M00_L21:
       cmp       byte ptr [r15+11A],0
       je        near ptr M00_L28
M00_L22:
       mov       rcx,[r15+0F8]
       test      rcx,rcx
       cmovne    r15,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L40
       mov       rsi,[rbp-48]
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L23
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       cmp       [rcx],rax
       jne       near ptr M00_L36
M00_L23:
       mov       [rbp-118],rcx
       cmp       byte ptr [r15+116],0
       jne       near ptr M00_L37
       mov       rcx,[r15+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L30
       cmp       qword ptr [rbp-118],0
       je        near ptr M00_L30
       mov       rdi,[r15+0B8]
       mov       rcx,[rbp-118]
       cmp       [rdi],dil
       call      qword ptr [7FFA0294C9A8]; System.Object.GetType()
       mov       r9,209649619B8
       cmp       rax,r9
       je        near ptr M00_L30
       mov       r15,[rdi+10]
       test      r15,r15
       je        near ptr M00_L38
       mov       r9,[r15+0C0]
       cmp       r9,rax
       jne       near ptr M00_L38
M00_L24:
       cmp       byte ptr [r15+11A],0
       je        near ptr M00_L29
M00_L25:
       mov       rcx,[r15+0F8]
       test      rcx,rcx
       cmovne    r15,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r15],rcx
       jne       near ptr M00_L39
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-118]
       call      qword ptr [7FFA02DD9158]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M00_L26:
       xor       edx,edx
       mov       [rbp-118],rdx
M00_L27:
       mov       r9,[rbp-238]
       cmp       [r9],r9b
       mov       rdx,[rbp-238]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-1C8]
       call      qword ptr [7FFA02FAFB58]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-1C8]
       mov       eax,[rbp-1C0]
       mov       [rbp-208],rcx
       mov       [rbp-200],eax
       lea       rcx,[rbp-208]
       call      qword ptr [7FFA02ED5E48]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L41
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFA02FAE298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L22
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFA02FAE298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L25
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-1B8]
       mov       rdx,r15
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA02FAF1F8]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-1B8]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-118]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAF210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAFB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L26
M00_L32:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-110],ymm0
       vmovdqu   ymmword ptr [rbp-0F0],ymm0
       vmovdqu   ymmword ptr [rbp-0D0],ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   ymmword ptr [rbp-90],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-110]
       mov       rdx,r15
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA02FAF1F8]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAF210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L33:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAFB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L27
M00_L34:
       mov       rax,[r15+148]
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L33
M00_L35:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D6CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L21
M00_L36:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L37:
       mov       rax,[r15+148]
       mov       rdx,r12
       mov       r8,[rbp-118]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L31
M00_L38:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rdi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D6CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L39:
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-118]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L40:
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L27
M00_L41:
       mov       rcx,r12
       mov       rdx,[rbp-238]
       call      qword ptr [7FFA02FAFB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFA02A9F960]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFA030677F8]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       call      qword ptr [7FFA0306C198]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-1D8]
       call      qword ptr [7FFA0306C210]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-1D8]
       mov       edi,[rbp-1D0]
       mov       rcx,1C8CF801D08
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFA02B6FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L57
       mov       rcx,rax
       call      qword ptr [7FFA02F4E1A0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L42:
       mov       [rbp-228],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L44
       mov       r13,offset MT_System.Byte
       mov       rcx,1C8CF800100
       mov       r12,[rcx]
       mov       rax,offset MT_System.ReadOnlySpan<System.Object>
       mov       [rbp-220],rax
M00_L43:
       movzx     edx,byte ptr [rsi+r15]
       mov       [rbp-3C],edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-230],r12
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-1E0],rax
       mov       rax,[rbp-228]
       cmp       [rax],al
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1F0],xmm0
       lea       rcx,[rbp-1F0]
       lea       r8,[rbp-1E0]
       mov       rdx,[rbp-220]
       call      qword ptr [7FFA033AD9F8]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-218],xmm0
       lea       r9,[rbp-218]
       mov       rdx,[rbp-230]
       mov       rcx,[rbp-228]
       mov       r8,20964971970
       call      qword ptr [7FFA03276940]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L43
M00_L44:
       mov       rcx,[rbp-228]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B32100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-228]
       mov       rcx,r14
       call      qword ptr [7FFA02B6FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA02FA51A0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L58
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFA02FA51B8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L45:
       mov       [rbp-1F8],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-1F8]
       mov       rdx,7FFA032A5BF8
       cmp       [rcx],ecx
       call      qword ptr [7FFA032769B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L46:
       mov       rdx,[r15+20]
       mov       rcx,209649619B8
       call      qword ptr [7FFA033A5488]
       int       3
M00_L47:
       call      qword ptr [7FFA02EDE6A0]
       mov       ecx,886
       mov       rdx,7FFA02D2A368
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C24878
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D2A368
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02947840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA033AD9C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA0327E6D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFA02D67378]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFA02D6CBA0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L50:
       call      qword ptr [7FFA033A5F98]
       int       3
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FFA02E56880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L52:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L53:
       mov       ecx,9
       call      qword ptr [7FFA0327E2C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L54:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C8E5800568
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L55:
       mov       rax,209649662A0
       jmp       near ptr M00_L09
M00_L56:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C8E5800568
       mov       r13,[rcx]
       jmp       near ptr M00_L11
M00_L57:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,rdi
       mov       rdx,r15
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L45
       sub       rsp,38
       mov       rcx,1C8CF801D08
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B6FE28]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-228]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA02FA51A0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L59
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFA02FA51B8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L60
M00_L59:
       mov       rcx,rsi
       mov       rdx,r15
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L60:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp-240]
       mov       rdx,[rbp-238]
       call      qword ptr [7FFA02FAFB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,38
       ret
; Total bytes of code 3132
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1C8CF801CD8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1C8CF801CD8
       xor       edx,edx
       jmp       qword ptr [7FFA02FA7810]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       call      qword ptr [7FFA62008CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA6200D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M02_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFA62008CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFA6200A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA6200D570]
       mov       [rbp-20],rsi
       lea       rax,[M02_L00]
       add       rsp,28
       ret
; Total bytes of code 138
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rdx
       mov       rsi,rcx
       mov       r14,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M03_L04
       test      rdi,rdi
       je        near ptr M03_L05
       mov       r15,[rsi+8]
       mov       r13,[r15+8]
       cmp       byte ptr [rsi+19],0
       je        near ptr M03_L06
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
M03_L00:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L03
M03_L01:
       lea       rdx,[rbp-48]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r12d
       call      qword ptr [7FFA02CD6658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M03_L02
       mov       rcx,7FFA033D48E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,7FFA033D48E8
       call      CORINFO_HELP_DELEGATEPROFILE32
       mov       rdx,rbx
       mov       r8,[rbp+30]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02CDC510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M03_L02:
       mov       rcx,7FFA033D49F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
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
       mov       rcx,r14
       mov       rdx,7FFA033C9FC0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L01
M03_L04:
       mov       rcx,7FFA033D48D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,1
       mov       rdx,7FFA02C2ED28
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA02E565F8]
       int       3
M03_L05:
       mov       rcx,7FFA033D48DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,0B80
       mov       rdx,7FFA02C2ED28
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA02E565F8]
       int       3
M03_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rdx,7FFA033C9FD8
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L08:
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M03_L00
; Total bytes of code 461
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
       jne       near ptr M04_L10
       and       esi,0FFFFFFF7
M04_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M04_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M04_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M04_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M04_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M04_L14
M04_L02:
       mov       rcx,2096496FFF8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,20964961518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,20964961518
       cmp       r8,rcx
       je        short M04_L05
       cmp       dword ptr [r8+8],2
       jne       short M04_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L09
M04_L05:
       and       esi,0FFFFFFFB
M04_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       r8d,2
       jmp       near ptr M04_L01
M04_L08:
       mov       ecx,38A0
       mov       rdx,7FFA02D814E8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA033A7CC0]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FFA02D814E8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA033A7C78]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FFA02D814E8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFA033A7C90]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFA02D814E8
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA033A7CA8]
       int       3
M04_L14:
       mov       r8,20964961518
       mov       [rcx+50],r8
       jmp       near ptr M04_L02
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
       mov       rcx,1C8CF800C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,0A
       call      qword ptr [7FFA0327E2C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA033A5AE8]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFA0288B1BC],0
       je        short M05_L05
       call      qword ptr [7FFA033A5B00]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FFA033A5B30]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFA0288B1B0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFA02E5D938]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FFA02946820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA033A5AE8]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,209649662A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,20964966F28
       call      qword ptr [7FFA02B6D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFA02FA7C78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA033A5AE8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFA033A5B48]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 798
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
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbx]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M06_L23
       mov       rcx,1C8CF801E00
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1C8CF800C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M06_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M06_L04
M06_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M06_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M06_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M06_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M06_L05
M06_L01:
       mov       rdx,r13
M06_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L03:
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
M06_L04:
       mov       ecx,0A
       call      qword ptr [7FFA0327E2C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA033A5AE8]
       jmp       short M06_L01
M06_L06:
       mov       rcx,[rdi+10]
       cmp       [rcx+8],r15d
       jbe       near ptr M06_L18
       mov       eax,r15d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M06_L17
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFA0288B1BC],0
       je        short M06_L07
       call      qword ptr [7FFA033A5B00]
       mov       ebp,eax
       jmp       short M06_L09
M06_L07:
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M06_L08
       call      qword ptr [7FFA033A5B30]
       mov       ebp,eax
       jmp       short M06_L09
M06_L08:
       sar       ebp,10
M06_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFA0288B1B0]
       mov       esi,edx
       xor       ebp,ebp
       jmp       short M06_L13
M06_L10:
       cmp       esi,[r13+8]
       jae       near ptr M06_L29
       mov       ecx,esi
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFA02E5D938]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M06_L11
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M06_L11:
       mov       rcx,r12
       call      qword ptr [7FFA02946820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M06_L14
       inc       esi
       cmp       [r13+8],esi
       jne       short M06_L12
       xor       esi,esi
M06_L12:
       inc       ebp
M06_L13:
       cmp       [r13+8],ebp
       jg        short M06_L10
       jmp       short M06_L15
M06_L14:
       mov       r13,r12
       jmp       short M06_L16
M06_L15:
       xor       r13d,r13d
M06_L16:
       test      r13,r13
       je        short M06_L17
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       mov       rcx,r13
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA033A5AE8]
       jmp       near ptr M06_L01
M06_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L20
M06_L18:
       test      ebp,ebp
       jne       short M06_L19
       mov       rdx,209649662A0
       jmp       near ptr M06_L02
M06_L19:
       mov       ecx,ebp
       mov       rdx,20964966F28
       call      qword ptr [7FFA02B6D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M06_L20:
       cmp       ebp,800
       jge       short M06_L21
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M06_L22
M06_L21:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FFA02FA7C78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFA033A5AE8]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,ebp
       call      qword ptr [7FFA033A5B48]
       jmp       near ptr M06_L01
M06_L23:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M06_L24
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FFA02ABDF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M06_L03
M06_L24:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M06_L25
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA033A7600]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L25:
       mov       rdx,[rbx]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FFFFFC7
       cmp       rdx,7FFFFFC7
       cmovl     rax,rdx
       cmp       ecx,eax
       mov       edx,eax
       cmovge    edx,ecx
       cmp       byte ptr [rbx+10],0
       jne       short M06_L26
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M06_L27
M06_L26:
       mov       rcx,1C8CF801E00
       mov       rcx,[rcx]
       call      qword ptr [7FFA02FCB5C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M06_L27:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M06_L28
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA02ABDF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M06_L28:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M06_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M06_L03
       mov       rcx,1C8CF801E00
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA02FCB5C8]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M06_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       je        short M07_L01
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FFA02945C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M07_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M08_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E8
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       [rsp+0E0],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+50]
       test      rax,rax
       je        near ptr M08_L06
M08_L01:
       mov       rcx,[rax+18]
       mov       rcx,[rcx]
       mov       rax,rsi
       test      rax,rax
       je        short M08_L02
       cmp       [rax],rcx
       je        short M08_L02
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M08_L02:
       mov       [rsp+0D8],rax
       cmp       byte ptr [rbx+116],0
       jne       near ptr M08_L11
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M08_L08
       cmp       qword ptr [rsp+0D8],0
       je        near ptr M08_L08
       mov       rbp,[rbx+0B8]
       mov       rcx,[rsp+0D8]
       cmp       [rbp],bpl
       call      qword ptr [7FFA0294C9A8]; System.Object.GetType()
       mov       r9,209649619B8
       cmp       rax,r9
       je        near ptr M08_L08
       mov       rsi,[rbp+10]
       test      rsi,rsi
       je        near ptr M08_L12
       mov       r9,[rsi+0C0]
       cmp       r9,rax
       jne       near ptr M08_L12
M08_L03:
       cmp       byte ptr [rsi+11A],0
       je        short M08_L07
M08_L04:
       mov       rcx,[rsi+0F8]
       test      rcx,rcx
       cmovne    rsi,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rsi],rcx
       jne       near ptr M08_L13
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       call      qword ptr [7FFA02DD9158]
M08_L05:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L06:
       mov       rdx,7FFA033F9E18
       call      qword ptr [7FFA0294C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,rsi
       call      qword ptr [7FFA02FAE298]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rsi+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+11A],1
       jmp       short M08_L04
M08_L08:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+38],ymm0
       vmovdqu   ymmword ptr [rsp+58],ymm0
       vmovdqu   ymmword ptr [rsp+78],ymm0
       vmovdqu   ymmword ptr [rsp+98],ymm0
       vmovdqu   ymmword ptr [rsp+0B8],ymm0
       mov       [rsp+0A0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+98],rcx
       mov       rcx,[rsp+98]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0C8],rcx
       mov       byte ptr [rsp+86],0
       mov       byte ptr [rsp+87],0
       mov       rbp,[rbx+0B8]
       cmp       dword ptr [rbp+8C],0
       jne       near ptr M08_L14
M08_L09:
       lea       rcx,[rsp+38]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rsp+0D8]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAF210]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FAFB40]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M08_L05
M08_L11:
       mov       rax,[rbx+148]
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M08_L10
M08_L12:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rbp
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFA02D6CB88]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L03
M08_L13:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D8]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M08_L05
M08_L14:
       mov       rcx,[rbp+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+58],rax
       cmp       dword ptr [rbp+8C],2
       jne       near ptr M08_L09
       test      rsi,rsi
       je        near ptr M08_L09
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M08_L09
       mov       rcx,[rsp+58]
       mov       rdx,rsi
       mov       rax,[rsp+58]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M08_L09
; Total bytes of code 779
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M09_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M09_L00:
       add       rsp,28
       ret
M09_L01:
       or        r8d,r9d
       jne       short M09_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M09_L00
M09_L02:
       call      qword ptr [7FFA02AB7198]
       int       3
; Total bytes of code 69
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
       mov       r8,1C8CF8013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M10_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFA02AB4C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L05
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L03
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M10_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M10_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FFA02AB4C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M10_L08
M10_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M10_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L03:
       mov       r15,20964960008
       jmp       short M10_L02
M10_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFA02EDDDB8]
       int       3
M10_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFA02EDDD88]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FFA02EDDDD0]
       int       3
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFA02EDDDB8]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFA02ED5C68]
       int       3
M10_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFA02EDE070]
       jmp       near ptr M10_L01
M10_L09:
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
       call      qword ptr [7FFA02EDE568]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+80],0
       jne       near ptr M11_L08
       xor       esi,esi
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       je        short M11_L02
M11_L00:
       mov       rdx,[rbx+0B8]
       mov       rcx,rdi
       call      qword ptr [7FFA6200E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M11_L01
       mov       rcx,[rax+80]
       test      rcx,rcx
       jne       short M11_L04
M11_L01:
       mov       rcx,rdi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M11_L00
M11_L02:
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       xor       ebp,ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
M11_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L04:
       mov       rsi,rax
       jmp       short M11_L02
M11_L05:
       mov       r14,[rdi+rbp*8+10]
       mov       rdx,[rbx+0B8]
       mov       rcx,r14
       call      qword ptr [7FFA6200E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       test      r15,r15
       je        short M11_L07
       mov       rcx,[r15+80]
       test      rcx,rcx
       je        short M11_L07
       test      rsi,rsi
       je        short M11_L06
       mov       rcx,[rsi+0C0]
       mov       rdx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L06
       mov       rdx,[rsi+0C0]
       mov       rcx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L07
       jmp       short M11_L08
M11_L06:
       mov       rsi,r15
M11_L07:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
       jmp       near ptr M11_L03
M11_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 292
```
```assembly
; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       edi,r9d
       lea       rcx,[rbx+68]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rsi+0D0]
       lea       rcx,[rbx+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+60]
       mov       rcx,[rcx+0C8]
       mov       [rbx+90],rcx
       mov       [rbx+4E],dil
       movzx     edi,byte ptr [rsp+70]
       mov       [rbx+4F],dil
       mov       rdi,[rsi+0B8]
       cmp       dword ptr [rdi+8C],0
       jne       short M12_L01
M12_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rcx,[rdi+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       short M12_L00
       test      rbp,rbp
       je        short M12_L00
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M12_L00
       mov       rcx,[rbx+20]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 196
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       mov       r15d,[rbx+28]
       and       r15d,7FFFFFFF
       cmp       r15d,[r14+88]
       jge       near ptr M13_L21
       cmp       byte ptr [rsi+17],0
       jne       short M13_L00
       cmp       qword ptr [rdi],0
       je        near ptr M13_L22
M13_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M13_L11
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M13_L23
M13_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M13_L25
       test      r8,r8
       je        near ptr M13_L08
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M13_L24
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M13_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,1C8CF8013F8
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,edi
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,[rbp+30]
       jmp       short M13_L03
M13_L02:
       mov       eax,0FFFFFFFF
M13_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M13_L06
       test      byte ptr [rbx+7C],2
       jne       short M13_L04
       movzx     eax,byte ptr [rbx+38]
       cmp       eax,10
       sete      dl
       movzx     edx,dl
       movzx     r8d,byte ptr [rbx+3A]
       cmp       eax,r8d
       sete      al
       movzx     eax,al
       or        eax,edx
       jne       short M13_L04
       mov       rcx,rbx
       call      qword ptr [7FFA033A7588]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFA02FAF618]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFA033A75A0]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFA033A7558]
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FFA02FAF828]
M13_L09:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M13_L26
M13_L10:
       mov       eax,1
       jmp       near ptr M13_L33
M13_L11:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M13_L17
       cmp       byte ptr [rcx+8E],1
       je        short M13_L17
       cmp       dword ptr [rcx+40],0
       jne       short M13_L12
       mov       r8,[rcx+68]
       jmp       short M13_L14
M13_L12:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M13_L27
M13_L13:
       mov       r8,r13
       mov       rcx,[rbp+30]
M13_L14:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M13_L28
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M13_L28
       xor       r13d,r13d
M13_L15:
       test      r15d,r15d
       jne       short M13_L16
       cmp       dword ptr [r14+8C],0
       jne       near ptr M13_L29
M13_L16:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M13_L30
M13_L17:
       call      qword ptr [7FFA02FAF240]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFA02E7F598]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFA02FAF678]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M13_L19
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M13_L31
M13_L19:
       mov       eax,r15d
       jmp       near ptr M13_L33
M13_L20:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M13_L18
M13_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FFA02FAF7F8]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FFA02FAF828]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFA02ED5D40]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M13_L09
M13_L24:
       mov       ecx,edi
       call      qword ptr [7FFA033A7540]
       int       3
M13_L25:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M13_L09
M13_L26:
       mov       rcx,rsi
       call      qword ptr [7FFA02FAF798]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FFA02E56880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFA033A74B0]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M13_L15
M13_L29:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFA033A74C8]
       test      eax,eax
       je        near ptr M13_L16
       jmp       near ptr M13_L10
M13_L30:
       mov       [rsp+20],rcx
       mov       r8,[rdi]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       lea       rax,[rcx+50]
       xor       edx,edx
       mov       r8d,2
       test      r15d,r15d
       cmove     edx,r8d
       mov       [rax+3E],dl
       test      r15d,r15d
       je        near ptr M13_L19
       cmp       byte ptr [rcx+8F],0
       je        near ptr M13_L19
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M13_L32
M13_L31:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M13_L32:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M13_L19
M13_L33:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+4F],0
       jne       short M13_L34
       call      qword ptr [7FFA033A7D68]
M13_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L35
       mov       rcx,rsi
       call      qword ptr [7FFA033A7D80]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFA033A7D98]
       jmp       near ptr M13_L38
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2096496EFC0
       cmp       [rcx],ecx
       call      qword ptr [7FFA033A7DC8]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2096496EF70
       call      qword ptr [7FFA02B64F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA033A7DB0]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFA033A7DE0]
M13_L38:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1287
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
       jne       short M14_L00
       cmp       qword ptr [rbx+8],0
       je        short M14_L03
M14_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M14_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M14_L06
       add       rcx,18
       add       [rcx+0C],edx
M14_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M14_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M14_L03:
       call      qword ptr [7FFA033AC1F8]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA0340A0D8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA033AC228]
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
       call      qword ptr [7FFA033AC240]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FFA02890FE8
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M15_L02
       cmp       byte ptr [rsp+70],0
       jne       short M15_L01
       mov       rcx,7FFA033D4830
       call      CORINFO_HELP_COUNTPROFILE32
M15_L00:
       test      rbp,rbp
       jne       near ptr M15_L08
       cmp       byte ptr [rsp+69],0
       je        near ptr M15_L07
       mov       rcx,7FFA033D4824
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFA033A5488]
       int       3
M15_L01:
       mov       rcx,7FFA033D4820
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA02D6D140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M15_L00
M15_L02:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        near ptr M15_L09
M15_L03:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA02D6D0C8]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M15_L11
M15_L04:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M15_L12
       mov       rbp,[rax+8]
M15_L05:
       test      dil,dil
       je        near ptr M15_L00
       test      rbp,rbp
       jne       short M15_L06
       mov       rcx,7FFA033D481C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,7FFA033D4818
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+119],2
       je        near ptr M15_L00
       jmp       near ptr M15_L14
M15_L07:
       mov       rcx,7FFA033D482C
       call      CORINFO_HELP_COUNTPROFILE32
M15_L08:
       mov       rcx,7FFA033D4828
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L09:
       mov       rcx,rbx
       call      qword ptr [7FFA02D6CBD0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rbp,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M15_L10
       call      qword ptr [7FFA0327E010]
       int       3
M15_L10:
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       cmove     rax,rbp
       mov       rbp,rax
       jmp       near ptr M15_L03
M15_L11:
       cmp       byte ptr [rax+20],0
       je        short M15_L13
       jmp       near ptr M15_L04
M15_L12:
       call      qword ptr [7FFA033A5F98]
       int       3
M15_L13:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFA033A5FB0]
       mov       rbp,rax
       jmp       near ptr M15_L05
M15_L14:
       mov       rcx,rbp
       call      qword ptr [7FFA02E56880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M15_L00
; Total bytes of code 411
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
M16_L00:
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M16_L00
M16_L01:
       mov       rax,rdx
       ret
M16_L02:
       jmp       qword ptr [7FFA0327E718]
; Total bytes of code 88
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M17_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M17_L40
M17_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,209649662A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L39
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L39
       mov       rcx,1C8CF801E00
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L41
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M17_L41
M17_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M17_L16
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolThreadLocalArray[]
       mov       edx,1B
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       mov       rcx,[r15+8]
       mov       [rbp-88],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-88],0
       je        near ptr M17_L07
       mov       rcx,[rbp-88]
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFA0327E880]
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B6CF30]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M17_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M17_L09
M17_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M17_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M17_L06
M17_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M17_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-90],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FFA625B3160
       test      rax,rax
       je        near ptr M17_L12
M17_L05:
       mov       rcx,[rbp-90]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M17_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M17_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M17_L13
M17_L06:
       mov       rcx,r13
       call      qword ptr [7FFA0294E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FFA0327DAE8]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FFA033ADB18]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FFA033ADB30]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA033ADB48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02CD5FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFA033ADB60]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-88]
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M17_L42
M17_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M17_L30
M17_L15:
       mov       rax,r13
M17_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M17_L26
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M17_L44
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-80],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-80]
       test      r12,r12
       je        near ptr M17_L26
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M17_L53
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFA033A7C60]
M17_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFA0317EDF0],1
       je        near ptr M17_L45
M17_L18:
       cmp       byte ptr [7FFA0288B1BC],0
       je        near ptr M17_L46
       call      qword ptr [7FFA033A5B00]
       mov       edx,eax
M17_L19:
       test      byte ptr [7FFA03158770],1
       je        near ptr M17_L48
M17_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFA0288B1B0]
       mov       eax,edx
       mov       edx,[r13+8]
       mov       [rbp-74],edx
       test      edx,edx
       jle       near ptr M17_L52
       mov       [rbp-78],edx
M17_L21:
       cmp       eax,edx
       jae       near ptr M17_L53
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-98],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-68],r9d
       mov       rcx,r10
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M17_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFA0327E880]
M17_L22:
       mov       rax,[rbp-98]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L24
       test      r8d,r8d
       je        near ptr M17_L33
M17_L23:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-6C]
       inc       ecx
       mov       rax,[rbp-98]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-68],1
M17_L24:
       mov       rcx,rax
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M17_L49
M17_L25:
       cmp       dword ptr [rbp-68],0
       je        near ptr M17_L50
       mov       r13d,1
M17_L26:
       mov       rcx,1C8CF800C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L39
       mov       rcx,rbx
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M17_L34
       mov       [rbp-70],eax
M17_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFA6254E4B0
       test      eax,eax
       je        near ptr M17_L35
M17_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-70]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFA033A5BF0]
       test      r13d,r15d
       jne       near ptr M17_L39
       mov       rcx,rbx
       call      qword ptr [7FFA02D6CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFA6254E4B0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M17_L36
M17_L29:
       test      r15d,r15d
       jne       near ptr M17_L37
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M17_L38
M17_L30:
       mov       r15,1C8CF801F50
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1C8CF801F48
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M17_L31:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FFA6257B5A0
       test      rax,rax
       je        near ptr M17_L43
M17_L32:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M17_L15
M17_L33:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M17_L23
M17_L34:
       mov       rcx,rbx
       call      qword ptr [7FFA0294E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-70],eax
       jmp       near ptr M17_L27
M17_L35:
       mov       rcx,rsi
       call      qword ptr [7FFA0294E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L28
M17_L36:
       mov       rcx,rsi
       call      qword ptr [7FFA0294E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M17_L29
M17_L37:
       xor       ecx,ecx
M17_L38:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFA033A5C08]
M17_L39:
       dec       dword ptr [rdi+18]
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
M17_L40:
       mov       ecx,9
       call      qword ptr [7FFA0327E2C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L41:
       mov       ecx,0A
       call      qword ptr [7FFA0327E2C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L42:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFA0327E418]
       jmp       near ptr M17_L14
M17_L43:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA033ADB78]
       jmp       near ptr M17_L32
M17_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA033A5BC0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA02CD6070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L45:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M17_L18
M17_L46:
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       mov       eax,[rax+10]
       mov       [rbp-64],eax
       mov       ecx,0C
       call      qword ptr [7FFA033A5B18]
       mov       edx,[rbp-64]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M17_L47
       call      qword ptr [7FFA033A5B30]
       mov       edx,eax
       jmp       near ptr M17_L19
M17_L47:
       sar       edx,10
       mov       [rbp-60],edx
       mov       edx,[rbp-60]
       jmp       near ptr M17_L19
M17_L48:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA02945740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M17_L20
M17_L49:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFA0327E418]
       jmp       near ptr M17_L25
M17_L50:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-74]
       cmp       edx,ecx
       jne       short M17_L51
       xor       ecx,ecx
M17_L51:
       mov       r8d,[rbp-78]
       dec       r8d
       mov       [rbp-78],r8d
       mov       eax,ecx
       jne       near ptr M17_L21
M17_L52:
       xor       r13d,r13d
       jmp       near ptr M17_L26
M17_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M17_L55
       cmp       qword ptr [rbp-88],0
       jne       short M17_L54
       xor       ecx,ecx
       call      qword ptr [7FFA0327DAE8]
       int       3
M17_L54:
       mov       rcx,[rbp-88]
       call      00007FFA625EDA10
       test      eax,eax
       je        short M17_L55
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFA0327E418]
M17_L55:
       nop
       add       rsp,38
       ret
; Total bytes of code 2041
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M18_L04
       mov       edi,[rbx+8]
       cmp       edi,20
       jle       near ptr M18_L03
       cmp       [rsi],sil
       lea       r8,[rbx+0C]
       mov       [rbp-38],r8
       mov       r14,[rbp-38]
       mov       r15d,edi
       lea       r8,[rbp-40]
       lea       r9,[rbp-48]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFA0294FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-40]
       cmp       r13,7FFFFFFF
       ja        near ptr M18_L06
       cmp       r9d,r15d
       jne       near ptr M18_L05
M18_L00:
       xor       edx,edx
       mov       [rbp-38],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M18_L07
       add       rbx,0C
       mov       [rbp-50],rbx
       mov       rbx,[rbp-50]
       mov       [rbp-58],r14
       test      r15d,r15d
       je        near ptr M18_L08
       lea       r13,[r14+10]
M18_L01:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r15d
       call      qword ptr [7FFA0294FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-60]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-68]
       sub       edx,r13d
       cmp       ecx,edi
       jne       near ptr M18_L09
M18_L02:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rax,r14
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA02E5ED30]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L04:
       mov       ecx,0BC5
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0327DAE8]
       int       3
M18_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFA033A68B0]
       add       r13d,eax
       jns       near ptr M18_L00
M18_L06:
       call      qword ptr [7FFA02EDDDD0]
       int       3
M18_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFA02ED5C68]
       int       3
M18_L08:
       xor       r13d,r13d
       jmp       near ptr M18_L01
M18_L09:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFA0327F210]
       jmp       near ptr M18_L02
; Total bytes of code 478
```
```assembly
; System.Security.Cryptography.SHA256.HashData(Byte[])
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
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       test      rbx,rbx
       je        near ptr M19_L02
       lea       rdi,[rbx+10]
       mov       ebx,[rbx+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       [rbp-88],r14
       lea       rcx,[r14+10]
       mov       [rbp-40],rdi
       mov       r9,rdi
       mov       [rbp-48],rcx
       mov       [rsp+20],ebx
       mov       dword ptr [rsp+30],20
       mov       [rsp+28],rcx
       mov       ecx,41
       xor       edx,edx
       xor       r8d,r8d
       mov       rax,7FFA02F620A0
       mov       [rbp-70],rax
       lea       rax,[M19_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAAD3E3BE0
       call      rax
M19_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M19_L01
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
M19_L01:
       mov       rcx,[rbp-78]
       mov       [rsi+8],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M19_L03
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rax
       mov       r14,[rbp-88]
       mov       rax,r14
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
M19_L02:
       mov       ecx,4C93
       mov       rdx,7FFA02D80AB0
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0327DAE8]
       int       3
M19_L03:
       call      qword ptr [7FFA033AC390]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 325
```
```assembly
; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M20_L00
       mov       rdx,offset MT_System.Byte[]
       cmp       [rcx],rdx
       jne       near ptr M20_L12
       xor       ecx,ecx
M20_L00:
       test      rcx,rcx
       jne       near ptr M20_L13
       mov       rsi,rbx
       test      rsi,rsi
       je        short M20_L01
       mov       rdx,offset MT_System.Byte[]
       cmp       [rsi],rdx
       jne       near ptr M20_L14
M20_L01:
       test      rsi,rsi
       je        near ptr M20_L25
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.Byte[]
       cmp       rbx,rdi
       jne       near ptr M20_L15
       mov       ebp,[rsi+8]
M20_L02:
       test      ebp,ebp
       je        near ptr M20_L24
       movsxd    rdx,ebp
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       rbx,rdi
       jne       near ptr M20_L23
       mov       edi,[rsi+8]
       cmp       dword ptr [rbx+4],18
       jne       near ptr M20_L22
       cmp       edi,[rsi+8]
       ja        near ptr M20_L22
       cmp       edi,[rbp+8]
       ja        near ptr M20_L22
       mov       r8d,edi
       movzx     ecx,word ptr [rbx]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbp+10]
       test      dword ptr [rbx],1000000
       jne       near ptr M20_L16
       mov       rax,rcx
       mov       r10,rdx
       mov       r9,r8
       mov       r11,rax
       sub       r11,r10
       cmp       r11,r9
       jb        near ptr M20_L20
       mov       r11,r10
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M20_L20
       lea       r11,[r10+r9]
       lea       rdi,[rax+r9]
       cmp       r9,10
       ja        short M20_L06
       test      r8b,18
       je        short M20_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[r11-8]
       mov       [rdi-8],rdx
M20_L03:
       mov       rax,rbp
M20_L04:
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M20_L05:
       test      r8b,4
       je        near ptr M20_L18
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[r11-4]
       mov       [rdi-4],edx
       jmp       short M20_L03
M20_L06:
       cmp       r9,40
       ja        short M20_L09
M20_L07:
       vmovups   xmm0,[r10]
       vmovups   [rax],xmm0
       cmp       r9,20
       ja        near ptr M20_L17
M20_L08:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
       jmp       short M20_L03
M20_L09:
       cmp       r9,800
       ja        near ptr M20_L21
       cmp       r9,100
       jae       near ptr M20_L19
M20_L10:
       mov       rcx,r9
       shr       rcx,6
M20_L11:
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rax+20],ymm0
       add       rax,40
       add       r10,40
       dec       rcx
       jne       short M20_L11
       and       r9,3F
       cmp       r9,10
       ja        short M20_L07
       jmp       short M20_L08
M20_L12:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M20_L00
M20_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+30]
M20_L14:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M20_L01
M20_L15:
       mov       rcx,rsi
       mov       r11,7FFA02891000
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M20_L02
M20_L16:
       call      qword ptr [7FFA029457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M20_L03
M20_L17:
       vmovups   xmm0,[r10+10]
       vmovups   [rax+10],xmm0
       cmp       r9,30
       jbe       near ptr M20_L08
       vmovups   xmm0,[r10+20]
       vmovups   [rax+20],xmm0
       jmp       near ptr M20_L08
M20_L18:
       test      r8,r8
       je        near ptr M20_L03
       movzx     r9d,byte ptr [rdx]
       mov       [rcx],r9b
       test      r8b,2
       je        near ptr M20_L03
       movsx     rcx,word ptr [r11-2]
       mov       [rdi-2],cx
       jmp       near ptr M20_L03
M20_L19:
       mov       r10,rcx
       and       r10,3F
       mov       r9,r10
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       lea       r10,[rdx+r9]
       lea       rax,[rcx+r9]
       sub       r8,r9
       mov       r9,r8
       jmp       near ptr M20_L10
M20_L20:
       cmp       rcx,rdx
       je        near ptr M20_L03
M20_L21:
       cmp       [rcx],cl
       call      qword ptr [7FFA029466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M20_L03
M20_L22:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFA0327CDB0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M20_L03
M20_L23:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFA02891008
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M20_L03
M20_L24:
       mov       rax,209649662A0
       jmp       near ptr M20_L04
M20_L25:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA0306C228]
; Total bytes of code 786
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       test      rdx,rdx
       je        short M21_L01
       lea       rax,[rdx+10]
       mov       [rcx],rax
       mov       eax,[rdx+8]
       mov       [rcx+8],eax
M21_L00:
       ret
M21_L01:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M21_L00
; Total bytes of code 30
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M22_L00
       mov       rax,[rcx+18]
       ret
M22_L00:
       jmp       qword ptr [7FFA02B6FE88]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       mov       [rsp+28],rcx
       cmp       qword ptr [rsp+28],0
       je        short M23_L02
       lea       rcx,[rbx+20]
       mov       r8,[rsp+28]
       test      rcx,rcx
       je        short M23_L01
       xor       edx,edx
       call      00007FFA62569D60
       cmp       rax,[rsp+28]
       jne       short M23_L02
M23_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M23_L01:
       call      qword ptr [7FFA0327E010]
       int       3
M23_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FA50F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M23_L03
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M23_L00
M23_L03:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 119
```
```assembly
; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       mov       [rcx],r8
       mov       dword ptr [rcx+8],1
       ret
; Total bytes of code 11
```
```assembly
; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rbx,rbx
       je        near ptr M25_L20
       test      rdi,rdi
       je        near ptr M25_L21
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M25_L22
       xor       edx,edx
M25_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
       jmp       near ptr M25_L12
M25_L01:
       inc       r10d
       mov       r9d,r13d
       sub       r9d,r10d
       mov       ecx,r10d
       mov       r11d,r9d
       add       rcx,r11
       mov       r11d,r12d
       cmp       rcx,r11
       ja        near ptr M25_L61
       mov       ecx,r10d
       lea       r10,[rbx+rcx*2+0C]
       mov       r12,r10
       mov       r10d,r9d
       mov       r9d,r10d
       mov       r10,r12
M25_L02:
       inc       r13d
       xor       r12d,r12d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr M25_L62
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+48],rdx
       test      r15,r15
       jne       near ptr M25_L36
M25_L03:
       test      r12,r12
       jne       near ptr M25_L51
       mov       [rsp+0A0],eax
       test      eax,eax
       jne       short M25_L04
       mov       [rsp+0A4],r8d
       test      r8d,r8d
       jne       near ptr M25_L40
       mov       r8d,[rsp+0A4]
M25_L04:
       mov       rdx,[rsp+48]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M25_L05
       mov       r12,offset MT_System.Byte
       cmp       [rcx],r12
       jne       near ptr M25_L38
M25_L05:
       test      rcx,rcx
       mov       [rsp+30],r10
       mov       [rsp+0A4],r8d
       mov       [rsp+50],r11
       je        near ptr M25_L39
       mov       r12,[rsi+8]
       mov       r11,r12
       mov       edx,[rsi+18]
       mov       r8d,edx
       mov       r12d,[r12+8]
       sub       r12d,edx
       mov       edx,r8d
       mov       r10d,r12d
       add       rdx,r10
       mov       r10d,[r11+8]
       cmp       rdx,r10
       ja        near ptr M25_L63
       mov       edx,r8d
       lea       rdx,[r11+rdx*2+10]
       mov       r8,offset MT_System.Byte
       cmp       [rcx],r8
       jne       near ptr M25_L42
       add       rcx,8
       movzx     ecx,byte ptr [rcx]
       test      r9d,r9d
       jne       near ptr M25_L41
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r11,7FFA5377C180
       add       r10,[r11+r8*8]
       sar       r10,20
       cmp       r10d,r12d
       jle       short M25_L06
       xor       r10d,r10d
       mov       [rsp+98],r10d
       jmp       near ptr M25_L10
       nop
M25_L06:
       mov       [rsp+98],r10d
       mov       [rsp+88],rdx
       movsxd    r8,r10d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M25_L18
       cmp       ecx,64
       jb        short M25_L08
       mov       r8,20964961234
M25_L07:
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r10d,ecx
       imul      r10,51EB851F
       shr       r10,25
       imul      r11d,r10d,64
       sub       ecx,r11d
       mov       r11,r8
       shl       ecx,2
       mov       ecx,[r11+rcx]
       mov       [rdx],ecx
       cmp       r10d,64
       mov       ecx,r10d
       jae       short M25_L07
M25_L08:
       cmp       ecx,0A
       jb        near ptr M25_L18
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r8,20964961234
       shl       ecx,2
       mov       r8d,[r8+rcx]
       mov       [rdx],r8d
M25_L09:
       xor       edx,edx
       mov       [rsp+88],rdx
       mov       r10d,1
M25_L10:
       xor       edx,edx
       mov       [rsp+88],rdx
M25_L11:
       test      r10d,r10d
       mov       [rsp+84],r9d
       je        near ptr M25_L45
       mov       r8d,[rsp+98]
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       r10d,[rsi+18]
       mov       r9d,r10d
       mov       ecx,[rcx+8]
       sub       ecx,r10d
       mov       r11d,ecx
       add       r9,r11
       mov       edx,[rdx+8]
       cmp       r9,rdx
       ja        near ptr M25_L63
       cmp       r8d,ecx
       ja        near ptr M25_L64
       add       r10d,[rsp+98]
       mov       [rsi+18],r10d
       cmp       dword ptr [rsp+0A0],0
       jne       near ptr M25_L43
M25_L12:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M25_L19
       mov       r8d,r13d
       lea       rax,[rbx+r8*2+0C]
       mov       [rsp+38],rax
       mov       r10d,r12d
       sub       r10d,r13d
       mov       [rsp+94],r10d
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,rax
       mov       r9d,r10d
       call      qword ptr [7FFA02B6C630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+90],eax
       test      eax,eax
       jl        near ptr M25_L56
       mov       r10d,[rsp+94]
       cmp       eax,r10d
       ja        near ptr M25_L63
       test      eax,eax
       jne       near ptr M25_L23
M25_L13:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M25_L65
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       eax,r13d
       movzx     edx,word ptr [rbx+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M25_L27
       cmp       ecx,7B
       jne       near ptr M25_L57
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M25_L58
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       mov       r11d,ecx
       cmp       r11d,7D
       je        near ptr M25_L02
M25_L14:
       lea       ecx,[r11-30]
       cmp       ecx,9
       jbe       near ptr M25_L29
M25_L15:
       cmp       r11d,20
       je        near ptr M25_L30
       cmp       r11d,2C
       je        near ptr M25_L31
M25_L16:
       cmp       r11d,7D
       je        near ptr M25_L02
       cmp       r11d,3A
       jne       near ptr M25_L60
       mov       r10d,r13d
       lea       r13d,[r10+1]
       cmp       r12d,r13d
       jbe       near ptr M25_L59
M25_L17:
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,7D
       je        near ptr M25_L01
       cmp       r11d,7B
       je        near ptr M25_L60
       inc       r13d
       cmp       r12d,r13d
       ja        short M25_L17
       jmp       near ptr M25_L59
M25_L18:
       lea       r8d,[rcx+30]
       mov       [rdx-2],r8w
       jmp       near ptr M25_L09
M25_L19:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M25_L20:
       mov       ecx,3B9
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rcx,rax
       call      qword ptr [7FFA0327DAE8]
       int       3
M25_L21:
       xor       edx,edx
       jmp       near ptr M25_L00
M25_L22:
       mov       rcx,rdi
       mov       r11,7FFA02891010
       mov       rdx,209649760D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M25_L00
M25_L23:
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       r10d,[rcx+rax]
       mov       [rsp+5C],r10d
       cmp       r10d,[r8+8]
       ja        short M25_L26
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        short M25_L24
       mov       r9,[rsp+38]
       movzx     r8d,word ptr [r9]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M25_L25
       movzx     r8d,word ptr [r9+2]
       mov       [rcx+2],r8w
       jmp       short M25_L25
M25_L24:
       mov       r9,[rsp+38]
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r9
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+90]
M25_L25:
       mov       r10d,[rsp+5C]
       mov       [rsi+18],r10d
       jmp       near ptr M25_L13
M25_L26:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FFA02ABF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+90]
       jmp       near ptr M25_L13
M25_L27:
       mov       rcx,rsi
       call      qword ptr [7FFA02ABF180]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M25_L12
M25_L28:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M25_L14
M25_L29:
       cmp       edx,0F4240
       jl        short M25_L28
       jmp       near ptr M25_L15
M25_L30:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M25_L15
M25_L31:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,20
       je        short M25_L31
       cmp       r11d,2D
       jne       short M25_L32
       mov       dword ptr [rsp+0A0],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       mov       eax,[rsp+0A0]
M25_L32:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M25_L58
       inc       r13d
       cmp       r12d,r13d
       ja        short M25_L34
       jmp       near ptr M25_L59
M25_L33:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+0A4],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+0A4]
       jbe       near ptr M25_L59
M25_L34:
       cmp       r13d,r12d
       jae       near ptr M25_L65
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M25_L35
       cmp       r8d,0F4240
       jl        short M25_L33
M25_L35:
       cmp       r11d,20
       jne       near ptr M25_L16
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       short M25_L35
M25_L36:
       test      r9d,r9d
       mov       [rsp+0A0],eax
       mov       [rsp+0A4],r8d
       je        near ptr M25_L44
       mov       [rsp+30],r10
       mov       [rsp+70],r10
       mov       [rsp+84],r9d
       mov       [rsp+78],r9d
       lea       rcx,[rsp+70]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M25_L37:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+50],r11
       mov       rdx,r11
       mov       r8,[rsp+48]
       mov       r11,7FFA02891028
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+84]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M25_L03
M25_L38:
       mov       [rsp+84],r9d
       mov       [rsp+30],r10
       mov       [rsp+0A4],r8d
       mov       [rsp+50],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+48]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+84]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M25_L05
M25_L39:
       mov       [rsp+84],r9d
       jmp       near ptr M25_L45
M25_L40:
       mov       [rsp+84],r9d
       mov       [rsp+30],r10
       mov       [rsp+50],r11
       jmp       near ptr M25_L45
M25_L41:
       mov       r11,[rsp+30]
       mov       [rsp+70],r11
       mov       [rsp+84],r9d
       mov       [rsp+78],r9d
       mov       [rsp+60],rdx
       mov       [rsp+68],r12d
       lea       rdx,[rsp+98]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+70]
       lea       r9,[rsp+60]
       mov       r8,rdi
       call      qword ptr [7FFA03276988]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r10d,eax
       mov       r9d,[rsp+84]
       jmp       near ptr M25_L11
M25_L42:
       mov       [rsp+60],rdx
       mov       [rsp+68],r12d
       mov       r12,[rsp+30]
       mov       [rsp+70],r12
       mov       [rsp+84],r9d
       mov       [rsp+78],r9d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+60]
       lea       r9,[rsp+70]
       lea       r8,[rsp+98]
       mov       r11,7FFA02891020
       call      qword ptr [r11]
       mov       r10d,eax
       mov       [rsp+30],r12
       mov       r9d,[rsp+84]
       jmp       near ptr M25_L11
M25_L43:
       mov       r12d,[rsp+0A4]
       cmp       r12d,[rsp+98]
       jle       near ptr M25_L12
       mov       r8d,r12d
       sub       r8d,[rsp+98]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033A6EC8]
       jmp       near ptr M25_L12
M25_L44:
       mov       [rsp+84],r9d
       mov       [rsp+30],r10
       jmp       near ptr M25_L37
M25_L45:
       mov       rdx,[rsp+48]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+40],rax
       test      rax,rax
       je        short M25_L48
       mov       rax,[rsp+40]
       mov       ecx,[rsp+84]
       test      ecx,ecx
       je        short M25_L47
       mov       rdx,[rsp+50]
       test      rdx,rdx
       mov       r12,rdx
       jne       short M25_L46
       mov       r12,[rsp+30]
       mov       [rsp+70],r12
       mov       [rsp+78],ecx
       lea       rcx,[rsp+70]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       rax,[rsp+40]
M25_L46:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFA02891018
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M25_L50
M25_L47:
       mov       r12,[rsp+50]
       jmp       short M25_L46
M25_L48:
       mov       r12,[rsp+48]
       test      r12,r12
       jne       short M25_L49
       xor       r12d,r12d
       jmp       short M25_L50
M25_L49:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M25_L50:
       test      r12,r12
       jne       short M25_L53
       mov       r12,20964960008
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
M25_L51:
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       jl        short M25_L54
M25_L52:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02ABF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M25_L12
M25_L53:
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       jmp       short M25_L51
M25_L54:
       test      eax,eax
       je        short M25_L55
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFA02ABF228]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033A6EC8]
       jmp       near ptr M25_L12
M25_L55:
       mov       r8d,[rsp+0A4]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFA033A6EC8]
       jmp       short M25_L52
M25_L56:
       mov       rbx,[rsp+38]
       mov       [rsp+70],rbx
       mov       ebx,[rsp+94]
       mov       [rsp+78],ebx
       lea       rdx,[rsp+70]
       mov       rcx,rsi
       call      qword ptr [7FFA0306D8C0]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M25_L19
M25_L57:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFA033A6EE0]
       int       3
M25_L58:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFA033A6EE0]
       int       3
M25_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFA033A6EE0]
       int       3
M25_L60:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFA033A6EE0]
       int       3
M25_L61:
       mov       ecx,21
       call      qword ptr [7FFA02B678D0]
       int       3
M25_L62:
       call      qword ptr [7FFA033A6EF8]
       int       3
M25_L63:
       call      qword ptr [7FFA02AB7198]
       int       3
M25_L64:
       call      qword ptr [7FFA033A6F10]
       int       3
M25_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2520
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M26_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       rsi,rax
M26_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M26_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M26_L03
       cmp       [rdx+8],r8d
       jb        short M26_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M26_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M26_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M26_L02:
       mov       rax,20964960008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M26_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rbx,rax
       call      qword ptr [7FFA0327E028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA02B6D8D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M27_L01
       cmp       esi,[rbx+20]
       jg        short M27_L02
       test      esi,esi
       jne       near ptr M27_L03
       cmp       qword ptr [rbx+10],0
       jne       short M27_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M27_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M27_L01:
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFA0327DAB8]
       int       3
M27_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA033A75E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6D8D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M27_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M27_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA033A6EC8]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFA033A7900]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M27_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M27_L07
       cmp       ecx,400
       jge       short M27_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M27_L06
M27_L05:
       xor       edx,edx
       call      qword ptr [7FFA02EDE7C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M27_L08
M27_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M27_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M27_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M27_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rax
       jne       near ptr M28_L13
       mov       rbp,[rbx+8]
       mov       eax,[rbp+8]
       mov       ecx,[rbx+1C]
       add       eax,ecx
       mov       rdx,[rdi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M28_L14
       cmp       dword ptr [rbx+20],0
       jl        near ptr M28_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M28_L08
       mov       eax,ecx
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M28_L07
       mov       rdi,rbx
       test      ecx,ecx
       jle       short M28_L01
M28_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M28_L00
M28_L01:
       cmp       rdi,rbx
       je        near ptr M28_L06
       add       ecx,[rbp+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       eax,[rbp+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M28_L02
       cmp       ecx,400
       jge       short M28_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M28_L04
M28_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M28_L05
M28_L03:
       xor       edx,edx
       call      qword ptr [7FFA02EDE7C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M28_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA02AB5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M28_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M28_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M28_L09
M28_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rbp+8]
       cmp       rcx,r8
       ja        near ptr M28_L12
       mov       edx,edx
       lea       rcx,[rbp+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA02D67630]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M28_L09
M28_L08:
       xor       ecx,ecx
       mov       [rbx+18],rcx
M28_L09:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M28_L16
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M28_L15
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       jne       near ptr M28_L16
M28_L10:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M28_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA02884000
       call      qword ptr [7FFA02B67798]
       mov       rsi,rax
       call      qword ptr [7FFA033A75E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA02B6D8D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M28_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA033A6F40]
       jmp       near ptr M28_L09
M28_L13:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M28_L09
M28_L14:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M28_L15:
       call      qword ptr [7FFA0327E010]
       int       3
M28_L16:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M28_L17
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02FA51E8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       near ptr M28_L10
M28_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M28_L14
; Total bytes of code 578
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
       je        near ptr M30_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M30_L01
       test      rsi,rsi
       je        short M30_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M30_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M30_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02945818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M30_L00:
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
M30_L01:
       test      rsi,rsi
       je        short M30_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M30_L03
M30_L02:
       mov       rax,20964960008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M30_L03:
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
M30_L04:
       call      qword ptr [7FFA0327F018]
       int       3
; Total bytes of code 244
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FFA620074E0]
       cmp       byte ptr [rax],0
       je        near ptr M31_L03
       call      qword ptr [7FFA6200DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M31_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
M31_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L01:
       call      qword ptr [7FFA62009688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M31_L00
       call      qword ptr [7FFA620074D8]
       cmp       byte ptr [rax],0
       je        short M31_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFA6200F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFA6200DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M31_L00
       cmp       [rsi+10],rbx
       je        short M31_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M31_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA6200D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M31_L00
M31_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M31_L00
M31_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M31_L04
       call      qword ptr [7FFA620096A0]
       test      rax,rax
       je        near ptr M31_L00
M31_L04:
       call      qword ptr [7FFA6200BE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFA6200D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA6200B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
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
       je        near ptr M33_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M33_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M33_L08
M33_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M33_L02
       mov       rcx,rsi
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M33_L01
       mov       rcx,rsi
       call      qword ptr [7FFA0327E880]
M33_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M33_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M33_L03
       mov       rcx,7FFA033DCFA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFA02E56898]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M33_L04
M33_L02:
       xor       ecx,ecx
       call      qword ptr [7FFA0327DAE8]
       int       3
M33_L03:
       mov       rcx,7FFA033DCFA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFA033A5F98]
       int       3
M33_L04:
       mov       rcx,7FFA033DCFAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M33_L10
M33_L05:
       mov       rcx,7FFA033DCFB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFA033DCFB4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M33_L06:
       call      qword ptr [7FFA033A65E0]
       int       3
M33_L07:
       mov       rcx,7FFA033DCFA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFA033A5F98]
       int       3
M33_L08:
       mov       rcx,rbx
       call      qword ptr [7FFA02D6CBD0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M33_L09
       call      qword ptr [7FFA0327E010]
       int       3
M33_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M33_L00
M33_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA0327E418]
       jmp       near ptr M33_L05
       sub       rsp,28
       call      qword ptr [7FFA033A65F8]
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
       je        short M33_L12
       mov       rcx,7FFA033DCFAC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M33_L11
       xor       ecx,ecx
       call      qword ptr [7FFA0327DAE8]
       int       3
M33_L11:
       mov       rcx,[rbp-20]
       call      00007FFA625EDA10
       test      eax,eax
       je        short M33_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFA0327E418]
M33_L12:
       mov       rcx,7FFA033DCFB0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA54400CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M34_L01
       cmp       [rax],ecx
       jle       short M34_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M34_L03
M34_L00:
       add       rsp,20
       pop       rbx
       ret
M34_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M34_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M34_L00
M34_L02:
       cmp       [rax+4],edx
       jle       short M34_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M34_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M34_L03
       jmp       short M34_L00
M34_L03:
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
       jne       short M35_L00
       ret
M35_L00:
       jmp       qword ptr [7FFA02945C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJsonJsonTypeInfo()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       mov       rcx,290CF4002E0
       mov       rdi,[rcx]
       mov       rbp,[rdi+18]
       test      rbp,rbp
       je        near ptr M00_L07
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L08
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L08
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L10
       mov       rax,7FFA53776998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L01:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFA53776998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L02:
       test      rbp,rbp
       je        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L14
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L16
       mov       rax,7FFA53776998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L18
M00_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L17
       mov       rax,7FFA53776998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L18
M00_L04:
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       byte ptr [rbp+119],2
       jne       short M00_L06
M00_L05:
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],r8d
       lea       rdx,[rsp+20]
       mov       r8,rbp
       mov       rcx,7FFA030E4CF0
       call      qword ptr [7FFA0309DC98]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+30],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       rcx,rbp
       call      qword ptr [7FFA02E86880]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M00_L05
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FFA03097978]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rcx,rax
       mov       rdx,2D14E340010
       cmp       [rcx],ecx
       call      qword ptr [7FFA03097990]; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       mov       rdx,rax
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFA02D94420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFA031056F8]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D14E341E40
       call      qword ptr [7FFA03105710]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      qword ptr [7FFA03106328]
       test      eax,eax
       jne       short M00_L12
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFA03106328]
       test      eax,eax
       je        near ptr M00_L02
M00_L12:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFA03106340]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L13:
       call      qword ptr [7FFA02F0E6A0]
       mov       ecx,874
       mov       rdx,7FFA02D5A368
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C54878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D5A368
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA031056F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA03105710]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFA02D94420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFA031056F8]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D14E341E40
       call      qword ptr [7FFA03105710]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       call      qword ptr [7FFA03106328]
       test      eax,eax
       jne       short M00_L18
       jmp       near ptr M00_L03
M00_L17:
       call      qword ptr [7FFA03106328]
       test      eax,eax
       je        near ptr M00_L04
M00_L18:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFA03106340]
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L19:
       mov       ecx,3888
       mov       rdx,7FFA02DB14E8
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA03105DD0]
       int       3
; Total bytes of code 868
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
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,5EA4AB398DFA
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M01_L15
       cmp       edi,15555555
       jg        near ptr M01_L16
       mov       rcx,290B9401E00
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,290B9400C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M01_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M01_L17
M01_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M01_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M01_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M01_L18
M01_L02:
       mov       [rbp+38],r8
M01_L03:
       test      r8,r8
       je        near ptr M01_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M01_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FFA02D97FD8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M01_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M01_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M01_L09
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
       call      qword ptr [7FFA02F054B8]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M01_L10
M01_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M01_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M01_L11
       xor       r9d,r9d
M01_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02F05548]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M01_L13
M01_L07:
       call      qword ptr [7FFA02AE7198]
       int       3
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FFA02DB14E8
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA0310F8E8]
       int       3
M01_L09:
       mov       ecx,38A0
       mov       rdx,7FFA02DB14E8
       call      qword ptr [7FFA02B97798]
       mov       rcx,rax
       call      qword ptr [7FFA0310F900]
       int       3
M01_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M01_L05
M01_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M01_L06
M01_L12:
       mov       r9d,1
       jmp       near ptr M01_L06
M01_L13:
       call      M01_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,5EA4AB398DFA
       cmp       [rbp],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
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
M01_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M01_L04
M01_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FFA02D97438]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,0A
       call      qword ptr [7FFA031065F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFA0309E250]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L19:
       mov       eax,[rbp+234]
       jmp       short M01_L21
M01_L20:
       mov       eax,[rbp+234]
M01_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M01_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FFA0309EAC0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M01_L25
M01_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M01_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FFA02E8D638]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M01_L23:
       mov       rcx,rdx
       call      qword ptr [7FFA02976820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M01_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M01_L24
       xor       r14d,r14d
M01_L24:
       mov       eax,[rbp+220]
       inc       eax
M01_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M01_L22
       jmp       short M01_L27
M01_L26:
       mov       r13,rcx
       jmp       short M01_L28
M01_L27:
       xor       r13d,r13d
M01_L28:
       test      r13,r13
       je        short M01_L30
       cmp       byte ptr [r12+9D],0
       je        short M01_L29
       mov       rcx,r13
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFA0309E250]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L29:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M01_L33
M01_L31:
       test      r13d,r13d
       jne       short M01_L32
       mov       r8,2D14E3362A0
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,r13d
       mov       rdx,2D14E336F28
       call      qword ptr [7FFA02B9D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M01_L33:
       cmp       r13d,800
       jge       short M01_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M01_L35
M01_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FFA02FD7C60]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M01_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M01_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFA0309E250]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFA0309E298]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L37:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M01_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FFA029757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,290B9401E00
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M01_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M01_L41
M01_L40:
       mov       ecx,0A
       call      qword ptr [7FFA031065F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       call      qword ptr [7FFA02FDFBA0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M01_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M01_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M01_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA0309E670]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFA028B4000
       call      qword ptr [7FFA02B97798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA02D06070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
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
       je        near ptr M01_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFA032640C0]
M01_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFA0309EAC0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M01_L51
M01_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M01_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FFA02E8D638]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L47
       test      r8d,r8d
       jne       short M01_L48
       xor       edx,edx
       mov       [rax+14],edx
M01_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M01_L47:
       mov       rcx,rax
       call      qword ptr [7FFA02976820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M01_L49
       jmp       short M01_L52
M01_L48:
       jmp       short M01_L46
M01_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M01_L50
       xor       r15d,r15d
M01_L50:
       inc       r12d
M01_L51:
       cmp       [r14+8],r12d
       jg        near ptr M01_L45
       jmp       short M01_L53
M01_L52:
       mov       r14d,1
       jmp       short M01_L54
M01_L53:
       xor       r14d,r14d
M01_L54:
       mov       rcx,290B9400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFA0310ED00]
       test      r14d,edi
       jne       short M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFA02D9CD20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L57
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       mov       ecx,esi
       xor       edx,edx
M01_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FFA0309E6E8]
M01_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
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
       je        near ptr M02_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M02_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M02_L08
M02_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,rsi
       call      00007FFA625EDAF0
       test      eax,eax
       jne       short M02_L01
       mov       rcx,rsi
       call      qword ptr [7FFA03106B98]
M02_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M02_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M02_L03
       mov       rcx,7FFA03243C80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFA02E86898]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M02_L04
M02_L02:
       xor       ecx,ecx
       call      qword ptr [7FFA03105DD0]
       int       3
M02_L03:
       mov       rcx,7FFA03243C7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFA0310F1B0]
       int       3
M02_L04:
       mov       rcx,7FFA03243C84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFA625EDA10
       test      eax,eax
       jne       near ptr M02_L10
M02_L05:
       mov       rcx,7FFA03243C88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFA03243C8C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L06:
       call      qword ptr [7FFA0310F438]
       int       3
M02_L07:
       mov       rcx,7FFA03243C78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFA0310F1B0]
       int       3
M02_L08:
       mov       rcx,rbx
       call      qword ptr [7FFA02D9CBD0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [7FFA031062F8]
       int       3
M02_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFA62569D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFA03106748]
       jmp       near ptr M02_L05
       sub       rsp,28
       call      qword ptr [7FFA0310F450]
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
       je        short M02_L12
       mov       rcx,7FFA03243C84
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M02_L11
       xor       ecx,ecx
       call      qword ptr [7FFA03105DD0]
       int       3
M02_L11:
       mov       rcx,[rbp-20]
       call      00007FFA625EDA10
       test      eax,eax
       je        short M02_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFA03106748]
M02_L12:
       mov       rcx,7FFA03243C88
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M03_L01
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L01:
       call      qword ptr [7FFA62008CB8]
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA6200D4A0]; Precode of System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA6200D4B0]; Precode of System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFA6200D4C8]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFA62007278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
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
       call      qword ptr [7FFA62009E88]; Precode of System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rcx,rbx
       call      qword ptr [7FFA6200DF48]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.IsInvalidForSerialization(System.Type)
       test      eax,eax
       jne       short M04_L00
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFA6200D440]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA6200BE28]
       int       3
; Total bytes of code 118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FFA0297FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       call      00007FFA625E4CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA02975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D14E330008
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
       call      qword ptr [7FFA03107330]
       int       3
; Total bytes of code 235
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M00_L09
       call      qword ptr [7FFA0294C9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L08
M00_L00:
       cmp       [rsi],sil
       lea       rdi,[rsi+68]
       mov       rbp,[rdi]
       test      rbp,rbp
       jne       short M00_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimePropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFA62569D60
       mov       rbp,rax
       test      rbp,rbp
       cmove     rbp,r14
M00_L01:
       mov       rsi,rbp
       mov       rdi,[rsi+20]
       test      rdi,rdi
       je        near ptr M00_L15
       mov       rcx,24D872FFD38
       call      qword ptr [7FFA029466D0]; System.String.GetNonRandomizedHashCode()
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       rbp,[rdi+8]
       mov       r14d,[rbp+8]
       mov       eax,edx
       cdq
       idiv      r14d
       mov       r15d,edx
       cmp       r15d,r14d
       jae       near ptr M00_L20
       mov       r8d,r15d
       mov       r13,[rbp+r8*8+10]
       test      r13,r13
       je        near ptr M00_L15
M00_L02:
       mov       r8,24D872FFD38
       cmp       r13,r8
       jne       near ptr M00_L11
M00_L03:
       mov       rcx,[rdi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L20
       mov       edx,r15d
       mov       rdi,[rcx+rdx*8+10]
M00_L04:
       test      rdi,rdi
       jne       short M00_L05
       mov       rcx,rsi
       mov       rdx,24D872FFD38
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFA0294D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
M00_L05:
       mov       ecx,[rdi+8]
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       [rsp+28],r8
       mov       [rsp+30],r8d
       mov       [rsp+34],ecx
       xor       esi,esi
       cmp       [rdi+8],esi
       jg        near ptr M00_L16
M00_L06:
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rcx,[rsp+30]
       mov       [rsp+48],rcx
       cmp       dword ptr [rsp+48],0
       jne       near ptr M00_L18
       xor       esi,esi
M00_L07:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       rcx,rax
       call      qword ptr [7FFA02947C30]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L09:
       xor       esi,esi
       jmp       short M00_L07
M00_L10:
       cmp       r15d,r14d
       jae       near ptr M00_L20
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        short M00_L15
       jmp       near ptr M00_L02
M00_L11:
       cmp       dword ptr [r13+8],4
       je        short M00_L13
M00_L12:
       inc       r15d
       mov       r14d,[rbp+8]
       cmp       r14d,r15d
       jg        short M00_L10
       jmp       short M00_L14
M00_L13:
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       mov       rdx,24D872FFD44
       call      qword ptr [7FFA0294FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L12
       jmp       near ptr M00_L03
M00_L14:
       sub       r15d,r14d
       jmp       short M00_L10
M00_L15:
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L16:
       mov       r8,[rdi+rsi*8+10]
       mov       ecx,[r8+58]
       and       ecx,36
       cmp       ecx,[r8+58]
       jne       short M00_L17
       lea       rcx,[rsp+20]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFA0294D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L17:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L16
       jmp       near ptr M00_L06
M00_L18:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       xor       r8d,r8d
       call      qword ptr [7FFA0305CE10]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsp+48],1
       jne       short M00_L19
       jmp       near ptr M00_L07
M00_L19:
       mov       rcx,rsi
       call      qword ptr [7FFA0305C798]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 643
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
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFA02945C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
```
```assembly
; System.String.GetNonRandomizedHashCode()
       push      rax
       xor       eax,eax
       mov       [rsp],rax
       cmp       [rcx],cl
       lea       rax,[rcx+0C]
       mov       [rsp],rax
       mov       eax,15051505
       mov       edx,15051505
       mov       r8,[rsp]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       jle       short M02_L01
M02_L00:
       add       ecx,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[r8]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[r8+4]
       add       r8,8
       cmp       ecx,2
       jg        short M02_L00
M02_L01:
       test      ecx,ecx
       jg        short M02_L03
M02_L02:
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
M02_L03:
       mov       ecx,edx
       rol       ecx,5
       add       ecx,edx
       mov       edx,ecx
       xor       edx,[r8]
       jmp       short M02_L02
; Total bytes of code 109
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       xorps     xmm4,xmm4
       movups    [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M03_L05
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L05
       cmp       r14d,1
       jne       short M03_L00
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,2E
       je        short M03_L00
       cmp       eax,2A
       jne       near ptr M03_L05
M03_L00:
       call      qword ptr [7FFA543E8B38]
       mov       rcx,[rax]
       cmp       [rcx],ecx
       mov       rdx,rbx
       call      qword ptr [7FFA54402D60]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       ja        short M03_L03
       mov       ecx,eax
       mov       rdx,rcx
       test      rdx,rdx
       je        short M03_L02
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M03_L01
       xor       edx,edx
M03_L01:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M03_L01
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       rdx,[rsp+30]
M03_L02:
       jmp       short M03_L04
M03_L03:
       movsxd    rcx,eax
       call      qword ptr [7FFA543F5AF8]
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M03_L04:
       mov       [rbp+8],rdx
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA5440D078]; Precode of System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M03_L06
M03_L05:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA5440D078]; Precode of System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L06:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA5440D080]; Precode of System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       lea       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       cmp       [rbp],r8
       je        short M03_L07
       call      qword ptr [7FFA543E7FC8]; CORINFO_HELP_FAIL_FAST
M03_L07:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 341
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
       call      00007FFA62585510
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
       mov       rax,7FFA02A81B50
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA624E2CB0
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M04_L04
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFA625ABB40
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
       call      qword ptr [7FFA0305FB28]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA0305DCE0]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA02947C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M05_L06
       cmp       rcx,rdx
       je        short M05_L04
       cmp       r8,10
       jae       short M05_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M05_L00:
       ret
M05_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L05
M05_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M05_L10
M05_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M05_L05
M05_L04:
       mov       eax,1
       ret
M05_L05:
       xor       eax,eax
       ret
M05_L06:
       cmp       r8,4
       jb        short M05_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L00
M05_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L08:
       test      r8b,1
       je        short M05_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M05_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L00
M05_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L05
       jmp       near ptr M05_L02
; Total bytes of code 237
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       eax,[rbx+10]
       test      eax,eax
       je        near ptr M06_L05
       cmp       eax,1
       je        short M06_L03
       cmp       [rbx+14],eax
       je        short M06_L02
M06_L00:
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rsi
       call      qword ptr [7FFA543E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M06_L01:
       inc       dword ptr [rbx+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       edi,[rbx+14]
       add       edi,edi
       call      qword ptr [7FFA543F1E60]
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FFA54412E50]; Precode of System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],edi
       jmp       short M06_L00
M06_L03:
       cmp       dword ptr [rbx+14],2
       jge       short M06_L04
       mov       dword ptr [rbx+14],4
M06_L04:
       call      qword ptr [7FFA543F1C30]
       mov       rcx,rax
       movsxd    rdx,dword ptr [rbx+14]
       call      qword ptr [7FFA543E8070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFA543E7FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FFA543E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M06_L00
M06_L05:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFA543E7FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 176
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       sub       rsp,28
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L00
       cmp       r8d,[rax+8]
       jae       short M07_L01
       mov       ecx,r8d
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M07_L00:
       mov       rax,[rcx+8]
       add       rsp,28
       ret
M07_L01:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 47
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        near ptr M00_L12
       call      qword ptr [7FFA0296C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M00_L11
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFA02967C30]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
M00_L01:
       cmp       [rdi],dil
       lea       rsi,[rdi+68]
       mov       rbp,[rsi]
       test      rbp,rbp
       je        near ptr M00_L13
M00_L02:
       mov       rsi,rbp
       mov       rdi,[rsi+20]
       test      rdi,rdi
       je        near ptr M00_L20
       mov       rax,25E0221FDB4
       mov       [rsp+28],rax
       mov       eax,15051505
       mov       edx,15051505
       mov       r8,[rsp+28]
       mov       ecx,4
M00_L03:
       add       ecx,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[r8]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[r8+4]
       add       r8,8
       cmp       ecx,2
       jg        short M00_L03
       test      ecx,ecx
       jg        near ptr M00_L14
M00_L04:
       imul      edx,5D588B65
       add       edx,eax
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,edx
       not       edx
       test      eax,eax
       cmovl     eax,edx
       mov       rbp,[rdi+8]
       mov       r14d,[rbp+8]
       cdq
       idiv      r14d
       mov       r15d,edx
       cmp       r15d,r14d
       jae       near ptr M00_L26
       mov       r8d,r15d
       mov       r13,[rbp+r8*8+10]
       test      r13,r13
       je        near ptr M00_L20
M00_L05:
       mov       r8,25E0221FDA8
       cmp       r13,r8
       jne       near ptr M00_L16
M00_L06:
       mov       rcx,[rdi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L26
       mov       edx,r15d
       mov       rdi,[rcx+rdx*8+10]
M00_L07:
       test      rdi,rdi
       je        near ptr M00_L21
M00_L08:
       mov       ecx,[rdi+8]
       xor       r8d,r8d
       mov       [rsp+30],r8
       mov       [rsp+38],r8
       mov       [rsp+40],r8d
       mov       [rsp+44],ecx
       xor       esi,esi
       cmp       [rdi+8],esi
       jg        near ptr M00_L22
M00_L09:
       vmovdqu   xmm0,xmmword ptr [rsp+30]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+40]
       mov       [rsp+58],rcx
       cmp       dword ptr [rsp+58],0
       jne       near ptr M00_L24
       xor       esi,esi
M00_L10:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L11:
       mov       rdi,rsi
       jmp       near ptr M00_L01
M00_L12:
       xor       esi,esi
       jmp       short M00_L10
M00_L13:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimePropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FFA62569D60
       mov       rbp,rax
       test      rbp,rbp
       cmove     rbp,r14
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,edx
       rol       ecx,5
       add       ecx,edx
       mov       edx,ecx
       xor       edx,[r8]
       jmp       near ptr M00_L04
M00_L15:
       cmp       r15d,r14d
       jae       near ptr M00_L26
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        short M00_L20
       jmp       near ptr M00_L05
M00_L16:
       cmp       dword ptr [r13+8],4
       je        short M00_L18
M00_L17:
       inc       r15d
       mov       r14d,[rbp+8]
       cmp       r14d,r15d
       jg        short M00_L15
       jmp       short M00_L19
M00_L18:
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       mov       rdx,25E0221FDB4
       call      qword ptr [7FFA0296FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L17
       jmp       near ptr M00_L06
M00_L19:
       sub       r15d,r14d
       jmp       short M00_L15
M00_L20:
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       rdx,25E0221FDA8
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFA0296D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L22:
       mov       r8,[rdi+rsi*8+10]
       mov       ecx,[r8+58]
       and       ecx,36
       cmp       ecx,[r8+58]
       jne       short M00_L23
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFA0296D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L23:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L22
       jmp       near ptr M00_L09
M00_L24:
       lea       rcx,[rsp+48]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       xor       r8d,r8d
       call      qword ptr [7FFA031BD098]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsp+58],1
       jne       short M00_L25
       jmp       near ptr M00_L10
M00_L25:
       mov       rcx,rsi
       call      qword ptr [7FFA031B64F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 765
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
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFA02965C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
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
       je        near ptr M02_L08
M02_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M02_L09
M02_L01:
       test      rdi,rdi
       jne       near ptr M02_L07
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
       call      00007FFA62585510
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L10
M02_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M02_L05
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
       mov       rax,7FFA02AA1B50
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA624E2CB0
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA628A3B10],0
       je        short M02_L04
       call      qword ptr [7FFA62891648]; CORINFO_HELP_STOP_FOR_GC
M02_L04:
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
M02_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFA625ABB40
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M02_L11
M02_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M02_L07:
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
M02_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFA031BD3C8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA0308F378]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA02967C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M02_L02
M02_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M03_L14
       cmp       rsi,rdi
       je        near ptr M03_L04
       cmp       rbx,20
       jae       near ptr M03_L06
       mov       rcx,7FFA030CCD08
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M03_L01
       mov       rcx,7FFA030CCD20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFA030CCD24
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M03_L00:
       mov       rcx,7FFA030CCCEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M03_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M03_L05
M03_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M03_L18
       mov       rcx,7FFA030CCD0C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M03_L10
       mov       rcx,7FFA030CCD10
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FFA030CCCF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       rcx,7FFA030CCD1C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M03_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L08
M03_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M03_L11
       mov       rcx,7FFA030CCD00
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M03_L07
M03_L08:
       mov       rcx,7FFA030CCD04
       call      CORINFO_HELP_COUNTPROFILE32
M03_L09:
       mov       rcx,7FFA030CCD28
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L10:
       mov       rcx,7FFA030CCD14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L11:
       mov       rcx,7FFA030CCCF4
       call      CORINFO_HELP_COUNTPROFILE32
M03_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       mov       rcx,7FFA030CCCF8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L04
M03_L13:
       mov       rcx,7FFA030CCCFC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L14:
       cmp       rbx,4
       jb        short M03_L15
       mov       rcx,7FFA030CCCE8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M03_L00
M03_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M03_L16
       mov       rcx,7FFA030CCCE0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M03_L16:
       test      bl,1
       je        short M03_L17
       mov       rcx,7FFA030CCCE4
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M03_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M03_L00
M03_L18:
       mov       rcx,7FFA030CCD18
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M03_L05
       jmp       near ptr M03_L02
; Total bytes of code 686
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,34846B943015
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M04_L07
       mov       r15d,[rbx+8]
       test      r15d,r15d
       je        near ptr M04_L07
       cmp       r14d,1
       je        near ptr M04_L08
M04_L00:
       mov       r8,21D6D400220
       mov       r13,[r8]
       lea       r8,[rbx+0C]
       mov       [rbp+38],r8
       mov       r12,[rbp+38]
       lea       r8,[rbp+28]
       lea       r9,[rbp+20]
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FFA0296FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r12
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp+28]
       cmp       rax,7FFFFFFF
       ja        near ptr M04_L10
       mov       [rbp+34],eax
       cmp       r9d,r15d
       jne       near ptr M04_L09
M04_L01:
       xor       edx,edx
       mov       [rbp+38],rdx
       mov       eax,[rbp+34]
       cmp       eax,400
       ja        near ptr M04_L11
       mov       edx,eax
       mov       r8,rdx
       test      r8,r8
       je        short M04_L03
       mov       rcx,r8
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M04_L02
       xor       ecx,ecx
M04_L02:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M04_L02
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M04_L03:
       mov       r15d,eax
M04_L04:
       mov       [rbp+10],r8
       mov       [rbp+18],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA0296D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
M04_L05:
       lea       rdx,[rbp+40]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA0296D578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+40]
       mov       r8,34846B943015
       cmp       [rbp+8],r8
       je        short M04_L06
       call      CORINFO_HELP_FAIL_FAST
M04_L06:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L07:
       xor       r8d,r8d
       mov       [rbp+10],r8
       mov       [rbp+18],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,25E02210008
       call      qword ptr [7FFA0296D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
       jmp       short M04_L05
M04_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M04_L00
       cmp       word ptr [rbx+0C],2A
       je        near ptr M04_L00
       jmp       short M04_L07
M04_L09:
       mov       rcx,r13
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFA031B7DC8]
       add       eax,[rbp+34]
       mov       r15d,eax
       test      r15d,r15d
       mov       [rbp+34],r15d
       jge       near ptr M04_L01
M04_L10:
       call      qword ptr [7FFA02EFDDD0]
       int       3
M04_L11:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
       jmp       near ptr M04_L04
; Total bytes of code 521
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rdx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ecx,[rbx+10]
       test      ecx,ecx
       je        near ptr M05_L08
       cmp       ecx,1
       je        near ptr M05_L04
       cmp       [rbx+14],ecx
       je        short M05_L02
       mov       rcx,7FFA03101D80
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,7FFA03101D78
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rdi
       call      qword ptr [7FFA029657B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M05_L01:
       mov       rcx,7FFA03101D7C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,7FFA03101D74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,[rbx+14]
       add       ebp,ebp
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M05_L09
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L09
M05_L03:
       mov       rdx,rbx
       mov       r8d,ebp
       call      qword ptr [7FFA0296D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],ebp
       jmp       short M05_L00
M05_L04:
       cmp       dword ptr [rbx+14],2
       jge       short M05_L05
       mov       rcx,7FFA03101D70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbx+14],4
M05_L05:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L07
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L07
M05_L06:
       movsxd    rdx,dword ptr [rbx+14]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FFA029657B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M05_L00
M05_L07:
       mov       rcx,rsi
       mov       rdx,7FFA030E9F70
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
M05_L08:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L09:
       mov       rcx,rsi
       mov       rdx,7FFA030E9F50
       call      qword ptr [7FFA0296C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L03
; Total bytes of code 347
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       sub       rsp,28
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L00
       cmp       r8d,[rax+8]
       jae       short M06_L01
       mov       ecx,r8d
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M06_L00:
       mov       rax,[rcx+8]
       add       rsp,28
       ret
M06_L01:
       call      qword ptr [7FFA543E7FC0]
       int       3
; Total bytes of code 47
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       cmp       qword ptr [rcx+48],0
       setne     al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 19
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       cmp       qword ptr [rcx+38],0
       setne     al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 19
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       cmp       qword ptr [rcx+48],0
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 19
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       cmp       qword ptr [rcx+38],0
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 19
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       vmovdqu   xmm0,xmmword ptr [rsi+40]
       vmovdqu   xmmword ptr [rdi+40],xmm0
       mov       rcx,[rsi+50]
       mov       [rdi+50],rcx
       mov       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+30]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,22F49D51970
       mov       [rdi+28],rcx
       mov       [rsp+28],rdi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 202
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA02D71510]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
; 		return this.PropertiesToString();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass16_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2DFA73D7DE0
       mov       [rsi+8],rcx
       mov       word ptr [rsi+10],3A
       test      rbx,rbx
       je        near ptr M01_L63
       mov       rdx,[rsi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA0297C9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L64
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L00:
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        near ptr M01_L12
M01_L01:
       mov       rcx,29F120310E8
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L65
M01_L02:
       mov       rdx,[rcx+18]
       test      rdx,rdx
       je        near ptr M01_L13
M01_L03:
       cmp       rdi,rdx
       je        near ptr M01_L67
       test      rdi,rdi
       je        short M01_L04
       test      rdx,rdx
       je        short M01_L04
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L66
M01_L04:
       mov       rdx,2DFA73D0008
M01_L05:
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02FBFC00]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,29F28400250
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L68
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L75
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L69
       mov       r14,rbx
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair<System.String, System.String>[]
       cmp       [r14],rdx
       je        short M01_L07
       xor       r14d,r14d
M01_L07:
       test      r14,r14
       jne       near ptr M01_L70
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L72
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+8],eax
       lea       rcx,[r15+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rcx,29F28400258
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M01_L73
M01_L09:
       mov       rcx,29F28400260
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L74
M01_L10:
       mov       r14,rbx
       mov       r13,rdi
       test      r15,r15
       je        near ptr M01_L75
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L59
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyDictionary<System.String, System.String>
       cmp       [rax],rcx
       jne       short M01_L14
       mov       rcx,[rax+8]
       mov       r11,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       cmp       [rcx],r11
       jne       near ptr M01_L76
       mov       r12d,[rcx+38]
       sub       r12d,[rcx+40]
M01_L11:
       jmp       short M01_L15
M01_L12:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FFA02AE4AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L13:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FFA02AE4AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,rax
       mov       r11,7FFA028C1280
       call      qword ptr [r11]
       mov       r12d,eax
M01_L15:
       test      r12d,r12d
       je        near ptr M01_L81
       mov       rax,r15
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair<System.String, System.String>[]
       cmp       [rax],rdx
       je        short M01_L16
       xor       eax,eax
M01_L16:
       test      rax,rax
       jne       near ptr M01_L82
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L83
M01_L17:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      r12d,r12d
       jl        near ptr M01_L85
       test      r12d,r12d
       jle       short M01_L18
       mov       ecx,r12d
       call      qword ptr [7FFA02975A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       edi,eax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C8],rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,edi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rcx,29F12400048
       mov       rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29F12400050
       mov       rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset MT_System.Linq.Enumerable+Concat2Iterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       mov       rdi,rax
       cmp       [r15],rdi
       jne       near ptr M01_L87
       cmp       dword ptr [r15+0C],0
       jne       near ptr M01_L86
       mov       r12d,[r15+8]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r12d,eax
       jne       near ptr M01_L86
M01_L19:
       mov       dword ptr [r15+0C],1
M01_L20:
       mov       [rbp-0C0],r15
M01_L21:
       mov       rcx,[rbp-0C0]
       mov       r15,[rcx]
       cmp       r15,rdi
       jne       near ptr M01_L31
       call      qword ptr [7FFA0328F760]; System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L22:
       test      eax,eax
       je        near ptr M01_L56
       cmp       r15,rdi
       jne       near ptr M01_L32
       mov       rcx,[rbp-0C0]
       vmovdqu   xmm0,xmmword ptr [rcx+10]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M01_L23:
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__18_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [r14+18],rdx
       jne       near ptr M01_L33
       mov       r15,[rbp-48]
M01_L24:
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__18_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [r13+18],rdx
       jne       near ptr M01_L34
       mov       r12,[rbp-40]
M01_L25:
       test      r15,r15
       je        near ptr M01_L52
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L35
M01_L26:
       mov       rax,[rbx+10]
       mov       [rbp-0D0],rax
       mov       rdx,[rbx+18]
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       mov       [rbp-0D8],rdx
       cmp       [rdx],r8
       jne       near ptr M01_L49
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA029766D0]; System.String.GetNonRandomizedHashCode()
M01_L27:
       mov       [rbp-6C],eax
       xor       r8d,r8d
       mov       [rbp-70],r8d
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FFA033B7D20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       [rbp-0E0],rax
       mov       r10d,[rax]
       dec       r10d
       mov       r9,[rbp-0D0]
       mov       r11d,[r9+8]
       mov       [rbp-0B4],r11d
       cmp       r11d,r10d
       ja        near ptr M01_L39
M01_L28:
       cmp       dword ptr [rbx+40],0
       jg        near ptr M01_L42
       mov       edx,[rbx+38]
       mov       [rbp-74],edx
       cmp       r11d,edx
       je        near ptr M01_L41
M01_L29:
       mov       edx,[rbp-74]
       mov       r10d,edx
       lea       edx,[r10+1]
       mov       [rbx+38],edx
       mov       r9,[rbx+10]
M01_L30:
       cmp       r10d,[r9+8]
       jae       near ptr M01_L55
       mov       [rbp-78],r10d
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       mov       [rbp-0D0],r9
       lea       r11,[r9+rdx*8+10]
       mov       [rbp-0E8],r11
       mov       ecx,[rbp-6C]
       mov       [r11+10],ecx
       mov       rax,[rbp-0E0]
       mov       ecx,[rax]
       dec       ecx
       mov       [r11+14],ecx
       mov       rcx,r11
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rbp-0E8]
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,[rbp-78]
       inc       r15d
       mov       r12,[rbp-0E0]
       mov       [r12],r15d
       inc       dword ptr [rbx+44]
       cmp       dword ptr [rbp-70],64
       jbe       near ptr M01_L21
       jmp       near ptr M01_L51
M01_L31:
       mov       r11,7FFA028C1260
       call      qword ptr [r11]
       jmp       near ptr M01_L22
M01_L32:
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-0C0]
       mov       r11,7FFA028C1268
       call      qword ptr [r11]
       mov       rcx,[rbp-0C0]
       jmp       near ptr M01_L23
M01_L33:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       lea       rdx,[rbp-90]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       mov       rcx,[rbp-0C0]
       jmp       near ptr M01_L24
M01_L34:
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       lea       rdx,[rbp-90]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       mov       r12,rax
       mov       rcx,[rbp-0C0]
       jmp       near ptr M01_L25
M01_L35:
       mov       rax,7FFA53781408
       xor       edx,edx
       mov       r8d,48
M01_L36:
       mov       r10d,[rax+rdx]
       test      r10d,r10d
       jge       short M01_L37
       add       rdx,4
       dec       r8d
       jne       short M01_L36
       jmp       near ptr M01_L43
M01_L37:
       mov       eax,r10d
M01_L38:
       mov       [rbp-7C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F0],rax
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [rbx+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-7C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+30],rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-0F0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0C0]
       jmp       near ptr M01_L26
M01_L39:
       cmp       r10d,r11d
       jae       near ptr M01_L55
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       lea       r8,[r9+rdx*8+10]
       mov       [rbp-100],r8
       mov       ecx,[rbp-6C]
       cmp       [r8+10],ecx
       je        near ptr M01_L50
M01_L40:
       mov       r8,[rbp-100]
       mov       r10d,[r8+14]
       mov       r8d,[rbp-70]
       inc       r8d
       mov       [rbp-70],r8d
       cmp       r11d,r8d
       jb        near ptr M01_L54
       cmp       r11d,r10d
       ja        short M01_L39
       jmp       near ptr M01_L28
M01_L41:
       mov       rcx,rbx
       call      qword ptr [7FFA032AE8B0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,rbx
       mov       edx,[rbp-6C]
       call      qword ptr [7FFA033B7D20]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucket(UInt32)
       mov       [rbp-0E0],rax
       jmp       near ptr M01_L29
M01_L42:
       mov       edx,[rbx+3C]
       mov       r10d,edx
       cmp       edx,r11d
       jae       near ptr M01_L55
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r9+rdx*8+24]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rbx+3C],edx
       dec       dword ptr [rbx+40]
       jmp       near ptr M01_L30
M01_L43:
       mov       eax,1
       jmp       short M01_L46
M01_L44:
       mov       [rbp-80],eax
       mov       ecx,eax
       call      qword ptr [7FFA032AEC58]
       test      eax,eax
       je        short M01_L45
       mov       ecx,[rbp-80]
       lea       r8d,[rcx-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      r8d
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       edx,eax
       imul      edx,65
       sub       r8d,edx
       mov       [rbp-80],ecx
       jne       short M01_L47
M01_L45:
       mov       ecx,[rbp-80]
       add       ecx,2
       mov       eax,ecx
       mov       rcx,[rbp-0C0]
M01_L46:
       cmp       eax,7FFFFFFF
       jl        short M01_L44
       jmp       short M01_L48
M01_L47:
       mov       ecx,[rbp-80]
       mov       eax,ecx
       jmp       near ptr M01_L38
M01_L48:
       xor       eax,eax
       jmp       near ptr M01_L38
M01_L49:
       mov       rdx,[rbp-0D8]
       mov       [rbp-0D8],rdx
       mov       rcx,rdx
       mov       rdx,r15
       mov       r11,7FFA028C1290
       call      qword ptr [r11]
       jmp       near ptr M01_L27
M01_L50:
       cmp       r10d,r11d
       jae       near ptr M01_L55
       mov       edx,r10d
       lea       rdx,[rdx+rdx*2]
       mov       [rbp-0D0],r9
       mov       rdx,[r9+rdx*8+10]
       mov       rcx,[rbp-0D8]
       mov       r8,r15
       mov       r11,7FFA028C1298
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-0D0]
       mov       r11d,[rbp-0B4]
       je        near ptr M01_L40
       jmp       short M01_L53
M01_L51:
       mov       r12,[rbp-0D8]
       mov       r15,[rbp-0D0]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       edx,[r15+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA02AEF3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L21
M01_L52:
       mov       ecx,4
       call      qword ptr [7FFA02B9C228]
       int       3
M01_L53:
       mov       rdx,r15
       mov       rcx,7FFA03420B30
       call      qword ptr [7FFA02B9C1F8]
       int       3
M01_L54:
       call      qword ptr [7FFA02B97A08]
       int       3
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       cmp       r15,rdi
       jne       near ptr M01_L88
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFA0328F758]; System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Dispose()
M01_L57:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyDictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFA02FBFC18]; System.Collections.ObjectModel.ReadOnlyDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rcx,offset MT_System.Func<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass16_0.<PropertiesToString>b__3(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,rbx
       mov       rdx,rdi
       mov       rcx,7FFA0307BE70
       mov       r8,2DFA73D0008
       call      qword ptr [7FFA02FBFAF8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFA02B95EF0]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M01_L89
       mov       r8,[rsi+8]
       mov       edx,[r8+8]
       mov       r8d,[rbx+8]
       sub       r8d,edx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA02AEF450]; System.String.Substring(Int32, Int32)
M01_L58:
       nop
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L59:
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M01_L61
       mov       rax,offset MT_System.Linq.Enumerable+Concat2Iterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       cmp       [r12],rax
       jne       near ptr M01_L78
       mov       rdx,[r12+28]
       lea       r8,[rbp-60]
       mov       rcx,7FFA03294B68
       call      qword ptr [7FFA0323F540]; System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L77
       mov       rdx,[r12+30]
       lea       r8,[rbp-68]
       mov       rcx,7FFA03294B68
       call      qword ptr [7FFA0323F540]; System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L77
       mov       r12d,[rbp-60]
       add       r12d,[rbp-68]
       jo        near ptr M01_L90
M01_L60:
       test      r12d,r12d
       jl        short M01_L61
       jmp       near ptr M01_L15
M01_L61:
       mov       rcx,r15
       mov       rdx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       cmp       [rcx],rdx
       jne       near ptr M01_L79
       xor       ecx,ecx
M01_L62:
       test      rcx,rcx
       jne       near ptr M01_L80
       xor       r12d,r12d
       jmp       near ptr M01_L17
M01_L63:
       call      qword ptr [7FFA02F069A0]
       mov       ecx,886
       mov       rdx,7FFA02D5A368
       call      qword ptr [7FFA02B97798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFA02C54878
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFA02D5A368
       call      qword ptr [7FFA02B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA02977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA033B7498]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA032AE0B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L64:
       mov       rcx,rax
       call      qword ptr [7FFA02977C30]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L65:
       mov       rcx,2DFA73DE208
       call      qword ptr [7FFA02977C30]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L66:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFA0297FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L04
M01_L67:
       mov       rdx,2DFA73D4B70
       jmp       near ptr M01_L05
M01_L68:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29F28400248
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29F28400250
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L69:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M01_L08
M01_L70:
       cmp       dword ptr [r14+8],0
       jne       short M01_L71
       mov       rcx,offset MT_System.Array+EmptyArray<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29F28400520
       mov       r15,[rcx]
       jmp       near ptr M01_L08
M01_L71:
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFA032A4948]
       jmp       near ptr M01_L08
M01_L72:
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFA032A4960]
       jmp       near ptr M01_L08
M01_L73:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29F28400248
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29F28400258
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L74:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29F28400248
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFA02976BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29F28400260
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L10
M01_L75:
       mov       ecx,11
       call      qword ptr [7FFA02B97E58]
       int       3
M01_L76:
       mov       r11,7FFA028C1288
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L11
M01_L77:
       mov       r12d,0FFFFFFFF
       jmp       near ptr M01_L60
M01_L78:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       r12d,eax
       jmp       near ptr M01_L60
M01_L79:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L62
M01_L80:
       mov       r11,7FFA028C1278
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L15
M01_L81:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFA02975A58]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       jmp       near ptr M01_L57
M01_L82:
       lea       rdx,[rax+10]
       mov       r9d,[rax+8]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],r9d
       xor       edx,edx
       mov       [rsp+20],rdx
       lea       rdx,[rbp-0B0]
       mov       r9,rdi
       mov       r8,rbx
       mov       rcx,7FFA03420E60
       call      qword ptr [7FFA0323F630]
       mov       rbx,rax
       jmp       near ptr M01_L57
M01_L83:
       mov       r8d,[rax+10]
       mov       rcx,[rax+8]
       cmp       [rcx+8],r8d
       jae       short M01_L84
       call      qword ptr [7FFA02B97A08]
       int       3
M01_L84:
       add       rcx,10
       mov       [rbp-0A0],rcx
       mov       [rbp-98],r8d
       lea       r8,[rbp-0A0]
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.Span<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       call      qword ptr [7FFA0323F690]
       xor       edx,edx
       mov       [rsp+20],rdx
       lea       rdx,[rbp-58]
       mov       r9,rdi
       mov       r8,rbx
       mov       rcx,7FFA03420E60
       call      qword ptr [7FFA0323F630]
       mov       rbx,rax
       jmp       near ptr M01_L57
M01_L85:
       mov       ecx,16
       call      qword ptr [7FFA02B978D0]
       int       3
M01_L86:
       mov       rcx,r15
       call      qword ptr [7FFA03291418]
       mov       r15,rax
       jmp       near ptr M01_L19
M01_L87:
       mov       rcx,r15
       mov       r11,7FFA028C1258
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r15,rcx
       jmp       near ptr M01_L20
M01_L88:
       mov       rcx,[rbp-0C0]
       mov       r11,7FFA028C1270
       call      qword ptr [r11]
       jmp       near ptr M01_L57
M01_L89:
       mov       rax,rbx
       jmp       near ptr M01_L58
M01_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L92
       mov       rcx,[rbp-0C0]
       mov       r15,[rcx]
       mov       rdi,offset MT_System.Linq.Enumerable+Concat2Iterator<System.Collections.Generic.KeyValuePair<System.String, System.String>>
       cmp       r15,rdi
       jne       short M01_L91
       call      qword ptr [7FFA0328F758]; System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Dispose()
       jmp       short M01_L92
M01_L91:
       mov       r11,7FFA028C1270
       call      qword ptr [r11]
M01_L92:
       nop
       add       rsp,28
       ret
; Total bytes of code 3618
```

