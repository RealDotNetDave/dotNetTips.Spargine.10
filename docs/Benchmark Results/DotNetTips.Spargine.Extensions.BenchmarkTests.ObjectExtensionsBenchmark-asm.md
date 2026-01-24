## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,1D8
       lea       rbp,[rsp+210]
       xor       eax,eax
       mov       [rbp-198],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rax,[rbx+48]
       test      rax,rax
       je        near ptr M00_L42
       mov       rcx,215E3C00220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFDC2A670C0]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       r15,rax
       cmp       byte ptr [r15+9F],0
       je        near ptr M00_L43
M00_L01:
       mov       rdx,[r15+18]
       test      rdx,rdx
       jne       near ptr M00_L08
       xor       esi,esi
       cmp       byte ptr [r15+9E],0
       je        near ptr M00_L07
       mov       rsi,[r15+8]
       test      rsi,rsi
       je        near ptr M00_L44
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,215E3C01960
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L45
M00_L03:
       cmp       [rdi],dil
       mov       r12,[rdi+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L17
       mov       r11,7FFDC2380D98
       mov       rdx,25678D119B8
       call      qword ptr [r11]
M00_L04:
       mov       [rbp-4C],eax
       mov       r10,[r12+8]
       mov       [rbp-1B8],r10
       mov       rdx,[r12+10]
       mov       ecx,eax
       imul      rcx,[r12+28]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L56
       mov       ecx,ecx
       mov       r9,[rdx+rcx*8+10]
       test      r9,r9
       jne       near ptr M00_L16
M00_L05:
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       rdx,25678D119B8
       mov       r8,rsi
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-58]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-4C]
       shl       r9,20
       or        r9,1
       mov       rdx,r12
       mov       r8,25678D119B8
       mov       rcx,rdi
       call      qword ptr [7FFDC27CC2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L06:
       mov       rcx,[rbp-58]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,[rcx+10]
       test      rax,rax
       jne       near ptr M00_L46
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M00_L07
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L47
M00_L07:
       test      rsi,rsi
       je        near ptr M00_L48
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L08:
       mov       r15,rdx
       test      r15,r15
       je        short M00_L09
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r15],rcx
       jne       near ptr M00_L49
M00_L09:
       mov       rsi,[r15+0B8]
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A67408]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r13d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L50
M00_L10:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L11
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,25678D162A0
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
M00_L11:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       jne       near ptr M00_L18
       mov       rcx,[rax+8]
       mov       [rbp-1C8],rcx
       mov       r12,[rax+10]
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r13d
       jl        near ptr M00_L40
M00_L12:
       lea       rcx,[r12+8]
       mov       rdx,[rbp-1C8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-5C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-68]
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
       je        near ptr M00_L41
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L13:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L51
       mov       rsi,25678D11518
M00_L14:
       mov       ecx,[rsi+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       near ptr M00_L22
       mov       dword ptr [r12+78],3E8
       jmp       near ptr M00_L22
M00_L15:
       mov       r9,[r9+18]
       test      r9,r9
       je        near ptr M00_L05
       mov       eax,[rbp-4C]
M00_L16:
       cmp       eax,[r9+20]
       jne       short M00_L15
       mov       [rbp-1C0],r9
       mov       rdx,[r9+8]
       mov       rcx,r10
       mov       r8,25678D119B8
       mov       r11,7FFDC2380DA0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-1C0]
       mov       r10,[rbp-1B8]
       je        short M00_L15
       mov       rcx,[r9+10]
       mov       [rbp-58],rcx
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,25678D119B8
       mov       rax,[7FFDC237A1C0]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L04
M00_L18:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r13d,r13d
       je        near ptr M00_L52
       mov       rcx,215E3C01E00
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFDC2A89938]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L19:
       mov       [rbp-80],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-1C8],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-5C]
       lea       rdi,[r12+70]
       lea       rsi,[rbp-68]
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
       je        near ptr M00_L39
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r12+2C],eax
       test      dl,4
       jne       near ptr M00_L53
       mov       r13,25678D11518
M00_L21:
       mov       ecx,[r13+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       short M00_L22
       mov       dword ptr [r12+78],3E8
M00_L22:
       mov       [rbp-1D0],r12
       cmp       byte ptr [r15+116],0
       jne       near ptr M00_L30
       mov       rcx,[r15+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L28
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L28
       mov       rsi,[r15+0B8]
       mov       rcx,[rbp-48]
       cmp       [rsi],sil
       call      qword ptr [7FFDC243C9A8]; System.Object.GetType()
       mov       r9,25678D119B8
       cmp       rax,r9
       je        near ptr M00_L28
       mov       r15,[rsi+10]
       test      r15,r15
       je        near ptr M00_L31
       mov       r9,[r15+0C0]
       cmp       r9,rax
       jne       near ptr M00_L31
M00_L23:
       cmp       byte ptr [r15+11A],0
       je        near ptr M00_L27
M00_L24:
       mov       r8,[r15+0F8]
       test      r8,r8
       cmovne    r15,r8
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],r8
       jne       near ptr M00_L33
       mov       r9,[rbp-48]
       mov       r8,r9
       test      r8,r8
       je        short M00_L25
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M00_L32
M00_L25:
       mov       [rbp-128],r8
       lea       r8,[rbp-128]
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FFDC2A67570]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-128],rdx
M00_L26:
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       lea       rdx,[rbp-138]
       call      qword ptr [7FFDC2E87DF8]; System.Net.ArrayBuffer.get_ActiveSpan()
       mov       rdx,[rbp-138]
       mov       r8d,[rbp-130]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-148],xmm0
       lea       rcx,[rbp-148]
       call      qword ptr [7FFDC2E87E10]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-148]
       vmovdqu   xmmword ptr [rbp-188],xmm0
       lea       rcx,[rbp-188]
       call      qword ptr [7FFDC29C5BC0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L34
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FFDC2A6DB60]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L24
M00_L28:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-120],ymm0
       vmovdqu   ymmword ptr [rbp-100],ymm0
       vmovdqu   ymmword ptr [rbp-0E0],ymm0
       vmovdqu   ymmword ptr [rbp-0C0],ymm0
       vmovdqu   ymmword ptr [rbp-0A0],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-120]
       mov       rdx,r15
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFDC2A6EAC0]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-120]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A6EAD8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L29:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A6F408]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L26
M00_L30:
       mov       rax,[r15+148]
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L29
M00_L31:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFDC285C858]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L23
M00_L32:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L33:
       mov       rcx,r15
       mov       rdx,r12
       mov       r8,[rbp-48]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L34:
       mov       rcx,r12
       mov       rdx,[rbp-1C8]
       call      qword ptr [7FFDC2A6F438]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFDC258F930]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFDC2B36FB8]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-158],xmm0
       call      qword ptr [7FFDC2B37150]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-158]
       call      qword ptr [7FFDC2B371C8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-158]
       mov       edi,[rbp-150]
       mov       rcx,215E3C01D08
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFDC265FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L54
       mov       rcx,rax
       call      qword ptr [7FFDC2A3CCC0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L35:
       mov       [rbp-1A8],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L37
       mov       r13,offset MT_System.Byte
       mov       rcx,215E3C00100
       mov       r12,[rcx]
       mov       rax,offset MT_System.ReadOnlySpan<System.Object>
       mov       [rbp-1A0],rax
M00_L36:
       movzx     edx,byte ptr [rsi+r15]
       mov       [rbp-3C],edx
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1B0],r12
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-160],rax
       mov       rax,[rbp-1A8]
       cmp       [rax],al
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-170],xmm0
       lea       rcx,[rbp-170]
       lea       r8,[rbp-160]
       mov       rdx,[rbp-1A0]
       call      qword ptr [7FFDC2E87E28]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-170]
       vmovdqu   xmmword ptr [rbp-198],xmm0
       lea       r9,[rbp-198]
       mov       rdx,[rbp-1B0]
       mov       rcx,[rbp-1A8]
       mov       r8,25678D21858
       call      qword ptr [7FFDC2D65B60]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L36
M00_L37:
       mov       rcx,[rbp-1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2622100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-1A8]
       mov       rcx,r14
       call      qword ptr [7FFDC265FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFDC2A64A68]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L55
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFDC2A64A80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L38:
       mov       [rbp-178],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-178]
       mov       rdx,7FFDC2D786E0
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2D65BD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L40:
       mov       edx,r13d
       call      qword ptr [7FFDC2A67498]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L12
M00_L41:
       mov       eax,2
       jmp       near ptr M00_L13
M00_L42:
       call      qword ptr [7FFDC29CE2C8]
       mov       ecx,7C8
       mov       rdx,7FFDC28189B8
       call      qword ptr [7FFDC2657738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2714878
       call      qword ptr [7FFDC2657738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2437858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28189B8
       call      qword ptr [7FFDC2657738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2437858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2E87BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2D6D950]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,r15
       call      qword ptr [7FFDC2857048]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,r15
       call      qword ptr [7FFDC285C870]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC237D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,215E3C01960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,rax
       call      qword ptr [7FFDC2E846D8]
       int       3
M00_L47:
       mov       rcx,rsi
       call      qword ptr [7FFDC29465C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L07
M00_L48:
       mov       rdx,[r15+20]
       mov       rcx,25678D119B8
       call      qword ptr [7FFDC2E846F0]
       int       3
M00_L49:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L50:
       mov       ecx,9
       call      qword ptr [7FFDC2D6D548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L10
M00_L51:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,215E3C02500
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L52:
       mov       rax,25678D162A0
       jmp       near ptr M00_L19
M00_L53:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,215E3C02500
       mov       r13,[rcx]
       jmp       near ptr M00_L21
M00_L54:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M00_L35
M00_L55:
       mov       rcx,rdi
       mov       rdx,r15
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L38
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,215E3C01D08
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFDC265FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-1A8]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFDC2A64A68]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L57
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFDC2A64A80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L58
M00_L57:
       mov       rcx,rsi
       mov       rdx,r15
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L58:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       mov       rcx,[rbp-1D0]
       mov       rdx,[rbp-1C8]
       call      qword ptr [7FFDC2A6F438]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2990
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,215E3C01CD8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,215E3C01CD8
       xor       edx,edx
       jmp       qword ptr [7FFDC2A670D8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-50],rax
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M02_L40
       cmp       byte ptr [rcx+19],0
       jne       near ptr M02_L39
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+90]
       test      r11,r11
       je        near ptr M02_L38
M02_L00:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
M02_L01:
       mov       [rbp-3C],eax
M02_L02:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-58],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M02_L42
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       byte ptr [rbp+40],0
       je        short M02_L04
       mov       rcx,7FFDC2EA7E74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M02_L25
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M02_L17
       mov       rcx,r14
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M02_L03
       mov       rcx,r14
       call      qword ptr [7FFDC2D6DB00]
M02_L03:
       mov       dword ptr [rbp-44],1
M02_L04:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M02_L18
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M02_L08
M02_L05:
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        near ptr M02_L16
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M02_L25
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L26
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M02_L28
M02_L07:
       cmp       r14d,64
       ja        near ptr M02_L29
       mov       rcx,7FFDC2EA7E8C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L30
M02_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M02_L11
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M02_L12
       mov       rcx,rax
M02_L09:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M02_L13
M02_L10:
       mov       rdx,[r15+8]
       mov       rcx,[rbp-50]
       mov       r8,[rbp+20]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L14
       mov       rcx,7FFDC2EA7E80
       call      CORINFO_HELP_COUNTPROFILE32
M02_L11:
       mov       rcx,7FFDC2EA7E90
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r14d
       mov       rcx,7FFDC2EA7E94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15,[r15+18]
       test      r15,r15
       mov       r8,[rbp+10]
       jne       near ptr M02_L08
       jmp       near ptr M02_L05
M02_L12:
       mov       rdx,7FFDC2E97750
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L13:
       mov       rdx,7FFDC2E967A0
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L10
M02_L14:
       cmp       byte ptr [rbp+38],0
       je        near ptr M02_L27
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M02_L15:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       jmp       near ptr M02_L37
M02_L16:
       mov       rdx,7FFDC2E97C20
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L17:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D6CD68]
       int       3
M02_L18:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-50]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        short M02_L23
       mov       rcx,7FFDC2EA7E78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-50],rcx
       mov       r8,[rbp+10]
       cmp       byte ptr [r8+19],0
       jne       short M02_L21
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M02_L19
       jmp       short M02_L20
M02_L19:
       mov       rdx,7FFDC2E97768
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L20:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       jmp       short M02_L22
M02_L21:
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M02_L22:
       mov       [rbp-3C],eax
M02_L23:
       mov       rcx,7FFDC2EA7E7C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L35
M02_L24:
       mov       rcx,7FFDC2EA7E84
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L30
M02_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L27:
       mov       rcx,7FFDC2EA7E88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L15
M02_L28:
       mov       rcx,7FFDC2EA7E98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,1
       jmp       near ptr M02_L07
M02_L29:
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFDC2436850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L24
       mov       rcx,7FFDC2EA7E9C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
M02_L30:
       cmp       dword ptr [rbp-44],0
       je        short M02_L31
       mov       rcx,7FFDC2EA7EA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M02_L42
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L33
       mov       rcx,rbx
       call      00007FFE2200BB70
       test      eax,eax
       jne       short M02_L34
M02_L31:
       mov       rcx,7FFDC2EA7EA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       or        ecx,edi
       jne       near ptr M02_L41
M02_L32:
       mov       rcx,7FFDC2EA7EAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D6CD68]
       int       3
M02_L34:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFDC2D6D698]
       jmp       short M02_L31
M02_L35:
       call      M02_L43
       jmp       near ptr M02_L02
M02_L36:
       mov       rcx,7FFDC2EA7EB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-48]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L37:
       call      M02_L43
       jmp       short M02_L36
M02_L38:
       mov       rcx,rax
       mov       rdx,7FFDC2E97768
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L39:
       mov       rdx,[rbp+20]
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M02_L01
M02_L40:
       mov       rcx,7FFDC2EA7E70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       jmp       near ptr M02_L01
M02_L41:
       mov       rcx,7FFDC2EA7EA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFDC2B3C9C0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M02_L32
M02_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L43:
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M02_L44
       mov       rcx,7FFDC2EA7EA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M02_L46
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M02_L45
       mov       rcx,rsi
       call      00007FFE2200BB70
       test      eax,eax
       je        short M02_L44
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFDC2D6D698]
M02_L44:
       mov       rcx,7FFDC2EA7EA4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M02_L45:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D6CD68]
       int       3
M02_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1523
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
       jne       near ptr M03_L11
       and       esi,0FFFFFFF7
M03_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M03_L10
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
       mov       rcx,25678D1FFA8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,25678D11518
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,25678D11518
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
       mov       rdx,7FFDC286E7E0
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E865E0]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       mov       ecx,38A0
       mov       rdx,7FFDC286E7E0
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFDC2E865B0]
       int       3
M03_L11:
       cmp       edx,9
       je        short M03_L12
       mov       ecx,38A0
       mov       rdx,7FFDC286E7E0
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E86598]
       int       3
M03_L12:
       or        esi,8
       jmp       near ptr M03_L00
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FFDC286E7E0
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E865C8]
       int       3
M03_L14:
       mov       r8,25678D11518
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
       mov       rcx,215E3C00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       call      qword ptr [7FFDC2D6D548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E84D50]
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
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFDC237B1AC],0
       je        short M04_L05
       call      qword ptr [7FFDC2E84D68]
       mov       ebx,eax
       jmp       short M04_L07
M04_L05:
       mov       ecx,0C
       call      qword ptr [7FFDC2E84D80]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFDC2E84D80]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M04_L06
       call      qword ptr [7FFDC2E84D98]
       mov       ebx,eax
       jmp       short M04_L07
M04_L06:
       sar       ebx,10
M04_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFDC237B1A0]
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
       call      qword ptr [7FFDC294D398]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFDC2436820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E84D50]
       jmp       near ptr M04_L01
M04_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L18
M04_L16:
       test      ebx,ebx
       jne       short M04_L17
       mov       rax,25678D162A0
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
       mov       rdx,25678D16F28
       call      qword ptr [7FFDC265D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFDC2A67540]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E84D50]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2E84DB0]
       jmp       near ptr M04_L01
M04_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 798
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
       je        short M05_L01
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       call      qword ptr [7FFDC2435C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M05_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M06_L00:
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M06_L09
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M06_L06
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M06_L06
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FFDC243C9A8]; System.Object.GetType()
       mov       r9,25678D119B8
       cmp       rax,r9
       je        near ptr M06_L06
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        near ptr M06_L10
       mov       r9,[rbx+0C0]
       cmp       r9,rax
       jne       near ptr M06_L10
M06_L01:
       cmp       byte ptr [rbx+11A],0
       je        short M06_L05
M06_L02:
       mov       r8,[rbx+0F8]
       test      r8,r8
       cmovne    rbx,r8
       mov       r9,[rsi]
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r8
       jne       near ptr M06_L12
       mov       r8,r9
       test      r8,r8
       je        short M06_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M06_L11
M06_L03:
       mov       [rsp+38],r8
       lea       r8,[rsp+38]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFDC2A67570]
M06_L04:
       nop
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2A6DB60]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M06_L02
M06_L06:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       mov       [rsp+0A8],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+0A0],rcx
       mov       rcx,[rsp+0A0]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0D0],rcx
       mov       byte ptr [rsp+8E],0
       mov       byte ptr [rsp+8F],0
       mov       r14,[rbx+0B8]
       cmp       dword ptr [r14+8C],0
       je        short M06_L07
       mov       rcx,[r14+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+60],rax
       cmp       dword ptr [r14+8C],2
       jne       short M06_L07
       test      rbp,rbp
       je        short M06_L07
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M06_L13
M06_L07:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A6EAD8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M06_L08:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A6F408]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M06_L04
M06_L09:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M06_L08
M06_L10:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,r14
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFDC285C858]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L01
M06_L11:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L12:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,r9
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M06_L04
M06_L13:
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M06_L07
; Total bytes of code 706
```
```assembly
; System.Net.ArrayBuffer.get_ActiveSpan()
       sub       rsp,28
       mov       rax,[rcx]
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       mov       ecx,[rcx+0C]
       sub       ecx,r8d
       test      rax,rax
       je        short M07_L01
       mov       r8d,ecx
       add       r8,r10
       mov       r9d,[rax+8]
       cmp       r8,r9
       ja        short M07_L02
       lea       rax,[rax+r10+10]
M07_L00:
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rax,rdx
       add       rsp,28
       ret
M07_L01:
       or        r10d,ecx
       jne       short M07_L02
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M07_L00
M07_L02:
       call      qword ptr [7FFDC25A7138]
       int       3
; Total bytes of code 77
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
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
       mov       r8,215E3C013D0
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
       call      qword ptr [7FFDC25A4BB8]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M09_L05
M09_L00:
       test      r14d,r14d
       je        near ptr M09_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFE2205AFE0
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
       call      qword ptr [7FFDC25A4BE8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       jmp       short M09_L03
M09_L02:
       mov       r15,25678D10008
M09_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M09_L09
M09_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFDC29CDC80]
       int       3
M09_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFDC2D67798]
       add       r14d,eax
       jns       near ptr M09_L00
       call      qword ptr [7FFDC2D677B0]
       int       3
M09_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFDC29CDC80]
       int       3
M09_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFDC29C59E0]
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
       call      qword ptr [7FFDC29CDC98]
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
       call      qword ptr [7FFDC2D677C8]
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
       call      qword ptr [7FFE3901F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFE3901F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       mov       rcx,7FFDC2EBFB10
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M11_L01:
       mov       r14,[rdi+38]
       mov       rcx,r14
       mov       rdx,7FFDC2EBFA08
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r14
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       near ptr M11_L04
       test      rbp,rbp
       je        short M11_L03
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M11_L02
       mov       rcx,7FFDC2EBFB14
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2EBFB10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FFDC2EBFB18
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M11_L02:
       mov       rcx,7FFDC2EBFC20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L00
M11_L03:
       mov       rcx,7FFDC2EBFC24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,7FFDC2EBFC28
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L00
; Total bytes of code 354
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
       mov       rax,215E3C013F8
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
       call      qword ptr [7FFDC2E860B8]
       mov       rcx,[rbp+30]
M12_L04:
       test      byte ptr [rbx+7C],1
       jne       short M12_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFDC2A6EEE0]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M12_L07
M12_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFDC2E860D0]
       jmp       short M12_L07
M12_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFDC2E86088]
M12_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M12_L09
M12_L08:
       mov       rcx,rbx
       call      qword ptr [7FFDC2A6F0F0]
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
       test      r13,r13
       jne       near ptr M12_L30
M12_L17:
       mov       rcx,[rbp+30]
       call      qword ptr [7FFDC2A6EB08]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       je        short M12_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
M12_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFDC2A6EF40]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFDC296D940]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
       jmp       short M12_L18
M12_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FFDC2A6F0C0]
       int       3
M12_L22:
       mov       rcx,rbx
       call      qword ptr [7FFDC2A6F0F0]
       jmp       near ptr M12_L10
M12_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M12_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFDC29C5AB8]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFDC2E86070]
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
       call      qword ptr [7FFDC2A6F060]
       int       3
M12_L27:
       mov       rcx,r13
       call      qword ptr [7FFDC29465C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M12_L13
M12_L28:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFDC2E85FE0]
       mov       r13,rax
       jmp       near ptr M12_L15
M12_L29:
       mov       [rsp+20],r13
       mov       rcx,[rbp+30]
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFDC2E85FF8]
       test      eax,eax
       je        near ptr M12_L16
       jmp       near ptr M12_L10
M12_L30:
       mov       rcx,[rbp+30]
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
       call      qword ptr [7FFDC2E86688]
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
       call      qword ptr [7FFDC2E866A0]
       test      rax,rax
       jne       near ptr M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFDC2E866B8]
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
       mov       rdx,25678D1EF70
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2E866E8]
       test      eax,eax
       jne       short M12_L38
       jmp       short M12_L37
M12_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,25678D1EF20
       call      qword ptr [7FFDC2654EA0]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFDC2E866D0]
       jmp       short M12_L38
M12_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFDC2E86700]
M12_L38:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1291
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
       call      qword ptr [7FFDC2E86B08]
       int       3
M13_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M13_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2EBECF0]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2E86B38]
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
       call      qword ptr [7FFDC2E86B50]
M13_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M13_L02
M13_L06:
       mov       r11,7FFDC2380E60
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
       je        near ptr M14_L11
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        short M14_L07
M14_L00:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFE3901E550]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r14,rax
       cmp       byte ptr [rsp+78],0
       jne       short M14_L08
M14_L01:
       mov       rcx,[r14+10]
       test      rcx,rcx
       jne       short M14_L09
M14_L02:
       mov       rbp,[r14+8]
M14_L03:
       test      dil,dil
       je        short M14_L04
       test      rbp,rbp
       je        short M14_L04
       cmp       byte ptr [rbp+119],2
       jne       short M14_L06
M14_L04:
       test      rbp,rbp
       je        short M14_L12
M14_L05:
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M14_L06:
       mov       rcx,rbp
       call      qword ptr [7FFE3901EFA0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M14_L04
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE3901E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M14_L00
M14_L08:
       cmp       byte ptr [r14+20],0
       je        short M14_L10
       jmp       short M14_L01
M14_L09:
       call      qword ptr [7FFE3901B218]
       jmp       short M14_L02
M14_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFE3901E560]
       mov       rbp,rax
       jmp       short M14_L03
M14_L11:
       cmp       byte ptr [rsp+70],0
       je        short M14_L04
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE3901E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M14_L04
M14_L12:
       cmp       byte ptr [rsp+69],0
       je        short M14_L05
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFE3901D058]
       int       3
; Total bytes of code 232
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
       jmp       qword ptr [7FFDC2D6D998]
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M16_L43
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M16_L43
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
       mov       rcx,25678D162A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M16_L42
       cmp       dword ptr [rbx+8],0
       je        near ptr M16_L42
       mov       rcx,215E3C01E00
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M16_L44
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M16_L44
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
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M16_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFDC2D6DB00]
M16_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFDC265CED0]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
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
       call      00007FFE2200C390
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
       call      00007FFE2202DBC0
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
       call      qword ptr [7FFDC243E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L04
M16_L07:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D6CD68]
       int       3
M16_L08:
       mov       ecx,36
       call      qword ptr [7FFDC2E87F30]
       int       3
M16_L09:
       mov       rcx,r12
       call      qword ptr [7FFDC2E87F48]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L03
M16_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC2E87F60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC27C5D88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M16_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M16_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFDC2E87F78]
       jmp       near ptr M16_L05
M16_L13:
       mov       rcx,[rbp-88]
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M16_L45
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
       jne       near ptr M16_L47
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
       jae       near ptr M16_L55
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M16_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFDC2E86580]
M16_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFDC2C52028],1
       je        near ptr M16_L48
M16_L18:
       cmp       byte ptr [7FFDC237B1AC],0
       je        near ptr M16_L33
       call      qword ptr [7FFDC2E84D68]
       mov       [rbp-60],eax
       mov       edx,[rbp-60]
M16_L19:
       test      byte ptr [7FFDC2C2BF20],1
       je        near ptr M16_L50
M16_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFDC237B1A0]
       mov       eax,edx
       mov       edx,[r13+8]
       mov       [rbp-70],edx
       test      edx,edx
       jle       near ptr M16_L54
       mov       [rbp-74],edx
M16_L21:
       cmp       eax,edx
       jae       near ptr M16_L55
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-98],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-64],r9d
       mov       rcx,r10
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M16_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFDC2D6DB00]
M16_L22:
       mov       rax,[rbp-98]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-68],r8d
       cmp       [rcx+8],r8d
       jbe       short M16_L24
       test      r8d,r8d
       je        near ptr M16_L36
M16_L23:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-68]
       inc       ecx
       mov       rax,[rbp-98]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-64],1
M16_L24:
       mov       rcx,rax
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M16_L51
M16_L25:
       cmp       dword ptr [rbp-64],0
       je        near ptr M16_L52
       mov       r13d,1
M16_L26:
       mov       rcx,215E3C00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M16_L42
       mov       rcx,rbx
       call      00007FFE2200C390
       test      eax,eax
       je        near ptr M16_L37
       mov       [rbp-6C],eax
M16_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFE2200C390
       test      eax,eax
       je        near ptr M16_L38
M16_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-6C]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFDC2E84E58]
       test      r13d,r15d
       jne       near ptr M16_L42
       mov       rcx,rbx
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFE2200C390
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M16_L39
M16_L29:
       test      r15d,r15d
       jne       near ptr M16_L40
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M16_L41
M16_L30:
       mov       r15,215E3C01F50
       mov       r12,[r15]
       test      r12,r12
       jne       short M16_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,215E3C01F48
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
       call      00007FFE220180F0
       test      rax,rax
       je        near ptr M16_L46
M16_L32:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M16_L15
M16_L33:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0C
       jle       near ptr M16_L49
       mov       rcx,[rcx+240]
       mov       rax,[rcx+60]
       test      rax,rax
       je        near ptr M16_L49
M16_L34:
       mov       ecx,[rax+10]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       je        short M16_L35
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       jmp       near ptr M16_L19
M16_L35:
       call      qword ptr [7FFDC2E84D98]
       mov       edx,eax
       jmp       near ptr M16_L19
M16_L36:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M16_L23
M16_L37:
       mov       rcx,rbx
       call      qword ptr [7FFDC243E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-6C],eax
       jmp       near ptr M16_L27
M16_L38:
       mov       rcx,rsi
       call      qword ptr [7FFDC243E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L28
M16_L39:
       mov       rcx,rsi
       call      qword ptr [7FFDC243E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M16_L29
M16_L40:
       xor       ecx,ecx
M16_L41:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFDC2E84E70]
M16_L42:
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
M16_L43:
       mov       ecx,9
       call      qword ptr [7FFDC2D6D548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M16_L00
M16_L44:
       mov       ecx,0A
       call      qword ptr [7FFDC2D6D548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M16_L01
M16_L45:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFDC2D6D698]
       jmp       near ptr M16_L14
M16_L46:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDC2E87F90]
       jmp       near ptr M16_L32
M16_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFDC2E84E28]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDC27C5E30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M16_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M16_L18
M16_L49:
       mov       ecx,0C
       call      qword ptr [7FFDC2E84D80]
       jmp       near ptr M16_L34
M16_L50:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M16_L20
M16_L51:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDC2D6D698]
       jmp       near ptr M16_L25
M16_L52:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-70]
       cmp       edx,ecx
       jne       short M16_L53
       xor       ecx,ecx
M16_L53:
       mov       r8d,[rbp-74]
       dec       r8d
       mov       [rbp-74],r8d
       mov       eax,ecx
       jne       near ptr M16_L21
M16_L54:
       xor       r13d,r13d
       jmp       near ptr M16_L26
M16_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M16_L57
       cmp       qword ptr [rbp-88],0
       jne       short M16_L56
       xor       ecx,ecx
       call      qword ptr [7FFDC2D6CD68]
       int       3
M16_L56:
       mov       rcx,[rbp-88]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M16_L57
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFDC2D6D698]
M16_L57:
       nop
       add       rsp,38
       ret
; Total bytes of code 2077
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
       call      qword ptr [7FFDC243FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFDC243FAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFDC294EAA8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
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
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D6CD68]
       int       3
M17_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFDC2E85410]
       add       r13d,eax
       jns       near ptr M17_L00
M17_L06:
       call      qword ptr [7FFDC2D677B0]
       int       3
M17_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFDC29C59E0]
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
       call      qword ptr [7FFDC2D6E4A8]
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
       mov       rax,7FFDC2A50DB0
       mov       [rbp-70],rax
       lea       rax,[M18_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE5B1F3BE0
       call      rax
M18_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M18_L01
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFDC286DDA8
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D6CD68]
       int       3
M18_L03:
       call      qword ptr [7FFDC2E86CA0]
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
       mov       r11,7FFDC2380E78
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M19_L02
M19_L17:
       call      qword ptr [7FFDC24357A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFDC24366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M19_L03
M19_L23:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFDC2D6C0D8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M19_L03
M19_L24:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFDC2380E80
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M19_L03
M19_L25:
       mov       rax,25678D162A0
       jmp       near ptr M19_L04
M19_L26:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDC2B371E0]
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
       jmp       qword ptr [7FFDC265FC48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      00007FFE22014230
       cmp       rax,[rsp+28]
       jne       short M22_L02
M22_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M22_L01:
       call      qword ptr [7FFDC2D6D290]
       int       3
M22_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A649C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       je        near ptr M24_L20
       test      rdi,rdi
       je        near ptr M24_L21
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M24_L22
       xor       edx,edx
M24_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
       jmp       near ptr M24_L12
M24_L01:
       inc       r10d
       mov       r9d,r13d
       sub       r9d,r10d
       mov       ecx,r10d
       mov       r11d,r9d
       add       rcx,r11
       mov       r11d,r12d
       cmp       rcx,r11
       ja        near ptr M24_L61
       mov       ecx,r10d
       lea       r10,[rbx+rcx*2+0C]
       mov       r12,r10
       mov       r10d,r9d
       mov       r9d,r10d
       mov       r10,r12
M24_L02:
       inc       r13d
       xor       r12d,r12d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr M24_L62
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+48],rdx
       test      r15,r15
       jne       near ptr M24_L36
M24_L03:
       test      r12,r12
       jne       near ptr M24_L51
       mov       [rsp+0A0],eax
       test      eax,eax
       jne       short M24_L04
       mov       [rsp+0A4],r8d
       test      r8d,r8d
       jne       near ptr M24_L40
       mov       r8d,[rsp+0A4]
M24_L04:
       mov       rdx,[rsp+48]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M24_L05
       mov       r12,offset MT_System.Byte
       cmp       [rcx],r12
       jne       near ptr M24_L38
M24_L05:
       test      rcx,rcx
       mov       [rsp+0A4],r8d
       mov       [rsp+30],r10
       mov       [rsp+50],r11
       je        near ptr M24_L39
       mov       r12,[rsi+8]
       mov       r11,r12
       mov       edx,[rsi+18]
       mov       r10d,edx
       mov       r12d,[r12+8]
       sub       r12d,edx
       mov       edx,r10d
       mov       r8d,r12d
       add       rdx,r8
       mov       r8d,[r11+8]
       cmp       rdx,r8
       ja        near ptr M24_L63
       mov       edx,r10d
       lea       rdx,[r11+rdx*2+10]
       mov       r8,offset MT_System.Byte
       cmp       [rcx],r8
       jne       near ptr M24_L42
       add       rcx,8
       movzx     ecx,byte ptr [rcx]
       test      r9d,r9d
       jne       near ptr M24_L41
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r11,7FFE1D72C0B8
       add       r10,[r11+r8*8]
       sar       r10,20
       cmp       r10d,r12d
       jle       short M24_L06
       xor       r10d,r10d
       mov       [rsp+98],r10d
       jmp       near ptr M24_L10
M24_L06:
       mov       [rsp+98],r10d
       mov       [rsp+80],rdx
       movsxd    r8,r10d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M24_L18
       cmp       ecx,64
       jb        short M24_L08
       mov       r8,25678D11234
M24_L07:
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
       jae       short M24_L07
M24_L08:
       cmp       ecx,0A
       jb        near ptr M24_L18
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r8,25678D11234
       shl       ecx,2
       mov       r8d,[r8+rcx]
       mov       [rdx],r8d
M24_L09:
       xor       edx,edx
       mov       [rsp+80],rdx
       mov       r10d,1
M24_L10:
       xor       edx,edx
       mov       [rsp+80],rdx
M24_L11:
       test      r10d,r10d
       mov       [rsp+7C],r9d
       je        near ptr M24_L45
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
       ja        near ptr M24_L63
       cmp       r8d,ecx
       ja        near ptr M24_L64
       add       r10d,[rsp+98]
       mov       [rsi+18],r10d
       cmp       dword ptr [rsp+0A0],0
       jne       near ptr M24_L43
M24_L12:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M24_L19
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
       call      qword ptr [7FFDC265C5D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+90],eax
       test      eax,eax
       jl        near ptr M24_L56
       mov       r10d,[rsp+94]
       cmp       eax,r10d
       ja        near ptr M24_L63
       test      eax,eax
       jne       near ptr M24_L23
M24_L13:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M24_L65
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       eax,r13d
       movzx     edx,word ptr [rbx+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M24_L27
       cmp       ecx,7B
       jne       near ptr M24_L57
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M24_L58
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       mov       r11d,ecx
       cmp       r11d,7D
       je        near ptr M24_L02
M24_L14:
       lea       ecx,[r11-30]
       cmp       ecx,9
       jbe       near ptr M24_L29
M24_L15:
       cmp       r11d,20
       je        near ptr M24_L30
       cmp       r11d,2C
       je        near ptr M24_L31
M24_L16:
       cmp       r11d,7D
       je        near ptr M24_L02
       cmp       r11d,3A
       jne       near ptr M24_L60
       mov       r10d,r13d
       lea       r13d,[r10+1]
       cmp       r12d,r13d
       jbe       near ptr M24_L59
M24_L17:
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,7D
       je        near ptr M24_L01
       cmp       r11d,7B
       je        near ptr M24_L60
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L17
       jmp       near ptr M24_L59
M24_L18:
       lea       r8d,[rcx+30]
       mov       [rdx-2],r8w
       jmp       near ptr M24_L09
M24_L19:
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
M24_L20:
       mov       ecx,3B9
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D6CD68]
       int       3
M24_L21:
       xor       edx,edx
       jmp       near ptr M24_L00
M24_L22:
       mov       rcx,rdi
       mov       r11,7FFDC2380E98
       mov       rdx,25678D25B10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M24_L00
M24_L23:
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+8C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M24_L26
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        short M24_L24
       mov       r9,[rsp+38]
       movzx     r8d,word ptr [r9]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M24_L25
       movzx     r8d,word ptr [r9+2]
       mov       [rcx+2],r8w
       jmp       short M24_L25
M24_L24:
       mov       r9,[rsp+38]
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r9
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+90]
M24_L25:
       mov       r10d,eax
       add       r10d,[rsp+8C]
       mov       [rsi+18],r10d
       jmp       near ptr M24_L13
M24_L26:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FFDC25AF180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+90]
       jmp       near ptr M24_L13
M24_L27:
       mov       rcx,rsi
       call      qword ptr [7FFDC25AF120]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M24_L12
M24_L28:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L14
M24_L29:
       cmp       edx,0F4240
       jl        short M24_L28
       jmp       near ptr M24_L15
M24_L30:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L15
M24_L31:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,20
       je        short M24_L31
       cmp       r11d,2D
       jne       short M24_L32
       mov       dword ptr [rsp+0A0],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       mov       eax,[rsp+0A0]
M24_L32:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M24_L58
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L34
       jmp       near ptr M24_L59
M24_L33:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+0A4],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+0A4]
       jbe       near ptr M24_L59
M24_L34:
       cmp       r13d,r12d
       jae       near ptr M24_L65
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M24_L35
       cmp       r8d,0F4240
       jl        short M24_L33
M24_L35:
       cmp       r11d,20
       jne       near ptr M24_L16
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L59
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       short M24_L35
M24_L36:
       test      r9d,r9d
       mov       [rsp+0A0],eax
       mov       [rsp+0A4],r8d
       je        near ptr M24_L44
       mov       [rsp+30],r10
       mov       [rsp+68],r10
       mov       [rsp+7C],r9d
       mov       [rsp+70],r9d
       lea       rcx,[rsp+68]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M24_L37:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+50],r11
       mov       rdx,r11
       mov       r8,[rsp+48]
       mov       r11,7FFDC2380EB0
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+7C]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M24_L03
M24_L38:
       mov       [rsp+7C],r9d
       mov       [rsp+0A4],r8d
       mov       [rsp+30],r10
       mov       [rsp+50],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+48]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+7C]
       mov       r10,[rsp+30]
       mov       r11,[rsp+50]
       jmp       near ptr M24_L05
M24_L39:
       mov       [rsp+7C],r9d
       jmp       near ptr M24_L45
M24_L40:
       mov       [rsp+7C],r9d
       mov       [rsp+30],r10
       mov       [rsp+50],r11
       jmp       near ptr M24_L45
M24_L41:
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
       call      qword ptr [7FFDC2D65BA8]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r10d,eax
       mov       r9d,[rsp+7C]
       jmp       near ptr M24_L11
M24_L42:
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
       mov       r11,7FFDC2380EA8
       call      qword ptr [r11]
       mov       r10d,eax
       mov       [rsp+30],r12
       mov       r9d,[rsp+7C]
       jmp       near ptr M24_L11
M24_L43:
       mov       r12d,[rsp+0A4]
       cmp       r12d,[rsp+98]
       jle       near ptr M24_L12
       mov       r8d,r12d
       sub       r8d,[rsp+98]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E85AE8]
       jmp       near ptr M24_L12
M24_L44:
       mov       [rsp+7C],r9d
       mov       [rsp+30],r10
       jmp       near ptr M24_L37
M24_L45:
       mov       rdx,[rsp+48]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+40],rax
       test      rax,rax
       je        short M24_L48
       mov       rax,[rsp+40]
       mov       ecx,[rsp+7C]
       test      ecx,ecx
       je        short M24_L47
       mov       rdx,[rsp+50]
       test      rdx,rdx
       mov       r12,rdx
       jne       short M24_L46
       mov       r12,[rsp+30]
       mov       [rsp+68],r12
       mov       [rsp+70],ecx
       lea       rcx,[rsp+68]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       rax,[rsp+40]
M24_L46:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,r12
       mov       r11,7FFDC2380EA0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M24_L50
M24_L47:
       mov       r12,[rsp+50]
       jmp       short M24_L46
M24_L48:
       mov       r12,[rsp+48]
       test      r12,r12
       jne       short M24_L49
       xor       r12d,r12d
       jmp       short M24_L50
M24_L49:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M24_L50:
       test      r12,r12
       jne       short M24_L53
       mov       r12,25678D10008
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
M24_L51:
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       jl        short M24_L54
M24_L52:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDC25AF1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M24_L12
M24_L53:
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
       jmp       short M24_L51
M24_L54:
       test      eax,eax
       je        short M24_L55
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDC25AF1C8]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E85AE8]
       jmp       near ptr M24_L12
M24_L55:
       mov       r8d,[rsp+0A4]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E85AE8]
       jmp       short M24_L52
M24_L56:
       mov       rbx,[rsp+38]
       mov       [rsp+68],rbx
       mov       ebx,[rsp+94]
       mov       [rsp+70],ebx
       lea       rdx,[rsp+68]
       mov       rcx,rsi
       call      qword ptr [7FFDC2B3C990]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M24_L19
M24_L57:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFDC2E85B00]
       int       3
M24_L58:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFDC2E85B00]
       int       3
M24_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDC2E85B00]
       int       3
M24_L60:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDC2E85B00]
       int       3
M24_L61:
       mov       ecx,21
       call      qword ptr [7FFDC2657870]
       int       3
M24_L62:
       call      qword ptr [7FFDC2E85B18]
       int       3
M24_L63:
       call      qword ptr [7FFDC25A7138]
       int       3
M24_L64:
       call      qword ptr [7FFDC2E85B30]
       int       3
M24_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2496
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
       call      00007FFE2205AFE0
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
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25678D10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M25_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rbx,rax
       call      qword ptr [7FFDC2D6D2A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2946070]
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
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDC2D6CD38]
       int       3
M26_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rsi,rax
       call      qword ptr [7FFDC2E85698]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDC2946070]
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
       call      qword ptr [7FFDC2E85AE8]
       jmp       near ptr M26_L00
M26_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFDC2E863B8]
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
       call      qword ptr [7FFDC29CE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M26_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFDC25A4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFE22014230
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
       mov       rdx,7FFDC2374000
       call      qword ptr [7FFDC2657738]
       mov       rsi,rax
       call      qword ptr [7FFDC2E85698]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDC2946070]
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
       call      qword ptr [7FFDC2E85AE8]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDC2E863B8]
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
       call      qword ptr [7FFDC29CE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFDC25A4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFDC2D6D290]
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
       call      qword ptr [7FFDC2A64AB0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       jne       near ptr M29_L23
       mov       rcx,215E3C01E00
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,215E3C00C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M29_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M29_L04
M29_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M29_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M29_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M29_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M29_L05
M29_L01:
       mov       rdx,r13
M29_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M29_L03:
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
M29_L04:
       mov       ecx,0A
       call      qword ptr [7FFDC2D6D548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M29_L00
M29_L05:
       mov       rcx,r13
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E84D50]
       jmp       short M29_L01
M29_L06:
       mov       rcx,[rdi+10]
       cmp       [rcx+8],r15d
       jbe       near ptr M29_L18
       mov       eax,r15d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M29_L17
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFDC237B1AC],0
       je        short M29_L07
       call      qword ptr [7FFDC2E84D68]
       mov       ebp,eax
       jmp       short M29_L09
M29_L07:
       mov       ecx,0C
       call      qword ptr [7FFDC2E84D80]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFDC2E84D80]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M29_L08
       call      qword ptr [7FFDC2E84D98]
       mov       ebp,eax
       jmp       short M29_L09
M29_L08:
       sar       ebp,10
M29_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2435740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFDC237B1A0]
       mov       esi,edx
       xor       ebp,ebp
       jmp       short M29_L13
M29_L10:
       cmp       esi,[r13+8]
       jae       near ptr M29_L29
       mov       ecx,esi
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFDC294D398]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M29_L11
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M29_L11:
       mov       rcx,r12
       call      qword ptr [7FFDC2436820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M29_L14
       inc       esi
       cmp       [r13+8],esi
       jne       short M29_L12
       xor       esi,esi
M29_L12:
       inc       ebp
M29_L13:
       cmp       [r13+8],ebp
       jg        short M29_L10
       jmp       short M29_L15
M29_L14:
       mov       r13,r12
       jmp       short M29_L16
M29_L15:
       xor       r13d,r13d
M29_L16:
       test      r13,r13
       je        short M29_L17
       cmp       byte ptr [r14+9D],0
       je        near ptr M29_L01
       mov       rcx,r13
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E84D50]
       jmp       near ptr M29_L01
M29_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M29_L20
M29_L18:
       test      ebp,ebp
       jne       short M29_L19
       mov       rdx,25678D162A0
       jmp       near ptr M29_L02
M29_L19:
       mov       ecx,ebp
       mov       rdx,25678D16F28
       call      qword ptr [7FFDC265D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M29_L20:
       cmp       ebp,800
       jge       short M29_L21
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M29_L22
M29_L21:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FFDC2A67540]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M29_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M29_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E84D50]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC285C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2E84DB0]
       jmp       near ptr M29_L01
M29_L23:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M29_L24
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FFDC25ADF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M29_L03
M29_L24:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M29_L25
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2E856B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M29_L25:
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
       jne       short M29_L26
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M29_L27
M29_L26:
       mov       rcx,215E3C01E00
       mov       rcx,[rcx]
       call      qword ptr [7FFDC2A89938]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M29_L27:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M29_L28
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFDC25ADF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M29_L28:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M29_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M29_L03
       mov       rcx,215E3C01E00
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
       jmp       qword ptr [7FFDC2A89940]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M29_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25678D10008
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
       call      qword ptr [7FFDC2D6E2B0]
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
       call      qword ptr [7FFE390184E0]
       cmp       byte ptr [rax],0
       je        near ptr M31_L03
       call      qword ptr [7FFE3901EBF0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M31_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
M31_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L01:
       call      qword ptr [7FFE3901A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M31_L00
       call      qword ptr [7FFE390184D8]
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
       call      qword ptr [7FFE390202F8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE3901EC20]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFE3901E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFE3901A6A0]
       test      rax,rax
       je        near ptr M31_L00
M31_L04:
       call      qword ptr [7FFE3901CE60]
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
       call      qword ptr [7FFE3901E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE3901C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FFE39019CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE3901E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M33_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFE39019CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE3901B210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE3901E578]
       mov       [rbp-20],rsi
       lea       rax,[M33_L00]
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
       je        near ptr M34_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M34_L07
M34_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M34_L08
M34_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FFE3901B180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M34_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M34_L03
M34_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE3901EF00]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M34_L04
M34_L03:
       mov       rcx,rax
       call      qword ptr [7FFE3901B218]
       jmp       short M34_L02
M34_L04:
       cmp       byte ptr [rbp-10],0
       je        short M34_L05
       mov       rcx,rbx
       call      qword ptr [7FFE3901B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M34_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M34_L06:
       call      qword ptr [7FFE3901CE58]
       int       3
M34_L07:
       mov       rcx,rax
       call      qword ptr [7FFE3901B218]
       jmp       near ptr M34_L00
M34_L08:
       mov       rcx,rax
       call      qword ptr [7FFE3901E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M34_L01
       sub       rsp,28
       call      qword ptr [7FFE3901B210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FFE39018258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M34_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE3901B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M34_L09:
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
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M35_L01
       cmp       [rax],ecx
       jle       short M35_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M35_L03
M35_L00:
       add       rsp,20
       pop       rbx
       ret
M35_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M35_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M35_L00
M35_L02:
       cmp       [rax+4],edx
       jle       short M35_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M35_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M35_L03
       jmp       short M35_L00
M35_L03:
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
       jne       short M36_L00
       ret
M36_L00:
       jmp       qword ptr [7FFDC2435C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,230A1000220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFDC2A57108]; System.Text.Json.JsonSerializerOptions.get_Default()
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
       mov       rcx,230A1001960
       mov       r9,[rcx]
       test      r9,r9
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC236D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,230A1001960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
M00_L03:
       mov       [rsp+20],rsi
       mov       rcx,rdi
       mov       rdx,7FFDC28CEFF8
       mov       r8,271360D19B8
       cmp       [rcx],ecx
       call      qword ptr [7FFDC284CDC8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFDC2A57450]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r13d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rcx,271360D62A0
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
       mov       rcx,230A1001E00
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFDC2A79938]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r13,271360D1518
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
       mov       rsi,271360D1518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r12+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r13d
       call      qword ptr [7FFDC2A574E0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       mov       r9,271360D19B8
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
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       mov       r9,271360D19B8
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
       call      qword ptr [7FFDC28B6510]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
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
       call      qword ptr [7FFDC2A5F468]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-1C8]
       mov       eax,[rbp-1C0]
       mov       [rbp-208],rcx
       mov       [rbp-200],eax
       lea       rcx,[rbp-208]
       call      qword ptr [7FFDC29B5BC0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L41
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFDC2A5DBA8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L22
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFDC2A5DBA8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFDC2A5EB08]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-1B8]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-118]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A5EB20]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A5F450]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFDC2A5EB08]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A5EB20]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L33:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A5F450]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFDC284C858]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFDC284C858]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFDC2A5F480]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFDC257F930]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFDC2B26FD0]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       call      qword ptr [7FFDC2B27960]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-1D8]
       call      qword ptr [7FFDC2B279D8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-1D8]
       mov       edi,[rbp-1D0]
       mov       rcx,230A1001D08
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFDC264FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L57
       mov       rcx,rax
       call      qword ptr [7FFDC2A2CCC0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L42:
       mov       [rbp-228],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L44
       mov       r13,offset MT_System.Byte
       mov       rcx,230A1000100
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
       call      qword ptr [7FFDC2E7D4A0]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-218],xmm0
       lea       r9,[rbp-218]
       mov       rdx,[rbp-230]
       mov       rcx,[rbp-228]
       mov       r8,271360E1858
       call      qword ptr [7FFDC2D46310]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L43
M00_L44:
       mov       rcx,[rbp-228]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2612100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-228]
       mov       rcx,r14
       call      qword ptr [7FFDC264FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFDC2A54A68]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L58
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFDC2A54A80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L45:
       mov       [rbp-1F8],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-1F8]
       mov       rdx,7FFDC2D71ED8
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2D46388]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,271360D19B8
       call      qword ptr [7FFDC2E74EB8]
       int       3
M00_L47:
       call      qword ptr [7FFDC29BE2C8]
       mov       ecx,7C8
       mov       rdx,7FFDC28089B8
       call      qword ptr [7FFDC2647738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2704878
       call      qword ptr [7FFDC2647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2427858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28089B8
       call      qword ptr [7FFDC2647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2427858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2E7D278]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2D4E118]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFDC2847048]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFDC284C870]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L50:
       call      qword ptr [7FFDC2E74EA0]
       int       3
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FFDC29365C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L52:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L53:
       mov       ecx,9
       call      qword ptr [7FFDC2D4DD10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L54:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,230B7000560
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L55:
       mov       rax,271360D62A0
       jmp       near ptr M00_L09
M00_L56:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,230B7000560
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
       mov       rcx,230A1001D08
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFDC264FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-228]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFDC2A54A68]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L59
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFDC2A54A80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
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
       call      qword ptr [7FFDC2A5F480]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,38
       ret
; Total bytes of code 3132
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,230A1001CD8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,230A1001CD8
       xor       edx,edx
       jmp       qword ptr [7FFDC2A57120]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       call      qword ptr [7FFE39019CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE3901E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFE39019CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE3901B210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE3901E578]
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rdx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       r14,r9
       test      rbx,rbx
       je        near ptr M03_L07
       test      r14,r14
       je        near ptr M03_L08
       mov       r15,[rsi+8]
       mov       r13,[r15+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M03_L05
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M03_L04
M03_L00:
       mov       rcx,r13
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r13d,eax
M03_L01:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L06
M03_L02:
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       call      qword ptr [7FFDC27B6418]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L09
M03_L03:
       mov       rcx,7FFDC2EA1478
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L04:
       mov       rdx,7FFDC2E97EC8
       call      qword ptr [7FFDC242C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M03_L00
M03_L05:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       short M03_L01
M03_L06:
       mov       rcx,rdi
       mov       rdx,7FFDC2E97EB0
       call      qword ptr [7FFDC2647AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,7FFDC2EA1360
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,1
       mov       rdx,7FFDC270ECE0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2936340]
       int       3
M03_L08:
       mov       rcx,7FFDC2EA1364
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,0B80
       mov       rdx,7FFDC270ECE0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2936340]
       int       3
M03_L09:
       mov       rcx,7FFDC2EA1368
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,r14
       mov       rdx,7FFDC2EA1370
       call      CORINFO_HELP_DELEGATEPROFILE32
       mov       rdx,rbx
       mov       r8,[rbp+30]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC27BC2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L03
; Total bytes of code 460
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
       jne       near ptr M04_L11
       and       esi,0FFFFFFF7
M04_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M04_L10
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
       mov       rcx,271360DFFA8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,271360D1518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,271360D1518
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
       mov       rdx,7FFDC285E7E0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E776D8]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       mov       ecx,38A0
       mov       rdx,7FFDC285E7E0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFDC2E776A8]
       int       3
M04_L11:
       cmp       edx,9
       je        short M04_L12
       mov       ecx,38A0
       mov       rdx,7FFDC285E7E0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E77690]
       int       3
M04_L12:
       or        esi,8
       jmp       near ptr M04_L00
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFDC285E7E0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2E776C0]
       int       3
M04_L14:
       mov       r8,271360D1518
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
       mov       rcx,230A1000C90
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
       call      qword ptr [7FFDC2D4DD10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E75518]
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
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFDC236B1AC],0
       je        short M05_L05
       call      qword ptr [7FFDC2E75530]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0C
       call      qword ptr [7FFDC2E75548]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFDC2E75548]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FFDC2E75560]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFDC236B1A0]
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
       call      qword ptr [7FFDC293D3B0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFDC2426820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E75518]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,271360D62A0
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
       mov       rdx,271360D6F28
       call      qword ptr [7FFDC264D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFDC2A57588]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDC2E75518]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2E75578]
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
       mov       rcx,230A1001E00
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,230A1000C90
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
       call      qword ptr [7FFDC2D4DD10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E75518]
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
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFDC236B1AC],0
       je        short M06_L07
       call      qword ptr [7FFDC2E75530]
       mov       ebp,eax
       jmp       short M06_L09
M06_L07:
       mov       ecx,0C
       call      qword ptr [7FFDC2E75548]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFDC2E75548]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M06_L08
       call      qword ptr [7FFDC2E75560]
       mov       ebp,eax
       jmp       short M06_L09
M06_L08:
       sar       ebp,10
M06_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFDC236B1A0]
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
       call      qword ptr [7FFDC293D3B0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFDC2426820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E75518]
       jmp       near ptr M06_L01
M06_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L20
M06_L18:
       test      ebp,ebp
       jne       short M06_L19
       mov       rdx,271360D62A0
       jmp       near ptr M06_L02
M06_L19:
       mov       ecx,ebp
       mov       rdx,271360D6F28
       call      qword ptr [7FFDC264D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFDC2A57588]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFDC2E75518]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2E75578]
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
       call      qword ptr [7FFDC259DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFDC2E766B8]
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
       mov       rcx,230A1001E00
       mov       rcx,[rcx]
       call      qword ptr [7FFDC2A79938]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFDC259DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,230A1001E00
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
       jmp       qword ptr [7FFDC2A79940]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFDC2425C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       mov       r9,271360D19B8
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
       call      qword ptr [7FFDC28B6510]
M08_L05:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L06:
       mov       rdx,7FFDC2EC7478
       call      qword ptr [7FFDC242C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,rsi
       call      qword ptr [7FFDC2A5DBA8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFDC2A5EB20]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A5F450]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFDC284C858]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFDC2597138]
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
       mov       r8,230A10013D0
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
       call      qword ptr [7FFDC2594BB8]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L05
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFE2205AFE0
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
       call      qword ptr [7FFDC2594BE8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       jmp       short M10_L03
M10_L02:
       mov       r15,271360D0008
M10_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFDC29BDC98]
       int       3
M10_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFDC2D47F60]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FFDC2D47F78]
       int       3
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFDC29BDC98]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFDC29B59E0]
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
       call      qword ptr [7FFDC29BDCB0]
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
       call      qword ptr [7FFDC2D47F90]
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
       call      qword ptr [7FFE3901F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFE3901F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rax,230A10013F8
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
       call      qword ptr [7FFDC2E77078]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFDC2A5EF28]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFDC2E77090]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFDC2E77048]
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FFDC2A5F138]
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
       call      qword ptr [7FFDC2A5EB50]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFDC295D940]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFDC2A5EF88]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFDC2A5F108]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FFDC2A5F138]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFDC29B5AB8]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFDC2E77030]
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
       call      qword ptr [7FFDC2A5F0A8]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FFDC29365C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFDC2E76FB8]
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
       call      qword ptr [7FFDC2E76FD0]
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
       call      qword ptr [7FFDC2E77780]
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
       call      qword ptr [7FFDC2E77798]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFDC2E777B0]
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
       mov       rdx,271360DEF70
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2E777E0]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,271360DEF20
       call      qword ptr [7FFDC2644EA0]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFDC2E777C8]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFDC2E777F8]
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
       call      qword ptr [7FFDC2E77C00]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2ED62B8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2E77C30]
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
       call      qword ptr [7FFDC2E77C48]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FFDC2370FC0
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       mov       [rbp-40],rax
       mov       [rbp+28],r9d
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9E],0
       je        near ptr M15_L20
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M15_L10
M15_L00:
       mov       r15,[r14+8]
       mov       rcx,230A1001960
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M15_L11
M15_L01:
       cmp       [r15],r15b
       test      rbx,rbx
       je        near ptr M15_L12
       mov       r12,[r15+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [r15+19],0
       jne       near ptr M15_L08
       mov       rdx,rbx
       mov       r11,7FFDC2370BD8
       call      qword ptr [r11]
M15_L02:
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFDC27B6418]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M15_L13
M15_L03:
       mov       r8,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       byte ptr [rbp+38],0
       jne       near ptr M15_L14
M15_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M15_L15
       mov       r14,[r8+8]
M15_L05:
       test      dil,dil
       je        short M15_L06
       test      r14,r14
       je        near ptr M15_L17
       mov       rcx,7FFDC2EA12B0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [r14+119],2
       jne       short M15_L09
M15_L06:
       test      r14,r14
       je        near ptr M15_L21
M15_L07:
       mov       rcx,7FFDC2EA12C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
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
M15_L08:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M15_L02
M15_L09:
       mov       rcx,r14
       call      qword ptr [7FFDC29365C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M15_L06
M15_L10:
       mov       rcx,rsi
       call      qword ptr [7FFDC284C870]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M15_L00
M15_L11:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFDC236D050
       call      qword ptr [7FFDC2426EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,230A1001960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M15_L01
M15_L12:
       mov       ecx,1
       mov       rdx,7FFDC270ECE0
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2936340]
       int       3
M15_L13:
       mov       rdx,rbx
       mov       r8,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-44]
       shl       r9,20
       or        r9,1
       mov       rdx,r12
       mov       r8,rbx
       mov       rcx,r15
       call      qword ptr [7FFDC27BC2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M15_L03
M15_L14:
       cmp       byte ptr [r8+20],0
       je        short M15_L16
       jmp       near ptr M15_L04
M15_L15:
       call      qword ptr [7FFDC2E74EA0]
       int       3
M15_L16:
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFDC2E759C8]
       mov       r14,rax
       jmp       near ptr M15_L05
M15_L17:
       mov       rcx,7FFDC2EA12B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L18:
       mov       rcx,7FFDC2EA12B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L19:
       mov       rcx,7FFDC2EA12BC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L07
M15_L20:
       cmp       byte ptr [rbp+30],0
       je        short M15_L18
       mov       rcx,7FFDC2EA12C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFDC284CE10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M15_L06
M15_L21:
       cmp       byte ptr [rbp+29],0
       je        short M15_L19
       mov       rcx,7FFDC2EA12C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFDC2E74EB8]
       int       3
; Total bytes of code 711
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
       jmp       qword ptr [7FFDC2D4E160]
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
       jle       near ptr M17_L43
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M17_L43
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
       mov       rcx,271360D62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L42
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L42
       mov       rcx,230A1001E00
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
       jle       near ptr M17_L44
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M17_L44
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
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFDC2D4E2C8]
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFDC264CED0]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
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
       call      00007FFE2200C390
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
       call      00007FFE2202DBC0
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
       call      qword ptr [7FFDC242E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D4D530]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FFDC2E7D5C0]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FFDC2E7D5D8]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC2E7D5F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC27B5D88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFDC2E7D608]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-88]
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M17_L45
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
       jne       near ptr M17_L47
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
       jae       near ptr M17_L55
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFDC2E77678]
M17_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFDC2C4ABE0],1
       je        near ptr M17_L48
M17_L18:
       cmp       byte ptr [7FFDC236B1AC],0
       je        near ptr M17_L33
       call      qword ptr [7FFDC2E75530]
       mov       [rbp-60],eax
       mov       edx,[rbp-60]
M17_L19:
       test      byte ptr [7FFDC2C349C8],1
       je        near ptr M17_L50
M17_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFDC236B1A0]
       mov       eax,edx
       mov       edx,[r13+8]
       mov       [rbp-70],edx
       test      edx,edx
       jle       near ptr M17_L54
       mov       [rbp-74],edx
M17_L21:
       cmp       eax,edx
       jae       near ptr M17_L55
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-98],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-64],r9d
       mov       rcx,r10
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M17_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFDC2D4E2C8]
M17_L22:
       mov       rax,[rbp-98]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-68],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L24
       test      r8d,r8d
       je        near ptr M17_L36
M17_L23:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-68]
       inc       ecx
       mov       rax,[rbp-98]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-64],1
M17_L24:
       mov       rcx,rax
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M17_L51
M17_L25:
       cmp       dword ptr [rbp-64],0
       je        near ptr M17_L52
       mov       r13d,1
M17_L26:
       mov       rcx,230A1000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L42
       mov       rcx,rbx
       call      00007FFE2200C390
       test      eax,eax
       je        near ptr M17_L37
       mov       [rbp-6C],eax
M17_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFE2200C390
       test      eax,eax
       je        near ptr M17_L38
M17_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-6C]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFDC2E75620]
       test      r13d,r15d
       jne       near ptr M17_L42
       mov       rcx,rbx
       call      qword ptr [7FFDC284C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFE2200C390
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M17_L39
M17_L29:
       test      r15d,r15d
       jne       near ptr M17_L40
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M17_L41
M17_L30:
       mov       r15,230A1001F50
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,230A1001F48
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
       call      00007FFE220180F0
       test      rax,rax
       je        near ptr M17_L46
M17_L32:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M17_L15
M17_L33:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0C
       jle       near ptr M17_L49
       mov       rcx,[rcx+240]
       mov       rax,[rcx+60]
       test      rax,rax
       je        near ptr M17_L49
M17_L34:
       mov       ecx,[rax+10]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       je        short M17_L35
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       jmp       near ptr M17_L19
M17_L35:
       call      qword ptr [7FFDC2E75560]
       mov       edx,eax
       jmp       near ptr M17_L19
M17_L36:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M17_L23
M17_L37:
       mov       rcx,rbx
       call      qword ptr [7FFDC242E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-6C],eax
       jmp       near ptr M17_L27
M17_L38:
       mov       rcx,rsi
       call      qword ptr [7FFDC242E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L28
M17_L39:
       mov       rcx,rsi
       call      qword ptr [7FFDC242E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M17_L29
M17_L40:
       xor       ecx,ecx
M17_L41:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFDC2E75638]
M17_L42:
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
M17_L43:
       mov       ecx,9
       call      qword ptr [7FFDC2D4DD10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L44:
       mov       ecx,0A
       call      qword ptr [7FFDC2D4DD10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L45:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFDC2D4DE60]
       jmp       near ptr M17_L14
M17_L46:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDC2E7D620]
       jmp       near ptr M17_L32
M17_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFDC2E755F0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDC27B5E30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M17_L18
M17_L49:
       mov       ecx,0C
       call      qword ptr [7FFDC2E75548]
       jmp       near ptr M17_L34
M17_L50:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFDC2425740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M17_L20
M17_L51:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFDC2D4DE60]
       jmp       near ptr M17_L25
M17_L52:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-70]
       cmp       edx,ecx
       jne       short M17_L53
       xor       ecx,ecx
M17_L53:
       mov       r8d,[rbp-74]
       dec       r8d
       mov       [rbp-74],r8d
       mov       eax,ecx
       jne       near ptr M17_L21
M17_L54:
       xor       r13d,r13d
       jmp       near ptr M17_L26
M17_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M17_L57
       cmp       qword ptr [rbp-88],0
       jne       short M17_L56
       xor       ecx,ecx
       call      qword ptr [7FFDC2D4D530]
       int       3
M17_L56:
       mov       rcx,[rbp-88]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M17_L57
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFDC2D4DE60]
M17_L57:
       nop
       add       rsp,38
       ret
; Total bytes of code 2077
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
       je        near ptr M18_L03
       mov       edi,[rbx+8]
       cmp       edi,20
       jle       near ptr M18_L04
       cmp       [rsi],sil
       lea       r8,[rbx+0C]
       mov       [rbp-38],r8
       mov       r14,[rbp-38]
       mov       r15d,edi
       lea       r8,[rbp-40]
       lea       r9,[rbp-48]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFDC242FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFDC242FAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       mov       ecx,0BC5
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D4D530]
       int       3
M18_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFDC293EAA8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
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
M18_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFDC2E762B0]
       add       r13d,eax
       jns       near ptr M18_L00
M18_L06:
       call      qword ptr [7FFDC2D47F78]
       int       3
M18_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFDC29B59E0]
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
       call      qword ptr [7FFDC2D4EC70]
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
       mov       rax,7FFDC2A40DB0
       mov       [rbp-70],rax
       lea       rax,[M19_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE5B1F3BE0
       call      rax
M19_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M19_L01
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFDC285DDA8
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D4D530]
       int       3
M19_L03:
       call      qword ptr [7FFDC2E77D98]
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
       jne       near ptr M20_L13
       xor       ecx,ecx
M20_L00:
       test      rcx,rcx
       jne       near ptr M20_L14
       mov       rsi,rbx
       test      rsi,rsi
       je        short M20_L01
       mov       rdx,offset MT_System.Byte[]
       cmp       [rsi],rdx
       jne       near ptr M20_L15
M20_L01:
       test      rsi,rsi
       je        near ptr M20_L26
       mov       rbx,[rsi]
       mov       rdi,offset MT_System.Byte[]
       cmp       rbx,rdi
       jne       near ptr M20_L16
       mov       ebp,[rsi+8]
M20_L02:
       test      ebp,ebp
       je        near ptr M20_L25
       movsxd    rdx,ebp
       mov       rcx,rdi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       rbx,rdi
       jne       near ptr M20_L24
       mov       edi,[rsi+8]
       cmp       dword ptr [rbx+4],18
       jne       near ptr M20_L23
       cmp       edi,[rsi+8]
       ja        near ptr M20_L23
       cmp       edi,[rbp+8]
       ja        near ptr M20_L23
       mov       r8d,edi
       movzx     ecx,word ptr [rbx]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbp+10]
       test      dword ptr [rbx],1000000
       jne       near ptr M20_L17
       mov       rax,rcx
       mov       r10,rdx
       mov       r9,r8
       mov       r11,rax
       sub       r11,r10
       cmp       r11,r9
       jb        near ptr M20_L21
       mov       r11,r10
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M20_L21
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
       je        near ptr M20_L19
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
       ja        short M20_L12
M20_L08:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
       jmp       short M20_L03
M20_L09:
       cmp       r9,800
       ja        near ptr M20_L22
       cmp       r9,100
       jae       near ptr M20_L20
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
       vmovups   xmm0,[r10+10]
       vmovups   [rax+10],xmm0
       cmp       r9,30
       jbe       short M20_L08
       jmp       short M20_L18
M20_L13:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M20_L00
M20_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+30]
M20_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M20_L01
M20_L16:
       mov       rcx,rsi
       mov       r11,7FFDC2370FD8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M20_L02
M20_L17:
       call      qword ptr [7FFDC24257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M20_L03
M20_L18:
       vmovups   xmm0,[r10+20]
       vmovups   [rax+20],xmm0
       jmp       near ptr M20_L08
M20_L19:
       test      r8,r8
       je        near ptr M20_L03
       movzx     r9d,byte ptr [rdx]
       mov       [rcx],r9b
       test      r8b,2
       je        near ptr M20_L03
       movsx     rcx,word ptr [r11-2]
       mov       [rdi-2],cx
       jmp       near ptr M20_L03
M20_L20:
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
M20_L21:
       cmp       rcx,rdx
       je        near ptr M20_L03
M20_L22:
       cmp       [rcx],cl
       call      qword ptr [7FFDC24266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M20_L03
M20_L23:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFDC2D4C8A0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M20_L03
M20_L24:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFDC2370FE0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M20_L03
M20_L25:
       mov       rax,271360D62A0
       jmp       near ptr M20_L04
M20_L26:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDC2B279F0]
; Total bytes of code 780
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
       jmp       qword ptr [7FFDC264FC48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      00007FFE22014230
       cmp       rax,[rsp+28]
       jne       short M23_L02
M23_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M23_L01:
       call      qword ptr [7FFDC2D4DA58]
       int       3
M23_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A549C0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
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
       ja        near ptr M25_L60
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
       jae       near ptr M25_L61
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+38],rdx
       test      r15,r15
       jne       near ptr M25_L36
M25_L03:
       test      r12,r12
       jne       near ptr M25_L50
       mov       [rsp+90],eax
       test      eax,eax
       jne       short M25_L04
       mov       [rsp+94],r8d
       test      r8d,r8d
       jne       near ptr M25_L40
       mov       r8d,[rsp+94]
M25_L04:
       mov       rdx,[rsp+38]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M25_L05
       mov       r12,offset MT_System.Byte
       cmp       [rcx],r12
       jne       near ptr M25_L38
M25_L05:
       test      rcx,rcx
       mov       [rsp+28],r10
       mov       [rsp+94],r8d
       mov       [rsp+40],r11
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
       ja        near ptr M25_L62
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
       mov       r11,7FFE1D72C0B8
       add       r10,[r11+r8*8]
       sar       r10,20
       cmp       r10d,r12d
       jle       short M25_L06
       xor       r10d,r10d
       mov       [rsp+88],r10d
       jmp       near ptr M25_L10
       nop       dword ptr [rax+rax]
M25_L06:
       mov       [rsp+88],r10d
       mov       [rsp+70],rdx
       movsxd    r8,r10d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M25_L18
       cmp       ecx,64
       jb        short M25_L08
       mov       r8,271360D1234
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
       mov       r8,271360D1234
       shl       ecx,2
       mov       r8d,[r8+rcx]
       mov       [rdx],r8d
M25_L09:
       xor       edx,edx
       mov       [rsp+70],rdx
       mov       r10d,1
M25_L10:
       xor       edx,edx
       mov       [rsp+70],rdx
M25_L11:
       test      r10d,r10d
       mov       [rsp+6C],r9d
       mov       rdx,[rsp+38]
       je        near ptr M25_L45
       mov       r8d,[rsp+88]
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
       ja        near ptr M25_L62
       cmp       r8d,ecx
       ja        near ptr M25_L63
       add       r10d,[rsp+88]
       mov       [rsi+18],r10d
       cmp       dword ptr [rsp+90],0
       jne       near ptr M25_L43
M25_L12:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M25_L19
       mov       r8d,r13d
       lea       rax,[rbx+r8*2+0C]
       mov       [rsp+30],rax
       mov       r10d,r12d
       sub       r10d,r13d
       mov       [rsp+84],r10d
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,rax
       mov       r9d,r10d
       call      qword ptr [7FFDC264C5D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+80],eax
       test      eax,eax
       jl        near ptr M25_L55
       mov       r10d,[rsp+84]
       cmp       eax,r10d
       ja        near ptr M25_L62
       test      eax,eax
       jne       near ptr M25_L23
M25_L13:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M25_L64
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L58
       mov       eax,r13d
       movzx     edx,word ptr [rbx+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M25_L27
       cmp       ecx,7B
       jne       near ptr M25_L56
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M25_L57
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L58
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
       jne       near ptr M25_L59
       mov       r10d,r13d
       lea       r13d,[r10+1]
       cmp       r12d,r13d
       jbe       near ptr M25_L58
M25_L17:
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,7D
       je        near ptr M25_L01
       cmp       r11d,7B
       je        near ptr M25_L59
       inc       r13d
       cmp       r12d,r13d
       ja        short M25_L17
       jmp       near ptr M25_L58
M25_L18:
       lea       r8d,[rcx+30]
       mov       [rdx-2],r8w
       jmp       near ptr M25_L09
M25_L19:
       mov       rax,rsi
       add       rsp,98
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
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rcx,rax
       call      qword ptr [7FFDC2D4D530]
       int       3
M25_L21:
       xor       edx,edx
       jmp       near ptr M25_L00
M25_L22:
       mov       rcx,rdi
       mov       r11,7FFDC2370FF8
       mov       rdx,271360E5FC0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M25_L00
M25_L23:
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+7C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M25_L26
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        short M25_L24
       mov       r9,[rsp+30]
       movzx     r8d,word ptr [r9]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M25_L25
       movzx     r8d,word ptr [r9+2]
       mov       [rcx+2],r8w
       jmp       short M25_L25
M25_L24:
       mov       r9,[rsp+30]
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r9
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+80]
M25_L25:
       mov       r10d,eax
       add       r10d,[rsp+7C]
       mov       [rsi+18],r10d
       jmp       near ptr M25_L13
M25_L26:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8d,eax
       call      qword ptr [7FFDC259F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+80]
       jmp       near ptr M25_L13
M25_L27:
       mov       rcx,rsi
       call      qword ptr [7FFDC259F120]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M25_L12
M25_L28:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L58
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
       jbe       near ptr M25_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M25_L15
M25_L31:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,20
       je        short M25_L31
       cmp       r11d,2D
       jne       short M25_L32
       mov       dword ptr [rsp+90],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M25_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       mov       eax,[rsp+90]
M25_L32:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M25_L57
       inc       r13d
       cmp       r12d,r13d
       ja        short M25_L34
       jmp       near ptr M25_L58
M25_L33:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+94],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+94]
       jbe       near ptr M25_L58
M25_L34:
       cmp       r13d,r12d
       jae       near ptr M25_L64
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
       jbe       near ptr M25_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       short M25_L35
M25_L36:
       test      r9d,r9d
       mov       [rsp+90],eax
       mov       [rsp+94],r8d
       je        near ptr M25_L44
       mov       [rsp+28],r10
       mov       [rsp+58],r10
       mov       [rsp+6C],r9d
       mov       [rsp+60],r9d
       lea       rcx,[rsp+58]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M25_L37:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       r8,[rsp+38]
       mov       r11,7FFDC2371010
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+6C]
       mov       r10,[rsp+28]
       mov       r11,[rsp+40]
       jmp       near ptr M25_L03
M25_L38:
       mov       [rsp+6C],r9d
       mov       [rsp+28],r10
       mov       [rsp+94],r8d
       mov       [rsp+40],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+38]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+6C]
       mov       r10,[rsp+28]
       mov       r11,[rsp+40]
       jmp       near ptr M25_L05
M25_L39:
       mov       [rsp+6C],r9d
       jmp       near ptr M25_L45
M25_L40:
       mov       [rsp+6C],r9d
       mov       [rsp+28],r10
       mov       [rsp+40],r11
       mov       rdx,[rsp+38]
       jmp       near ptr M25_L45
M25_L41:
       mov       r11,[rsp+28]
       mov       [rsp+58],r11
       mov       [rsp+6C],r9d
       mov       [rsp+60],r9d
       mov       [rsp+48],rdx
       mov       [rsp+50],r12d
       lea       rdx,[rsp+88]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+58]
       lea       r9,[rsp+48]
       mov       r8,rdi
       call      qword ptr [7FFDC2D46358]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r10d,eax
       mov       r9d,[rsp+6C]
       jmp       near ptr M25_L11
M25_L42:
       mov       [rsp+48],rdx
       mov       [rsp+50],r12d
       mov       r12,[rsp+28]
       mov       [rsp+58],r12
       mov       [rsp+6C],r9d
       mov       [rsp+60],r9d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+48]
       lea       r9,[rsp+58]
       lea       r8,[rsp+88]
       mov       r11,7FFDC2371008
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r9d,[rsp+6C]
       jmp       near ptr M25_L11
M25_L43:
       mov       r12d,[rsp+94]
       cmp       r12d,[rsp+88]
       jle       near ptr M25_L12
       mov       r8d,r12d
       sub       r8d,[rsp+88]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E76B08]
       jmp       near ptr M25_L12
M25_L44:
       mov       [rsp+6C],r9d
       mov       [rsp+28],r10
       jmp       near ptr M25_L37
M25_L45:
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M25_L47
       mov       ecx,[rsp+6C]
       test      ecx,ecx
       je        short M25_L46
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       jne       short M25_L46
       mov       r10,[rsp+28]
       mov       [rsp+58],r10
       mov       [rsp+60],ecx
       lea       rcx,[rsp+58]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       [rsp+40],rdx
M25_L46:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+40]
       mov       r11,7FFDC2371000
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M25_L49
M25_L47:
       mov       r12,[rsp+38]
       test      r12,r12
       jne       short M25_L48
       xor       r12d,r12d
       jmp       short M25_L49
M25_L48:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M25_L49:
       test      r12,r12
       jne       short M25_L52
       mov       r12,271360D0008
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
M25_L50:
       mov       [rsp+94],r8d
       cmp       [r12+8],r8d
       jl        short M25_L53
M25_L51:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDC259F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M25_L12
M25_L52:
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
       jmp       short M25_L50
M25_L53:
       test      eax,eax
       je        short M25_L54
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDC259F1C8]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E76B08]
       jmp       near ptr M25_L12
M25_L54:
       mov       r8d,[rsp+94]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDC2E76B08]
       jmp       short M25_L51
M25_L55:
       mov       rbx,[rsp+30]
       mov       [rsp+58],rbx
       mov       ebx,[rsp+84]
       mov       [rsp+60],ebx
       lea       rdx,[rsp+58]
       mov       rcx,rsi
       call      qword ptr [7FFDC2B2D1A0]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M25_L19
M25_L56:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFDC2E76B20]
       int       3
M25_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFDC2E76B20]
       int       3
M25_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDC2E76B20]
       int       3
M25_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDC2E76B20]
       int       3
M25_L60:
       mov       ecx,21
       call      qword ptr [7FFDC2647870]
       int       3
M25_L61:
       call      qword ptr [7FFDC2E76B38]
       int       3
M25_L62:
       call      qword ptr [7FFDC2597138]
       int       3
M25_L63:
       call      qword ptr [7FFDC2E76B50]
       int       3
M25_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2473
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
       call      00007FFE2205AFE0
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
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,271360D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M26_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rbx,rax
       call      qword ptr [7FFDC2D4DA70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2936070]
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
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDC2D4D500]
       int       3
M27_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rsi,rax
       call      qword ptr [7FFDC2E766A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDC2936070]
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
       call      qword ptr [7FFDC2E76B08]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFDC2E774B0]
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
       call      qword ptr [7FFDC29BE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFDC2594FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M28_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M28_L11
       cmp       dword ptr [rbx+20],0
       jl        short M28_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M28_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M28_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M28_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M28_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFE22014230
       test      rax,rax
       jne       near ptr M28_L13
M28_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M28_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFDC2364000
       call      qword ptr [7FFDC2647738]
       mov       rsi,rax
       call      qword ptr [7FFDC2E766A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDC2936070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M28_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M28_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDC2E76B08]
       jmp       near ptr M28_L00
M28_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDC2E774B0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M28_L09
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
       jge       short M28_L07
       cmp       ecx,400
       jge       short M28_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M28_L06
M28_L05:
       xor       edx,edx
       call      qword ptr [7FFDC29BE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M28_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFDC2594FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M28_L08
M28_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M28_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M28_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M28_L00
M28_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M28_L00
M28_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M28_L12:
       call      qword ptr [7FFDC2D4DA58]
       int       3
M28_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M28_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2A54AB0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       near ptr M28_L01
M28_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M28_L11
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,271360D0008
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
       call      qword ptr [7FFDC2D4EA78]
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
       call      qword ptr [7FFE390184E0]
       cmp       byte ptr [rax],0
       je        near ptr M31_L03
       call      qword ptr [7FFE3901EBF0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M31_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
M31_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L01:
       call      qword ptr [7FFE3901A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M31_L00
       call      qword ptr [7FFE390184D8]
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
       call      qword ptr [7FFE390202F8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE3901EC20]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFE3901E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFE3901A6A0]
       test      rax,rax
       je        near ptr M31_L00
M31_L04:
       call      qword ptr [7FFE3901CE60]
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
       call      qword ptr [7FFE3901E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE3901C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M33_L01
       mov       rcx,rsi
       call      qword ptr [7FFDC2D4E2C8]
M33_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M33_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M33_L03
       mov       rcx,7FFDC2EA9A20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFDC29365E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M33_L04
M33_L02:
       xor       ecx,ecx
       call      qword ptr [7FFDC2D4D530]
       int       3
M33_L03:
       mov       rcx,7FFDC2EA9A1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2E74EA0]
       int       3
M33_L04:
       mov       rcx,7FFDC2EA9A24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M33_L10
M33_L05:
       mov       rcx,7FFDC2EA9A28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2EA9A2C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M33_L06:
       call      qword ptr [7FFDC2E75FE0]
       int       3
M33_L07:
       mov       rcx,7FFDC2EA9A18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2E74EA0]
       int       3
M33_L08:
       mov       rcx,rbx
       call      qword ptr [7FFDC284C8A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M33_L09
       call      qword ptr [7FFDC2D4DA58]
       int       3
M33_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFE22014230
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M33_L00
M33_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFDC2D4DE60]
       jmp       near ptr M33_L05
       sub       rsp,28
       call      qword ptr [7FFDC2E75FF8]
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
       mov       rcx,7FFDC2EA9A24
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M33_L11
       xor       ecx,ecx
       call      qword ptr [7FFDC2D4D530]
       int       3
M33_L11:
       mov       rcx,[rbp-20]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M33_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFDC2D4DE60]
M33_L12:
       mov       rcx,7FFDC2EA9A28
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
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFDC2425C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,292090002D8
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
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L01:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFE1D7268D0
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
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L18
M00_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L17
       mov       rax,7FFE1D7268D0
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
       mov       rcx,7FFDC2B54030
       call      qword ptr [7FFDC2B1D7B8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFDC29265C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M00_L05
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FFDC2B17498]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rcx,rax
       mov       rdx,2D2880BFFC0
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2B174B0]; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       mov       rdx,rax
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFDC28340F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFDC2B75278]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D2880C1D28
       call      qword ptr [7FFDC2B75290]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      qword ptr [7FFDC2B75DB8]
       test      eax,eax
       jne       short M00_L12
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFDC2B75DB8]
       test      eax,eax
       je        near ptr M00_L02
M00_L12:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFDC2B75DD0]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L13:
       call      qword ptr [7FFDC29AE400]
       mov       ecx,7B6
       mov       rdx,7FFDC27F89B8
       call      qword ptr [7FFDC2637738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26F4878
       call      qword ptr [7FFDC2637738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2417858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC27F89B8
       call      qword ptr [7FFDC2637738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2417858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2B75278]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2B75290]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFDC28340F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFDC2B75278]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D2880C1D28
       call      qword ptr [7FFDC2B75290]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       call      qword ptr [7FFDC2B75DB8]
       test      eax,eax
       jne       short M00_L18
       jmp       near ptr M00_L03
M00_L17:
       call      qword ptr [7FFDC2B75DB8]
       test      eax,eax
       je        near ptr M00_L04
M00_L18:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFDC2B75DD0]
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L19:
       mov       ecx,3888
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2B75860]
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
       mov       rax,4C2E6A8C1254
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
       mov       rcx,291F3001E00
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,291F3000C90
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
       call      qword ptr [7FFDC2837CA8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FFDC29A5230]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FFDC29A52C0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M01_L13
M01_L07:
       call      qword ptr [7FFDC2587138]
       int       3
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2B7F330]
       int       3
M01_L09:
       mov       ecx,38A0
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2B7F348]
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
       mov       r8,4C2E6A8C1254
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
       call      qword ptr [7FFDC2837108]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,0A
       call      qword ptr [7FFDC2B76088]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFDC2B1DD70]
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
       call      qword ptr [7FFDC2B1E640]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFDC292D3B0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFDC2416820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFDC2B1DD70]
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
       mov       r8,2D2880B62A0
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,r13d
       mov       rdx,2D2880B6F28
       call      qword ptr [7FFDC263D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFDC2A47678]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M01_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M01_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFDC2B1DD70]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2B1DDB8]
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
       call      qword ptr [7FFDC24157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,291F3001E00
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
       call      qword ptr [7FFDC2B76088]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       call      qword ptr [7FFDC2A4F6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFDC2B1E1A8]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFDC2354000
       call      qword ptr [7FFDC2637738]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFDC27A5E30]
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
       call      qword ptr [7FFDC2B7FA68]
M01_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFDC2B1E640]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFDC292D3B0]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFDC2416820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,291F3000C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFDC2B7E778]
       test      r14d,edi
       jne       short M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2B1E220]
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
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M02_L01
       mov       rcx,rsi
       call      qword ptr [7FFDC2B76628]
M02_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M02_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M02_L03
       mov       rcx,7FFDC2CB2F88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFDC29265E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M02_L04
M02_L02:
       xor       ecx,ecx
       call      qword ptr [7FFDC2B75860]
       int       3
M02_L03:
       mov       rcx,7FFDC2CB2F84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2B7D848]
       int       3
M02_L04:
       mov       rcx,7FFDC2CB2F8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M02_L10
M02_L05:
       mov       rcx,7FFDC2CB2F90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2CB2F94
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L06:
       call      qword ptr [7FFDC2B7EE98]
       int       3
M02_L07:
       mov       rcx,7FFDC2CB2F80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2B7D848]
       int       3
M02_L08:
       mov       rcx,rbx
       call      qword ptr [7FFDC283C8A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [7FFDC2B75D88]
       int       3
M02_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFE22014230
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFDC2B761D8]
       jmp       near ptr M02_L05
       sub       rsp,28
       call      qword ptr [7FFDC2B7EEB0]
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
       mov       rcx,7FFDC2CB2F8C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M02_L11
       xor       ecx,ecx
       call      qword ptr [7FFDC2B75860]
       int       3
M02_L11:
       mov       rcx,[rbp-20]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M02_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFDC2B761D8]
M02_L12:
       mov       rcx,7FFDC2CB2F90
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
       call      qword ptr [7FFE39019CB8]
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE3901E4A8]; Precode of System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE3901E4B8]; Precode of System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE3901E4D0]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFE3901AE88]; Precode of System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rcx,rbx
       call      qword ptr [7FFE3901EF58]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.IsInvalidForSerialization(System.Type)
       test      eax,eax
       jne       short M04_L00
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE3901E448]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE3901CE30]
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
       jmp       qword ptr [7FFDC241FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2415818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2415818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D2880B0008
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
       call      qword ptr [7FFDC2B76DD8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
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
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M00_L12
       call      qword ptr [7FFDC243C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M00_L11
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFDC2437C48]; System.RuntimeType.InitializeCache()
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
       je        near ptr M00_L22
       mov       rax,2E4C287FD64
       mov       [rsp+28],rax
       mov       eax,15051505
       mov       edx,15051505
       mov       rcx,[rsp+28]
       mov       r8d,4
M00_L03:
       add       r8d,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[rcx+4]
       add       rcx,8
       cmp       r8d,2
       jg        short M00_L03
       test      r8d,r8d
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
       jae       near ptr M00_L28
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,2E4C287FD58
       cmp       r13,rcx
       jne       near ptr M00_L16
M00_L06:
       mov       rcx,[rdi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L28
       mov       edx,r15d
       mov       rdi,[rcx+rdx*8+10]
M00_L07:
       test      rdi,rdi
       je        near ptr M00_L23
M00_L08:
       mov       ecx,[rdi+8]
       xor       r8d,r8d
       mov       [rsp+30],r8
       mov       [rsp+38],r8
       mov       [rsp+40],r8d
       mov       [rsp+44],ecx
       xor       esi,esi
       cmp       [rdi+8],esi
       jg        near ptr M00_L24
M00_L09:
       vmovdqu   xmm0,xmmword ptr [rsp+30]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+40]
       mov       [rsp+58],rcx
       cmp       dword ptr [rsp+58],0
       jne       near ptr M00_L26
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
       call      00007FFE22014230
       mov       rbp,rax
       test      rbp,rbp
       cmove     rbp,r14
       jmp       near ptr M00_L02
M00_L14:
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
       jmp       near ptr M00_L04
M00_L15:
       cmp       r15d,r14d
       jae       near ptr M00_L28
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        short M00_L22
       jmp       near ptr M00_L05
M00_L16:
       cmp       dword ptr [r13+8],4
       je        short M00_L18
M00_L17:
       inc       r15d
       mov       r14d,[rbp+8]
       cmp       r14d,r15d
       jg        short M00_L15
       jmp       short M00_L21
M00_L18:
       lea       rcx,[r13+0C]
       mov       rdx,2E4C287FD64
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L19
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M00_L20
M00_L19:
       call      qword ptr [7FFDC243FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       test      eax,eax
       je        short M00_L17
       jmp       near ptr M00_L06
M00_L21:
       sub       r15d,r14d
       jmp       short M00_L15
M00_L22:
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       rdx,2E4C287FD58
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFDC243D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L24:
       mov       r8,[rdi+rsi*8+10]
       mov       ecx,[r8+58]
       and       ecx,36
       cmp       ecx,[r8+58]
       jne       short M00_L25
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFDC243D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L25:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L24
       jmp       near ptr M00_L09
M00_L26:
       lea       rcx,[rsp+48]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       xor       r8d,r8d
       call      qword ptr [7FFDC2C5C960]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsp+58],1
       jne       short M00_L27
       jmp       near ptr M00_L10
M00_L27:
       mov       rcx,rsi
       call      qword ptr [7FFDC2C55EF0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 804
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
       call      qword ptr [7FFDC2435C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE22017010
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
       mov       rax,7FFDC2571B50
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE21FF8A70
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M02_L04
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE220265E0
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
       call      qword ptr [7FFDC2C5D6F8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFDC2B3FE10]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFDC2437C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rcx,7FFDC2B6BE40
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M03_L01
       mov       rcx,7FFDC2B6BE58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2B6BE5C
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
       mov       rcx,7FFDC2B6BE24
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
       mov       rcx,7FFDC2B6BE44
       call      CORINFO_HELP_COUNTPROFILE32
M03_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M03_L10
       mov       rcx,7FFDC2B6BE48
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FFDC2B6BE28
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
       mov       rcx,7FFDC2B6BE54
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
       mov       rcx,7FFDC2B6BE38
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M03_L07
M03_L08:
       mov       rcx,7FFDC2B6BE3C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L09:
       mov       rcx,7FFDC2B6BE60
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
       mov       rcx,7FFDC2B6BE4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L11:
       mov       rcx,7FFDC2B6BE2C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       mov       rcx,7FFDC2B6BE30
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L04
M03_L13:
       mov       rcx,7FFDC2B6BE34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L14:
       cmp       rbx,4
       jb        short M03_L15
       mov       rcx,7FFDC2B6BE20
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
       mov       rcx,7FFDC2B6BE18
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M03_L16:
       test      bl,1
       je        short M03_L17
       mov       rcx,7FFDC2B6BE1C
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
       mov       rcx,7FFDC2B6BE50
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,0BE0630C2384B
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M04_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M04_L06
       cmp       r14d,1
       jne       short M04_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M04_L01
       mov       rcx,7FFDC2C43970
       call      CORINFO_HELP_COUNTPROFILE32
M04_L00:
       mov       rcx,2A42D800220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFDC2C43978
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M04_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M04_L04
M04_L01:
       cmp       r15d,2A
       jne       near ptr M04_L05
       mov       rcx,7FFDC2C4396C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L00
M04_L02:
       mov       rcx,7FFDC2C43A80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M04_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M04_L03
       xor       ecx,ecx
M04_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M04_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M04_L04:
       mov       rcx,7FFDC2C43A84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDC243D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M04_L07
M04_L05:
       mov       rcx,7FFDC2C43968
       call      CORINFO_HELP_COUNTPROFILE32
M04_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2E4C2870008
       call      qword ptr [7FFDC243D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M04_L07:
       mov       rcx,7FFDC2C43A88
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFDC243D578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0BE0630C2384B
       cmp       [rbp],r8
       je        short M04_L08
       call      CORINFO_HELP_FAIL_FAST
M04_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
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
       je        near ptr M05_L09
       cmp       ecx,1
       je        near ptr M05_L04
       cmp       [rbx+14],ecx
       je        short M05_L02
       mov       rcx,7FFDC2BA0EE0
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,7FFDC2BA0ED8
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rdi
       call      qword ptr [7FFDC24357B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M05_L01:
       mov       rcx,7FFDC2BA0EDC
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,7FFDC2BA0ED4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,[rbx+14]
       add       ebp,ebp
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M05_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L10
M05_L03:
       mov       rdx,rbx
       mov       r8d,ebp
       call      qword ptr [7FFDC243D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],ebp
       jmp       short M05_L00
M05_L04:
       cmp       dword ptr [rbx+14],2
       jl        short M05_L07
M05_L05:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
M05_L06:
       movsxd    rdx,dword ptr [rbx+14]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FFDC24357B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M05_L00
M05_L07:
       mov       rcx,7FFDC2BA0ED0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbx+14],4
       jmp       short M05_L05
M05_L08:
       mov       rcx,rsi
       mov       rdx,7FFDC2B8A078
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
M05_L09:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L10:
       mov       rcx,rsi
       mov       rdx,7FFDC2B8A058
       call      qword ptr [7FFDC243C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L03
; Total bytes of code 349
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
       call      qword ptr [7FFE1E396FC0]
       int       3
; Total bytes of code 47
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M00_L11
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFDC2427C48]; System.RuntimeType.InitializeCache()
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
       je        near ptr M00_L22
       mov       rax,20429A6FD14
       mov       [rsp+28],rax
       mov       eax,15051505
       mov       edx,15051505
       mov       rcx,[rsp+28]
       mov       r8d,4
M00_L03:
       add       r8d,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[rcx+4]
       add       rcx,8
       cmp       r8d,2
       jg        short M00_L03
       test      r8d,r8d
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
       jae       near ptr M00_L28
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,20429A6FD08
       cmp       r13,rcx
       jne       near ptr M00_L16
M00_L06:
       mov       rcx,[rdi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L28
       mov       edx,r15d
       mov       rdi,[rcx+rdx*8+10]
M00_L07:
       test      rdi,rdi
       je        near ptr M00_L23
M00_L08:
       mov       ecx,[rdi+8]
       xor       r8d,r8d
       mov       [rsp+30],r8
       mov       [rsp+38],r8
       mov       [rsp+40],r8d
       mov       [rsp+44],ecx
       xor       esi,esi
       cmp       [rdi+8],esi
       jg        near ptr M00_L24
M00_L09:
       vmovdqu   xmm0,xmmword ptr [rsp+30]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+40]
       mov       [rsp+58],rcx
       cmp       dword ptr [rsp+58],0
       jne       near ptr M00_L26
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
       call      00007FFE22014230
       mov       rbp,rax
       test      rbp,rbp
       cmove     rbp,r14
       jmp       near ptr M00_L02
M00_L14:
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
       jmp       near ptr M00_L04
M00_L15:
       cmp       r15d,r14d
       jae       near ptr M00_L28
       mov       ecx,r15d
       mov       r13,[rbp+rcx*8+10]
       test      r13,r13
       je        short M00_L22
       jmp       near ptr M00_L05
M00_L16:
       cmp       dword ptr [r13+8],4
       je        short M00_L18
M00_L17:
       inc       r15d
       mov       r14d,[rbp+8]
       cmp       r14d,r15d
       jg        short M00_L15
       jmp       short M00_L21
M00_L18:
       lea       rcx,[r13+0C]
       mov       rdx,20429A6FD14
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L19
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M00_L20
M00_L19:
       call      qword ptr [7FFDC242FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       test      eax,eax
       je        short M00_L17
       jmp       near ptr M00_L06
M00_L21:
       sub       r15d,r14d
       jmp       short M00_L15
M00_L22:
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,rsi
       mov       rdx,20429A6FD08
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFDC242D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L24:
       mov       r8,[rdi+rsi*8+10]
       mov       ecx,[r8+58]
       and       ecx,36
       cmp       ecx,[r8+58]
       jne       short M00_L25
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFDC242D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L25:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L24
       jmp       near ptr M00_L09
M00_L26:
       lea       rcx,[rsp+48]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       xor       r8d,r8d
       call      qword ptr [7FFDC2C4C3A8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsp+58],1
       jne       short M00_L27
       jmp       near ptr M00_L10
M00_L27:
       mov       rcx,rsi
       call      qword ptr [7FFDC2C45E00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 804
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
       call      qword ptr [7FFDC2425C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE22017010
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
       mov       rax,7FFDC2561B50
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE21FF8A70
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M02_L04
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE220265E0
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
       call      qword ptr [7FFDC2C4CD68]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFDC2B2FD20]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFDC2427C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rcx,7FFDC2B5B180
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M03_L01
       mov       rcx,7FFDC2B5B198
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2B5B19C
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
       mov       rcx,7FFDC2B5B164
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
       mov       rcx,7FFDC2B5B184
       call      CORINFO_HELP_COUNTPROFILE32
M03_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M03_L10
       mov       rcx,7FFDC2B5B188
       call      CORINFO_HELP_COUNTPROFILE32
M03_L04:
       mov       rcx,7FFDC2B5B168
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
       mov       rcx,7FFDC2B5B194
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
       mov       rcx,7FFDC2B5B178
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M03_L07
M03_L08:
       mov       rcx,7FFDC2B5B17C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L09:
       mov       rcx,7FFDC2B5B1A0
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
       mov       rcx,7FFDC2B5B18C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L11:
       mov       rcx,7FFDC2B5B16C
       call      CORINFO_HELP_COUNTPROFILE32
M03_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       mov       rcx,7FFDC2B5B170
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L04
M03_L13:
       mov       rcx,7FFDC2B5B174
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L09
M03_L14:
       cmp       rbx,4
       jb        short M03_L15
       mov       rcx,7FFDC2B5B160
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
       mov       rcx,7FFDC2B5B158
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M03_L16:
       test      bl,1
       je        short M03_L17
       mov       rcx,7FFDC2B5B15C
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
       mov       rcx,7FFDC2B5B190
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
       mov       rax,78A864BF4E6A
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
       mov       r8,1C394800220
       mov       r13,[r8]
       lea       r8,[rbx+0C]
       mov       [rbp+38],r8
       mov       r12,[rbp+38]
       lea       r8,[rbp+28]
       lea       r9,[rbp+20]
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FFDC242FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFDC242D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
M04_L05:
       lea       rdx,[rbp+40]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFDC242D578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+40]
       mov       r8,78A864BF4E6A
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
       mov       rdx,20429A60008
       call      qword ptr [7FFDC242D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
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
       call      qword ptr [7FFDC2C476D8]
       add       eax,[rbp+34]
       mov       r15d,eax
       test      r15d,r15d
       mov       [rbp+34],r15d
       jge       near ptr M04_L01
M04_L10:
       call      qword ptr [7FFDC29BE2B0]
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
       je        near ptr M05_L09
       cmp       ecx,1
       je        near ptr M05_L04
       cmp       [rbx+14],ecx
       je        short M05_L02
       mov       rcx,7FFDC2B90950
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,7FFDC2B90948
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rdi
       call      qword ptr [7FFDC24257B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M05_L01:
       mov       rcx,7FFDC2B9094C
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,7FFDC2B90944
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,[rbx+14]
       add       ebp,ebp
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M05_L10
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L10
M05_L03:
       mov       rdx,rbx
       mov       r8d,ebp
       call      qword ptr [7FFDC242D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],ebp
       jmp       short M05_L00
M05_L04:
       cmp       dword ptr [rbx+14],2
       jl        short M05_L07
M05_L05:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M05_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
M05_L06:
       movsxd    rdx,dword ptr [rbx+14]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      qword ptr [7FFDC24257B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M05_L00
M05_L07:
       mov       rcx,7FFDC2B90940
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbx+14],4
       jmp       short M05_L05
M05_L08:
       mov       rcx,rsi
       mov       rdx,7FFDC2B79DC0
       call      qword ptr [7FFDC242C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L06
M05_L09:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L10:
       mov       rcx,rsi
       mov       rdx,7FFDC2B79DA0
       call      qword ptr [7FFDC242C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L03
; Total bytes of code 349
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
       call      qword ptr [7FFE1E396FC0]
       int       3
; Total bytes of code 47
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1D69E161858
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

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC280EB90]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
       sub       rsp,118
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass16_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2B0B0477DE0
       mov       [rsi+8],rcx
       mov       word ptr [rsi+10],3A
       test      rbx,rbx
       je        near ptr M01_L49
       mov       rdi,rbx
       mov       rdx,[rsi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L50
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L50
M01_L00:
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M01_L31
M01_L01:
       mov       rcx,2701AF810E8
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L51
M01_L02:
       mov       rdx,[rcx+18]
       test      rdx,rdx
       je        near ptr M01_L32
M01_L03:
       cmp       r14,rdx
       je        near ptr M01_L55
       test      r14,r14
       je        short M01_L04
       test      rdx,rdx
       je        short M01_L04
       mov       ecx,[r14+8]
       cmp       ecx,[rdx+8]
       je        near ptr M01_L52
M01_L04:
       mov       r14,2B0B0470008
M01_L05:
       mov       ecx,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FFDC242C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2701B400048
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2701B400050
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2701B401D00
       mov       r13,[rcx]
       cmp       qword ptr [r13+8],0
       je        near ptr M01_L36
       mov       r12,[r13+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r12],rcx
       jne       near ptr M01_L58
       mov       [rbp-70],rdi
       xor       ecx,ecx
       mov       [rbp-78],rcx
       lea       rcx,[rbp-70]
       cmp       qword ptr [rbp-78],0
       jne       short M01_L06
       mov       rcx,[rbp-70]
       mov       [rbp-78],rcx
       lea       rcx,[rbp-78]
       cmp       qword ptr [rbp-78],0
       je        near ptr M01_L56
M01_L06:
       mov       rax,[rcx]
       mov       [rbp-108],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L57
       mov       rcx,rax
       call      00007FFE2200C390
       test      eax,eax
       je        near ptr M01_L33
M01_L07:
       xor       ecx,ecx
       mov       [rbp-78],rcx
M01_L08:
       mov       [rbp-64],eax
       mov       rcx,[r13+8]
       mov       edx,eax
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L85
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       r13,[r13+10]
       xor       r8d,r8d
       mov       [rbp-68],r8d
       dec       ecx
       cmp       [r13+8],ecx
       jbe       near ptr M01_L36
       mov       rdx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r12],rdx
       jne       near ptr M01_L59
M01_L09:
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       [r12+10],eax
       jne       near ptr M01_L35
       mov       r10,[r12]
       test      r10,r10
       je        near ptr M01_L35
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M01_L34
       cmp       rdi,r10
       sete      r9b
       movzx     r9d,r9b
M01_L10:
       test      r9d,r9d
       je        near ptr M01_L35
M01_L11:
       add       r12,8
       test      r12,r12
       je        near ptr M01_L36
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L47
M01_L12:
       cmp       qword ptr [r15+8],0
       je        near ptr M01_L48
M01_L13:
       mov       rdi,[r15+10]
       mov       r13,[r15+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r13],rcx
       jne       near ptr M01_L67
       lea       rcx,[r14+0C]
       mov       [rbp-88],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rbp-88]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L15
M01_L14:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L14
M01_L15:
       test      eax,eax
       jle       short M01_L16
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L16:
       imul      r12d,edx,5D588B65
       add       r12d,ecx
       xor       ecx,ecx
       mov       [rbp-88],rcx
M01_L17:
       xor       eax,eax
       mov       [rbp-7C],eax
       mov       rdx,[r15+8]
       mov       ecx,r12d
       imul      rcx,[r15+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L85
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-118],r10
       mov       r9d,[r10]
       dec       r9d
       cmp       [rdi+8],r9d
       ja        near ptr M01_L26
M01_L18:
       cmp       dword ptr [r15+40],0
       jg        near ptr M01_L28
       mov       edx,[r15+38]
       mov       [rbp-80],edx
       cmp       [rdi+8],edx
       je        near ptr M01_L69
M01_L19:
       mov       edx,[rbp-80]
       mov       edi,edx
       lea       ecx,[rdi+1]
       mov       [r15+38],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M01_L20:
       cmp       edi,[r8+8]
       jae       near ptr M01_L85
       mov       ecx,edi
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-110],r8
       lea       rcx,[r8+rcx*8+10]
       mov       [rcx+10],r12d
       mov       r10,[rbp-118]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+14],edx
       mov       [rcx],r14
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       r14,[rbp-118]
       mov       [r14],edi
       inc       dword ptr [r15+44]
       cmp       dword ptr [rbp-7C],64
       ja        near ptr M01_L70
M01_L21:
       mov       rcx,27031400258
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M01_L81
M01_L22:
       mov       rdx,r15
       mov       rcx,7FFDC2B58730
       call      qword ptr [7FFDC2B27378]; System.Linq.Enumerable.Where[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rbx,rax
       mov       rcx,27031400260
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L82
M01_L23:
       mov       rcx,27031400268
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M01_L83
M01_L24:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rbx
       mov       r8,rdi
       mov       rcx,7FFDC2D6EED0
       call      qword ptr [7FFDC2D46EF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass16_0.<PropertiesToString>b__3(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,7FFDC2B57FF0
       mov       r8,2B0B0470008
       call      qword ptr [7FFDC2B27348]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2645E90]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M01_L84
       mov       r8,[rsi+8]
       mov       edx,[r8+8]
       mov       r8d,[rbx+8]
       sub       r8d,edx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC259F3F0]; System.String.Substring(Int32, Int32)
M01_L25:
       nop
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       cmp       r9d,[rdi+8]
       jae       near ptr M01_L85
       mov       edx,r9d
       lea       rdx,[rdx+rdx*2]
       lea       r11,[rdi+rdx*8+10]
       mov       [rbp-120],r11
       cmp       [r11+10],r12d
       je        near ptr M01_L68
M01_L27:
       mov       r11,[rbp-120]
       mov       r9d,[r11+14]
       mov       eax,[rbp-7C]
       inc       eax
       mov       [rbp-7C],eax
       cmp       [rdi+8],eax
       jb        short M01_L29
       cmp       [rdi+8],r9d
       ja        short M01_L26
       jmp       near ptr M01_L18
M01_L28:
       mov       ecx,[r15+3C]
       mov       r8d,ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M01_L85
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[rdi+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+3C],ecx
       dec       dword ptr [r15+40]
       mov       rax,rdi
       mov       edi,r8d
       mov       r8,rax
       jmp       near ptr M01_L20
M01_L29:
       call      qword ptr [7FFDC26479A8]
       int       3
M01_L30:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       int       3
M01_L31:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FFDC2594A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L32:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FFDC2594A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       near ptr M01_L03
M01_L33:
       mov       rcx,[rbp-108]
       call      qword ptr [7FFDC242E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L07
M01_L34:
       mov       rcx,r10
       mov       rdx,rdi
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       r9d,eax
       jmp       near ptr M01_L10
M01_L35:
       mov       ecx,[r12+14]
       mov       r8d,[rbp-68]
       inc       r8d
       mov       [rbp-68],r8d
       cmp       [r13+8],r8d
       jb        near ptr M01_L29
       cmp       [r13+8],ecx
       mov       eax,[rbp-64]
       ja        near ptr M01_L09
M01_L36:
       mov       rcx,rdi
       call      qword ptr [7FFDC2D45E90]; DotNetTips.Spargine.Core.TypeHelper.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L30
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0A0]
       mov       rcx,rdi
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFDC242F390]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       mov       r8d,[rbp-90]
       test      r8d,r8d
       je        near ptr M01_L71
       cmp       r8d,1
       je        near ptr M01_L72
       lea       rdx,[rbp-0A0]
       mov       rcx,7FFDC257DC78
       call      qword ptr [7FFDC242D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-90]
       mov       [rbp-8C],ecx
       mov       rdx,[rbp-0A0]
M01_L37:
       mov       rcx,7FFDC2D69B80
       call      qword ptr [7FFDC27B6658]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M01_L73
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       cmp       [rax],rcx
       jne       near ptr M01_L74
       lea       rdi,[rax+10]
       mov       r13d,[rax+8]
M01_L38:
       mov       r12,2B0B0470008
       cmp       dword ptr [r14+8],0
       jle       near ptr M01_L40
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFDC2644E10]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L76
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L75
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       rdx,[rbp-48]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rbp-40]
       sub       ecx,r8d
       mov       r8d,ecx
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFDC2E5ECD0]
       vmovdqu   xmm0,xmmword ptr [rbp-0B0]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       lea       rdx,[rbp-0C0]
       mov       rcx,r14
       call      qword ptr [7FFDC2E5ECE8]
       test      eax,eax
       je        near ptr M01_L76
       mov       eax,[rbp-50]
       add       eax,[r14+8]
       mov       [rbp-50],eax
M01_L39:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFDC2B25170]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFDC2644E40]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
M01_L40:
       mov       r14d,r13d
       xor       eax,eax
M01_L41:
       cmp       eax,r13d
       jge       near ptr M01_L21
       cmp       eax,r14d
       jae       near ptr M01_L85
       mov       [rbp-0C8],rax
       mov       r8,[rdi+rax*8]
       mov       [rbp-0D0],r8
       mov       rdx,r8
       mov       rcx,7FFDC2D69EA0
       call      qword ptr [7FFDC2D45F98]; DotNetTips.Spargine.Core.TypeHelper.GetAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.PropertyInfo)
       test      rax,rax
       jne       near ptr M01_L46
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       rax,[rbp-0D0]
       cmp       [rax],rcx
       jne       near ptr M01_L77
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFDC257E430]; System.Reflection.RuntimePropertyInfo.GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L42:
       mov       [rbp-0F8],rax
       test      rax,rax
       je        near ptr M01_L46
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0D8],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       rax,[rbp-0D0]
       cmp       [rax],rcx
       jne       near ptr M01_L78
       mov       rcx,rax
       call      qword ptr [7FFDC257E360]; System.Reflection.RuntimePropertyInfo.get_Name()
M01_L43:
       mov       r8,[rbp-0D8]
       lea       rcx,[r8+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0D8]
       mov       rcx,2B0B0481930
       call      qword ptr [7FFDC2B275A0]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FFDC2B27450]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,7FFDC2B59BC0
       call      qword ptr [7FFDC2B274E0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r15,rax
       mov       rcx,27031400298
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L79
M01_L44:
       mov       rcx,270314002A0
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M01_L80
M01_L45:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rax
       mov       rcx,7FFDC2D6EED0
       call      qword ptr [7FFDC2D46EF8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r15,rax
M01_L46:
       mov       rcx,[rbp-0C8]
       add       ecx,1
       jo        near ptr M01_L86
       mov       rax,rcx
       jmp       near ptr M01_L41
M01_L47:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rbx,rax
       jmp       near ptr M01_L12
M01_L48:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFDC2425A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L13
M01_L49:
       call      qword ptr [7FFDC29BE400]
       mov       ecx,7C8
       mov       rdx,7FFDC28089B8
       call      qword ptr [7FFDC2647738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2704878
       call      qword ptr [7FFDC2647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2427858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28089B8
       call      qword ptr [7FFDC2647738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2427858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2E5E640]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2E54510]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L50:
       mov       rcx,rax
       call      qword ptr [7FFDC2427C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L51:
       mov       rcx,2B0B047E1B8
       call      qword ptr [7FFDC2427C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L52:
       lea       rcx,[r14+0C]
       add       rdx,0C
       mov       r8d,[r14+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M01_L53
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      al
       movzx     eax,al
       jmp       short M01_L54
M01_L53:
       call      qword ptr [7FFDC242FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L54:
       test      eax,eax
       je        near ptr M01_L04
M01_L55:
       mov       r14,2B0B0474B70
       jmp       near ptr M01_L05
M01_L56:
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L57:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L07
M01_L58:
       mov       rcx,r12
       mov       rdx,rdi
       mov       r11,7FFDC2371338
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L59:
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r13+rcx*8+10]
       mov       r10,rcx
       cmp       [r10+10],eax
       jne       short M01_L61
       mov       [rbp-100],r10
       mov       rcx,[r10]
       mov       r11,rcx
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r12],rcx
       je        short M01_L60
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,r11
       mov       r11,7FFDC2371340
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       short M01_L64
M01_L60:
       test      r11,r11
       jne       short M01_L62
       mov       r10,[rbp-100]
M01_L61:
       mov       ecx,[r10+14]
       mov       r8d,[rbp-68]
       inc       r8d
       cmp       [r13+8],r8d
       jae       short M01_L66
       jmp       near ptr M01_L29
M01_L62:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r11],rcx
       je        short M01_L63
       mov       rcx,r11
       mov       rdx,rdi
       mov       r9,[r11]
       mov       r9,[r9+40]
       call      qword ptr [r9+10]
       mov       r9d,eax
       jmp       short M01_L64
M01_L63:
       cmp       rdi,r11
       sete      r9b
       movzx     r9d,r9b
M01_L64:
       test      r9d,r9d
       jne       short M01_L65
       mov       r10,[rbp-100]
       jmp       short M01_L61
M01_L65:
       mov       r12,[rbp-100]
       jmp       near ptr M01_L11
M01_L66:
       cmp       [r13+8],ecx
       mov       [rbp-68],r8d
       mov       eax,[rbp-64]
       jbe       near ptr M01_L36
       jmp       near ptr M01_L59
M01_L67:
       mov       rcx,r13
       mov       rdx,r14
       mov       r11,7FFDC2371348
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L17
M01_L68:
       cmp       r9d,[rdi+8]
       jae       near ptr M01_L85
       mov       edx,r9d
       lea       rdx,[rdx+rdx*2]
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,r13
       mov       r8,r14
       mov       r11,7FFDC2371350
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L27
       mov       rdx,r14
       mov       rcx,7FFDC2F072C0
       call      qword ptr [7FFDC264C198]
       int       3
M01_L69:
       mov       rcx,r15
       call      qword ptr [7FFDC2E54A80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[r15+8]
       mov       edx,r12d
       imul      rdx,[r15+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L85
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rdi,r10
       mov       [rbp-118],rdi
       jmp       near ptr M01_L19
M01_L70:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L21
       mov       rdi,[rbp-110]
       mov       edx,[rdi+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFDC259F390]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L21
       int       3
       int       3
M01_L71:
       mov       rdx,2701B4010C8
       mov       rdx,[rdx]
       jmp       near ptr M01_L37
M01_L72:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rbp-98]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rdx,rdi
       jmp       near ptr M01_L37
M01_L73:
       xor       edi,edi
       xor       r13d,r13d
       jmp       near ptr M01_L38
M01_L74:
       call      qword ptr [7FFDC2E5C558]
       int       3
M01_L75:
       call      qword ptr [7FFDC2597138]
       int       3
M01_L76:
       lea       rcx,[rbp-60]
       mov       rdx,r14
       call      qword ptr [7FFDC2E57630]
       jmp       near ptr M01_L39
M01_L77:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+58]
       call      qword ptr [r10+38]
       jmp       near ptr M01_L42
M01_L78:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L43
M01_L79:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       rdx,27031400250
       mov       rdx,[rdx]
       mov       rcx,rax
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__18_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27031400298
       mov       rdx,[rbp-0F0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       [rbp-0E0],rax
       mov       rax,[rbp-0E0]
       jmp       near ptr M01_L44
M01_L80:
       mov       [rbp-0E0],rax
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-0E8],r9
       mov       rdx,27031400250
       mov       rdx,[rdx]
       mov       rcx,r9
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__18_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,270314002A0
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0E8]
       mov       rax,[rbp-0E0]
       jmp       near ptr M01_L45
M01_L81:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27031400250
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27031400258
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
       jmp       near ptr M01_L22
M01_L82:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27031400250
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27031400260
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L23
M01_L83:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,27031400250
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToString>b__16_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27031400268
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M01_L24
M01_L84:
       mov       rax,rbx
       jmp       near ptr M01_L25
M01_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L86:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       int       3
       sub       rsp,38
       int       3
; Total bytes of code 3746
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L11
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L11
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L13
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L15
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L14
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L15
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L16
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L16
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L18
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L02:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L19
       mov       rax,7FFE1D7268D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L03:
       test      rsi,rsi
       je        near ptr M00_L21
       mov       rcx,23984002248
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L22
M00_L04:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L05
       mov       rcx,[rbp+0C0]
       mov       rax,27A18FAFFC0
       cmp       rcx,rax
       je        short M00_L08
M00_L05:
       xor       ebp,ebp
       cmp       byte ptr [rdi+9E],0
       je        short M00_L07
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L23
M00_L06:
       cmp       [rcx],cl
       mov       rdx,27A18FAFFC0
       call      qword ptr [7FFDC283CD98]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L24
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        short M00_L07
       cmp       byte ptr [rbp+119],2
       jne       near ptr M00_L25
M00_L07:
       test      rbp,rbp
       je        near ptr M00_L10
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       r8,rbp
       test      r8,r8
       je        short M00_L09
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r8],rcx
       jne       near ptr M00_L26
M00_L09:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,7FFDC2B47F40
       call      qword ptr [7FFDC2B170C0]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L27
       mov       [rsp+38],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFDC2B4D700
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2B17E58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L10:
       mov       rdx,[rdi+20]
       mov       rcx,27A18FAFFC0
       call      qword ptr [7FFDC2C36FB8]
       int       3
M00_L11:
       call      qword ptr [7FFDC28340F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFDC2B177C8]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27A18FB1858
       call      qword ptr [7FFDC2B177E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFDC2B1F528]
       test      eax,eax
       jne       short M00_L15
       jmp       near ptr M00_L00
M00_L14:
       call      qword ptr [7FFDC2B1F528]
       test      eax,eax
       je        near ptr M00_L01
M00_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFDC2B1F540]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L16:
       call      qword ptr [7FFDC28340F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L17
       call      qword ptr [7FFDC2B177C8]
       mov       rbx,rax
M00_L17:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27A18FB1858
       call      qword ptr [7FFDC2B177E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FFDC2B1F528]
       test      eax,eax
       jne       short M00_L20
       jmp       near ptr M00_L02
M00_L19:
       call      qword ptr [7FFDC2B1F528]
       test      eax,eax
       je        near ptr M00_L03
M00_L20:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFDC2B1F540]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,3888
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2B1EFD0]
       int       3
M00_L22:
       mov       rcx,rdi
       call      qword ptr [7FFDC2837048]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L23:
       mov       rcx,rdi
       call      qword ptr [7FFDC283C870]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L06
M00_L24:
       call      qword ptr [7FFDC2C36FA0]
       int       3
M00_L25:
       mov       rcx,rbp
       call      qword ptr [7FFDC29265C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L07
M00_L26:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L27:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFDC2634E10]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M00_L30
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       cmp       eax,29
       jb        short M00_L28
       vmovups   ymm0,[7FFDC2BF19C0]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FFDC2BF19E0]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FFDC2BF1A00]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L29
M00_L28:
       lea       rcx,[rsp+40]
       mov       rdx,27A18FB1D20
       call      qword ptr [7FFDC2B149A8]
M00_L29:
       lea       rcx,[rsp+40]
       mov       rdx,7FFDC2B47D08
       mov       r8,27A18FAFFC0
       call      qword ptr [7FFDC263E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L31
M00_L30:
       call      qword ptr [7FFDC2587138]
       int       3
M00_L31:
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        short M00_L32
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
       jmp       short M00_L33
M00_L32:
       lea       rcx,[rsp+40]
       mov       rdx,27A18FA0658
       call      qword ptr [7FFDC2B149A8]
M00_L33:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDC2634E40]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFDC27A5D88]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1172
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+8]
       mov       rcx,23984001960
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L04
M01_L00:
       mov       rcx,7FFDC2C90034
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L05
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       jne       short M01_L03
       mov       rdx,rbx
       mov       r11,7FFDC2360C00
       call      qword ptr [r11]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFDC27A6418]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L06
M01_L02:
       mov       rax,[rbp-38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       short M01_L01
M01_L04:
       mov       rcx,7FFDC2C90030
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFDC235D050
       call      qword ptr [7FFDC2416EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,23984001960
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,1
       mov       rdx,7FFDC26FECE0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2926340]
       int       3
M01_L06:
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-38]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDC27AC2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 392
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
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0D44F626927A7
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M02_L15
       cmp       edi,15555555
       jg        near ptr M02_L16
       mov       rcx,23984001E00
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,23984000C90
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
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M02_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M02_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L18
M02_L02:
       mov       [rbp+38],r8
M02_L03:
       test      r8,r8
       je        near ptr M02_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M02_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FFDC2837CA8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M02_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M02_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M02_L09
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
       call      qword ptr [7FFDC29A5230]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M02_L10
M02_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M02_L11
       xor       r9d,r9d
M02_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC29A52C0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FFDC2587138]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2C3D200]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FFDC284E7E0
       call      qword ptr [7FFDC2637738]
       mov       rcx,rax
       call      qword ptr [7FFDC2C3D218]
       int       3
M02_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M02_L05
M02_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M02_L06
M02_L12:
       mov       r9d,1
       jmp       near ptr M02_L06
M02_L13:
       call      M02_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,0D44F626927A7
       cmp       [rbp],r8
       je        short M02_L14
       call      CORINFO_HELP_FAIL_FAST
M02_L14:
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
M02_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M02_L04
M02_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FFDC2837108]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0A
       call      qword ptr [7FFDC2B1F7F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFDC2B175A0]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L19:
       mov       eax,[rbp+234]
       jmp       short M02_L21
M02_L20:
       mov       eax,[rbp+234]
M02_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M02_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FFDC2B17DE0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M02_L25
M02_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M02_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FFDC292D6B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M02_L23:
       mov       rcx,rdx
       call      qword ptr [7FFDC2416820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M02_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M02_L24
       xor       r14d,r14d
M02_L24:
       mov       eax,[rbp+220]
       inc       eax
M02_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M02_L22
       jmp       short M02_L27
M02_L26:
       mov       r13,rcx
       jmp       short M02_L28
M02_L27:
       xor       r13d,r13d
M02_L28:
       test      r13,r13
       je        short M02_L30
       cmp       byte ptr [r12+9D],0
       je        short M02_L29
       mov       rcx,r13
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFDC2B175A0]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L29:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M02_L33
M02_L31:
       test      r13d,r13d
       jne       short M02_L32
       mov       r8,27A18FA62A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,27A18FA6F28
       call      qword ptr [7FFDC263D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L33:
       cmp       r13d,800
       jge       short M02_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M02_L35
M02_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FFDC2A47588]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFDC2B175A0]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDC2B175E8]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L37:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M02_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FFDC24157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,23984001E00
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
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0A
       call      qword ptr [7FFDC2B1F7F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FFDC2A4F4C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M02_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M02_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M02_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC2B17990]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFDC2354000
       call      qword ptr [7FFDC2637738]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFDC27A5E30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L43:
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
       je        near ptr M02_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFDC2C3DC20]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFDC2B17DE0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M02_L51
M02_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M02_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FFDC292D6B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L47
       test      r8d,r8d
       jne       short M02_L48
       xor       edx,edx
       mov       [rax+14],edx
M02_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M02_L47:
       mov       rcx,rax
       call      qword ptr [7FFDC2416820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M02_L49
       jmp       short M02_L52
M02_L48:
       jmp       short M02_L46
M02_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M02_L50
       xor       r15d,r15d
M02_L50:
       inc       r12d
M02_L51:
       cmp       [r14+8],r12d
       jg        near ptr M02_L45
       jmp       short M02_L53
M02_L52:
       mov       r14d,1
       jmp       short M02_L54
M02_L53:
       xor       r14d,r14d
M02_L54:
       mov       rcx,23984000C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFDC2C37ED0]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M02_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L57
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L56:
       mov       ecx,esi
       xor       edx,edx
M02_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FFDC2B17A08]
M02_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
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
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FFE390184E0]
       cmp       byte ptr [rax],0
       je        near ptr M04_L03
       call      qword ptr [7FFE3901EBF0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
M04_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FFE3901A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L00
       call      qword ptr [7FFE390184D8]
       cmp       byte ptr [rax],0
       je        short M04_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFE390202F8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE3901EC20]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFE39018278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L00
       cmp       [rsi+10],rbx
       je        short M04_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M04_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3901E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M04_L00
M04_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L00
M04_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L04
       call      qword ptr [7FFE3901A6A0]
       test      rax,rax
       je        near ptr M04_L00
M04_L04:
       call      qword ptr [7FFE3901CE60]
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
       call      qword ptr [7FFE3901E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE3901C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       je        near ptr M06_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M06_L08
M06_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M06_L02
       mov       rcx,rsi
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFDC2B1FD98]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FFDC2C9A1B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFDC29265E0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FFDC2B1EFD0]
       int       3
M06_L03:
       mov       rcx,7FFDC2C9A1B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2C36FA0]
       int       3
M06_L04:
       mov       rcx,7FFDC2C9A1BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FFDC2C9A1C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFDC2C9A1C4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FFDC2C3C8E8]
       int       3
M06_L07:
       mov       rcx,7FFDC2C9A1B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDC2C36FA0]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FFDC283C8A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FFDC2B1F480]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFE22014230
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFDC2B1F948]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FFDC2C3C900]
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
       je        short M06_L12
       mov       rcx,7FFDC2C9A1BC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FFDC2B1EFD0]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFDC2B1F948]
M06_L12:
       mov       rcx,7FFDC2C9A1C0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       jmp       qword ptr [7FFDC241FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,23984000C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FFDC2C8C878
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbx+8],rax
       test      rax,rax
       je        short M08_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M08_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M08_L00
; Total bytes of code 127
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M09_L05
       test      rsi,rsi
       je        near ptr M09_L06
       mov       rcx,rsi
       call      qword ptr [7FFE1E3A51F0]
       test      rax,rax
       jne       short M09_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M09_L00:
       test      rdx,rdx
       je        near ptr M09_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M09_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M09_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFE1E3AB980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M09_L06
M09_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3A5228]
       test      rax,rax
       je        near ptr M09_L04
       mov       rcx,rsi
       call      qword ptr [7FFE1E3A6468]
       mov       rsi,rax
M09_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M09_L07
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M09_L03
       mov       rcx,rbx
       call      qword ptr [7FFE1E3B3078]
       jmp       short M09_L02
M09_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M09_L06
M09_L04:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3A6460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M09_L00
M09_L05:
       call      qword ptr [7FFE1E39E130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE1E3C2780]
M09_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L07:
       call      qword ptr [7FFE1E3AD310]
       int       3
M09_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE1E3B3050]
       jmp       short M09_L06
; Total bytes of code 397
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M10_L13
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rbp,rbp
       je        near ptr M10_L03
       mov       rcx,23984000C88
       mov       rbx,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M10_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M10_L14
M10_L00:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M10_L15
M10_L01:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       short M10_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,esi
       cmp       [rbp+8],ecx
       jne       near ptr M10_L16
       mov       ecx,esi
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       short M10_L04
M10_L02:
       mov       rcx,23984000C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L23
M10_L03:
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M10_L26
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M10_L17
M10_L05:
       mov       r15,[rax+8]
       call      qword ptr [7FFDC2B17DE0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       mov       eax,[r15+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M10_L22
       mov       [rsp+40],eax
M10_L06:
       cmp       r13d,eax
       jae       near ptr M10_L26
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rsp+38],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+60],r10d
       mov       rcx,r8
       call      00007FFE21FE0070
       test      eax,eax
       je        near ptr M10_L18
M10_L07:
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+5C],r8d
       cmp       [rcx+8],r8d
       jbe       short M10_L09
       test      r8d,r8d
       je        short M10_L12
M10_L08:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+5C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+60],1
M10_L09:
       mov       rcx,rax
       call      00007FFE2200BB70
       test      eax,eax
       jne       near ptr M10_L19
M10_L10:
       cmp       dword ptr [rsp+60],0
       je        near ptr M10_L20
       mov       r15d,1
M10_L11:
       jmp       near ptr M10_L02
M10_L12:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M10_L08
M10_L13:
       call      qword ptr [7FFDC2587138]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FFDC2B1F7F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FFDC263CE28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFDC2B17990]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFDC2354000
       call      qword ptr [7FFDC2637738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFDC27A5E30]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFDC2C37EB8]
       jmp       near ptr M10_L05
M10_L18:
       mov       rcx,[rsp+38]
       call      qword ptr [7FFDC2B1FD98]
       jmp       near ptr M10_L07
M10_L19:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FFDC2B1F948]
       jmp       near ptr M10_L10
M10_L20:
       inc       r13d
       mov       ecx,[rsp+44]
       cmp       ecx,r13d
       jne       short M10_L21
       xor       r13d,r13d
M10_L21:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,ecx
       jne       near ptr M10_L06
M10_L22:
       xor       r15d,r15d
       jmp       near ptr M10_L11
M10_L23:
       cmp       dword ptr [rbp+8],0
       je        near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FFDC2C37ED0]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rbx
       call      qword ptr [7FFDC283C9F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L24
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L25
M10_L24:
       mov       ecx,esi
       xor       edx,edx
M10_L25:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,ebp
       call      qword ptr [7FFDC2B17A08]
       jmp       near ptr M10_L03
M10_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.InitializeFields()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rax,0DE34A9C160A1
       mov       [rbp-40],rax
       mov       [rbp-100],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataSet
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFDC2B07120]; System.Data.DataSet..ctor()
       mov       rcx,1746F000258
       mov       rcx,[rcx]
       mov       r14,rcx
       mov       r15d,[rdi+94]
       cmp       byte ptr [rcx+9D],0
       je        short M00_L01
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       [rbp-60],rax
       mov       r8,1B4EE141858
       mov       [rbp-58],r8
       lea       r8,[rbp-60]
       mov       [rbp-0B0],r8
       mov       dword ptr [rbp-0A8],2
       lea       r8,[rbp-0B0]
       xor       ecx,ecx
       mov       rdx,1B4EE1419F0
       call      qword ptr [7FFDC2C5C108]
       cmp       byte ptr [r14+9D],0
       jne       near ptr M00_L65
M00_L00:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M00_L01:
       mov       rcx,[rdi+38]
       mov       rax,1B4EE141858
       cmp       rcx,rax
       je        near ptr M00_L10
       test      rcx,rcx
       je        short M00_L02
       cmp       dword ptr [rcx+8],4
       jne       short M00_L02
       mov       rax,54005300450054
       cmp       [rcx+0C],rax
       je        near ptr M00_L10
M00_L02:
       mov       r14,[rdi+20]
       mov       r15,[rdi+48]
       cmp       [r14],r14b
       test      r15,r15
       je        near ptr M00_L66
       mov       r13d,0FFFFFFFF
       mov       rcx,[r14+10]
       mov       rax,offset MT_System.Collections.ArrayList
       cmp       [rcx],rax
       jne       near ptr M00_L67
       mov       r12d,[rcx+10]
M00_L03:
       xor       eax,eax
       cmp       eax,r12d
       jl        near ptr M00_L68
M00_L04:
       mov       edx,r13d
M00_L05:
       cmp       edx,0FFFFFFFE
       je        near ptr M00_L73
       test      edx,edx
       jge       short M00_L06
       xor       r15d,r15d
       jmp       short M00_L07
M00_L06:
       mov       rcx,[r14+10]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r15,rax
       test      r15,r15
       je        short M00_L07
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [r15],rcx
       je        short M00_L07
       mov       rdx,rax
       call      qword ptr [7FFDC240FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r15,rax
M00_L07:
       test      r15,r15
       je        short M00_L08
       cmp       byte ptr [r15+1C4],0
       je        near ptr M00_L74
M00_L08:
       mov       rcx,offset MT_System.ComponentModel.PropertyChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,1B4EE1419C0
       mov       [rax+8],rdx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L75
M00_L09:
       mov       rcx,1B4EE141858
       mov       [rdi+38],rcx
M00_L10:
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0B8],rsi
       mov       [rbp-0C8],rsi
       mov       rcx,rsi
       call      qword ptr [7FFDC240C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       mov       rsi,[rbp-0C8]
       je        short M00_L11
       mov       rcx,[rax+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       near ptr M00_L35
M00_L11:
       mov       rcx,rax
       call      qword ptr [7FFDC2407C48]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M00_L12:
       cmp       [r14],r14b
       lea       rdi,[r14+50]
       mov       rcx,[rdi]
       test      rcx,rcx
       je        near ptr M00_L39
M00_L13:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L40
       mov       rdi,[rcx+8]
M00_L14:
       mov       r14d,[rdi+8]
       mov       edx,r14d
       xor       ecx,ecx
       mov       [rbp-90],rcx
       mov       [rbp-88],rcx
       mov       [rbp-80],ecx
       mov       [rbp-7C],edx
       test      r14d,r14d
       jle       short M00_L18
       add       rdi,10
M00_L15:
       mov       r15,[rdi]
       mov       edx,[r15+18]
       mov       ecx,edx
       and       ecx,36
       cmp       ecx,edx
       jne       short M00_L17
       cmp       dword ptr [rbp-80],0
       jne       near ptr M00_L36
       mov       [rbp-88],r15
M00_L16:
       mov       edx,[rbp-80]
       inc       edx
       mov       [rbp-80],edx
M00_L17:
       add       rdi,8
       dec       r14d
       jne       short M00_L15
M00_L18:
       mov       rdi,[rbp-90]
       mov       r14,[rbp-88]
       mov       r15d,[rbp-80]
       test      r15d,r15d
       je        near ptr M00_L43
       cmp       r15d,1
       je        near ptr M00_L44
       test      r15d,r15d
       jl        near ptr M00_L45
       test      rdi,rdi
       je        near ptr M00_L46
       cmp       [rdi+8],r15d
       jne       near ptr M00_L47
M00_L19:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.FieldInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L48
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rcx,rdi
       mov       r11,7FFDC2350CF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L49
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,rdi
       mov       rdx,r14
       mov       r11,7FFDC2350D00
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L20:
       test      r14,r14
       je        near ptr M00_L51
       mov       rax,offset MT_System.Reflection.FieldInfo[]
       cmp       [r14],rax
       jne       near ptr M00_L52
       lea       rdi,[r14+10]
       mov       r14d,[r14+8]
M00_L21:
       mov       [rbp-0F8],rdi
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M00_L34
M00_L22:
       cmp       r15d,r14d
       jae       near ptr M00_L62
       mov       r13,[rdi+r15*8]
       mov       [rbp-0D0],r13
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r13],rcx
       jne       near ptr M00_L59
       mov       r12,r13
       cmp       qword ptr [r12+30],0
       jne       near ptr M00_L31
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-0D8]
       mov       rcx,[r12+8]
       mov       rax,[rcx+10]
       cmp       [rax],al
       mov       rcx,rax
M00_L23:
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L56
       mov       [rbp-0E0],rcx
       mov       rax,[rcx+18]
       mov       rcx,rax
       mov       rax,7FFE220151A0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0E0]
       cmp       dword ptr [7FFE2236F778],0
       jne       near ptr M00_L54
M00_L24:
       cmp       ebx,1D
       ja        short M00_L25
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L55
M00_L25:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L26:
       test      edi,edi
       jne       near ptr M00_L53
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L57
M00_L27:
       test      rsi,rsi
       je        near ptr M00_L61
       mov       rcx,rsi
       call      00007FFE2201A990
       test      eax,eax
       jne       short M00_L29
       mov       r12,[rbp-0D8]
       mov       rcx,[r12+8]
       mov       rcx,[rcx+10]
       mov       rdx,[rcx+18]
       test      dl,2
       jne       near ptr M00_L58
       mov       edx,[rdx]
       and       edx,0F0000
       cmp       edx,50000
       sete      dl
       movzx     edx,dl
M00_L28:
       test      edx,edx
       jne       short M00_L29
       mov       dword ptr [r12+20],0F
       jmp       short M00_L30
M00_L29:
       mov       r12,[rbp-0D8]
       mov       dword ptr [r12+20],11
M00_L30:
       mov       r13,[rbp-0D0]
       lea       rcx,[r13+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C8]
M00_L31:
       mov       r13,[rbp-0D0]
       mov       rcx,[r13+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2797918]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L32:
       test      rax,rax
       je        near ptr M00_L60
M00_L33:
       inc       r15d
       cmp       r15d,r14d
       mov       rdi,[rbp-0F8]
       jl        near ptr M00_L22
M00_L34:
       mov       rcx,[rbp-0B8]
       mov       [rbp-98],rcx
       mov       rbx,[rbp-100]
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-98]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M00_L63
M00_L35:
       mov       r14,rdi
       jmp       near ptr M00_L12
M00_L36:
       cmp       dword ptr [rbp-80],1
       jne       near ptr M00_L42
       cmp       dword ptr [rbp-7C],2
       jl        near ptr M00_L41
M00_L37:
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L38:
       movsxd    rdx,dword ptr [rbp-80]
       mov       rcx,[rbp-90]
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L16
M00_L39:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFE22014230
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r15
       jmp       near ptr M00_L13
M00_L40:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFDC240D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M00_L14
M00_L41:
       mov       dword ptr [rbp-7C],4
       jmp       near ptr M00_L37
M00_L42:
       mov       edx,[rbp-7C]
       cmp       edx,[rbp-80]
       jne       short M00_L38
       mov       r13d,[rbp-7C]
       add       r13d,r13d
       lea       rdx,[rbp-90]
       mov       r8d,r13d
       mov       rcx,7FFDC256C9C8
       call      qword ptr [7FFDC240D4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-7C],r13d
       jmp       near ptr M00_L38
M00_L43:
       mov       rdx,17459001BE0
       mov       rdi,[rdx]
       jmp       near ptr M00_L19
M00_L44:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L19
M00_L45:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFDC29959E0]
       int       3
M00_L46:
       mov       edx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       jmp       near ptr M00_L19
M00_L47:
       mov       edx,r15d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       r15d,r8d
       cmovg     r15d,r8d
       mov       r8d,r15d
       shl       r8,3
       call      qword ptr [7FFDC24057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,r14
       jmp       near ptr M00_L19
M00_L48:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L49:
       mov       rcx,17459001BE0
       mov       r14,[rcx]
       jmp       near ptr M00_L20
M00_L50:
       mov       rcx,7FFDC2CCF740
       xor       edx,edx
       call      qword ptr [7FFDC2B0EE80]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L51:
       xor       edi,edi
       xor       r14d,r14d
       jmp       near ptr M00_L21
M00_L52:
       call      qword ptr [7FFDC2C5C1C8]
       int       3
M00_L53:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       mov       rcx,rsi
       mov       rsi,[rbp-0C8]
       jmp       near ptr M00_L23
M00_L54:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L55:
       mov       edi,1
       jmp       near ptr M00_L26
M00_L56:
       mov       [rbp-0E0],rcx
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       mov       rsi,[rbp-0E0]
       jmp       near ptr M00_L26
M00_L57:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L27
M00_L58:
       xor       edx,edx
       jmp       near ptr M00_L28
M00_L59:
       mov       rcx,r13
       mov       rdx,rsi
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L32
M00_L60:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M00_L33
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FFDC2915488]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       r12,rax
       call      qword ptr [7FFDC29152A8]; System.Type.get_DefaultBinder()
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+20],rax
       mov       rdx,rsi
       mov       r8,r12
       mov       rcx,r13
       xor       r9d,r9d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       jmp       near ptr M00_L33
M00_L61:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC2B0F390]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDC2B0F3A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      M00_L79
       nop
       mov       r8,0DE34A9C160A1
       cmp       [rbp-40],r8
       je        short M00_L64
       call      CORINFO_HELP_FAIL_FAST
M00_L64:
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
M00_L65:
       mov       rcx,1B4EE130008
       test      rax,rax
       cmove     rax,rcx
       lea       rcx,[rax+0C]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rbp-50],rcx
       mov       ecx,[rax+8]
       lea       ecx,[rcx*2+2]
       mov       [rbp-48],ecx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       lea       rcx,[rbp-50]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       edx,1
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFDC2C5C120]
       xor       ecx,ecx
       mov       [rbp-68],rcx
       jmp       near ptr M00_L00
M00_L66:
       mov       ecx,0C190
       mov       rdx,7FFDC2B37708
       call      qword ptr [7FFDC2627738]
       mov       rcx,rax
       call      qword ptr [7FFDC2C5C150]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r12d,eax
       jmp       near ptr M00_L03
M00_L68:
       mov       rcx,[r14+10]
       mov       [rbp-70],eax
       mov       edx,eax
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rbp-0C0],rax
       mov       r9,[r14+8]
       mov       r9,[r9+50]
       mov       rcx,[rax+70]
       mov       rdx,1B4EE141858
       xor       r8d,r8d
       call      qword ptr [7FFDC2C5CE10]
       mov       [rbp-74],eax
       cmp       eax,1
       jne       short M00_L69
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFDC2C5CE28]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFDC240C840]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L72
M00_L69:
       cmp       dword ptr [rbp-74],0FFFFFFFF
       jne       short M00_L71
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFDC2C5CE28]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFDC240C840]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M00_L71
       cmp       r13d,0FFFFFFFF
       je        short M00_L70
       mov       r13d,0FFFFFFFE
       jmp       short M00_L71
M00_L70:
       mov       r13d,[rbp-70]
       mov       ecx,r13d
       mov       [rbp-70],r13d
       mov       r13d,ecx
M00_L71:
       mov       ecx,[rbp-70]
       inc       ecx
       cmp       ecx,r12d
       mov       eax,ecx
       jl        near ptr M00_L68
       jmp       near ptr M00_L04
M00_L72:
       mov       ecx,[rbp-70]
       mov       edx,ecx
       jmp       near ptr M00_L05
M00_L73:
       mov       ecx,103
       mov       rdx,7FFDC26E2E40
       call      qword ptr [7FFDC2627738]
       mov       rcx,rax
       call      qword ptr [7FFDC2C5C168]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L74:
       mov       ecx,103
       mov       rdx,7FFDC26E2E40
       call      qword ptr [7FFDC2627738]
       mov       rcx,rax
       call      qword ptr [7FFDC2C5C180]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L75:
       mov       rdx,rdi
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       jmp       near ptr M00_L09
M00_L76:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-9C],0
       je        short M00_L78
       cmp       qword ptr [rbp-0E8],0
       jne       short M00_L77
       xor       ecx,ecx
       call      qword ptr [7FFDC2B0E760]
       int       3
M00_L77:
       mov       rcx,[rbp-0E8]
       call      00007FFE2200BB70
       test      eax,eax
       je        short M00_L78
       mov       ecx,eax
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FFDC2B0ED30]
M00_L78:
       nop
       add       rsp,38
       ret
M00_L79:
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0B8]
       cmp       byte ptr [rcx+10],0
       jne       near ptr M00_L91
       mov       rbx,[rcx+8]
       mov       [rbp-0E8],rbx
       mov       rax,offset MT_System.Data.DataSet
       mov       rbx,[rbp-0E8]
       cmp       [rbx],rax
       jne       near ptr M00_L87
       mov       [rbp-0F0],rbx
       xor       eax,eax
       mov       [rbp-9C],eax
       mov       rcx,[rbp-0F0]
       call      00007FFE21FE0070
       test      eax,eax
       jne       short M00_L80
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFDC2B0F558]
M00_L80:
       mov       dword ptr [rbp-9C],1
       mov       rcx,[rbp-0F0]
       mov       r11,[rcx+8]
       test      r11,r11
       je        short M00_L81
       mov       rcx,r11
       mov       r11,7FFDC2350D08
       call      qword ptr [r11]
       test      rax,rax
       je        short M00_L81
       mov       rcx,rax
       mov       rdx,[rbp-0F0]
       mov       r11,7FFDC2350D10
       call      qword ptr [r11]
M00_L81:
       mov       rcx,[rbp-0F0]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       jne       short M00_L82
       xor       edx,edx
       jmp       short M00_L83
M00_L82:
       mov       rcx,offset MT_System.ComponentModel.MarshalByValueComponent
       call      qword ptr [7FFDC2405728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1746F000388
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      qword ptr [7FFDC2C5CE40]
       mov       rdx,rax
M00_L83:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M00_L84
       mov       rax,offset MT_System.EventHandler
       cmp       [rsi],rax
       je        short M00_L84
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L84:
       test      rsi,rsi
       je        short M00_L85
       mov       rcx,offset MT_System.EventArgs
       call      qword ptr [7FFDC2405728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1746F000380
       mov       r8,[r8]
       mov       rdx,[rbp-0F0]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       nop
M00_L85:
       call      M00_L76
       nop
M00_L86:
       cmp       qword ptr [rbp-0E8],0
       jne       short M00_L88
       jmp       short M00_L90
M00_L87:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       short M00_L86
M00_L88:
       mov       rbx,[rbp-0E8]
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M00_L89
       mov       rcx,rbx
       call      00007FFE220202E0
M00_L89:
       mov       rcx,[rbp-0B8]
       mov       byte ptr [rcx+10],1
       jmp       short M00_L91
M00_L90:
       mov       ecx,707
       mov       rdx,7FFDC2344000
       call      qword ptr [7FFDC2627738]
       mov       rcx,rax
       call      qword ptr [7FFDC2B0E760]
       int       3
M00_L91:
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L92
       call      00007FFE220202E0
M00_L92:
       nop
       add       rsp,38
       ret
; Total bytes of code 3251
```
```assembly
; System.Data.DataSet..ctor()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       mov       rax,0DE34A9C160A1
       mov       [rsp+90],rax
       mov       rbx,rcx
       mov       rcx,1B4EE141878
       mov       [rbx+38],rcx
       mov       rsi,1B4EE130008
       mov       [rbx+40],rsi
       mov       [rbx+48],rsi
       mov       byte ptr [rbx+98],1
       mov       byte ptr [rbx+9F],1
       mov       [rbx+58],rsi
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC234B168
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M01_L00
       mov       rcx,rbx
       call      00007FFE220202E0
M01_L00:
       mov       rcx,1746F000258
       mov       rdi,[rcx]
       mov       rbp,rdi
       mov       r14d,[rbx+94]
       cmp       byte ptr [rdi+9D],0
       je        short M01_L02
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r14d
       mov       [rsp+88],rax
       lea       r8,[rsp+88]
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],1
       lea       r8,[rsp+50]
       xor       ecx,ecx
       mov       rdx,1B4EE1418A8
       call      qword ptr [7FFDC2C5C108]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L08
M01_L01:
       xor       ecx,ecx
       mov       [rsp+80],rcx
M01_L02:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,17459001A90
       mov       r15,[rcx]
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbp+30],1
       mov       rcx,7FFDC234B178
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbp+34],eax
       mov       r14,rdi
       mov       r13d,[rbp+34]
       mov       r12d,[rbx+94]
       cmp       byte ptr [rdi+9D],0
       je        short M01_L04
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],r13d
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r12d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       [rsp+68],rdi
       mov       [rsp+70],rax
       lea       r8,[rsp+68]
       mov       [rsp+50],r8
       mov       dword ptr [rsp+58],2
       lea       r8,[rsp+50]
       xor       ecx,ecx
       mov       rdx,1B4EE141920
       call      qword ptr [7FFDC2C5C108]
       cmp       byte ptr [r14+9D],0
       jne       near ptr M01_L09
M01_L03:
       xor       ecx,ecx
       mov       [rsp+60],rcx
M01_L04:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],1
       mov       rcx,7FFDC234B180
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       mov       [rsi+24],edx
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L10
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L10
M01_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M01_L06
       mov       rdx,17459000110
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M01_L06
       mov       rdx,174590000F0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L11
M01_L06:
       lea       rcx,[rbx+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,0DE34A9C160A1
       cmp       [rsp+90],r8
       je        short M01_L07
       call      CORINFO_HELP_FAIL_FAST
M01_L07:
       nop
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       test      rax,rax
       cmove     rax,rsi
       lea       rcx,[rax+0C]
       mov       [rsp+80],rcx
       mov       rcx,[rsp+80]
       mov       [rsp+40],rcx
       mov       ecx,[rax+8]
       lea       ecx,[rcx*2+2]
       mov       [rsp+48],ecx
       xor       ecx,ecx
       mov       [rsp+4C],ecx
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,rbp
       mov       edx,1
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFDC2C5C120]
       xor       ecx,ecx
       mov       [rsp+80],rcx
       jmp       near ptr M01_L01
M01_L09:
       test      rax,rax
       cmove     rax,rsi
       lea       rcx,[rax+0C]
       mov       [rsp+60],rcx
       mov       rcx,[rsp+60]
       mov       [rsp+30],rcx
       mov       ecx,[rax+8]
       lea       ecx,[rcx*2+2]
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+3C],ecx
       lea       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       edx,1
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFDC2C5C120]
       xor       ecx,ecx
       mov       [rsp+60],rcx
       jmp       near ptr M01_L03
M01_L10:
       mov       ecx,2
       call      qword ptr [7FFDC2B0EFB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L05
M01_L11:
       call      qword ptr [7FFDC2625DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       jmp       near ptr M01_L06
; Total bytes of code 1065
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rbx]
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M02_L01
M02_L00:
       mov       rcx,7FFDC2BAB8E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M02_L02
       mov       rcx,7FFDC2BAB8E0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L00
M02_L02:
       test      rdi,rdi
       je        near ptr M02_L07
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M02_L06
       test      rdi,rdi
       je        short M02_L05
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M02_L04
       test      rdi,rdi
       je        short M02_L03
       mov       rcx,7FFDC2BAB8CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M02_L00
       jmp       short M02_L01
M02_L03:
       mov       rcx,7FFDC2BAB8C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L08
M02_L04:
       mov       rcx,7FFDC2BAB8D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,7FFDC2BAB8D4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L08
M02_L06:
       mov       rcx,7FFDC2BAB8D8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L00
M02_L07:
       mov       rcx,7FFDC2BAB8DC
       call      CORINFO_HELP_COUNTPROFILE32
M02_L08:
       mov       rcx,7FFDC2BAB8E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDC2B0F3F0]
; Total bytes of code 272
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
       call      qword ptr [7FFDC2405C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FFE22017010
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
       mov       rax,7FFDC2541B50
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE21FF8A70
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M04_L04
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE220265E0
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
       call      qword ptr [7FFDC2C5CE88]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFDC2C54510]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFDC2407C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M06_L00:
       mov       ecx,[rbx+20]
       cmp       ecx,11
       ja        near ptr M06_L14
       lea       rax,[7FFDC2BE4530]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M06_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,[rbx+8]
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+18]
       mov       rbp,rsi
       test      rbp,rbp
       je        short M06_L01
       mov       rdx,[rbp]
       cmp       rdx,rcx
       jne       near ptr M06_L06
M06_L01:
       mov       rax,rbp
M06_L02:
       test      rax,rax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M06_L24
       mov       rdi,[rbx+18]
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       lea       rsi,[rsi+rcx+8]
       mov       ecx,[rdi]
       and       ecx,0F0000
       cmp       ecx,50000
       je        near ptr M06_L27
       cmp       [rsi],sil
       mov       rcx,rdi
       call      00007FFE22026110
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M06_L25
M06_L03:
       test      dword ptr [rdi],1000000
       jne       near ptr M06_L26
       cmp       [rbx],bl
       lea       rbp,[rbx+8]
       mov       rcx,rdi
       call      00007FFE220355F0
       mov       r8d,eax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFDC2405818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L04:
       mov       rax,rbx
M06_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       rax,17459000038
       mov       rax,[rax]
       add       rax,10
       rorx      r8,rdx,20
       xor       r8,rcx
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rax]
       shrx      r8,r8,r10
       xor       r10d,r10d
M06_L07:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r14,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r14,rdx
       jne       near ptr M06_L20
       mov       r14,rcx
       xor       r14,[r9+10]
       cmp       r14,1
       ja        near ptr M06_L20
       cmp       r11d,[r9]
       jne       near ptr M06_L21
M06_L08:
       cmp       r14d,1
       je        near ptr M06_L01
       jmp       near ptr M06_L22
       mov       rcx,[rbx+8]
       mov       rdi,[rcx+10]
       mov       rcx,[rdi+18]
       mov       rbp,rsi
       test      rbp,rbp
       je        short M06_L09
       mov       rdx,[rbp]
       cmp       rdx,rcx
       jne       short M06_L11
M06_L09:
       mov       rax,rbp
M06_L10:
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M06_L19
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       near ptr M06_L05
M06_L11:
       mov       rax,17459000038
       mov       rax,[rax]
       add       rax,10
       rorx      r8,rdx,20
       xor       r8,rcx
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rax]
       shrx      r8,r8,r10
       xor       r10d,r10d
M06_L12:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rax+r9*8]
       mov       r11d,[r9]
       mov       r14,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       r14,rdx
       jne       short M06_L15
       mov       r14,rcx
       xor       r14,[r9+10]
       cmp       r14,1
       ja        short M06_L15
       cmp       r11d,[r9]
       jne       short M06_L16
M06_L13:
       cmp       r14d,1
       je        near ptr M06_L09
       jmp       short M06_L17
M06_L14:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L15:
       test      r11d,r11d
       je        short M06_L16
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        short M06_L12
M06_L16:
       mov       r14d,2
       jmp       short M06_L13
M06_L17:
       test      r14d,r14d
       jne       short M06_L18
       xor       ebp,ebp
       jmp       near ptr M06_L09
M06_L18:
       mov       rdx,rsi
       call      qword ptr [7FFDC240D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M06_L10
M06_L19:
       test      rsi,rsi
       jne       near ptr M06_L36
       jmp       near ptr M06_L35
M06_L20:
       test      r11d,r11d
       je        short M06_L21
       inc       r10d
       add       r8d,r10d
       and       r8d,[rax+4]
       cmp       r10d,8
       jl        near ptr M06_L07
M06_L21:
       mov       r14d,2
       jmp       near ptr M06_L08
M06_L22:
       test      r14d,r14d
       jne       short M06_L23
       xor       ebp,ebp
       jmp       near ptr M06_L01
M06_L23:
       mov       rdx,rsi
       call      qword ptr [7FFDC240D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
       jmp       near ptr M06_L02
M06_L24:
       test      rsi,rsi
       jne       near ptr M06_L36
       jmp       near ptr M06_L35
M06_L25:
       mov       rcx,rdi
       call      qword ptr [7FFDC2B0D1B8]; System.RuntimeTypeHandle.<InternalAllocNoChecks>g__InternalAllocNoChecksWorker|37_0(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,rax
       jmp       near ptr M06_L03
M06_L26:
       cmp       [rbx],bl
       lea       rcx,[rbx+8]
       mov       r8d,[rdi+4]
       add       r8d,0FFFFFFF0
       mov       rdx,rsi
       call      qword ptr [7FFDC24057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L04
M06_L27:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFDC2405878]; System.Runtime.CompilerServices.CastHelpers.Box_Nullable(System.Runtime.CompilerServices.MethodTable*, Byte ByRef)
       mov       rbx,rax
       jmp       near ptr M06_L04
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC234A578]; System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M06_L28
       test      rsi,rsi
       jne       near ptr M06_L36
       jmp       near ptr M06_L35
M06_L28:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M06_L29
       call      qword ptr [7FFDC27978A0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M06_L29:
       mov       rcx,rsi
       call      qword ptr [7FFDC2C57CC0]
       jmp       near ptr M06_L05
       mov       rax,[rbx+10]
       mov       rax,[rax]
       jmp       near ptr M06_L05
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFDC2C57CD8]
       jmp       near ptr M06_L05
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFDC2C57CD8]
       jmp       near ptr M06_L05
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M06_L30
       call      qword ptr [7FFDC27978A0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M06_L30:
       mov       rcx,rsi
       call      qword ptr [7FFDC2C57CC0]
       jmp       near ptr M06_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2797930]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M06_L31
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC234A578]; System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M06_L31
       test      rsi,rsi
       jne       near ptr M06_L36
       jmp       near ptr M06_L35
M06_L31:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbx+8]
       mov       rdi,rcx
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M06_L32
       call      qword ptr [7FFDC27978A0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M06_L32:
       mov       r8,rdx
       test      r8,r8
       je        short M06_L33
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       je        short M06_L33
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L33:
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFDC2797948]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M06_L34
       mov       rcx,rbx
       call      qword ptr [7FFDC2797960]; System.Reflection.FieldAccessor.Initialize()
M06_L34:
       mov       rax,rsi
       jmp       near ptr M06_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2797930]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M06_L37
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFDC234A578]; System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M06_L37
       test      rsi,rsi
       jne       short M06_L36
M06_L35:
       call      qword ptr [7FFDC2C57CF0]
       int       3
M06_L36:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFDC2C57D08]
       int       3
M06_L37:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M06_L38
       call      qword ptr [7FFDC27978A0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M06_L38:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFDC2797948]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M06_L05
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC256BD30]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M06_L39
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC256BD30]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M06_L39
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDC2C57D20]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2795D88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L39:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDC256BD30]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M06_L41
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M06_L40
       call      qword ptr [7FFDC27978A0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M06_L40:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2575398]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M06_L41
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC2C56178]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L41:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFDC2C57D38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1482
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       je        short M07_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M07_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFDC240D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M07_L00:
       call      qword ptr [7FFDC2B0D260]
       int       3
M07_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFE22059DD0
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,0DE34A9C160A1
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M08_L00
       cmp       dword ptr [rbx+8],0
       jne       short M08_L03
M08_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1B4EE130008
       call      qword ptr [7FFDC240D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M08_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFDC240D578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0DE34A9C160A1
       cmp       [rbp],r8
       je        short M08_L02
       call      CORINFO_HELP_FAIL_FAST
M08_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M08_L03:
       cmp       r14d,1
       jne       short M08_L04
       cmp       word ptr [rbx+0C],2E
       je        short M08_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M08_L00
M08_L04:
       mov       rcx,17459000220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFDC255F178]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M08_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M08_L07
M08_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M08_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M08_L06
       xor       edx,edx
M08_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M08_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M08_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFDC240D320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M08_L01
; Total bytes of code 348
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M09_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M09_L02
       cmp       [rdi+8],ebx
       jne       short M09_L05
M09_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFDC29959E0]
       int       3
M09_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L03
       mov       rcx,rax
       jmp       short M09_L04
M09_L03:
       mov       rdx,7FFDC2B99088
       call      qword ptr [7FFDC2627AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M09_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M09_L00
M09_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M09_L06
       mov       rcx,rax
       jmp       short M09_L07
M09_L06:
       mov       rdx,7FFDC2B99088
       call      qword ptr [7FFDC2627AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M09_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFDC24057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M09_L00
; Total bytes of code 214
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M10_L02
       call      00007FFE2200B8A0
       cmp       dword ptr [7FFE2236F778],0
       jne       short M10_L01
M10_L00:
       add       rsp,28
       ret
M10_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L00
M10_L02:
       add       rsp,28
       jmp       qword ptr [7FFDC299DC80]
; Total bytes of code 49
```
```assembly
; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       mov       esi,r8d
       test      rcx,rcx
       je        short M11_L02
       mov       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       r11,[rcx]
       jne       short M11_L01
M11_L00:
       call      qword ptr [7FFE1E3A5100]
       test      rax,rax
       je        short M11_L03
       test      bl,bl
       sete      dl
       movzx     edx,dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M11_L01:
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       short M11_L00
M11_L02:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M11_L03:
       call      qword ptr [7FFE1E3A15F8]
       mov       rbx,rax
       call      qword ptr [7FFE1E3ABD58]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AA218]
       mov       rcx,rbx
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 149
```
```assembly
; System.Type.get_DefaultBinder()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFE1E397658]
       mov       rax,[rax]
       test      rax,rax
       je        short M12_L01
M12_L00:
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       call      qword ptr [7FFE1E3A1698]
       mov       rbx,rax
       call      qword ptr [7FFE1E397658]
       test      rax,rax
       jne       short M12_L02
       call      qword ptr [7FFE1E3AD468]
       int       3
M12_L02:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       test      rax,rax
       jne       short M12_L00
       call      qword ptr [7FFE1E397658]
       mov       rax,[rax]
       jmp       short M12_L00
; Total bytes of code 83
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       jne       short M13_L01
M13_L00:
       mov       rax,rdx
       ret
M13_L01:
       cmp       [rdx],rcx
       je        short M13_L00
       jmp       qword ptr [7FFDC240FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.String.Equals(System.String, System.String)
       sub       rsp,28
       cmp       rcx,rdx
       je        short M14_L01
       test      rcx,rcx
       je        short M14_L00
       test      rdx,rdx
       je        short M14_L00
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       je        short M14_L02
M14_L00:
       xor       eax,eax
       add       rsp,28
       ret
M14_L01:
       mov       eax,1
       add       rsp,28
       ret
M14_L02:
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M14_L03
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M14_L04
M14_L03:
       mov       rcx,rax
       call      qword ptr [7FFDC240FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M14_L04:
       nop
       add       rsp,28
       ret
; Total bytes of code 111
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
       jmp       qword ptr [7FFDC2405C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

