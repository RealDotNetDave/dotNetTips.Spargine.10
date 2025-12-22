## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
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
       mov       rbx,[rbx+18]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rax,[rbx+50]
       test      rax,rax
       je        near ptr M00_L42
       mov       rcx,1751BC00220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFCC6FF7468]; System.Text.Json.JsonSerializerOptions.get_Default()
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
       mov       rcx,1751BC01950
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M00_L45
M00_L03:
       cmp       [rdi],dil
       mov       r12,[rdi+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L17
       mov       r11,7FFCC67C0F10
       mov       rdx,1B5B0E619B8
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
       mov       rdx,1B5B0E619B8
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
       mov       r8,1B5B0E619B8
       mov       rcx,rdi
       call      qword ptr [7FFCC6D2C2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       call      qword ptr [7FFCC6FF77B0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,1B5B0E662A0
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
       mov       rsi,1B5B0E61518
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
       mov       r8,1B5B0E619B8
       mov       r11,7FFCC67C0F18
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-1C0]
       mov       r10,[rbp-1B8]
       je        short M00_L15
       mov       rcx,[r9+10]
       mov       [rbp-58],rcx
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,1B5B0E619B8
       mov       rax,[7FFCC67BA1C0]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L04
M00_L18:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r13d,r13d
       je        near ptr M00_L52
       mov       rcx,1751BC01DE8
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFCC7028F80]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r13,1B5B0E61518
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
       call      qword ptr [7FFCC687C9A8]; System.Object.GetType()
       mov       r9,1B5B0E619B8
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
       call      qword ptr [7FFCC6FF7918]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-128],rdx
M00_L26:
       mov       rcx,[rbp-1C8]
       cmp       [rcx],cl
       mov       rcx,[rbp-1C8]
       add       rcx,18
       lea       rdx,[rbp-138]
       call      qword ptr [7FFCC749C9F0]; System.Net.ArrayBuffer.get_ActiveSpan()
       mov       rdx,[rbp-138]
       mov       r8d,[rbp-130]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-148],xmm0
       lea       rcx,[rbp-148]
       call      qword ptr [7FFCC749CA08]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-148]
       vmovdqu   xmmword ptr [rbp-188],xmm0
       lea       rcx,[rbp-188]
       call      qword ptr [7FFCC6F45AE8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L34
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FFCC6FFDF08]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFCC6FFEE68]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-120]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6FFEE80]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L29:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6FFF7B0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFCC6DCC780]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFCC6FFF7E0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFCC6A050E8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFCC70C74B0]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-158],xmm0
       call      qword ptr [7FFCC70C7648]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-158]
       call      qword ptr [7FFCC70C76C0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-158]
       mov       edi,[rbp-150]
       mov       rcx,1751BC01CF0
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFCC6AFFBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L54
       mov       rcx,rax
       call      qword ptr [7FFCC6FDAA28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L35:
       mov       [rbp-1A8],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L37
       mov       r13,offset MT_System.Byte
       mov       rcx,1751BC00100
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
       call      qword ptr [7FFCC749CA20]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-170]
       vmovdqu   xmmword ptr [rbp-198],xmm0
       lea       r9,[rbp-198]
       mov       rdx,[rbp-1B0]
       mov       rcx,[rbp-1A8]
       mov       r8,1B5B0E71838
       call      qword ptr [7FFCC7325FE0]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L36
M00_L37:
       mov       rcx,[rbp-1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6AD0A18]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-1A8]
       mov       rcx,r14
       call      qword ptr [7FFCC6AFFBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCC6FF4BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L55
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFCC6FF4C00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L38:
       mov       [rbp-178],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-178]
       mov       rdx,7FFCC73497E8
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7326058]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFCC6FF7840]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L12
M00_L41:
       mov       eax,2
       jmp       near ptr M00_L13
M00_L42:
       call      qword ptr [7FFCC6F4E2B0]
       mov       ecx,74B
       mov       rdx,7FFCC6D98628
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
       mov       rdx,7FFCC6D98628
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6877858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC749C7C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC732DF20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,r15
       call      qword ptr [7FFCC6DC6F70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,r15
       call      qword ptr [7FFCC6DCC798]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC67BD050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,1751BC01950
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L46:
       mov       rcx,rax
       call      qword ptr [7FFCC7494D50]
       int       3
M00_L47:
       mov       rcx,rsi
       call      qword ptr [7FFCC6ED64F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L07
M00_L48:
       mov       rdx,[r15+20]
       mov       rcx,1B5B0E619B8
       call      qword ptr [7FFCC7494D68]
       int       3
M00_L49:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L50:
       mov       ecx,9
       call      qword ptr [7FFCC732DB18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L10
M00_L51:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1751BC024E0
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L52:
       mov       rax,1B5B0E662A0
       jmp       near ptr M00_L19
M00_L53:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1751BC024E0
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
       mov       rcx,1751BC01CF0
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6AFFBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-1A8]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCC6FF4BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L57
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFCC6FF4C00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
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
       call      qword ptr [7FFCC6FFF7E0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2990
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,1751BC01CC8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1751BC01CC8
       xor       edx,edx
       jmp       qword ptr [7FFCC6FF7480]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       mov       rcx,7FFCC74CA754
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M02_L03
       mov       rcx,r14
       call      qword ptr [7FFCC732E0D0]
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
       mov       rcx,7FFCC74CA76C
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
       mov       rcx,7FFCC74CA760
       call      CORINFO_HELP_COUNTPROFILE32
M02_L11:
       mov       rcx,7FFCC74CA770
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r14d
       mov       rcx,7FFCC74CA774
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15,[r15+18]
       test      r15,r15
       mov       r8,[rbp+10]
       jne       near ptr M02_L08
       jmp       near ptr M02_L05
M02_L12:
       mov       rdx,7FFCC74B70F8
       call      qword ptr [7FFCC687C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L13:
       mov       rdx,7FFCC74B60B8
       call      qword ptr [7FFCC687C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCC74B75C8
       call      qword ptr [7FFCC687C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L17:
       xor       ecx,ecx
       call      qword ptr [7FFCC732D140]
       int       3
M02_L18:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-50]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        short M02_L23
       mov       rcx,7FFCC74CA758
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
       mov       rdx,7FFCC74B7110
       call      qword ptr [7FFCC687C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FFCC74CA75C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L35
M02_L24:
       mov       rcx,7FFCC74CA764
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L30
M02_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L27:
       mov       rcx,7FFCC74CA768
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M02_L15
M02_L28:
       mov       rcx,7FFCC74CA778
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,1
       jmp       near ptr M02_L07
M02_L29:
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFCC6876850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L24
       mov       rcx,7FFCC74CA77C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
M02_L30:
       cmp       dword ptr [rbp-44],0
       je        short M02_L31
       mov       rcx,7FFCC74CA780
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
       call      00007FFD26476030
       test      eax,eax
       jne       short M02_L34
M02_L31:
       mov       rcx,7FFCC74CA784
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       or        ecx,edi
       jne       near ptr M02_L41
M02_L32:
       mov       rcx,7FFCC74CA78C
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
       call      qword ptr [7FFCC732D140]
       int       3
M02_L34:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFCC732DC68]
       jmp       short M02_L31
M02_L35:
       call      M02_L43
       jmp       near ptr M02_L02
M02_L36:
       mov       rcx,7FFCC74CA790
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
       mov       rdx,7FFCC74B7110
       call      qword ptr [7FFCC687C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,7FFCC74CA750
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       jmp       near ptr M02_L01
M02_L41:
       mov       rcx,7FFCC74CA788
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFCC70CCE40]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M02_L32
M02_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L43:
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M02_L44
       mov       rcx,7FFCC74CA780
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
       call      00007FFD26476030
       test      eax,eax
       je        short M02_L44
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC732DC68]
M02_L44:
       mov       rcx,7FFCC74CA784
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M02_L45:
       xor       ecx,ecx
       call      qword ptr [7FFCC732D140]
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
       mov       rcx,1B5B0E6FF88
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,1B5B0E61518
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,1B5B0E61518
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
       mov       rdx,7FFCC6E10548
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC7496C58]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       mov       ecx,38A0
       mov       rdx,7FFCC6E10548
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFCC7496C28]
       int       3
M03_L11:
       cmp       edx,9
       je        short M03_L12
       mov       ecx,38A0
       mov       rdx,7FFCC6E10548
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC7496C10]
       int       3
M03_L12:
       or        esi,8
       jmp       near ptr M03_L00
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FFCC6E10548
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC7496C40]
       int       3
M03_L14:
       mov       r8,1B5B0E61518
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
       mov       rcx,1751BC00C90
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
       call      qword ptr [7FFCC732DB18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC7495398]
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
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFCC67BB1B4],0
       je        short M04_L05
       call      qword ptr [7FFCC74953B0]
       mov       ebx,eax
       jmp       short M04_L07
M04_L05:
       mov       ecx,0C
       call      qword ptr [7FFCC74953C8]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFCC74953C8]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M04_L06
       call      qword ptr [7FFCC74953E0]
       mov       ebx,eax
       jmp       short M04_L07
M04_L06:
       sar       ebx,10
M04_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFCC67BB1A8]
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
       call      qword ptr [7FFCC6EDD5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFCC6876820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC7495398]
       jmp       near ptr M04_L01
M04_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L18
M04_L16:
       test      ebx,ebx
       jne       short M04_L17
       mov       rax,1B5B0E662A0
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
       mov       rdx,1B5B0E66F28
       call      qword ptr [7FFCC6AFD7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFCC6FF78E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC7495398]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFCC74953F8]
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
       call      qword ptr [7FFCC6875C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFCC687C9A8]; System.Object.GetType()
       mov       r9,1B5B0E619B8
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
       call      qword ptr [7FFCC6FF7918]
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
       call      qword ptr [7FFCC6FFDF08]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       jne       near ptr M06_L13
M06_L07:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6FFEE80]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M06_L08:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6FFF7B0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFCC6DCC780]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M06_L07
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M06_L07
; Total bytes of code 710
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
       call      qword ptr [7FFCC6A17138]
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
       mov       r8,1751BC013C0
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
       call      qword ptr [7FFCC6A14BB8]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFD264C8D20
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
       call      qword ptr [7FFCC6A14BE8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,1B5B0E60008
       jmp       short M09_L02
M09_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFCC6F4DBC0]
       int       3
M09_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFCC6F4E1C0]
       add       r14d,eax
       jns       near ptr M09_L00
       call      qword ptr [7FFCC6F4E1D8]
       int       3
M09_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFCC6F4DBC0]
       int       3
M09_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFCC6F45908]
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
       call      qword ptr [7FFCC6F4DBD8]
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
       call      qword ptr [7FFCC6F4E1F0]
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
       call      qword ptr [7FFDF377F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFDF377F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rcx,7FFCC7504010
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
       mov       rdx,7FFCC7503F08
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
       mov       rcx,7FFCC7504014
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFCC7504010
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FFCC7504018
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
       mov       rcx,7FFCC7504120
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L00
M11_L03:
       mov       rcx,7FFCC7504124
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,7FFCC7504128
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
       mov       rax,1751BC013E8
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
       call      qword ptr [7FFCC7496520]
       mov       rcx,[rbp+30]
M12_L04:
       test      byte ptr [rbx+7C],1
       jne       short M12_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFCC6FFF288]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M12_L07
M12_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFCC7496538]
       jmp       short M12_L07
M12_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFCC74964F0]
M12_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M12_L09
M12_L08:
       mov       rcx,rbx
       call      qword ptr [7FFCC6FFF498]
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
       call      qword ptr [7FFCC6FFEEB0]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M12_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFCC6F00D50]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M12_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFCC6FFF2E8]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFCC6FFF468]
       int       3
M12_L22:
       mov       rcx,rbx
       call      qword ptr [7FFCC6FFF498]
       jmp       near ptr M12_L10
M12_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M12_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFCC6F459E0]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFCC74964D8]
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
       call      qword ptr [7FFCC6FFF408]
       int       3
M12_L27:
       mov       rcx,r13
       call      qword ptr [7FFCC6ED64F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M12_L13
M12_L28:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFCC7496448]
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
       call      qword ptr [7FFCC7496460]
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
       call      qword ptr [7FFCC7496D00]
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
       call      qword ptr [7FFCC7496D18]
       test      rax,rax
       jne       near ptr M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFCC7496D30]
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
       mov       rdx,1B5B0E6EF48
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7496D60]
       test      eax,eax
       jne       short M12_L38
       jmp       short M12_L37
M12_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,1B5B0E6EEF8
       call      qword ptr [7FFCC6AF4EA0]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M12_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFCC7496D48]
       jmp       short M12_L38
M12_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFCC7496D78]
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
       call      qword ptr [7FFCC7497180]
       int       3
M13_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M13_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC75031F0]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC74971B0]
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
       call      qword ptr [7FFCC74971C8]
M13_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M13_L02
M13_L06:
       mov       r11,7FFCC67C0FD8
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
       call      qword ptr [7FFDF377E550]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       call      qword ptr [7FFDF377EFA0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M14_L04
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FFDF377E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M14_L00
M14_L08:
       cmp       byte ptr [r14+20],0
       je        short M14_L10
       jmp       short M14_L01
M14_L09:
       call      qword ptr [7FFDF377B218]
       jmp       short M14_L02
M14_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFDF377E560]
       mov       rbp,rax
       jmp       short M14_L03
M14_L11:
       cmp       byte ptr [rsp+70],0
       je        short M14_L04
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFDF377E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M14_L04
M14_L12:
       cmp       byte ptr [rsp+69],0
       je        short M14_L05
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFDF377D058]
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
       jmp       qword ptr [7FFCC732DF68]
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
       mov       rcx,1B5B0E662A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M16_L42
       cmp       dword ptr [rbx+8],0
       je        near ptr M16_L42
       mov       rcx,1751BC01DE8
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M16_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFCC732E0D0]
M16_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6AFCED0]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
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
       call      00007FFD26476270
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
       call      00007FFD26496A90
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
       call      qword ptr [7FFCC687E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L04
M16_L07:
       xor       ecx,ecx
       call      qword ptr [7FFCC732D140]
       int       3
M16_L08:
       mov       ecx,36
       call      qword ptr [7FFCC749CB28]
       int       3
M16_L09:
       mov       rcx,r12
       call      qword ptr [7FFCC749CB40]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L03
M16_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC749CB58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D25D88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M16_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M16_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFCC749CB70]
       jmp       near ptr M16_L05
M16_L13:
       mov       rcx,[rbp-88]
       call      00007FFD26476030
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
       call      qword ptr [7FFCC7496BF8]
M16_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFCC721DCC0],1
       je        near ptr M16_L48
M16_L18:
       cmp       byte ptr [7FFCC67BB1B4],0
       je        near ptr M16_L33
       call      qword ptr [7FFCC74953B0]
       mov       [rbp-60],eax
       mov       edx,[rbp-60]
M16_L19:
       test      byte ptr [7FFCC71F7AC0],1
       je        near ptr M16_L50
M16_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFCC67BB1A8]
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M16_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFCC732E0D0]
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
       call      00007FFD26476030
       test      eax,eax
       jne       near ptr M16_L51
M16_L25:
       cmp       dword ptr [rbp-64],0
       je        near ptr M16_L52
       mov       r13d,1
M16_L26:
       mov       rcx,1751BC00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M16_L42
       mov       rcx,rbx
       call      00007FFD26476270
       test      eax,eax
       je        near ptr M16_L37
       mov       [rbp-6C],eax
M16_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFD26476270
       test      eax,eax
       je        near ptr M16_L38
M16_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-6C]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFCC74954A0]
       test      r13d,r15d
       jne       near ptr M16_L42
       mov       rcx,rbx
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFD26476270
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
       mov       r15,1751BC01F38
       mov       r12,[r15]
       test      r12,r12
       jne       short M16_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1751BC01F30
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
       call      00007FFD264820C0
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
       call      qword ptr [7FFCC74953E0]
       mov       edx,eax
       jmp       near ptr M16_L19
M16_L36:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M16_L23
M16_L37:
       mov       rcx,rbx
       call      qword ptr [7FFCC687E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-6C],eax
       jmp       near ptr M16_L27
M16_L38:
       mov       rcx,rsi
       call      qword ptr [7FFCC687E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M16_L28
M16_L39:
       mov       rcx,rsi
       call      qword ptr [7FFCC687E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FFCC74954B8]
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
       call      qword ptr [7FFCC732DB18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M16_L00
M16_L44:
       mov       ecx,0A
       call      qword ptr [7FFCC732DB18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M16_L01
M16_L45:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFCC732DC68]
       jmp       near ptr M16_L14
M16_L46:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCC749CB88]
       jmp       near ptr M16_L32
M16_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCC7495470]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFCC6D25E30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M16_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M16_L18
M16_L49:
       mov       ecx,0C
       call      qword ptr [7FFCC74953C8]
       jmp       near ptr M16_L34
M16_L50:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M16_L20
M16_L51:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFCC732DC68]
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
       call      qword ptr [7FFCC732D140]
       int       3
M16_L56:
       mov       rcx,[rbp-88]
       call      00007FFD26476030
       test      eax,eax
       je        short M16_L57
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFCC732DC68]
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
       call      qword ptr [7FFCC687FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFCC687FAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFCC6EDE9D0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
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
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC732D140]
       int       3
M17_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFCC7495A58]
       add       r13d,eax
       jns       near ptr M17_L00
M17_L06:
       call      qword ptr [7FFCC6F4E1D8]
       int       3
M17_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFCC6F45908]
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
       call      qword ptr [7FFCC732EA78]
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
       mov       rax,7FFCC6FDE8E0
       mov       [rbp-70],rax
       lea       rax,[M18_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE142B3BE0
       call      rax
M18_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M18_L01
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFCC6DDF978
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC732D140]
       int       3
M18_L03:
       call      qword ptr [7FFCC7497318]
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
       mov       r11,7FFCC67C0FF0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M19_L02
M19_L17:
       call      qword ptr [7FFCC68757A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFCC68766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M19_L03
M19_L23:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC732C438]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M19_L03
M19_L24:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFCC67C0FF8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M19_L03
M19_L25:
       mov       rax,1B5B0E662A0
       jmp       near ptr M19_L04
M19_L26:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFCC70C76D8]
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
       jmp       qword ptr [7FFCC6AFFC48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      00007FFD2647FBA0
       cmp       rax,[rsp+28]
       jne       short M22_L02
M22_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M22_L01:
       call      qword ptr [7FFCC732D668]
       int       3
M22_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6FF4B40]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       sub       rsp,98
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
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
       jmp       near ptr M24_L07
M24_L01:
       mov       [rsp+88],r10d
       mov       [rsp+78],rdx
       movsxd    r8,r10d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M24_L18
       cmp       ecx,64
       jb        short M24_L03
       mov       r8,1B5B0E61234
M24_L02:
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
       jae       short M24_L02
M24_L03:
       cmp       ecx,0A
       jb        near ptr M24_L18
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r8,1B5B0E61234
       shl       ecx,2
       mov       r8d,[r8+rcx]
       mov       [rdx],r8d
M24_L04:
       xor       edx,edx
       mov       [rsp+78],rdx
       mov       r10d,1
M24_L05:
       xor       edx,edx
       mov       [rsp+78],rdx
M24_L06:
       test      r10d,r10d
       mov       [rsp+74],r9d
       mov       rdx,[rsp+38]
       je        near ptr M24_L45
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
       ja        near ptr M24_L62
       cmp       r8d,ecx
       ja        near ptr M24_L63
       add       r10d,[rsp+88]
       mov       [rsi+18],r10d
       cmp       dword ptr [rsp+90],0
       jne       near ptr M24_L43
M24_L07:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M24_L19
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
       call      qword ptr [7FFCC6AFC5D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+80],eax
       test      eax,eax
       jl        near ptr M24_L55
       mov       r10d,[rsp+84]
       cmp       eax,r10d
       ja        near ptr M24_L62
       test      eax,eax
       jne       near ptr M24_L23
M24_L08:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M24_L64
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       eax,r13d
       movzx     edx,word ptr [rbx+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M24_L27
       cmp       ecx,7B
       jne       near ptr M24_L56
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M24_L57
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       mov       r11d,ecx
       cmp       r11d,7D
       je        near ptr M24_L14
M24_L09:
       lea       ecx,[r11-30]
       cmp       ecx,9
       jbe       near ptr M24_L29
M24_L10:
       cmp       r11d,20
       je        near ptr M24_L30
       cmp       r11d,2C
       je        near ptr M24_L31
M24_L11:
       cmp       r11d,7D
       je        short M24_L14
       cmp       r11d,3A
       jne       near ptr M24_L59
       mov       r10d,r13d
       lea       r13d,[r10+1]
       cmp       r12d,r13d
       jbe       near ptr M24_L58
M24_L12:
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,7D
       je        short M24_L13
       cmp       r11d,7B
       je        near ptr M24_L59
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L12
       jmp       near ptr M24_L58
M24_L13:
       inc       r10d
       mov       r9d,r13d
       sub       r9d,r10d
       mov       ecx,r10d
       mov       r11d,r9d
       add       rcx,r11
       mov       r11d,r12d
       cmp       rcx,r11
       ja        near ptr M24_L60
       mov       ecx,r10d
       lea       r10,[rbx+rcx*2+0C]
       mov       r12,r10
       mov       r10d,r9d
       mov       r9d,r10d
       mov       r10,r12
M24_L14:
       inc       r13d
       xor       r12d,r12d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr M24_L61
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+38],rdx
       test      r15,r15
       jne       near ptr M24_L36
M24_L15:
       test      r12,r12
       jne       near ptr M24_L50
       mov       [rsp+90],eax
       test      eax,eax
       jne       short M24_L16
       mov       [rsp+94],r8d
       test      r8d,r8d
       jne       near ptr M24_L40
       mov       r8d,[rsp+94]
M24_L16:
       mov       rdx,[rsp+38]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M24_L17
       mov       r12,offset MT_System.Byte
       cmp       [rcx],r12
       jne       near ptr M24_L38
M24_L17:
       test      rcx,rcx
       mov       [rsp+28],r10
       mov       [rsp+94],r8d
       mov       [rsp+40],r11
       je        near ptr M24_L39
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
       ja        near ptr M24_L62
       mov       edx,r8d
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
       mov       r11,7FFD2566C108
       add       r10,[r11+r8*8]
       sar       r10,20
       cmp       r10d,r12d
       jle       near ptr M24_L01
       xor       r10d,r10d
       mov       [rsp+88],r10d
       jmp       near ptr M24_L05
M24_L18:
       lea       r8d,[rcx+30]
       mov       [rdx-2],r8w
       jmp       near ptr M24_L04
M24_L19:
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
M24_L20:
       mov       ecx,3B9
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rcx,rax
       call      qword ptr [7FFCC732D140]
       int       3
M24_L21:
       xor       edx,edx
       jmp       near ptr M24_L00
M24_L22:
       mov       rcx,rdi
       mov       r11,7FFCC67C1010
       mov       rdx,1B5B0E75AF0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M24_L00
M24_L23:
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       r10d,[rcx+rax]
       mov       [rsp+4C],r10d
       cmp       r10d,[r8+8]
       ja        short M24_L26
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        short M24_L24
       mov       r9,[rsp+30]
       movzx     r8d,word ptr [r9]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M24_L25
       movzx     r8d,word ptr [r9+2]
       mov       [rcx+2],r8w
       jmp       short M24_L25
M24_L24:
       mov       r9,[rsp+30]
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r9
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+80]
M24_L25:
       mov       r10d,[rsp+4C]
       mov       [rsi+18],r10d
       jmp       near ptr M24_L08
M24_L26:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       r8d,eax
       call      qword ptr [7FFCC6A1F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+80]
       jmp       near ptr M24_L08
M24_L27:
       mov       rcx,rsi
       call      qword ptr [7FFCC6A1F120]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M24_L07
M24_L28:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L09
M24_L29:
       cmp       edx,0F4240
       jl        short M24_L28
       jmp       near ptr M24_L10
M24_L30:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       near ptr M24_L10
M24_L31:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       cmp       r11d,20
       je        short M24_L31
       cmp       r11d,2D
       jne       short M24_L32
       mov       dword ptr [rsp+90],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       mov       eax,[rsp+90]
M24_L32:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M24_L57
       inc       r13d
       cmp       r12d,r13d
       ja        short M24_L34
       jmp       near ptr M24_L58
M24_L33:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+94],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+94]
       jbe       near ptr M24_L58
M24_L34:
       cmp       r13d,r12d
       jae       near ptr M24_L64
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M24_L35
       cmp       r8d,0F4240
       jl        short M24_L33
M24_L35:
       cmp       r11d,20
       jne       near ptr M24_L11
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M24_L58
       mov       r11d,r13d
       movzx     r11d,word ptr [rbx+r11*2+0C]
       jmp       short M24_L35
M24_L36:
       test      r9d,r9d
       mov       [rsp+90],eax
       mov       [rsp+94],r8d
       je        near ptr M24_L44
       mov       [rsp+28],r10
       mov       [rsp+60],r10
       mov       [rsp+74],r9d
       mov       [rsp+68],r9d
       lea       rcx,[rsp+60]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M24_L37:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       r8,[rsp+38]
       mov       r11,7FFCC67C1028
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+74]
       mov       r10,[rsp+28]
       mov       r11,[rsp+40]
       jmp       near ptr M24_L15
M24_L38:
       mov       [rsp+74],r9d
       mov       [rsp+28],r10
       mov       [rsp+94],r8d
       mov       [rsp+40],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+38]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+74]
       mov       r10,[rsp+28]
       mov       r11,[rsp+40]
       jmp       near ptr M24_L17
M24_L39:
       mov       [rsp+74],r9d
       jmp       near ptr M24_L45
M24_L40:
       mov       [rsp+74],r9d
       mov       [rsp+28],r10
       mov       [rsp+40],r11
       mov       rdx,[rsp+38]
       jmp       near ptr M24_L45
M24_L41:
       mov       r11,[rsp+28]
       mov       [rsp+60],r11
       mov       [rsp+74],r9d
       mov       [rsp+68],r9d
       mov       [rsp+50],rdx
       mov       [rsp+58],r12d
       lea       rdx,[rsp+88]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+60]
       lea       r9,[rsp+50]
       mov       r8,rdi
       call      qword ptr [7FFCC7326028]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r10d,eax
       mov       r9d,[rsp+74]
       jmp       near ptr M24_L06
M24_L42:
       mov       [rsp+50],rdx
       mov       [rsp+58],r12d
       mov       r12,[rsp+28]
       mov       [rsp+60],r12
       mov       [rsp+74],r9d
       mov       [rsp+68],r9d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+50]
       lea       r9,[rsp+60]
       lea       r8,[rsp+88]
       mov       r11,7FFCC67C1020
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r9d,[rsp+74]
       jmp       near ptr M24_L06
M24_L43:
       mov       r12d,[rsp+94]
       cmp       r12d,[rsp+88]
       jle       near ptr M24_L07
       mov       r8d,r12d
       sub       r8d,[rsp+88]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFCC7495F50]
       jmp       near ptr M24_L07
M24_L44:
       mov       [rsp+74],r9d
       mov       [rsp+28],r10
       jmp       near ptr M24_L37
M24_L45:
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        short M24_L47
       mov       ecx,[rsp+74]
       test      ecx,ecx
       je        short M24_L46
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       jne       short M24_L46
       mov       r10,[rsp+28]
       mov       [rsp+60],r10
       mov       [rsp+68],ecx
       lea       rcx,[rsp+60]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       [rsp+40],rdx
M24_L46:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+40]
       mov       r11,7FFCC67C1018
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M24_L49
M24_L47:
       mov       r12,[rsp+38]
       test      r12,r12
       jne       short M24_L48
       xor       r12d,r12d
       jmp       short M24_L49
M24_L48:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M24_L49:
       test      r12,r12
       jne       short M24_L52
       mov       r12,1B5B0E60008
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
M24_L50:
       mov       [rsp+94],r8d
       cmp       [r12+8],r8d
       jl        short M24_L53
M24_L51:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFCC6A1F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M24_L07
M24_L52:
       mov       eax,[rsp+90]
       mov       r8d,[rsp+94]
       jmp       short M24_L50
M24_L53:
       test      eax,eax
       je        short M24_L54
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFCC6A1F1C8]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFCC7495F50]
       jmp       near ptr M24_L07
M24_L54:
       mov       r8d,[rsp+94]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFCC7495F50]
       jmp       short M24_L51
M24_L55:
       mov       rbx,[rsp+30]
       mov       [rsp+60],rbx
       mov       ebx,[rsp+84]
       mov       [rsp+68],ebx
       lea       rdx,[rsp+60]
       mov       rcx,rsi
       call      qword ptr [7FFCC7495EF0]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M24_L19
M24_L56:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFCC7495F68]
       int       3
M24_L57:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFCC7495F68]
       int       3
M24_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFCC7495F68]
       int       3
M24_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFCC7495F68]
       int       3
M24_L60:
       mov       ecx,21
       call      qword ptr [7FFCC6AF7870]
       int       3
M24_L61:
       call      qword ptr [7FFCC7495F80]
       int       3
M24_L62:
       call      qword ptr [7FFCC6A17138]
       int       3
M24_L63:
       call      qword ptr [7FFCC7495F98]
       int       3
M24_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2454
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
       call      00007FFD264C8D20
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
       call      qword ptr [7FFCC6875818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B5B0E60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M25_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rbx,rax
       call      qword ptr [7FFCC732D680]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC6ED5F98]
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
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFCC732D110]
       int       3
M26_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rsi,rax
       call      qword ptr [7FFCC74965B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC6ED5F98]
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
       call      qword ptr [7FFCC7495F50]
       jmp       near ptr M26_L00
M26_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFCC7496A30]
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
       call      qword ptr [7FFCC6F4E490]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M26_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFCC6A14FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFD2647FBA0
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
       mov       rdx,7FFCC67B4000
       call      qword ptr [7FFCC6AF7738]
       mov       rsi,rax
       call      qword ptr [7FFCC74965B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC6ED5F98]
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
       call      qword ptr [7FFCC7495F50]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC7496A30]
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
       call      qword ptr [7FFCC6F4E490]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFCC6A14FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCC732D668]
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
       call      qword ptr [7FFCC6FF4C30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rcx,1751BC01DE8
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1751BC00C90
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
       call      qword ptr [7FFCC732DB18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M29_L00
M29_L05:
       mov       rcx,r13
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC7495398]
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
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFCC67BB1B4],0
       je        short M29_L07
       call      qword ptr [7FFCC74953B0]
       mov       ebp,eax
       jmp       short M29_L09
M29_L07:
       mov       ecx,0C
       call      qword ptr [7FFCC74953C8]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFCC74953C8]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M29_L08
       call      qword ptr [7FFCC74953E0]
       mov       ebp,eax
       jmp       short M29_L09
M29_L08:
       sar       ebp,10
M29_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC6875740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFCC67BB1A8]
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
       call      qword ptr [7FFCC6EDD5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFCC6876820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC7495398]
       jmp       near ptr M29_L01
M29_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M29_L20
M29_L18:
       test      ebp,ebp
       jne       short M29_L19
       mov       rdx,1B5B0E662A0
       jmp       near ptr M29_L02
M29_L19:
       mov       ecx,ebp
       mov       rdx,1B5B0E66F28
       call      qword ptr [7FFCC6AFD7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFCC6FF78E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M29_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M29_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC7495398]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DCC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFCC74953F8]
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
       call      qword ptr [7FFCC6A1DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCC74965C8]
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
       mov       rcx,1751BC01DE8
       mov       rcx,[rcx]
       call      qword ptr [7FFCC7028F80]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFCC6A1DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,1751BC01DE8
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
       jmp       qword ptr [7FFCC7028F88]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,1B5B0E60008
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
       call      qword ptr [7FFCC732E880]
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
       call      qword ptr [7FFDF37784E0]
       cmp       byte ptr [rax],0
       je        near ptr M31_L03
       call      qword ptr [7FFDF377EBF0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M31_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
M31_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L01:
       call      qword ptr [7FFDF377A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M31_L00
       call      qword ptr [7FFDF37784D8]
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
       call      qword ptr [7FFDF37802F8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFDF377EC20]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFDF377E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFDF377A6A0]
       test      rax,rax
       je        near ptr M31_L00
M31_L04:
       call      qword ptr [7FFDF377CE60]
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
       call      qword ptr [7FFDF377E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFDF377C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FFDF3779CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF377E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFDF3779CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF377B210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFDF377E578]
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
       call      qword ptr [7FFDF377B180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M34_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M34_L03
M34_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFDF377EF00]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M34_L04
M34_L03:
       mov       rcx,rax
       call      qword ptr [7FFDF377B218]
       jmp       short M34_L02
M34_L04:
       cmp       byte ptr [rbp-10],0
       je        short M34_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF377B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M34_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M34_L06:
       call      qword ptr [7FFDF377CE58]
       int       3
M34_L07:
       mov       rcx,rax
       call      qword ptr [7FFDF377B218]
       jmp       near ptr M34_L00
M34_L08:
       mov       rcx,rax
       call      qword ptr [7FFDF377E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M34_L01
       sub       rsp,28
       call      qword ptr [7FFDF377B210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FFDF3778258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M34_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDF377B188]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFD262F0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCC6875C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rax,[rbx+40]
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,2BE0E400220
       mov       r14,[rcx]
       mov       [rbp-48],rax
       call      qword ptr [7FFCC7027318]; System.Text.Json.JsonSerializerOptions.get_Default()
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
       mov       rcx,2BE0E401950
       mov       r9,[rcx]
       test      r9,r9
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCC67ED050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,2BE0E401950
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
M00_L03:
       mov       [rsp+20],rsi
       mov       rcx,rdi
       mov       rdx,7FFCC6E91E10
       mov       r8,2FEA32919B8
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6DFCCF0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
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
       call      qword ptr [7FFCC7027660]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,2FEA32962A0
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
       mov       rcx,2BE0E401DE8
       mov       rcx,[rcx]
       mov       edx,r13d
       call      qword ptr [7FFCC7058158]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r13,2FEA3291518
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
       mov       rsi,2FEA3291518
M00_L17:
       mov       ecx,[rsi+8]
       mov       [r12+30],ecx
       cmp       dword ptr [r12+78],0
       jne       near ptr M00_L12
       mov       dword ptr [r12+78],3E8
       jmp       near ptr M00_L12
M00_L18:
       mov       edx,r13d
       call      qword ptr [7FFCC70276F0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFCC68AC9A8]; System.Object.GetType()
       mov       r9,2FEA32919B8
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
       call      qword ptr [7FFCC68AC9A8]; System.Object.GetType()
       mov       r9,2FEA32919B8
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
       call      qword ptr [7FFCC6E78188]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
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
       call      qword ptr [7FFCC702F858]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-1C8]
       mov       eax,[rbp-1C0]
       mov       [rbp-208],rcx
       mov       [rbp-200],eax
       lea       rcx,[rbp-208]
       call      qword ptr [7FFCC6F75AE8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L41
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FFCC702DDB8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r15+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+11A],1
       jmp       near ptr M00_L22
M00_L29:
       mov       rcx,r15
       call      qword ptr [7FFCC702DDB8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFCC702ED18]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-1B8]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-118]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC702ED30]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC702F840]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFCC702ED18]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r15+158]
       mov       r9,[r15+0B8]
       lea       r8,[rbp-48]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC702ED30]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L33:
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFCC702F840]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFCC6DFC780]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFCC6DFC780]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFCC702F870]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFCC6A350E8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       rcx,rax
       call      qword ptr [7FFCC70F7570]; System.Security.Cryptography.SHA256.HashData(Byte[])
       mov       rcx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       call      qword ptr [7FFCC70F7EA0]; System.Linq.Enumerable.ToArray[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rdx,rax
       lea       rcx,[rbp-1D8]
       call      qword ptr [7FFCC70F7F18]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rsi,[rbp-1D8]
       mov       edi,[rbp-1D0]
       mov       rcx,2BE0E401CF0
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFCC6B2FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rax],rcx
       jne       near ptr M00_L57
       mov       rcx,rax
       call      qword ptr [7FFCC7009E50]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M00_L42:
       mov       [rbp-228],r15
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M00_L44
       mov       r13,offset MT_System.Byte
       mov       rcx,2BE0E400100
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
       call      qword ptr [7FFCC74BDC68]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon ByRef)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-218],xmm0
       lea       r9,[rbp-218]
       mov       rdx,[rbp-230]
       mov       rcx,[rbp-228]
       mov       r8,2FEA32A1858
       call      qword ptr [7FFCC7346838]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M00_L43
M00_L44:
       mov       rcx,[rbp-228]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6B00A18]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15,[rbp-228]
       mov       rcx,r14
       call      qword ptr [7FFCC6B2FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCC7024AB0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rdi],rcx
       jne       near ptr M00_L58
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFCC7024AC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L45:
       mov       [rbp-1F8],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-1F8]
       mov       rdx,7FFCC7393528
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7346898]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,2FEA32919B8
       call      qword ptr [7FFCC74B5680]
       int       3
M00_L47:
       call      qword ptr [7FFCC6F7E178]
       mov       ecx,74B
       mov       rdx,7FFCC6DC8628
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
       mov       rdx,7FFCC6DC8628
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC68A7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCC74BDA40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC734E850]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       mov       rcx,r15
       call      qword ptr [7FFCC6DF6F70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L49:
       mov       rcx,r15
       call      qword ptr [7FFCC6DFC798]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L50:
       call      qword ptr [7FFCC74B5668]
       int       3
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FFCC6F064F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L04
M00_L52:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L53:
       mov       ecx,9
       call      qword ptr [7FFCC734E448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L54:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BE24400540
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L55:
       mov       rax,2FEA32962A0
       jmp       near ptr M00_L09
M00_L56:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BE24400540
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
       mov       rcx,2BE0E401CF0
       mov       r14,[rcx]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6B2FBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       r15,[rbp-228]
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCC7024AB0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       short M00_L59
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFCC7024AC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
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
       call      qword ptr [7FFCC702F870]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,38
       ret
; Total bytes of code 3132
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,2BE0E401CC8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,2BE0E401CC8
       xor       edx,edx
       jmp       qword ptr [7FFCC7027330]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       call      qword ptr [7FFDF3779CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF377E4F0]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFDF3779CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF377B210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFDF377E578]
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
       call      qword ptr [7FFCC6D56418]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L09
M03_L03:
       mov       rcx,7FFCC7502488
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
       mov       rdx,7FFCC74E91A8
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFCC74E9190
       call      qword ptr [7FFCC6B27AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,7FFCC7502370
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,1
       mov       rdx,7FFCC6CE1508
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC6F06268]
       int       3
M03_L08:
       mov       rcx,7FFCC7502374
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,0B80
       mov       rdx,7FFCC6CE1508
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC6F06268]
       int       3
M03_L09:
       mov       rcx,7FFCC7502378
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,r14
       mov       rdx,7FFCC7502380
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
       call      qword ptr [7FFCC6D5C2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,2FEA329FF88
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,2FEA3291518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,2FEA3291518
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
       mov       rdx,7FFCC6E40548
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC74B7E70]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       mov       ecx,38A0
       mov       rdx,7FFCC6E40548
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFCC74B7E40]
       int       3
M04_L11:
       cmp       edx,9
       je        short M04_L12
       mov       ecx,38A0
       mov       rdx,7FFCC6E40548
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC74B7E28]
       int       3
M04_L12:
       or        esi,8
       jmp       near ptr M04_L00
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFCC6E40548
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC74B7E58]
       int       3
M04_L14:
       mov       r8,2FEA3291518
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
       mov       rcx,2BE0E400C90
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
       call      qword ptr [7FFCC734E448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC74B5C20]
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
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFCC67EB1B4],0
       je        short M05_L05
       call      qword ptr [7FFCC74B5C38]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0C
       call      qword ptr [7FFCC74B5C50]
       mov       ebx,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFCC74B5C50]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FFCC74B5C68]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFCC67EB1A8]
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
       call      qword ptr [7FFCC6F0D500]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC74B5C20]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,2FEA32962A0
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
       mov       rdx,2FEA3296F28
       call      qword ptr [7FFCC6B2D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFCC7027798]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFCC74B5C20]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFCC74B5C80]
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
       mov       rcx,2BE0E401DE8
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,2BE0E400C90
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
       call      qword ptr [7FFCC734E448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC74B5C20]
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
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFCC67EB1B4],0
       je        short M06_L07
       call      qword ptr [7FFCC74B5C38]
       mov       ebp,eax
       jmp       short M06_L09
M06_L07:
       mov       ecx,0C
       call      qword ptr [7FFCC74B5C50]
       mov       ebp,[rax+10]
       mov       ecx,0C
       call      qword ptr [7FFCC74B5C50]
       lea       ecx,[rbp-1]
       mov       [rax+10],ecx
       movzx     eax,bp
       test      eax,eax
       jne       short M06_L08
       call      qword ptr [7FFCC74B5C68]
       mov       ebp,eax
       jmp       short M06_L09
M06_L08:
       sar       ebp,10
M06_L09:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebp
       xor       edx,edx
       div       dword ptr [7FFCC67EB1A8]
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
       call      qword ptr [7FFCC6F0D500]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFCC68A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC74B5C20]
       jmp       near ptr M06_L01
M06_L17:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L20
M06_L18:
       test      ebp,ebp
       jne       short M06_L19
       mov       rdx,2FEA32962A0
       jmp       near ptr M06_L02
M06_L19:
       mov       ecx,ebp
       mov       rdx,2FEA3296F28
       call      qword ptr [7FFCC6B2D7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFCC7027798]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFCC74B5C20]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFCC74B5C80]
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
       call      qword ptr [7FFCC6A4DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFCC74B77E0]
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
       mov       rcx,2BE0E401DE8
       mov       rcx,[rcx]
       call      qword ptr [7FFCC7058158]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFCC6A4DF08]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,2BE0E401DE8
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
       jmp       qword ptr [7FFCC7058160]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFCC68A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFCC68AC9A8]; System.Object.GetType()
       mov       r9,2FEA32919B8
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
       call      qword ptr [7FFCC6E78188]
M08_L05:
       nop
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L06:
       mov       rdx,7FFCC752E988
       call      qword ptr [7FFCC68AC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,rsi
       call      qword ptr [7FFCC702DDB8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFCC702ED30]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L10:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFCC702F840]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFCC6DFC780]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFCC6A47138]
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
       mov       r8,2BE0E4013C0
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
       call      qword ptr [7FFCC6A44BB8]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFD264C8D20
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
       call      qword ptr [7FFCC6A44BE8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       mov       r15,2FEA3290008
M10_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFCC6F7DBC0]
       int       3
M10_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFCC734C4C8]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FFCC734C4E0]
       int       3
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFCC6F7DBC0]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFCC6F75908]
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
       call      qword ptr [7FFCC6F7DBD8]
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
       call      qword ptr [7FFCC734C4F8]
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
       call      qword ptr [7FFDF377F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFDF377F038]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rax,2BE0E4013E8
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
       call      qword ptr [7FFCC74B7738]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFCC702F138]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFCC74B7750]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFCC702F198]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FFCC702F528]
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
       call      qword ptr [7FFCC702ED60]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFCC6F30D50]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFCC702F2D0]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFCC702F4F8]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FFCC702F528]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFCC6F759E0]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFCC74B7708]
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
       call      qword ptr [7FFCC702F498]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FFCC6F064F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFCC74B7678]
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
       call      qword ptr [7FFCC74B7690]
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
       call      qword ptr [7FFCC74B7F18]
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
       call      qword ptr [7FFCC74B7F30]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFCC74B7F48]
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
       mov       rdx,2FEA329EF48
       cmp       [rcx],ecx
       call      qword ptr [7FFCC74B7F78]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2FEA329EEF8
       call      qword ptr [7FFCC6B24EA0]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFCC74B7F60]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFCC74B7F90]
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
       call      qword ptr [7FFCC74BC3A8]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7548F98]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC74BC3D8]
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
       call      qword ptr [7FFCC74BC3F0]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FFCC67F1018
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
       mov       rcx,2BE0E401950
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
       mov       r11,7FFCC67F0C30
       call      qword ptr [r11]
M15_L02:
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFCC6D56418]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       mov       rcx,7FFCC75022C0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [r14+119],2
       jne       short M15_L09
M15_L06:
       test      r14,r14
       je        near ptr M15_L21
M15_L07:
       mov       rcx,7FFCC75022D8
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
       call      qword ptr [7FFCC6F064F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M15_L06
M15_L10:
       mov       rcx,rsi
       call      qword ptr [7FFCC6DFC798]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M15_L00
M15_L11:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFCC67ED050
       call      qword ptr [7FFCC68A6EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2BE0E401950
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M15_L01
M15_L12:
       mov       ecx,1
       mov       rdx,7FFCC6CE1508
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC6F06268]
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
       call      qword ptr [7FFCC6D5C2D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M15_L03
M15_L14:
       cmp       byte ptr [r8+20],0
       je        short M15_L16
       jmp       near ptr M15_L04
M15_L15:
       call      qword ptr [7FFCC74B5668]
       int       3
M15_L16:
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFCC74B6148]
       mov       r14,rax
       jmp       near ptr M15_L05
M15_L17:
       mov       rcx,7FFCC75022C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L18:
       mov       rcx,7FFCC75022C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L19:
       mov       rcx,7FFCC75022CC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L07
M15_L20:
       cmp       byte ptr [rbp+30],0
       je        short M15_L18
       mov       rcx,7FFCC75022D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCC6DFCD38]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M15_L06
M15_L21:
       cmp       byte ptr [rbp+29],0
       je        short M15_L19
       mov       rcx,7FFCC75022D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFCC74B5680]
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
       jmp       qword ptr [7FFCC734E898]
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
       mov       rcx,2FEA32962A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L42
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L42
       mov       rcx,2BE0E401DE8
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-88]
       call      qword ptr [7FFCC734EA00]
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFCC6B2CED0]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
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
       call      00007FFD26476270
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
       call      00007FFD26496A90
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
       call      qword ptr [7FFCC68AE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FFCC734DA88]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FFCC74BDD88]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FFCC74BDDA0]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCC74BDDB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC6D55D88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFCC74BDDD0]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-88]
       call      00007FFD26476030
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
       call      qword ptr [7FFCC74B7E10]
M17_L17:
       mov       r13,[rax+8]
       test      byte ptr [7FFCC725A420],1
       je        near ptr M17_L48
M17_L18:
       cmp       byte ptr [7FFCC67EB1B4],0
       je        near ptr M17_L33
       call      qword ptr [7FFCC74B5C38]
       mov       [rbp-60],eax
       mov       edx,[rbp-60]
M17_L19:
       test      byte ptr [7FFCC7244298],1
       je        near ptr M17_L50
M17_L20:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFCC67EB1A8]
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M17_L22
       mov       rcx,[rbp-98]
       call      qword ptr [7FFCC734EA00]
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
       call      00007FFD26476030
       test      eax,eax
       jne       near ptr M17_L51
M17_L25:
       cmp       dword ptr [rbp-64],0
       je        near ptr M17_L52
       mov       r13d,1
M17_L26:
       mov       rcx,2BE0E400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L42
       mov       rcx,rbx
       call      00007FFD26476270
       test      eax,eax
       je        near ptr M17_L37
       mov       [rbp-6C],eax
M17_L27:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFD26476270
       test      eax,eax
       je        near ptr M17_L38
M17_L28:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-6C]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFCC74B5DA0]
       test      r13d,r15d
       jne       near ptr M17_L42
       mov       rcx,rbx
       call      qword ptr [7FFCC6DFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFD26476270
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
       mov       r15,2BE0E401F38
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L31
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,2BE0E401F30
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
       call      00007FFD264820C0
       test      rax,rax
       je        near ptr M17_L46
M17_L32:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M17_L15
M17_L33:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       call      qword ptr [7FFCC74B5C68]
       mov       edx,eax
       jmp       near ptr M17_L19
M17_L36:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M17_L23
M17_L37:
       mov       rcx,rbx
       call      qword ptr [7FFCC68AE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-6C],eax
       jmp       near ptr M17_L27
M17_L38:
       mov       rcx,rsi
       call      qword ptr [7FFCC68AE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L28
M17_L39:
       mov       rcx,rsi
       call      qword ptr [7FFCC68AE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FFCC74B5DB8]
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
       call      qword ptr [7FFCC734E448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L44:
       mov       ecx,0A
       call      qword ptr [7FFCC734E448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L45:
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFCC734E598]
       jmp       near ptr M17_L14
M17_L46:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCC74BDDE8]
       jmp       near ptr M17_L32
M17_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCC74B5D70]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFCC6D55E30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M17_L18
M17_L49:
       mov       ecx,0C
       call      qword ptr [7FFCC74B5C50]
       jmp       near ptr M17_L34
M17_L50:
       mov       [rbp-60],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFCC68A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-60]
       jmp       near ptr M17_L20
M17_L51:
       mov       ecx,eax
       mov       rdx,[rbp-98]
       call      qword ptr [7FFCC734E598]
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
       call      qword ptr [7FFCC734DA88]
       int       3
M17_L56:
       mov       rcx,[rbp-88]
       call      00007FFD26476030
       test      eax,eax
       je        short M17_L57
       mov       ecx,eax
       mov       rdx,[rbp-88]
       call      qword ptr [7FFCC734E598]
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
       call      qword ptr [7FFCC68AFAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFCC68AFAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFCC6F0E9D0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
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
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC734DA88]
       int       3
M18_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFCC74B6A30]
       add       r13d,eax
       jns       near ptr M18_L00
M18_L06:
       call      qword ptr [7FFCC734C4E0]
       int       3
M18_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFCC6F75908]
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
       call      qword ptr [7FFCC734F390]
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
       mov       rax,7FFCC700DD08
       mov       [rbp-70],rax
       lea       rax,[M19_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE142B3BE0
       call      rax
M19_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFD267DF778],0
       je        short M19_L01
       call      qword ptr [7FFD267CD608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,7FFCC6E0F978
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC734DA88]
       int       3
M19_L03:
       call      qword ptr [7FFCC74BC540]
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
       mov       r11,7FFCC67F1030
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M20_L02
M20_L16:
       call      qword ptr [7FFCC68A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFCC68A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M20_L03
M20_L22:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFCC734CDF8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M20_L03
M20_L23:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFCC67F1038
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M20_L03
M20_L24:
       mov       rax,2FEA32962A0
       jmp       near ptr M20_L04
M20_L25:
       mov       rcx,rbx
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFCC70F7F30]
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
       jmp       qword ptr [7FFCC6B2FC48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      00007FFD2647FBA0
       cmp       rax,[rsp+28]
       jne       short M23_L02
M23_L00:
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M23_L01:
       call      qword ptr [7FFCC734DF98]
       int       3
M23_L02:
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFCC7024A08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       r11,7FFD2566C108
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
       mov       r8,2FEA3291234
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
       mov       r8,2FEA3291234
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
       call      qword ptr [7FFCC6B2C5D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rcx,rax
       call      qword ptr [7FFCC734DA88]
       int       3
M25_L21:
       xor       edx,edx
       jmp       near ptr M25_L00
M25_L22:
       mov       rcx,rdi
       mov       r11,7FFCC67F1050
       mov       rdx,2FEA32A5FC0
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
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+90]
M25_L25:
       mov       r10d,[rsp+5C]
       mov       [rsi+18],r10d
       jmp       near ptr M25_L13
M25_L26:
       mov       rcx,rsi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FFCC6A4F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+90]
       jmp       near ptr M25_L13
M25_L27:
       mov       rcx,rsi
       call      qword ptr [7FFCC6A4F120]; System.Text.StringBuilder.Append(Char)
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
       mov       r11,7FFCC67F1068
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
       call      qword ptr [7FFCC7346880]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
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
       mov       r11,7FFCC67F1060
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
       call      qword ptr [7FFCC74B71C8]
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
       mov       r11,7FFCC67F1058
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
       mov       r12,2FEA3290008
       mov       eax,[rsp+0A0]
       mov       r8d,[rsp+0A4]
M25_L51:
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       jl        short M25_L54
M25_L52:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFCC6A4F1C8]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFCC6A4F1C8]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFCC74B71C8]
       jmp       near ptr M25_L12
M25_L55:
       mov       r8d,[rsp+0A4]
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFCC74B71C8]
       jmp       short M25_L52
M25_L56:
       mov       rbx,[rsp+38]
       mov       [rsp+70],rbx
       mov       ebx,[rsp+94]
       mov       [rsp+78],ebx
       lea       rdx,[rsp+70]
       mov       rcx,rsi
       call      qword ptr [7FFCC74B7168]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M25_L19
M25_L57:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFCC74B71E0]
       int       3
M25_L58:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFCC74B71E0]
       int       3
M25_L59:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFCC74B71E0]
       int       3
M25_L60:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFCC74B71E0]
       int       3
M25_L61:
       mov       ecx,21
       call      qword ptr [7FFCC6B27870]
       int       3
M25_L62:
       call      qword ptr [7FFCC74B71F8]
       int       3
M25_L63:
       call      qword ptr [7FFCC6A47138]
       int       3
M25_L64:
       call      qword ptr [7FFCC74B7210]
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
       call      00007FFD264C8D20
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
       call      qword ptr [7FFCC68A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2FEA3290008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M26_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rbx,rax
       call      qword ptr [7FFCC734DFB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCC6F05F98]
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
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFCC734DA58]
       int       3
M27_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rsi,rax
       call      qword ptr [7FFCC74B77C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC6F05F98]
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
       call      qword ptr [7FFCC74B71C8]
       jmp       near ptr M27_L00
M27_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFCC74B7C48]
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
       call      qword ptr [7FFCC6F7E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M27_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFD2647FBA0
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
       mov       rdx,7FFCC67E4000
       call      qword ptr [7FFCC6B27738]
       mov       rsi,rax
       call      qword ptr [7FFCC74B77C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC6F05F98]
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
       call      qword ptr [7FFCC74B71C8]
       jmp       near ptr M28_L00
M28_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC74B7C48]
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
       call      qword ptr [7FFCC6F7E358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M28_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFCC6A44FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFCC734DF98]
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
       call      qword ptr [7FFCC7024AF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       mov       rax,2FEA3290008
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
       call      qword ptr [7FFCC734F198]
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
       call      qword ptr [7FFDF37784E0]
       cmp       byte ptr [rax],0
       je        near ptr M31_L03
       call      qword ptr [7FFDF377EBF0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M31_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
M31_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M31_L01:
       call      qword ptr [7FFDF377A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M31_L00
       call      qword ptr [7FFDF37784D8]
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
       call      qword ptr [7FFDF37802F8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFDF377EC20]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFDF3778278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFDF377E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFDF377A6A0]
       test      rax,rax
       je        near ptr M31_L00
M31_L04:
       call      qword ptr [7FFDF377CE60]
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
       call      qword ptr [7FFDF377E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFDF377C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFD263B9E20
       test      eax,eax
       jne       short M33_L01
       mov       rcx,rsi
       call      qword ptr [7FFCC734EA00]
M33_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M33_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M33_L03
       mov       rcx,7FFCC750AA30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFCC6F06508]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M33_L04
M33_L02:
       xor       ecx,ecx
       call      qword ptr [7FFCC734DA88]
       int       3
M33_L03:
       mov       rcx,7FFCC750AA2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFCC74B5668]
       int       3
M33_L04:
       mov       rcx,7FFCC750AA34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFD26476030
       test      eax,eax
       jne       near ptr M33_L10
M33_L05:
       mov       rcx,7FFCC750AA38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFCC750AA3C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M33_L06:
       call      qword ptr [7FFCC74B6760]
       int       3
M33_L07:
       mov       rcx,7FFCC750AA28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFCC74B5668]
       int       3
M33_L08:
       mov       rcx,rbx
       call      qword ptr [7FFCC6DFC7C8]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M33_L09
       call      qword ptr [7FFCC734DF98]
       int       3
M33_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFD2647FBA0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M33_L00
M33_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFCC734E598]
       jmp       near ptr M33_L05
       sub       rsp,28
       call      qword ptr [7FFCC74B6778]
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
       mov       rcx,7FFCC750AA34
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M33_L11
       xor       ecx,ecx
       call      qword ptr [7FFCC734DA88]
       int       3
M33_L11:
       mov       rcx,[rbp-20]
       call      00007FFD26476030
       test      eax,eax
       je        short M33_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFCC734E598]
M33_L12:
       mov       rcx,7FFCC750AA38
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
       call      qword ptr [7FFD262F0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFCC68A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

